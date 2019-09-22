using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Web.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpPost("VerificarUsuario")]
        public ActionResult VerificarUsuario([FromBody] Usuario usuario )
        {
            try
            {
                if (usuario.Email == "luiz@teste.com" && usuario.Senha=="abc123")
                    return Ok(usuario);
                return BadRequest("Usuário ou senha inválido");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}