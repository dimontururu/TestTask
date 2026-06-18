using TextCompressor.Validation;

namespace TextCompressor.Compressor.Interface
{
    internal class CompressorFactory : ICompressorFactory
    {
        public ICompressor CreateCompressor()=>new Compressor();
        public IServiceValidation CreateValidation()=>new ServiceValidation();
        public IServiceCompressor CreateServiceCompressor()=>new ServiceCompressor(CreateCompressor(),CreateValidation()); 

        
    }
}
