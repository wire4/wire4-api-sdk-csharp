using System;
using System.Runtime.Serialization;

namespace MX.Wire4.Authenticator.Client
{
    [Serializable]
    internal class ApiException : Exception
    {
        private int code;

        private string message;

        public ApiException()
        {
        }

        public ApiException(string message) : base(message)
        {
        }

        public ApiException(int expectationFailed, string message)
        {
            code = expectationFailed;
            this.message = message;
        }

        public ApiException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ApiException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}