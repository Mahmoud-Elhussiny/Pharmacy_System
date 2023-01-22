using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_representer.Query
{
    public class GetRepresenterByIdHandlerOutput : BaseResponse
    {
        public GetRepresenterByIdHandlerOutput() { }
        public GetRepresenterByIdHandlerOutput(Guid correlationId) : base(correlationId) { }
        public int Id { get; set; }
        public string? NameEn { get; set; }
        public string? NameAr { get; set; }
        public int? distributed_Company_Id { get; set; }
        public string? phone { get; set; }

    }
}
