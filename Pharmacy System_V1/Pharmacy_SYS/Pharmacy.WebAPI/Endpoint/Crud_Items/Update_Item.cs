using Ardalis.ApiEndpoints;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Business.Crud_Items.Command;
using Pharmacy.Core.CustomException;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Pharmacy.WebAPI.Endpoint.Crud_Items
{
    public class Update_ItemEndPoint : EndpointBaseAsync
    .WithRequest<Update_ItemEndPointRequest>
    .WithActionResult<Update_ItemEndPointResponse>
    {
        private readonly ILogger<Update_ItemEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public Update_ItemEndPoint(ILogger<Update_ItemEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpPut(Update_ItemEndPointRequest.Route)]
        [SwaggerOperation(Summary = "Update_Item", Description = "Update_Item ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_Items.Update_Item", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_Items" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(Update_ItemEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<Update_ItemEndPointResponse>> HandleAsync([FromBody] Update_ItemEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting Update_Item handling");
            var Appinput = _mapper.Map<Update_ItemHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<Update_ItemEndPointResponse>(result));
        }
    }
}
