using Ardalis.ApiEndpoints;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_representer.Query;
using Pharmacy.Core.CustomException;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Pharmacy.WebAPI.Endpoint.Crud_representer
{
    public class GetRepresenterByIdEndPoint : EndpointBaseAsync
    .WithRequest<GetRepresenterByIdEndPointRequest>
    .WithActionResult<GetRepresenterByIdEndPointResponse>
    {
        private readonly ILogger<GetRepresenterByIdEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public GetRepresenterByIdEndPoint(ILogger<GetRepresenterByIdEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        [HttpGet(GetRepresenterByIdEndPointRequest.Route)]
        [SwaggerOperation(Summary = "GetRepresenterById", Description = "GetRepresenterById ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_representer.GetRepresenterById", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_representer" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(GetRepresenterByIdEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<GetRepresenterByIdEndPointResponse>> HandleAsync([FromQuery] GetRepresenterByIdEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting GetRepresenterById handling");
            var Appinput = _mapper.Map<GetRepresenterByIdHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<GetRepresenterByIdEndPointResponse>(result));
        }
    }
}
