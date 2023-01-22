using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;

namespace Pharmacy.Application.Business.Crud_representer.Query
{
    public class GetRepresenterByIdHandler : IRequestHandler<GetRepresenterByIdHandlerInput, GetRepresenterByIdHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<GetRepresenterByIdHandler> _logger;
        public GetRepresenterByIdHandler(ILogger<GetRepresenterByIdHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<GetRepresenterByIdHandlerOutput> Handle(GetRepresenterByIdHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling GetRepresenterById business logic");
            GetRepresenterByIdHandlerOutput output = new GetRepresenterByIdHandlerOutput(request.CorrelationId());
            if (request.Id.Equals(0))
            {
                throw new WebApiException("id must be greater than 1");
            }
            var representer = await _databaseService.representers.Where(i => i.Id == request.Id).FirstOrDefaultAsync(cancellationToken);
            if (representer == null)
            {
                throw new WebApiException("The Representer Not Found");
            }
            output.Id = representer.Id;
            output.NameAr = representer.NameAr;
            output.NameEn = representer.NameEn;
            output.distributed_Company_Id =representer.distributed_Company_Id;
            output.phone = representer.phone;
            return output;
        }
    }
}
