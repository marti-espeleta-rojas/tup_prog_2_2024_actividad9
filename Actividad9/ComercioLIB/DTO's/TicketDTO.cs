using ComercioLIB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLIB.DTO_s
{
   public class TicketDTO
    {
        public int tipo { get; set; }
        public int nroOrden { get; set; }
        public DateTime fechaHora { get; set; }

        public CuentaCorriente ficha { get; set; }

        public int dni { get; set; }

        public TicketDTO(Ticket ticket)
        {
            nroOrden = ticket.VerNro();
            fechaHora = ticket.VerFechaHora();
            if (ticket is Cliente cliente)
            {
                tipo = 1;
                cliente.VerDNI();
            }
            else if (ticket is Pago pago)
            {
                tipo = 2;         
                ficha = pago.VerCC();
            }
        }
    }
}
