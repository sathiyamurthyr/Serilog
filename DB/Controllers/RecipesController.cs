
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace DB.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly ILoggerService Logger;
        public RecipesController(ILoggerService logger)
        {
            Logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            //Logger.Log(LogLevel.Debug, $"GET /Recipes/");
            return "recipe";
        }
    }
}
