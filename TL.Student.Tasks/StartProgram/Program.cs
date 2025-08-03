using TL.Student.Interfaces;
using TL.Student.Implementations;

namespace StartProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            //IT01 calc = new T01istoyanov()
            //    .Interval(1, 15)
            //    .Multiple(3)
            //    .Multiple(5);
            //Console.Write(calc.Calculate());

            //IT02 c = new T02istoyanov()
            //    .Limit(10);

            //IT04 c = new T04istoyanov()
            //    .Interval(10, 30);
            //Console.Write(c.Calculate());
            //var t05 = new T05istoyanov();
            //Dictionary<int, int> dic = t05.PrimeFactor(60);
            //foreach (var item in dic)
            //{
            //    Console.WriteLine($"{item.Key}={item.Value}");
            //}

            //var c = new T06istoyanov()
            //.Interval(1, 10);

            //var c = new T07istoyanov()
            //    .Interval(1, 100);
            //Console.Write(c.Calculate());

            // var c = new T08istoyanov().Init(5, 5).DefaultValue(10).Value(1,0, 69).Calculate();
            // var c = new T09istoyanov().Limit(100).Calculate();
            // var c = new T10istoyanov().Limit(100).Calculate();
            // var c = new T11istoyanov().Calculate(10,20); 
            // foreach (var item in c)
            // {   
            //     Console.WriteLine(item);
            //}

            // var c = new T12istoyanov().Calculate(2);
            // Console.WriteLine(c);
            //var c = new T13istoyanov().Calculate();
            //var c = new T14istoyanov().Calculate();
            //foreach (var item in c)
            //{

            //    Console.WriteLine(item);
            //}
            int[][] ms1 = new int[][]
            {
                new int[] { 8, 1, 6 },
                new int[] { 3, 5, 7 },
                new int[] { 4, 9, 2 }
            };
            int[][] ms2 = new int[][]
            {
                new int[] { 2, 7, 6 },
                new int[] { 9, 5, 1 },
                new int[] { 4, 3, 8 }
            };
            
            var res = new T15istoyanov();
            Console.WriteLine("result: " + res.Value(ms1, ms2));

            //
            // int[][] magicSquare = new int[][]
            // {
            //     new int[] { 2,7,6 },
            //     new int[] { 9,5,1 },
            //     new int[] { 4,3,8 }
            // };  
            //
            //
            // int seed = 5; 
            // var magic = new T16istoyanov();
            //
            // // Make a deep copy to preserve the original
            // int[][] originalCopy = magicSquare.Select(row => row.ToArray()).ToArray();
            //
            // int[][] randomized = magic.Randomize(magicSquare, seed);
            //
            // Console.WriteLine("Original Square:");
            // PrintMatrix(originalCopy);
            //
            // Console.WriteLine($"\nRandomized Square (Seed: {seed}):");
            // PrintMatrix(randomized);
            
            
            
            IT17 solver = new T17istoyanov();

            int[][] puzzle = new int[][]
            {
                new int[] { 0, 28, 0 },
                new int[] { 36, 0, 4 },
                new int[] { 0, 12, 32 }
            };

            Console.WriteLine("Input:");
            PrintMatrix(puzzle);

            var result = solver.Solve(puzzle);

            Console.WriteLine("Solved:");
            PrintMatrix(result);
            
            
        }
        static void PrintMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }
    }
}