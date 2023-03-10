namespace PSTargetSistemas
{
    /// <summary>
    /// This class contains a method to check if a number is in the Fibonacci sequence.
    /// </summary>
    public class Fibonacci
    {
        /// <summary>
        /// This method checks if a number is in the Fibonacci sequence.
        /// </summary>
        /// <param name="number">The number to check.</param>
        /// <returns>True if the number is in the Fibonacci sequence, false otherwise.</returns>
        public bool IsInSequence(int number)
        {
            if (number == 0 || number == 1)
            {
                return true;
            }
            else
            {
                int a = 0;
                int b = 1;
                int c = 0;
                while (c < number)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                return c == number;
            }
        }
    }
}