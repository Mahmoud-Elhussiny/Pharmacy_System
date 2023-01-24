using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;

namespace Pharmacy.Application.Business.Crud_Calenders.Quary
{
    public class GetAll_CalendersHandler : IRequestHandler<GetAll_CalendersHandlerInput, GetAll_CalendersHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<GetAll_CalendersHandler> _logger;
        public GetAll_CalendersHandler(ILogger<GetAll_CalendersHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<GetAll_CalendersHandlerOutput> Handle(GetAll_CalendersHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling GetAll_Calenders business logic");
            GetAll_CalendersHandlerOutput output = new GetAll_CalendersHandlerOutput(request.CorrelationId());
            
            var allClenders = await _databaseService.Calenders.Select(o=> new listOfCalender
            {
                Id = o.Id,
                NameEn = o.NameEn,
                NameAr = o.NameAr
            }).ToListAsync(cancellationToken);

            output.listOfCalenders = allClenders;

            return output;
        }
    }
}
