using Ardalis.ApiEndpoints;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_Manufacturer.Query;
using Pharmacy.Core.CustomException;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Pharmacy.WebAPI.Endpoint.Crud_Manufacturer
{
    public class GetAllManufacturersEndPoint : EndpointBaseAsync
    .WithRequest<GetAllManufacturersEndPointRequest>
    .WithActionResult<GetAllManufacturersEndPointResponse>
    {
        private readonly ILogger<GetAllManufacturersEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public GetAllManufacturersEndPoint(ILogger<GetAllManufacturersEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
      
        [HttpGet(GetAllManufacturersEndPointRequest.Route)]
        [SwaggerOperation(Summary = "GetAllManufacturers", Description = "GetAllManufacturers ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_Manufacturer.GetAllManufacturers", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_Manufacturer" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(GetAllManufacturersEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<GetAllManufacturersEndPointResponse>> HandleAsync([FromQuery] GetAllManufacturersEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting GetAllManufacturers handling");
            var Appinput = _mapper.Map<GetAllManufacturersHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<GetAllManufacturersEndPointResponse>(result));
        }
    }
}
