using AutoMapper;
using GerenciamentoDeVendas.Data.Dto.UsuarioDto;
using GerenciamentoDeVendas.Models;

namespace GerenciamentoDeVendas.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, Usuario>();
            CreateMap<Usuario, ReadUsuarioDto>();
            CreateMap<UpdateUsuarioDto, Usuario>();
        }
    }
}
