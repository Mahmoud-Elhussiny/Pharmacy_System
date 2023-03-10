using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Pharmacy.Application.Contract;
using Pharmacy.domain;
using Pharmacy.Persistence.Context;
using Pharmacy.Application.DependencyInjectionApplication;
using System;
using System.Reflection;
using System.Text;
using Pharmacy.Core.Services;
using Microsoft.AspNetCore.Diagnostics;
using Pharmacy.Core.CustomException;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


builder.Services.AddDbContext<DatabaseService>(option =>

    option.UseSqlServer(builder.Configuration.GetConnectionString("PharmacyConnection"))
);

builder.Services.AddScoped<IDatabaseService,DatabaseService>();

builder.Services.AddScoped<IDatabaseService>(provider => provider.GetService<DatabaseService>());

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IMailService, SendGridMailService>();


builder.Services.AddAuthentication(auth =>
{
    auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = builder.Configuration["AuthSettings:Audience"],
        ValidIssuer = builder.Configuration["AuthSettings:Issuer"],
        RequireExpirationTime = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["AuthSettings:Key"])),
        ValidateIssuerSigningKey = true
    };
});

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddApplicationServices();


//builder.Services.AddMediatR(typeof(DatabaseService).Assembly);
//builder.Services.AddAutoMapper(typeof(Program).Assembly);


builder.Services.AddHttpContextAccessor();

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(option =>
{
    option.Password.RequireDigit = true;
    option.Password.RequireLowercase = true;
    option.Password.RequireNonAlphanumeric = false;
    option.Password.RequireUppercase = false;
    option.Password.RequiredLength = 6;
}).AddEntityFrameworkStores<DatabaseService>().AddDefaultTokenProviders();
//builder.WebHost.UseKestrel(option => option.AddServerHeader = false);
var app = builder.Build();

//using (var scope = app.Services.CreateAsyncScope())
//{
//    scope.ServiceProvider.GetRequiredService<IDatabaseService>();
//}



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseExceptionHandler(delegate (IApplicationBuilder appError)
{
    appError.Run(async delegate (HttpContext context)
    {
        context.Response.ContentType = "application/json";
        IExceptionHandlerFeature contextFeature = context.Features.Get<IExceptionHandlerFeature>();
        if (contextFeature != null)
        {
            context.Response.StatusCode = 400;
            Exception error = contextFeature.Error;
            WebApiException? except = error as WebApiException;
            if (except != null)
            {
                context.Response.Headers.Append("EXCEPTION", except.ToString());
                await context.Response.WriteAsync(except.ToString());
            }
            else
            {
                WebApiException exception = new WebApiException(contextFeature.Error, WebApiExceptionSource.GeneralException, "internal_server_error");
                context.Response.Headers.Append("EXCEPTION", exception.ToString());
                await context.Response.WriteAsync(exception.ToString());
            }
        }
    });
});

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run();
