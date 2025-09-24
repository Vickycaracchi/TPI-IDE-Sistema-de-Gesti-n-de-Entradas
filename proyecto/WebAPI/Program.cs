using WebAPI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v2", new()
    {
        Title = "Bohemia Gestión de Entradas API",
        Version = "v2"
    });
});
builder.Services.AddHttpLogging(o => { });

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorWasm",
        policy =>
        {
            policy.WithOrigins("https://localhost:7170", "http://localhost:5076")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v2/swagger.json", "Bohemia Gestión de Entradas API v2");
    });
    app.UseHttpLogging();
}

app.UseHttpsRedirection();

app.UseCors("AllowBlazorWasm");

app.MapClienteEndpoints();
app.MapEventoEndpoints();
app.MapVendedorEndpoints();

app.Run();
