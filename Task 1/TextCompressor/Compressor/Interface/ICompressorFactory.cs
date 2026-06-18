namespace TextCompressor.Compressor.Interface
{
    internal interface ICompressorFactory
    {
        ICompressor CreateCompressor();
        IServiceValidation CreateValidation();
        IServiceCompressor CreateServiceCompressor();
    }
}
