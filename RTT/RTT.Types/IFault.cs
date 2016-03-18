using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RTT.Types
{
   public interface IFault
    {
        string iProblemType { get; set; }
        string iSubCategory { get; set; }
        string iDepartment { get; set; }
        string iRemarks { get; set; }
        bool iStatus { get; set; }
        int iFaultId { get; set; }
        int iUserId { get; set; }
    }
}
