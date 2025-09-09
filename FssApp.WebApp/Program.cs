using FssApp.Plugins.EFCoreSqlServer;
using FssApp.UseCases;
using FssApp.UseCases.FormationsSanitaires;
using FssApp.UseCases.Interfaces;
using FssApp.UseCases.PluginInterfaces;
using FssApp.UseCases.Prestations;
using FssApp.WebApp.Components;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextFactory<AppDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("FssAppConnection"));
});


// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


builder.Services.AddMudServices();

builder.Services.AddTransient<IGetFosasUseCase, GetFosasUseCase>();
builder.Services.AddTransient<IGetFosasDtoUseCase, GetFosasDtoUseCase>();
builder.Services.AddTransient<IAddFosaUseCase, AddFosaUseCase>();
builder.Services.AddTransient<IEditFosaUseCase, EditFosaUseCase>();
builder.Services.AddTransient<IGetFosaByIdUseCase, GetFosaByIdUseCase>();
builder.Services.AddTransient<IDeleteFosaByIdUseCase, DeleteFosaByIdUseCase>();

builder.Services.AddTransient<IGetFosaTypesUseCase, GetFosaTypesUseCase>();
builder.Services.AddTransient<IGetZoneDeSanteUseCase, GetZoneDeSanteUseCase>();
builder.Services.AddTransient<IGetMonnaiesUseCase, GetMonnaiesUseCase>();
builder.Services.AddTransient<IGetMoisUseCase, GetMoisUseCase>();
builder.Services.AddTransient<IGetProvincesUseCase, GetProvincesUseCase>();
builder.Services.AddTransient<IGetDistrictsUseCase, GetDistrictsUseCase>();
builder.Services.AddTransient<IGetAnneesUseCase, GetAnneesUseCase>();
builder.Services.AddTransient<IGetServiceUseCase, GetServiceUseCase>();



builder.Services.AddTransient<IGetPrestationsUseCase, GetPrestationsUseCase>();
builder.Services.AddTransient<IAddPrestationUseCase, AddPrestationUseCase>();
builder.Services.AddTransient<IEditPrestationUseCase, EditPrestationUseCase>();
builder.Services.AddTransient<IGetPrestationByIdUseCase, GetPrestationByIdUseCase>();
builder.Services.AddTransient<IDeletePrestationByIdUseCase, DeletePrestationByIdUseCase>();
builder.Services.AddTransient<IGetPrestatairesUseCase, GetPrestatairesUseCase>();
builder.Services.AddTransient<IGetPrestationCategoriesUseCase, GetPrestationCategoriesUseCase>();

builder.Services.AddSingleton<IFosaEFCoreRepository, FosaEFCoreRepository>();
builder.Services.AddSingleton<IPrestationCategorieEFCoreRepository, PrestationCategorieEFCoreRepository>();
builder.Services.AddSingleton<IPrestationEFCoreRepository, PrestationEFCoreRepository>();
builder.Services.AddSingleton<IProvinceEFCoreRepository, ProvinceEFCoreRepository>();
builder.Services.AddSingleton<IDistrictEFCoreRepository, DistrictEFCoreRepository>();
builder.Services.AddSingleton<IZoneDeSanteEFCoreRepository, ZoneDeSanteEFCoreRepository>();
builder.Services.AddSingleton<ITypeDeFosaEFCoreRepository, TypeDeFosaEFCoreRepository>();
builder.Services.AddSingleton<IPrestationEFCoreRepository, PrestationEFCoreRepository>();
builder.Services.AddSingleton<IPrestataireEFCoreRepository, PrestataireEFCoreRepository>();
builder.Services.AddSingleton<IMonnaieEFCoreRepository, MonnaieEFCoreRepository>();
builder.Services.AddSingleton<IMoisEFCoreRepository, MoisEFCoreRepository>();
builder.Services.AddSingleton<IAnneeEFCoreRepository, AnneeEFCoreRepository>();
builder.Services.AddSingleton<IServiceEFCoreRepository, ServiceEFCoreRepository>();




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
