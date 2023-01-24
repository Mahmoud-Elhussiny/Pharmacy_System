using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Items.Command
{
    public class Delete_ItemHandlerOutput : BaseRessponse
    {
        public Delete_ItemHandlerOutput() { }
        public Delete_ItemHandlerOutput(Guid correlationId) : base(correlationId) { }

        public string Message { get; set; }

    }
}
