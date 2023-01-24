using Ardalis.ApiEndpoints;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Business.Crud_Calenders.Command;
using Pharmacy.Core.CustomException;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Pharmacy.WebAPI.Endpoint.Crud_Calenders
{
    public class Update_CalenderEndPoint : EndpointBaseAsync
    .WithRequest<Update_CalenderEndPointRequest>
    .WithActionResult<Update_CalenderEndPointResponse>
    {
        private readonly ILogger<Update_CalenderEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public Update_CalenderEndPoint(ILogger<Update_CalenderEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpPut(Update_CalenderEndPointRequest.Route)]
        [SwaggerOperation(Summary = "Update_Calender", Description = "Update_Calender ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_Calenders.Update_Calender", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_Calenders" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(Update_CalenderEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<Update_CalenderEndPointResponse>> HandleAsync([FromBody] Update_CalenderEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting Update_Calender handling");
            var Appinput = _mapper.Map<Update_CalenderHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<Update_CalenderEndPointResponse>(result));
        }
    }
}
