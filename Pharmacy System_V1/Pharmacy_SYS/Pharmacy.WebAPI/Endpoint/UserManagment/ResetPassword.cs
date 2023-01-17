using Ardalis.ApiEndpoints;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.UserManagment.Reset_Password;
using Pharmacy.Core.CustomException;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class ResetPasswordEndPoint : EndpointBaseAsync
    .WithRequest<ResetPasswordEndPointRequest>
    .WithActionResult<ResetPasswordEndPointResponse>
    {
        private readonly ILogger<ResetPasswordEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public ResetPasswordEndPoint(ILogger<ResetPasswordEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[ApiVersion("0.0")]
        //[Authorize]
        [HttpGet(ResetPasswordEndPointRequest.Route)]
        [SwaggerOperation(Summary = "ResetPassword", Description = "ResetPassword ", OperationId = "Pharmacy.WebAPI.Endpoint.UserManagment.ResetPassword", Tags = new[] { "Pharmacy.WebAPI.Endpoint.UserManagment" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ResetPasswordEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<ResetPasswordEndPointResponse>> HandleAsync([FromQuery] ResetPasswordEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting ResetPassword handling");
            var Appinput = _mapper.Map<ResetPasswordHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<ResetPasswordEndPointResponse>(result));
        }
    }
}
