using FssApp.Plugins.EFCoreSqlServer;
using FssApp.UseCases;
using FssApp.UseCases.Interfaces;
using FssApp.UseCases.PluginInterfaces;
using FssApp.WebApp.Components;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextFactory<AppDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("FssAppConnection"));
});


// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSingleton<IFormationSanitaireEFCoreRepository, FormationSanitaireEFCoreRepository>();
builder.Services.AddTransient<IAfficherFormationsSanitairesUseCase, AfficherFormationsSanitairesUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
   .AddInteractiveServerRenderMode();

app.Run();
