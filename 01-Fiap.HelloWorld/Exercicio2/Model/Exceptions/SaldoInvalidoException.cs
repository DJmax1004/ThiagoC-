using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Banco.Model
{

    [Serializable]
    public class SaldoInvalidoException : Exception
    {
        public SaldoInvalidoException() { }
        public SaldoInvalidoException(string message) : base(message) { }
        public SaldoInvalidoException(string message, Exception inner) : base(message, inner) { }
        protected SaldoInvalidoException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
