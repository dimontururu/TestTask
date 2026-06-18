using TextCompressor.Compressor.Interface;

namespace TextCompressor.Compressor
{
    internal class ServiceCompressor(ICompressor compressor, IServiceValidation serviceValidation):IServiceCompressor
    {
        private ICompressor Compressor { get; } = compressor;
        private IServiceValidation ServiceValidation {  get; } = serviceValidation;

        public string Compress(string text)
        {
            if (!ServiceValidation.Validation(text))
                throw new ArgumentException($"Строка: ({text}) не прошла проверку");

            return Compressor.Compress(text);
        }

        public string Decompress(string text)
        {
            return Compressor.Decompress(text);
        }
    }
}
