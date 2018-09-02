using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.Models;

namespace Rewards.DBA
{
public class YearTypeDBAccess
{

	BaseMonthlyInformationDBAccess baseMonthlyInformationDBAccess = new BaseMonthlyInformationDBAccess();
	ContractualEmployeeRewardDBAccess contractualEmployeeRewardDBAccess = new ContractualEmployeeRewardDBAccess();
	DepartmentMonthlyInformationDBAccess departmentMonthlyInformationDBAccess = new DepartmentMonthlyInformationDBAccess();
	OfficialEmployeeRewardDBAccess officialEmployeeRewardDBAccess = new OfficialEmployeeRewardDBAccess();

	public List<BaseMonthlyInformation> GetListBaseMonthlyInformation(int yearTypeID)
	{
		List<BaseMonthlyInformation> listBaseMonthlyInformation = new List<BaseMonthlyInformation>() { };
		SqlParameter[] parametersYearType = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", yearTypeID)
		};

		//Lets get the list of BaseMonthlyInformation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("BaseMonthlyInformation_GetList_UseInYearType", CommandType.StoredProcedure, parametersYearType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of baseMonthlyInformation
				listBaseMonthlyInformation = new List<BaseMonthlyInformation>();

				//Now lets populate the BaseMonthlyInformation details into the list of baseMonthlyInformations
				foreach (DataRow row in table.Rows)
				{
					BaseMonthlyInformation baseMonthlyInformation = ConvertRowToBaseMonthlyInformation(row);
					listBaseMonthlyInformation.Add(baseMonthlyInformation);
				}
			}
		}

		return listBaseMonthlyInformation;
	}

	private BaseMonthlyInformation ConvertRowToBaseMonthlyInformation(DataRow row)
	{
		BaseMonthlyInformation baseMonthlyInformation = new BaseMonthlyInformation();
		baseMonthlyInformation.YearTypeID = (row["YearTypeID"] != DBNull.Value) ? Convert.ToInt32(row["YearTypeID"]) : 0 ;
		baseMonthlyInformation.MonthTypeID = (row["MonthTypeID"] != DBNull.Value) ? Convert.ToInt32(row["MonthTypeID"]) : 0 ;
		baseMonthlyInformation.MainOfficeTypeID = (row["MainOfficeTypeID"] != DBNull.Value) ? Convert.ToInt32(row["MainOfficeTypeID"]) : 0 ;
		baseMonthlyInformation.ValueToScore = (row["ValueToScore"] != DBNull.Value) ? Convert.ToDecimal(row["ValueToScore"]) : 0 ;
		baseMonthlyInformation.TotalOperationalReward = (row["TotalOperationalReward"] != DBNull.Value) ? Convert.ToInt64(row["TotalOperationalReward"]) : 0 ;
		baseMonthlyInformation.TotalOrganizationalReward = (row["TotalOrganizationalReward"] != DBNull.Value) ? Convert.ToInt64(row["TotalOrganizationalReward"]) : 0 ;
		baseMonthlyInformation.ContractualDividableReward = (row["ContractualDividableReward"] != DBNull.Value) ? Convert.ToInt64(row["ContractualDividableReward"]) : 0 ;
		baseMonthlyInformation.ContractualBossReward = (row["ContractualBossReward"] != DBNull.Value) ? Convert.ToInt64(row["ContractualBossReward"]) : 0 ;
		baseMonthlyInformation.ContractualDevotedReward = (row["ContractualDevotedReward"] != DBNull.Value) ? Convert.ToInt64(row["ContractualDevotedReward"]) : 0 ;
		baseMonthlyInformation.ContractualRemainingReward = (row["ContractualRemainingReward"] != DBNull.Value) ? Convert.ToInt64(row["ContractualRemainingReward"]) : 0 ;
		baseMonthlyInformation.DividableReward = (row["DividableReward"] != DBNull.Value) ? Convert.ToInt64(row["DividableReward"]) : 0 ;
		baseMonthlyInformation.BossReward = (row["BossReward"] != DBNull.Value) ? Convert.ToInt64(row["BossReward"]) : 0 ;
		baseMonthlyInformation.DevotedReward = (row["DevotedReward"] != DBNull.Value) ? Convert.ToInt64(row["DevotedReward"]) : 0 ;
		baseMonthlyInformation.RemainingReward = (row["RemainingReward"] != DBNull.Value) ? Convert.ToInt64(row["RemainingReward"]) : 0 ;
		baseMonthlyInformation.YearTypeIDTitle = row["YearTypeIDTitle"].ToString();
		baseMonthlyInformation.MonthTypeIDTitle = row["MonthTypeIDTitle"].ToString();
		baseMonthlyInformation.ContractualReward = (row["ContractualReward"] != DBNull.Value) ? Convert.ToInt64(row["ContractualReward"]) : 0 ;
		baseMonthlyInformation.ContractualConstantReward = (row["ContractualConstantReward"] != DBNull.Value) ? Convert.ToInt64(row["ContractualConstantReward"]) : 0 ;
		baseMonthlyInformation.ExtraReward = (row["ExtraReward"] != DBNull.Value) ? Convert.ToInt64(row["ExtraReward"]) : 0 ;
		baseMonthlyInformation.Factor5 = (row["Factor5"] != DBNull.Value) ? Convert.ToDecimal(row["Factor5"]) : 0 ;
		baseMonthlyInformation.Factor6 = (row["Factor6"] != DBNull.Value) ? Convert.ToDecimal(row["Factor6"]) : 0 ;
		baseMonthlyInformation.Factor7 = (row["Factor7"] != DBNull.Value) ? Convert.ToDecimal(row["Factor7"]) : 0 ;
		baseMonthlyInformation.Factor8 = (row["Factor8"] != DBNull.Value) ? Convert.ToDecimal(row["Factor8"]) : 0 ;
		baseMonthlyInformation.Factor9 = (row["Factor9"] != DBNull.Value) ? Convert.ToDecimal(row["Factor9"]) : 0 ;
		baseMonthlyInformation.Factor10 = (row["Factor10"] != DBNull.Value) ? Convert.ToDecimal(row["Factor10"]) : 0 ;
		baseMonthlyInformation.OfficialReward = (row["OfficialReward"] != DBNull.Value) ? Convert.ToInt64(row["OfficialReward"]) : 0 ;
		baseMonthlyInformation.IsFanalized = (row["IsFanalized"] != DBNull.Value) ? Convert.ToBoolean((row["IsFanalized"].ToString() == "1" || row["IsFanalized"].ToString().ToLower() == "true" ) ? true : false) : false ;
		baseMonthlyInformation.IsFainalizedEmployeesInformation = (row["IsFainalizedEmployeesInformation"] != DBNull.Value) ? Convert.ToBoolean((row["IsFainalizedEmployeesInformation"].ToString() == "1" || row["IsFainalizedEmployeesInformation"].ToString().ToLower() == "true" ) ? true : false) : false ;
		baseMonthlyInformation.IsFainalizedRewardCalculation = (row["IsFainalizedRewardCalculation"] != DBNull.Value) ? Convert.ToBoolean((row["IsFainalizedRewardCalculation"].ToString() == "1" || row["IsFainalizedRewardCalculation"].ToString().ToLower() == "true" ) ? true : false) : false ;
		baseMonthlyInformation.BossFactor = (row["BossFactor"] != DBNull.Value) ? Convert.ToDecimal(row["BossFactor"]) : 0 ;
		baseMonthlyInformation.OperationalFactor = (row["OperationalFactor"] != DBNull.Value) ? Convert.ToDecimal(row["OperationalFactor"]) : 0 ;
		baseMonthlyInformation.Factor1 = (row["Factor1"] != DBNull.Value) ? Convert.ToDecimal(row["Factor1"]) : 0 ;
		baseMonthlyInformation.Factor2 = (row["Factor2"] != DBNull.Value) ? Convert.ToDecimal(row["Factor2"]) : 0 ;
		baseMonthlyInformation.Factor3 = (row["Factor3"] != DBNull.Value) ? Convert.ToDecimal(row["Factor3"]) : 0 ;
		baseMonthlyInformation.Factor4 = (row["Factor4"] != DBNull.Value) ? Convert.ToDecimal(row["Factor4"]) : 0 ;
		return baseMonthlyInformation;
	}
	public List<ContractualEmployeeReward> GetListContractualEmployeeReward(int yearTypeID)
	{
		List<ContractualEmployeeReward> listContractualEmployeeReward = new List<ContractualEmployeeReward>() { };
		SqlParameter[] parametersYearType = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", yearTypeID)
		};

		//Lets get the list of ContractualEmployeeReward records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ContractualEmployeeReward_GetList_UseInYearType", CommandType.StoredProcedure, parametersYearType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of contractualEmployeeReward
				listContractualEmployeeReward = new List<ContractualEmployeeReward>();

				//Now lets populate the ContractualEmployeeReward details into the list of contractualEmployeeRewards
				foreach (DataRow row in table.Rows)
				{
					ContractualEmployeeReward contractualEmployeeReward = ConvertRowToContractualEmployeeReward(row);
					listContractualEmployeeReward.Add(contractualEmployeeReward);
				}
			}
		}

		return listContractualEmployeeReward;
	}

	private ContractualEmployeeReward ConvertRowToContractualEmployeeReward(DataRow row)
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
		return contractualEmployeeReward;
	}
	public List<DepartmentMonthlyInformation> GetListDepartmentMonthlyInformation(int yearTypeID)
	{
		List<DepartmentMonthlyInformation> listDepartmentMonthlyInformation = new List<DepartmentMonthlyInformation>() { };
		SqlParameter[] parametersYearType = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", yearTypeID)
		};

		//Lets get the list of DepartmentMonthlyInformation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("DepartmentMonthlyInformation_GetList_UseInYearType", CommandType.StoredProcedure, parametersYearType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of departmentMonthlyInformation
				listDepartmentMonthlyInformation = new List<DepartmentMonthlyInformation>();

				//Now lets populate the DepartmentMonthlyInformation details into the list of departmentMonthlyInformations
				foreach (DataRow row in table.Rows)
				{
					DepartmentMonthlyInformation departmentMonthlyInformation = ConvertRowToDepartmentMonthlyInformation(row);
					listDepartmentMonthlyInformation.Add(departmentMonthlyInformation);
				}
			}
		}

		return listDepartmentMonthlyInformation;
	}

	private DepartmentMonthlyInformation ConvertRowToDepartmentMonthlyInformation(DataRow row)
	{
		DepartmentMonthlyInformation departmentMonthlyInformation = new DepartmentMonthlyInformation();
		departmentMonthlyInformation.YearTypeID = (row["YearTypeID"] != DBNull.Value) ? Convert.ToInt32(row["YearTypeID"]) : 0 ;
		departmentMonthlyInformation.MonthTypeID = (row["MonthTypeID"] != DBNull.Value) ? Convert.ToInt32(row["MonthTypeID"]) : 0 ;
		departmentMonthlyInformation.DepartmentID = (row["DepartmentID"] != DBNull.Value) ? Convert.ToInt32(row["DepartmentID"]) : 0 ;
		departmentMonthlyInformation.AdjutancyTypeID = (row["AdjutancyTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AdjutancyTypeID"]) : 0 ;
		departmentMonthlyInformation.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		departmentMonthlyInformation.OperationalReward_Average = (row["OperationalReward_Average"] != DBNull.Value) ? Convert.ToSingle(row["OperationalReward_Average"]) : 0 ;
		departmentMonthlyInformation.OperationalRewardAverage = (row["OperationalRewardAverage"] != DBNull.Value) ? Convert.ToSingle(row["OperationalRewardAverage"]) : 0 ;
		departmentMonthlyInformation.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToDecimal(row["Value2"]) : 0 ;
		departmentMonthlyInformation.OperationalScore = (row["OperationalScore"] != DBNull.Value) ? Convert.ToDecimal(row["OperationalScore"]) : 0 ;
		departmentMonthlyInformation.TotalParameter1 = (row["TotalParameter1"] != DBNull.Value) ? Convert.ToDecimal(row["TotalParameter1"]) : 0 ;
		departmentMonthlyInformation.TotalParameter2 = (row["TotalParameter2"] != DBNull.Value) ? Convert.ToDecimal(row["TotalParameter2"]) : 0 ;
		departmentMonthlyInformation.TotalParameter3 = (row["TotalParameter3"] != DBNull.Value) ? Convert.ToDecimal(row["TotalParameter3"]) : 0 ;
		departmentMonthlyInformation.TotalBossFactor = (row["TotalBossFactor"] != DBNull.Value) ? Convert.ToDecimal(row["TotalBossFactor"]) : 0 ;
		departmentMonthlyInformation.TotalReward_ = (row["TotalReward_"] != DBNull.Value) ? Convert.ToInt64(row["TotalReward_"]) : 0 ;
		departmentMonthlyInformation.OrganizationalReward_ = (row["OrganizationalReward_"] != DBNull.Value) ? Convert.ToInt64(row["OrganizationalReward_"]) : 0 ;
		departmentMonthlyInformation.OperationalReward_ = (row["OperationalReward_"] != DBNull.Value) ? Convert.ToInt64(row["OperationalReward_"]) : 0 ;
		departmentMonthlyInformation.TotalReward_Average = (row["TotalReward_Average"] != DBNull.Value) ? Convert.ToInt64(row["TotalReward_Average"]) : 0 ;
		departmentMonthlyInformation.YearTypeIDTitle = row["YearTypeIDTitle"].ToString();
		departmentMonthlyInformation.MonthTypeIDTitle = row["MonthTypeIDTitle"].ToString();
		departmentMonthlyInformation.DepartmentIDTitle = row["DepartmentIDTitle"].ToString();
		departmentMonthlyInformation.RewardPerEmployee = (row["RewardPerEmployee"] != DBNull.Value) ? Convert.ToInt64(row["RewardPerEmployee"]) : 0 ;
		departmentMonthlyInformation.OperationalRewardCalculated = (row["OperationalRewardCalculated"] != DBNull.Value) ? Convert.ToInt64(row["OperationalRewardCalculated"]) : 0 ;
		departmentMonthlyInformation.OperationalReward = (row["OperationalReward"] != DBNull.Value) ? Convert.ToInt64(row["OperationalReward"]) : 0 ;
		departmentMonthlyInformation.OrganizationalRewardCalculated = (row["OrganizationalRewardCalculated"] != DBNull.Value) ? Convert.ToInt64(row["OrganizationalRewardCalculated"]) : 0 ;
		departmentMonthlyInformation.OrganizationalReward = (row["OrganizationalReward"] != DBNull.Value) ? Convert.ToInt64(row["OrganizationalReward"]) : 0 ;
		departmentMonthlyInformation.MonthlyProceed = (row["MonthlyProceed"] != DBNull.Value) ? Convert.ToInt64(row["MonthlyProceed"]) : 0 ;
		departmentMonthlyInformation.DesiredMonthlyProceed = (row["DesiredMonthlyProceed"] != DBNull.Value) ? Convert.ToInt64(row["DesiredMonthlyProceed"]) : 0 ;
		departmentMonthlyInformation.LastYearProceed = (row["LastYearProceed"] != DBNull.Value) ? Convert.ToInt64(row["LastYearProceed"]) : 0 ;
		departmentMonthlyInformation.StatisticsFinalalization = (row["StatisticsFinalalization"] != DBNull.Value) ? Convert.ToBoolean((row["StatisticsFinalalization"].ToString() == "1" || row["StatisticsFinalalization"].ToString().ToLower() == "true" ) ? true : false) : false ;
		departmentMonthlyInformation.AssistantRewardsFinalization = (row["AssistantRewardsFinalization"] != DBNull.Value) ? Convert.ToBoolean((row["AssistantRewardsFinalization"].ToString() == "1" || row["AssistantRewardsFinalization"].ToString().ToLower() == "true" ) ? true : false) : false ;
		departmentMonthlyInformation.ManagerRewardsFinalization = (row["ManagerRewardsFinalization"] != DBNull.Value) ? Convert.ToBoolean((row["ManagerRewardsFinalization"].ToString() == "1" || row["ManagerRewardsFinalization"].ToString().ToLower() == "true" ) ? true : false) : false ;
		departmentMonthlyInformation.IsOfficialRewardsFinalizedBoss = (row["IsOfficialRewardsFinalizedBoss"] != DBNull.Value) ? Convert.ToBoolean((row["IsOfficialRewardsFinalizedBoss"].ToString() == "1" || row["IsOfficialRewardsFinalizedBoss"].ToString().ToLower() == "true" ) ? true : false) : false ;
		departmentMonthlyInformation.IsOfficialRewardsFinalizedAssistant = (row["IsOfficialRewardsFinalizedAssistant"] != DBNull.Value) ? Convert.ToBoolean((row["IsOfficialRewardsFinalizedAssistant"].ToString() == "1" || row["IsOfficialRewardsFinalizedAssistant"].ToString().ToLower() == "true" ) ? true : false) : false ;
		departmentMonthlyInformation.IsOfficialRewardsFinalizedManager = (row["IsOfficialRewardsFinalizedManager"] != DBNull.Value) ? Convert.ToBoolean((row["IsOfficialRewardsFinalizedManager"].ToString() == "1" || row["IsOfficialRewardsFinalizedManager"].ToString().ToLower() == "true" ) ? true : false) : false ;
		departmentMonthlyInformation.ContractualRewardsFinalization = (row["ContractualRewardsFinalization"] != DBNull.Value) ? Convert.ToBoolean((row["ContractualRewardsFinalization"].ToString() == "1" || row["ContractualRewardsFinalization"].ToString().ToLower() == "true" ) ? true : false) : false ;
		departmentMonthlyInformation.IsContractualRewardsFinalizedBoss = (row["IsContractualRewardsFinalizedBoss"] != DBNull.Value) ? Convert.ToBoolean((row["IsContractualRewardsFinalizedBoss"].ToString() == "1" || row["IsContractualRewardsFinalizedBoss"].ToString().ToLower() == "true" ) ? true : false) : false ;
		departmentMonthlyInformation.IsContractualRewardsFinalizedAssistant = (row["IsContractualRewardsFinalizedAssistant"] != DBNull.Value) ? Convert.ToBoolean((row["IsContractualRewardsFinalizedAssistant"].ToString() == "1" || row["IsContractualRewardsFinalizedAssistant"].ToString().ToLower() == "true" ) ? true : false) : false ;
		departmentMonthlyInformation.IsContractualRewardsFinalizedManager = (row["IsContractualRewardsFinalizedManager"] != DBNull.Value) ? Convert.ToBoolean((row["IsContractualRewardsFinalizedManager"].ToString() == "1" || row["IsContractualRewardsFinalizedManager"].ToString().ToLower() == "true" ) ? true : false) : false ;
		departmentMonthlyInformation.DossierNumber = (row["DossierNumber"] != DBNull.Value) ? Convert.ToInt32(row["DossierNumber"]) : 0 ;
		departmentMonthlyInformation.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToInt32(row["Value3"]) : 0 ;
		departmentMonthlyInformation.Value4 = (row["Value4"] != DBNull.Value) ? Convert.ToInt32(row["Value4"]) : 0 ;
		departmentMonthlyInformation.Value5 = (row["Value5"] != DBNull.Value) ? Convert.ToInt32(row["Value5"]) : 0 ;
		departmentMonthlyInformation.Value6 = (row["Value6"] != DBNull.Value) ? Convert.ToInt32(row["Value6"]) : 0 ;
		departmentMonthlyInformation.EmployeeNumber = (row["EmployeeNumber"] != DBNull.Value) ? Convert.ToInt32(row["EmployeeNumber"]) : 0 ;
		departmentMonthlyInformation.ContractualEmployeeNumber = (row["ContractualEmployeeNumber"] != DBNull.Value) ? Convert.ToInt32(row["ContractualEmployeeNumber"]) : 0 ;
		return departmentMonthlyInformation;
	}
	public List<OfficialEmployeeReward> GetListOfficialEmployeeReward(int yearTypeID)
	{
		List<OfficialEmployeeReward> listOfficialEmployeeReward = new List<OfficialEmployeeReward>() { };
		SqlParameter[] parametersYearType = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", yearTypeID)
		};

		//Lets get the list of OfficialEmployeeReward records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("OfficialEmployeeReward_GetList_UseInYearType", CommandType.StoredProcedure, parametersYearType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of officialEmployeeReward
				listOfficialEmployeeReward = new List<OfficialEmployeeReward>();

				//Now lets populate the OfficialEmployeeReward details into the list of officialEmployeeRewards
				foreach (DataRow row in table.Rows)
				{
					OfficialEmployeeReward officialEmployeeReward = ConvertRowToOfficialEmployeeReward(row);
					listOfficialEmployeeReward.Add(officialEmployeeReward);
				}
			}
		}

		return listOfficialEmployeeReward;
	}

	private OfficialEmployeeReward ConvertRowToOfficialEmployeeReward(DataRow row)
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
		return officialEmployeeReward;
	}
	public Int64 Insert(YearType yearType)
	{
		SqlParameter[] parametersYearType = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", yearType.YearTypeID),
			new SqlParameter("@Title", yearType.Title)
		};
		return SqlDBHelper.ExecuteScalar("YearType_Insert", CommandType.StoredProcedure, parametersYearType);
	}

	public bool Update(YearType yearType)
	{
		SqlParameter[] parametersYearType = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", yearType.YearTypeID),
			new SqlParameter("@Title", yearType.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("YearType_Update", CommandType.StoredProcedure, parametersYearType);
	}

	public bool Delete(int yearTypeID)
	{
		SqlParameter[] parametersYearType = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", yearTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("YearType_Delete", CommandType.StoredProcedure, parametersYearType);
	}

	public YearType GetDetails(int yearTypeID)
	{
		YearType yearType = new YearType();

		SqlParameter[] parametersYearType = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", yearTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("YearType_GetDetails", CommandType.StoredProcedure, parametersYearType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				yearType.YearTypeID = (row["YearTypeID"] != DBNull.Value) ? Convert.ToInt32(row["YearTypeID"]) : 0 ;
				yearType.Title = row["Title"].ToString();
			}
		}

		return yearType;
	}

	public List<YearType> GetListAll()
	{
		List<YearType> listYearType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("YearType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listYearType = new List<YearType>();

				foreach (DataRow row in table.Rows)
				{
					YearType yearType = new YearType();
					yearType.YearTypeID = (row["YearTypeID"] != DBNull.Value) ? Convert.ToInt32(row["YearTypeID"]) : 0 ;
					yearType.Title = row["Title"].ToString();
					listYearType.Add(yearType);
				}
			}
		}

		return listYearType;
	}

	public bool Exists(int yearTypeID)
	{
		SqlParameter[] parametersYearType = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", yearTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("YearType_Exists", CommandType.StoredProcedure, parametersYearType)>0);
	}

	public bool Exists(YearType yearType)
	{
		SqlParameter[] parametersYearType = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", yearType.YearTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("YearType_Exists", CommandType.StoredProcedure, parametersYearType)>0);
	}

	public List<YearType> SearchLike(YearType yearType)
	{
		List<YearType> listYearType = new List<YearType>();


		SqlParameter[] parametersYearType = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", yearType.YearTypeID),
			new SqlParameter("@Title", yearType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("YearType_SearchLike", CommandType.StoredProcedure, parametersYearType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					YearType tmpYearType = new YearType();
					tmpYearType.YearTypeID = (row["YearTypeID"] != DBNull.Value) ? Convert.ToInt32(row["YearTypeID"]) : 0 ;
					tmpYearType.Title = row["Title"].ToString();

					listYearType.Add(tmpYearType);
				}
			}
		}

		return listYearType;
	}

}
}
