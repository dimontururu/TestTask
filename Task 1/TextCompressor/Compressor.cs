using System.Text;

namespace TextCompressor
{
    internal class Compressor:ICompressor
    {
        public string Compress(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "";

            StringBuilder result = new();

            char currentChar = input[0];
            int count = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == currentChar)
                {
                    count++;
                }
                else
                {
                    result.Append(currentChar);

                    if (count > 1)
                        result.Append(count);

                    currentChar = input[i];
                    count = 1;
                }
            }

            result.Append(currentChar);

            if (count > 1)
                result.Append(count);

            return result.ToString();
        }

        public string Decompress(string input)
        {
            StringBuilder result = new();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (char.IsLetter(currentChar))
                {
                    StringBuilder number = new();

                    int j = i + 1;

                    while (j < input.Length && char.IsDigit(input[j]))
                    {
                        number.Append(input[j]);
                        j++;
                    }

                    int count = number.Length > 0
                        ? int.Parse(number.ToString())
                        : 1;

                    result.Append(new string(currentChar, count));

                    i = j - 1;
                }
            }

            return result.ToString();
        }
    }
}
