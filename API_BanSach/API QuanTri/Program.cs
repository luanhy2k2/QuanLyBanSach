using BanMayTinh_V2.Code;
using API_QuanTri.Helpers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using BLL.Interface;

using BLL;
using DAL.Helper;
using DAL.Interface;
using DAL;
using API_QuanTri.Helpers;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<ITools, Tools>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});
// configure strongly typed settings objects
var appSettingsSection = builder.Configuration.GetSection("AppSettings");
builder.Services.Configure<AppSettings>(appSettingsSection);
// configure jwt authentication
var appSettings = appSettingsSection.Get<AppSettings>();
var key = Encoding.ASCII.GetBytes(appSettings.Secret);
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

builder.Services.AddHttpContextAccessor();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        Description = "Standard Authorization header using Bearer",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });
    options.OperationFilter<SecurityRequirementsOperationFilter>();
});

// Add services to the container.
builder.Services.AddTransient<IDatabaseHelper, DatabaseHelper>();
builder.Services.AddTransient<IDanhMucRepository, DanhMucRepository>();
builder.Services.AddTransient<IDanhMucBLL, DanhMucBLL>();

builder.Services.AddTransient<ITacGiaRepository, TacGiaReository>();
builder.Services.AddTransient<ITacGiaBLL, TacGiaBLL>();

builder.Services.AddTransient<IHoaDonBanRespository, HoaDonBanRepository>();
builder.Services.AddTransient<IHoaDonBanBLL, HoaDonBanBLL>();
builder.Services.AddControllers();

builder.Services.AddTransient<ILoaispRepository, LoaispRepository>();
builder.Services.AddTransient<ILoaispBLL, LoaispBLL>();

builder.Services.AddTransient<INhaSanXuatRepository, NhaSanXuatRepository>();
builder.Services.AddTransient<INhaSanXuatBLL, NhaSanXuatBLL>();

builder.Services.AddTransient<ISachRepository, SachRepository>();
builder.Services.AddTransient<ISachBLL, SachBLL>();

builder.Services.AddTransient<ITaiKhoanRepository, TaiKhoanRepository>();
builder.Services.AddTransient<ITaiKhoanBLL, TaiKhoanBLL>();

builder.Services.AddTransient<INguoiDungRepository, NguoiDungRepository>();
builder.Services.AddTransient<INguoiDung, NguoiDungBLL>();

builder.Services.AddTransient<IGiaSachRepository, GiaSachRepository>();
builder.Services.AddTransient<IGiaSachBLL, GiaCaBLL>();

builder.Services.AddTransient<IHoaDonNhapRepository, HoaDonNhapRepository>();
builder.Services.AddTransient<IHoaDonNhapBLL, HoaDonNhapBLL>();
builder.Services.AddTransient<IDonHangRepository, DonHangRepository>();
builder.Services.AddTransient<IDonHangBLL, DonHangBLL>();
builder.Services.AddTransient<IKhoRepository, KhoRepository>();
builder.Services.AddTransient<IKhoBLL, KhoBLL>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());
app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run();
