using Informatique.Base.Core.Messages;
using Microsoft.AspNetCore.Mvc;

namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class ResetPasswordEndPointRequest : BaseRequest
    {
        public const string Route = "/api/v{version:apiVersion}/ResetPassword/";
    }
}
