using System;
namespace IBLEventSystem.Domain.Interfaces.Domain
{
    public interface IEndereco
    {
        Guid ENDERECO_ID { get; set; }

        string RUA { get; set; }

        int NUMERO { get; set; }

        string COMPLEMENTO { get; set; }

        string BAIRRO { get; set; }

        int CEP { get; set; }

        string CIDADE { get; set; }

        string ESTADO { get; set; }
    }
}