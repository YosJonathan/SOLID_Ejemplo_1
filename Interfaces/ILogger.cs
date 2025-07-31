namespace solid
{
    /// <summary>
    /// Interfaz que maneja el logger.
    /// </summary>
    interface ILogger
    {
        /// <summary>
        /// Metodo guardar log.
        /// </summary>
        /// <param name="mensaje">Mensaje para guardar.</param>
        void GuardarLog(string mensaje);
    }
}
