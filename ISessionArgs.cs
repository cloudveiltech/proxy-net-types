using System;
using System.Collections.Generic;
using System.Text;

namespace FilterProvider.Common.Proxy
{
    public interface ISessionArgs
    {
        IRequest Request { get; }
        IResponse Response { get; }

        void SendResponse(IResponse response);
    }
}
