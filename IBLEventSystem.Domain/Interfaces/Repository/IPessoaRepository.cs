using IBLEventSystem.Adapter.DTO;
using System;
using System.Collections.Generic;

namespace IBLEventSystem.Domain.Interfaces.Repository
{
    public interface IPessoaRepository
    {
        void CriarUsuario(UsuarioDTO usuario);
        UsuarioDTO BuscarUsuario(Guid id);
        IEnumerable<UsuarioDTO> ListarUsuario();
        void AtualizarUsuario(UsuarioDTO usuario);
        void RemoverUsuario(UsuarioDTO usuario);
        void Dispose();
    }
}
