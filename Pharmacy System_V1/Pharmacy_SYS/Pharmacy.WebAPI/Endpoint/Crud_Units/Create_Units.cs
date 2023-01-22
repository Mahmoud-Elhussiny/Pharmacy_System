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
    public class Create_UnitsEndPoint : EndpointBaseAsync
    .WithRequest<Create_UnitsEndPointRequest>
    .WithActionResult<Create_UnitsEndPointResponse>
    {
        private readonly ILogger<Create_UnitsEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public Create_UnitsEndPoint(ILogger<Create_UnitsEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpPost(Create_UnitsEndPointRequest.Route)]
        [SwaggerOperation(Summary = "Create_Units", Description = "Create_Units ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_Units.Create_Units", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_Units" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(Create_UnitsEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<Create_UnitsEndPointResponse>> HandleAsync([FromBody] Create_UnitsEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting Create_Units handling");
            var Appinput = _mapper.Map<Create_UnitsHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<Create_UnitsEndPointResponse>(result));
        }
    }
}
