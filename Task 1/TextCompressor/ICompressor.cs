
namespace TextCompressor
{
    internal interface ICompressor
    {
        string Compress(string input);
        string Decompress(string input);
    }
}

