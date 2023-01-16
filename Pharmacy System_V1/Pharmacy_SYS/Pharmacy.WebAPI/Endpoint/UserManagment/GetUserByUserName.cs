using Ardalis.ApiEndpoints;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Business.UserManagment.Query;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class GetUserByUserNameEndPoint : EndpointBaseAsync
    .WithRequest<GetUserByUserNameEndPointRequest>
    .WithActionResult<GetUserByUserNameEndPointResponse>
    {
        private readonly ILogger<GetUserByUserNameEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public GetUserByUserNameEndPoint(ILogger<GetUserByUserNameEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[ApiVersion("0.0")]
        //[Authorize]
        [HttpGet(GetUserByUserNameEndPointRequest.Route)]
        [SwaggerOperation(Summary = "GetUserByUserName", Description = "GetUserByUserName ", OperationId = "Pharmacy.WebAPI.Endpoint.UserManagment.GetUserByUserName", Tags = new[] { "Pharmacy.WebAPI.Endpoint.UserManagment" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(GetUserByUserNameEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(Exception))]
        public override async Task<ActionResult<GetUserByUserNameEndPointResponse>> HandleAsync([FromQuery] GetUserByUserNameEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting GetUserByUserName handling");
            var Appinput = _mapper.Map<GetUserByUserNameHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<GetUserByUserNameEndPointResponse>(result));
        }
    }
}
