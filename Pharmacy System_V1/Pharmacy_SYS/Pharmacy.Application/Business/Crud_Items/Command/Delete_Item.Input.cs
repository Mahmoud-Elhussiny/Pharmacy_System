using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Items.Command
{
    public class Delete_ItemHandlerInput : BaseRequest, IRequest<Delete_ItemHandlerOutput>
    {
        public Delete_ItemHandlerInput() { }
        public Delete_ItemHandlerInput(Guid correlationId) : base(correlationId) { }
        public int Id { get; set; }
    }
}
