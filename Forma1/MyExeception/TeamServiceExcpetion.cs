using System;
using System.Runtime.Serialization;

namespace Forma1.MyExeception
{
    [Serializable]
    internal class TeamServiceExcpetion : Exception
    {
        public TeamServiceExcpetion()
        {
        }

        public TeamServiceExcpetion(string message) : base(message)
        {
        }

        public TeamServiceExcpetion(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TeamServiceExcpetion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}