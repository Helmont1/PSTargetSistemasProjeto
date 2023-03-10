namespace PSTargetSistemas
{
    /// <summary>
    /// This class provides a method to invert a given string
    /// </summary>
    public class StringInverter
    {
        /// <summary>
        /// Inverts the order of the characters in a string
        /// </summary>
        /// <param name="input">The string to be inverted</param>
        /// <returns>The inverted string</returns>
        public string Invert(string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return input;
            }

            var charArray = input.ToCharArray();
            int length = charArray.Length;

            for (int i = 0; i < length/2; i++)
            {
                char temp = charArray[i];
                charArray[i] = charArray[length - i - 1];
                charArray[length - i - 1] = temp;
            }

            return new string(charArray);
        }
    }
}
