using System;
using System.Runtime.Serialization;

namespace Levismad
{
    [Serializable]
    public class AprimoramentosException : Exception
    {
        /*
        public AprimoramentosException()
        {
        }
        */

        public AprimoramentosException(string message)
            : base(message)
        {
        }

        /*
        public AprimoramentosException(string format, params object[] args)
            : base(string.Format(format, args))
        {
        }
        */

        /*
        public AprimoramentosException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
        */

        /*
        public AprimoramentosException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException)
        {
        }
        */

        protected AprimoramentosException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
