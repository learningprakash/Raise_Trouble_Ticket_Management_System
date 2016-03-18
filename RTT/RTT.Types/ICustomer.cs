using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RTT.Types
{
    public interface ICustomer
    {
        int iUserId { get; set; }
        string iUserName { get; set; }
        string iDateOfJoining { get; set; }
        string iEmailId { get; set; }
        string iAddress { get; set; }
        string iPassword { get; set; }
        string iContactNo { get; set; }
        string iAltContactNo { get; set; }
        string iUserType { get; set; }
    }
}
