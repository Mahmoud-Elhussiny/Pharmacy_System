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
    public class UpdateTheManufacturerEndPoint : EndpointBaseAsync
    .WithRequest<UpdateTheManufacturerEndPointRequest>
    .WithActionResult<UpdateTheManufacturerEndPointResponse>
    {
        private readonly ILogger<UpdateTheManufacturerEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public UpdateTheManufacturerEndPoint(ILogger<UpdateTheManufacturerEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        [HttpPut(UpdateTheManufacturerEndPointRequest.Route)]
        [SwaggerOperation(Summary = "UpdateTheManufacturer", Description = "UpdateTheManufacturer ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_Manufacturer.UpdateTheManufacturer", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_Manufacturer" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(UpdateTheManufacturerEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<UpdateTheManufacturerEndPointResponse>> HandleAsync([FromBody] UpdateTheManufacturerEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting UpdateTheManufacturer handling");
            var Appinput = _mapper.Map<UpdateTheManufacturerHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<UpdateTheManufacturerEndPointResponse>(result));
        }
    }
}
