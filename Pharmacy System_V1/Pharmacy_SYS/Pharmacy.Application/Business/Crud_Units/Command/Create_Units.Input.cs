using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Units.Command
{
    public class Create_UnitsHandlerInput : BaseRequest, IRequest<Create_UnitsHandlerOutput>
    {
        public Create_UnitsHandlerInput() { }
        public Create_UnitsHandlerInput(Guid correlationId) : base(correlationId) { }

        public string nameEn { get; set; }
        public string nameAr { get; set; }
    }
}
