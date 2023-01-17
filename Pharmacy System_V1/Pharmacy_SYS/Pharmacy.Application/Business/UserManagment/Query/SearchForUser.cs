using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharmacy.Application.Contract;

namespace Pharmacy.Application.Business.UserManagment.Query
{
    public class SearchForUserHandler : IRequestHandler<SearchForUserHandlerInput, SearchForUserHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<SearchForUserHandler> _logger;
        public SearchForUserHandler(ILogger<SearchForUserHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<SearchForUserHandlerOutput> Handle(SearchForUserHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling SearchForUser business logic");
            SearchForUserHandlerOutput output = new SearchForUserHandlerOutput(request.CorrelationId());
            var AllPh_Users = await _databaseService.AppUser.ToListAsync(cancellationToken);
            if (!AllPh_Users.Any())
            {
                throw new Exception("There Are No Users");
            }
            if (!string.IsNullOrEmpty(request.firstName))
                AllPh_Users = AllPh_Users.Where(f => f.firstName == request.firstName).ToList();
            if(!string.IsNullOrEmpty(request.UserName))
                AllPh_Users = AllPh_Users.Where(u => u.UserName == request.UserName).ToList();
            if (!string.IsNullOrEmpty(request.Email))
                AllPh_Users= AllPh_Users.Where(E => E.Email == request.Email).ToList();
            if (request.isAdmin.HasValue)
                AllPh_Users = AllPh_Users.Where(A => A.isAdmin == request.isAdmin).ToList();
            output.phUsers = AllPh_Users.Select(o => new PH_Users {
                firstName = o.firstName,
                lastName = o.lastName,
                UserName = o.UserName,
                Address = o.Address,
                Email = o.Email,
                Phone1 = o.Phone1,
                Phone2 = o.Phone2,
                lastloginDate = (DateTime)o.lastloginDate!,
                timeCreated = (DateTime)o.timeCreated!
            }).ToList();
                return output;
        }
    }
}
