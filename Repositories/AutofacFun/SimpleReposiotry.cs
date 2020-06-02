namespace AutofacFun
{
    public interface ISimpleRepository
    {
        string GetIdentity();
    }
    
    public class SimpleRepository : ISimpleRepository
    {
        private readonly ICoreRepository _core;
        public SimpleRepository(ICoreRepository core)
        {
            _core = core;
        }
        
        public string GetIdentity()
            => $"SimpleRepository {_core.GetImplementationType()} for {typeof(T)}";
    }
}