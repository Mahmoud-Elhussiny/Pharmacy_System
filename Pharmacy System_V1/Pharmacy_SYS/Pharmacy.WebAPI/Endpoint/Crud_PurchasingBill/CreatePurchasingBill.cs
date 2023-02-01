using Ardalis.ApiEndpoints;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_PurchasingBill.Command;
using Pharmacy.Core.CustomException;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Pharmacy.WebAPI.Endpoint.Crud_PurchasingBill
{
    public class CreatePurchasingBillEndPoint : EndpointBaseAsync
    .WithRequest<CreatePurchasingBillEndPointRequest>
    .WithActionResult<CreatePurchasingBillEndPointResponse>
    {
        private readonly ILogger<CreatePurchasingBillEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public CreatePurchasingBillEndPoint(ILogger<CreatePurchasingBillEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }

        [HttpPost(CreatePurchasingBillEndPointRequest.Route)]
        [SwaggerOperation(Summary = "CreatePurchasingBill", Description = "CreatePurchasingBill ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_PurchasingBill.CreatePurchasingBill", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_PurchasingBill" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(CreatePurchasingBillEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<CreatePurchasingBillEndPointResponse>> HandleAsync([FromBody] CreatePurchasingBillEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting CreatePurchasingBill handling");
            var Appinput = _mapper.Map<CreatePurchasingBillHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<CreatePurchasingBillEndPointResponse>(result));
        }
    }
}
