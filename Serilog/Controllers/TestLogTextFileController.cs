using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;
namespace SerilogDemo.Controllers
{
    [Route("api/log")]
    [ApiController]
    public class TestLogTextFileController : ControllerBase
    {
        [HttpGet]
        [Route("TextFile")]
        public int WriteTextFile()
        {
            int C = 0;
            string fileName ="LogFile"+ System.DateTime.Now.ToString("yyyymmddhhmmss")+".log";
            Log.Logger=new LoggerConfiguration().WriteTo.File(AppDomain.CurrentDomain.BaseDirectory + @"\" + fileName).CreateLogger();
            try
            {
                Log.Information("Start -- " + System.DateTime.Now.ToString());
                int A = 10;
                int B = 0;
                Log.Information("Input Values {0} and {0} -- " + A, B);
                
                // C = A / B;  check error log
                C = A + B;
                Log.Information("Output Value {0} -- " + C);
                Log.Information("End -- " + System.DateTime.Now.ToString());
            }
            catch (Exception ex)
            {
                Log.Error(ex,"Some error occurred");
            }
            Log.CloseAndFlush();
            return C;
        }
    }
}
