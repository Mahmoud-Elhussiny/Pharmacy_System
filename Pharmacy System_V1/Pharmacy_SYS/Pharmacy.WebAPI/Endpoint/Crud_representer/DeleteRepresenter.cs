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
    public class DeleteRepresenterEndPoint : EndpointBaseAsync
    .WithRequest<DeleteRepresenterEndPointRequest>
    .WithActionResult<DeleteRepresenterEndPointResponse>
    {
        private readonly ILogger<DeleteRepresenterEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public DeleteRepresenterEndPoint(ILogger<DeleteRepresenterEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }

        [HttpDelete(DeleteRepresenterEndPointRequest.Route)]
        [SwaggerOperation(Summary = "DeleteRepresenter", Description = "DeleteRepresenter ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_representer.DeleteRepresenter", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_representer" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(DeleteRepresenterEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<DeleteRepresenterEndPointResponse>> HandleAsync([FromQuery] DeleteRepresenterEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting DeleteRepresenter handling");
            var Appinput = _mapper.Map<DeleteRepresenterHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<DeleteRepresenterEndPointResponse>(result));
        }
    }
}
