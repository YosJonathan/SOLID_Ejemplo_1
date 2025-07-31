using System;

namespace solid.Clases
{
    /// <summary>
    /// Notificador de Whastapp.
    /// </summary>
    class NotificadorWhatsApp : INotificador
    {
        /// <summary>
        /// Notificación de mensaje.
        /// </summary>
        /// <param name="usuario">Usuario.</param>
        /// <param name="mensaje">Mensaje.</param>
        public void Notificar(Usuario usuario, string mensaje)
        {
            Console.WriteLine($"Enviando WhatsApp a {usuario.Telefono}: {mensaje}");
        }
    }
}
