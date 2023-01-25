using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using projeto_radar_backend.Database;
using projeto_radar_backend.Services.Auth;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(
        name: "AllowOrigin",
        builder => {
            builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
        });
});

builder.Services.AddDbContext<DbRadarContext>(service =>
{
  var conn = Environment.GetEnvironmentVariable("DATABASE_CF_URL");
  if (conn is null) conn = builder.Configuration.GetConnectionString("cnn");
  service.UseMySql(conn, ServerVersion.AutoDetect(conn));
});

// Add services to the container.
builder.Services.AddControllers();


builder.Services.AddAuthentication(x =>
{
  x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
  x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
  x.RequireHttpsMetadata = false;
  x.SaveToken = true;
  x.TokenValidationParameters = new TokenValidationParameters
  {
    ValidateIssuerSigningKey = true,
    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(TokenJWT.Key)),
    ValidateIssuer = false,
    ValidateAudience = false
  };
});

builder.Services.AddAuthorization(options =>
{
  options.AddPolicy("admin", policy => policy.RequireClaim("admin"));
  options.AddPolicy("editor", policy => policy.RequireClaim("editor"));
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerGen(c =>
{
  c.SwaggerDoc("v1", new OpenApiInfo
  {
    Title = "Radar API",
    Description = "Projeto final - Código do Futuro",
    Contact = new OpenApiContact { Name = "Grupo 1"},
    License = new OpenApiLicense { Name = "MIT", Url = new Uri("https://opensource.org/licenses/MIT") }
  });

  c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
  {
    Description = "Insira o token JWT como no exemplo: Bearer {SEU_TOKEN}",
    Name = "Authorization",
    Scheme = "Bearer",
    BearerFormat = "JWT",
    In = ParameterLocation.Header,
    Type = SecuritySchemeType.ApiKey
  });

  c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});

builder.Services.AddMvc(config =>
{
  var policy = new AuthorizationPolicyBuilder()
                   .RequireAuthenticatedUser()
                   .Build();
  config.Filters.Add(new AuthorizeFilter(policy));
});

var app = builder.Build();

//Configurando Railway
var scope = app.Services.CreateScope();
await DataHelper.ManageDataAsync(scope.ServiceProvider);

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseCors("AllowOrigin");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

