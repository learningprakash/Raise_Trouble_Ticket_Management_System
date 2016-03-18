////////////////////////////////////////////////////////////////////////////////////
//
//	File Description	: Factory for Business Logic Layer of Fault
// ---------------------------------------------------------------------------------
//	Date Created		: Feb 22, 2012
//	Author			    : Tata Consultancy Services
// ---------------------------------------------------------------------------------
// 	Change History
//	Date Modified		: 
//	Changed By		:
//	Change Description   : 
//
////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RTT.BO;
using RTT.Types;

namespace RTT.BOFactory
{
    /// <summary>
    /// This class contains all the methods and functions related to a create an object of Customer class
    /// </summary>
    
    public class CustomerFactory
    {
        public static ICustomer CreateObject()
        {
            return (new Customer());
        }
     
    }
}
