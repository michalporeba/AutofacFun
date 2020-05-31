namespace AutofacFun
{
    public interface IComplexRepository<T>
    {
        string GetIdentity();
    }
    
    public class ComplexRepositoryOne<T> : IComplexRepository<T>
    {
        public string GetIdentity()
            => $"ComplexRepositoryOne for {typeof(T)}";
    }

    public class ComplexRepositoryTwo<T> : IComplexRepository<T>
    {
        public string GetIdentity()
            => $"ComplexRepositoryTwo for {typeof(T)}";
    }
}