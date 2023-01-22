using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_ItemTypes.Command
{
    public class Delete_ItemTypeHandlerOutput : BaseResponse
    {
        public Delete_ItemTypeHandlerOutput() { }
        public Delete_ItemTypeHandlerOutput(Guid correlationId) : base(correlationId) { }

        public string Message { get; set; }
    }
}
