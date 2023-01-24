using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Units.Query
{
    public class GetUnitByIdHandlerOutput : BaseRessponse
    {
        public GetUnitByIdHandlerOutput() { }
        public GetUnitByIdHandlerOutput(Guid correlationId) : base(correlationId) { }
        
        public int Id { get; set; }
        public string nameEn { get; set; }
        public string nameAr { get; set; }
    }
}
