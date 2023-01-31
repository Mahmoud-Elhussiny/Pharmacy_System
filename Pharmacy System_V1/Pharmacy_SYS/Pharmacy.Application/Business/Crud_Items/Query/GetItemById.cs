using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;

namespace Pharmacy.Application.Business.Crud_Items.Query
{
    public class GetItemByIdHandler : IRequestHandler<GetItemByIdHandlerInput, GetItemByIdHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<GetItemByIdHandler> _logger;
        public GetItemByIdHandler(ILogger<GetItemByIdHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<GetItemByIdHandlerOutput> Handle(GetItemByIdHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling GetItemById business logic");
            GetItemByIdHandlerOutput output = new GetItemByIdHandlerOutput(request.CorrelationId());
            var itemSelected = await _databaseService.items.Where(o => o.Id == request.Id).FirstOrDefaultAsync(cancellationToken);

            if (itemSelected == null)
                throw new WebApiException("this Item Is Not Found");
            output.Id = itemSelected.Id;
            output.tradeNameEn = itemSelected.tradeNameEn;
            output.tradeNameAr = itemSelected.tradeNameAr;
            output.chemicalName = itemSelected.chemicalName;
            output.Code = itemSelected.Code;
            output.molality = itemSelected.molality;
            output.duration = itemSelected.duration;
            output.buyingPrice = itemSelected.buyingPrice;
            output.sellingPrice = itemSelected.sellingPrice;
            output.itemtypeId = itemSelected.itemtypeId;
            output.manufactureId = itemSelected.manufactureId;
            output.distributedId = itemSelected.distributedId;
            output.clenderId = itemSelected.clenderId;

            return output;
        }
    }
}
