using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.UserManagment.Command;

namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class LoginMapper : Profile
    {
        public LoginMapper()
        {
            CreateMap<LoginEndPointRequest, LoginHandlerInput>()
                .ConstructUsing(src => new LoginHandlerInput(src.CorrelationId()));
            CreateMap<LoginHandlerOutput, LoginEndPointResponse>()
               .ConstructUsing(src => new LoginEndPointResponse(src.CorrelationId()));
        }

    }
}
