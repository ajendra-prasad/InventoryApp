using InventoryApp.Common;
using InventoryApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace InventoryApp.Repository
{
    public class AuthenticationRepository
    {
        public AuthenticationRepository()
        {
        }

        public bool AuthorizeUser(User user)
        {
            if (user.UserName == "ajendra" && user.Password == "123")
                return true;
            else
                return false;
            //using (SqlConnection sqlConnection = new SqlConnection(ConfigSetting.DBConnectionString))
            //{
            //    List<SqlParameter> parameterList = new List<SqlParameter>();

            //    parameterList.Add(new SqlParameter("@UserName", user.UserName));
            //    parameterList.Add(new SqlParameter("@Password", user.Password));

            //    if (sqlConnection.State == ConnectionState.Closed)
            //    {
            //        sqlConnection.Open();
            //    }

            //    return Convert.ToBoolean(BaseRepository.ExecuteScalar(sqlConnection, CommandType.StoredProcedure, "uspAuthorizeUser", parameterList.ToArray()));
            //}
        }
    }
}
