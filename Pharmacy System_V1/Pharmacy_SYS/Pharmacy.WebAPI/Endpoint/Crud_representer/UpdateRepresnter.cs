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
    public class UpdateRepresnterEndPoint : EndpointBaseAsync
    .WithRequest<UpdateRepresnterEndPointRequest>
    .WithActionResult<UpdateRepresnterEndPointResponse>
    {
        private readonly ILogger<UpdateRepresnterEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public UpdateRepresnterEndPoint(ILogger<UpdateRepresnterEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }

        [HttpPut(UpdateRepresnterEndPointRequest.Route)]
        [SwaggerOperation(Summary = "UpdateRepresnter", Description = "UpdateRepresnter ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_representer.UpdateRepresnter", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_representer" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(UpdateRepresnterEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<UpdateRepresnterEndPointResponse>> HandleAsync([FromBody] UpdateRepresnterEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting UpdateRepresnter handling");
            var Appinput = _mapper.Map<UpdateRepresnterHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<UpdateRepresnterEndPointResponse>(result));
        }
    }
}
