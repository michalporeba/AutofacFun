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
        private readonly Configuration _config;
        
        public ConfigurableAction(Configuration config)
        {
            _config = config;
        }

        public string Execute()
        {
            return $"Configurable Action - {_config.Value}";
        }
    }

    public class Configuration
    {
        public string Value { get; set; }
    }

    public class ConfigurationResolver
    {
        public T Get<T>()
            where T : Configuration, new()
        {
            var output = Activator.CreateInstance<T>();
            output.Value = Guid.NewGuid().ToString().Substring(8);
            return output;
        }
    }
}
