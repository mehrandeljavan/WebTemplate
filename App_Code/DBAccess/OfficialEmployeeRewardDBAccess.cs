using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.Models;

namespace Rewards.DBA
{
public class OfficialEmployeeRewardDBAccess
{


	public Int64 Insert(OfficialEmployeeReward officialEmployeeReward)
	{
		SqlParameter[] parametersOfficialEmployeeReward = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", (officialEmployeeReward.NationalCode > 0) ? officialEmployeeReward.NationalCode : (object)DBNull.Value),
			new SqlParameter("@YearTypeID", (officialEmployeeReward.YearTypeID > 0) ? officialEmployeeReward.YearTypeID : (object)DBNull.Value),
			new SqlParameter("@MonthTypeID", (officialEmployeeReward.MonthTypeID > 0) ? officialEmployeeReward.MonthTypeID : (object)DBNull.Value),
			new SqlParameter("@BossFactor", officialEmployeeReward.BossFactor),
			new SqlParameter("@Reward", officialEmployeeReward.Reward),
			new SqlParameter("@BossFinalValue", officialEmployeeReward.BossFinalValue),
			new SqlParameter("@AssistantFinalValue", officialEmployeeReward.AssistantFinalValue),
			new SqlParameter("@ManagerFinalValue", officialEmployeeReward.ManagerFinalValue),
			new SqlParameter("@ExtraReward1", officialEmployeeReward.ExtraReward1),
			new SqlParameter("@ExtraReward2", officialEmployeeReward.ExtraReward2),
			new SqlParameter("@ExtraReward3", officialEmployeeReward.ExtraReward3),
			new SqlParameter("@RoleTypeID", (officialEmployeeReward.RoleTypeID != null) ? officialEmployeeReward.RoleTypeID : (object)DBNull.Value),
			new SqlParameter("@Parameter1", officialEmployeeReward.Parameter1),
			new SqlParameter("@Parameter2", officialEmployeeReward.Parameter2),
			new SqlParameter("@Parameter3", officialEmployeeReward.Parameter3)
		};
		return SqlDBHelper.ExecuteScalar("OfficialEmployeeReward_Insert", CommandType.StoredProcedure, parametersOfficialEmployeeReward);
	}

	public bool Update(OfficialEmployeeReward officialEmployeeReward)
	{
		SqlParameter[] parametersOfficialEmployeeReward = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", officialEmployeeReward.NationalCode),
			new SqlParameter("@YearTypeID", officialEmployeeReward.YearTypeID),
			new SqlParameter("@MonthTypeID", officialEmployeeReward.MonthTypeID),
			new SqlParameter("@BossFactor", officialEmployeeReward.BossFactor),
			new SqlParameter("@Reward", officialEmployeeReward.Reward),
			new SqlParameter("@BossFinalValue", officialEmployeeReward.BossFinalValue),
			new SqlParameter("@AssistantFinalValue", officialEmployeeReward.AssistantFinalValue),
			new SqlParameter("@ManagerFinalValue", officialEmployeeReward.ManagerFinalValue),
			new SqlParameter("@ExtraReward1", officialEmployeeReward.ExtraReward1),
			new SqlParameter("@ExtraReward2", officialEmployeeReward.ExtraReward2),
			new SqlParameter("@ExtraReward3", officialEmployeeReward.ExtraReward3),
			new SqlParameter("@RoleTypeID", (officialEmployeeReward.RoleTypeID != null) ? officialEmployeeReward.RoleTypeID : (object)DBNull.Value),
			new SqlParameter("@Parameter1", officialEmployeeReward.Parameter1),
			new SqlParameter("@Parameter2", officialEmployeeReward.Parameter2),
			new SqlParameter("@Parameter3", officialEmployeeReward.Parameter3)
		};
		return SqlDBHelper.ExecuteNonQuery("OfficialEmployeeReward_Update", CommandType.StoredProcedure, parametersOfficialEmployeeReward);
	}

	public bool Delete(Int64 nationalCode , int yearTypeID , int monthTypeID)
	{
		SqlParameter[] parametersOfficialEmployeeReward = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", nationalCode),
			new SqlParameter("@YearTypeID", yearTypeID),
			new SqlParameter("@MonthTypeID", monthTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("OfficialEmployeeReward_Delete", CommandType.StoredProcedure, parametersOfficialEmployeeReward);
	}

	public OfficialEmployeeReward GetDetails(Int64 nationalCode , int yearTypeID , int monthTypeID)
	{
		OfficialEmployeeReward officialEmployeeReward = new OfficialEmployeeReward();

		SqlParameter[] parametersOfficialEmployeeReward = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", nationalCode),
			new SqlParameter("@YearTypeID", yearTypeID),
			new SqlParameter("@MonthTypeID", monthTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("OfficialEmployeeReward_GetDetails", CommandType.StoredProcedure, parametersOfficialEmployeeReward))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				officialEmployeeReward.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
				officialEmployeeReward.YearTypeID = (row["YearTypeID"] != DBNull.Value) ? Convert.ToInt32(row["YearTypeID"]) : 0 ;
				officialEmployeeReward.MonthTypeID = (row["MonthTypeID"] != DBNull.Value) ? Convert.ToInt32(row["MonthTypeID"]) : 0 ;
				officialEmployeeReward.EmployeeFullName = row["EmployeeFullName"].ToString();
				officialEmployeeReward.DepartmentIDTitle = row["DepartmentIDTitle"].ToString();
				officialEmployeeReward.YearTypeIDTitle = row["YearTypeIDTitle"].ToString();
				officialEmployeeReward.MonthTypeIDTitle = row["MonthTypeIDTitle"].ToString();
				officialEmployeeReward.RoleTypeIDTitle = row["RoleTypeIDTitle"].ToString();
				officialEmployeeReward.TotalReward = (row["TotalReward"] != DBNull.Value) ? Convert.ToInt64(row["TotalReward"]) : 0 ;
				officialEmployeeReward.Reward_ = (row["Reward_"] != DBNull.Value) ? Convert.ToInt64(row["Reward_"]) : 0 ;
				officialEmployeeReward.RoleTypeIDFactor = (row["RoleTypeIDFactor"] != DBNull.Value) ? Convert.ToDecimal(row["RoleTypeIDFactor"]) : 0 ;
				officialEmployeeReward.BossFactor = (row["BossFactor"] != DBNull.Value) ? Convert.ToDecimal(row["BossFactor"]) : 0 ;
				officialEmployeeReward.Reward = (row["Reward"] != DBNull.Value) ? Convert.ToInt64(row["Reward"]) : 0 ;
				officialEmployeeReward.BossFinalValue = (row["BossFinalValue"] != DBNull.Value) ? Convert.ToInt64(row["BossFinalValue"]) : 0 ;
				officialEmployeeReward.AssistantFinalValue = (row["AssistantFinalValue"] != DBNull.Value) ? Convert.ToInt64(row["AssistantFinalValue"]) : 0 ;
				officialEmployeeReward.ManagerFinalValue = (row["ManagerFinalValue"] != DBNull.Value) ? Convert.ToInt64(row["ManagerFinalValue"]) : 0 ;
				officialEmployeeReward.ExtraReward1 = (row["ExtraReward1"] != DBNull.Value) ? Convert.ToInt64(row["ExtraReward1"]) : 0 ;
				officialEmployeeReward.ExtraReward2 = (row["ExtraReward2"] != DBNull.Value) ? Convert.ToInt64(row["ExtraReward2"]) : 0 ;
				officialEmployeeReward.ExtraReward3 = (row["ExtraReward3"] != DBNull.Value) ? Convert.ToInt64(row["ExtraReward3"]) : 0 ;
				officialEmployeeReward.RoleTypeID = (row["RoleTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RoleTypeID"]) : 0 ;
				officialEmployeeReward.Parameter1 = (row["Parameter1"] != DBNull.Value) ? Convert.ToInt32(row["Parameter1"]) : 0 ;
				officialEmployeeReward.Parameter2 = (row["Parameter2"] != DBNull.Value) ? Convert.ToInt32(row["Parameter2"]) : 0 ;
				officialEmployeeReward.Parameter3 = (row["Parameter3"] != DBNull.Value) ? Convert.ToInt32(row["Parameter3"]) : 0 ;
			}
		}

		return officialEmployeeReward;
	}

	public List<OfficialEmployeeReward> GetListAll()
	{
		List<OfficialEmployeeReward> listOfficialEmployeeReward = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("OfficialEmployeeReward_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listOfficialEmployeeReward = new List<OfficialEmployeeReward>();

				foreach (DataRow row in table.Rows)
				{
					OfficialEmployeeReward officialEmployeeReward = new OfficialEmployeeReward();
					officialEmployeeReward.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
					officialEmployeeReward.YearTypeID = (row["YearTypeID"] != DBNull.Value) ? Convert.ToInt32(row["YearTypeID"]) : 0 ;
					officialEmployeeReward.MonthTypeID = (row["MonthTypeID"] != DBNull.Value) ? Convert.ToInt32(row["MonthTypeID"]) : 0 ;
					officialEmployeeReward.EmployeeFullName = row["EmployeeFullName"].ToString();
					officialEmployeeReward.DepartmentIDTitle = row["DepartmentIDTitle"].ToString();
					officialEmployeeReward.YearTypeIDTitle = row["YearTypeIDTitle"].ToString();
					officialEmployeeReward.MonthTypeIDTitle = row["MonthTypeIDTitle"].ToString();
					officialEmployeeReward.RoleTypeIDTitle = row["RoleTypeIDTitle"].ToString();
					officialEmployeeReward.TotalReward = (row["TotalReward"] != DBNull.Value) ? Convert.ToInt64(row["TotalReward"]) : 0 ;
					officialEmployeeReward.Reward_ = (row["Reward_"] != DBNull.Value) ? Convert.ToInt64(row["Reward_"]) : 0 ;
					officialEmployeeReward.RoleTypeIDFactor = (row["RoleTypeIDFactor"] != DBNull.Value) ? Convert.ToDecimal(row["RoleTypeIDFactor"]) : 0 ;
					officialEmployeeReward.BossFactor = (row["BossFactor"] != DBNull.Value) ? Convert.ToDecimal(row["BossFactor"]) : 0 ;
					officialEmployeeReward.Reward = (row["Reward"] != DBNull.Value) ? Convert.ToInt64(row["Reward"]) : 0 ;
					officialEmployeeReward.BossFinalValue = (row["BossFinalValue"] != DBNull.Value) ? Convert.ToInt64(row["BossFinalValue"]) : 0 ;
					officialEmployeeReward.AssistantFinalValue = (row["AssistantFinalValue"] != DBNull.Value) ? Convert.ToInt64(row["AssistantFinalValue"]) : 0 ;
					officialEmployeeReward.ManagerFinalValue = (row["ManagerFinalValue"] != DBNull.Value) ? Convert.ToInt64(row["ManagerFinalValue"]) : 0 ;
					officialEmployeeReward.ExtraReward1 = (row["ExtraReward1"] != DBNull.Value) ? Convert.ToInt64(row["ExtraReward1"]) : 0 ;
					officialEmployeeReward.ExtraReward2 = (row["ExtraReward2"] != DBNull.Value) ? Convert.ToInt64(row["ExtraReward2"]) : 0 ;
					officialEmployeeReward.ExtraReward3 = (row["ExtraReward3"] != DBNull.Value) ? Convert.ToInt64(row["ExtraReward3"]) : 0 ;
					officialEmployeeReward.RoleTypeID = (row["RoleTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RoleTypeID"]) : 0 ;
					officialEmployeeReward.Parameter1 = (row["Parameter1"] != DBNull.Value) ? Convert.ToInt32(row["Parameter1"]) : 0 ;
					officialEmployeeReward.Parameter2 = (row["Parameter2"] != DBNull.Value) ? Convert.ToInt32(row["Parameter2"]) : 0 ;
					officialEmployeeReward.Parameter3 = (row["Parameter3"] != DBNull.Value) ? Convert.ToInt32(row["Parameter3"]) : 0 ;
					listOfficialEmployeeReward.Add(officialEmployeeReward);
				}
			}
		}

		return listOfficialEmployeeReward;
	}

	public bool Exists(Int64 nationalCode , int yearTypeID , int monthTypeID)
	{
		SqlParameter[] parametersOfficialEmployeeReward = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", nationalCode),
			new SqlParameter("@YearTypeID", yearTypeID),
			new SqlParameter("@MonthTypeID", monthTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("OfficialEmployeeReward_Exists", CommandType.StoredProcedure, parametersOfficialEmployeeReward)>0);
	}

	public bool Exists(OfficialEmployeeReward officialEmployeeReward)
	{
		SqlParameter[] parametersOfficialEmployeeReward = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", officialEmployeeReward.NationalCode),
			new SqlParameter("@YearTypeID", officialEmployeeReward.YearTypeID),
			new SqlParameter("@MonthTypeID", officialEmployeeReward.MonthTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("OfficialEmployeeReward_Exists", CommandType.StoredProcedure, parametersOfficialEmployeeReward)>0);
	}

	public List<OfficialEmployeeReward> SearchLike(OfficialEmployeeReward officialEmployeeReward)
	{
		List<OfficialEmployeeReward> listOfficialEmployeeReward = new List<OfficialEmployeeReward>();


		SqlParameter[] parametersOfficialEmployeeReward = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", officialEmployeeReward.NationalCode),
			new SqlParameter("@YearTypeID", officialEmployeeReward.YearTypeID),
			new SqlParameter("@MonthTypeID", officialEmployeeReward.MonthTypeID),
			new SqlParameter("@EmployeeFullName", officialEmployeeReward.EmployeeFullName),
			new SqlParameter("@DepartmentIDTitle", officialEmployeeReward.DepartmentIDTitle),
			new SqlParameter("@YearTypeIDTitle", officialEmployeeReward.YearTypeIDTitle),
			new SqlParameter("@MonthTypeIDTitle", officialEmployeeReward.MonthTypeIDTitle),
			new SqlParameter("@RoleTypeIDTitle", officialEmployeeReward.RoleTypeIDTitle),
			new SqlParameter("@TotalReward", officialEmployeeReward.TotalReward),
			new SqlParameter("@Reward_", officialEmployeeReward.Reward_),
			new SqlParameter("@RoleTypeIDFactor", officialEmployeeReward.RoleTypeIDFactor),
			new SqlParameter("@BossFactor", officialEmployeeReward.BossFactor),
			new SqlParameter("@Reward", officialEmployeeReward.Reward),
			new SqlParameter("@BossFinalValue", officialEmployeeReward.BossFinalValue),
			new SqlParameter("@AssistantFinalValue", officialEmployeeReward.AssistantFinalValue),
			new SqlParameter("@ManagerFinalValue", officialEmployeeReward.ManagerFinalValue),
			new SqlParameter("@ExtraReward1", officialEmployeeReward.ExtraReward1),
			new SqlParameter("@ExtraReward2", officialEmployeeReward.ExtraReward2),
			new SqlParameter("@ExtraReward3", officialEmployeeReward.ExtraReward3),
			new SqlParameter("@RoleTypeID", officialEmployeeReward.RoleTypeID),
			new SqlParameter("@Parameter1", officialEmployeeReward.Parameter1),
			new SqlParameter("@Parameter2", officialEmployeeReward.Parameter2),
			new SqlParameter("@Parameter3", officialEmployeeReward.Parameter3),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("OfficialEmployeeReward_SearchLike", CommandType.StoredProcedure, parametersOfficialEmployeeReward))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					OfficialEmployeeReward tmpOfficialEmployeeReward = new OfficialEmployeeReward();
					tmpOfficialEmployeeReward.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
					tmpOfficialEmployeeReward.YearTypeID = (row["YearTypeID"] != DBNull.Value) ? Convert.ToInt32(row["YearTypeID"]) : 0 ;
					tmpOfficialEmployeeReward.MonthTypeID = (row["MonthTypeID"] != DBNull.Value) ? Convert.ToInt32(row["MonthTypeID"]) : 0 ;
					tmpOfficialEmployeeReward.EmployeeFullName = row["EmployeeFullName"].ToString();
					tmpOfficialEmployeeReward.DepartmentIDTitle = row["DepartmentIDTitle"].ToString();
					tmpOfficialEmployeeReward.YearTypeIDTitle = row["YearTypeIDTitle"].ToString();
					tmpOfficialEmployeeReward.MonthTypeIDTitle = row["MonthTypeIDTitle"].ToString();
					tmpOfficialEmployeeReward.RoleTypeIDTitle = row["RoleTypeIDTitle"].ToString();
					tmpOfficialEmployeeReward.TotalReward = (row["TotalReward"] != DBNull.Value) ? Convert.ToInt64(row["TotalReward"]) : 0 ;
					tmpOfficialEmployeeReward.Reward_ = (row["Reward_"] != DBNull.Value) ? Convert.ToInt64(row["Reward_"]) : 0 ;
					tmpOfficialEmployeeReward.RoleTypeIDFactor = (row["RoleTypeIDFactor"] != DBNull.Value) ? Convert.ToDecimal(row["RoleTypeIDFactor"]) : 0 ;
					tmpOfficialEmployeeReward.BossFactor = (row["BossFactor"] != DBNull.Value) ? Convert.ToDecimal(row["BossFactor"]) : 0 ;
					tmpOfficialEmployeeReward.Reward = (row["Reward"] != DBNull.Value) ? Convert.ToInt64(row["Reward"]) : 0 ;
					tmpOfficialEmployeeReward.BossFinalValue = (row["BossFinalValue"] != DBNull.Value) ? Convert.ToInt64(row["BossFinalValue"]) : 0 ;
					tmpOfficialEmployeeReward.AssistantFinalValue = (row["AssistantFinalValue"] != DBNull.Value) ? Convert.ToInt64(row["AssistantFinalValue"]) : 0 ;
					tmpOfficialEmployeeReward.ManagerFinalValue = (row["ManagerFinalValue"] != DBNull.Value) ? Convert.ToInt64(row["ManagerFinalValue"]) : 0 ;
					tmpOfficialEmployeeReward.ExtraReward1 = (row["ExtraReward1"] != DBNull.Value) ? Convert.ToInt64(row["ExtraReward1"]) : 0 ;
					tmpOfficialEmployeeReward.ExtraReward2 = (row["ExtraReward2"] != DBNull.Value) ? Convert.ToInt64(row["ExtraReward2"]) : 0 ;
					tmpOfficialEmployeeReward.ExtraReward3 = (row["ExtraReward3"] != DBNull.Value) ? Convert.ToInt64(row["ExtraReward3"]) : 0 ;
					tmpOfficialEmployeeReward.RoleTypeID = (row["RoleTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RoleTypeID"]) : 0 ;
					tmpOfficialEmployeeReward.Parameter1 = (row["Parameter1"] != DBNull.Value) ? Convert.ToInt32(row["Parameter1"]) : 0 ;
					tmpOfficialEmployeeReward.Parameter2 = (row["Parameter2"] != DBNull.Value) ? Convert.ToInt32(row["Parameter2"]) : 0 ;
					tmpOfficialEmployeeReward.Parameter3 = (row["Parameter3"] != DBNull.Value) ? Convert.ToInt32(row["Parameter3"]) : 0 ;

					listOfficialEmployeeReward.Add(tmpOfficialEmployeeReward);
				}
			}
		}

		return listOfficialEmployeeReward;
	}

}
}
