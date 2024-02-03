using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.BLL.Exceptions
{
    internal class NotFoundUserException: Exception
    {
        public NotFoundUserException() { }
        public NotFoundUserException(string message) : base(message) { }
    }
}
