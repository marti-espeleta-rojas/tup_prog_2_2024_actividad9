using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLIB.Models
{
    public class DNINoValidoException : ApplicationException
    {
        public DNINoValidoException():base("DNI no válido") { }
        public DNINoValidoException(string msg) : base(msg) { }
        public DNINoValidoException(string msg, Exception ec) : base(msg, ec) { }
    }
}
