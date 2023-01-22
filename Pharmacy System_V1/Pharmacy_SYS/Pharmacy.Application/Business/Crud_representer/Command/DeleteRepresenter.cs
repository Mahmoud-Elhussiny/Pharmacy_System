using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;
using Pharmacy.Core.CustomException;

namespace Pharmacy.Application.Business.Crud_representer.Command
{
    public class DeleteRepresenterHandler : IRequestHandler<DeleteRepresenterHandlerInput, DeleteRepresenterHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<DeleteRepresenterHandler> _logger;
        public DeleteRepresenterHandler(ILogger<DeleteRepresenterHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<DeleteRepresenterHandlerOutput> Handle(DeleteRepresenterHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling DeleteRepresenter business logic");
            DeleteRepresenterHandlerOutput output = new DeleteRepresenterHandlerOutput(request.CorrelationId());
            if (request.Id.Equals(0))
            {
                throw new WebApiException("id must be greater than 1");
            }
            var oldRepresenter = await _databaseService.representers.Where(i => i.Id == request.Id).FirstOrDefaultAsync(cancellationToken);
            if (oldRepresenter == null)
            {
                throw new WebApiException("The Representer Not Found");
            }
            _databaseService.representers.Remove(oldRepresenter);
            if (await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
            {
                throw new WebApiException("Error During Delete The Manufacturer");
            }
            output.Message = "Data Deleted Sucessfully";
            return output;
        }
    }
}
