using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;

namespace Pharmacy.Application.Business.Crud_representer.Query
{
    public class GetAllRepresentersHandler : IRequestHandler<GetAllRepresentersHandlerInput, GetAllRepresentersHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<GetAllRepresentersHandler> _logger;
        public GetAllRepresentersHandler(ILogger<GetAllRepresentersHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<GetAllRepresentersHandlerOutput> Handle(GetAllRepresentersHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling GetAllRepresenters business logic");
            GetAllRepresentersHandlerOutput output = new GetAllRepresentersHandlerOutput(request.CorrelationId());
            var allrepresenters = await _databaseService.representers.ToListAsync(cancellationToken);
            output.all_Representers = allrepresenters.Select(c => new All_Representers
            {
                Id = c.Id,
                NameAr = c.NameAr,
                NameEn = c.NameEn,
                distributed_Company_Id = c.distributed_Company_Id,
                phone = c.phone
            }).ToList();
            return output;
        }
    }
}
