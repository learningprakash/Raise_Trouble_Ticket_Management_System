using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RTT.Types;
using RTT.BLL;

namespace RTT.BLLFactory
{
   public class FaultBLLFactory
    {
       public static IFaultBLL CreateObject()
        {
            IFaultBLL ifaultbll = new FaultBLL();
            return (new FaultBLL());
        }
        
    }
}
