var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add Swagger and OpenAPI documentation services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();

// Enable Swagger UI and specify the Swagger JSON endpoint
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    options.RoutePrefix = string.Empty;  // Optionally set the Swagger UI to be served at the root ("/")
});

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
