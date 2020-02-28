using System;
using System.Runtime.Serialization;

namespace Forma1.MyExeception
{
    [Serializable]
    internal class TeamServiceToGUIExcpetion : Exception
    {
        public TeamServiceToGUIExcpetion()
        {
        }

        public TeamServiceToGUIExcpetion(string message) : base(message)
        {
        }

        public TeamServiceToGUIExcpetion(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TeamServiceToGUIExcpetion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}