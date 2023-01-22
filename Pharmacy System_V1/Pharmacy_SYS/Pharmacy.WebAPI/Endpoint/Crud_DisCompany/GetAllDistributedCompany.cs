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
    public class GetAllDistributedCompanyEndPoint : EndpointBaseAsync
    .WithRequest<GetAllDistributedCompanyEndPointRequest>
    .WithActionResult<GetAllDistributedCompanyEndPointResponse>
    {
        private readonly ILogger<GetAllDistributedCompanyEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public GetAllDistributedCompanyEndPoint(ILogger<GetAllDistributedCompanyEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        [HttpGet(GetAllDistributedCompanyEndPointRequest.Route)]
        [SwaggerOperation(Summary = "GetAllDistributedCompany", Description = "GetAllDistributedCompany ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_DisCompany.GetAllDistributedCompany", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_DisCompany" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(GetAllDistributedCompanyEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<GetAllDistributedCompanyEndPointResponse>> HandleAsync([FromQuery] GetAllDistributedCompanyEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting GetAllDistributedCompany handling");
            var Appinput = _mapper.Map<GetAllDistributedCompanyHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<GetAllDistributedCompanyEndPointResponse>(result));
        }
    }
}
