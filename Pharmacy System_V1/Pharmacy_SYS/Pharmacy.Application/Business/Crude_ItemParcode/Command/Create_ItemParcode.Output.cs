using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crude_ItemParcode.Command
{
    public class Create_ItemParcodeHandlerOutput : BaseResponse
    {
        public Create_ItemParcodeHandlerOutput() { }
        public Create_ItemParcodeHandlerOutput(Guid correlationId) : base(correlationId) { }

        public string Messages { get; set; }
    }
}
