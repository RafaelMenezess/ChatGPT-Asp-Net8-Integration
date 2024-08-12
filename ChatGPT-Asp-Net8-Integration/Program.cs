using ChatGPT_Asp_Net8_Integration.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.AddChatGpt(/*builder.Configuration*/);
builder.AddSerilog(builder.Configuration, "ChatGPT Asp.Net 8 Integration");

// Add services to the container.

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
