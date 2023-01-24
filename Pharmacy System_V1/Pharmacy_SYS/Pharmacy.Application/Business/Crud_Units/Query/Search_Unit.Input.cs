using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Units.Query
{
    public class Search_UnitHandlerInput : BaseRequest, IRequest<Search_UnitHandlerOutput>
    {
        public Search_UnitHandlerInput() { }
        public Search_UnitHandlerInput(Guid correlationId) : base(correlationId) { }
        public string? nameEn { get; set; }
        public string? nameAr { get; set; }
    }
}
