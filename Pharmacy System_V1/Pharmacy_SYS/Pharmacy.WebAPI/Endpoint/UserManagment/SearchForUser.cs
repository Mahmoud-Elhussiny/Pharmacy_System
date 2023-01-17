using Ardalis.ApiEndpoints;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Business.UserManagment.Query;
using Pharmacy.Core.CustomException;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Pharmacy.WebAPI.Endpoint.UserManagment
{
    public class SearchForUserEndPoint : EndpointBaseAsync
    .WithRequest<SearchForUserEndPointRequest>
    .WithActionResult<SearchForUserEndPointResponse>
    {
        private readonly ILogger<SearchForUserEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public SearchForUserEndPoint(ILogger<SearchForUserEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[ApiVersion("0.0")]
        //[Authorize]
        [HttpGet(SearchForUserEndPointRequest.Route)]
        [SwaggerOperation(Summary = "SearchForUser", Description = "SearchForUser ", OperationId = "Pharmacy.WebAPI.Endpoint.UserManagment.SearchForUser", Tags = new[] { "UserManagment" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(SearchForUserEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<SearchForUserEndPointResponse>> HandleAsync([FromQuery] SearchForUserEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting SearchForUser handling");
            var Appinput = _mapper.Map<SearchForUserHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<SearchForUserEndPointResponse>(result));
        }
    }
}
