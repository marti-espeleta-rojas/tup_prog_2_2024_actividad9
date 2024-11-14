using ComercioLIB.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EjercicioParcialWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComercioController : ControllerBase
    {
        readonly static Comercio comercio = new Comercio();
        [HttpGet("AgregarTicket")]
        public IActionResult GetAgregarTicket(int tipo, string dni, int nroCC)
        {
            Ticket ticket = null;
            if (tipo == 0)
            {
                ticket = new Cliente(dni);
            }
            if(tipo == 1)
            {
                CuentaCorriente cc = comercio.VerCC(nroCC);
                if (cc != null)
                {
                    ticket = new Pago(cc);
                }
                return NotFound("No encontró la cuenta corriente");
            }
            if (ticket != null)
            {
                comercio.AgregarTicket(ticket);
                return Ok("Turno solicitado");
            }
            return Ok("No pudo ser agregado");
        }


        [HttpGet("AgregarCuentaCorriente")]
        public IActionResult GetAgregarCuentaCorriente(int nroCC, string dni)
        {
            CuentaCorriente cuenta = comercio.VerCC(nroCC);
            if (cuenta != null)
            {
                comercio.AgregarCuentaCorriente(nroCC, dni);
                return Ok();
            }
            return Ok();
        }

        [HttpGet("AtenderTicket")]
        public IActionResult GetAtenderTicket(int tipo)
        {
            Ticket t = null;
            t = comercio.AtenderTicket(tipo);
            if (t != null)
            {
                return Ok(t);
            }
            return NotFound("No se econtraron tickets");

        }
    }
}
