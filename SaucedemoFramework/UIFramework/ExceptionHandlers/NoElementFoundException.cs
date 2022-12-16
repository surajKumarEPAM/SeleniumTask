using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIFramework.ExceptionHandlers
{
    [Serializable]
    public class NoElementFoundException : Exception
    {

        public override string Message
        {
            get
            {
                return "Invalid Path :No element Found";
            }
        }

    }
}
