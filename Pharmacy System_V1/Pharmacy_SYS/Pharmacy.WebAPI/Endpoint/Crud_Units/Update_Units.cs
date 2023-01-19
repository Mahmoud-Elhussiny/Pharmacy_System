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
    public class Update_UnitsEndPoint : EndpointBaseAsync
    .WithRequest<Update_UnitsEndPointRequest>
    .WithActionResult<Update_UnitsEndPointResponse>
    {
        private readonly ILogger<Update_UnitsEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public Update_UnitsEndPoint(ILogger<Update_UnitsEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpPut(Update_UnitsEndPointRequest.Route)]
        [SwaggerOperation(Summary = "Update_Units", Description = "Update_Units ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_Units.Update_Units", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_Units" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(Update_UnitsEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<Update_UnitsEndPointResponse>> HandleAsync([FromBody] Update_UnitsEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting Update_Units handling");
            var Appinput = _mapper.Map<Update_UnitsHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<Update_UnitsEndPointResponse>(result));
        }
    }
}
