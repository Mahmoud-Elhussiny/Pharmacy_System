using AutoMapper;
using Informatique.Base.Core.Messages;
using Microsoft.AspNetCore.Mvc;

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
