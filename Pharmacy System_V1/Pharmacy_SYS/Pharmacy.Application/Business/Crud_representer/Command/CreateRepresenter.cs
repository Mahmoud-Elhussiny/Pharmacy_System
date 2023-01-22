using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;
using Pharmacy.domain;

namespace Pharmacy.Application.Business.Crud_representer.Command
{
    public class CreateRepresenterHandler : IRequestHandler<CreateRepresenterHandlerInput, CreateRepresenterHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<CreateRepresenterHandler> _logger;
        public CreateRepresenterHandler(ILogger<CreateRepresenterHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<CreateRepresenterHandlerOutput> Handle(CreateRepresenterHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling CreateRepresenter business logic");
            CreateRepresenterHandlerOutput output = new CreateRepresenterHandlerOutput(request.CorrelationId());
            var represnter = new Representer();
            represnter.NameAr = request.NameAr.Trim();
            represnter.NameEn = request.NameEn.Trim();
            represnter.distributed_Company_Id = request.distributed_Company_Id;
            represnter.phone = request.phone;
            await _databaseService.representers.AddAsync(represnter);
            if (await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
            {
                throw new WebApiException("Error During Saving");
            }
            output.Message = "Data Saved Sucessfully";
            return output;
        }
    }
}
