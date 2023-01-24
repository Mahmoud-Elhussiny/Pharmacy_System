using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;

namespace Pharmacy.Application.Business.Crud_Calenders.Quary
{
    public class GetCalenderByIdHandler : IRequestHandler<GetCalenderByIdHandlerInput, GetCalenderByIdHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<GetCalenderByIdHandler> _logger;
        public GetCalenderByIdHandler(ILogger<GetCalenderByIdHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<GetCalenderByIdHandlerOutput> Handle(GetCalenderByIdHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling GetCalenderById business logic");
            GetCalenderByIdHandlerOutput output = new GetCalenderByIdHandlerOutput(request.CorrelationId());

            var calenderSelected = await _databaseService
                .Calenders.FirstOrDefaultAsync(o => o.Id == request.Id,cancellationToken);

            if (calenderSelected == null)
                throw new WebApiException("this Calender is not found");

            output.Id = calenderSelected.Id;
            output.NameEn = calenderSelected.NameEn;
            output.NameAr = calenderSelected.NameAr;

            return output;

        }
    }
}
