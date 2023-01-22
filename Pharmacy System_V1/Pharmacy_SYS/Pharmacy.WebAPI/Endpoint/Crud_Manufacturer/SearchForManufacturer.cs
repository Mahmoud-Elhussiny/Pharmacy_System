using Ardalis.ApiEndpoints;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_Manufacturer.Query;
using Pharmacy.Core.CustomException;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Pharmacy.WebAPI.Endpoint.Crud_Manufacturer
{
    public class SearchForManufacturerEndPoint : EndpointBaseAsync
    .WithRequest<SearchForManufacturerEndPointRequest>
    .WithActionResult<SearchForManufacturerEndPointResponse>
    {
        private readonly ILogger<SearchForManufacturerEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public SearchForManufacturerEndPoint(ILogger<SearchForManufacturerEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }

        [HttpGet(SearchForManufacturerEndPointRequest.Route)]
        [SwaggerOperation(Summary = "SearchForManufacturer", Description = "SearchForManufacturer ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_Manufacturer.SearchForManufacturer", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_Manufacturer" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(SearchForManufacturerEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<SearchForManufacturerEndPointResponse>> HandleAsync([FromQuery] SearchForManufacturerEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting SearchForManufacturer handling");
            var Appinput = _mapper.Map<SearchForManufacturerHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<SearchForManufacturerEndPointResponse>(result));
        }
    }
}
