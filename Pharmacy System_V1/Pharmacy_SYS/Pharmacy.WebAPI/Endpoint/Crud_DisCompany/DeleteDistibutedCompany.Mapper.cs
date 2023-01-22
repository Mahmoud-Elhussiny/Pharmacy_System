using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_DisCompany.Command;

namespace Pharmacy.WebAPI.Endpoint.Crud_DisCompany
{
    public class DeleteDistibutedCompanyMapper : Profile
    {
        public DeleteDistibutedCompanyMapper()
        {
            CreateMap<DeleteDistibutedCompanyEndPointRequest, DeleteDistibutedCompanyHandlerInput>()
                .ConstructUsing(src => new DeleteDistibutedCompanyHandlerInput(src.CorrelationId()));
            CreateMap<DeleteDistibutedCompanyHandlerOutput, DeleteDistibutedCompanyEndPointResponse>()
               .ConstructUsing(src => new DeleteDistibutedCompanyEndPointResponse(src.CorrelationId()));
        }

    }
}
