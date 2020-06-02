namespace AutofacFun
{
    public interface IComplexRepository<T>
    {
        string GetIdentity();
    }
    
    public class ComplexRepository<T> : IComplexRepository<T>
    {
        private readonly ICoreRepository _core;
        public ComplexRepository(ICoreRepository core)
        {
            _core = core;
        }
        
        public string GetIdentity()
            => $"ComplexRepository {_core.GetImplementationType()} for {typeof(T)}";
    }
}