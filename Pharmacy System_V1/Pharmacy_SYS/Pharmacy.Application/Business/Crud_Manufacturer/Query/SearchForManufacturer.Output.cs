using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Manufacturer.Query
{
    public class SearchForManufacturerHandlerOutput : BaseResponse
    {
        public SearchForManufacturerHandlerOutput() { }
        public SearchForManufacturerHandlerOutput(Guid correlationId) : base(correlationId) { }
        public List<AllManufacturers> allManufacturers { get; set; }

    }
    public class AllManufacturers
    {
        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
    }
}
