using IBLEventSystem.Adapter.DTO;
using IBLEventSystem.Domain.Interfaces.Repository;
using IBLEventSystem.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;

namespace IBLEventSystem.Service.UsuarioService
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void AtualizarStatus(UsuarioDTO usuarioDTO)
        {
            _usuarioRepository.AtualizarStatus(usuarioDTO);
        }

        public void AtualizarUsuario(UsuarioDTO usuarioDTO)
        {
            _usuarioRepository.AtualizarUsuario(usuarioDTO);
        }

        public UsuarioDTO BuscarUsuario(Guid id)
        {
            return _usuarioRepository.BuscarUsuario(id);
        }

        public void CriarUsuario(UsuarioDTO usuarioDTO)
        {
            usuarioDTO.USUARIO_ID = Guid.NewGuid();
            usuarioDTO.STATUS = false;
            usuarioDTO.DATA_CADASTRO = DateTime.Now;
            _usuarioRepository.CriarUsuario(usuarioDTO);
        }

        public IEnumerable<UsuarioDTO> ListarUsuarios()
        {
            return _usuarioRepository.ListarUsuarios();
        }

        public void RemoverUsuario(Guid id)
        {
            _usuarioRepository.RemoverUsuario(id);
        }
    }
}
