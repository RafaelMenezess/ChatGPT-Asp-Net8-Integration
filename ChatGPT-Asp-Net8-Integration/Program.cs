using ChatGPT_Asp_Net8_Integration.Extensions;

var appName = "ChatGPT Asp.Net 8 Integration";

var builder = WebApplication.CreateBuilder(args);

builder.AddChatGpt(/*builder.Configuration*/);
builder.AddSerilog(builder.Configuration, appName);

// Add services to the container.

builder.Services.AddRouting(opt => opt.LowercaseUrls = true);
builder.Services.AddControllers();
builder.Services.AddSwagger(builder.Configuration, appName);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwaggerDoc(appName);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
