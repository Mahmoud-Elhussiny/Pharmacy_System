using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_ItemTypes.Command
{
    public class Update_ItemTypeHandlerOutput : BaseResponse
    {
        public Update_ItemTypeHandlerOutput() { }
        public Update_ItemTypeHandlerOutput(Guid correlationId) : base(correlationId) { }

        public string Message { get; set; }
    }
}
