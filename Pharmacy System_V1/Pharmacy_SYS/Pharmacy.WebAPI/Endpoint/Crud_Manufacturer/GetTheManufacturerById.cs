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
    public class GetTheManufacturerByIdEndPoint : EndpointBaseAsync
    .WithRequest<GetTheManufacturerByIdEndPointRequest>
    .WithActionResult<GetTheManufacturerByIdEndPointResponse>
    {
        private readonly ILogger<GetTheManufacturerByIdEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public GetTheManufacturerByIdEndPoint(ILogger<GetTheManufacturerByIdEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
      
        [HttpGet(GetTheManufacturerByIdEndPointRequest.Route)]
        [SwaggerOperation(Summary = "GetTheManufacturerById", Description = "GetTheManufacturerById ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_Manufacturer.GetTheManufacturerById", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_Manufacturer" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(GetTheManufacturerByIdEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<GetTheManufacturerByIdEndPointResponse>> HandleAsync([FromQuery] GetTheManufacturerByIdEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting GetTheManufacturerById handling");
            var Appinput = _mapper.Map<GetTheManufacturerByIdHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<GetTheManufacturerByIdEndPointResponse>(result));
        }
    }
}
