using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Calenders.Quary
{
    public class GetAll_CalendersHandlerOutput : BaseResponse
    {
        public GetAll_CalendersHandlerOutput() { }
        public GetAll_CalendersHandlerOutput(Guid correlationId) : base(correlationId) { }

        public List<listOfCalender> listOfCalenders { get; set; }
    }

    public class listOfCalender
    {
        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
    }

}
