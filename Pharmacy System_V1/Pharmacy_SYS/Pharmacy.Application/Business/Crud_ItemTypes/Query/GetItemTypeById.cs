using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;

namespace Pharmacy.Application.Business.Crud_ItemTypes.Query
{
    public class GetItemTypeByIdHandler : IRequestHandler<GetItemTypeByIdHandlerInput, GetItemTypeByIdHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<GetItemTypeByIdHandler> _logger;
        public GetItemTypeByIdHandler(ILogger<GetItemTypeByIdHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<GetItemTypeByIdHandlerOutput> Handle(GetItemTypeByIdHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling GetItemTypeById business logic");
            GetItemTypeByIdHandlerOutput output = new GetItemTypeByIdHandlerOutput(request.CorrelationId());

            var itemType = await _databaseService.itemTypes
                .Where(o => o.Id == request.Id).FirstOrDefaultAsync(cancellationToken);
            if (itemType == null)
            {
                throw new WebApiException("this item type is not found");
            }

            output.Id = itemType.Id;
            output.nameEn = itemType.nameEn;
            output.nameAr = itemType.nameAr;

            return output;
        }
    }
}
