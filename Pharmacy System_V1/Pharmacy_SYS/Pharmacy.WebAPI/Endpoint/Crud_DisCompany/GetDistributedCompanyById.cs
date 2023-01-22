using Ardalis.ApiEndpoints;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_DisCompany.Query;
using Pharmacy.Core.CustomException;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Pharmacy.WebAPI.Endpoint.Crud_DisCompany
{
    public class GetDistributedCompanyByIdEndPoint : EndpointBaseAsync
    .WithRequest<GetDistributedCompanyByIdEndPointRequest>
    .WithActionResult<GetDistributedCompanyByIdEndPointResponse>
    {
        private readonly ILogger<GetDistributedCompanyByIdEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public GetDistributedCompanyByIdEndPoint(ILogger<GetDistributedCompanyByIdEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        [HttpGet(GetDistributedCompanyByIdEndPointRequest.Route)]
        [SwaggerOperation(Summary = "GetDistributedCompanyById", Description = "GetDistributedCompanyById ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_DisCompany.GetDistributedCompanyById", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_DisCompany" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(GetDistributedCompanyByIdEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<GetDistributedCompanyByIdEndPointResponse>> HandleAsync([FromQuery] GetDistributedCompanyByIdEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting GetDistributedCompanyById handling");
            var Appinput = _mapper.Map<GetDistributedCompanyByIdHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<GetDistributedCompanyByIdEndPointResponse>(result));
        }
    }
}
