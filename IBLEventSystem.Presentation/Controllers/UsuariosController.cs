using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Http;
using Ninject;
using System.Reflection;
using IBLEventSystem.Domain.Interfaces.Service;
using IBLEventSystem.Adapter.DTO;
using System.Web.Http.Description;
using System;
using System.Linq;
using System.Net;

namespace IBLEventSystem.Presentation.Controllers
{
    public class UsuariosController : ApiController
    {
        private readonly IUsuarioService _usuarioService;

        public UsuariosController()
        {
            IKernel _Kernal = new StandardKernel();
            _Kernal.Load(Assembly.GetExecutingAssembly());
            _usuarioService = _Kernal.Get<IUsuarioService>();
        }

        // PUT: api/Usuarios/5
        [HttpPut]
        [ResponseType(typeof(void))]
        public IHttpActionResult AtualizarUsuario(UsuarioDTO usuarioDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!PessoaExists(usuarioDTO.USUARIO_ID))
            {
                return NotFound();
            }

            _usuarioService.AtualizarUsuario(usuarioDTO);

            if (usuarioDTO.STATUS != null)
            {
                _usuarioService.AtualizarStatus(usuarioDTO);
            }

            return Ok();
        }
        
        // GET: api/Usuarios/5
        [HttpGet]
        [ResponseType(typeof(UsuarioDTO))]
        public IHttpActionResult BuscarUsuario(Guid id)
        {
            UsuarioDTO usuarioDTO = _usuarioService.BuscarUsuario(id);
            if (usuarioDTO == null)
            {
                return NotFound();
            }

            return Ok(usuarioDTO);
        }

        // POST: api/Usuarios
        [HttpPost]
        [ResponseType(typeof(UsuarioDTO))]
        public IHttpActionResult CriarUsuario(UsuarioDTO usuarioDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (PessoaExists(usuarioDTO.USUARIO_ID))
            {
                return Conflict();
            }
            _usuarioService.CriarUsuario(usuarioDTO);

            return Ok();
        }

        // GET: api/Usuarios
        [HttpGet]
        public IEnumerable<UsuarioDTO> ListarUsuarios()
        {
            return _usuarioService.ListarUsuarios();
        }
        
        // DELETE: api/Usuarios/5
        [HttpDelete]
        [ResponseType(typeof(UsuarioDTO))]
        public IHttpActionResult RemoverUsuario(Guid id)
        {
            if (!PessoaExists(id))
            {
                return NotFound();
            }

            _usuarioService.RemoverUsuario(id);

            return Ok();
        }

        private bool PessoaExists(Guid id)
        {
            return _usuarioService.ListarUsuarios().Count(e => e.USUARIO_ID == id) > 0;
        }
    }
}