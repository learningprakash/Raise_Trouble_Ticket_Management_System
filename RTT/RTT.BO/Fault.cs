////////////////////////////////////////////////////////////////////////////////////
//
//	File Description	: Business Object for Fault
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
using RTT.Types;
namespace RTT.BO
{
    /// <summary>
    /// This class contains all attributes related to a Fault raised
    /// </summary>
    public class Fault : IFault
    {
        //getter-setter properties
        /// <summary>
        /// Gets or Sets FaultID
        /// </summary>
      
        private string _ProblemType;
        public string iProblemType
        {
            get
            {
                return _ProblemType;
            }
            set
            {
                _ProblemType = value;
            }
        }
        private string _SubCategory;
        public string iSubCategory
        {
            get
            {
                return _SubCategory;
            }
            set
            {
                _SubCategory = value;
            }
        }
        private string _Department;
        public string iDepartment
        {
            get
            {
                return _Department;
            }
            set
            {
                _Department = value;
            }
        }
        private string _Remarks;
        public string iRemarks
        {
            get
            {
                return _Remarks;
            }
            set
            {
                _Remarks = value;
            }
        }
        private bool _Status;
        public bool iStatus
        {
            get
            {
                return _Status;
            }
            set
            {
                _Status = value;
            }
        }
        private int _FaultId;
        public int iFaultId
        {
            get
            {
                return _FaultId;
            }
            set
            {
                _FaultId = value;
            }
        }
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
    }
}
