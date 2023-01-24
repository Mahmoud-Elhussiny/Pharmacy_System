using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Units
{
    public class GetUnitByIdEndPointResponse : BaseRessponse
    {
        public GetUnitByIdEndPointResponse() { }
        public GetUnitByIdEndPointResponse(Guid correlationId) : base(correlationId) { }

        public int Id { get; set; }
        public string nameEn { get; set; }
        public string nameAr { get; set; }
    }
}
