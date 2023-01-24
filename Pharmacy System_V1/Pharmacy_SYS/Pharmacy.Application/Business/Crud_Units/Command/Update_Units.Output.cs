using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Units.Command
{
    public class Update_UnitsHandlerOutput : BaseRessponse
    {
        public Update_UnitsHandlerOutput() { }
        public Update_UnitsHandlerOutput(Guid correlationId) : base(correlationId) { }
        public string message { get; set; }
    }
}
