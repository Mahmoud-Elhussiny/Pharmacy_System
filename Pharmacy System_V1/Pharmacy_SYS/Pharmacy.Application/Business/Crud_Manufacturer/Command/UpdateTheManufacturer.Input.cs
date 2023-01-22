using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Manufacturer.Command
{
    public class UpdateTheManufacturerHandlerInput : BaseRequest, IRequest<UpdateTheManufacturerHandlerOutput>
    {
        public UpdateTheManufacturerHandlerInput() { }
        public UpdateTheManufacturerHandlerInput(Guid correlationId) : base(correlationId) { }
        public int Id { get; set; }
        public string? NameEn { get; set; }
        public string? NameAr { get; set; } 
        public string? Location { get; set; }
        public string? Phone { get; set; } 
    }
}
