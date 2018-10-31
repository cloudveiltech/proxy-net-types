using System;
using System.Collections.Generic;
using System.Text;

namespace FilterProvider.Common.Proxy
{
    public interface IProxyServer
    {
        int HttpPort { get; }
        int HttpsPort { get; }

        bool ProxyRunning { get; }

        void Start();
        void Stop();

        // Initialize() is implemented by class constructor or by global native function.
    }
}
