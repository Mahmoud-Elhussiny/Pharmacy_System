using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_ItemTypes.Command
{
    public class Create_ItemTypeHandlerOutput : BaseRessponse
    {
        public Create_ItemTypeHandlerOutput() { }
        public Create_ItemTypeHandlerOutput(Guid correlationId) : base(correlationId) { }
        
        public string Message { get; set; }
    }
}
