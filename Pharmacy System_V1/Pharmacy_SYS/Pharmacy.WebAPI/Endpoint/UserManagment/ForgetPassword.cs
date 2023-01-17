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
    public class ForgetPasswordEndPoint : EndpointBaseAsync
    .WithRequest<ForgetPasswordEndPointRequest>
    .WithActionResult<ForgetPasswordEndPointResponse>
    {
        private readonly ILogger<ForgetPasswordEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public ForgetPasswordEndPoint(ILogger<ForgetPasswordEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[ApiVersion("0.0")]
        //[Authorize]
        [HttpGet(ForgetPasswordEndPointRequest.Route)]
        [SwaggerOperation(Summary = "ForgetPassword", Description = "ForgetPassword ", OperationId = "Pharmacy.WebAPI.Endpoint.UserManagment.ForgetPassword", Tags = new[] { "Pharmacy.WebAPI.Endpoint.UserManagment" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ForgetPasswordEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<ForgetPasswordEndPointResponse>> HandleAsync([FromQuery] ForgetPasswordEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting ForgetPassword handling");
            var Appinput = _mapper.Map<ForgetPasswordHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<ForgetPasswordEndPointResponse>(result));
        }
    }
}
