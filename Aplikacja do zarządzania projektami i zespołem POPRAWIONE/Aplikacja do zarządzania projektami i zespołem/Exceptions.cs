using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_do_zarządzania_projektami_i_zespołem
{
    public class InvalidTaskOperationException : Exception
    {
        public InvalidTaskOperationException(string message) : base(message) { }
    }
}
