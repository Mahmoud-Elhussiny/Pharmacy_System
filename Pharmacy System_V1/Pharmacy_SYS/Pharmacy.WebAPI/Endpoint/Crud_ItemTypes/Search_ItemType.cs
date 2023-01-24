using Ardalis.ApiEndpoints;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Business.Crud_ItemTypes.Query;
using Pharmacy.Core.CustomException;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Pharmacy.WebAPI.Endpoint.Crud_ItemTypes
{
    public class Search_ItemTypeEndPoint : EndpointBaseAsync
    .WithRequest<Search_ItemTypeEndPointRequest>
    .WithActionResult<Search_ItemTypeEndPointResponse>
    {
        private readonly ILogger<Search_ItemTypeEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public Search_ItemTypeEndPoint(ILogger<Search_ItemTypeEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpGet(Search_ItemTypeEndPointRequest.Route)]
        [SwaggerOperation(Summary = "Search_ItemType", Description = "Search_ItemType ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_ItemTypes.Search_ItemType", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_ItemTypes" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(Search_ItemTypeEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<Search_ItemTypeEndPointResponse>> HandleAsync([FromQuery] Search_ItemTypeEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting Search_ItemType handling");
            var Appinput = _mapper.Map<Search_ItemTypeHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<Search_ItemTypeEndPointResponse>(result));
        }
    }
}
