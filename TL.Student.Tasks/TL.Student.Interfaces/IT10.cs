namespace TL.Student.Interfaces
{

    public interface IT10
    {
        /// <summary>
        /// Sets the upper limit for the sum of A, B, and C.
        /// </summary>
        /// <param name="limit">The upper limit to set</param>
        /// <returns>The same object</returns>
        IT10 Limit(int limit);
        /// <summary>
        /// Calculates the number of triples (A, B, C) such that 0 < A <= B < C, A^2 + B^2 = C^2,
        //and A + B + C <= X.
        /// </summary>
        /// <returns>The count of such triples</returns>
        int Calculate();
    }
}