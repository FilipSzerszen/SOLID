using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŁańcuchZobowiązań
{
    public class AuthorizationHandler : BaseHandler
    {
        public Dictionary<int, int> EntityOwners = new Dictionary<int, int>()
        {
            {101, 13 },
            {105, 14 },
            {200, 15 }
        };
        public AuthorizationHandler(IHandler next) : base(next)
        {
        }

        public override void Handle(RequestContext requestContext)
        {
            Console.WriteLine("AuthorizationHandler");

            if (requestContext.Request.UserRole == "Admin")
            {
                _next.Handle(requestContext);
                return;
            }
            if (EntityOwners.TryGetValue(requestContext.Request.EntityId, out int ownerId))
            {
                if (ownerId == requestContext.Request.UserId)
                {
                    _next.Handle(requestContext);
                    return;
                }
            }
            requestContext.Response.IsSuccessfull = false;
            requestContext.Response.Message = "User is not authorized";
        }
    }
}
