using Ardalis.ApiEndpoints;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Business.Crud_ItemTypes.Query;
using Pharmacy.Core.CustomException;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Pharmacy.WebAPI.Endpoint.Crud_ItemTypes
{
    public class GetAll_ItemTypeEndPoint : EndpointBaseAsync
    .WithRequest<GetAll_ItemTypeEndPointRequest>
    .WithActionResult<GetAll_ItemTypeEndPointResponse>
    {
        private readonly ILogger<GetAll_ItemTypeEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public GetAll_ItemTypeEndPoint(ILogger<GetAll_ItemTypeEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpGet(GetAll_ItemTypeEndPointRequest.Route)]
        [SwaggerOperation(Summary = "GetAll_ItemType", Description = "GetAll_ItemType ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_ItemTypes.GetAll_ItemType", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_ItemTypes" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(GetAll_ItemTypeEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<GetAll_ItemTypeEndPointResponse>> HandleAsync([FromQuery] GetAll_ItemTypeEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting GetAll_ItemType handling");
            var Appinput = _mapper.Map<GetAll_ItemTypeHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<GetAll_ItemTypeEndPointResponse>(result));
        }
    }
}
