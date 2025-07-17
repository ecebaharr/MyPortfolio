var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// ? Statik dosyalar i�in gerekli middleware'ler
app.UseDefaultFiles(); // index.html gibi default dosyalar� otomatik tan�r
app.UseStaticFiles();  // wwwroot alt�ndaki dosyalar� sunar

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
