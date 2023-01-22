using Ardalis.ApiEndpoints;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_Manufacturer.Command;
using Pharmacy.Core.CustomException;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Pharmacy.WebAPI.Endpoint.Crud_Manufacturer
{
    public class CreateTheManufacturerEndPoint : EndpointBaseAsync
    .WithRequest<CreateTheManufacturerEndPointRequest>
    .WithActionResult<CreateTheManufacturerEndPointResponse>
    {
        private readonly ILogger<CreateTheManufacturerEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public CreateTheManufacturerEndPoint(ILogger<CreateTheManufacturerEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
      
        [HttpPost(CreateTheManufacturerEndPointRequest.Route)]
        [SwaggerOperation(Summary = "CreateTheManufacturer", Description = "CreateTheManufacturer ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_Manufacturer.CreateTheManufacturer", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_Manufacturer" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(CreateTheManufacturerEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<CreateTheManufacturerEndPointResponse>> HandleAsync([FromBody] CreateTheManufacturerEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting CreateTheManufacturer handling");
            var Appinput = _mapper.Map<CreateTheManufacturerHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<CreateTheManufacturerEndPointResponse>(result));
        }
    }
}
