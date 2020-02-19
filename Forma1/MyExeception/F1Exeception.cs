using System;
using System.Runtime.Serialization;

namespace Forma1.MyExeception;
{
    [Serializable]
    internal class F1Exeception : Exception
    {
        public F1Exeception()
        {
        }

        public F1Exeception(string message) : base(message)
        {
        }

        public F1Exeception(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected F1Exeception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}