using AutoMapper;
using Pharmacy.Application.Business.Crud_DisCompany.Command;

namespace Pharmacy.WebAPI.Endpoint.Crud_DisCompany
{
    public class UpdateDistributedCompanyMapper : Profile
    {
        public UpdateDistributedCompanyMapper()
        {
            CreateMap<UpdateDistributedCompanyEndPointRequest, UpdateDistributedCompanyHandlerInput>()
                .ConstructUsing(src => new UpdateDistributedCompanyHandlerInput(src.CorrelationId()));
            CreateMap<UpdateDistributedCompanyHandlerOutput, UpdateDistributedCompanyEndPointResponse>()
               .ConstructUsing(src => new UpdateDistributedCompanyEndPointResponse(src.CorrelationId()));
        }

    }
}
