using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŁańcuchZobowiązań
{
    public interface IHandler
    {
        void Handle(RequestContext requestContext);
    }
}
