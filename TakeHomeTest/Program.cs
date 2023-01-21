using API.CustomInputFormatter;
using BusinessLogic.Formatter;
using BusinessLogic.Parsers;
using BusinessLogic.Services;
using BusinessLogic.Validators;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(c => c.InputFormatters.Insert(c.InputFormatters.Count, new TextPlainInputFormatter()));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IParser, CSVParser>();
builder.Services.AddScoped<IFormatter, BoxBracketFormatter>();
builder.Services.AddScoped<IProcessInputService, ProcessTextInput>();
builder.Services.AddScoped<IValidator, CsvValidator>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseExceptionHandler("/error-development");
}
else
{
    app.UseExceptionHandler("/error");
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
