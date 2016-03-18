using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RTT.Types;
using RTT.DAL;

namespace RTT.DALFactory
{
    public class CustomerManagerFactory
    {
        public static ICustomerManager CreateObject()
        {
            return (new CustomerManager());
        }

        public CustomerManagerFactory()
        {
        }
    }
}
