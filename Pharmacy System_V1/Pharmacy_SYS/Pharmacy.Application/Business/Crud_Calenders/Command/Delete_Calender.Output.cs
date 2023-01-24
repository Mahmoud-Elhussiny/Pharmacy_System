using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Calenders.Command
{
    public class Delete_CalenderHandlerOutput : BaseRessponse
    {
        public Delete_CalenderHandlerOutput() { }
        public Delete_CalenderHandlerOutput(Guid correlationId) : base(correlationId) { }

        public string Message { get; set; }
    }
}
