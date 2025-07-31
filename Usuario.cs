namespace solid
{
    /// <summary>
    /// Clase de usario.
    /// </summary>
    class Usuario
    {
        public Usuario()
        {
            this.Nombre = string.Empty;
            this.Email = string.Empty;
            this.Telefono = string.Empty;
        }

        /// <summary>
        /// Nombre.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Telefono.
        /// </summary>
        public string Telefono { get; set; }
    }
}
