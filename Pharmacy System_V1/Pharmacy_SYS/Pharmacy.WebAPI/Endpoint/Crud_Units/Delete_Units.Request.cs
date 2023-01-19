using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Units
{
    public class Delete_UnitsEndPointRequest : BaseRequest
    {
        public const string Route = "/api/Delete_Units/";

        public int Id { get; set; }

    }
}
