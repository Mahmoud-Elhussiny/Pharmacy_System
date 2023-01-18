using AutoMapper;
using Pharmacy.Application.Business.UserManagment.Reset_Password;

namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class ResetPasswordMapper : Profile
    {
        public ResetPasswordMapper()
        {
            CreateMap<ResetPasswordEndPointRequest, ResetPasswordHandlerInput>()
                .ConstructUsing(src => new ResetPasswordHandlerInput(src.CorrelationId()));
            CreateMap<ResetPasswordHandlerOutput, ResetPasswordEndPointResponse>()
               .ConstructUsing(src => new ResetPasswordEndPointResponse(src.CorrelationId()));
        }

    }
}
