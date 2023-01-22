using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Units.Command
{
    public class Delete_UnitsHandlerInput : BaseRequest, IRequest<Delete_UnitsHandlerOutput>
    {
        public Delete_UnitsHandlerInput() { }
        public Delete_UnitsHandlerInput(Guid correlationId) : base(correlationId) { }
        public int Id { get; set; }
    }
}
