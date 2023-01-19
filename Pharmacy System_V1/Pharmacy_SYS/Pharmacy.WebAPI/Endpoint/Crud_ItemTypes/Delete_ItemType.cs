using Ardalis.ApiEndpoints;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Business.Crud_ItemTypes.Command;
using Pharmacy.Core.CustomException;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Pharmacy.WebAPI.Endpoint.Crud_ItemTypes
{
    public class Delete_ItemTypeEndPoint : EndpointBaseAsync
    .WithRequest<Delete_ItemTypeEndPointRequest>
    .WithActionResult<Delete_ItemTypeEndPointResponse>
    {
        private readonly ILogger<Delete_ItemTypeEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public Delete_ItemTypeEndPoint(ILogger<Delete_ItemTypeEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpDelete(Delete_ItemTypeEndPointRequest.Route)]
        [SwaggerOperation(Summary = "Delete_ItemType", Description = "Delete_ItemType ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_ItemTypes.Delete_ItemType", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_ItemTypes" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(Delete_ItemTypeEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<Delete_ItemTypeEndPointResponse>> HandleAsync([FromQuery] Delete_ItemTypeEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting Delete_ItemType handling");
            var Appinput = _mapper.Map<Delete_ItemTypeHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<Delete_ItemTypeEndPointResponse>(result));
        }
    }
}
