var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseHttpsRedirection(); // Use HTTPS redirection only in production
}

app.UseAuthorization();

app.UseCors("AllowAll"); // Apply CORS policy

app.MapControllers();

var port = "7244"; // Set a fixed local port for development

// var port = Environment.GetEnvironmentVariable("PORT") ?? "8080"; // Get PORT from environment or fallback to 8080 for local testing

app.Run($"http://0.0.0.0:{port}");

app.MapGet("/", () =>
{
    var response = HNG_STAGE_ZERO_TASK.Controllers.RetrieveBasicInformationController.GetBasicInfo();
    return Results.Ok(response);
});