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
if (app.Environment.IsDevelopment() || app.Environment.IsStaging())
{
    app.UseHttpsRedirection(); // Use HTTPS redirection in development/staging only
}

app.UseAuthorization();

app.UseCors("AllowAll"); // Apply CORS policy

app.MapControllers();


var port = "7244"; // Set a fixed local port for development
app.Run($"https://0.0.0.0:{port}");

app.MapGet("/", () => "App is running!");