using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Excepciones
{
    class FacturaNoExistenteError : System.Exception
    {
          public FacturaNoExistenteError() : base() { }
    public FacturaNoExistenteError(string message) : base(message) { }
    public FacturaNoExistenteError(string message, System.Exception inner) : base(message, inner) { }

    // A constructor is needed for serialization when an
    // exception propagates from a remoting server to the client. 
    protected FacturaNoExistenteError(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) { }



    }
}
