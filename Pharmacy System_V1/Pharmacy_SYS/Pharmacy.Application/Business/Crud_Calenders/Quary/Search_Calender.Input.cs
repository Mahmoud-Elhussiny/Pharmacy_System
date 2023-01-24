using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Calenders.Quary
{
    public class Search_CalenderHandlerInput : BaseRequest, IRequest<Search_CalenderHandlerOutput>
    {
        public Search_CalenderHandlerInput() { }
        public Search_CalenderHandlerInput(Guid correlationId) : base(correlationId) { }

        public string? NameEn { get; set; }
        public string? NameAr { get; set; }
    }
}
