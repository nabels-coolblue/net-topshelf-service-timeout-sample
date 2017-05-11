using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Serilog;

namespace net_topshelf_service_timeout_sample.Services
{
    public class BlockingService : IService
    {
        public void Start()
        {
            Thread.Sleep(60000);
            Log.Logger.Information($"{nameof(BlockingService)} has started.");
        }

        public void Stop()
        {
            Log.Logger.Information($"{nameof(BlockingService)} has stopped.");
        }
    }
}
