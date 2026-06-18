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

            ICompressor compressor = new Compressor();
            IServiceValidation serviceValidation = new ServiceValidation();

            ServiceCompressor compressorService = new(compressor,serviceValidation);

            compressionLine = compressorService.Compress(compressionLine);

            Console.WriteLine(compressionLine);

            compressionLine = compressorService.Decompress(compressionLine);

            Console.WriteLine(compressionLine);

            Console.WriteLine("Совпадает? "+ compressionLine.Equals("aaabbcccdde"));
        }
    }
}
