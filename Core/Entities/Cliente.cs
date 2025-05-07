namespace Core.Entities;

public class Cliente
{
    public int Id { get; private set; }
    public string Nombre { get; private set; }
    public string Email { get; private set; }
    public DateTime FechaRegistro { get; private set; }

    public Cliente(string nombre, string email)
    {
        if (string.IsNullOrEmpty(nombre))
            throw new ArgumentException("Nombre requerido");
        
        if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            throw new ArgumentException("Email inválido");

        Nombre = nombre;
        Email = email;
        FechaRegistro = DateTime.UtcNow;
    }

    public void ActualizarEmail(string nuevoEmail) => Email = nuevoEmail;
}