

using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_representer
{
    public class DeleteRepresenterEndPointResponse : BaseResponse
    {
        public DeleteRepresenterEndPointResponse() { }
        public DeleteRepresenterEndPointResponse(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }


    }
}
