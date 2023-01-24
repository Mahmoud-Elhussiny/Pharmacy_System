using Ardalis.ApiEndpoints;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Business.Crud_Calenders.Quary;
using Pharmacy.Core.CustomException;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Pharmacy.WebAPI.Endpoint.Crud_Calenders
{
    public class GetAll_CalendersEndPoint : EndpointBaseAsync
    .WithRequest<GetAll_CalendersEndPointRequest>
    .WithActionResult<GetAll_CalendersEndPointResponse>
    {
        private readonly ILogger<GetAll_CalendersEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public GetAll_CalendersEndPoint(ILogger<GetAll_CalendersEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpGet(GetAll_CalendersEndPointRequest.Route)]
        [SwaggerOperation(Summary = "GetAll_Calenders", Description = "GetAll_Calenders ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_Calenders.GetAll_Calenders", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_Calenders" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(GetAll_CalendersEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<GetAll_CalendersEndPointResponse>> HandleAsync([FromQuery] GetAll_CalendersEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting GetAll_Calenders handling");
            var Appinput = _mapper.Map<GetAll_CalendersHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<GetAll_CalendersEndPointResponse>(result));
        }
    }
}
