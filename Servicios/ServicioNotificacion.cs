namespace solid.Servicios
{
    //Servicio que ejecuta la notificación de cada uno
    class ServicioNotificacion
    {
        private readonly INotificador _notificador;
        private readonly ILogger _logger;

        /// <summary>
        /// Constructor de Servicio.
        /// </summary>
        /// <param name="notificador">Notificador.</param>
        /// <param name="logger">Logger.</param>
        public ServicioNotificacion(INotificador notificador, ILogger logger)
        {
            // Se realiza una inyección de dependecias.
            _notificador = notificador;
            _logger = logger;
        }

        /// <summary>
        /// Método para ejecutar la notificación y el guardado en logger.
        /// </summary>
        /// <param name="usuario">Usuario.</param>
        /// <param name="mensaje">Mensaje.</param>
        public void Ejecutar(Usuario usuario, string mensaje)
        {
            _notificador.Notificar(usuario, mensaje);
            _logger.GuardarLog("Notificación exitosa");
        }
    }
}
