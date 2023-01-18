using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Units
{
    public class Create_UnitsHandlerOutput : BaseResponse
    {
        public Create_UnitsHandlerOutput() { }
        public Create_UnitsHandlerOutput(Guid correlationId) : base(correlationId) { }

        public string message { get; set; }

    }
}
