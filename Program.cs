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

// Conditionally apply HTTPS redirection based on the environment
if (app.Environment.IsDevelopment())
{
    app.UseHttpsRedirection(); // Use HTTPS redirection in development only
}

app.UseAuthorization();

app.UseCors("AllowAll"); // Apply CORS policy

app.MapControllers();

var port = Environment.GetEnvironmentVariable("PORT") ?? "8080"; // Get PORT from environment or fallback to 8080 for local testing

app.Run($"http://0.0.0.0:{port}");


app.MapGet("/", () => "App is running!");
