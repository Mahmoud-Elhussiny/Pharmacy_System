using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_DisCompany.Query
{
    public class SearchForDistributedCompanyHandlerInput : BaseRequest, IRequest<SearchForDistributedCompanyHandlerOutput>
    {
        public SearchForDistributedCompanyHandlerInput() { }
        public SearchForDistributedCompanyHandlerInput(Guid correlationId) : base(correlationId) { }
        public int? Id { get; set; }
        public string? NameEn { get; set; }
        public string? NameAr { get; set; }
        public int? TheManufacturerId { get; set; }
    }
}
