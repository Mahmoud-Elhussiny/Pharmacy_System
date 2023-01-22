using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_representer.Command
{
    public class CreateRepresenterHandlerInput : BaseRequest, IRequest<CreateRepresenterHandlerOutput>
    {
        public CreateRepresenterHandlerInput() { }
        public CreateRepresenterHandlerInput(Guid correlationId) : base(correlationId) { }
        public string NameEn { get; set; } = null!;
        public string NameAr { get; set; } = null!;
        public int distributed_Company_Id { get; set; }
        public string phone { get; set; }
    }
}
