using System;

namespace AutofacFun
{
    public interface IConfigurableAction
    {
        string Execute();
    }
    
    public class ConfigurableAction
        : IConfigurableAction
    {
        public ConfigurableAction()
        {
            
        }

        public string Execute()
        {
            return "Configurable Action - OK";
        }
    }
}
