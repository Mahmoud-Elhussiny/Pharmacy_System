using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Pharmacy.Application.Contract;
using Pharmacy.Core.UserManagement;
using Pharmacy.domain;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Transactions;

namespace Pharmacy.Application.Business.UserManagment.Command
{
    public class LoginHandler : IRequestHandler<LoginHandlerInput, LoginHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<LoginHandler> _logger;
        private UserManager<ApplicationUser> _userManger;
        private IConfiguration _configuration;
        public LoginHandler(ILogger<LoginHandler> logger,
            IDatabaseService databaseService,
            IHttpContextAccessor contextAccessor,
            UserManager<ApplicationUser> userManager, IConfiguration configuration)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
            _userManger = userManager;
            _configuration = configuration;
        }
        public async Task<LoginHandlerOutput> Handle(LoginHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling Login business logic");
            LoginHandlerOutput output = new LoginHandlerOutput(request.CorrelationId());
            var user =await _userManger.FindByNameAsync(request.userName);
            if(user == null)
            {
                output.UserManagmentResponse = new UserManagementResponse
                {
                    Message = "User Not Found ",
                    IsSuccess = false,
                };
                return output;
            }
            var password =await _userManger.CheckPasswordAsync(user, request.Password);
            if(!password)
            {
                output.UserManagmentResponse = new UserManagementResponse
                {
                    Message = "Ivaild Password",
                    IsSuccess = false,
                };
                return output;
            }
           
            
            user.lastloginDate = DateTime.Now;

            await _userManger.UpdateAsync(user);


           
            var claims =   await _userManger.GetClaimsAsync(user);



            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["AuthSettings:Key"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["AuthSettings:Issuer"],
                audience: _configuration["AuthSettings:Audience"],
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256));

            string tokenAsString = new JwtSecurityTokenHandler().WriteToken(token);

            output.UserManagmentResponse = new UserManagementResponse
            {
                Message = tokenAsString,
                IsSuccess = true,
                ExpireDate = token.ValidTo
            };
            return output;
        }
    }
}
