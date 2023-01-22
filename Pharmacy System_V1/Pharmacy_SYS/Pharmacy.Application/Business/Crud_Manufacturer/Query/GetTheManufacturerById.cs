using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;

namespace Pharmacy.Application.Business.Crud_Manufacturer.Query
{
    public class GetTheManufacturerByIdHandler : IRequestHandler<GetTheManufacturerByIdHandlerInput, GetTheManufacturerByIdHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<GetTheManufacturerByIdHandler> _logger;
        public GetTheManufacturerByIdHandler(ILogger<GetTheManufacturerByIdHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<GetTheManufacturerByIdHandlerOutput> Handle(GetTheManufacturerByIdHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling GetTheManufacturerById business logic");
            GetTheManufacturerByIdHandlerOutput output = new GetTheManufacturerByIdHandlerOutput(request.CorrelationId());
            if (request.Id.Equals(0))
            {
                throw new WebApiException("id must be greater than 1");
            }
            var Manufacturer = await _databaseService.TheManufacturer.Where(i => i.Id == request.Id).FirstOrDefaultAsync(cancellationToken);
            if (Manufacturer == null)
            {
                throw new WebApiException("The Manufacturer Not Found");
            }
            output.Id=Manufacturer.Id;
            output.NameAr=Manufacturer.NameAr;
            output.NameEn=Manufacturer.NameEn;
            output.Location=Manufacturer.Location;
            output.Phone=Manufacturer.Phone;
            return output;
        }
    }
}
