namespace Ejercicio2DateTime
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// irodhan -> 29/01/2024
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo principal de la aplicacion
        /// irodhan -> 29/01/2024
        /// </summary>
        static void Main(string[] args)
        {
            //Creamos una variable y le añadimos la informacion
            DateTime fechaActual = DateTime.Now;
            int anyo=fechaActual.Year;
            int mes=fechaActual.Month;
            int dia=fechaActual.Day;
            int hora=fechaActual.Hour;
            int minuto=fechaActual.Minute;
            int segundo=fechaActual.Second;
            string diaSemana=fechaActual.DayOfWeek.ToString();
            string diaAnyo = fechaActual.DayOfYear.ToString();
            //Mostramos los resultados
            Console.WriteLine(fechaActual.ToString());
            Console.WriteLine("Año: " + anyo);
            Console.WriteLine("Mes: "+mes);
            Console.WriteLine("Día: " + dia);
            Console.WriteLine("Hora: " + hora);
            Console.WriteLine("Minutos: "+minuto);
            Console.WriteLine("Segundos: " + segundo);
            Console.WriteLine("Dia de la semana: "+diaSemana);
            Console.WriteLine("Dia del año:" + diaAnyo);

        }
    }
}
