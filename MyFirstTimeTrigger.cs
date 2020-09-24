using System;
using System.Threading;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace MyFirstTimeTrigger
{
    public static class MyFirstTimeTrigger
    {
        [FunctionName("MyFirstTimeTrigger")]
        public static void Run([TimerTrigger("*/3 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C#  Timer trigger function started at: {DateTime.Now}");
            Thread.Sleep(5000);
            log.LogInformation($"C#  Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
