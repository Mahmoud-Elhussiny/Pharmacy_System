using Ardalis.ApiEndpoints;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Business.Crud_Units.Command;
using Pharmacy.Core.CustomException;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Pharmacy.WebAPI.Endpoint.Crud_Units
{
    public class Delete_UnitsEndPoint : EndpointBaseAsync
    .WithRequest<Delete_UnitsEndPointRequest>
    .WithActionResult<Delete_UnitsEndPointResponse>
    {
        private readonly ILogger<Delete_UnitsEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public Delete_UnitsEndPoint(ILogger<Delete_UnitsEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpDelete(Delete_UnitsEndPointRequest.Route)]
        [SwaggerOperation(Summary = "Delete_Units", Description = "Delete_Units ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_Units.Delete_Units", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_Units" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(Delete_UnitsEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<Delete_UnitsEndPointResponse>> HandleAsync([FromQuery] Delete_UnitsEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting Delete_Units handling");
            var Appinput = _mapper.Map<Delete_UnitsHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<Delete_UnitsEndPointResponse>(result));
        }
    }
}
