using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.Models;

namespace Rewards.DBA
{
public class DepartmentDBAccess
{

	DepartmentMonthlyInformationDBAccess departmentMonthlyInformationDBAccess = new DepartmentMonthlyInformationDBAccess();
	EmployeeDBAccess employeeDBAccess = new EmployeeDBAccess();

	OfficialEmployeeRewardDBAccess officialEmployeeRewardDBAccess = new OfficialEmployeeRewardDBAccess();
	ContractualEmployeeRewardDBAccess contractualEmployeeRewardDBAccess = new ContractualEmployeeRewardDBAccess();
	public List<OfficialEmployeeReward> GetListOfficialEmployeeReward(int departmentID)
	{
		List<OfficialEmployeeReward> listOfficialEmployeeReward = new List<OfficialEmployeeReward>() { };
		SqlParameter[] parametersDepartment = new SqlParameter[]
		{
			new SqlParameter("@DepartmentID", departmentID)
		};

		//Lets get the list of OfficialEmployeeReward records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Department_GetList_OfficialEmployeeReward", CommandType.StoredProcedure, parametersDepartment))
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

	public List<ContractualEmployeeReward> GetListContractualEmployeeReward(int departmentID)
	{
		List<ContractualEmployeeReward> listContractualEmployeeReward = new List<ContractualEmployeeReward>() { };
		SqlParameter[] parametersDepartment = new SqlParameter[]
		{
			new SqlParameter("@DepartmentID", departmentID)
		};

		//Lets get the list of ContractualEmployeeReward records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Department_GetList_ContractualEmployeeReward", CommandType.StoredProcedure, parametersDepartment))
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

	public List<DepartmentMonthlyInformation> GetListDepartmentMonthlyInformation(int departmentID)
	{
		List<DepartmentMonthlyInformation> listDepartmentMonthlyInformation = new List<DepartmentMonthlyInformation>() { };
		SqlParameter[] parametersDepartment = new SqlParameter[]
		{
			new SqlParameter("@DepartmentID", departmentID)
		};

		//Lets get the list of DepartmentMonthlyInformation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("DepartmentMonthlyInformation_GetList_UseInDepartment", CommandType.StoredProcedure, parametersDepartment))
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
	public List<Employee> GetListEmployee(int departmentID)
	{
		List<Employee> listEmployee = new List<Employee>() { };
		SqlParameter[] parametersDepartment = new SqlParameter[]
		{
			new SqlParameter("@DepartmentID", departmentID)
		};

		//Lets get the list of Employee records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Employee_GetList_UseInDepartment", CommandType.StoredProcedure, parametersDepartment))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of employee
				listEmployee = new List<Employee>();

				//Now lets populate the Employee details into the list of employees
				foreach (DataRow row in table.Rows)
				{
					Employee employee = ConvertRowToEmployee(row);
					listEmployee.Add(employee);
				}
			}
		}

		return listEmployee;
	}

	private Employee ConvertRowToEmployee(DataRow row)
	{
		Employee employee = new Employee();
		employee.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
		employee.ContractTypeIDTitle = row["ContractTypeIDTitle"].ToString();
		employee.RoleTypeIDTitle = row["RoleTypeIDTitle"].ToString();
		employee.FullName = row["FullName"].ToString();
		employee.DepartmentIDTitle = row["DepartmentIDTitle"].ToString();
		employee.RoleTypeIDFactor = (row["RoleTypeIDFactor"] != DBNull.Value) ? Convert.ToDecimal(row["RoleTypeIDFactor"]) : 0 ;
		employee.PersonalCode = row["PersonalCode"].ToString();
		employee.FirstName = row["FirstName"].ToString();
		employee.LastName = row["LastName"].ToString();
		employee.AccountNumber = row["AccountNumber"].ToString();
		employee.ContractTypeID = (row["ContractTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ContractTypeID"]) : 0 ;
		employee.RoleTypeID = (row["RoleTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RoleTypeID"]) : 0 ;
		employee.DepartmentID = (row["DepartmentID"] != DBNull.Value) ? Convert.ToInt32(row["DepartmentID"]) : 0 ;
		employee.IsActiveEmployee = (row["IsActiveEmployee"] != DBNull.Value) ? Convert.ToBoolean((row["IsActiveEmployee"].ToString() == "1" || row["IsActiveEmployee"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return employee;
	}
	public Int64 Insert(Department department)
	{
		SqlParameter[] parametersDepartment = new SqlParameter[]
		{
			new SqlParameter("@ComputationTypeID", (department.ComputationTypeID > 0) ? department.ComputationTypeID : (object)DBNull.Value),
			new SqlParameter("@MainOfficeTypeID", (department.MainOfficeTypeID > 0) ? department.MainOfficeTypeID : (object)DBNull.Value),
			new SqlParameter("@AdjutancyTypeID", (department.AdjutancyTypeID > 0) ? department.AdjutancyTypeID : (object)DBNull.Value),
			new SqlParameter("@TotalEmployeeNumber", (department.TotalEmployeeNumber != null) ? department.TotalEmployeeNumber : (object)DBNull.Value),
			new SqlParameter("@TotalContractualEmployeeNumber", (department.TotalContractualEmployeeNumber != null) ? department.TotalContractualEmployeeNumber : (object)DBNull.Value),
			new SqlParameter("@TotalPersonalScore", (department.TotalPersonalScore != null) ? department.TotalPersonalScore : (object)DBNull.Value),
			new SqlParameter("@DividerNationalCode", (department.DividerNationalCode != null) ? department.DividerNationalCode : (object)DBNull.Value),
			new SqlParameter("@Title", department.Title)
		};
		department.DepartmentID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("Department_Insert", CommandType.StoredProcedure, parametersDepartment));
		return department.DepartmentID;
	}

	public bool Update(Department department)
	{
		SqlParameter[] parametersDepartment = new SqlParameter[]
		{
			new SqlParameter("@DepartmentID", department.DepartmentID),
			new SqlParameter("@ComputationTypeID", (department.ComputationTypeID != null && department.ComputationTypeID >0 ) ? department.ComputationTypeID : (object)DBNull.Value),
			new SqlParameter("@MainOfficeTypeID", department.MainOfficeTypeID),
			new SqlParameter("@AdjutancyTypeID", (department.AdjutancyTypeID != null && department.AdjutancyTypeID >0 ) ? department.AdjutancyTypeID : (object)DBNull.Value),
			new SqlParameter("@TotalEmployeeNumber", (department.TotalEmployeeNumber != null) ? department.TotalEmployeeNumber : (object)DBNull.Value),
			new SqlParameter("@TotalContractualEmployeeNumber", (department.TotalContractualEmployeeNumber != null) ? department.TotalContractualEmployeeNumber : (object)DBNull.Value),
			new SqlParameter("@TotalPersonalScore", (department.TotalPersonalScore != null) ? department.TotalPersonalScore : (object)DBNull.Value),
			new SqlParameter("@DividerNationalCode", (department.DividerNationalCode != null) ? department.DividerNationalCode : (object)DBNull.Value),
			new SqlParameter("@Title", department.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("Department_Update", CommandType.StoredProcedure, parametersDepartment);
	}

	public bool Delete(int departmentID)
	{
		SqlParameter[] parametersDepartment = new SqlParameter[]
		{
			new SqlParameter("@DepartmentID", departmentID)
		};
		return SqlDBHelper.ExecuteNonQuery("Department_Delete", CommandType.StoredProcedure, parametersDepartment);
	}

	public Department GetDetails(int departmentID)
	{
		Department department = new Department();

		SqlParameter[] parametersDepartment = new SqlParameter[]
		{
			new SqlParameter("@DepartmentID", departmentID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Department_GetDetails", CommandType.StoredProcedure, parametersDepartment))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

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
			}
		}

		return department;
	}

	public List<Department> GetListAll()
	{
		List<Department> listDepartment = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Department_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listDepartment = new List<Department>();

				foreach (DataRow row in table.Rows)
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
					listDepartment.Add(department);
				}
			}
		}

		return listDepartment;
	}

	public bool Exists(int departmentID)
	{
		SqlParameter[] parametersDepartment = new SqlParameter[]
		{
			new SqlParameter("@DepartmentID", departmentID)
		};
		return (SqlDBHelper.ExecuteScalar("Department_Exists", CommandType.StoredProcedure, parametersDepartment)>0);
	}

	public bool Exists(Department department)
	{
		SqlParameter[] parametersDepartment = new SqlParameter[]
		{
			new SqlParameter("@DepartmentID", department.DepartmentID)
		};
		return (SqlDBHelper.ExecuteScalar("Department_Exists", CommandType.StoredProcedure, parametersDepartment)>0);
	}

	public List<Department> SearchLike(Department department)
	{
		List<Department> listDepartment = new List<Department>();


		SqlParameter[] parametersDepartment = new SqlParameter[]
		{
			new SqlParameter("@DepartmentID", department.DepartmentID),
			new SqlParameter("@DividerFullName", department.DividerFullName),
			new SqlParameter("@ComputationTypeIDTitle", department.ComputationTypeIDTitle),
			new SqlParameter("@MainOfficeTypeIDTitle", department.MainOfficeTypeIDTitle),
			new SqlParameter("@AdjutancyTypeIDTitle", department.AdjutancyTypeIDTitle),
			new SqlParameter("@ComputationTypeID", department.ComputationTypeID),
			new SqlParameter("@MainOfficeTypeID", department.MainOfficeTypeID),
			new SqlParameter("@AdjutancyTypeID", department.AdjutancyTypeID),
			new SqlParameter("@TotalEmployeeNumber", department.TotalEmployeeNumber),
			new SqlParameter("@TotalContractualEmployeeNumber", department.TotalContractualEmployeeNumber),
			new SqlParameter("@TotalPersonalScore", department.TotalPersonalScore),
			new SqlParameter("@DividerNationalCode", department.DividerNationalCode),
			new SqlParameter("@Title", department.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Department_SearchLike", CommandType.StoredProcedure, parametersDepartment))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Department tmpDepartment = new Department();
					tmpDepartment.DepartmentID = (row["DepartmentID"] != DBNull.Value) ? Convert.ToInt32(row["DepartmentID"]) : 0 ;
					tmpDepartment.DividerFullName = row["DividerFullName"].ToString();
					tmpDepartment.ComputationTypeIDTitle = row["ComputationTypeIDTitle"].ToString();
					tmpDepartment.MainOfficeTypeIDTitle = row["MainOfficeTypeIDTitle"].ToString();
					tmpDepartment.AdjutancyTypeIDTitle = row["AdjutancyTypeIDTitle"].ToString();
					tmpDepartment.ComputationTypeID = (row["ComputationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ComputationTypeID"]) : 0 ;
					tmpDepartment.MainOfficeTypeID = (row["MainOfficeTypeID"] != DBNull.Value) ? Convert.ToInt32(row["MainOfficeTypeID"]) : 0 ;
					tmpDepartment.AdjutancyTypeID = (row["AdjutancyTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AdjutancyTypeID"]) : 0 ;
					tmpDepartment.TotalEmployeeNumber = (row["TotalEmployeeNumber"] != DBNull.Value) ? Convert.ToInt32(row["TotalEmployeeNumber"]) : 0 ;
					tmpDepartment.TotalContractualEmployeeNumber = (row["TotalContractualEmployeeNumber"] != DBNull.Value) ? Convert.ToInt32(row["TotalContractualEmployeeNumber"]) : 0 ;
					tmpDepartment.TotalPersonalScore = (row["TotalPersonalScore"] != DBNull.Value) ? Convert.ToDecimal(row["TotalPersonalScore"]) : 0 ;
					tmpDepartment.DividerNationalCode = (row["DividerNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["DividerNationalCode"]) : 0 ;
					tmpDepartment.Title = row["Title"].ToString();

					listDepartment.Add(tmpDepartment);
				}
			}
		}

		return listDepartment;
	}

}
}
