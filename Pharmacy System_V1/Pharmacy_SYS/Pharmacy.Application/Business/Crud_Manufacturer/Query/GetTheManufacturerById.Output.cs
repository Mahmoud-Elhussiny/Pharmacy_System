using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Manufacturer.Query
{
    public class GetTheManufacturerByIdHandlerOutput : BaseRessponse
    {
        public GetTheManufacturerByIdHandlerOutput() { }
        public GetTheManufacturerByIdHandlerOutput(Guid correlationId) : base(correlationId) { }
        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }

    }
}
