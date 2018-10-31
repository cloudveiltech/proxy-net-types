using System;
using System.Collections.Generic;
using System.Text;

namespace FilterProvider.Common.Proxy
{
    public interface IRequest
    {
        string Url { get; }

        IHeaderCollection Headers { get; }
    }
}
