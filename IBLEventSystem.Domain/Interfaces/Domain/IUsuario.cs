using System;
namespace IBLEventSystem.Domain.Interfaces.Domain
{
    public interface IUsuario
    {
        Guid USUARIO_ID { get; set; }

        string NOME { get; set; }
        
        string EMAIL { get; set; }

        DateTime DATA_CADASTRO { get; set; }

        string LOGIN { get; set; }

        string PASSWORD { get; set; }

        bool STATUS { get; set; }
    }
}
