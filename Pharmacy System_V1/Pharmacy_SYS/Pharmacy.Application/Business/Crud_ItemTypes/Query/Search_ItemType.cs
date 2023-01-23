using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;

namespace Pharmacy.Application.Business.Crud_ItemTypes.Query
{
    public class Search_ItemTypeHandler : IRequestHandler<Search_ItemTypeHandlerInput, Search_ItemTypeHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<Search_ItemTypeHandler> _logger;
        public Search_ItemTypeHandler(ILogger<Search_ItemTypeHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<Search_ItemTypeHandlerOutput> Handle(Search_ItemTypeHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling Search_ItemType business logic");
            Search_ItemTypeHandlerOutput output = new Search_ItemTypeHandlerOutput(request.CorrelationId());

            var allitemTypes = await _databaseService.itemTypes.Select(o => new SearchlistItemtype
            {
                Id = o.Id,
                nameEn = o.nameEn,
                nameAr = o.nameAr
            }).ToListAsync(cancellationToken);

            if(!String.IsNullOrEmpty(request.nameEn))
                allitemTypes = allitemTypes.Where(o=>o.nameEn.StartsWith(request.nameEn.Trim())).ToList();

            if (!String.IsNullOrEmpty(request.nameAr))
                allitemTypes = allitemTypes.Where(o => o.nameAr.StartsWith(request.nameAr.Trim())).ToList();


            output.searchlistItemtypes = allitemTypes;


            return output;
        }
    }
}
