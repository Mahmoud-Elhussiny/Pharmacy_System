using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Calenders.Quary
{
    public class GetCalenderByIdHandlerOutput : BaseResponse
    {
        public GetCalenderByIdHandlerOutput() { }
        public GetCalenderByIdHandlerOutput(Guid correlationId) : base(correlationId) { }

        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }

    }
}
