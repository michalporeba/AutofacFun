using Microsoft.AspNetCore.Mvc;

namespace AutofacFun.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Sample : ControllerBase
    {
        [HttpGet]
        public string Get([FromServices] IRepositoryAction action)
            => action.Execute();
    }
}