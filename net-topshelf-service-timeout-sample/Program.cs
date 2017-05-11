using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using net_topshelf_service_timeout_sample.Services;

using Serilog;

using Topshelf;

namespace net_topshelf_service_timeout_sample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.ColoredConsole()
                .CreateLogger();

            HostFactory.Run(x =>
            {
                x.Service<IService>(s =>
                {
                    s.ConstructUsing(name => ServiceFactory.GetService());
                    s.WhenStarted(ms => ms.Start());
                    s.WhenStopped(ms => ms.Stop());
                });
                x.SetServiceName("sample-BlockingService5");
            });
        }
    }
}
