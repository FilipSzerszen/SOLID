using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŁańcuchZobowiązań
{
    public class ResultHandler : BaseHandler
    {
        public ResultHandler(IHandler next) : base(next)
        {
        }

        public override void Handle(RequestContext requestContext)
        {
            Console.WriteLine("ResultHandler");
            requestContext.Response.IsSuccessfull = true;
            requestContext.Response.Message = "Everything ok";
            requestContext.Response.Data = "Some value";
        }
    }
}
