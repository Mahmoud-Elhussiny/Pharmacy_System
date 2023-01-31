using AutoMapper;
using Pharmacy.Application.Business.UserManagment.Command;

namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class LogoutMapper : Profile
    {
        public LogoutMapper()
        {
            CreateMap<LogoutEndPointRequest, LogoutHandlerInput>()
                .ConstructUsing(src => new LogoutHandlerInput(src.CorrelationId()));
            CreateMap<LogoutHandlerOutput, LogoutEndPointResponse>()
               .ConstructUsing(src => new LogoutEndPointResponse(src.CorrelationId()));
        }

    }
}
