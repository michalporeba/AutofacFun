namespace AutofacFun
{
    public interface ISimpleRepository
    {
        string GetIdentity();
    }
    
    public class SimpleRepositoryOne : ISimpleRepository
    {
        public string GetIdentity()
            => "SimpleRepositoryOne";
    }

    public class SimpleRepositoryTwo : ISimpleRepository
    {
        public string GetIdentity()
            => "SimpleRepositoryTwo";
    }
}