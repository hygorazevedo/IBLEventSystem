using IBLEventSystem.Adapter.DTO;
using System;
using System.Collections.Generic;

namespace IBLEventSystem.Domain.Interfaces.Repository
{
    public interface IUsuarioRepository
    {
        void AtualizarStatus(UsuarioDTO usuarioDTO);
        void AtualizarUsuario(UsuarioDTO usuarioDTO);
        UsuarioDTO BuscarUsuario(Guid id);
        void CriarUsuario(UsuarioDTO usuario);
        IEnumerable<UsuarioDTO> ListarUsuarios();
        void RemoverUsuario(Guid id);
    }
}
