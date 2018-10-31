using System;
using System.Collections.Generic;
using System.Text;

namespace FilterProvider.Common.Proxy
{
    public interface IResponse
    {
        IHeaderCollection Headers { get; set; }

        bool HasBody { get; }

        // This can also be a stream if you want it to be, rather than a buffer.
        byte[] Body { get; set; }

        int StatusCode { get; set; }
    }
}
