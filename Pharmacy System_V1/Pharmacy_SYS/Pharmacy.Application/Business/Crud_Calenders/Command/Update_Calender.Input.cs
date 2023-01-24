using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Calenders.Command
{
    public class Update_CalenderHandlerInput : BaseRequest, IRequest<Update_CalenderHandlerOutput>
    {
        public Update_CalenderHandlerInput() { }
        public Update_CalenderHandlerInput(Guid correlationId) : base(correlationId) { }

        public int Id { get; set; }
        public string? NameEn { get; set; }
        public string? NameAr { get; set; }
    }
}
