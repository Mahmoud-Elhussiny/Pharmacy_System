using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.UserManagment.Command
{
    public class LogoutHandlerOutput : BaseRessponse
    {
        public LogoutHandlerOutput() { }
        public LogoutHandlerOutput(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }
    }
}
