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
    public class Search_CalenderEndPoint : EndpointBaseAsync
    .WithRequest<Search_CalenderEndPointRequest>
    .WithActionResult<Search_CalenderEndPointResponse>
    {
        private readonly ILogger<Search_CalenderEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public Search_CalenderEndPoint(ILogger<Search_CalenderEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpGet(Search_CalenderEndPointRequest.Route)]
        [SwaggerOperation(Summary = "Search_Calender", Description = "Search_Calender ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_Calenders.Search_Calender", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_Calenders" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(Search_CalenderEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<Search_CalenderEndPointResponse>> HandleAsync([FromQuery] Search_CalenderEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting Search_Calender handling");
            var Appinput = _mapper.Map<Search_CalenderHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<Search_CalenderEndPointResponse>(result));
        }
    }
}
