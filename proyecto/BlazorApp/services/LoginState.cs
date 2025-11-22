using DTOs;

public class LoginState
{
    public UsuarioDTO Usuario { get; private set; }

    public event Action OnChange;

    public void SetUsuario(UsuarioDTO usuario)
    {
        Usuario = usuario;
        NotifyStateChanged();
    }

    public void Logout()
    {
        Usuario = null;
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();

    public string MensajeTemporal { get; set; }
}