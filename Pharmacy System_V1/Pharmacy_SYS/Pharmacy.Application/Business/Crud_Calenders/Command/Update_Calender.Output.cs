using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Calenders.Command
{
    public class Update_CalenderHandlerOutput : BaseRessponse
    {
        public Update_CalenderHandlerOutput() { }
        public Update_CalenderHandlerOutput(Guid correlationId) : base(correlationId) { }

        public string Message { get; set; }
    }
}
