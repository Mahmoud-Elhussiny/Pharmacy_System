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
    public class Create_ItemTypeEndPoint : EndpointBaseAsync
    .WithRequest<Create_ItemTypeEndPointRequest>
    .WithActionResult<Create_ItemTypeEndPointResponse>
    {
        private readonly ILogger<Create_ItemTypeEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public Create_ItemTypeEndPoint(ILogger<Create_ItemTypeEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpPost(Create_ItemTypeEndPointRequest.Route)]
        [SwaggerOperation(Summary = "Create_ItemType", Description = "Create_ItemType ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_ItemTypes.Create_ItemType", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_ItemTypes" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(Create_ItemTypeEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<Create_ItemTypeEndPointResponse>> HandleAsync([FromBody] Create_ItemTypeEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting Create_ItemType handling");
            var Appinput = _mapper.Map<Create_ItemTypeHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<Create_ItemTypeEndPointResponse>(result));
        }
    }
}
