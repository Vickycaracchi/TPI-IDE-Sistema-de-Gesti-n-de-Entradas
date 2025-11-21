using BlazorApp.Authentication;
//using BlazorApp.Services;   // ← Asegurate de agregar este using
using Microsoft.AspNetCore.Components.Authorization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddHttpClient("WebAPI", client =>
{
    client.BaseAddress = new Uri("https://localhost:7114/");
});

builder.Services.AddAuthorization();
builder.Services.AddCascadingAuthenticationState();

// Si usás CustomAuthStateProvider
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

// ⬅ ⬅ ⬅ REGISTRÁS EL SERVICIO AQUI
builder.Services.AddScoped<LoginState>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();