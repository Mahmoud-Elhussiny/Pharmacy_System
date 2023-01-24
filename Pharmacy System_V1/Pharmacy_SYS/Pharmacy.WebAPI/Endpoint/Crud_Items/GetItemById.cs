using Ardalis.ApiEndpoints;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Business.Crud_Items.Query;
using Pharmacy.Core.CustomException;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Pharmacy.WebAPI.Endpoint.Crud_Items
{
    public class GetItemByIdEndPoint : EndpointBaseAsync
    .WithRequest<GetItemByIdEndPointRequest>
    .WithActionResult<GetItemByIdEndPointResponse>
    {
        private readonly ILogger<GetItemByIdEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public GetItemByIdEndPoint(ILogger<GetItemByIdEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpGet(GetItemByIdEndPointRequest.Route)]
        [SwaggerOperation(Summary = "GetItemById", Description = "GetItemById ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_Items.GetItemById", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_Items" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(GetItemByIdEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<GetItemByIdEndPointResponse>> HandleAsync([FromQuery] GetItemByIdEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting GetItemById handling");
            var Appinput = _mapper.Map<GetItemByIdHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<GetItemByIdEndPointResponse>(result));
        }
    }
}
