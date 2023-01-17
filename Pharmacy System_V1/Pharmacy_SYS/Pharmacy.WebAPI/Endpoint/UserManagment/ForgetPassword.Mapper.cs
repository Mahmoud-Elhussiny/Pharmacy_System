using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.UserManagment.Reset_Password;

namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class ForgetPasswordMapper : Profile
    {
        public ForgetPasswordMapper()
        {
            CreateMap<ForgetPasswordEndPointRequest, ForgetPasswordHandlerInput>()
                .ConstructUsing(src => new ForgetPasswordHandlerInput(src.CorrelationId()));
            CreateMap<ForgetPasswordHandlerOutput, ForgetPasswordEndPointResponse>()
               .ConstructUsing(src => new ForgetPasswordEndPointResponse(src.CorrelationId()));
        }

    }
}
