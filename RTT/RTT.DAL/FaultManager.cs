////////////////////////////////////////////////////////////////////////////////////
//
//	File Description	: Data Access Layer for Fault
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
using System.Data.SqlClient;
using RTT.BOFactory;
using System.Data;
namespace RTT.DAL
{
    /// <summary>
    /// This class contains all the methods and functions related to a Fault raised
    /// </summary>
   public class FaultManager : IFaultManager
    {
        /// <summary>
        /// This class contains checking by Login UserId's Phonenumber if match display data, otherwise display alert message.
        /// </summary>        
        
       public IFault GetFaultDetails(int faultId)
       {
           IFault ifault = FaultFactory.CreateObject();
           using (SqlConnection con = new SqlConnection(DBUtility.GetConnectionString()))
           {
               try
               {
                   using (SqlCommand cmdGetFaultDetails = DBUtility.GetCommand("dbo.sp_getFaultDetails_GR3", CommandType.StoredProcedure, con))
                   {
                       con.Open();
                       cmdGetFaultDetails.Parameters.AddWithValue("@FaultID", faultId);
                       cmdGetFaultDetails.Connection = con;
                       SqlDataReader dr = cmdGetFaultDetails.ExecuteReader();
                       if (dr.Read())
                       {
                           ifault.iRemarks = dr[2].ToString();
                           ifault.iProblemType = dr[4].ToString();
                           ifault.iSubCategory = dr[5].ToString();
                           ifault.iStatus = Convert.ToBoolean(dr[3]);
                           ifault.iDepartment = dr[6].ToString();
                       }
                   }
               }
               catch (Exception e)
               {
                   return null;
               }
               finally
               {
                   con.Close();
               }
               return ifault;
           }
       }
       /// <summary>
       /// This class contains cupdate fault datails, after successfully Updated will give message successfully message .
       /// </summary>
      
       public int UpdateFault(IFault ifault)
       {
           int result = 0;
           using (SqlConnection conUpdateFault = new SqlConnection(DBUtility.GetConnectionString()))
           {
               try
               {
                   string strCmdString = "";
                   if (ifault.iProblemType == "" || ifault.iProblemType == null)
                   {
                       strCmdString = "dbo.sp_AgentFaultUpdate_GR3";
                   }
                   else
                       strCmdString = "dbo.sp_faultUpdate_GR3";

                   using (SqlCommand cmdFaultUpdate = DBUtility.GetCommand(strCmdString, CommandType.StoredProcedure, conUpdateFault))
                   {
                       cmdFaultUpdate.Parameters.AddWithValue("@FaultID", ifault.iFaultId);
                       cmdFaultUpdate.Parameters.AddWithValue("@UserRemarks", ifault.iRemarks);

                       //if (ifault.ProblemType != "" || ifault.ProblemType != null)
                       if (strCmdString == "dbo.sp_faultUpdate_GR3")
                       {
                           cmdFaultUpdate.Parameters.AddWithValue("@Status", ifault.iStatus);
                           cmdFaultUpdate.Parameters.AddWithValue("@Problem_Type", ifault.iProblemType);
                           cmdFaultUpdate.Parameters.AddWithValue("@Sub_Category", ifault.iSubCategory);
                           cmdFaultUpdate.Parameters.AddWithValue("@Dapartment", ifault.iDepartment);
                       }
                       cmdFaultUpdate.Connection = conUpdateFault;
                       conUpdateFault.Open();
                       result = (int)cmdFaultUpdate.ExecuteNonQuery();
                   }
               }
               catch (Exception e)
               {
                   return -1;
               }
               finally
               {
                   conUpdateFault.Close();
               }


               return result;
           }
       }
       /// <summary>
       /// This class contains Deleting User's Created fault.
       /// </summary>

     
        public int DeleteFault(int faultId)
        {
            int result = 0;
            using (SqlConnection conDeleteFault = new SqlConnection(DBUtility.GetConnectionString()))
            {
                try
                {
                    using (SqlCommand cmdDeleteFault = DBUtility.GetCommand("dbo.sp_DeleteFault_GR3", CommandType.StoredProcedure, conDeleteFault))
                    {
                        cmdDeleteFault.Parameters.AddWithValue("@FaultID", faultId);
                        cmdDeleteFault.Connection = conDeleteFault;
                        conDeleteFault.Open();
                        result = (int)cmdDeleteFault.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    return -1;
                }
                finally
                {
                    conDeleteFault.Close();
                }

            }
            return result;
        }
        /// <summary>
        /// This class contains Veiwing of faults by the user
        /// </summary>
     
        public System.Data.DataSet ViewFaults(int userId, int status)
        {
            DataSet dstFaultsById = new DataSet();
            using (SqlConnection conViewFaults = new SqlConnection(DBUtility.GetConnectionString()))
            {
                try
                {
                    conViewFaults.Open();
                    string strCmdString="";
                    if (status == 2)
                    {
                        strCmdString = "sp_ViewAllFaultsByID_GR3";
                    }
                    else
                        strCmdString = "dbo.sp_ViewFaultsByID_GR3";

                    using (SqlCommand cmdViewFault = DBUtility.GetCommand(strCmdString, CommandType.StoredProcedure, conViewFaults))
                    {
                        
                        cmdViewFault.Parameters.AddWithValue("@UserID",userId);
                        
                        if (status != 2)
                        {
                            cmdViewFault.Parameters.AddWithValue("@Status", status);
                        }
                        SqlDataAdapter da = new SqlDataAdapter(cmdViewFault);
                        cmdViewFault.ExecuteNonQuery();
                        da.Fill(dstFaultsById);
                    }
                }
                catch (Exception E)
                {
                   Console.Write(E.ToString());
                }
                finally
                {
                    conViewFaults.Close();
                }
                return dstFaultsById;
            }
        }

        /// <summary>
        /// This class contains Closing Customer Fault by Customer.
        /// </summary>
       
        public int CloseFault(int faultId)
        {
            int result = 0;
            using (SqlConnection conCloseFault = new SqlConnection(DBUtility.GetConnectionString()))
            {
                try
                {
                    using (SqlCommand cmdCloseFault = DBUtility.GetCommand("dbo.sp_CLoseFault_GR3", CommandType.StoredProcedure, conCloseFault))
                    {
                        cmdCloseFault.Parameters.AddWithValue("@FaultID", faultId);
                        cmdCloseFault.Connection = conCloseFault;
                        conCloseFault.Open();
                        result = (int)cmdCloseFault.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    return -1;
                }
                finally
                {
                    conCloseFault.Close();
                }

            }
            return result;
        }
        /// <summary>
        /// This class contains creating Fault by Customer and get unique Fault Id .
        /// </summary>

    
        public int CreateFault(IFault ifault)
        {
            using (SqlConnection con = new SqlConnection(DBUtility.GetConnectionString()))
            {
                try
                {
                    using (SqlCommand cmdRaiseFault = DBUtility.GetCommand("sp_RaiseFault_GR3", CommandType.StoredProcedure, con))
                    {
                        cmdRaiseFault.Parameters.AddWithValue("@UserId", ifault.iUserId);
                        cmdRaiseFault.Parameters.AddWithValue("@FaultStatus", ifault.iStatus);
                        cmdRaiseFault.Parameters.AddWithValue("@Remarks", ifault.iRemarks);
                        cmdRaiseFault.Parameters.AddWithValue("@ProblemType", ifault.iProblemType);
                        cmdRaiseFault.Parameters.AddWithValue("@SubCategory", ifault.iSubCategory);
                        cmdRaiseFault.Parameters.AddWithValue("@Department", ifault.iDepartment);

                        SqlParameter prmFaultId = new SqlParameter();
                        prmFaultId.ParameterName = "@FaultId";
                        prmFaultId.SqlDbType = SqlDbType.Int;
                        prmFaultId.Direction =ParameterDirection.Output;
                        cmdRaiseFault.Parameters.Add(prmFaultId);
                        con.Open();
                        int i = cmdRaiseFault.ExecuteNonQuery();
                        con.Close();
                        if (i != 0)
                            return (int)prmFaultId.Value;
                        else
                            return 0;
                    }
                }
                catch (Exception ex)
                {
                    return -1;
                }
                finally
                {
                    con.Close();
                }
            }
        }

    }
}
