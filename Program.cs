using solid.Clases;
using solid.Servicios;
using System;

namespace solid
{
    class Program
    {
        static void Main()
        {
            // Genera info del modelo
            Usuario user = new Usuario()
            {
                Nombre = "Ana",
                Email = "ana@mail.com",
                Telefono = "5555"
            };

            // Se realiza la instancia del notificador y asignarle un tipo
            INotificador notificador = new NotificadorEmail();
            // Se realiza una instacia para mantener un estandar de llenado de logger. 
            ILogger logger = new LoggerArchivo();

            //Instancia de servicio de notificación y ejecución
            ServicioNotificacion servicio = new ServicioNotificacion(notificador, logger);
            servicio.Ejecutar(user, "Hola Ana");

            Console.WriteLine("\nPresiona Enter para salir...");
            Console.ReadLine();
        }
    }
}
