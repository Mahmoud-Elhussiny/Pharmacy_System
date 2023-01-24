using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;

namespace Pharmacy.Application.Business.Crud_Calenders.Quary
{
    public class Search_CalenderHandler : IRequestHandler<Search_CalenderHandlerInput, Search_CalenderHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<Search_CalenderHandler> _logger;
        public Search_CalenderHandler(ILogger<Search_CalenderHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<Search_CalenderHandlerOutput> Handle(Search_CalenderHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling Search_Calender business logic");
            Search_CalenderHandlerOutput output = new Search_CalenderHandlerOutput(request.CorrelationId());

            var allClenders = await _databaseService.Calenders.Select(o => new SeachlistOfCalender
            {
                Id = o.Id,
                NameEn = o.NameEn,
                NameAr = o.NameAr
            }).ToListAsync(cancellationToken);

            if (!String.IsNullOrEmpty(request.NameEn))
                allClenders = allClenders.Where(o => o.NameEn.Contains(request.NameEn.Trim())).ToList();

            if (!String.IsNullOrEmpty(request.NameAr))
                allClenders = allClenders.Where(o => o.NameAr.Contains(request.NameAr.Trim())).ToList();

            output.resultcalenders = allClenders;

            return output;
        }
    }
}
