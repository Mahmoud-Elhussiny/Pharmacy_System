using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Calenders.Command
{
    public class Create_CalenderHandlerInput : BaseRequest, IRequest<Create_CalenderHandlerOutput>
    {
        public Create_CalenderHandlerInput() { }
        public Create_CalenderHandlerInput(Guid correlationId) : base(correlationId) { }
       
        public string NameEn { get; set; }
        public string NameAr { get; set; }
    }
}
