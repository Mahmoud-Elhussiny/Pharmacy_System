using AutoMapper;
using Pharmacy.Application.Business.Crud_DisCompany.Command;

namespace Pharmacy.WebAPI.Endpoint.Crud_DisCompany
{
    public class CreateDistrbutedCompanyMapper : Profile
    {
        public CreateDistrbutedCompanyMapper()
        {
            CreateMap<CreateDistrbutedCompanyEndPointRequest, CreateDistrbutedCompanyHandlerInput>()
                .ConstructUsing(src => new CreateDistrbutedCompanyHandlerInput(src.CorrelationId()));
            CreateMap<CreateDistrbutedCompanyHandlerOutput, CreateDistrbutedCompanyEndPointResponse>()
               .ConstructUsing(src => new CreateDistrbutedCompanyEndPointResponse(src.CorrelationId()));
        }

    }
}
