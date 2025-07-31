namespace solid
{
    /// <summary>
    /// Interfaz de notificador.
    /// </summary>
    interface INotificador
    {
        /// <summary>
        /// Metodo de notificar.
        /// </summary>
        /// <param name="usuario">información de usuario.</param>
        /// <param name="mensaje">Mensaje.</param>
        void Notificar(Usuario usuario, string mensaje);
    }
}
