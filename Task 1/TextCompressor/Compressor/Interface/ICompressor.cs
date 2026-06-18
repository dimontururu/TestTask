namespace TextCompressor.Compressor.Interface
{
    internal interface ICompressor
    {
        string Compress(string input);
        string Decompress(string input);
    }
}

