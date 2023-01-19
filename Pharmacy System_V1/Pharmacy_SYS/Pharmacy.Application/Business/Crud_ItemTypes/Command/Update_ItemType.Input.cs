using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_ItemTypes.Command
{
    public class Update_ItemTypeHandlerInput : BaseRequest, IRequest<Update_ItemTypeHandlerOutput>
    {
        public Update_ItemTypeHandlerInput() { }
        public Update_ItemTypeHandlerInput(Guid correlationId) : base(correlationId) { }
        
        public int Id { get; set; }
        public string nameEn { get; set; }
        public string nameAr { get; set; }

    }
}
