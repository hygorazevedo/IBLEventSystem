using System;
namespace IBLEventSystem.Adapter.DTO
{
    public class EnderecoDTO
    {
        public Guid ENDERECO_ID { get; set; }

        public string RUA { get; set; }

        public int NUMERO { get; set; }

        public string COMPLEMENTO { get; set; }

        public string BAIRRO { get; set; }

        public string CEP { get; set; }

        public string CIDADE { get; set; }

        public string ESTADO { get; set; }
    }
}
