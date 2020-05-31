namespace AutofacFun
{
    public interface IActionOne
    {
        string Execute();
    }
    
    public class ActionOne : IActionOne
    {
        private readonly Configuration _configuration;

        public ActionOne(Configuration configuration)
        {
            _configuration = configuration;
        }

        public string Execute()
        {
            return $"Action One with configurable property {_configuration.TextProperty}";
        }

        public class Configuration : IConfiguration
        {
            public string TextProperty { get; set; }
        }
    }
}