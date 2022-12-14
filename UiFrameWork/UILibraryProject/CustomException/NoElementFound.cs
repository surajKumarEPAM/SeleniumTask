using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UILibraryProject.CustomException
{
    [Serializable]
    public class NoElementFound : Exception
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
