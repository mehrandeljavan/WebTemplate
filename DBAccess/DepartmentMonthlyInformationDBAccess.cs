using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.Models;

namespace Rewards.DBA
{
public class DepartmentMonthlyInformationDBAccess
{


	public Int64 Insert(DepartmentMonthlyInformation departmentMonthlyInformation)
	{
		SqlParameter[] parametersDepartmentMonthlyInformation = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", (departmentMonthlyInformation.YearTypeID > 0) ? departmentMonthlyInformation.YearTypeID : (object)DBNull.Value),
			new SqlParameter("@MonthTypeID", (departmentMonthlyInformation.MonthTypeID > 0) ? departmentMonthlyInformation.MonthTypeID : (object)DBNull.Value),
			new SqlParameter("@DepartmentID", (departmentMonthlyInformation.DepartmentID > 0) ? departmentMonthlyInformation.DepartmentID : (object)DBNull.Value),
			new SqlParameter("@RewardPerEmployee", (departmentMonthlyInformation.RewardPerEmployee != null) ? departmentMonthlyInformation.RewardPerEmployee : (object)DBNull.Value),
			new SqlParameter("@OperationalRewardCalculated", (departmentMonthlyInformation.OperationalRewardCalculated != null) ? departmentMonthlyInformation.OperationalRewardCalculated : (object)DBNull.Value),
			new SqlParameter("@OperationalReward", (departmentMonthlyInformation.OperationalReward != null) ? departmentMonthlyInformation.OperationalReward : (object)DBNull.Value),
			new SqlParameter("@OrganizationalRewardCalculated", (departmentMonthlyInformation.OrganizationalRewardCalculated != null) ? departmentMonthlyInformation.OrganizationalRewardCalculated : (object)DBNull.Value),
			new SqlParameter("@OrganizationalReward", (departmentMonthlyInformation.OrganizationalReward != null) ? departmentMonthlyInformation.OrganizationalReward : (object)DBNull.Value),
			new SqlParameter("@MonthlyProceed", departmentMonthlyInformation.MonthlyProceed),
			new SqlParameter("@DesiredMonthlyProceed", departmentMonthlyInformation.DesiredMonthlyProceed),
			new SqlParameter("@LastYearProceed", departmentMonthlyInformation.LastYearProceed),
			new SqlParameter("@StatisticsFinalalization", departmentMonthlyInformation.StatisticsFinalalization),
			new SqlParameter("@AssistantRewardsFinalization", departmentMonthlyInformation.AssistantRewardsFinalization),
			new SqlParameter("@ManagerRewardsFinalization", departmentMonthlyInformation.ManagerRewardsFinalization),
			new SqlParameter("@IsOfficialRewardsFinalizedBoss", departmentMonthlyInformation.IsOfficialRewardsFinalizedBoss),
			new SqlParameter("@IsOfficialRewardsFinalizedAssistant", departmentMonthlyInformation.IsOfficialRewardsFinalizedAssistant),
			new SqlParameter("@IsOfficialRewardsFinalizedManager", departmentMonthlyInformation.IsOfficialRewardsFinalizedManager),
			new SqlParameter("@ContractualRewardsFinalization", departmentMonthlyInformation.ContractualRewardsFinalization),
			new SqlParameter("@IsContractualRewardsFinalizedBoss", departmentMonthlyInformation.IsContractualRewardsFinalizedBoss),
			new SqlParameter("@IsContractualRewardsFinalizedAssistant", departmentMonthlyInformation.IsContractualRewardsFinalizedAssistant),
			new SqlParameter("@IsContractualRewardsFinalizedManager", departmentMonthlyInformation.IsContractualRewardsFinalizedManager),
			new SqlParameter("@DossierNumber", departmentMonthlyInformation.DossierNumber),
			new SqlParameter("@Value3", departmentMonthlyInformation.Value3),
			new SqlParameter("@Value4", departmentMonthlyInformation.Value4),
			new SqlParameter("@Value5", departmentMonthlyInformation.Value5),
			new SqlParameter("@Value6", departmentMonthlyInformation.Value6),
			new SqlParameter("@EmployeeNumber", departmentMonthlyInformation.EmployeeNumber),
			new SqlParameter("@ContractualEmployeeNumber", departmentMonthlyInformation.ContractualEmployeeNumber)
		};
		return SqlDBHelper.ExecuteScalar("DepartmentMonthlyInformation_Insert", CommandType.StoredProcedure, parametersDepartmentMonthlyInformation);
	}

	public bool Update(DepartmentMonthlyInformation departmentMonthlyInformation)
	{
		SqlParameter[] parametersDepartmentMonthlyInformation = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", departmentMonthlyInformation.YearTypeID),
			new SqlParameter("@MonthTypeID", departmentMonthlyInformation.MonthTypeID),
			new SqlParameter("@DepartmentID", departmentMonthlyInformation.DepartmentID),
			new SqlParameter("@RewardPerEmployee", (departmentMonthlyInformation.RewardPerEmployee != null) ? departmentMonthlyInformation.RewardPerEmployee : (object)DBNull.Value),
			new SqlParameter("@OperationalRewardCalculated", (departmentMonthlyInformation.OperationalRewardCalculated != null) ? departmentMonthlyInformation.OperationalRewardCalculated : (object)DBNull.Value),
			new SqlParameter("@OperationalReward", (departmentMonthlyInformation.OperationalReward != null) ? departmentMonthlyInformation.OperationalReward : (object)DBNull.Value),
			new SqlParameter("@OrganizationalRewardCalculated", (departmentMonthlyInformation.OrganizationalRewardCalculated != null) ? departmentMonthlyInformation.OrganizationalRewardCalculated : (object)DBNull.Value),
			new SqlParameter("@OrganizationalReward", (departmentMonthlyInformation.OrganizationalReward != null) ? departmentMonthlyInformation.OrganizationalReward : (object)DBNull.Value),
			new SqlParameter("@MonthlyProceed", departmentMonthlyInformation.MonthlyProceed),
			new SqlParameter("@DesiredMonthlyProceed", departmentMonthlyInformation.DesiredMonthlyProceed),
			new SqlParameter("@LastYearProceed", departmentMonthlyInformation.LastYearProceed),
			new SqlParameter("@StatisticsFinalalization", departmentMonthlyInformation.StatisticsFinalalization),
			new SqlParameter("@AssistantRewardsFinalization", departmentMonthlyInformation.AssistantRewardsFinalization),
			new SqlParameter("@ManagerRewardsFinalization", departmentMonthlyInformation.ManagerRewardsFinalization),
			new SqlParameter("@IsOfficialRewardsFinalizedBoss", departmentMonthlyInformation.IsOfficialRewardsFinalizedBoss),
			new SqlParameter("@IsOfficialRewardsFinalizedAssistant", departmentMonthlyInformation.IsOfficialRewardsFinalizedAssistant),
			new SqlParameter("@IsOfficialRewardsFinalizedManager", departmentMonthlyInformation.IsOfficialRewardsFinalizedManager),
			new SqlParameter("@ContractualRewardsFinalization", departmentMonthlyInformation.ContractualRewardsFinalization),
			new SqlParameter("@IsContractualRewardsFinalizedBoss", departmentMonthlyInformation.IsContractualRewardsFinalizedBoss),
			new SqlParameter("@IsContractualRewardsFinalizedAssistant", departmentMonthlyInformation.IsContractualRewardsFinalizedAssistant),
			new SqlParameter("@IsContractualRewardsFinalizedManager", departmentMonthlyInformation.IsContractualRewardsFinalizedManager),
			new SqlParameter("@DossierNumber", departmentMonthlyInformation.DossierNumber),
			new SqlParameter("@Value3", departmentMonthlyInformation.Value3),
			new SqlParameter("@Value4", departmentMonthlyInformation.Value4),
			new SqlParameter("@Value5", departmentMonthlyInformation.Value5),
			new SqlParameter("@Value6", departmentMonthlyInformation.Value6),
			new SqlParameter("@EmployeeNumber", departmentMonthlyInformation.EmployeeNumber),
			new SqlParameter("@ContractualEmployeeNumber", departmentMonthlyInformation.ContractualEmployeeNumber)
		};
		return SqlDBHelper.ExecuteNonQuery("DepartmentMonthlyInformation_Update", CommandType.StoredProcedure, parametersDepartmentMonthlyInformation);
	}

	public bool Delete(int yearTypeID , int monthTypeID , int departmentID)
	{
		SqlParameter[] parametersDepartmentMonthlyInformation = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", yearTypeID),
			new SqlParameter("@MonthTypeID", monthTypeID),
			new SqlParameter("@DepartmentID", departmentID)
		};
		return SqlDBHelper.ExecuteNonQuery("DepartmentMonthlyInformation_Delete", CommandType.StoredProcedure, parametersDepartmentMonthlyInformation);
	}

	public bool Delete(int yearTypeID , int monthTypeID)
	{
		SqlParameter[] parametersDepartmentMonthlyInformation = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", yearTypeID),
			new SqlParameter("@MonthTypeID", monthTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("DepartmentMonthlyInformation_DeleteBy_YearTypeIDMonthTypeID", CommandType.StoredProcedure, parametersDepartmentMonthlyInformation);

	}

	public DepartmentMonthlyInformation GetDetails(int yearTypeID , int monthTypeID , int departmentID)
	{
		DepartmentMonthlyInformation departmentMonthlyInformation = new DepartmentMonthlyInformation();

		SqlParameter[] parametersDepartmentMonthlyInformation = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", yearTypeID),
			new SqlParameter("@MonthTypeID", monthTypeID),
			new SqlParameter("@DepartmentID", departmentID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("DepartmentMonthlyInformation_GetDetails", CommandType.StoredProcedure, parametersDepartmentMonthlyInformation))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

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
			}
		}

		return departmentMonthlyInformation;
	}

	public DepartmentMonthlyInformation GetDetails(int yearTypeID , int monthTypeID)
	{
		DepartmentMonthlyInformation departmentMonthlyInformation = new DepartmentMonthlyInformation();

		SqlParameter[] parametersDepartmentMonthlyInformation = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", yearTypeID),
			new SqlParameter("@MonthTypeID", monthTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("DepartmentMonthlyInformation_GetDetailsBy_YearTypeIDMonthTypeID", CommandType.StoredProcedure, parametersDepartmentMonthlyInformation))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

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
			}
		}

		return departmentMonthlyInformation;
	}

	public List<DepartmentMonthlyInformation> GetListAll()
	{
		List<DepartmentMonthlyInformation> listDepartmentMonthlyInformation = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("DepartmentMonthlyInformation_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listDepartmentMonthlyInformation = new List<DepartmentMonthlyInformation>();

				foreach (DataRow row in table.Rows)
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
					listDepartmentMonthlyInformation.Add(departmentMonthlyInformation);
				}
			}
		}

		return listDepartmentMonthlyInformation;
	}

	public bool Exists(int yearTypeID , int monthTypeID , int departmentID)
	{
		SqlParameter[] parametersDepartmentMonthlyInformation = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", yearTypeID),
			new SqlParameter("@MonthTypeID", monthTypeID),
			new SqlParameter("@DepartmentID", departmentID)
		};
		return (SqlDBHelper.ExecuteScalar("DepartmentMonthlyInformation_Exists", CommandType.StoredProcedure, parametersDepartmentMonthlyInformation)>0);
	}

	public bool Exists(DepartmentMonthlyInformation departmentMonthlyInformation)
	{
		SqlParameter[] parametersDepartmentMonthlyInformation = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", departmentMonthlyInformation.YearTypeID),
			new SqlParameter("@MonthTypeID", departmentMonthlyInformation.MonthTypeID),
			new SqlParameter("@DepartmentID", departmentMonthlyInformation.DepartmentID)
		};
		return (SqlDBHelper.ExecuteScalar("DepartmentMonthlyInformation_Exists", CommandType.StoredProcedure, parametersDepartmentMonthlyInformation)>0);
	}

	public List<DepartmentMonthlyInformation> GetListByDepartmentMonthlyInformationYearTypeIDMonthTypeID(int yearTypeID,int monthTypeID)
	{
		List<DepartmentMonthlyInformation> listDepartmentMonthlyInformation = new List<DepartmentMonthlyInformation>();

		//Lets get the list of all DepartmentMonthlyInformation records from database using YearTypeID MonthTypeID
		SqlParameter[] parametersDepartmentMonthlyInformation = new SqlParameter[]
		{
			new SqlParameter("@yearTypeID", yearTypeID),
			new SqlParameter("@monthTypeID", monthTypeID)
		};
		//Lets get the list of DepartmentMonthlyInformation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("DepartmentMonthlyInformation_GetListByYearTypeIDMonthTypeID", CommandType.StoredProcedure, parametersDepartmentMonthlyInformation))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of departmentMonthlyInformation
				listDepartmentMonthlyInformation = new List<DepartmentMonthlyInformation>();

				//Now lets populate the departmentMonthlyInformation details into the list of departmentMonthlyInformations
				foreach (DataRow row in table.Rows)
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
					listDepartmentMonthlyInformation.Add(departmentMonthlyInformation);
				}
			}
		}

		return listDepartmentMonthlyInformation;
	}

	public List<DepartmentMonthlyInformation> SearchLike(DepartmentMonthlyInformation departmentMonthlyInformation)
	{
		List<DepartmentMonthlyInformation> listDepartmentMonthlyInformation = new List<DepartmentMonthlyInformation>();


		SqlParameter[] parametersDepartmentMonthlyInformation = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", departmentMonthlyInformation.YearTypeID),
			new SqlParameter("@MonthTypeID", departmentMonthlyInformation.MonthTypeID),
			new SqlParameter("@DepartmentID", departmentMonthlyInformation.DepartmentID),
			new SqlParameter("@AdjutancyTypeID", departmentMonthlyInformation.AdjutancyTypeID),
			new SqlParameter("@Value1", departmentMonthlyInformation.Value1),
			new SqlParameter("@OperationalReward_Average", departmentMonthlyInformation.OperationalReward_Average),
			new SqlParameter("@OperationalRewardAverage", departmentMonthlyInformation.OperationalRewardAverage),
			new SqlParameter("@Value2", departmentMonthlyInformation.Value2),
			new SqlParameter("@OperationalScore", departmentMonthlyInformation.OperationalScore),
			new SqlParameter("@TotalParameter1", departmentMonthlyInformation.TotalParameter1),
			new SqlParameter("@TotalParameter2", departmentMonthlyInformation.TotalParameter2),
			new SqlParameter("@TotalParameter3", departmentMonthlyInformation.TotalParameter3),
			new SqlParameter("@TotalBossFactor", departmentMonthlyInformation.TotalBossFactor),
			new SqlParameter("@TotalReward_", departmentMonthlyInformation.TotalReward_),
			new SqlParameter("@OrganizationalReward_", departmentMonthlyInformation.OrganizationalReward_),
			new SqlParameter("@OperationalReward_", departmentMonthlyInformation.OperationalReward_),
			new SqlParameter("@TotalReward_Average", departmentMonthlyInformation.TotalReward_Average),
			new SqlParameter("@YearTypeIDTitle", departmentMonthlyInformation.YearTypeIDTitle),
			new SqlParameter("@MonthTypeIDTitle", departmentMonthlyInformation.MonthTypeIDTitle),
			new SqlParameter("@DepartmentIDTitle", departmentMonthlyInformation.DepartmentIDTitle),
			new SqlParameter("@RewardPerEmployee", departmentMonthlyInformation.RewardPerEmployee),
			new SqlParameter("@OperationalRewardCalculated", departmentMonthlyInformation.OperationalRewardCalculated),
			new SqlParameter("@OperationalReward", departmentMonthlyInformation.OperationalReward),
			new SqlParameter("@OrganizationalRewardCalculated", departmentMonthlyInformation.OrganizationalRewardCalculated),
			new SqlParameter("@OrganizationalReward", departmentMonthlyInformation.OrganizationalReward),
			new SqlParameter("@MonthlyProceed", departmentMonthlyInformation.MonthlyProceed),
			new SqlParameter("@DesiredMonthlyProceed", departmentMonthlyInformation.DesiredMonthlyProceed),
			new SqlParameter("@LastYearProceed", departmentMonthlyInformation.LastYearProceed),
			new SqlParameter("@StatisticsFinalalization", departmentMonthlyInformation.StatisticsFinalalization),
			new SqlParameter("@AssistantRewardsFinalization", departmentMonthlyInformation.AssistantRewardsFinalization),
			new SqlParameter("@ManagerRewardsFinalization", departmentMonthlyInformation.ManagerRewardsFinalization),
			new SqlParameter("@IsOfficialRewardsFinalizedBoss", departmentMonthlyInformation.IsOfficialRewardsFinalizedBoss),
			new SqlParameter("@IsOfficialRewardsFinalizedAssistant", departmentMonthlyInformation.IsOfficialRewardsFinalizedAssistant),
			new SqlParameter("@IsOfficialRewardsFinalizedManager", departmentMonthlyInformation.IsOfficialRewardsFinalizedManager),
			new SqlParameter("@ContractualRewardsFinalization", departmentMonthlyInformation.ContractualRewardsFinalization),
			new SqlParameter("@IsContractualRewardsFinalizedBoss", departmentMonthlyInformation.IsContractualRewardsFinalizedBoss),
			new SqlParameter("@IsContractualRewardsFinalizedAssistant", departmentMonthlyInformation.IsContractualRewardsFinalizedAssistant),
			new SqlParameter("@IsContractualRewardsFinalizedManager", departmentMonthlyInformation.IsContractualRewardsFinalizedManager),
			new SqlParameter("@DossierNumber", departmentMonthlyInformation.DossierNumber),
			new SqlParameter("@Value3", departmentMonthlyInformation.Value3),
			new SqlParameter("@Value4", departmentMonthlyInformation.Value4),
			new SqlParameter("@Value5", departmentMonthlyInformation.Value5),
			new SqlParameter("@Value6", departmentMonthlyInformation.Value6),
			new SqlParameter("@EmployeeNumber", departmentMonthlyInformation.EmployeeNumber),
			new SqlParameter("@ContractualEmployeeNumber", departmentMonthlyInformation.ContractualEmployeeNumber),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("DepartmentMonthlyInformation_SearchLike", CommandType.StoredProcedure, parametersDepartmentMonthlyInformation))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					DepartmentMonthlyInformation tmpDepartmentMonthlyInformation = new DepartmentMonthlyInformation();
					tmpDepartmentMonthlyInformation.YearTypeID = (row["YearTypeID"] != DBNull.Value) ? Convert.ToInt32(row["YearTypeID"]) : 0 ;
					tmpDepartmentMonthlyInformation.MonthTypeID = (row["MonthTypeID"] != DBNull.Value) ? Convert.ToInt32(row["MonthTypeID"]) : 0 ;
					tmpDepartmentMonthlyInformation.DepartmentID = (row["DepartmentID"] != DBNull.Value) ? Convert.ToInt32(row["DepartmentID"]) : 0 ;
					tmpDepartmentMonthlyInformation.AdjutancyTypeID = (row["AdjutancyTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AdjutancyTypeID"]) : 0 ;
					tmpDepartmentMonthlyInformation.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
					tmpDepartmentMonthlyInformation.OperationalReward_Average = (row["OperationalReward_Average"] != DBNull.Value) ? Convert.ToSingle(row["OperationalReward_Average"]) : 0 ;
					tmpDepartmentMonthlyInformation.OperationalRewardAverage = (row["OperationalRewardAverage"] != DBNull.Value) ? Convert.ToSingle(row["OperationalRewardAverage"]) : 0 ;
					tmpDepartmentMonthlyInformation.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToDecimal(row["Value2"]) : 0 ;
					tmpDepartmentMonthlyInformation.OperationalScore = (row["OperationalScore"] != DBNull.Value) ? Convert.ToDecimal(row["OperationalScore"]) : 0 ;
					tmpDepartmentMonthlyInformation.TotalParameter1 = (row["TotalParameter1"] != DBNull.Value) ? Convert.ToDecimal(row["TotalParameter1"]) : 0 ;
					tmpDepartmentMonthlyInformation.TotalParameter2 = (row["TotalParameter2"] != DBNull.Value) ? Convert.ToDecimal(row["TotalParameter2"]) : 0 ;
					tmpDepartmentMonthlyInformation.TotalParameter3 = (row["TotalParameter3"] != DBNull.Value) ? Convert.ToDecimal(row["TotalParameter3"]) : 0 ;
					tmpDepartmentMonthlyInformation.TotalBossFactor = (row["TotalBossFactor"] != DBNull.Value) ? Convert.ToDecimal(row["TotalBossFactor"]) : 0 ;
					tmpDepartmentMonthlyInformation.TotalReward_ = (row["TotalReward_"] != DBNull.Value) ? Convert.ToInt64(row["TotalReward_"]) : 0 ;
					tmpDepartmentMonthlyInformation.OrganizationalReward_ = (row["OrganizationalReward_"] != DBNull.Value) ? Convert.ToInt64(row["OrganizationalReward_"]) : 0 ;
					tmpDepartmentMonthlyInformation.OperationalReward_ = (row["OperationalReward_"] != DBNull.Value) ? Convert.ToInt64(row["OperationalReward_"]) : 0 ;
					tmpDepartmentMonthlyInformation.TotalReward_Average = (row["TotalReward_Average"] != DBNull.Value) ? Convert.ToInt64(row["TotalReward_Average"]) : 0 ;
					tmpDepartmentMonthlyInformation.YearTypeIDTitle = row["YearTypeIDTitle"].ToString();
					tmpDepartmentMonthlyInformation.MonthTypeIDTitle = row["MonthTypeIDTitle"].ToString();
					tmpDepartmentMonthlyInformation.DepartmentIDTitle = row["DepartmentIDTitle"].ToString();
					tmpDepartmentMonthlyInformation.RewardPerEmployee = (row["RewardPerEmployee"] != DBNull.Value) ? Convert.ToInt64(row["RewardPerEmployee"]) : 0 ;
					tmpDepartmentMonthlyInformation.OperationalRewardCalculated = (row["OperationalRewardCalculated"] != DBNull.Value) ? Convert.ToInt64(row["OperationalRewardCalculated"]) : 0 ;
					tmpDepartmentMonthlyInformation.OperationalReward = (row["OperationalReward"] != DBNull.Value) ? Convert.ToInt64(row["OperationalReward"]) : 0 ;
					tmpDepartmentMonthlyInformation.OrganizationalRewardCalculated = (row["OrganizationalRewardCalculated"] != DBNull.Value) ? Convert.ToInt64(row["OrganizationalRewardCalculated"]) : 0 ;
					tmpDepartmentMonthlyInformation.OrganizationalReward = (row["OrganizationalReward"] != DBNull.Value) ? Convert.ToInt64(row["OrganizationalReward"]) : 0 ;
					tmpDepartmentMonthlyInformation.MonthlyProceed = (row["MonthlyProceed"] != DBNull.Value) ? Convert.ToInt64(row["MonthlyProceed"]) : 0 ;
					tmpDepartmentMonthlyInformation.DesiredMonthlyProceed = (row["DesiredMonthlyProceed"] != DBNull.Value) ? Convert.ToInt64(row["DesiredMonthlyProceed"]) : 0 ;
					tmpDepartmentMonthlyInformation.LastYearProceed = (row["LastYearProceed"] != DBNull.Value) ? Convert.ToInt64(row["LastYearProceed"]) : 0 ;
					tmpDepartmentMonthlyInformation.StatisticsFinalalization = (row["StatisticsFinalalization"] != DBNull.Value) ? Convert.ToBoolean((row["StatisticsFinalalization"].ToString() == "1" || row["StatisticsFinalalization"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpDepartmentMonthlyInformation.AssistantRewardsFinalization = (row["AssistantRewardsFinalization"] != DBNull.Value) ? Convert.ToBoolean((row["AssistantRewardsFinalization"].ToString() == "1" || row["AssistantRewardsFinalization"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpDepartmentMonthlyInformation.ManagerRewardsFinalization = (row["ManagerRewardsFinalization"] != DBNull.Value) ? Convert.ToBoolean((row["ManagerRewardsFinalization"].ToString() == "1" || row["ManagerRewardsFinalization"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpDepartmentMonthlyInformation.IsOfficialRewardsFinalizedBoss = (row["IsOfficialRewardsFinalizedBoss"] != DBNull.Value) ? Convert.ToBoolean((row["IsOfficialRewardsFinalizedBoss"].ToString() == "1" || row["IsOfficialRewardsFinalizedBoss"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpDepartmentMonthlyInformation.IsOfficialRewardsFinalizedAssistant = (row["IsOfficialRewardsFinalizedAssistant"] != DBNull.Value) ? Convert.ToBoolean((row["IsOfficialRewardsFinalizedAssistant"].ToString() == "1" || row["IsOfficialRewardsFinalizedAssistant"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpDepartmentMonthlyInformation.IsOfficialRewardsFinalizedManager = (row["IsOfficialRewardsFinalizedManager"] != DBNull.Value) ? Convert.ToBoolean((row["IsOfficialRewardsFinalizedManager"].ToString() == "1" || row["IsOfficialRewardsFinalizedManager"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpDepartmentMonthlyInformation.ContractualRewardsFinalization = (row["ContractualRewardsFinalization"] != DBNull.Value) ? Convert.ToBoolean((row["ContractualRewardsFinalization"].ToString() == "1" || row["ContractualRewardsFinalization"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpDepartmentMonthlyInformation.IsContractualRewardsFinalizedBoss = (row["IsContractualRewardsFinalizedBoss"] != DBNull.Value) ? Convert.ToBoolean((row["IsContractualRewardsFinalizedBoss"].ToString() == "1" || row["IsContractualRewardsFinalizedBoss"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpDepartmentMonthlyInformation.IsContractualRewardsFinalizedAssistant = (row["IsContractualRewardsFinalizedAssistant"] != DBNull.Value) ? Convert.ToBoolean((row["IsContractualRewardsFinalizedAssistant"].ToString() == "1" || row["IsContractualRewardsFinalizedAssistant"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpDepartmentMonthlyInformation.IsContractualRewardsFinalizedManager = (row["IsContractualRewardsFinalizedManager"] != DBNull.Value) ? Convert.ToBoolean((row["IsContractualRewardsFinalizedManager"].ToString() == "1" || row["IsContractualRewardsFinalizedManager"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpDepartmentMonthlyInformation.DossierNumber = (row["DossierNumber"] != DBNull.Value) ? Convert.ToInt32(row["DossierNumber"]) : 0 ;
					tmpDepartmentMonthlyInformation.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToInt32(row["Value3"]) : 0 ;
					tmpDepartmentMonthlyInformation.Value4 = (row["Value4"] != DBNull.Value) ? Convert.ToInt32(row["Value4"]) : 0 ;
					tmpDepartmentMonthlyInformation.Value5 = (row["Value5"] != DBNull.Value) ? Convert.ToInt32(row["Value5"]) : 0 ;
					tmpDepartmentMonthlyInformation.Value6 = (row["Value6"] != DBNull.Value) ? Convert.ToInt32(row["Value6"]) : 0 ;
					tmpDepartmentMonthlyInformation.EmployeeNumber = (row["EmployeeNumber"] != DBNull.Value) ? Convert.ToInt32(row["EmployeeNumber"]) : 0 ;
					tmpDepartmentMonthlyInformation.ContractualEmployeeNumber = (row["ContractualEmployeeNumber"] != DBNull.Value) ? Convert.ToInt32(row["ContractualEmployeeNumber"]) : 0 ;

					listDepartmentMonthlyInformation.Add(tmpDepartmentMonthlyInformation);
				}
			}
		}

		return listDepartmentMonthlyInformation;
	}

}
}
