using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Serilog;

namespace net_topshelf_service_timeout_sample.Services
{
    public class WellBehavedService : IService
    {
        public void Start()
        {
            Log.Logger.Information($"{nameof(WellBehavedService)} has started.");
        }

        public void Stop()
        {
            Log.Logger.Information($"{nameof(WellBehavedService)} has stopped.");
        }
    }
}
