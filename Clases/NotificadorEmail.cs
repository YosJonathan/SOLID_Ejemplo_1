using System;

namespace solid.Clases
{
    /// <summary>
    /// Logica de notificación para Email.
    /// </summary>
    class NotificadorEmail : INotificador
    {
        /// <summary>
        /// Notificar mensaje.
        /// </summary>
        /// <param name="usuario">Usuario.</param>
        /// <param name="mensaje">Mensaje.</param>
        public void Notificar(Usuario usuario, string mensaje)
        {
            Console.WriteLine($"Enviando email a {usuario.Email}: {mensaje}");
        }
    }
}
