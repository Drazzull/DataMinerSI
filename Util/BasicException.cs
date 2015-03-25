namespace DataMinerSI.Util
{
    using System;
    using System.Runtime.Serialization;

    class BasicException : Exception
    {
        /// <summary>
        /// Basic exception without error
        /// </summary>
        public BasicException()
            : base()
        {
        }

        /// <summary>
        /// Basic constructor for show messages
        /// </summary>
        /// <param name="message">Message with the error</param>
        public BasicException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Exception with some another exception inside
        /// </summary>
        /// <param name="message">Message with the exception</param>
        /// <param name="inner">Inner exception</param>
        public BasicException(string message, Exception inner)
            : base(message, inner)
        {
        }

        /// <summary>
        /// A constructor is needed for serialization when an exception propagates from a remoting
        /// server to the client. 
        /// </summary>
        /// <param name="info">Parameter SerializationInfo</param>
        /// <param name="context">Parameter StreamingContext</param>
        protected BasicException(SerializationInfo info, StreamingContext context)
        {
        }

    }
}
