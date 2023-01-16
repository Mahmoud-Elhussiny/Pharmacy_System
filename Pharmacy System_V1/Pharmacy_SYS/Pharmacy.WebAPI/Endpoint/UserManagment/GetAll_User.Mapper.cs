using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.UserManagment.Query;

namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class GetAll_UserMapper : Profile
    {
        public GetAll_UserMapper()
        {
            CreateMap<GetAll_UserEndPointRequest, GetAll_UserHandlerInput>()
                .ConstructUsing(src => new GetAll_UserHandlerInput(src.CorrelationId()));
            CreateMap<GetAll_UserHandlerOutput, GetAll_UserEndPointResponse>()
               .ConstructUsing(src => new GetAll_UserEndPointResponse(src.CorrelationId()));
        }

    }
}
