using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_ItemTypes.Query
{
    public class Search_ItemTypeHandlerInput : BaseRequest, IRequest<Search_ItemTypeHandlerOutput>
    {
        public Search_ItemTypeHandlerInput() { }
        public Search_ItemTypeHandlerInput(Guid correlationId) : base(correlationId) { }

        public string? nameEn { get; set; }
        public string? nameAr { get; set; }
    }
}
