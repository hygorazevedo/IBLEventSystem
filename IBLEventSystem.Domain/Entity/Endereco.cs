using IBLEventSystem.Domain.Interfaces.Domain;
using System;
namespace IBLEventSystem.Domain.Entity
{
    public class Endereco : IEndereco
    {
        public Guid ENDERECO_ID { get; set; }
        
        public string RUA { get; set; }

        public int NUMERO { get; set; }

        public string COMPLEMENTO { get; set; }

        public string BAIRRO { get; set; }

        public int CEP { get; set; }

        public string CIDADE { get; set; }

        public string ESTADO { get; set; }
    }
}
