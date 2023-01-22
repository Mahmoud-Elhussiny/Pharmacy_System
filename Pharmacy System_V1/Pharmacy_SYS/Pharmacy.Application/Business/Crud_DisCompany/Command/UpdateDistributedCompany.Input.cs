using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_DisCompany.Command
{
    public class UpdateDistributedCompanyHandlerInput : BaseRequest, IRequest<UpdateDistributedCompanyHandlerOutput>
    {
        public UpdateDistributedCompanyHandlerInput() { }
        public UpdateDistributedCompanyHandlerInput(Guid correlationId) : base(correlationId) { }
        public int Id { get; set; }
        public string? NameEn { get; set; } 
        public string? NameAr { get; set; } 
        public string? Location { get; set; }
        public string? Phone { get; set; }
        public int? TheManufacturerId { get; set; }
    }
}
