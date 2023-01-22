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
    public class SearchForDistributedCompanyEndPoint : EndpointBaseAsync
    .WithRequest<SearchForDistributedCompanyEndPointRequest>
    .WithActionResult<SearchForDistributedCompanyEndPointResponse>
    {
        private readonly ILogger<SearchForDistributedCompanyEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public SearchForDistributedCompanyEndPoint(ILogger<SearchForDistributedCompanyEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        [HttpGet(SearchForDistributedCompanyEndPointRequest.Route)]
        [SwaggerOperation(Summary = "SearchForDistributedCompany", Description = "SearchForDistributedCompany ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_DisCompany.SearchForDistributedCompany", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_DisCompany" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(SearchForDistributedCompanyEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<SearchForDistributedCompanyEndPointResponse>> HandleAsync([FromQuery] SearchForDistributedCompanyEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting SearchForDistributedCompany handling");
            var Appinput = _mapper.Map<SearchForDistributedCompanyHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<SearchForDistributedCompanyEndPointResponse>(result));
        }
    }
}
