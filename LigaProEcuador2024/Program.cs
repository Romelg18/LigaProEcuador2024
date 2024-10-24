using LigaProEcuador2024.Data;

var builder = WebApplication.CreateBuilder(args);

// A�adir el contexto de la base de datos al contenedor de servicios
builder.Services.AddDbContext<LigaProContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LigaProConnection")));

// Otros servicios como controladores
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configurar la aplicaci�n
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
