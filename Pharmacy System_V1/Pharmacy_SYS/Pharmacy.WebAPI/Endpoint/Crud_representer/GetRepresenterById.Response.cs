using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_representer
{
    public class GetRepresenterByIdEndPointResponse : BaseResponse
    {
        public GetRepresenterByIdEndPointResponse() { }
        public GetRepresenterByIdEndPointResponse(Guid correlationId) : base(correlationId) { }
        public int Id { get; set; }
        public string? NameEn { get; set; }
        public string? NameAr { get; set; }
        public int? distributed_Company_Id { get; set; }
        public string? phone { get; set; }

    }
}
