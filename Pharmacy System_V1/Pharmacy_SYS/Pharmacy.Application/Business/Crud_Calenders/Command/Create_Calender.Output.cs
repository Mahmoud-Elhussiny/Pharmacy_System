using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Calenders.Command
{
    public class Create_CalenderHandlerOutput : BaseResponse
    {
        public Create_CalenderHandlerOutput() { }
        public Create_CalenderHandlerOutput(Guid correlationId) : base(correlationId) { }

        public string Message { get; set; }
    }
}
