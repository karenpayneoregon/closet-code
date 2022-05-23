namespace TransformingConsoleCodeSample.Interfaces
{
    public interface ITransformer<in TSource, out TResult>
    {
        TResult Transform(TSource source);
    }
}
