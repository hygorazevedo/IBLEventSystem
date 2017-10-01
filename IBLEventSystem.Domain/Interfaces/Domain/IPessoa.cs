using System;
namespace IBLEventSystem.Domain.Interfaces.Domain
{
    public interface IPessoa
    {
        Guid PESSOA_ID { get; set; }

        string NOME { get; set; }

        string CPF { get; set; }

        int DDD { get; set; }

        string TELEFONE { get; set; }

        string EMAIL { get; set; }

        DateTime DATA_NASCIMENTO { get; set; }

        DateTime DATA_CADASTRO { get; set; }
    }
}
