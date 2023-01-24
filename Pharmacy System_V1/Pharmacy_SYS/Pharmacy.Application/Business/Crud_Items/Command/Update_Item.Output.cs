using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Items.Command
{
    public class Update_ItemHandlerOutput : BaseRessponse
    {
        public Update_ItemHandlerOutput() { }
        public Update_ItemHandlerOutput(Guid correlationId) : base(correlationId) { }
        public string Message { get; set; }
    }
}
