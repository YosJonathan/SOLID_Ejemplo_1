using System;
using System.IO;

namespace solid.Clases
{
    //Clase que guarda el logger en un archivo txt
    class LoggerArchivo : ILogger
    {
        /// <summary>
        /// Guardando log.
        /// </summary>
        /// <param name="mensaje">Mensaje para el log.</param>
        public void GuardarLog(string mensaje)
        {
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaArchivo = Path.Combine(escritorio, "log.txt");
            // Creando o rescribiendo el archivo txt con el nuevo mensaje.
            File.WriteAllText(rutaArchivo, mensaje);
        }
    }
}
