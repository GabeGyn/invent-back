using Microsoft.EntityFrameworkCore;
using Invent.Models;

var builder = WebApplication.CreateBuilder(args);
var  CorsPolicy = "_CorsPolicy";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: CorsPolicy, policy  =>
    {
        policy.WithOrigins("http://localhost:4200")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});
// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EquipamentoEletronicoContext>(opt =>
    opt.UseInMemoryDatabase("EquipamentoEletronico")
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(CorsPolicy);

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();