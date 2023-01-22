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
    public class GetAllRepresentersEndPoint : EndpointBaseAsync
    .WithRequest<GetAllRepresentersEndPointRequest>
    .WithActionResult<GetAllRepresentersEndPointResponse>
    {
        private readonly ILogger<GetAllRepresentersEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public GetAllRepresentersEndPoint(ILogger<GetAllRepresentersEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        [HttpGet(GetAllRepresentersEndPointRequest.Route)]
        [SwaggerOperation(Summary = "GetAllRepresenters", Description = "GetAllRepresenters ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_representer.GetAllRepresenters", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_representer" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(GetAllRepresentersEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<GetAllRepresentersEndPointResponse>> HandleAsync([FromQuery] GetAllRepresentersEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting GetAllRepresenters handling");
            var Appinput = _mapper.Map<GetAllRepresentersHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<GetAllRepresentersEndPointResponse>(result));
        }
    }
}
