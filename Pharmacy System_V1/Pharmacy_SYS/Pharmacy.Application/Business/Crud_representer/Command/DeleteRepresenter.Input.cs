using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_representer.Command
{
    public class DeleteRepresenterHandlerInput : BaseRequest, IRequest<DeleteRepresenterHandlerOutput>
    {
        public DeleteRepresenterHandlerInput() { }
        public DeleteRepresenterHandlerInput(Guid correlationId) : base(correlationId) { }
        public int Id { get; set; }
    }
}
