using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Manufacturer.Query
{
    public class GetAllManufacturersHandlerOutput : BaseResponse
    {
        public GetAllManufacturersHandlerOutput() { }
        public GetAllManufacturersHandlerOutput(Guid correlationId) : base(correlationId) { }
        public List<All_Manufacturers>all_Manufacturers { get; set; }

    }
    public class All_Manufacturers
    {
        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
    }
}
