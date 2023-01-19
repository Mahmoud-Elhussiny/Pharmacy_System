using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;
using Pharmacy.domain;

namespace Pharmacy.Application.Business.Crud_ItemTypes.Command
{
    public class Create_ItemTypeHandler : IRequestHandler<Create_ItemTypeHandlerInput, Create_ItemTypeHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<Create_ItemTypeHandler> _logger;
        public Create_ItemTypeHandler(ILogger<Create_ItemTypeHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<Create_ItemTypeHandlerOutput> Handle(Create_ItemTypeHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling Create_ItemType business logic");
            Create_ItemTypeHandlerOutput output = new Create_ItemTypeHandlerOutput(request.CorrelationId());
            var newitmType = new ItemType();

            newitmType.nameEn = request.nameEn;
            newitmType.nameAr = request.nameAr;

            await _databaseService.itemTypes.AddAsync(newitmType, cancellationToken);

            if (await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
            {
                throw new WebApiException("Can't created data");
            }

            output.Message = "data Created Successfully";

            return output;
        }
    }
}
