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
    public class Delete_ItemEndPoint : EndpointBaseAsync
    .WithRequest<Delete_ItemEndPointRequest>
    .WithActionResult<Delete_ItemEndPointResponse>
    {
        private readonly ILogger<Delete_ItemEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public Delete_ItemEndPoint(ILogger<Delete_ItemEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpDelete(Delete_ItemEndPointRequest.Route)]
        [SwaggerOperation(Summary = "Delete_Item", Description = "Delete_Item ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_Items.Delete_Item", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_Items" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(Delete_ItemEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<Delete_ItemEndPointResponse>> HandleAsync([FromQuery] Delete_ItemEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting Delete_Item handling");
            var Appinput = _mapper.Map<Delete_ItemHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<Delete_ItemEndPointResponse>(result));
        }
    }
}
