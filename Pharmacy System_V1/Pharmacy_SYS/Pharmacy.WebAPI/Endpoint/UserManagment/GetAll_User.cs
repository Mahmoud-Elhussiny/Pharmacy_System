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
    public class GetAll_UserEndPoint : EndpointBaseAsync
    .WithRequest<GetAll_UserEndPointRequest>
    .WithActionResult<GetAll_UserEndPointResponse>
    {
        private readonly ILogger<GetAll_UserEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public GetAll_UserEndPoint(ILogger<GetAll_UserEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[ApiVersion("0.0")]
        //[Authorize]
        [HttpGet(GetAll_UserEndPointRequest.Route)]
        [SwaggerOperation(Summary = "GetAll_User", Description = "GetAll_User ", OperationId = "Pharmacy.WebAPI.Endpoint.UserManagment.GetAll_User", Tags = new[] { "Pharmacy.WebAPI.Endpoint.UserManagment" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(GetAll_UserEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(Exception))]
        public override async Task<ActionResult<GetAll_UserEndPointResponse>> HandleAsync([FromQuery] GetAll_UserEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting GetAll_User handling");
            var Appinput = _mapper.Map<GetAll_UserHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<GetAll_UserEndPointResponse>(result));
        }
    }
}
