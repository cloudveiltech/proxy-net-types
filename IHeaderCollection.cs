using System;
using System.Collections.Generic;
using System.Text;

namespace FilterProvider.Common.Proxy
{
    public interface IHeaderCollection : ICollection<IHeader>
    {
        bool HeaderExists(string headerName);

        IHeader GetFirstHeader(string headerName);
    }
}
