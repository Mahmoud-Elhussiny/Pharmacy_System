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
    public class DeleteTheManufacturerEndPoint : EndpointBaseAsync
    .WithRequest<DeleteTheManufacturerEndPointRequest>
    .WithActionResult<DeleteTheManufacturerEndPointResponse>
    {
        private readonly ILogger<DeleteTheManufacturerEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public DeleteTheManufacturerEndPoint(ILogger<DeleteTheManufacturerEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
       
        [HttpDelete(DeleteTheManufacturerEndPointRequest.Route)]
        [SwaggerOperation(Summary = "DeleteTheManufacturer", Description = "DeleteTheManufacturer ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_Manufacturer.DeleteTheManufacturer", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_Manufacturer" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(DeleteTheManufacturerEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<DeleteTheManufacturerEndPointResponse>> HandleAsync([FromQuery] DeleteTheManufacturerEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting DeleteTheManufacturer handling");
            var Appinput = _mapper.Map<DeleteTheManufacturerHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<DeleteTheManufacturerEndPointResponse>(result));
        }
    }
}
