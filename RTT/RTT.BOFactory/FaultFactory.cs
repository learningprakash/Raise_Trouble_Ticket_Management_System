using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RTT.Types;
using RTT.BO;

namespace RTT.BOFactory
{
    /// <summary>
    /// This class contains all the methods and functions related to a create an object of Fault class
    /// </summary>
   public class FaultFactory
    {
        public static IFault CreateObject()
        {
            return(new Fault());
        }
        public FaultFactory()
        {
        }
    }
}
