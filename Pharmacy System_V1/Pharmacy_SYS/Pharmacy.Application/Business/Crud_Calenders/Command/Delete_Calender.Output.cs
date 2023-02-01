using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Calenders.Command
{
    public class Delete_CalenderHandlerOutput : BaseResponse
    {
        public Delete_CalenderHandlerOutput() { }
        public Delete_CalenderHandlerOutput(Guid correlationId) : base(correlationId) { }

        public string Message { get; set; }
    }
}
