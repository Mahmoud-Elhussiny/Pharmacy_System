using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_DisCompany.Command
{
    public class DeleteDistibutedCompanyHandlerInput : BaseRequest, IRequest<DeleteDistibutedCompanyHandlerOutput>
    {
        public DeleteDistibutedCompanyHandlerInput() { }
        public DeleteDistibutedCompanyHandlerInput(Guid correlationId) : base(correlationId) { }
        public int Id { get; set; }

    }
}
