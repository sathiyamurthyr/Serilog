using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using DB;
namespace DB.Controllers
{
    [Route("api/dblog")]
    [ApiController]
    public class MSSQLLogController : ControllerBase
    {
        private readonly ILoggerService Logger;
        public MSSQLLogController(ILoggerService logger)
        {
            Logger = logger;
        }

        [HttpGet]
        [Route("dbFile")]
        public string DBSQLLog()
        {

          //  Logger.Log(LogLevel.Debug, $"GET /Recipes/");
            Logger.Log(LogLevel.Information, "test");
            Add ASD = new Add();
            try
            {
                int a = 10;
                int b = 10;
                ASD.A = a;
                ASD.B = b;
                // _logger.LogWarning("A value --: "+a +" B Value is --: "+b);
              //  _logger.LogInformation("A and B",ASD);
                int c = a + b;
              //  _logger.LogWarning("Output is --: "+c);
                // <snip>
            }
            catch (Exception ex)
            {
               // _logger.LogError(ex, "Unhandled exception");
            }
            finally
            {
              //  _logger.LogInformation("Shut down complete");
               
            }

            return "";
        }
        private readonly ILogger<MSSQLLogController> _logger;

        //public MSSQLLogController(ILogger<MSSQLLogController> logger)
        //{
        //    _logger = logger;
        //}
        public class Add
        {
            public int A { get; set; }
            public int B { get; set; }  
            public int C { get; set; }   
        }

    }
}
