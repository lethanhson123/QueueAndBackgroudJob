using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Helpers
{
    public static class SQLHelper
    {
        public static string ExecuteNonQueryByStoredProcedure(string connectionString, string storedProcedureName, params SqlParameter[] parameters)
        {
            string result = "";
            try
            {

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddRange(parameters);
                        conn.Open();
                        result = cmd.ExecuteNonQuery().ToString();
                    }
                }
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }

        public static async Task<string> ExecuteNonQueryByStoredProcedureAsync(string connectionString, string storedProcedureName, params SqlParameter[] parameters)
        {
            string result = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddRange(parameters);
                        await conn.OpenAsync();
                        int result01 = await cmd.ExecuteNonQueryAsync();
                        result = result01.ToString();                        
                    }
                }
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }

        public static object ExecuteScalarByStoredProcedure(string connectionString, string storedProcedureName, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    return result;
                }
            }
        }

        public static async Task<object> ExecuteScalarByStoredProcedureAsync(string connectionString, string storedProcedureName, params SqlParameter[] parameters)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(parameters);
                    await conn.OpenAsync();
                    var result = await cmd.ExecuteScalarAsync();
                    return result;
                }
            }
        }

        public static SqlDataReader ExecuteReaderByStoredProcedure(string connectionString, string storedProcedureName, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    SqlDataReader result = cmd.ExecuteReader();
                    return result;

                }
            }
        }

        public static async Task<SqlDataReader> ExecuteReaderByStoredProcedureAsync(string connectionString, string storedProcedureName, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(parameters);
                    await conn.OpenAsync();
                    var result = await cmd.ExecuteReaderAsync();
                    return result;
                }
            }
        }

        public static DataTable FillDataTableByStoredProcedure(string connectionString, string storedProcedureName, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            string result = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddRange(parameters);
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        conn.Open();
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return dt;
        }

        public static async Task<DataTable> FillDataTableByStoredProcedureAsync(string connectionString, string storedProcedureName, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            string result = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddRange(parameters);
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        await conn.OpenAsync();
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return dt;
        }

        public static DataSet FillDataSetByStoredProcedure(string connectionString, string storedProcedureName, params SqlParameter[] parameters)
        {
            DataSet ds = new DataSet();
            string result = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddRange(parameters);
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        conn.Open();
                        adapter.Fill(ds);
                    }
                }
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return ds;
        }

        public static async Task<DataSet> FillDataSetByStoredProcedureAsync(string connectionString, string storedProcedureName, params SqlParameter[] parameters)
        {
            DataSet ds = new DataSet();
            string result = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddRange(parameters);
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        await conn.OpenAsync();
                        adapter.Fill(ds);
                    }
                }
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return ds;
        }

		public static string ExecuteNonQueryBySQL(string connectionString, string sql, params SqlParameter[] parameters)
		{
			string result = "";
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					using (SqlCommand cmd = new SqlCommand(sql, conn))
					{
						cmd.CommandType = CommandType.Text;
						cmd.Parameters.AddRange(parameters);
						conn.Open();
						result = cmd.ExecuteNonQuery().ToString();
					}
				}
			}
			catch (Exception e)
			{
				result = e.Message;
			}
			return result;
		}

		public static async Task<string> ExecuteNonQueryBySQLAsync(string connectionString, string sql, params SqlParameter[] parameters)
		{
			string result = "";
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					using (SqlCommand cmd = new SqlCommand(sql, conn))
					{
						cmd.CommandType = CommandType.Text;
						cmd.Parameters.AddRange(parameters);
						await conn.OpenAsync();
						int result01 = await cmd.ExecuteNonQueryAsync();
						result = result01.ToString();
					}
				}
			}
			catch (Exception e)
			{
				result = e.Message;
			}
			return result;
		}

		public static object ExecuteScalarBySQL(string connectionString, string sql, params SqlParameter[] parameters)
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					cmd.CommandType = CommandType.Text;
					cmd.Parameters.AddRange(parameters);
					conn.Open();
					var result = cmd.ExecuteScalar();
					return result;
				}
			}
		}

		public static async Task<object> ExecuteScalarBySQLAsync(string connectionString, string sql, params SqlParameter[] parameters)
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					cmd.CommandType = CommandType.Text;
					cmd.Parameters.AddRange(parameters);
					await conn.OpenAsync();
					var result = await cmd.ExecuteScalarAsync();
					return result;
				}
			}
		}

		public static SqlDataReader ExecuteReaderBySQL(string connectionString, string sql, params SqlParameter[] parameters)
		{
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    SqlDataReader result = cmd.ExecuteReader();
                    return result;
                }
            }
		}

		public static async Task<SqlDataReader> ExecuteReaderBySQLAsync(string connectionString, string sql, params SqlParameter[] parameters)
		{
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddRange(parameters);
                    await conn.OpenAsync();
                    var result = await cmd.ExecuteReaderAsync();
                    return result;
                }
            }
		}

		public static DataTable FillDataTableBySQL(string connectionString, string sql, params SqlParameter[] parameters)
		{
			DataTable dt = new DataTable();
			string result = "";
			try
			{
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddRange(parameters);
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        conn.Open();
                        adapter.Fill(dt);
                    }
                }
			}
			catch (Exception e)
			{
				result = e.Message;
			}
			return dt;
		}

		public static async Task<DataTable> FillDataTableBySQLAsync(string connectionString, string sql, params SqlParameter[] parameters)
		{
			DataTable dt = new DataTable();
			string result = "";
			try
			{
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddRange(parameters);
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        await conn.OpenAsync();
                        adapter.Fill(dt);
                    }
                }
			}
			catch (Exception e)
			{
				result = e.Message;
			}
			return dt;
		}

		public static DataSet FillDataSetBySQL(string connectionString, string sql, params SqlParameter[] parameters)
		{
			DataSet ds = new DataSet();
			string result = "";
			try
			{
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddRange(parameters);
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        conn.Open();
                        adapter.Fill(ds);
                    }
                }
			}
			catch (Exception e)
			{
				result = e.Message;
			}
			return ds;
		}

		public static async Task<DataSet> FillDataSetBySQLAsync(string connectionString, string sql, params SqlParameter[] parameters)
		{
			DataSet ds = new DataSet();
			string result = "";
			try
			{
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddRange(parameters);
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        await conn.OpenAsync();
                        adapter.Fill(ds);
                    }
                }
			}
			catch (Exception e)
			{
				result = e.Message;
			}
			return ds;
		}

		public static List<T> ToList<T>(this DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }

        public static IEnumerable<T> ToIEnumerable<T>(this DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                yield return item;
            }
        }

        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    try
                    {
                        if (pro.Name == column.ColumnName && dr[column.ColumnName] != DBNull.Value)
                        {
                            Type t = Nullable.GetUnderlyingType(pro.PropertyType) ?? pro.PropertyType;

                            pro.SetValue(obj, System.Convert.ChangeType(dr[column.ColumnName], t), null);
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            return obj;
        }
    }
}
