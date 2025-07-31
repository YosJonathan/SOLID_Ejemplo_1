using System;

namespace solid.Clases
{
    /// <summary>
    /// Notificar mediante SMS.
    /// </summary>
    class NotificadorSMS : INotificador
    {
        /// <summary>
        /// Notificar a usuario.
        /// </summary>
        /// <param name="usuario">Usuario.</param>
        /// <param name="mensaje">Mensaje.</param>
        public void Notificar(Usuario usuario, string mensaje)
        {
            Console.WriteLine($"Enviando SMS a {usuario.Telefono}: {mensaje}");
        }
    }
}
