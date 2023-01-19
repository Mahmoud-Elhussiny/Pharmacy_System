using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;

namespace Pharmacy.Application.Business.Crud_ItemTypes.Query
{
    public class GetAll_ItemTypeHandler : IRequestHandler<GetAll_ItemTypeHandlerInput, GetAll_ItemTypeHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<GetAll_ItemTypeHandler> _logger;
        public GetAll_ItemTypeHandler(ILogger<GetAll_ItemTypeHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<GetAll_ItemTypeHandlerOutput> Handle(GetAll_ItemTypeHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling GetAll_ItemType business logic");
            GetAll_ItemTypeHandlerOutput output = new GetAll_ItemTypeHandlerOutput(request.CorrelationId());
            
            var allitemTypes = await _databaseService.itemTypes.Select(o=> new listItemtype
            {
                Id = o.Id,
                nameEn = o.nameEn,
                nameAr = o.nameAr
            }).ToListAsync(cancellationToken);

            output.listItemtypes = allitemTypes;

            return output;
        }
    }
}
