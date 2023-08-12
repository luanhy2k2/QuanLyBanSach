using BanMayTinh_V2.Code;
using API_QuanTri.Helpers;

using Microsoft.Extensions.Configuration;

using System.Text;
using BLL.Interface;
using BLL;
using DAL.Helper;
using DAL.Interface;
using DAL;
using API_QuanTri.Helpers;

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




// Add services to the container.
builder.Services.AddTransient<IDatabaseHelper, DatabaseHelper>();
builder.Services.AddTransient<IDanhMucRepository, DanhMucRepository>();
builder.Services.AddTransient<IDanhMucBLL, DanhMucBLL>();
builder.Services.AddTransient<IHomeRepository, HomeRepository>();
builder.Services.AddTransient<IHomeBLL, HomeBLL>();
builder.Services.AddTransient<ITacGiaRepository, TacGiaReository>();
builder.Services.AddTransient<ITacGiaBLL, TacGiaBLL>();
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

builder.Services.AddTransient<IKhoRepository, KhoRepository>();
builder.Services.AddTransient<IKhoBLL, KhoBLL>();

builder.Services.AddTransient<IDonHangRepository, DonHangRepository>();
builder.Services.AddTransient<IDonHangBLL, DonHangBLL>();
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
