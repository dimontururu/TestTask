namespace TextCompressor
{
    internal class ServiceCompressor(ICompressor compressor)
    {
        private ICompressor Compressor { get; } = compressor;

        public string Compress(string text)
        {
            return Compressor.Compress(text);
        }

        public string Decompress(string text)
        {
            return Compressor.Decompress(text);
        }
    }
}
