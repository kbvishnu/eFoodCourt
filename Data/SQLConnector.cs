using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace E_FoodCourt.Data
{
    public class SQLConnector
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdaptor;
        SqlDataReader sqlDataReader;
        SqlConnectionStringBuilder sqlConnectionStringBuilder;
        public SQLConnector()
        {
            try
            {
                sqlConnectionStringBuilder = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["EMCConnectionString"].ToString());
                sqlConnection = new SqlConnection(sqlConnectionStringBuilder.ToString());
                sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
            }
            catch (SqlException ex)
            {
                throw;
            }
        }
        public int ExecuteNonQuery(string sqlString)
        {
            return ExecuteNonQuery(sqlString, 300);
        }
        public int ExecuteNonQuery(string sqlString, int connectionTimeOut)
        {
            try
            {
                sqlCommand.CommandText = sqlString;
                sqlCommand.CommandTimeout = connectionTimeOut;
                return sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw;
            }
        }
        public int ExecuteScalar(string sqlString)
        {
            return ExecuteScalar(sqlString, 300);
        }
        public int ExecuteScalar(string sqlString, int connectionTimeOut)
        {
            try
            {
                sqlCommand.CommandText = sqlString;
                sqlCommand.CommandTimeout = connectionTimeOut;
                return Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw;
            }
        }
        public void ExecuteReader(string sqlString)
        {
            ExecuteReader(sqlString, 300);
        }
        public void ExecuteReader(string sqlString, int connectionTimeOut)
        {
            try
            {
                sqlCommand.CommandText = sqlString;
                sqlCommand.CommandTimeout = connectionTimeOut;
                sqlCommand.ExecuteReader();
            }
            catch (SqlException ex)
            {
                throw;
            }
        }
        public DataSet GetData(string sqlString)
        {
            return GetData(sqlString, 30);
        }
        public DataSet GetData(string sqlString, int connectionTimeOut)
        {
            try
            {
                DataSet ds = new DataSet();
                sqlCommand.CommandText = sqlString;
                sqlCommand.CommandTimeout = connectionTimeOut;
                sqlDataAdaptor = new SqlDataAdapter();
                sqlDataAdaptor.SelectCommand = sqlCommand;
                sqlDataAdaptor.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}