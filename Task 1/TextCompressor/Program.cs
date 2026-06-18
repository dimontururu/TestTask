using TextCompressor.Compressor;
using TextCompressor.Compressor.Interface;

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

            ICompressorFactory compressorFactory = new CompressorFactory();

            IServiceCompressor compressorService = compressorFactory.CreateServiceCompressor();

            try
            {
                compressionLine = compressorService.Compress(compressionLine);

                Console.WriteLine(compressionLine);

                compressionLine = compressorService.Decompress(compressionLine);

                Console.WriteLine(compressionLine);

                Console.WriteLine("Совпадает? " + compressionLine.Equals("aaabbcccdde"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка в программе:\n"+ex.Message);
            }
        }
    }
}
