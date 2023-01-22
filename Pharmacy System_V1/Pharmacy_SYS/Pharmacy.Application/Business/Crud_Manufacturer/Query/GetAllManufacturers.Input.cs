using MediatR;
using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Manufacturer.Query
{
    public class GetAllManufacturersHandlerInput : BaseRequest, IRequest<GetAllManufacturersHandlerOutput>
    {
        public GetAllManufacturersHandlerInput() { }
        public GetAllManufacturersHandlerInput(Guid correlationId) : base(correlationId) { }
    }
}
