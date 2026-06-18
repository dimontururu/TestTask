namespace TextCompressor.Validation
{
    internal class ServiceValidation : IServiceValidation
    {
        public bool Validation(string text)
        {
            if (string.IsNullOrEmpty(text)) return false;

            foreach (char c in text)
            {
                if (c < 'a' || c > 'z')
                    return false;
            }
            return true;
        }
    }
}
