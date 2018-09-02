using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.Models;

namespace Rewards.DBA
{
public class UserTypeDBAccess
{

	ActivityUserTypeDBAccess activityUserTypeDBAccess = new ActivityUserTypeDBAccess();
	EmployeeUserTypeDBAccess employeeUserTypeDBAccess = new EmployeeUserTypeDBAccess();

	public List<ActivityUserType> GetListActivityUserType(int userTypeID)
	{
		List<ActivityUserType> listActivityUserType = new List<ActivityUserType>() { };
		SqlParameter[] parametersUserType = new SqlParameter[]
		{
			new SqlParameter("@UserTypeID", userTypeID)
		};

		//Lets get the list of ActivityUserType records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ActivityUserType_GetList_UseInUserType", CommandType.StoredProcedure, parametersUserType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of activityUserType
				listActivityUserType = new List<ActivityUserType>();

				//Now lets populate the ActivityUserType details into the list of activityUserTypes
				foreach (DataRow row in table.Rows)
				{
					ActivityUserType activityUserType = ConvertRowToActivityUserType(row);
					listActivityUserType.Add(activityUserType);
				}
			}
		}

		return listActivityUserType;
	}

	private ActivityUserType ConvertRowToActivityUserType(DataRow row)
	{
		ActivityUserType activityUserType = new ActivityUserType();
		activityUserType.ActivityTypeID = (row["ActivityTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ActivityTypeID"]) : 0 ;
		activityUserType.UserTypeID = (row["UserTypeID"] != DBNull.Value) ? Convert.ToInt32(row["UserTypeID"]) : 0 ;
		activityUserType.ActivityTypeIDTitle = row["ActivityTypeIDTitle"].ToString();
		activityUserType.UserTypeIDTitle = row["UserTypeIDTitle"].ToString();
		return activityUserType;
	}
	public List<EmployeeUserType> GetListEmployeeUserType(int userTypeID)
	{
		List<EmployeeUserType> listEmployeeUserType = new List<EmployeeUserType>() { };
		SqlParameter[] parametersUserType = new SqlParameter[]
		{
			new SqlParameter("@UserTypeID", userTypeID)
		};

		//Lets get the list of EmployeeUserType records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("EmployeeUserType_GetList_UseInUserType", CommandType.StoredProcedure, parametersUserType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of employeeUserType
				listEmployeeUserType = new List<EmployeeUserType>();

				//Now lets populate the EmployeeUserType details into the list of employeeUserTypes
				foreach (DataRow row in table.Rows)
				{
					EmployeeUserType employeeUserType = ConvertRowToEmployeeUserType(row);
					listEmployeeUserType.Add(employeeUserType);
				}
			}
		}

		return listEmployeeUserType;
	}

	private EmployeeUserType ConvertRowToEmployeeUserType(DataRow row)
	{
		EmployeeUserType employeeUserType = new EmployeeUserType();
		employeeUserType.UserTypeID = (row["UserTypeID"] != DBNull.Value) ? Convert.ToInt32(row["UserTypeID"]) : 0 ;
		employeeUserType.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
		employeeUserType.EmployeeFullName = row["EmployeeFullName"].ToString();
		employeeUserType.UserTypeIDTitle = row["UserTypeIDTitle"].ToString();
		return employeeUserType;
	}
	public Int64 Insert(UserType userType)
	{
		SqlParameter[] parametersUserType = new SqlParameter[]
		{
			new SqlParameter("@Title", userType.Title)
		};
		userType.UserTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("UserType_Insert", CommandType.StoredProcedure, parametersUserType));
		return userType.UserTypeID;
	}

	public bool Update(UserType userType)
	{
		SqlParameter[] parametersUserType = new SqlParameter[]
		{
			new SqlParameter("@UserTypeID", userType.UserTypeID),
			new SqlParameter("@Title", userType.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("UserType_Update", CommandType.StoredProcedure, parametersUserType);
	}

	public bool Delete(int userTypeID)
	{
		SqlParameter[] parametersUserType = new SqlParameter[]
		{
			new SqlParameter("@UserTypeID", userTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("UserType_Delete", CommandType.StoredProcedure, parametersUserType);
	}

	public UserType GetDetails(int userTypeID)
	{
		UserType userType = new UserType();

		SqlParameter[] parametersUserType = new SqlParameter[]
		{
			new SqlParameter("@UserTypeID", userTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UserType_GetDetails", CommandType.StoredProcedure, parametersUserType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				userType.UserTypeID = (row["UserTypeID"] != DBNull.Value) ? Convert.ToInt32(row["UserTypeID"]) : 0 ;
				userType.Title = row["Title"].ToString();
			}
		}

		return userType;
	}

	public List<UserType> GetListAll()
	{
		List<UserType> listUserType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("UserType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listUserType = new List<UserType>();

				foreach (DataRow row in table.Rows)
				{
					UserType userType = new UserType();
					userType.UserTypeID = (row["UserTypeID"] != DBNull.Value) ? Convert.ToInt32(row["UserTypeID"]) : 0 ;
					userType.Title = row["Title"].ToString();
					listUserType.Add(userType);
				}
			}
		}

		return listUserType;
	}

	public bool Exists(int userTypeID)
	{
		SqlParameter[] parametersUserType = new SqlParameter[]
		{
			new SqlParameter("@UserTypeID", userTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("UserType_Exists", CommandType.StoredProcedure, parametersUserType)>0);
	}

	public bool Exists(UserType userType)
	{
		SqlParameter[] parametersUserType = new SqlParameter[]
		{
			new SqlParameter("@UserTypeID", userType.UserTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("UserType_Exists", CommandType.StoredProcedure, parametersUserType)>0);
	}

	public List<UserType> SearchLike(UserType userType)
	{
		List<UserType> listUserType = new List<UserType>();


		SqlParameter[] parametersUserType = new SqlParameter[]
		{
			new SqlParameter("@UserTypeID", userType.UserTypeID),
			new SqlParameter("@Title", userType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UserType_SearchLike", CommandType.StoredProcedure, parametersUserType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					UserType tmpUserType = new UserType();
					tmpUserType.UserTypeID = (row["UserTypeID"] != DBNull.Value) ? Convert.ToInt32(row["UserTypeID"]) : 0 ;
					tmpUserType.Title = row["Title"].ToString();

					listUserType.Add(tmpUserType);
				}
			}
		}

		return listUserType;
	}

}
}
