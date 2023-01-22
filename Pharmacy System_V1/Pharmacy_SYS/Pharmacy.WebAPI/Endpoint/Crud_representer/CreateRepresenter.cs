using Ardalis.ApiEndpoints;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_representer.Command;
using Pharmacy.Core.CustomException;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Pharmacy.WebAPI.Endpoint.Crud_representer
{
    public class CreateRepresenterEndPoint : EndpointBaseAsync
    .WithRequest<CreateRepresenterEndPointRequest>
    .WithActionResult<CreateRepresenterEndPointResponse>
    {
        private readonly ILogger<CreateRepresenterEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public CreateRepresenterEndPoint(ILogger<CreateRepresenterEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        [HttpPost(CreateRepresenterEndPointRequest.Route)]
        [SwaggerOperation(Summary = "CreateRepresenter", Description = "CreateRepresenter ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_representer.CreateRepresenter", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_representer" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(CreateRepresenterEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<CreateRepresenterEndPointResponse>> HandleAsync([FromBody] CreateRepresenterEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting CreateRepresenter handling");
            var Appinput = _mapper.Map<CreateRepresenterHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<CreateRepresenterEndPointResponse>(result));
        }
    }
}
