using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.Models;

namespace Rewards.DBA
{
public class ContractualEmployeeRewardDBAccess
{


	public Int64 Insert(ContractualEmployeeReward contractualEmployeeReward)
	{
		SqlParameter[] parametersContractualEmployeeReward = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", (contractualEmployeeReward.YearTypeID > 0) ? contractualEmployeeReward.YearTypeID : (object)DBNull.Value),
			new SqlParameter("@MonthTypeID", (contractualEmployeeReward.MonthTypeID > 0) ? contractualEmployeeReward.MonthTypeID : (object)DBNull.Value),
			new SqlParameter("@NationalCode", (contractualEmployeeReward.NationalCode > 0) ? contractualEmployeeReward.NationalCode : (object)DBNull.Value),
			new SqlParameter("@Reward", contractualEmployeeReward.Reward),
			new SqlParameter("@BossFinalValue", contractualEmployeeReward.BossFinalValue),
			new SqlParameter("@AssistantFinalValue", contractualEmployeeReward.AssistantFinalValue),
			new SqlParameter("@ManagerFinalValue", contractualEmployeeReward.ManagerFinalValue),
			new SqlParameter("@ExtraReward1", contractualEmployeeReward.ExtraReward1),
			new SqlParameter("@ExtraReward2", contractualEmployeeReward.ExtraReward2),
			new SqlParameter("@ExtraReward3", contractualEmployeeReward.ExtraReward3)
		};
		return SqlDBHelper.ExecuteScalar("ContractualEmployeeReward_Insert", CommandType.StoredProcedure, parametersContractualEmployeeReward);
	}

	public bool Update(ContractualEmployeeReward contractualEmployeeReward)
	{
		SqlParameter[] parametersContractualEmployeeReward = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", contractualEmployeeReward.YearTypeID),
			new SqlParameter("@MonthTypeID", contractualEmployeeReward.MonthTypeID),
			new SqlParameter("@NationalCode", contractualEmployeeReward.NationalCode),
			new SqlParameter("@Reward", contractualEmployeeReward.Reward),
			new SqlParameter("@BossFinalValue", contractualEmployeeReward.BossFinalValue),
			new SqlParameter("@AssistantFinalValue", contractualEmployeeReward.AssistantFinalValue),
			new SqlParameter("@ManagerFinalValue", contractualEmployeeReward.ManagerFinalValue),
			new SqlParameter("@ExtraReward1", contractualEmployeeReward.ExtraReward1),
			new SqlParameter("@ExtraReward2", contractualEmployeeReward.ExtraReward2),
			new SqlParameter("@ExtraReward3", contractualEmployeeReward.ExtraReward3)
		};
		return SqlDBHelper.ExecuteNonQuery("ContractualEmployeeReward_Update", CommandType.StoredProcedure, parametersContractualEmployeeReward);
	}

	public bool Delete(int yearTypeID , int monthTypeID , Int64 nationalCode)
	{
		SqlParameter[] parametersContractualEmployeeReward = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", yearTypeID),
			new SqlParameter("@MonthTypeID", monthTypeID),
			new SqlParameter("@NationalCode", nationalCode)
		};
		return SqlDBHelper.ExecuteNonQuery("ContractualEmployeeReward_Delete", CommandType.StoredProcedure, parametersContractualEmployeeReward);
	}

	public ContractualEmployeeReward GetDetails(int yearTypeID , int monthTypeID , Int64 nationalCode)
	{
		ContractualEmployeeReward contractualEmployeeReward = new ContractualEmployeeReward();

		SqlParameter[] parametersContractualEmployeeReward = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", yearTypeID),
			new SqlParameter("@MonthTypeID", monthTypeID),
			new SqlParameter("@NationalCode", nationalCode)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ContractualEmployeeReward_GetDetails", CommandType.StoredProcedure, parametersContractualEmployeeReward))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				contractualEmployeeReward.YearTypeID = (row["YearTypeID"] != DBNull.Value) ? Convert.ToInt32(row["YearTypeID"]) : 0 ;
				contractualEmployeeReward.MonthTypeID = (row["MonthTypeID"] != DBNull.Value) ? Convert.ToInt32(row["MonthTypeID"]) : 0 ;
				contractualEmployeeReward.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
				contractualEmployeeReward.TotalReward = (row["TotalReward"] != DBNull.Value) ? Convert.ToInt64(row["TotalReward"]) : 0 ;
				contractualEmployeeReward.Reward_ = (row["Reward_"] != DBNull.Value) ? Convert.ToInt64(row["Reward_"]) : 0 ;
				contractualEmployeeReward.EmployeeFullName = row["EmployeeFullName"].ToString();
				contractualEmployeeReward.DepartmentIDTitle = row["DepartmentIDTitle"].ToString();
				contractualEmployeeReward.YearTypeIDTitle = row["YearTypeIDTitle"].ToString();
				contractualEmployeeReward.MonthTypeIDTitle = row["MonthTypeIDTitle"].ToString();
				contractualEmployeeReward.Reward = (row["Reward"] != DBNull.Value) ? Convert.ToInt64(row["Reward"]) : 0 ;
				contractualEmployeeReward.BossFinalValue = (row["BossFinalValue"] != DBNull.Value) ? Convert.ToInt64(row["BossFinalValue"]) : 0 ;
				contractualEmployeeReward.AssistantFinalValue = (row["AssistantFinalValue"] != DBNull.Value) ? Convert.ToInt64(row["AssistantFinalValue"]) : 0 ;
				contractualEmployeeReward.ManagerFinalValue = (row["ManagerFinalValue"] != DBNull.Value) ? Convert.ToInt64(row["ManagerFinalValue"]) : 0 ;
				contractualEmployeeReward.ExtraReward1 = (row["ExtraReward1"] != DBNull.Value) ? Convert.ToInt64(row["ExtraReward1"]) : 0 ;
				contractualEmployeeReward.ExtraReward2 = (row["ExtraReward2"] != DBNull.Value) ? Convert.ToInt64(row["ExtraReward2"]) : 0 ;
				contractualEmployeeReward.ExtraReward3 = (row["ExtraReward3"] != DBNull.Value) ? Convert.ToInt64(row["ExtraReward3"]) : 0 ;
			}
		}

		return contractualEmployeeReward;
	}

	public List<ContractualEmployeeReward> GetListAll()
	{
		List<ContractualEmployeeReward> listContractualEmployeeReward = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("ContractualEmployeeReward_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listContractualEmployeeReward = new List<ContractualEmployeeReward>();

				foreach (DataRow row in table.Rows)
				{
					ContractualEmployeeReward contractualEmployeeReward = new ContractualEmployeeReward();
					contractualEmployeeReward.YearTypeID = (row["YearTypeID"] != DBNull.Value) ? Convert.ToInt32(row["YearTypeID"]) : 0 ;
					contractualEmployeeReward.MonthTypeID = (row["MonthTypeID"] != DBNull.Value) ? Convert.ToInt32(row["MonthTypeID"]) : 0 ;
					contractualEmployeeReward.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
					contractualEmployeeReward.TotalReward = (row["TotalReward"] != DBNull.Value) ? Convert.ToInt64(row["TotalReward"]) : 0 ;
					contractualEmployeeReward.Reward_ = (row["Reward_"] != DBNull.Value) ? Convert.ToInt64(row["Reward_"]) : 0 ;
					contractualEmployeeReward.EmployeeFullName = row["EmployeeFullName"].ToString();
					contractualEmployeeReward.DepartmentIDTitle = row["DepartmentIDTitle"].ToString();
					contractualEmployeeReward.YearTypeIDTitle = row["YearTypeIDTitle"].ToString();
					contractualEmployeeReward.MonthTypeIDTitle = row["MonthTypeIDTitle"].ToString();
					contractualEmployeeReward.Reward = (row["Reward"] != DBNull.Value) ? Convert.ToInt64(row["Reward"]) : 0 ;
					contractualEmployeeReward.BossFinalValue = (row["BossFinalValue"] != DBNull.Value) ? Convert.ToInt64(row["BossFinalValue"]) : 0 ;
					contractualEmployeeReward.AssistantFinalValue = (row["AssistantFinalValue"] != DBNull.Value) ? Convert.ToInt64(row["AssistantFinalValue"]) : 0 ;
					contractualEmployeeReward.ManagerFinalValue = (row["ManagerFinalValue"] != DBNull.Value) ? Convert.ToInt64(row["ManagerFinalValue"]) : 0 ;
					contractualEmployeeReward.ExtraReward1 = (row["ExtraReward1"] != DBNull.Value) ? Convert.ToInt64(row["ExtraReward1"]) : 0 ;
					contractualEmployeeReward.ExtraReward2 = (row["ExtraReward2"] != DBNull.Value) ? Convert.ToInt64(row["ExtraReward2"]) : 0 ;
					contractualEmployeeReward.ExtraReward3 = (row["ExtraReward3"] != DBNull.Value) ? Convert.ToInt64(row["ExtraReward3"]) : 0 ;
					listContractualEmployeeReward.Add(contractualEmployeeReward);
				}
			}
		}

		return listContractualEmployeeReward;
	}

	public bool Exists(int yearTypeID , int monthTypeID , Int64 nationalCode)
	{
		SqlParameter[] parametersContractualEmployeeReward = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", yearTypeID),
			new SqlParameter("@MonthTypeID", monthTypeID),
			new SqlParameter("@NationalCode", nationalCode)
		};
		return (SqlDBHelper.ExecuteScalar("ContractualEmployeeReward_Exists", CommandType.StoredProcedure, parametersContractualEmployeeReward)>0);
	}

	public bool Exists(ContractualEmployeeReward contractualEmployeeReward)
	{
		SqlParameter[] parametersContractualEmployeeReward = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", contractualEmployeeReward.YearTypeID),
			new SqlParameter("@MonthTypeID", contractualEmployeeReward.MonthTypeID),
			new SqlParameter("@NationalCode", contractualEmployeeReward.NationalCode)
		};
		return (SqlDBHelper.ExecuteScalar("ContractualEmployeeReward_Exists", CommandType.StoredProcedure, parametersContractualEmployeeReward)>0);
	}

	public List<ContractualEmployeeReward> SearchLike(ContractualEmployeeReward contractualEmployeeReward)
	{
		List<ContractualEmployeeReward> listContractualEmployeeReward = new List<ContractualEmployeeReward>();


		SqlParameter[] parametersContractualEmployeeReward = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", contractualEmployeeReward.YearTypeID),
			new SqlParameter("@MonthTypeID", contractualEmployeeReward.MonthTypeID),
			new SqlParameter("@NationalCode", contractualEmployeeReward.NationalCode),
			new SqlParameter("@TotalReward", contractualEmployeeReward.TotalReward),
			new SqlParameter("@Reward_", contractualEmployeeReward.Reward_),
			new SqlParameter("@EmployeeFullName", contractualEmployeeReward.EmployeeFullName),
			new SqlParameter("@DepartmentIDTitle", contractualEmployeeReward.DepartmentIDTitle),
			new SqlParameter("@YearTypeIDTitle", contractualEmployeeReward.YearTypeIDTitle),
			new SqlParameter("@MonthTypeIDTitle", contractualEmployeeReward.MonthTypeIDTitle),
			new SqlParameter("@Reward", contractualEmployeeReward.Reward),
			new SqlParameter("@BossFinalValue", contractualEmployeeReward.BossFinalValue),
			new SqlParameter("@AssistantFinalValue", contractualEmployeeReward.AssistantFinalValue),
			new SqlParameter("@ManagerFinalValue", contractualEmployeeReward.ManagerFinalValue),
			new SqlParameter("@ExtraReward1", contractualEmployeeReward.ExtraReward1),
			new SqlParameter("@ExtraReward2", contractualEmployeeReward.ExtraReward2),
			new SqlParameter("@ExtraReward3", contractualEmployeeReward.ExtraReward3),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ContractualEmployeeReward_SearchLike", CommandType.StoredProcedure, parametersContractualEmployeeReward))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					ContractualEmployeeReward tmpContractualEmployeeReward = new ContractualEmployeeReward();
					tmpContractualEmployeeReward.YearTypeID = (row["YearTypeID"] != DBNull.Value) ? Convert.ToInt32(row["YearTypeID"]) : 0 ;
					tmpContractualEmployeeReward.MonthTypeID = (row["MonthTypeID"] != DBNull.Value) ? Convert.ToInt32(row["MonthTypeID"]) : 0 ;
					tmpContractualEmployeeReward.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
					tmpContractualEmployeeReward.TotalReward = (row["TotalReward"] != DBNull.Value) ? Convert.ToInt64(row["TotalReward"]) : 0 ;
					tmpContractualEmployeeReward.Reward_ = (row["Reward_"] != DBNull.Value) ? Convert.ToInt64(row["Reward_"]) : 0 ;
					tmpContractualEmployeeReward.EmployeeFullName = row["EmployeeFullName"].ToString();
					tmpContractualEmployeeReward.DepartmentIDTitle = row["DepartmentIDTitle"].ToString();
					tmpContractualEmployeeReward.YearTypeIDTitle = row["YearTypeIDTitle"].ToString();
					tmpContractualEmployeeReward.MonthTypeIDTitle = row["MonthTypeIDTitle"].ToString();
					tmpContractualEmployeeReward.Reward = (row["Reward"] != DBNull.Value) ? Convert.ToInt64(row["Reward"]) : 0 ;
					tmpContractualEmployeeReward.BossFinalValue = (row["BossFinalValue"] != DBNull.Value) ? Convert.ToInt64(row["BossFinalValue"]) : 0 ;
					tmpContractualEmployeeReward.AssistantFinalValue = (row["AssistantFinalValue"] != DBNull.Value) ? Convert.ToInt64(row["AssistantFinalValue"]) : 0 ;
					tmpContractualEmployeeReward.ManagerFinalValue = (row["ManagerFinalValue"] != DBNull.Value) ? Convert.ToInt64(row["ManagerFinalValue"]) : 0 ;
					tmpContractualEmployeeReward.ExtraReward1 = (row["ExtraReward1"] != DBNull.Value) ? Convert.ToInt64(row["ExtraReward1"]) : 0 ;
					tmpContractualEmployeeReward.ExtraReward2 = (row["ExtraReward2"] != DBNull.Value) ? Convert.ToInt64(row["ExtraReward2"]) : 0 ;
					tmpContractualEmployeeReward.ExtraReward3 = (row["ExtraReward3"] != DBNull.Value) ? Convert.ToInt64(row["ExtraReward3"]) : 0 ;

					listContractualEmployeeReward.Add(tmpContractualEmployeeReward);
				}
			}
		}

		return listContractualEmployeeReward;
	}

}
}
