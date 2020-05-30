namespace AutofacFun.Service
{
    public interface IConfigurationProvider
    {
        T Get<T>(T config) where T : IConfiguration;
    }
    public class ConfigurationProvider
        : IConfigurationProvider
    {
        public T Get<T>(T config)
            where T : IConfiguration
        {
            return config;
        }
    }
}