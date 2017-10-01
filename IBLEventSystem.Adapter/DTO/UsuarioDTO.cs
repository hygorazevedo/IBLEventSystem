using System;
using System.ComponentModel.DataAnnotations;

namespace IBLEventSystem.Adapter.DTO
{
    public class UsuarioDTO
    {
        public Guid USUARIO_ID { get; set; }

        [Required(ErrorMessage ="Informe o nome!")]
        public string NOME { get; set; }

        [Required(ErrorMessage = "Informe o email!")]
        public string EMAIL { get; set; }

        [Required(ErrorMessage = "Informe o login!")]
        public string LOGIN { get; set; }

        [Required(ErrorMessage = "Informe a senha!")]
        public string PASSWORD { get; set; }

        public bool? STATUS { get; set; }

        public DateTime DATA_CADASTRO { get; set; }
    }
}
