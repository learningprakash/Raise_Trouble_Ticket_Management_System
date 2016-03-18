using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RTT.Types;
using RTT.DAL;

namespace RTT.DALFactory
{
   public class FaultManagerFactory
    {
        public static IFaultManager CreateObject()
        {
            return new FaultManager();
        }
    }
}
