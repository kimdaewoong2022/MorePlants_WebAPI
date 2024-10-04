using Microsoft.EntityFrameworkCore;
using MorePlants_PlantsAPI.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(option => {
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultSQLConnection"));
});

// Add services to the container.

//3-9. Http Patch Nuget ÆÐÅ°Áö ¼³Ä¡
//builder.Services.AddControllers().AddNewtonsoftJson();

//3-12. ÄÜÅÙÃ÷ Çù»ó (Content Negotiations)
builder.Services.AddControllers(option =>
{
    //ÄÜÅÙÃ÷ Çù»ó(Content Negotiations) :: XML ÇüÅÂ·Î º¯È¯ 
    //option.ReturnHttpNotAcceptable = true;
}).AddNewtonsoftJson().AddXmlDataContractSerializerFormatters();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
