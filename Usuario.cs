using System;
using System.Collections.Generic;
using System.Linq;

public class Usuario
{
    private string? nombre;
    private string? email = " ";
    private string? contraseña = " ";

    // Propiedades para obtener valores
    public string? GetNombre { get => nombre; }
    public string? GetEmail { get => email; }
    public string? GetContraseña { get => contraseña; }

    public Usuario() { }

    public Usuario(string? nombre, string email, string contraseña)
    {
        this.nombre = nombre;
        this.email = email;
        this.contraseña = contraseña;
    }

    public static Usuario CrearUsuario(List<Usuario> usuarios)
    {
        string? nombre;
        string email;
        string contraseña;



        // Validación del nombre
        do
        {
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                Console.WriteLine(" El nombre no puede estar vacío.");
            }
        } while (string.IsNullOrWhiteSpace(nombre));

        // Validación del email
        
        bool emailExistente;
                
        do
        {
            Console.Write("Ingrese su email: ");
            email = Console.ReadLine();
            emailExistente = false;

            for (int i = 0; i < usuarios.Count ; i++){
                if (email == usuarios[i].GetEmail){
                emailExistente = true;   
                break;
            }   
                
                
            }
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                Console.WriteLine("El email no es válido. Debe contener '@'.");
            }
            else if (emailExistente)
            {
                Console.WriteLine("Este email ya está registrado. Intente con otro.");
            }

        } while (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || emailExistente);

        // Validación de la contraseña
        do
        {
            Console.Write("Ingrese su contraseña (mínimo 4 caracteres): ");
            contraseña = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(contraseña) || contraseña.Length < 4)
            {
                Console.WriteLine(" La contraseña debe tener al menos 4 caracteres.");
            }
        } while (string.IsNullOrWhiteSpace(contraseña) || contraseña.Length < 4);

        Usuario nuevoUsuario = new Usuario(nombre, email, contraseña);
        return nuevoUsuario;
    }

    public void MostrandoUsuarios(List<Usuario> usuarios){

    foreach (Usuario indice in usuarios){
        Console.WriteLine($"Nombre: {indice.GetNombre}, Email: {indice.GetEmail}");
    }
    }
}