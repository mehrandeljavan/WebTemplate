using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.Models;

namespace Rewards.DBA
{
public class EmployeeUserTypeDBAccess
{


	public Int64 Insert(EmployeeUserType employeeUserType)
	{
		SqlParameter[] parametersEmployeeUserType = new SqlParameter[]
		{
			new SqlParameter("@UserTypeID", (employeeUserType.UserTypeID > 0) ? employeeUserType.UserTypeID : (object)DBNull.Value),
			new SqlParameter("@NationalCode", (employeeUserType.NationalCode > 0) ? employeeUserType.NationalCode : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("EmployeeUserType_Insert", CommandType.StoredProcedure, parametersEmployeeUserType);
	}

	public bool Update(EmployeeUserType employeeUserType)
	{
		SqlParameter[] parametersEmployeeUserType = new SqlParameter[]
		{
			new SqlParameter("@UserTypeID", employeeUserType.UserTypeID),
			new SqlParameter("@NationalCode", employeeUserType.NationalCode)
		};
		return SqlDBHelper.ExecuteNonQuery("EmployeeUserType_Update", CommandType.StoredProcedure, parametersEmployeeUserType);
	}

	public bool Delete(int userTypeID , Int64 nationalCode)
	{
		SqlParameter[] parametersEmployeeUserType = new SqlParameter[]
		{
			new SqlParameter("@UserTypeID", userTypeID),
			new SqlParameter("@NationalCode", nationalCode)
		};
		return SqlDBHelper.ExecuteNonQuery("EmployeeUserType_Delete", CommandType.StoredProcedure, parametersEmployeeUserType);
	}

	public EmployeeUserType GetDetails(int userTypeID , Int64 nationalCode)
	{
		EmployeeUserType employeeUserType = new EmployeeUserType();

		SqlParameter[] parametersEmployeeUserType = new SqlParameter[]
		{
			new SqlParameter("@UserTypeID", userTypeID),
			new SqlParameter("@NationalCode", nationalCode)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("EmployeeUserType_GetDetails", CommandType.StoredProcedure, parametersEmployeeUserType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				employeeUserType.UserTypeID = (row["UserTypeID"] != DBNull.Value) ? Convert.ToInt32(row["UserTypeID"]) : 0 ;
				employeeUserType.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
				employeeUserType.EmployeeFullName = row["EmployeeFullName"].ToString();
				employeeUserType.UserTypeIDTitle = row["UserTypeIDTitle"].ToString();
			}
		}

		return employeeUserType;
	}

	public List<EmployeeUserType> GetListAll()
	{
		List<EmployeeUserType> listEmployeeUserType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("EmployeeUserType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listEmployeeUserType = new List<EmployeeUserType>();

				foreach (DataRow row in table.Rows)
				{
					EmployeeUserType employeeUserType = new EmployeeUserType();
					employeeUserType.UserTypeID = (row["UserTypeID"] != DBNull.Value) ? Convert.ToInt32(row["UserTypeID"]) : 0 ;
					employeeUserType.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
					employeeUserType.EmployeeFullName = row["EmployeeFullName"].ToString();
					employeeUserType.UserTypeIDTitle = row["UserTypeIDTitle"].ToString();
					listEmployeeUserType.Add(employeeUserType);
				}
			}
		}

		return listEmployeeUserType;
	}

	public bool Exists(int userTypeID , Int64 nationalCode)
	{
		SqlParameter[] parametersEmployeeUserType = new SqlParameter[]
		{
			new SqlParameter("@UserTypeID", userTypeID),
			new SqlParameter("@NationalCode", nationalCode)
		};
		return (SqlDBHelper.ExecuteScalar("EmployeeUserType_Exists", CommandType.StoredProcedure, parametersEmployeeUserType)>0);
	}

	public bool Exists(EmployeeUserType employeeUserType)
	{
		SqlParameter[] parametersEmployeeUserType = new SqlParameter[]
		{
			new SqlParameter("@UserTypeID", employeeUserType.UserTypeID),
			new SqlParameter("@NationalCode", employeeUserType.NationalCode)
		};
		return (SqlDBHelper.ExecuteScalar("EmployeeUserType_Exists", CommandType.StoredProcedure, parametersEmployeeUserType)>0);
	}

	public List<EmployeeUserType> SearchLike(EmployeeUserType employeeUserType)
	{
		List<EmployeeUserType> listEmployeeUserType = new List<EmployeeUserType>();


		SqlParameter[] parametersEmployeeUserType = new SqlParameter[]
		{
			new SqlParameter("@UserTypeID", employeeUserType.UserTypeID),
			new SqlParameter("@NationalCode", employeeUserType.NationalCode),
			new SqlParameter("@EmployeeFullName", employeeUserType.EmployeeFullName),
			new SqlParameter("@UserTypeIDTitle", employeeUserType.UserTypeIDTitle),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("EmployeeUserType_SearchLike", CommandType.StoredProcedure, parametersEmployeeUserType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					EmployeeUserType tmpEmployeeUserType = new EmployeeUserType();
					tmpEmployeeUserType.UserTypeID = (row["UserTypeID"] != DBNull.Value) ? Convert.ToInt32(row["UserTypeID"]) : 0 ;
					tmpEmployeeUserType.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
					tmpEmployeeUserType.EmployeeFullName = row["EmployeeFullName"].ToString();
					tmpEmployeeUserType.UserTypeIDTitle = row["UserTypeIDTitle"].ToString();

					listEmployeeUserType.Add(tmpEmployeeUserType);
				}
			}
		}

		return listEmployeeUserType;
	}

}
}
