using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.Models;

namespace Rewards.DBA
{
public class MainOfficeTypeDBAccess
{

	BaseMonthlyInformationDBAccess baseMonthlyInformationDBAccess = new BaseMonthlyInformationDBAccess();
	DepartmentDBAccess departmentDBAccess = new DepartmentDBAccess();

	OfficialEmployeeRewardDBAccess officialEmployeeRewardDBAccess = new OfficialEmployeeRewardDBAccess();
	ContractualEmployeeRewardDBAccess contractualEmployeeRewardDBAccess = new ContractualEmployeeRewardDBAccess();
	public List<OfficialEmployeeReward> GetListOfficialEmployeeReward(int mainOfficeTypeID)
	{
		List<OfficialEmployeeReward> listOfficialEmployeeReward = new List<OfficialEmployeeReward>() { };
		SqlParameter[] parametersMainOfficeType = new SqlParameter[]
		{
			new SqlParameter("@MainOfficeTypeID", mainOfficeTypeID)
		};

		//Lets get the list of OfficialEmployeeReward records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("MainOfficeType_GetList_OfficialEmployeeReward", CommandType.StoredProcedure, parametersMainOfficeType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of OfficialEmployeeReward
				listOfficialEmployeeReward = new List<OfficialEmployeeReward>();

				//Now lets populate the OfficialEmployeeReward details into the list of OfficialEmployeeRewards
				foreach (DataRow row in table.Rows)
				{
					OfficialEmployeeReward officialEmployeeReward = officialEmployeeRewardDBAccess.GetDetails(Convert.ToInt64(row["NationalCode"]), Convert.ToInt32(row["YearTypeID"]), Convert.ToInt32(row["MonthTypeID"]));
					listOfficialEmployeeReward.Add(officialEmployeeReward);
				}
			}
		}

		return listOfficialEmployeeReward;
	}

	public List<ContractualEmployeeReward> GetListContractualEmployeeReward(int mainOfficeTypeID)
	{
		List<ContractualEmployeeReward> listContractualEmployeeReward = new List<ContractualEmployeeReward>() { };
		SqlParameter[] parametersMainOfficeType = new SqlParameter[]
		{
			new SqlParameter("@MainOfficeTypeID", mainOfficeTypeID)
		};

		//Lets get the list of ContractualEmployeeReward records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("MainOfficeType_GetList_ContractualEmployeeReward", CommandType.StoredProcedure, parametersMainOfficeType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of ContractualEmployeeReward
				listContractualEmployeeReward = new List<ContractualEmployeeReward>();

				//Now lets populate the ContractualEmployeeReward details into the list of ContractualEmployeeRewards
				foreach (DataRow row in table.Rows)
				{
					ContractualEmployeeReward contractualEmployeeReward = contractualEmployeeRewardDBAccess.GetDetails(Convert.ToInt32(row["YearTypeID"]), Convert.ToInt32(row["MonthTypeID"]), Convert.ToInt64(row["NationalCode"]));
					listContractualEmployeeReward.Add(contractualEmployeeReward);
				}
			}
		}

		return listContractualEmployeeReward;
	}

	public List<BaseMonthlyInformation> GetListBaseMonthlyInformation(int mainOfficeTypeID)
	{
		List<BaseMonthlyInformation> listBaseMonthlyInformation = new List<BaseMonthlyInformation>() { };
		SqlParameter[] parametersMainOfficeType = new SqlParameter[]
		{
			new SqlParameter("@MainOfficeTypeID", mainOfficeTypeID)
		};

		//Lets get the list of BaseMonthlyInformation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("BaseMonthlyInformation_GetList_UseInMainOfficeType", CommandType.StoredProcedure, parametersMainOfficeType))
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
	public List<Department> GetListDepartment(int mainOfficeTypeID)
	{
		List<Department> listDepartment = new List<Department>() { };
		SqlParameter[] parametersMainOfficeType = new SqlParameter[]
		{
			new SqlParameter("@MainOfficeTypeID", mainOfficeTypeID)
		};

		//Lets get the list of Department records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Department_GetList_UseInMainOfficeType", CommandType.StoredProcedure, parametersMainOfficeType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of department
				listDepartment = new List<Department>();

				//Now lets populate the Department details into the list of departments
				foreach (DataRow row in table.Rows)
				{
					Department department = ConvertRowToDepartment(row);
					listDepartment.Add(department);
				}
			}
		}

		return listDepartment;
	}

	private Department ConvertRowToDepartment(DataRow row)
	{
		Department department = new Department();
		department.DepartmentID = (row["DepartmentID"] != DBNull.Value) ? Convert.ToInt32(row["DepartmentID"]) : 0 ;
		department.DividerFullName = row["DividerFullName"].ToString();
		department.ComputationTypeIDTitle = row["ComputationTypeIDTitle"].ToString();
		department.MainOfficeTypeIDTitle = row["MainOfficeTypeIDTitle"].ToString();
		department.AdjutancyTypeIDTitle = row["AdjutancyTypeIDTitle"].ToString();
		department.ComputationTypeID = (row["ComputationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ComputationTypeID"]) : 0 ;
		department.MainOfficeTypeID = (row["MainOfficeTypeID"] != DBNull.Value) ? Convert.ToInt32(row["MainOfficeTypeID"]) : 0 ;
		department.AdjutancyTypeID = (row["AdjutancyTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AdjutancyTypeID"]) : 0 ;
		department.TotalEmployeeNumber = (row["TotalEmployeeNumber"] != DBNull.Value) ? Convert.ToInt32(row["TotalEmployeeNumber"]) : 0 ;
		department.TotalContractualEmployeeNumber = (row["TotalContractualEmployeeNumber"] != DBNull.Value) ? Convert.ToInt32(row["TotalContractualEmployeeNumber"]) : 0 ;
		department.TotalPersonalScore = (row["TotalPersonalScore"] != DBNull.Value) ? Convert.ToDecimal(row["TotalPersonalScore"]) : 0 ;
		department.DividerNationalCode = (row["DividerNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["DividerNationalCode"]) : 0 ;
		department.Title = row["Title"].ToString();
		return department;
	}
	public Int64 Insert(MainOfficeType mainOfficeType)
	{
		SqlParameter[] parametersMainOfficeType = new SqlParameter[]
		{
			new SqlParameter("@Title", mainOfficeType.Title),
			new SqlParameter("@TotalScore", (mainOfficeType.TotalScore != null) ? mainOfficeType.TotalScore : (object)DBNull.Value),
			new SqlParameter("@TotalScoreCat1", (mainOfficeType.TotalScoreCat1 != null) ? mainOfficeType.TotalScoreCat1 : (object)DBNull.Value),
			new SqlParameter("@TotalScoreCat2", (mainOfficeType.TotalScoreCat2 != null) ? mainOfficeType.TotalScoreCat2 : (object)DBNull.Value)
		};
		mainOfficeType.MainOfficeTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("MainOfficeType_Insert", CommandType.StoredProcedure, parametersMainOfficeType));
		return mainOfficeType.MainOfficeTypeID;
	}

	public bool Update(MainOfficeType mainOfficeType)
	{
		SqlParameter[] parametersMainOfficeType = new SqlParameter[]
		{
			new SqlParameter("@MainOfficeTypeID", mainOfficeType.MainOfficeTypeID),
			new SqlParameter("@Title", mainOfficeType.Title),
			new SqlParameter("@TotalScore", (mainOfficeType.TotalScore != null) ? mainOfficeType.TotalScore : (object)DBNull.Value),
			new SqlParameter("@TotalScoreCat1", (mainOfficeType.TotalScoreCat1 != null) ? mainOfficeType.TotalScoreCat1 : (object)DBNull.Value),
			new SqlParameter("@TotalScoreCat2", (mainOfficeType.TotalScoreCat2 != null) ? mainOfficeType.TotalScoreCat2 : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("MainOfficeType_Update", CommandType.StoredProcedure, parametersMainOfficeType);
	}

	public bool Delete(int mainOfficeTypeID)
	{
		SqlParameter[] parametersMainOfficeType = new SqlParameter[]
		{
			new SqlParameter("@MainOfficeTypeID", mainOfficeTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("MainOfficeType_Delete", CommandType.StoredProcedure, parametersMainOfficeType);
	}

	public MainOfficeType GetDetails(int mainOfficeTypeID)
	{
		MainOfficeType mainOfficeType = new MainOfficeType();

		SqlParameter[] parametersMainOfficeType = new SqlParameter[]
		{
			new SqlParameter("@MainOfficeTypeID", mainOfficeTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("MainOfficeType_GetDetails", CommandType.StoredProcedure, parametersMainOfficeType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				mainOfficeType.MainOfficeTypeID = (row["MainOfficeTypeID"] != DBNull.Value) ? Convert.ToInt32(row["MainOfficeTypeID"]) : 0 ;
				mainOfficeType.ContractualEmployeesNumber = (row["ContractualEmployeesNumber"] != DBNull.Value) ? Convert.ToInt64(row["ContractualEmployeesNumber"]) : 0 ;
				mainOfficeType.Title = row["Title"].ToString();
				mainOfficeType.TotalScore = (row["TotalScore"] != DBNull.Value) ? Convert.ToDecimal(row["TotalScore"]) : 0 ;
				mainOfficeType.TotalScoreCat1 = (row["TotalScoreCat1"] != DBNull.Value) ? Convert.ToDecimal(row["TotalScoreCat1"]) : 0 ;
				mainOfficeType.TotalScoreCat2 = (row["TotalScoreCat2"] != DBNull.Value) ? Convert.ToDecimal(row["TotalScoreCat2"]) : 0 ;
			}
		}

		return mainOfficeType;
	}

	public List<MainOfficeType> GetListAll()
	{
		List<MainOfficeType> listMainOfficeType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("MainOfficeType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listMainOfficeType = new List<MainOfficeType>();

				foreach (DataRow row in table.Rows)
				{
					MainOfficeType mainOfficeType = new MainOfficeType();
					mainOfficeType.MainOfficeTypeID = (row["MainOfficeTypeID"] != DBNull.Value) ? Convert.ToInt32(row["MainOfficeTypeID"]) : 0 ;
					mainOfficeType.ContractualEmployeesNumber = (row["ContractualEmployeesNumber"] != DBNull.Value) ? Convert.ToInt64(row["ContractualEmployeesNumber"]) : 0 ;
					mainOfficeType.Title = row["Title"].ToString();
					mainOfficeType.TotalScore = (row["TotalScore"] != DBNull.Value) ? Convert.ToDecimal(row["TotalScore"]) : 0 ;
					mainOfficeType.TotalScoreCat1 = (row["TotalScoreCat1"] != DBNull.Value) ? Convert.ToDecimal(row["TotalScoreCat1"]) : 0 ;
					mainOfficeType.TotalScoreCat2 = (row["TotalScoreCat2"] != DBNull.Value) ? Convert.ToDecimal(row["TotalScoreCat2"]) : 0 ;
					listMainOfficeType.Add(mainOfficeType);
				}
			}
		}

		return listMainOfficeType;
	}

	public bool Exists(int mainOfficeTypeID)
	{
		SqlParameter[] parametersMainOfficeType = new SqlParameter[]
		{
			new SqlParameter("@MainOfficeTypeID", mainOfficeTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("MainOfficeType_Exists", CommandType.StoredProcedure, parametersMainOfficeType)>0);
	}

	public bool Exists(MainOfficeType mainOfficeType)
	{
		SqlParameter[] parametersMainOfficeType = new SqlParameter[]
		{
			new SqlParameter("@MainOfficeTypeID", mainOfficeType.MainOfficeTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("MainOfficeType_Exists", CommandType.StoredProcedure, parametersMainOfficeType)>0);
	}

	public List<MainOfficeType> SearchLike(MainOfficeType mainOfficeType)
	{
		List<MainOfficeType> listMainOfficeType = new List<MainOfficeType>();


		SqlParameter[] parametersMainOfficeType = new SqlParameter[]
		{
			new SqlParameter("@MainOfficeTypeID", mainOfficeType.MainOfficeTypeID),
			new SqlParameter("@ContractualEmployeesNumber", mainOfficeType.ContractualEmployeesNumber),
			new SqlParameter("@Title", mainOfficeType.Title),
			new SqlParameter("@TotalScore", mainOfficeType.TotalScore),
			new SqlParameter("@TotalScoreCat1", mainOfficeType.TotalScoreCat1),
			new SqlParameter("@TotalScoreCat2", mainOfficeType.TotalScoreCat2),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("MainOfficeType_SearchLike", CommandType.StoredProcedure, parametersMainOfficeType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					MainOfficeType tmpMainOfficeType = new MainOfficeType();
					tmpMainOfficeType.MainOfficeTypeID = (row["MainOfficeTypeID"] != DBNull.Value) ? Convert.ToInt32(row["MainOfficeTypeID"]) : 0 ;
					tmpMainOfficeType.ContractualEmployeesNumber = (row["ContractualEmployeesNumber"] != DBNull.Value) ? Convert.ToInt64(row["ContractualEmployeesNumber"]) : 0 ;
					tmpMainOfficeType.Title = row["Title"].ToString();
					tmpMainOfficeType.TotalScore = (row["TotalScore"] != DBNull.Value) ? Convert.ToDecimal(row["TotalScore"]) : 0 ;
					tmpMainOfficeType.TotalScoreCat1 = (row["TotalScoreCat1"] != DBNull.Value) ? Convert.ToDecimal(row["TotalScoreCat1"]) : 0 ;
					tmpMainOfficeType.TotalScoreCat2 = (row["TotalScoreCat2"] != DBNull.Value) ? Convert.ToDecimal(row["TotalScoreCat2"]) : 0 ;

					listMainOfficeType.Add(tmpMainOfficeType);
				}
			}
		}

		return listMainOfficeType;
	}

}
}
