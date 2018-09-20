using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.Models;

namespace Rewards.DBA
{
public class BaseMonthlyInformationDBAccess
{


	public Int64 Insert(BaseMonthlyInformation baseMonthlyInformation)
	{
		SqlParameter[] parametersBaseMonthlyInformation = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", (baseMonthlyInformation.YearTypeID > 0) ? baseMonthlyInformation.YearTypeID : (object)DBNull.Value),
			new SqlParameter("@MonthTypeID", (baseMonthlyInformation.MonthTypeID > 0) ? baseMonthlyInformation.MonthTypeID : (object)DBNull.Value),
			new SqlParameter("@MainOfficeTypeID", (baseMonthlyInformation.MainOfficeTypeID > 0) ? baseMonthlyInformation.MainOfficeTypeID : (object)DBNull.Value),
			new SqlParameter("@ContractualReward", (baseMonthlyInformation.ContractualReward != null) ? baseMonthlyInformation.ContractualReward : (object)DBNull.Value),
			new SqlParameter("@ContractualConstantReward", (baseMonthlyInformation.ContractualConstantReward != null) ? baseMonthlyInformation.ContractualConstantReward : (object)DBNull.Value),
			new SqlParameter("@ExtraReward", (baseMonthlyInformation.ExtraReward != null) ? baseMonthlyInformation.ExtraReward : (object)DBNull.Value),
			new SqlParameter("@Factor5", baseMonthlyInformation.Factor5),
			new SqlParameter("@Factor6", baseMonthlyInformation.Factor6),
			new SqlParameter("@Factor7", baseMonthlyInformation.Factor7),
			new SqlParameter("@Factor8", baseMonthlyInformation.Factor8),
			new SqlParameter("@Factor9", baseMonthlyInformation.Factor9),
			new SqlParameter("@Factor10", baseMonthlyInformation.Factor10),
			new SqlParameter("@OfficialReward", (baseMonthlyInformation.OfficialReward != null) ? baseMonthlyInformation.OfficialReward : (object)DBNull.Value),
			new SqlParameter("@IsFanalized", (baseMonthlyInformation.IsFanalized != null) ? baseMonthlyInformation.IsFanalized : (object)DBNull.Value),
			new SqlParameter("@IsFainalizedEmployeesInformation", (baseMonthlyInformation.IsFainalizedEmployeesInformation != null) ? baseMonthlyInformation.IsFainalizedEmployeesInformation : (object)DBNull.Value),
			new SqlParameter("@IsFainalizedRewardCalculation", (baseMonthlyInformation.IsFainalizedRewardCalculation != null) ? baseMonthlyInformation.IsFainalizedRewardCalculation : (object)DBNull.Value),
			new SqlParameter("@BossFactor", baseMonthlyInformation.BossFactor),
			new SqlParameter("@OperationalFactor", baseMonthlyInformation.OperationalFactor),
			new SqlParameter("@Factor1", baseMonthlyInformation.Factor1),
			new SqlParameter("@Factor2", baseMonthlyInformation.Factor2),
			new SqlParameter("@Factor3", baseMonthlyInformation.Factor3),
			new SqlParameter("@Factor4", baseMonthlyInformation.Factor4)
		};
		return SqlDBHelper.ExecuteScalar("BaseMonthlyInformation_Insert", CommandType.StoredProcedure, parametersBaseMonthlyInformation);
	}

	public bool Update(BaseMonthlyInformation baseMonthlyInformation)
	{
		SqlParameter[] parametersBaseMonthlyInformation = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", baseMonthlyInformation.YearTypeID),
			new SqlParameter("@MonthTypeID", baseMonthlyInformation.MonthTypeID),
			new SqlParameter("@MainOfficeTypeID", baseMonthlyInformation.MainOfficeTypeID),
			new SqlParameter("@ContractualReward", (baseMonthlyInformation.ContractualReward != null) ? baseMonthlyInformation.ContractualReward : (object)DBNull.Value),
			new SqlParameter("@ContractualConstantReward", (baseMonthlyInformation.ContractualConstantReward != null) ? baseMonthlyInformation.ContractualConstantReward : (object)DBNull.Value),
			new SqlParameter("@ExtraReward", (baseMonthlyInformation.ExtraReward != null) ? baseMonthlyInformation.ExtraReward : (object)DBNull.Value),
			new SqlParameter("@Factor5", baseMonthlyInformation.Factor5),
			new SqlParameter("@Factor6", baseMonthlyInformation.Factor6),
			new SqlParameter("@Factor7", baseMonthlyInformation.Factor7),
			new SqlParameter("@Factor8", baseMonthlyInformation.Factor8),
			new SqlParameter("@Factor9", baseMonthlyInformation.Factor9),
			new SqlParameter("@Factor10", baseMonthlyInformation.Factor10),
			new SqlParameter("@OfficialReward", (baseMonthlyInformation.OfficialReward != null) ? baseMonthlyInformation.OfficialReward : (object)DBNull.Value),
			new SqlParameter("@IsFanalized", (baseMonthlyInformation.IsFanalized != null) ? baseMonthlyInformation.IsFanalized : (object)DBNull.Value),
			new SqlParameter("@IsFainalizedEmployeesInformation", (baseMonthlyInformation.IsFainalizedEmployeesInformation != null) ? baseMonthlyInformation.IsFainalizedEmployeesInformation : (object)DBNull.Value),
			new SqlParameter("@IsFainalizedRewardCalculation", (baseMonthlyInformation.IsFainalizedRewardCalculation != null) ? baseMonthlyInformation.IsFainalizedRewardCalculation : (object)DBNull.Value),
			new SqlParameter("@BossFactor", baseMonthlyInformation.BossFactor),
			new SqlParameter("@OperationalFactor", baseMonthlyInformation.OperationalFactor),
			new SqlParameter("@Factor1", baseMonthlyInformation.Factor1),
			new SqlParameter("@Factor2", baseMonthlyInformation.Factor2),
			new SqlParameter("@Factor3", baseMonthlyInformation.Factor3),
			new SqlParameter("@Factor4", baseMonthlyInformation.Factor4)
		};
		return SqlDBHelper.ExecuteNonQuery("BaseMonthlyInformation_Update", CommandType.StoredProcedure, parametersBaseMonthlyInformation);
	}

	public bool Delete(int yearTypeID , int monthTypeID , int mainOfficeTypeID)
	{
		SqlParameter[] parametersBaseMonthlyInformation = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", yearTypeID),
			new SqlParameter("@MonthTypeID", monthTypeID),
			new SqlParameter("@MainOfficeTypeID", mainOfficeTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("BaseMonthlyInformation_Delete", CommandType.StoredProcedure, parametersBaseMonthlyInformation);
	}

	public BaseMonthlyInformation GetDetails(int yearTypeID , int monthTypeID , int mainOfficeTypeID)
	{
		BaseMonthlyInformation baseMonthlyInformation = new BaseMonthlyInformation();

		SqlParameter[] parametersBaseMonthlyInformation = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", yearTypeID),
			new SqlParameter("@MonthTypeID", monthTypeID),
			new SqlParameter("@MainOfficeTypeID", mainOfficeTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("BaseMonthlyInformation_GetDetails", CommandType.StoredProcedure, parametersBaseMonthlyInformation))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

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
			}
		}

		return baseMonthlyInformation;
	}

	public List<BaseMonthlyInformation> GetListAll()
	{
		List<BaseMonthlyInformation> listBaseMonthlyInformation = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("BaseMonthlyInformation_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listBaseMonthlyInformation = new List<BaseMonthlyInformation>();

				foreach (DataRow row in table.Rows)
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
					listBaseMonthlyInformation.Add(baseMonthlyInformation);
				}
			}
		}

		return listBaseMonthlyInformation;
	}

	public bool Exists(int yearTypeID , int monthTypeID , int mainOfficeTypeID)
	{
		SqlParameter[] parametersBaseMonthlyInformation = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", yearTypeID),
			new SqlParameter("@MonthTypeID", monthTypeID),
			new SqlParameter("@MainOfficeTypeID", mainOfficeTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("BaseMonthlyInformation_Exists", CommandType.StoredProcedure, parametersBaseMonthlyInformation)>0);
	}

	public bool Exists(BaseMonthlyInformation baseMonthlyInformation)
	{
		SqlParameter[] parametersBaseMonthlyInformation = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", baseMonthlyInformation.YearTypeID),
			new SqlParameter("@MonthTypeID", baseMonthlyInformation.MonthTypeID),
			new SqlParameter("@MainOfficeTypeID", baseMonthlyInformation.MainOfficeTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("BaseMonthlyInformation_Exists", CommandType.StoredProcedure, parametersBaseMonthlyInformation)>0);
	}

	public List<BaseMonthlyInformation> SearchLike(BaseMonthlyInformation baseMonthlyInformation)
	{
		List<BaseMonthlyInformation> listBaseMonthlyInformation = new List<BaseMonthlyInformation>();


		SqlParameter[] parametersBaseMonthlyInformation = new SqlParameter[]
		{
			new SqlParameter("@YearTypeID", baseMonthlyInformation.YearTypeID),
			new SqlParameter("@MonthTypeID", baseMonthlyInformation.MonthTypeID),
			new SqlParameter("@MainOfficeTypeID", baseMonthlyInformation.MainOfficeTypeID),
			new SqlParameter("@ValueToScore", baseMonthlyInformation.ValueToScore),
			new SqlParameter("@TotalOperationalReward", baseMonthlyInformation.TotalOperationalReward),
			new SqlParameter("@TotalOrganizationalReward", baseMonthlyInformation.TotalOrganizationalReward),
			new SqlParameter("@ContractualDividableReward", baseMonthlyInformation.ContractualDividableReward),
			new SqlParameter("@ContractualBossReward", baseMonthlyInformation.ContractualBossReward),
			new SqlParameter("@ContractualDevotedReward", baseMonthlyInformation.ContractualDevotedReward),
			new SqlParameter("@ContractualRemainingReward", baseMonthlyInformation.ContractualRemainingReward),
			new SqlParameter("@DividableReward", baseMonthlyInformation.DividableReward),
			new SqlParameter("@BossReward", baseMonthlyInformation.BossReward),
			new SqlParameter("@DevotedReward", baseMonthlyInformation.DevotedReward),
			new SqlParameter("@RemainingReward", baseMonthlyInformation.RemainingReward),
			new SqlParameter("@YearTypeIDTitle", baseMonthlyInformation.YearTypeIDTitle),
			new SqlParameter("@MonthTypeIDTitle", baseMonthlyInformation.MonthTypeIDTitle),
			new SqlParameter("@ContractualReward", baseMonthlyInformation.ContractualReward),
			new SqlParameter("@ContractualConstantReward", baseMonthlyInformation.ContractualConstantReward),
			new SqlParameter("@ExtraReward", baseMonthlyInformation.ExtraReward),
			new SqlParameter("@Factor5", baseMonthlyInformation.Factor5),
			new SqlParameter("@Factor6", baseMonthlyInformation.Factor6),
			new SqlParameter("@Factor7", baseMonthlyInformation.Factor7),
			new SqlParameter("@Factor8", baseMonthlyInformation.Factor8),
			new SqlParameter("@Factor9", baseMonthlyInformation.Factor9),
			new SqlParameter("@Factor10", baseMonthlyInformation.Factor10),
			new SqlParameter("@OfficialReward", baseMonthlyInformation.OfficialReward),
			new SqlParameter("@IsFanalized", baseMonthlyInformation.IsFanalized),
			new SqlParameter("@IsFainalizedEmployeesInformation", baseMonthlyInformation.IsFainalizedEmployeesInformation),
			new SqlParameter("@IsFainalizedRewardCalculation", baseMonthlyInformation.IsFainalizedRewardCalculation),
			new SqlParameter("@BossFactor", baseMonthlyInformation.BossFactor),
			new SqlParameter("@OperationalFactor", baseMonthlyInformation.OperationalFactor),
			new SqlParameter("@Factor1", baseMonthlyInformation.Factor1),
			new SqlParameter("@Factor2", baseMonthlyInformation.Factor2),
			new SqlParameter("@Factor3", baseMonthlyInformation.Factor3),
			new SqlParameter("@Factor4", baseMonthlyInformation.Factor4),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("BaseMonthlyInformation_SearchLike", CommandType.StoredProcedure, parametersBaseMonthlyInformation))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					BaseMonthlyInformation tmpBaseMonthlyInformation = new BaseMonthlyInformation();
					tmpBaseMonthlyInformation.YearTypeID = (row["YearTypeID"] != DBNull.Value) ? Convert.ToInt32(row["YearTypeID"]) : 0 ;
					tmpBaseMonthlyInformation.MonthTypeID = (row["MonthTypeID"] != DBNull.Value) ? Convert.ToInt32(row["MonthTypeID"]) : 0 ;
					tmpBaseMonthlyInformation.MainOfficeTypeID = (row["MainOfficeTypeID"] != DBNull.Value) ? Convert.ToInt32(row["MainOfficeTypeID"]) : 0 ;
					tmpBaseMonthlyInformation.ValueToScore = (row["ValueToScore"] != DBNull.Value) ? Convert.ToDecimal(row["ValueToScore"]) : 0 ;
					tmpBaseMonthlyInformation.TotalOperationalReward = (row["TotalOperationalReward"] != DBNull.Value) ? Convert.ToInt64(row["TotalOperationalReward"]) : 0 ;
					tmpBaseMonthlyInformation.TotalOrganizationalReward = (row["TotalOrganizationalReward"] != DBNull.Value) ? Convert.ToInt64(row["TotalOrganizationalReward"]) : 0 ;
					tmpBaseMonthlyInformation.ContractualDividableReward = (row["ContractualDividableReward"] != DBNull.Value) ? Convert.ToInt64(row["ContractualDividableReward"]) : 0 ;
					tmpBaseMonthlyInformation.ContractualBossReward = (row["ContractualBossReward"] != DBNull.Value) ? Convert.ToInt64(row["ContractualBossReward"]) : 0 ;
					tmpBaseMonthlyInformation.ContractualDevotedReward = (row["ContractualDevotedReward"] != DBNull.Value) ? Convert.ToInt64(row["ContractualDevotedReward"]) : 0 ;
					tmpBaseMonthlyInformation.ContractualRemainingReward = (row["ContractualRemainingReward"] != DBNull.Value) ? Convert.ToInt64(row["ContractualRemainingReward"]) : 0 ;
					tmpBaseMonthlyInformation.DividableReward = (row["DividableReward"] != DBNull.Value) ? Convert.ToInt64(row["DividableReward"]) : 0 ;
					tmpBaseMonthlyInformation.BossReward = (row["BossReward"] != DBNull.Value) ? Convert.ToInt64(row["BossReward"]) : 0 ;
					tmpBaseMonthlyInformation.DevotedReward = (row["DevotedReward"] != DBNull.Value) ? Convert.ToInt64(row["DevotedReward"]) : 0 ;
					tmpBaseMonthlyInformation.RemainingReward = (row["RemainingReward"] != DBNull.Value) ? Convert.ToInt64(row["RemainingReward"]) : 0 ;
					tmpBaseMonthlyInformation.YearTypeIDTitle = row["YearTypeIDTitle"].ToString();
					tmpBaseMonthlyInformation.MonthTypeIDTitle = row["MonthTypeIDTitle"].ToString();
					tmpBaseMonthlyInformation.ContractualReward = (row["ContractualReward"] != DBNull.Value) ? Convert.ToInt64(row["ContractualReward"]) : 0 ;
					tmpBaseMonthlyInformation.ContractualConstantReward = (row["ContractualConstantReward"] != DBNull.Value) ? Convert.ToInt64(row["ContractualConstantReward"]) : 0 ;
					tmpBaseMonthlyInformation.ExtraReward = (row["ExtraReward"] != DBNull.Value) ? Convert.ToInt64(row["ExtraReward"]) : 0 ;
					tmpBaseMonthlyInformation.Factor5 = (row["Factor5"] != DBNull.Value) ? Convert.ToDecimal(row["Factor5"]) : 0 ;
					tmpBaseMonthlyInformation.Factor6 = (row["Factor6"] != DBNull.Value) ? Convert.ToDecimal(row["Factor6"]) : 0 ;
					tmpBaseMonthlyInformation.Factor7 = (row["Factor7"] != DBNull.Value) ? Convert.ToDecimal(row["Factor7"]) : 0 ;
					tmpBaseMonthlyInformation.Factor8 = (row["Factor8"] != DBNull.Value) ? Convert.ToDecimal(row["Factor8"]) : 0 ;
					tmpBaseMonthlyInformation.Factor9 = (row["Factor9"] != DBNull.Value) ? Convert.ToDecimal(row["Factor9"]) : 0 ;
					tmpBaseMonthlyInformation.Factor10 = (row["Factor10"] != DBNull.Value) ? Convert.ToDecimal(row["Factor10"]) : 0 ;
					tmpBaseMonthlyInformation.OfficialReward = (row["OfficialReward"] != DBNull.Value) ? Convert.ToInt64(row["OfficialReward"]) : 0 ;
					tmpBaseMonthlyInformation.IsFanalized = (row["IsFanalized"] != DBNull.Value) ? Convert.ToBoolean((row["IsFanalized"].ToString() == "1" || row["IsFanalized"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpBaseMonthlyInformation.IsFainalizedEmployeesInformation = (row["IsFainalizedEmployeesInformation"] != DBNull.Value) ? Convert.ToBoolean((row["IsFainalizedEmployeesInformation"].ToString() == "1" || row["IsFainalizedEmployeesInformation"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpBaseMonthlyInformation.IsFainalizedRewardCalculation = (row["IsFainalizedRewardCalculation"] != DBNull.Value) ? Convert.ToBoolean((row["IsFainalizedRewardCalculation"].ToString() == "1" || row["IsFainalizedRewardCalculation"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpBaseMonthlyInformation.BossFactor = (row["BossFactor"] != DBNull.Value) ? Convert.ToDecimal(row["BossFactor"]) : 0 ;
					tmpBaseMonthlyInformation.OperationalFactor = (row["OperationalFactor"] != DBNull.Value) ? Convert.ToDecimal(row["OperationalFactor"]) : 0 ;
					tmpBaseMonthlyInformation.Factor1 = (row["Factor1"] != DBNull.Value) ? Convert.ToDecimal(row["Factor1"]) : 0 ;
					tmpBaseMonthlyInformation.Factor2 = (row["Factor2"] != DBNull.Value) ? Convert.ToDecimal(row["Factor2"]) : 0 ;
					tmpBaseMonthlyInformation.Factor3 = (row["Factor3"] != DBNull.Value) ? Convert.ToDecimal(row["Factor3"]) : 0 ;
					tmpBaseMonthlyInformation.Factor4 = (row["Factor4"] != DBNull.Value) ? Convert.ToDecimal(row["Factor4"]) : 0 ;

					listBaseMonthlyInformation.Add(tmpBaseMonthlyInformation);
				}
			}
		}

		return listBaseMonthlyInformation;
	}

}
}
