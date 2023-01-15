using Ardalis.ApiEndpoints;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.UserManagment.Command;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class Create_UserEndPoint : EndpointBaseAsync
    .WithRequest<Create_UserEndPointRequest>
    .WithActionResult<Create_UserEndPointResponse>
    {
        private readonly ILogger<Create_UserEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public Create_UserEndPoint(ILogger<Create_UserEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpPost(Create_UserEndPointRequest.Route)]
        [SwaggerOperation(Summary = "Create_User", Description = "Create_User ", OperationId = "Pharmacy.WebAPI.Endpoint.UserManagment.Create_User", Tags = new[] { "Pharmacy.WebAPI.Endpoint.UserManagment" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(Create_UserEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(Exception))]
        public override async Task<ActionResult<Create_UserEndPointResponse>> HandleAsync([FromBody] Create_UserEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting Create_User handling");
            var Appinput = _mapper.Map<Create_UserHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<Create_UserEndPointResponse>(result));
        }
    }
}
