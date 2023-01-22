using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Units.Command
{
    public class Delete_UnitsHandlerOutput : BaseResponse
    {
        public Delete_UnitsHandlerOutput() { }
        public Delete_UnitsHandlerOutput(Guid correlationId) : base(correlationId) { }
        public string message { get; set; }
    }
}
