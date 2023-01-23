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
    public class GetAll_ItemsEndPoint : EndpointBaseAsync
    .WithRequest<GetAll_ItemsEndPointRequest>
    .WithActionResult<GetAll_ItemsEndPointResponse>
    {
        private readonly ILogger<GetAll_ItemsEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public GetAll_ItemsEndPoint(ILogger<GetAll_ItemsEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpGet(GetAll_ItemsEndPointRequest.Route)]
        [SwaggerOperation(Summary = "GetAll_Items", Description = "GetAll_Items ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_Items.GetAll_Items", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_Items" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(GetAll_ItemsEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<GetAll_ItemsEndPointResponse>> HandleAsync([FromQuery] GetAll_ItemsEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting GetAll_Items handling");
            var Appinput = _mapper.Map<GetAll_ItemsHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<GetAll_ItemsEndPointResponse>(result));
        }
    }
}
