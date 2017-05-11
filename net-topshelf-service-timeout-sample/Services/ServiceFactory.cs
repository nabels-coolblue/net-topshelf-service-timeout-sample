using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Serilog;

namespace net_topshelf_service_timeout_sample.Services
{
    public class ServiceFactory
    {
        public static IService GetService()
        {
            Log.Logger.Information($"Initializing {nameof(BlockingService)}...");
            return new BlockingService();
        }
    }
}
