using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_ItemTypes.Query
{
    public class GetItemTypeByIdHandlerOutput : BaseResponse
    {
        public GetItemTypeByIdHandlerOutput() { }
        public GetItemTypeByIdHandlerOutput(Guid correlationId) : base(correlationId) { }

        public int Id { get; set; }
        public string nameEn { get; set; }
        public string nameAr { get; set; }
    }
}
