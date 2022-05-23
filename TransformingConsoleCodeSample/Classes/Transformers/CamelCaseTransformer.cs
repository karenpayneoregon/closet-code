using TransformingConsoleCodeSample.Interfaces;
using TransformingConsoleCodeSample.LanguageExtensions;

namespace TransformingConsoleCodeSample.Classes.Transformers
{
    public class CamelCaseTransformer :  ITransformer<string, string>
    {
        public string Transform(string source) => source.SplitCamelCase();
    }
}