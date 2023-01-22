using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_ItemTypes.Command
{
    public class Create_ItemTypeHandlerInput : BaseRequest, IRequest<Create_ItemTypeHandlerOutput>
    {
        public Create_ItemTypeHandlerInput() { }
        public Create_ItemTypeHandlerInput(Guid correlationId) : base(correlationId) { }

        public string nameEn { get; set; }
        public string nameAr { get; set; }
    }
}
