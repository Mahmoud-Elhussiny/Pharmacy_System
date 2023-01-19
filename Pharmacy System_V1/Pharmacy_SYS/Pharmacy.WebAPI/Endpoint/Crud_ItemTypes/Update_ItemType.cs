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
    public class Update_ItemTypeEndPoint : EndpointBaseAsync
    .WithRequest<Update_ItemTypeEndPointRequest>
    .WithActionResult<Update_ItemTypeEndPointResponse>
    {
        private readonly ILogger<Update_ItemTypeEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public Update_ItemTypeEndPoint(ILogger<Update_ItemTypeEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpPut(Update_ItemTypeEndPointRequest.Route)]
        [SwaggerOperation(Summary = "Update_ItemType", Description = "Update_ItemType ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_ItemTypes.Update_ItemType", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_ItemTypes" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(Update_ItemTypeEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<Update_ItemTypeEndPointResponse>> HandleAsync([FromBody] Update_ItemTypeEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting Update_ItemType handling");
            var Appinput = _mapper.Map<Update_ItemTypeHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<Update_ItemTypeEndPointResponse>(result));
        }
    }
}
