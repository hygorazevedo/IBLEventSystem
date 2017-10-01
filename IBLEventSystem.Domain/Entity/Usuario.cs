using IBLEventSystem.Domain.Interfaces.Domain;
using System;
namespace IBLEventSystem.Domain.Entity
{
    public class Usuario : IUsuario
    {
        public Guid USUARIO_ID { get; set; }

        public string NOME { get; set; }
        
        public string EMAIL { get; set; }
        
        public string LOGIN { get; set; }

        public string PASSWORD { get; set; }

        public bool STATUS { get; set; }

        public DateTime DATA_CADASTRO { get; set; }
    }
}