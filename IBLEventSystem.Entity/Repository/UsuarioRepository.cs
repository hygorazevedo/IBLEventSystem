using AutoMapper;
using Dapper;
using IBLEventSystem.Adapter.DTO;
using IBLEventSystem.Domain.Entity;
using IBLEventSystem.Domain.Interfaces.Repository;
using IBLEventSystem.Entity.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IBLEventSystem.Entity.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private IBLContext contexto;
        private StringBuilder query;

        public void AtualizarStatus(UsuarioDTO usuarioDTO)
        {
            query = new StringBuilder();
            query.Append(@"UPDATE IBL.dbo.USUARIO
                           SET STATUS = @STATUS
                           WHERE USUARIO_ID = @USUARIO_ID");

            using (contexto = new IBLContext())
            {
                contexto.Database.Connection.Query<Usuario>(query.ToString(), new
                {
                    usuarioDTO.USUARIO_ID,
                    usuarioDTO.STATUS
                });
            }
            contexto.Dispose();
        }

        public void AtualizarUsuario(UsuarioDTO usuarioDTO)
        {
            Usuario usuario = Mapper.Map<Usuario>(usuarioDTO);
            query = new StringBuilder();
            query.Append(@"UPDATE IBL.dbo.USUARIO
                           SET NOME = @NOME
                              ,EMAIL = @EMAIL
                              ,LOGIN = @LOGIN
                              ,PASSWORD = @PASSWORD");

            using (contexto = new IBLContext())
            {
                contexto.Database.Connection.Query<Usuario>(query.ToString(), new
                {
                    usuarioDTO.USUARIO_ID,
                    usuarioDTO.NOME,
                    usuarioDTO.EMAIL,
                    usuarioDTO.LOGIN,
                    usuarioDTO.PASSWORD,
                    usuarioDTO.STATUS,
                    usuarioDTO.DATA_CADASTRO
                });
            }
            contexto.Dispose();
        }
        
        public UsuarioDTO BuscarUsuario(Guid id)
        {
            Usuario usuario;
            query = new StringBuilder();
            query.Append(@"SELECT USUARIO_ID
                                 ,NOME
                                 ,EMAIL
                                 ,LOGIN
                                 ,PASSWORD
                                 ,STATUS
                                 ,DATA_CADASTRO
                             FROM IBL.dbo.USUARIO
                             WHERE USUARIO_ID = @id");

            using (contexto = new IBLContext())
            {
                usuario = contexto.Database.Connection.Query<Usuario>(query.ToString(), new { id }).First();
            }
            contexto.Dispose();
            return Mapper.Map<UsuarioDTO>(usuario);
        }

        public void CriarUsuario(UsuarioDTO usuarioDTO)
        {
            Usuario usuario = Mapper.Map<Usuario>(usuarioDTO);
            query = new StringBuilder();
            query.Append(@"INSERT INTO IBL.dbo.USUARIO
                           VALUES(@USUARIO_ID
                                 ,@NOME
                                 ,@EMAIL
                                 ,@LOGIN
                                 ,@PASSWORD
                                 , @STATUS
                                 ,@DATA_CADASTRO)");

            using (contexto = new IBLContext())
            {
                contexto.Database.Connection.Query<Usuario>(query.ToString(), new
                {
                    usuarioDTO.USUARIO_ID,
                    usuarioDTO.NOME,
                    usuarioDTO.EMAIL,
                    usuarioDTO.LOGIN,
                    usuarioDTO.PASSWORD,
                    usuarioDTO.STATUS,
                    usuarioDTO.DATA_CADASTRO
                });
            }
            contexto.Dispose();

        }

        public IEnumerable<UsuarioDTO> ListarUsuarios()
        {
            IEnumerable<Usuario> usuarios;
            StringBuilder query = new StringBuilder();
            query.Append(@"SELECT USUARIO_ID
                                 ,NOME
                                 ,EMAIL
                                 ,LOGIN
                                 ,PASSWORD
                                 ,STATUS
                                 ,DATA_CADASTRO
                             FROM IBL.dbo.USUARIO");

            using (contexto = new IBLContext())
            {
                usuarios = contexto.Database.Connection.Query<Usuario>(query.ToString());
            }
            contexto.Dispose();
            return Mapper.Map<IEnumerable<UsuarioDTO>>(usuarios);
        }

        public void RemoverUsuario(Guid id)
        {
            query = new StringBuilder();
            query.Append(@"DELETE FROM IBL.dbo.USUARIO
                           WHERE USUARIO_ID = @id");

            using (contexto = new IBLContext())
            {
                contexto.Database.Connection.Query<Usuario>(query.ToString(), new { id });
            }
            contexto.Dispose();
        }
    }
}
