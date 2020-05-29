using Microsoft.AspNetCore.Mvc;

namespace AutofacFun.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Sample : ControllerBase
    {
        [HttpGet]
        public string Get([FromServices] IConfigurableAction action)
            => action.Execute();

        [HttpGet]
        public string One([FromServices] IActionOne action)
            => action.Execute();
        
        [HttpGet]
        public string One([FromServices] IActionTwo action)
            => action.Execute();
    }
}