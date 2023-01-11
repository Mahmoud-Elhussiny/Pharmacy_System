using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.UserManagment.Command;

namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class Create_UserMapper : Profile
    {
        public Create_UserMapper()
        {
            CreateMap<Create_UserEndPointRequest, Create_UserHandlerInput>()
                .ConstructUsing(src => new Create_UserHandlerInput(src.CorrelationId()));
            CreateMap<Create_UserHandlerOutput, Create_UserEndPointResponse>()
               .ConstructUsing(src => new Create_UserEndPointResponse(src.CorrelationId()));
        }

    }
}
