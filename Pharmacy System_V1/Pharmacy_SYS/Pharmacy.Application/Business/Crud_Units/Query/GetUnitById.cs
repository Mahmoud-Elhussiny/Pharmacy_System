using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;

namespace Pharmacy.Application.Business.Crud_Units.Query
{
    public class GetUnitByIdHandler : IRequestHandler<GetUnitByIdHandlerInput, GetUnitByIdHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<GetUnitByIdHandler> _logger;
        public GetUnitByIdHandler(ILogger<GetUnitByIdHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<GetUnitByIdHandlerOutput> Handle(GetUnitByIdHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling GetUnitById business logic");
            GetUnitByIdHandlerOutput output = new GetUnitByIdHandlerOutput(request.CorrelationId());

            var singleUnit = await _databaseService.units.FirstOrDefaultAsync(o => o.Id == request.Id);

            if(singleUnit== null)
            {
                throw new WebApiException("this Unit Is Not Found");
            }

            output.Id = singleUnit.Id;
            output.nameEn = singleUnit.nameEn;
            output.nameAr = singleUnit.nameAr;

            return output;
        }
    }
}
