using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_Manufacturer
{
    public class GetTheManufacturerByIdEndPointResponse : BaseRessponse
    {
        public GetTheManufacturerByIdEndPointResponse() { }
        public GetTheManufacturerByIdEndPointResponse(Guid correlationId) : base(correlationId) { }
        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }

    }
}
