////////////////////////////////////////////////////////////////////////////////////
//
//	File Description	: Business Logic Layer for Fault
// ---------------------------------------------------------------------------------
//	Date Created		: Feb 24, 2012
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
using RTT.DALFactory;
using System.Data;

namespace RTT.BLL
{
    /// <summary>
    /// This class contains all the methods and functions related to a Fault raised
    /// </summary>
   public class FaultBLL : IFaultBLL
    {

        /// <summary>
        /// This will enable the user to Get Fault Details.
        /// </summary>
        public IFault GetFaultDetails(int intFaultId)
        {
            return FaultManagerFactory.CreateObject().GetFaultDetails(intFaultId);
        }

        /// <summary>
        /// This will enable the user to update the faults
        /// </summary>
        public int UpdateFault(IFault objIFault)
        {
            return FaultManagerFactory.CreateObject().UpdateFault(objIFault);
        }
        /// <summary>
        /// This will enable the user to delete the faults
        /// </summary>

        public int DeleteFault(int intFaultId)
        {
            return FaultManagerFactory.CreateObject().DeleteFault(intFaultId);
        }
        /// <summary>
        /// This will enable the user to view the faults
        /// </summary>

        public System.Data.DataSet ViewFaults(int intUserId, int intStatus)
        {
            DataSet dstFault = new DataSet();
            dstFault = null;
            try
            {
                //return FaultManagerFactory.IFCreateManager().viewFaults(userId, status);
                IFaultManager objIFaultManager = FaultManagerFactory.CreateObject();
                dstFault = objIFaultManager.ViewFaults(intUserId, intStatus);
                if (dstFault != null)
                {
                    dstFault.Tables[0].Columns.Add("FaultStatus", typeof(string));
                    foreach (DataRow drwFault in dstFault.Tables[0].Rows)
                    {
                        if ((bool)drwFault["Status"] == true)
                        {
                            drwFault["FaultStatus"] = "Open";
                        }
                        else
                            drwFault["FaultStatus"] = "Closed";
                    }
                    dstFault.Tables[0].Columns.Remove(dstFault.Tables[0].Columns["Status"]);
                }
            }
            catch(Exception E)
            {
            }
            
            return dstFault;
        }

        /// <summary>
        /// This will enable the user to close the faults and set their fault status as true or false.
        /// </summary>

        public int CloseFault(int intFaultId)
        {
            return FaultManagerFactory.CreateObject().CloseFault(intFaultId);
        }

        /// <summary>
        /// This will enable the user to create new faults
        /// </summary>

        public int CreateFault(IFault objIFault)
        {
            return FaultManagerFactory.CreateObject().CreateFault(objIFault);
        }
    }
}
