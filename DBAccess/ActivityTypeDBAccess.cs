using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.Models;

namespace Rewards.DBA
{
public class ActivityTypeDBAccess
{

	ActivityUserTypeDBAccess activityUserTypeDBAccess = new ActivityUserTypeDBAccess();

	public List<ActivityUserType> GetListActivityUserType(int activityTypeID)
	{
		List<ActivityUserType> listActivityUserType = new List<ActivityUserType>() { };
		SqlParameter[] parametersActivityType = new SqlParameter[]
		{
			new SqlParameter("@ActivityTypeID", activityTypeID)
		};

		//Lets get the list of ActivityUserType records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ActivityUserType_GetList_UseInActivityType", CommandType.StoredProcedure, parametersActivityType))
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
	public Int64 Insert(ActivityType activityType)
	{
		SqlParameter[] parametersActivityType = new SqlParameter[]
		{
			new SqlParameter("@Title", activityType.Title)
		};
		activityType.ActivityTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("ActivityType_Insert", CommandType.StoredProcedure, parametersActivityType));
		return activityType.ActivityTypeID;
	}

	public bool Update(ActivityType activityType)
	{
		SqlParameter[] parametersActivityType = new SqlParameter[]
		{
			new SqlParameter("@ActivityTypeID", activityType.ActivityTypeID),
			new SqlParameter("@Title", activityType.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("ActivityType_Update", CommandType.StoredProcedure, parametersActivityType);
	}

	public bool Delete(int activityTypeID)
	{
		SqlParameter[] parametersActivityType = new SqlParameter[]
		{
			new SqlParameter("@ActivityTypeID", activityTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("ActivityType_Delete", CommandType.StoredProcedure, parametersActivityType);
	}

	public ActivityType GetDetails(int activityTypeID)
	{
		ActivityType activityType = new ActivityType();

		SqlParameter[] parametersActivityType = new SqlParameter[]
		{
			new SqlParameter("@ActivityTypeID", activityTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ActivityType_GetDetails", CommandType.StoredProcedure, parametersActivityType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				activityType.ActivityTypeID = (row["ActivityTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ActivityTypeID"]) : 0 ;
				activityType.Title = row["Title"].ToString();
			}
		}

		return activityType;
	}

	public List<ActivityType> GetListAll()
	{
		List<ActivityType> listActivityType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("ActivityType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listActivityType = new List<ActivityType>();

				foreach (DataRow row in table.Rows)
				{
					ActivityType activityType = new ActivityType();
					activityType.ActivityTypeID = (row["ActivityTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ActivityTypeID"]) : 0 ;
					activityType.Title = row["Title"].ToString();
					listActivityType.Add(activityType);
				}
			}
		}

		return listActivityType;
	}

	public bool Exists(int activityTypeID)
	{
		SqlParameter[] parametersActivityType = new SqlParameter[]
		{
			new SqlParameter("@ActivityTypeID", activityTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("ActivityType_Exists", CommandType.StoredProcedure, parametersActivityType)>0);
	}

	public bool Exists(ActivityType activityType)
	{
		SqlParameter[] parametersActivityType = new SqlParameter[]
		{
			new SqlParameter("@ActivityTypeID", activityType.ActivityTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("ActivityType_Exists", CommandType.StoredProcedure, parametersActivityType)>0);
	}

	public List<ActivityType> SearchLike(ActivityType activityType)
	{
		List<ActivityType> listActivityType = new List<ActivityType>();


		SqlParameter[] parametersActivityType = new SqlParameter[]
		{
			new SqlParameter("@ActivityTypeID", activityType.ActivityTypeID),
			new SqlParameter("@Title", activityType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ActivityType_SearchLike", CommandType.StoredProcedure, parametersActivityType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					ActivityType tmpActivityType = new ActivityType();
					tmpActivityType.ActivityTypeID = (row["ActivityTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ActivityTypeID"]) : 0 ;
					tmpActivityType.Title = row["Title"].ToString();

					listActivityType.Add(tmpActivityType);
				}
			}
		}

		return listActivityType;
	}

}
}
