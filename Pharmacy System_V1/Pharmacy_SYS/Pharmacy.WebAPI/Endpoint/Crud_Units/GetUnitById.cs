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
    public class GetUnitByIdEndPoint : EndpointBaseAsync
    .WithRequest<GetUnitByIdEndPointRequest>
    .WithActionResult<GetUnitByIdEndPointResponse>
    {
        private readonly ILogger<GetUnitByIdEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public GetUnitByIdEndPoint(ILogger<GetUnitByIdEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpGet(GetUnitByIdEndPointRequest.Route)]
        [SwaggerOperation(Summary = "GetUnitById", Description = "GetUnitById ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_Units.GetUnitById", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_Units" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(GetUnitByIdEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<GetUnitByIdEndPointResponse>> HandleAsync([FromQuery] GetUnitByIdEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting GetUnitById handling");
            var Appinput = _mapper.Map<GetUnitByIdHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<GetUnitByIdEndPointResponse>(result));
        }
    }
}
