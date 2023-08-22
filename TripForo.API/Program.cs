using Microsoft.EntityFrameworkCore;
using Tripforo.Repository.EFCoreModels.ScaffoldedEntity;
using Tripforo.Repository.Repositories.Supplier;
using Tripforo.Repository.RepositoryContracts.Supplier;
using Tripforo.Service.ServiceContracts.Supplier;
using Tripforo.Service.Services.Supplier;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_TripforoUI";
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddScoped<ISupplierService, SupplierService>();
builder.Services.AddScoped<ISupplierRepository, SupplierRepository>();
builder.Services.AddDbContext<FlyrajaContext>(option =>
option.UseSqlServer(builder.Configuration.GetConnectionString("dbconn")));
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:4200",
                                              "http://localhost:60806");
                          policy.AllowAnyHeader();
                          policy.AllowAnyMethod();
                      });
});
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

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();