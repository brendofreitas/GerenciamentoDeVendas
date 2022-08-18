using AutoMapper;
using FluentResults;
using GerenciamentoDeVendas.Data;
using GerenciamentoDeVendas.Data.Dto.UsuarioDto;
using GerenciamentoDeVendas.Models;
using System.Collections.Generic;
using System.Linq;

namespace GerenciamentoDeVendas.Services
{
    public class UsuarioService
    {

        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public UsuarioService(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public List<ReadUsuarioDto> RecuperaUsuario()
        {
            var usuarios = _appDbContext.Usuarios.ToList();
            if (usuarios == null)
            {
                return null;
            }
            return _mapper.Map<List<ReadUsuarioDto>>(usuarios);
        }


        public ReadUsuarioDto RecuperaUsuarioPorId(int id)
        {
            Usuario usuario = _appDbContext.Usuarios.FirstOrDefault(usuarios => usuarios.Id == id);
            if (usuario != null)
            {
                ReadUsuarioDto usuarioDto = _mapper.Map<ReadUsuarioDto>(usuario);

                return usuarioDto;
            }
            return null;
        }

        public ReadUsuarioDto AdicionaUsuario(CreateUsuarioDto usuarioDto)
        {
            Usuario usuario = _mapper.Map<Usuario>(usuarioDto);
            _appDbContext.Usuarios.Add(usuario);
            _appDbContext.SaveChanges();
            return _mapper.Map<ReadUsuarioDto>(usuario);
        }
        public Result AtualizaUsuario(int id, UpdateUsuarioDto usuarioDto)
        {
            Usuario usuario = _appDbContext.Usuarios.FirstOrDefault(usuarios => usuarios.Id == id);
            if (usuario == null)
            {
                return Result.Fail("Usuario não encontrado");
            }
            _mapper.Map(usuarioDto, usuario);
            _appDbContext.SaveChanges();
            return Result.Ok();
        }

        public Result DeletaUsuario(int id)
        {
            Usuario usuario = _appDbContext.Usuarios.FirstOrDefault(usuarios => usuarios.Id == id);
            if (usuario == null)
            {
                return Result.Fail("Usuario não encontrado");
            }
            _appDbContext.Remove(usuario);
            _appDbContext.SaveChanges();
            return Result.Ok();
        }



    }
}
