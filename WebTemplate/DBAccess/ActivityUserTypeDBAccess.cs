using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.Models;

namespace Rewards.DBA
{
public class ActivityUserTypeDBAccess
{


	public Int64 Insert(ActivityUserType activityUserType)
	{
		SqlParameter[] parametersActivityUserType = new SqlParameter[]
		{
			new SqlParameter("@ActivityTypeID", (activityUserType.ActivityTypeID > 0) ? activityUserType.ActivityTypeID : (object)DBNull.Value),
			new SqlParameter("@UserTypeID", (activityUserType.UserTypeID > 0) ? activityUserType.UserTypeID : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("ActivityUserType_Insert", CommandType.StoredProcedure, parametersActivityUserType);
	}

	public bool Update(ActivityUserType activityUserType)
	{
		SqlParameter[] parametersActivityUserType = new SqlParameter[]
		{
			new SqlParameter("@ActivityTypeID", activityUserType.ActivityTypeID),
			new SqlParameter("@UserTypeID", activityUserType.UserTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("ActivityUserType_Update", CommandType.StoredProcedure, parametersActivityUserType);
	}

	public bool Delete(int activityTypeID , int userTypeID)
	{
		SqlParameter[] parametersActivityUserType = new SqlParameter[]
		{
			new SqlParameter("@ActivityTypeID", activityTypeID),
			new SqlParameter("@UserTypeID", userTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("ActivityUserType_Delete", CommandType.StoredProcedure, parametersActivityUserType);
	}

	public ActivityUserType GetDetails(int activityTypeID , int userTypeID)
	{
		ActivityUserType activityUserType = new ActivityUserType();

		SqlParameter[] parametersActivityUserType = new SqlParameter[]
		{
			new SqlParameter("@ActivityTypeID", activityTypeID),
			new SqlParameter("@UserTypeID", userTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ActivityUserType_GetDetails", CommandType.StoredProcedure, parametersActivityUserType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				activityUserType.ActivityTypeID = (row["ActivityTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ActivityTypeID"]) : 0 ;
				activityUserType.UserTypeID = (row["UserTypeID"] != DBNull.Value) ? Convert.ToInt32(row["UserTypeID"]) : 0 ;
				activityUserType.ActivityTypeIDTitle = row["ActivityTypeIDTitle"].ToString();
				activityUserType.UserTypeIDTitle = row["UserTypeIDTitle"].ToString();
			}
		}

		return activityUserType;
	}

	public List<ActivityUserType> GetListAll()
	{
		List<ActivityUserType> listActivityUserType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("ActivityUserType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listActivityUserType = new List<ActivityUserType>();

				foreach (DataRow row in table.Rows)
				{
					ActivityUserType activityUserType = new ActivityUserType();
					activityUserType.ActivityTypeID = (row["ActivityTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ActivityTypeID"]) : 0 ;
					activityUserType.UserTypeID = (row["UserTypeID"] != DBNull.Value) ? Convert.ToInt32(row["UserTypeID"]) : 0 ;
					activityUserType.ActivityTypeIDTitle = row["ActivityTypeIDTitle"].ToString();
					activityUserType.UserTypeIDTitle = row["UserTypeIDTitle"].ToString();
					listActivityUserType.Add(activityUserType);
				}
			}
		}

		return listActivityUserType;
	}

	public bool Exists(int activityTypeID , int userTypeID)
	{
		SqlParameter[] parametersActivityUserType = new SqlParameter[]
		{
			new SqlParameter("@ActivityTypeID", activityTypeID),
			new SqlParameter("@UserTypeID", userTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("ActivityUserType_Exists", CommandType.StoredProcedure, parametersActivityUserType)>0);
	}

	public bool Exists(ActivityUserType activityUserType)
	{
		SqlParameter[] parametersActivityUserType = new SqlParameter[]
		{
			new SqlParameter("@ActivityTypeID", activityUserType.ActivityTypeID),
			new SqlParameter("@UserTypeID", activityUserType.UserTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("ActivityUserType_Exists", CommandType.StoredProcedure, parametersActivityUserType)>0);
	}

	public List<ActivityUserType> SearchLike(ActivityUserType activityUserType)
	{
		List<ActivityUserType> listActivityUserType = new List<ActivityUserType>();


		SqlParameter[] parametersActivityUserType = new SqlParameter[]
		{
			new SqlParameter("@ActivityTypeID", activityUserType.ActivityTypeID),
			new SqlParameter("@UserTypeID", activityUserType.UserTypeID),
			new SqlParameter("@ActivityTypeIDTitle", activityUserType.ActivityTypeIDTitle),
			new SqlParameter("@UserTypeIDTitle", activityUserType.UserTypeIDTitle),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ActivityUserType_SearchLike", CommandType.StoredProcedure, parametersActivityUserType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					ActivityUserType tmpActivityUserType = new ActivityUserType();
					tmpActivityUserType.ActivityTypeID = (row["ActivityTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ActivityTypeID"]) : 0 ;
					tmpActivityUserType.UserTypeID = (row["UserTypeID"] != DBNull.Value) ? Convert.ToInt32(row["UserTypeID"]) : 0 ;
					tmpActivityUserType.ActivityTypeIDTitle = row["ActivityTypeIDTitle"].ToString();
					tmpActivityUserType.UserTypeIDTitle = row["UserTypeIDTitle"].ToString();

					listActivityUserType.Add(tmpActivityUserType);
				}
			}
		}

		return listActivityUserType;
	}

}
}
