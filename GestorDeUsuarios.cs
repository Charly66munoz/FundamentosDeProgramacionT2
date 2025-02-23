public class GestorDeUsuario{
    
    private List<Usuario> usuarios = new List<Usuario>();
    
    
    public void Menu1(){
        
        int opcion;

        do{
            Console.Clear();
            Console.WriteLine("===== MENÚ PRINCIPAL =====");
            Console.WriteLine("1. Crear usuario");
            Console.WriteLine("2. Mostrar usuarios");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            bool esNumero = int.TryParse(Console.ReadLine(), out opcion);

            if(!esNumero){
                Console.WriteLine("Numero ingresado incorrecto");
                Console.ReadKey();
                continue; //vuelve inicio del 
            }


            switch (opcion){
                case 1:
                Usuario nuevoUsuario = Usuario.CrearUsuario(usuarios);
                usuarios.Add(nuevoUsuario);
                Console.WriteLine("Usuario Creado");
                break;
                case 2:
                Usuario usuarioC = new Usuario();
                usuarioC.IniciarSesion(usuarios);
                break;
                case 3: 
                Console.WriteLine ("Saliendo del programa");
                break;
                default: Console.WriteLine("Opción no válida. Intente de nuevo.");
                break;
            }
        }while(opcion != 3);


        // Evitar que la consola se cierre automáticamente
        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadLine();
        
    }



}