using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RTT.Types
{
    public interface IFaultManager
    {
        IFault GetFaultDetails(int intFaultId);
        int UpdateFault(IFault objIFault);
        int DeleteFault(int intFaultId);
        System.Data.DataSet ViewFaults(int intUserId, int intStatus);
        int CloseFault(int intFaultId);
        int CreateFault(IFault objIFault);
    }
}
