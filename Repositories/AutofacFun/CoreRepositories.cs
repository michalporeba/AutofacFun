namespace AutofacFun
{
    public interface ICoreRepository
    {
        string GetImplementationType();
    }
    
    public class FirstCoreRepository : ICoreRepository
    {
        public string GetImplementationType() => "First Implementation";
    }

    public class SecondCoreRepository : ICoreRepository
    {
        public string GetImplementationType() => "Second Implementation";
    }
}