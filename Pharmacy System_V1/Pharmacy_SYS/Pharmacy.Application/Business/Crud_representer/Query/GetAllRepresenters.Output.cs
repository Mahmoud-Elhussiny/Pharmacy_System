using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_representer.Query
{
    public class GetAllRepresentersHandlerOutput : BaseRessponse
    {
        public GetAllRepresentersHandlerOutput() { }
        public GetAllRepresentersHandlerOutput(Guid correlationId) : base(correlationId) { }
        public List<All_Representers> all_Representers { get; set; }

    }
    public class All_Representers
    {
        public int Id { get; set; }
        public string? NameEn { get; set; }
        public string? NameAr { get; set; }
        public int? distributed_Company_Id { get; set; }
        public string? phone { get; set; }
    }
}
