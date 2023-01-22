using Ardalis.ApiEndpoints;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_DisCompany.Command;
using Pharmacy.Core.CustomException;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Pharmacy.WebAPI.Endpoint.Crud_DisCompany
{
    public class UpdateDistributedCompanyEndPoint : EndpointBaseAsync
    .WithRequest<UpdateDistributedCompanyEndPointRequest>
    .WithActionResult<UpdateDistributedCompanyEndPointResponse>
    {
        private readonly ILogger<UpdateDistributedCompanyEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public UpdateDistributedCompanyEndPoint(ILogger<UpdateDistributedCompanyEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        [HttpPut(UpdateDistributedCompanyEndPointRequest.Route)]
        [SwaggerOperation(Summary = "UpdateDistributedCompany", Description = "UpdateDistributedCompany ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_DisCompany.UpdateDistributedCompany", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_DisCompany" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(UpdateDistributedCompanyEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<UpdateDistributedCompanyEndPointResponse>> HandleAsync([FromBody] UpdateDistributedCompanyEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting UpdateDistributedCompany handling");
            var Appinput = _mapper.Map<UpdateDistributedCompanyHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<UpdateDistributedCompanyEndPointResponse>(result));
        }
    }
}
