using System;


namespace Impendulo.Common.EmailSending
{
    public class InvalidEmailAddressException : Exception
    {
        public InvalidEmailAddressException()
        {

        }
        public InvalidEmailAddressException(string message)
        : base(message)
        {
        }

        public InvalidEmailAddressException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}