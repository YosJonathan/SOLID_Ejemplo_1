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
            // Creando o rescribiendo el archivo txt con el nuevo mensaje.
            File.WriteAllText("D:\\log.txt", mensaje);
        }
    }
}
