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
    public class CreateDistrbutedCompanyEndPoint : EndpointBaseAsync
    .WithRequest<CreateDistrbutedCompanyEndPointRequest>
    .WithActionResult<CreateDistrbutedCompanyEndPointResponse>
    {
        private readonly ILogger<CreateDistrbutedCompanyEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public CreateDistrbutedCompanyEndPoint(ILogger<CreateDistrbutedCompanyEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
       
        [HttpPost(CreateDistrbutedCompanyEndPointRequest.Route)]
        [SwaggerOperation(Summary = "CreateDistrbutedCompany", Description = "CreateDistrbutedCompany ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_DisCompany.CreateDistrbutedCompany", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_DisCompany" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(CreateDistrbutedCompanyEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<CreateDistrbutedCompanyEndPointResponse>> HandleAsync([FromBody] CreateDistrbutedCompanyEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting CreateDistrbutedCompany handling");
            var Appinput = _mapper.Map<CreateDistrbutedCompanyHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<CreateDistrbutedCompanyEndPointResponse>(result));
        }
    }
}
