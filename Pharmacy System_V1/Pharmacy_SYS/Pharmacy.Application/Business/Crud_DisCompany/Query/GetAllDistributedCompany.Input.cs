using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_DisCompany.Query
{
    public class GetAllDistributedCompanyHandlerInput : BaseRequest, IRequest<GetAllDistributedCompanyHandlerOutput>
    {
        public GetAllDistributedCompanyHandlerInput() { }
        public GetAllDistributedCompanyHandlerInput(Guid correlationId) : base(correlationId) { }
    }
}
