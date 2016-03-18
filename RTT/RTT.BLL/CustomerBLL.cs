////////////////////////////////////////////////////////////////////////////////////
//
//	File Description	: Business Logic Layer for User
// ---------------------------------------------------------------------------------
//	Date Created		: Feb 24 , 2012
//	Author			:  Tata Consultancy Services
// ---------------------------------------------------------------------------------
// 	Change History
//	Date Modified		 : 
//	Changed By		     :
//	Change Description   : 
//
////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RTT.Types;
using RTT.DALFactory;

namespace RTT.BLL
{
    public class CustomerBLL : ICustomerBLL
    {
        /// <summary>
        /// This method creates new User
        /// </summary>
        /// <param name="objUser">object of Customer </param>
        /// <returns>returns UserID</returns>
        public int CreateProfile(ICustomer objICustomer)
        {
            return CustomerManagerFactory.CreateObject().CreateProfile(objICustomer);
        }
        /// <summary>
        /// This method allows User to Login
        /// </summary>
        /// <param name="strUserID">UserID and Password</param>
        /// <param name="strPassword"> Password</param>
        /// <returns>returns Object of that User</returns>

        public ICustomer Login(int intUserId, string strPassword)
        {
            return CustomerManagerFactory.CreateObject().Login(intUserId, strPassword);
        }

        /// <summary>
        /// This method helps User to search a particular Customer
        /// </summary>
        /// <param name="strUserID">UserID </param>
        /// <returns>returns object of that Customer</returns>

        public ICustomer SearchProfile(int intUserId)
        {
            return CustomerManagerFactory.CreateObject().SearchProfile(intUserId);
        }
        /// <summary>
        /// This method edits the details of the User
        /// </summary>
        /// <param name="objUser">Object of the User</param>
        /// <returns>returns No of rows affected</returns>

        public int UpdateProfile(ICustomer objICustomer)
        {
            return CustomerManagerFactory.CreateObject().UpdateProfile(objICustomer);
        }
        /// <summary>
        /// This method Check the ContactNo of User
        /// </summary>
        /// <param name="objUser">Object of the User</param>
        /// <returns>returns No of rows affected</returns>

        public int CheckContactNo(string strContactNo, int intUserId)
        {
            return CustomerManagerFactory.CreateObject().CheckContactNo(strContactNo,intUserId);
        }
    }
}
