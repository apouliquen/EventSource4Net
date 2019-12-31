using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSource4Net
{
    class WebRequesterFactory : IWebRequesterFactory
    {
        public int Timeout { get; set; }
        public IWebRequester Create()
        {
            return new WebRequester()
            {
                Timeout = Timeout
            };
        }
    }
}
