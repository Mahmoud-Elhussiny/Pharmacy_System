using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crude_ItemParcode.Command
{
    public class Create_ItemParcodeHandlerInput : BaseRequest, IRequest<Create_ItemParcodeHandlerOutput>
    {
        public Create_ItemParcodeHandlerInput() { }
        public Create_ItemParcodeHandlerInput(Guid correlationId) : base(correlationId) { }

        public int Id { get; set; }
        public int itemId { get; set; }
        public DateTime productionDate { get; set; }
        public string? codeGenerated { get; set; }
        public string? batchNo { get; set; }
    }
}
