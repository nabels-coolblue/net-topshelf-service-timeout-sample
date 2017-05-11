using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Serilog;

namespace net_topshelf_service_timeout_sample.Services
{
    public class WellBehavedService : IService
    {
        public void Start()
        {
            Log.Logger.Information($"{nameof(WellBehavedService)} has started.");
            Log.Logger.Information($"{nameof(WellBehavedService)} performing heavy initialization in separate thread.");
            Task.Run(() => DoWork());
            Log.Logger.Information($"{nameof(WellBehavedService)} service about to be registered as Running.");
        }

        public void DoWork()
        {
            Thread.Sleep(60000);
            Log.Logger.Information($"{nameof(WellBehavedService)} Finished initialization.");
        }

        public void Stop()
        {
            Log.Logger.Information($"{nameof(WellBehavedService)} has stopped.");
        }
    }
}
