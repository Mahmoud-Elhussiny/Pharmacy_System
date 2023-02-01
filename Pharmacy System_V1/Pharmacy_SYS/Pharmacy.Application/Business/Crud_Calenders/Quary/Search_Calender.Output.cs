using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Calenders.Quary
{
    public class Search_CalenderHandlerOutput : BaseResponse
    {
        public Search_CalenderHandlerOutput() { }
        public Search_CalenderHandlerOutput(Guid correlationId) : base(correlationId) { }

        public List<SeachlistOfCalender> resultcalenders { get; set; }
    }

    public class SeachlistOfCalender
    {
        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
    }
}
