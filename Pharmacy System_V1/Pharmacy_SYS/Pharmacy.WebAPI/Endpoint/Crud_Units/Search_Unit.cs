using Ardalis.ApiEndpoints;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Business.Crud_Units.Query;
using Pharmacy.Core.CustomException;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Pharmacy.WebAPI.Endpoint.Crud_Units
{
    public class Search_UnitEndPoint : EndpointBaseAsync
    .WithRequest<Search_UnitEndPointRequest>
    .WithActionResult<Search_UnitEndPointResponse>
    {
        private readonly ILogger<Search_UnitEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public Search_UnitEndPoint(ILogger<Search_UnitEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpGet(Search_UnitEndPointRequest.Route)]
        [SwaggerOperation(Summary = "Search_Unit", Description = "Search_Unit ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_Units.Search_Unit", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_Units" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(Search_UnitEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<Search_UnitEndPointResponse>> HandleAsync([FromQuery] Search_UnitEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting Search_Unit handling");
            var Appinput = _mapper.Map<Search_UnitHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<Search_UnitEndPointResponse>(result));
        }
    }
}
