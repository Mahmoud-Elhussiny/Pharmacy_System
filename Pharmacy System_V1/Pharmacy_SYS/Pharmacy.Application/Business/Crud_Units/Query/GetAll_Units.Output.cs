using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_Units.Query
{
    public class GetAll_UnitsHandlerOutput : BaseRessponse
    {
        public GetAll_UnitsHandlerOutput() { }
        public GetAll_UnitsHandlerOutput(Guid correlationId) : base(correlationId) { }
        public List<listofUnit> listofUnits { get; set; }
    }

    public class listofUnit
    {
        public int Id { get; set; }
        public string nameEn { get; set; }
        public string nameAr { get; set; }
    }

}
