using Ninject.Modules;
using IBLEventSystem.Service.UsuarioService;
using IBLEventSystem.Domain.Interfaces.Service;
using IBLEventSystem.Domain.Entity;
using IBLEventSystem.Domain.Interfaces.Domain;
using IBLEventSystem.Entity.Repository;
using IBLEventSystem.Domain.Interfaces.Repository;

namespace IBLEventSystem.Presentation.Ninject
{
    public class Binding : NinjectModule
    { 
        public override void Load()
        {
            Bind<IUsuarioService>().To<UsuarioService>();
            
            Bind<IUsuario>().To<Usuario>();
            Bind<IEndereco>().To<Endereco>();
            
            Bind<IUsuarioRepository>().To<UsuarioRepository>();
            Bind<IEnderecoRepository>().To<EnderecoRepository>();
        }
    }
}