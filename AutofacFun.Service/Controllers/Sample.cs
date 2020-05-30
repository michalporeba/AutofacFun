using Microsoft.AspNetCore.Mvc;

namespace AutofacFun.Service.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class Sample : ControllerBase
    {
        [HttpGet]
        public string Get([FromServices] IConfigurableAction action)
            => action.Execute();

        [HttpGet]
        public string One([FromServices] IActionOne action)
            => action.Execute();
        
        [HttpGet]
        public string Two([FromServices] IActionTwo action)
            => action.Execute();

        [HttpGet]
        public string Test() => "Hello";
    }
}