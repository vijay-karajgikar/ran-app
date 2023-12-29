using DataAccess.Extensions;
using Business.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.RegisterDataAccess(builder.Configuration);
builder.Services.RegisterBusiness(builder.Configuration);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();

app.UseHttpsRedirection();
app.Run();
