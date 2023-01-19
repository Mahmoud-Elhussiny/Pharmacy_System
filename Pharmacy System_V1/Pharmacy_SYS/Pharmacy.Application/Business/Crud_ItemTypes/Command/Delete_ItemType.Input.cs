using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_ItemTypes.Command
{
    public class Delete_ItemTypeHandlerInput : BaseRequest, IRequest<Delete_ItemTypeHandlerOutput>
    {
        public Delete_ItemTypeHandlerInput() { }
        public Delete_ItemTypeHandlerInput(Guid correlationId) : base(correlationId) { }

        public int Id { get; set; }
    }
}
