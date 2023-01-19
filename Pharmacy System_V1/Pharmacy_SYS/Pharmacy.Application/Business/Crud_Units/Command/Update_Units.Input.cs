using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Units.Command
{
    public class Update_UnitsHandlerInput : BaseRequest, IRequest<Update_UnitsHandlerOutput>
    {
        public Update_UnitsHandlerInput() { }
        public Update_UnitsHandlerInput(Guid correlationId) : base(correlationId) { }


        public int Id { get; set; }
        public string? nameEn { get; set; }
        public string? nameAr { get; set; }
    }
}
