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
    public class Create_CalenderEndPoint : EndpointBaseAsync
    .WithRequest<Create_CalenderEndPointRequest>
    .WithActionResult<Create_CalenderEndPointResponse>
    {
        private readonly ILogger<Create_CalenderEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public Create_CalenderEndPoint(ILogger<Create_CalenderEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpPost(Create_CalenderEndPointRequest.Route)]
        [SwaggerOperation(Summary = "Create_Calender", Description = "Create_Calender ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_Calenders.Create_Calender", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_Calenders" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(Create_CalenderEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<Create_CalenderEndPointResponse>> HandleAsync([FromBody] Create_CalenderEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting Create_Calender handling");
            var Appinput = _mapper.Map<Create_CalenderHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<Create_CalenderEndPointResponse>(result));
        }
    }
}
