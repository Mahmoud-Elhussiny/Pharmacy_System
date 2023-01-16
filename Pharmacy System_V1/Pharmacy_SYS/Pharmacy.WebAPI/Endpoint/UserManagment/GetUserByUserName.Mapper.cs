using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.UserManagment.Query;

namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class GetUserByUserNameMapper : Profile
    {
        public GetUserByUserNameMapper()
        {
            CreateMap<GetUserByUserNameEndPointRequest, GetUserByUserNameHandlerInput>()
                .ConstructUsing(src => new GetUserByUserNameHandlerInput(src.CorrelationId()));
            CreateMap<GetUserByUserNameHandlerOutput, GetUserByUserNameEndPointResponse>()
               .ConstructUsing(src => new GetUserByUserNameEndPointResponse(src.CorrelationId()));
        }

    }
}
