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
    public class GetItemTypeByIdEndPoint : EndpointBaseAsync
    .WithRequest<GetItemTypeByIdEndPointRequest>
    .WithActionResult<GetItemTypeByIdEndPointResponse>
    {
        private readonly ILogger<GetItemTypeByIdEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public GetItemTypeByIdEndPoint(ILogger<GetItemTypeByIdEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpGet(GetItemTypeByIdEndPointRequest.Route)]
        [SwaggerOperation(Summary = "GetItemTypeById", Description = "GetItemTypeById ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_ItemTypes.GetItemTypeById", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_ItemTypes" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(GetItemTypeByIdEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<GetItemTypeByIdEndPointResponse>> HandleAsync([FromQuery] GetItemTypeByIdEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting GetItemTypeById handling");
            var Appinput = _mapper.Map<GetItemTypeByIdHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<GetItemTypeByIdEndPointResponse>(result));
        }
    }
}
