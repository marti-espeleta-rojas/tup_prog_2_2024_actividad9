using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLIB.Models
{
    public class Pago : Ticket
    {
        private static int nroInicio;
        private CuentaCorriente ficha = null;

        public Pago(CuentaCorriente cuenta)
        {
            ficha = cuenta;
            nroOrden = nroInicio++;
        }

        public void MontoPago(double valor)
        {
            ficha.RegistrarPago(valor);
        }
    }
}
