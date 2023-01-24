using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_representer
{
    public class UpdateRepresnterEndPointResponse : BaseRessponse
    {
        public UpdateRepresnterEndPointResponse() { }
        public UpdateRepresnterEndPointResponse(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }


    }
}
