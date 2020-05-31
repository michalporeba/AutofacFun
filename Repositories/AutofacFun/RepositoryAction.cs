using System;

namespace AutofacFun
{
    public interface IRepositoryAction
    {
        string Execute();
    }
    
    public class RepositoryAction
        : IRepositoryAction
    {
        public string Execute()
        {
            return $"Not connected yet";
        }
    }
}
