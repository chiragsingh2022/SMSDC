using Microsoft.EntityFrameworkCore;

using SmsdcWebApi.Model;

var builder = WebApplication.CreateBuilder(args);

// 👇 Add this line to load secrets from User Secrets
builder.Configuration.AddUserSecrets<Program>();

// Register the DbContext with the connection string from secrets
builder.Services.AddDbContext<SmsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add controllers (API endpoints)
builder.Services.AddControllers();

// Configure Swagger (optional, for API docs)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
