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

// ? Statik dosyalar için gerekli middleware'ler
app.UseDefaultFiles(); // index.html gibi default dosyalarý otomatik tanýr
app.UseStaticFiles();  // wwwroot altýndaki dosyalarý sunar

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
