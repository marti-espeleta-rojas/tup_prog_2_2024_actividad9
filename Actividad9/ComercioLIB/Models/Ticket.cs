using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLIB.Models
{
    public abstract class Ticket
    {
        protected int nroOrden;
        private DateTime fechaHora;

        public Ticket()
        {
            fechaHora = DateTime.Now;
        }

        public int VerNro()
        {
            return nroOrden;
        }

        public DateTime VerFechaHora()
        {
            return fechaHora;
        }
    }
}
