using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace parsaspace.netcore.Exceptions
{
    public class ParsaspaceException : Exception
    {
        /// <summary>
        /// Create an empty GhasedakApiException
        /// </summary>
        public ParsaspaceException() { }

        /// <summary>
        /// Create a GhasedakApiException from an error message
        /// </summary>
        /// <param name="message">Error message</param>
        public ParsaspaceException(string message) : base(message) { }

        /// <summary>
        /// Create a GhasedakApiException from message and another exception
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="exception">Original Exception</param>
        public ParsaspaceException(string message, Exception exception) : base(message, exception) { }
    }
}