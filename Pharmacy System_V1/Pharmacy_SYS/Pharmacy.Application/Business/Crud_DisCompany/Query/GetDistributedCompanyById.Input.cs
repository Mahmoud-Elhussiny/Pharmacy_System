using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_DisCompany.Query
{
    public class GetDistributedCompanyByIdHandlerInput : BaseRequest, IRequest<GetDistributedCompanyByIdHandlerOutput>
    {
        public GetDistributedCompanyByIdHandlerInput() { }
        public GetDistributedCompanyByIdHandlerInput(Guid correlationId) : base(correlationId) { }
        public int Id { get; set; }
    }
}
