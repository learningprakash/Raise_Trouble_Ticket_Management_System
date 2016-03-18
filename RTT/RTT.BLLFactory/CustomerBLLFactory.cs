using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RTT.Types;
using RTT.BLL;

namespace RTT.BLLFactory
{
    public class CustomerBLLFactory
    {
        public static ICustomerBLL CreateObject()
        {
            return (new CustomerBLL());

        }
        public CustomerBLLFactory()
        {
        }
    }
}
