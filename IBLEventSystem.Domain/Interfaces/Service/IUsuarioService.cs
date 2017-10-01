using IBLEventSystem.Adapter.DTO;
using System;
using System.Collections.Generic;

namespace IBLEventSystem.Domain.Interfaces.Service
{
    public interface IUsuarioService
    {
        void AtualizarStatus(UsuarioDTO usuarioDTO);

        void AtualizarUsuario(UsuarioDTO usuarioDTO);

        UsuarioDTO BuscarUsuario(Guid id);

        void CriarUsuario(UsuarioDTO usuarioDTO);
        
        IEnumerable<UsuarioDTO> ListarUsuarios();

        void RemoverUsuario(Guid id);
    }
}
