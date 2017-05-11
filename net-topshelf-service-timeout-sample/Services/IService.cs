using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_topshelf_service_timeout_sample.Services
{
    public interface IService
    {
        void Start();
        void Stop();
    }

}
