using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Excepciones
{
    class EmpresaNoRendidaError : System.Exception
    {

    public EmpresaNoRendidaError() : base() { }
    public EmpresaNoRendidaError(string message) : base(message) { }
    public EmpresaNoRendidaError(string message, System.Exception inner) : base(message, inner) { }

    // A constructor is needed for serialization when an
    // exception propagates from a remoting server to the client. 
    protected EmpresaNoRendidaError(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) { }



    }
}
