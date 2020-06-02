namespace AutofacFun
{
    public interface IFactory
    {
        T Create<T>();
    }
    
    public class Factory : IFactory
    {
        T Create<T>()
        {
            if (typeof(T).IsAssignableFrom(ISimpleRepository))
            {
                return (new FirstFactory()).Create<T>();
            }

            return (new SecondFactory()).Create<T>();
        }
    }

    public class FirstFactory : IFactory
    {
        public T Create<T>()
        {
            
        }
    }

    public class SecondFactory : IFactory
    {
        public T Create<T>()
        {
            
        }
    }
}