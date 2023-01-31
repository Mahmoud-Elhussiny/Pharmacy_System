using Ardalis.ApiEndpoints;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.UserManagment.Command;
using Pharmacy.Core.CustomException;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class LogoutEndPoint : EndpointBaseAsync
    .WithRequest<LogoutEndPointRequest>
    .WithActionResult<LogoutEndPointResponse>
    {
        private readonly ILogger<LogoutEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public LogoutEndPoint(ILogger<LogoutEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }

        [HttpPost(LogoutEndPointRequest.Route)]
        [SwaggerOperation(Summary = "Logout", Description = "Logout ", OperationId = "Pharmacy.WebAPI.Endpoint.UserManagment.Logout", Tags = new[] { "Pharmacy.WebAPI.Endpoint.UserManagment" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(LogoutEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<LogoutEndPointResponse>> HandleAsync([FromQuery] LogoutEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting Logout handling");
            var Appinput = _mapper.Map<LogoutHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<LogoutEndPointResponse>(result));
        }
    }
}
