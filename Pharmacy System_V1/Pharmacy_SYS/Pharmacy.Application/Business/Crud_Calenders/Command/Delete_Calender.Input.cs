using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Calenders.Command
{
    public class Delete_CalenderHandlerInput : BaseRequest, IRequest<Delete_CalenderHandlerOutput>
    {
        public Delete_CalenderHandlerInput() { }
        public Delete_CalenderHandlerInput(Guid correlationId) : base(correlationId) { }

        public int Id { get; set; }

    }
}
