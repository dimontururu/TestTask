namespace TextCompressor.Compressor.Interface
{
    internal interface IServiceCompressor
    {
        public string Compress(string text);
        public string Decompress(string text);
    }
}
