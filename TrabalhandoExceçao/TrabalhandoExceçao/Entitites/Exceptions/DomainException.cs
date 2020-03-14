using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhandoExceçao.Entitites.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
