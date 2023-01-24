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
    public class GetCalenderByIdEndPoint : EndpointBaseAsync
    .WithRequest<GetCalenderByIdEndPointRequest>
    .WithActionResult<GetCalenderByIdEndPointResponse>
    {
        private readonly ILogger<GetCalenderByIdEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public GetCalenderByIdEndPoint(ILogger<GetCalenderByIdEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpGet(GetCalenderByIdEndPointRequest.Route)]
        [SwaggerOperation(Summary = "GetCalenderById", Description = "GetCalenderById ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_Calenders.GetCalenderById", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_Calenders" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(GetCalenderByIdEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<GetCalenderByIdEndPointResponse>> HandleAsync([FromQuery] GetCalenderByIdEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting GetCalenderById handling");
            var Appinput = _mapper.Map<GetCalenderByIdHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<GetCalenderByIdEndPointResponse>(result));
        }
    }
}
