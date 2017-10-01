using AutoMapper;
using IBLEventSystem.Adapter.DTO;
using IBLEventSystem.Domain.Entity;

namespace IBLEventSystem.Entity.AutoMapper
{
    public static class MapperConfig
    {
        public static void RegisterMapping()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Usuario, UsuarioDTO>().ReverseMap();
                cfg.CreateMap<Endereco, EnderecoDTO>().ReverseMap();
            });
        }
    }
}
