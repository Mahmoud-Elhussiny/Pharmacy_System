using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_ItemTypes
{
    public class GetItemTypeByIdEndPointResponse : BaseResponse
    {
        public GetItemTypeByIdEndPointResponse() { }
        public GetItemTypeByIdEndPointResponse(Guid correlationId) : base(correlationId) { }
        
        public int Id { get; set; }
        public string nameEn { get; set; }
        public string nameAr { get; set; }
    }
}
