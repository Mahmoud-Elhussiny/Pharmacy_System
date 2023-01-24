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
    public class Delete_CalenderEndPoint : EndpointBaseAsync
    .WithRequest<Delete_CalenderEndPointRequest>
    .WithActionResult<Delete_CalenderEndPointResponse>
    {
        private readonly ILogger<Delete_CalenderEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public Delete_CalenderEndPoint(ILogger<Delete_CalenderEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpDelete(Delete_CalenderEndPointRequest.Route)]
        [SwaggerOperation(Summary = "Delete_Calender", Description = "Delete_Calender ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_Calenders.Delete_Calender", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_Calenders" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(Delete_CalenderEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<Delete_CalenderEndPointResponse>> HandleAsync([FromQuery] Delete_CalenderEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting Delete_Calender handling");
            var Appinput = _mapper.Map<Delete_CalenderHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<Delete_CalenderEndPointResponse>(result));
        }
    }
}
