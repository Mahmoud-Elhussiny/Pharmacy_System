using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;

namespace Pharmacy.Application.Business.Crud_representer.Command
{
    public class UpdateRepresnterHandler : IRequestHandler<UpdateRepresnterHandlerInput, UpdateRepresnterHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<UpdateRepresnterHandler> _logger;
        public UpdateRepresnterHandler(ILogger<UpdateRepresnterHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<UpdateRepresnterHandlerOutput> Handle(UpdateRepresnterHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling UpdateRepresnter business logic");
            UpdateRepresnterHandlerOutput output = new UpdateRepresnterHandlerOutput(request.CorrelationId());
            if (request.Id.Equals(0))
            {
                throw new WebApiException("id must be greater than 1");
            }
            var oldRepresenter = await _databaseService.representers.Where(i => i.Id == request.Id).FirstOrDefaultAsync(cancellationToken);
            if (oldRepresenter == null)
            {
                throw new WebApiException("The Representer Not Found");
            }
            if (!string.IsNullOrEmpty(request.NameAr))
                oldRepresenter.NameAr = request.NameAr.Trim();
            if (!string.IsNullOrEmpty(request.NameEn))
                oldRepresenter.NameEn = request.NameEn.Trim();
            if (!string.IsNullOrEmpty(request.phone))
                oldRepresenter.phone = request.phone;
            if (request.distributed_Company_Id.HasValue)
                oldRepresenter.distributed_Company_Id = (int)request.distributed_Company_Id;
            _databaseService.representers.Update(oldRepresenter);
            if (await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
            {
                throw new WebApiException("Error During Updating");
            }
            output.Message = "Data Updated Sucessfully";
            return output;
        }
    }
}
