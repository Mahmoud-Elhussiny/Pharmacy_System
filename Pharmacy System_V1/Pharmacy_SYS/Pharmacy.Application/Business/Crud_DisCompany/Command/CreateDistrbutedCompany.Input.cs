using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_DisCompany.Command
{
    public class CreateDistrbutedCompanyHandlerInput : BaseRequest, IRequest<CreateDistrbutedCompanyHandlerOutput>
    {
        public CreateDistrbutedCompanyHandlerInput() { }
        public CreateDistrbutedCompanyHandlerInput(Guid correlationId) : base(correlationId) { }
        public string NameEn { get; set; } = null!;
        public string NameAr { get; set; } = null!;
        public string? Location { get; set; }
        public string? Phone { get; set; }
        public int? TheManufacturerId { get; set; }
    }
}
