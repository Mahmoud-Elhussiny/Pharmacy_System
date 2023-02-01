using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Items.Command
{
    public class Create_ItemHandlerOutput : BaseResponse
    {
        public Create_ItemHandlerOutput() { }
        public Create_ItemHandlerOutput(Guid correlationId) : base(correlationId) { }

        public string Message { get; set; }


    }
}
