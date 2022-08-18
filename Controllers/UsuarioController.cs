using AutoMapper;
using FluentResults;
using GerenciamentoDeVendas.Data;
using GerenciamentoDeVendas.Data.Dto.UsuarioDto;
using GerenciamentoDeVendas.Models;
using GerenciamentoDeVendas.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace GerenciamentoDeVendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

    
        // GET: api/<UsuarioController>
        [HttpGet]
        public IActionResult RecuperarUsuario ()
        {
            List<ReadUsuarioDto> readDto = _usuarioService.RecuperaUsuario();
            if (readDto == null) return NotFound();
            return Ok(readDto);
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public  IActionResult RecuperandoUsuarioPorId(int id)
        {
            ReadUsuarioDto readDto = _usuarioService.RecuperaUsuarioPorId(id);
            if (readDto == null) return NotFound();
            return Ok(readDto);
        }


        [HttpPost]
        public IActionResult AdicionarUsuario([FromBody] CreateUsuarioDto usuarioDto)
        {
            ReadUsuarioDto readDto = _usuarioService.AdicionaUsuario(usuarioDto);
            return CreatedAtAction(nameof(RecuperandoUsuarioPorId), new {readDto.Id }, readDto);
        }



        [HttpPut("{id}")]
        public IActionResult AtualizaUsuario (int id, [FromBody] UpdateUsuarioDto usuarioDto)
        {
            Result resultado = _usuarioService.AtualizaUsuario(id, usuarioDto);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaUsuario(int id)
        {
            Result resultado = _usuarioService.DeletaUsuario(id);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }
    }
}
