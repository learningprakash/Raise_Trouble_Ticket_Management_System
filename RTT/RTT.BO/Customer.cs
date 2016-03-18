using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RTT.Types;

namespace RTT.BO
{
   public class Customer : ICustomer
    {
        private int _UserId;
        public int iUserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                _UserId = value;
            }
        }
        private string _UserName;
        public string iUserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }
        private string _DateOfJoining;
        public string iDateOfJoining
        {
            get
            {
                return _DateOfJoining;
            }
            set
            {
                _DateOfJoining = value;
            }
        }
        private string _EmailId;
        public string iEmailId
        {
            get
            {
                return _EmailId;
            }
            set
            {
                _EmailId = value;
            }
        }
        private string _Address;
        public string iAddress
        {
            get
            {
                return _Address;
            }
            set
            {
                _Address = value;
            }
        }
        private string _Password;
        public string iPassword
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
            }
        }
        private string _ContactNo;
        public string iContactNo
        {
            get
            {
                return _ContactNo;
            }
            set
            {
                _ContactNo = value;
            }
        }
        private string _AltContactNo;
        public string iAltContactNo
        {
            get
            {
                return _AltContactNo;
            }
            set
            {
                _AltContactNo = value;
            }
        }
        private string _UserType;
        public string iUserType
        {
            get
            {
                return _UserType;
            }
            set
            {
                _UserType = value;
            }
        }
    }
}
