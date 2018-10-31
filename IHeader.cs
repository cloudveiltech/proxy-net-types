using System;
using System.Collections.Generic;
using System.Text;

namespace FilterProvider.Common.Proxy
{
    public interface IHeader
    {
        string RawHeader { get; }

        string Name { get; }
        string Value { get; }
    }
}
