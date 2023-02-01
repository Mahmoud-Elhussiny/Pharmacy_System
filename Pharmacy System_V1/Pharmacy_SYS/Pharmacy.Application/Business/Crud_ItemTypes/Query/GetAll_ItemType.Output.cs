using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_ItemTypes.Query
{
    public class GetAll_ItemTypeHandlerOutput : BaseResponse
    {
        public GetAll_ItemTypeHandlerOutput() { }
        public GetAll_ItemTypeHandlerOutput(Guid correlationId) : base(correlationId) { }

        public List<listItemtype> listItemtypes { get; set; }

    }

    public class listItemtype
    {
        public int Id { get; set; }
        public string nameEn { get; set; }
        public string nameAr { get; set; }

    }
}
