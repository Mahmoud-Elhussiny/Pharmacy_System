using Ardalis.ApiEndpoints;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Business.Crud_Items.Query;
using Pharmacy.Core.CustomException;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Pharmacy.WebAPI.Endpoint.Crud_Items
{
    public class Search_ItemEndPoint : EndpointBaseAsync
    .WithRequest<Search_ItemEndPointRequest>
    .WithActionResult<Search_ItemEndPointResponse>
    {
        private readonly ILogger<Search_ItemEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public Search_ItemEndPoint(ILogger<Search_ItemEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpGet(Search_ItemEndPointRequest.Route)]
        [SwaggerOperation(Summary = "Search_Item", Description = "Search_Item ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_Items.Search_Item", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_Items" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(Search_ItemEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<Search_ItemEndPointResponse>> HandleAsync([FromQuery] Search_ItemEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting Search_Item handling");
            var Appinput = _mapper.Map<Search_ItemHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<Search_ItemEndPointResponse>(result));
        }
    }
}
