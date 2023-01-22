using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;

namespace Pharmacy.Application.Business.Crud_Manufacturer.Query
{
    public class GetAllManufacturersHandler : IRequestHandler<GetAllManufacturersHandlerInput, GetAllManufacturersHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<GetAllManufacturersHandler> _logger;
        public GetAllManufacturersHandler(ILogger<GetAllManufacturersHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<GetAllManufacturersHandlerOutput> Handle(GetAllManufacturersHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling GetAllManufacturers business logic");
            GetAllManufacturersHandlerOutput output = new GetAllManufacturersHandlerOutput(request.CorrelationId());
            var allmanufacturers = await _databaseService.TheManufacturer.ToListAsync(cancellationToken);
            output.all_Manufacturers = allmanufacturers.Select(c => new All_Manufacturers
            {
                Id = c.Id,
                NameAr=c.NameAr,
                NameEn=c.NameEn,
                Location=c.Location,
                Phone=c.Phone
            }).ToList();
            return output;
        }
    }
}
