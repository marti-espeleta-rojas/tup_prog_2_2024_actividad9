using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLIB.Models;

public class Comercio
{
    List<Ticket> ListaAtendidos = new List<Ticket>();
    Queue<Pago> nuevosP = new Queue<Pago>();
    Queue<Cliente> nuevosClientes = new Queue<Cliente>();
    List<CuentaCorriente> cuentas = new List<CuentaCorriente>();

    public void AgregarTicket(Ticket turno)
    {
        if (turno is Cliente)
        {
            nuevosClientes.Enqueue((Cliente)turno);
        }
        if (turno is Pago)
        {
            nuevosP.Enqueue((Pago)turno);
        }
    }

    public Ticket AtenderTicket(int tipo)
    {
        Ticket ticket = null;
        if (tipo == 0) //Clientes
        {
            if (nuevosClientes.Count >= 0)
            {
                ticket = nuevosClientes.Dequeue();
            }

        }
        else
        {
            if (tipo == 1) //Pago
            {
                if (nuevosP.Count >= 0)
                {
                    ticket = nuevosP.Dequeue();
                }
            }
        }
        if (ticket != null)
        {
            ListaAtendidos.Add(ticket);
            return ticket;
        }
        return null;
    }

    public CuentaCorriente VerCC(int nro)
    {
        CuentaCorriente cc = new CuentaCorriente(nro, null);
        cuentas.Sort();
        int idx = cuentas.BinarySearch(cc);
        if (idx >= 0)
        {
            return cuentas[idx];
        }
        return null;
    }

    public CuentaCorriente AgregarCuentaCorriente(int nroCC, string dni)
    {
        CuentaCorriente cc = VerCC(nroCC);
        if (cc != null)
        {
            Cliente cli = new Cliente(dni);
            cc = new CuentaCorriente(nroCC, cli);
            cuentas.Add(cc);
            return cc;
        }
        return null;
    }

}
