using System;

namespace AutofacFun.Service
{
    public interface IConfigurationProvider
    {
        T Get<T>(T config) where T : SomeEntity;
    }
    public class ConfigurationProvider
        : IConfigurationProvider
    {
        public T Get<T>(T config)
            where T : SomeEntity
        {
            foreach (var p in config.GetType().GetProperties())
            {
                if (p.PropertyType == typeof(int))
                {
                    p.SetValue(config, (new Random()).Next(1000,2000));
                }

                if (p.PropertyType == typeof(string))
                {
                    p.SetValue(config, Guid.NewGuid().ToString().Substring(0,8));
                }
            }
            return config;
        }
    }
}