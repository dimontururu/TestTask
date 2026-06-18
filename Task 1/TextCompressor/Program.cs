namespace TextCompressor
{
    internal class Program
    {
        static void Main()
        {
            string compressionLine;

            //Console.WriteLine("Введите строку для сжатия");

            //compressionLine = Console.ReadLine()??"";

            compressionLine = "aaabbcccdde";

            compressionLine = compressionLine.Compress();

            Console.WriteLine(compressionLine);

            compressionLine = compressionLine.Decompress();

            Console.WriteLine(compressionLine);

            Console.WriteLine("Совпадает?"+ compressionLine.Equals("aaabbcccdde"));
        }
    }
}
