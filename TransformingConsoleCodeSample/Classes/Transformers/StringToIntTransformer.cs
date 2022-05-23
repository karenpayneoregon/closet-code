using TransformingConsoleCodeSample.Interfaces;

namespace TransformingConsoleCodeSample.Classes.Transformers
{
    public class StringToIntTransformer : ITransformer<string, int>
    {
        public int Transform(string source) => int.TryParse(source, out var value) ? value : 0;
    }
}
