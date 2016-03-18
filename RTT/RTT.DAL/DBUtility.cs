using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace RTT.DAL
{
    class DBUtility
    {
        static string strConnectionString = null;
        public static string GetConnectionString()
        {
            if (strConnectionString == null)
                strConnectionString = ConfigurationManager.ConnectionStrings["connString"].ToString();
            return strConnectionString;
        }
        public static SqlCommand GetCommand(string strCommand, CommandType objType, SqlConnection objCon)
        {
            SqlCommand objCmd = new SqlCommand();
            objCmd.CommandText = strCommand;
            objCmd.CommandType = objType;
            objCmd.Connection = objCon;

            return objCmd;
        }
    }
}
