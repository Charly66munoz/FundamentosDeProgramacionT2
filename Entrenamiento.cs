public class Entrenamiento
{
    private double distancia;
    private TimeSpan tiempo;
    private string fecha;
    private static List<Entrenamiento> entrenamientos = new List<Entrenamiento>();

    // Constructor
    public Entrenamiento(double distancia, TimeSpan tiempo, string fecha)
    {
        this.distancia = distancia;
        this.tiempo = tiempo;
        this.fecha = fecha;
    }

    
    public double GetDistancia() { return distancia; }
    public void SetDistancia(double distancia) { this.distancia = distancia; }

    public TimeSpan GetTiempo() { return tiempo; }
    public void SetTiempo(TimeSpan tiempo) { this.tiempo = tiempo; }

    public string GetFecha() { return fecha; }
    public void SetFecha(string fecha) { this.fecha = fecha; }

    
    public static void RegistrarEntrenamiento()
    {
        Console.Write("Ingrese la distancia recorrida (km): ");
        double distancia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tiempo empleado (minutos): ");
        int minutos = Convert.ToInt32(Console.ReadLine());
        TimeSpan tiempo = TimeSpan.FromMinutes(minutos);

        string fecha = DateTime.Now.ToString("dd/MM/yyyy");

        
        entrenamientos.Add(new Entrenamiento(distancia, tiempo, fecha));
        Console.WriteLine("Entrenamiento registrado correctamente.\n");
    }

    
    public static void ListarEntrenamientos()
    {
        if (entrenamientos.Count == 0)
        {
            Console.WriteLine("No hay entrenamientos registrados.\n");
            return;
        }

        Console.WriteLine("Tus entrenamientos:");
        foreach (var entrenamiento in entrenamientos)
        {
            Console.WriteLine(entrenamiento);
        }
        Console.WriteLine();
    }

   
    public static void VaciarEntrenamientos()
    {
        entrenamientos.Clear();
        Console.WriteLine("Todos los entrenamientos han sido eliminados.\n");
    }

   
    public override string ToString() //recomendacion de chat gpt 
    {
        return $" Fecha: {fecha} | Distancia: {distancia} km | Tiempo: {tiempo}";
    }
}
