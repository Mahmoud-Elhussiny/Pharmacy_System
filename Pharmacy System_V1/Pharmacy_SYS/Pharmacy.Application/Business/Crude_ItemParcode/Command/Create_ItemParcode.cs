using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.domain;

namespace Pharmacy.Application.Business.Crude_ItemParcode.Command
{
    public class Create_ItemParcodeHandler : IRequestHandler<Create_ItemParcodeHandlerInput, Create_ItemParcodeHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<Create_ItemParcodeHandler> _logger;
        public Create_ItemParcodeHandler(ILogger<Create_ItemParcodeHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<Create_ItemParcodeHandlerOutput> Handle(Create_ItemParcodeHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling Create_ItemParcode business logic");
            Create_ItemParcodeHandlerOutput output = new Create_ItemParcodeHandlerOutput(request.CorrelationId());

            var itemdetected = await _databaseService.items
                .FirstOrDefaultAsync(o => o.Id == request.itemId, cancellationToken);
            if (itemdetected == null)
                throw new Exception("this Item is Not Found");
            var newitemparcode = new ItemBarcode();
            newitemparcode.itemId = request.itemId;
            newitemparcode.batchNo = request.batchNo;
            newitemparcode.productionDate = request.productionDate;
            newitemparcode.codeGenerated = request.codeGenerated;
            



            return output;
        }
    }
}
