namespace TL.Student.Interfaces
{
    /// Примерен вход:
    /// -- ->
    /// +---+---+---+---+
    /// | 1 | 2 | 3 | 4 |
    /// +---+---+---+---+ -- ->
    /// A | 12| 13| 14| 5 | | +---+---+
    /// | +---+---+---+---+ | A | 13| 14| |
    /// | | 11| 16| 15| 6 | | | +---+---+ |
    /// | +---+---+---+---+ V | | 16| 15| V
    /// | 10| 9 | 8 | 7 | +---+---+
    /// +---+---+---+---+ <- --
    /// <- --
    ///
    /// Примерен изход:
    /// +---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+
    /// | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10| 11| 12| 13| 14| 15| 16|
    /// +---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+
    /// </summary>
    public interface IT08
    {
        /// <summary>
        /// Initializes the matrix with the specified number of rows and columns.
        /// </summary>
        /// <param name="rows">Number of rows</param>
        /// <param name="columns">Number of columns</param>
        /// <returns>The same object</returns>
        IT08 Init(int rows, int columns);
        /// <summary>
        /// Sets a default value for the cells if not explicitly set.
        /// </summary>
        /// <param name="value">Default value for cells</param>
        /// <returns>The same object</returns>
        IT08 DefaultValue(int value);
        /// <summary>
        /// Sets an explicit value for a specific cell.
        /// </summary>
        /// <param name="iRow">Row index</param>
        /// <param name="iCol">Column index</param>
        /// <param name="value">Value to set</param>
        /// <returns>The same object</returns>
        IT08 Value(int iRow, int iCol, int value);
        /// <summary>
        /// Calculates the array of numbers from the matrix following the specified recipe.
        /// </summary>
        /// <returns>An array of numbers from the matrix</returns>
        int[] Calculate();
    }
}