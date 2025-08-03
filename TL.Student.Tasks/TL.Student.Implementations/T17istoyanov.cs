using System;
using System.Collections.Generic;
using System.Linq;
using TL.Student.Interfaces;

namespace TL.Student.Implementations;

public class T17istoyanov : IT17
{
    private int n;
    private int[][] sq;
    private List<(int r, int c)> empties;
    private HashSet<int> used;
    private int targetSum;

    public int[][] Solve(int[][] ms)
    {
        n = ms.Length;
        sq = ms.Select(r => (int[])r.Clone()).ToArray();


        empties = new List<(int, int)>();
        used = new HashSet<int>();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (sq[i][j] == 0)
                    empties.Add((i, j));
                else
                    used.Add(sq[i][j]);
            }
        }


        for (int sum = 15; sum <= 500; sum++)
        {
            targetSum = sum;
            
            foreach (var (r, c) in empties)
                sq[r][c] = 0;


            if (Backtrack(0))
                return sq;
        }

        throw new Exception("No solution found.");
    }

    private bool Backtrack(int idx)
    {
        if (idx == empties.Count)
            return IsMagic();

        var (r, c) = empties[idx];


        for (int val = 1; val < targetSum; val++)
        {
            if (used.Contains(val)) continue;

            sq[r][c] = val;
            used.Add(val);


            if (IsPartialValid(r, c) && Backtrack(idx + 1))
                return true;


            used.Remove(val);
            sq[r][c] = 0;
        }

        return false;
    }

    private bool IsPartialValid(int row, int col)
    {
        if (sq[row].All(x => x != 0) && sq[row].Sum() != targetSum)
            return false;


        int colSum = 0;
        bool colFull = true;
        for (int i = 0; i < n; i++)
        {
            if (sq[i][col] == 0) colFull = false;
            colSum += sq[i][col];
        }

        if (colFull && colSum != targetSum)
            return false;


        if (row == col)
        {
            int d1 = 0;
            bool full1 = true;
            for (int i = 0; i < n; i++)
            {
                if (sq[i][i] == 0) full1 = false;
                d1 += sq[i][i];
            }

            if (full1 && d1 != targetSum)
                return false;
        }


        if (row + col == n - 1)
        {
            int d2 = 0;
            bool full2 = true;
            for (int i = 0; i < n; i++)
            {
                if (sq[i][n - 1 - i] == 0) full2 = false;
                d2 += sq[i][n - 1 - i];
            }

            if (full2 && d2 != targetSum)
                return false;
        }

        return true;
    }

    public bool IsMagic()
    {
        IsValidMatrix(sq);

        int size = sq.Length;

        List<int> rowSumsMs1 = Enumerable.Repeat(0, size).ToList();
        List<int> colSumsMs1 = Enumerable.Repeat(0, size).ToList();
        int diagSumMs1 = 0;
        int antiDiagSumMs1 = 0;


        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                rowSumsMs1[row] += sq[row][col];
                colSumsMs1[col] += sq[row][col];
            }
        }

        for (int i = 0; i < size; i++)
        {
            diagSumMs1 += sq[i][i];
            antiDiagSumMs1 += sq[i][size - 1 - i];
        }

        bool isMs1Magic = rowSumsMs1.All(s => s == rowSumsMs1[0]) &&
                          colSumsMs1.All(s => s == colSumsMs1[0]) &&
                          diagSumMs1 == rowSumsMs1[0] &&
                          antiDiagSumMs1 == rowSumsMs1[0];

        return isMs1Magic;
    }

    private static void IsValidMatrix(int[][] matrix)
    {
        if (matrix == null)
            throw new ArgumentNullException("Matrix cannot be null");
        if (matrix.Length == 0 || matrix.Any(row => row == null || row.Length != matrix.Length))
            throw new ArgumentException("Matrix must be non-empty and square");

        var ms1Elements = matrix.SelectMany(row => row).ToList();

        if (ms1Elements.Count != ms1Elements.Distinct().Count())
            throw new ArgumentException("Matrix ms1 contains duplicate elements. Not a valid magic square.");
    }
}