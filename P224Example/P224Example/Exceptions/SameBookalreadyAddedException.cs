using System;
using System.Collections.Generic;
using System.Text;

namespace P224Example.Exceptions
{
    class SameBookalreadyAddedException: Exception 

    {
        public SameBookalreadyAddedException(string message):base(message)
        {
            
        }
    }
}
