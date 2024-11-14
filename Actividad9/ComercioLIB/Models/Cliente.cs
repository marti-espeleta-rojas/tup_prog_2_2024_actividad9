using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLIB.Models
{
    public class Cliente : Ticket
    {
        private int dni;
        private static int numeroInicio;
        public Cliente(string dni) 
        {
            int Dni = Convert.ToInt32(dni);
            if (Dni < 3000000 && Dni > 45000000)
            {
                throw new DNINoValidoException();
            }
            this.dni = Dni;
            numeroInicio++;
            nroOrden = numeroInicio;
        }

        public int VerDNI()
        {
            return dni;
        }
    }
}
