namespace AutofacFun
{
    public interface IActionTwo
    {
        string Execute();
    }
    
    public class ActionTwo : IActionTwo
    {
        private readonly Configuration _configuration;

        public ActionTwo(Configuration configuration)
        {
            _configuration = configuration;
        }
        
        public string Execute()
        {
            return $"Action Two with configurable property {_configuration.NumericProperty}";
        }

        public class Configuration
        {
            public int NumericProperty { get; set; }
        }
    }
}