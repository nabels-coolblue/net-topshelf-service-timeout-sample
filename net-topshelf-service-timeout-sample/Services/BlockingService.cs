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
            Log.Logger.Information($"{GetType().Name}: {nameof(Start)}.");
            Log.Logger.Information("Simulating expensive bootstrapping of application (60 seconds).");

            Thread.Sleep(5000);

            Log.Logger.Information($"{nameof(BlockingService)} has started.");
        }

        public void Stop()
        {
            Log.Logger.Information($"{nameof(BlockingService)} has stopped.");
        }
    }
}
