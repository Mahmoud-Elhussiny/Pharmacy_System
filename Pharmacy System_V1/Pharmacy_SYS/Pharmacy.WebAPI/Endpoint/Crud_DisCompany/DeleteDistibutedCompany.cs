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
    public class DeleteDistibutedCompanyEndPoint : EndpointBaseAsync
    .WithRequest<DeleteDistibutedCompanyEndPointRequest>
    .WithActionResult<DeleteDistibutedCompanyEndPointResponse>
    {
        private readonly ILogger<DeleteDistibutedCompanyEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public DeleteDistibutedCompanyEndPoint(ILogger<DeleteDistibutedCompanyEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        [HttpDelete(DeleteDistibutedCompanyEndPointRequest.Route)]
        [SwaggerOperation(Summary = "DeleteDistibutedCompany", Description = "DeleteDistibutedCompany ", OperationId = "Pharmacy.WebAPI.Endpoint.Crud_DisCompany.DeleteDistibutedCompany", Tags = new[] { "Pharmacy.WebAPI.Endpoint.Crud_DisCompany" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(DeleteDistibutedCompanyEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<DeleteDistibutedCompanyEndPointResponse>> HandleAsync([FromQuery] DeleteDistibutedCompanyEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting DeleteDistibutedCompany handling");
            var Appinput = _mapper.Map<DeleteDistibutedCompanyHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<DeleteDistibutedCompanyEndPointResponse>(result));
        }
    }
}
