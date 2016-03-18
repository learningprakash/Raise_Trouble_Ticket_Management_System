using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RTT.Types
{
    public interface ICustomerBLL
    {
        int CreateProfile(ICustomer objICustomer);
        ICustomer Login(int intUserId, string strPassword);
        ICustomer SearchProfile(int intUserId);
        int UpdateProfile(ICustomer objICustomer);
        int CheckContactNo(String strContactNo,int intUserId);
    }
}
