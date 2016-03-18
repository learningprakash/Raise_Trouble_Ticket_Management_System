using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RTT.Types;
using System.Data.SqlClient;
using System.Data;
using RTT.BOFactory;

namespace RTT.DAL
{
   public class CustomerManager : ICustomerManager
    {
        //During registration, this function stores the user data in database
        //and generates user id for customer
        public int CreateProfile(ICustomer c)
        {
            int intUserid = 0;
            using (SqlConnection conInsert = new SqlConnection(DBUtility.GetConnectionString()))
            {
                try
                {                    
                    SqlCommand objCmdInsert = new SqlCommand("sp_Register_GR3", conInsert);
                    objCmdInsert.CommandType = CommandType.StoredProcedure;
                    objCmdInsert.Parameters.AddWithValue("@Username", c.iUserName);
                    objCmdInsert.Parameters.AddWithValue("@DOJ", c.iDateOfJoining);
                    objCmdInsert.Parameters.AddWithValue("@EmailID", c.iEmailId);
                    objCmdInsert.Parameters.AddWithValue("@Address", c.iAddress);
                    objCmdInsert.Parameters.AddWithValue("@Password", c.iPassword);
                    objCmdInsert.Parameters.AddWithValue("@ContactNo", c.iContactNo);
                    objCmdInsert.Parameters.AddWithValue("@Alt_ContactNo", c.iAltContactNo);
                    SqlParameter objPara = new SqlParameter("@UserID", SqlDbType.Int);
                    objPara.Direction = ParameterDirection.Output;
                    objCmdInsert.Parameters.Add(objPara);
                    conInsert.Open();
                    int intResult = objCmdInsert.ExecuteNonQuery();
                    if (intResult > 0)
                    {
                        intUserid = (int)objCmdInsert.Parameters["@UserID"].Value;
                    }
                }
                catch (Exception p)
                {
                    return -1;
                }
                finally
                {
                    conInsert.Close();
                }
            }
            return intUserid;
        }


        //This function checks whether userId and Password entered during login is valid,
        //then only allow user to login
        public ICustomer Login(int userId, string password)
        {
            ICustomer objICustomer = CustomerFactory.CreateObject();
            using (SqlConnection objCon = new SqlConnection(DBUtility.GetConnectionString()))
            {

                try
                {
                    using (SqlCommand objCmdLogin = DBUtility.GetCommand("sp_UserLogin_GR3", CommandType.StoredProcedure, objCon))
                    {
                        objCmdLogin.Parameters.AddWithValue("@UserID",userId);
                        objCmdLogin.Parameters.AddWithValue("PasswordText",password);
                        SqlParameter objPrmUserType = new SqlParameter();
                        objPrmUserType.ParameterName = "@UserType";
                        objPrmUserType.SqlDbType = SqlDbType.VarChar;
                        objPrmUserType.Direction = ParameterDirection.Output;
                        objCmdLogin.Parameters.Add(objPrmUserType);
                        objPrmUserType.Size = 50;
                        SqlParameter objPrmUserName = new SqlParameter();                        
                        objPrmUserName.ParameterName = "@UserName";
                        objPrmUserName.SqlDbType = SqlDbType.VarChar;
                        objPrmUserName.Direction = ParameterDirection.Output;
                        objCmdLogin.Parameters.Add(objPrmUserName);
                        objPrmUserName.Size = 50;

                        objCon.Open();
                        objCmdLogin.ExecuteNonQuery();

                        objICustomer.iUserId = userId;
                        objICustomer.iUserType = Convert.ToString(objPrmUserType.Value);
                        objICustomer.iUserName= Convert.ToString(objPrmUserName.Value);
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
                finally
                {
                    objCon.Close();
                }
            }
          return objICustomer;
        }

        //This function is for dual purpose
        //Firstly,After login, it shows the profile when user gives its emailid
        //secondly,During fault management, it shows profile when user gives phone number
        public ICustomer SearchProfile(int userId)
        {
            ICustomer objICustomer = null;
            using (SqlConnection objConSearchUser = new SqlConnection(DBUtility.GetConnectionString()))
            {
                try
                {
                    using (SqlCommand objCmdSearchUser = DBUtility.GetCommand("sp_SearchUser_GR3", CommandType.StoredProcedure, objConSearchUser))
                    {
                        
                        objCmdSearchUser.Parameters.AddWithValue("@UserID", userId);
                        objConSearchUser.Open();
                        SqlDataReader drdUserProfile = objCmdSearchUser.ExecuteReader();
                        if (drdUserProfile.Read())
                            {
                                objICustomer = CustomerFactory.CreateObject();
                                objICustomer.iUserId = userId;
                                objICustomer.iAddress = drdUserProfile[4].ToString();
                                objICustomer.iAltContactNo = drdUserProfile[7].ToString();
                                objICustomer.iContactNo = drdUserProfile[6].ToString();
                                objICustomer.iDateOfJoining = drdUserProfile["DOJ"].ToString();
                                objICustomer.iEmailId = drdUserProfile[3].ToString();
                                objICustomer.iUserName = drdUserProfile[1].ToString();                           
                            }
                        drdUserProfile.Close();
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
                finally
                {
                    objConSearchUser.Close();
                    
                }
            }
            return objICustomer;
        }

        // When customer updates the profile,updated data stored 
        //in customer's previous location
        public int UpdateProfile(ICustomer iCustomer)
        {
            int intRowsAffected = 0;
            using (SqlConnection conUpdate = new SqlConnection(DBUtility.GetConnectionString()))
            {
                try
                {
                    using (SqlCommand objCmdUpdate = DBUtility.GetCommand("sp_UpdateProfile_GR3", CommandType.StoredProcedure, conUpdate))
                    {
                        objCmdUpdate.Parameters.AddWithValue("@UserName",iCustomer.iUserName);
                        objCmdUpdate.Parameters.AddWithValue("@Address", iCustomer.iAddress);
                        objCmdUpdate.Parameters.AddWithValue("@DateOfJoining", iCustomer.iDateOfJoining.ToString());
                        objCmdUpdate.Parameters.AddWithValue("@EmailId", iCustomer.iEmailId);
                        objCmdUpdate.Parameters.AddWithValue("@ContactNo", iCustomer.iContactNo);
                        objCmdUpdate.Parameters.AddWithValue("@AltContactNo", iCustomer.iAltContactNo);
                        objCmdUpdate.Parameters.AddWithValue("@UserID", iCustomer.iUserId);
                        conUpdate.Open();
                        intRowsAffected = objCmdUpdate.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                  
                }
                finally
                {
                    conUpdate.Close();
                }
            }
            return intRowsAffected;
        }


        //it checks contact no in user's database or not 
        //when user enters his/her phone no to view/create/close his/her faults
        public int CheckContactNo(string contactNo, int userId)
        {
            using (SqlConnection objCon = new SqlConnection())
            {
                int i;
                objCon.ConnectionString = DBUtility.GetConnectionString();
                try
                {
                    using (SqlCommand objCmd = DBUtility.GetCommand("sp_CheckContactNumber_GR3", CommandType.StoredProcedure, objCon))
                    {
                        objCmd.Parameters.AddWithValue("@UserId",userId);
                        objCmd.Parameters.AddWithValue("@Contact",contactNo);
                        SqlParameter objPrmRetVal = new SqlParameter();
                        objPrmRetVal.Direction = ParameterDirection.ReturnValue;
                        objPrmRetVal.SqlDbType = SqlDbType.Int;
                        objCmd.Parameters.Add(objPrmRetVal);
                        objCon.Open();
                        objCmd.ExecuteNonQuery();
                        i = Convert.ToInt32(objPrmRetVal.Value);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    objCon.Close();
                }
                return i;
            }
        }
    }
}
