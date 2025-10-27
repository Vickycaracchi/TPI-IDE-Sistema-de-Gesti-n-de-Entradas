// BlazorApp/Authentication/CustomAuthStateProvider.cs
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using DTOs;

namespace BlazorApp.Authentication;

public class CustomAuthStateProvider : AuthenticationStateProvider
{
    private UsuarioDTO? _currentUser;

    public void SetUser(UsuarioDTO? user)
    {
        _currentUser = user;
        NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
    }

    public void Logout()
    {
        _currentUser = null;
        NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
    }

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        if (_currentUser == null)
        {
            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
        }

        var identity = new ClaimsIdentity(new[]
        {
            new Claim(ClaimTypes.Name, $"{_currentUser.Nombre} {_currentUser.Apellido}"),
            new Claim(ClaimTypes.Email, _currentUser.Email),
            new Claim(ClaimTypes.NameIdentifier, _currentUser.Id.ToString()),
            new Claim("Tipo", _currentUser.Tipo)
        }, "apiauth");

        return new AuthenticationState(new ClaimsPrincipal(identity));
    }
}