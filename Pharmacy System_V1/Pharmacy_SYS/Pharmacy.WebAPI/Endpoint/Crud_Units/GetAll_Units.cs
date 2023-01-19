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
    public class GetAll_UnitsEndPoint : EndpointBaseAsync
    .WithRequest<GetAll_UnitsEndPointRequest>
    .WithActionResult<GetAll_UnitsEndPointResponse>
    {
        private readonly ILogger<GetAll_UnitsEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public GetAll_UnitsEndPoint(ILogger<GetAll_UnitsEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpGet(GetAll_UnitsEndPointRequest.Route)]
        [SwaggerOperation(Summary = "GetAll_Units", Description = "GetAll_Units ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_Units.GetAll_Units", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_Units" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(GetAll_UnitsEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<GetAll_UnitsEndPointResponse>> HandleAsync([FromQuery] GetAll_UnitsEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting GetAll_Units handling");
            var Appinput = _mapper.Map<GetAll_UnitsHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<GetAll_UnitsEndPointResponse>(result));
        }
    }
}
