using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLIB.Models
{
    public class CuentaCorriente :IComparable<CuentaCorriente>
    {
        private int nroCuenta;
        private Cliente titular;
        private double saldo;

        public CuentaCorriente(int nroCuenta, Cliente titular)
        {
            this.nroCuenta = nroCuenta;
            this.titular = titular;
        }

        public int VerNroCuenta()
        {
            return nroCuenta;
        }

        public void RegistrarPago(double monto)
        {
            saldo -= monto;
        }

        public void RegistrarVenta(double monto)
        {
            saldo += monto;
        }

        public double Versaldo()
        {
            return saldo;
        }

        public Cliente VerTitular()
        {
            return titular;
        }


        public int CompareTo(CuentaCorriente? other)
        {
            if (other != null)
            {
                return nroCuenta.CompareTo(other.VerNroCuenta());
            }
            return 1;
        }
    }
}
