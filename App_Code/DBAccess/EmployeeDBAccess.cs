using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.Models;

namespace Rewards.DBA
{
public class EmployeeDBAccess
{

	ContractualEmployeeRewardDBAccess contractualEmployeeRewardDBAccess = new ContractualEmployeeRewardDBAccess();
	EmployeeUserTypeDBAccess employeeUserTypeDBAccess = new EmployeeUserTypeDBAccess();
	OfficialEmployeeRewardDBAccess officialEmployeeRewardDBAccess = new OfficialEmployeeRewardDBAccess();

	public List<ContractualEmployeeReward> GetListContractualEmployeeReward(Int64 nationalCode)
	{
		List<ContractualEmployeeReward> listContractualEmployeeReward = new List<ContractualEmployeeReward>() { };
		SqlParameter[] parametersEmployee = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", nationalCode)
		};

		//Lets get the list of ContractualEmployeeReward records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ContractualEmployeeReward_GetList_UseInEmployee", CommandType.StoredProcedure, parametersEmployee))
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
	public List<EmployeeUserType> GetListEmployeeUserType(Int64 nationalCode)
	{
		List<EmployeeUserType> listEmployeeUserType = new List<EmployeeUserType>() { };
		SqlParameter[] parametersEmployee = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", nationalCode)
		};

		//Lets get the list of EmployeeUserType records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("EmployeeUserType_GetList_UseInEmployee", CommandType.StoredProcedure, parametersEmployee))
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
	public List<OfficialEmployeeReward> GetListOfficialEmployeeReward(Int64 nationalCode)
	{
		List<OfficialEmployeeReward> listOfficialEmployeeReward = new List<OfficialEmployeeReward>() { };
		SqlParameter[] parametersEmployee = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", nationalCode)
		};

		//Lets get the list of OfficialEmployeeReward records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("OfficialEmployeeReward_GetList_UseInEmployee", CommandType.StoredProcedure, parametersEmployee))
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
	public Int64 Insert(Employee employee)
	{
		SqlParameter[] parametersEmployee = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", employee.NationalCode),
			new SqlParameter("@PersonalCode", (employee.PersonalCode != null) ? employee.PersonalCode : (object)DBNull.Value),
			new SqlParameter("@FirstName", employee.FirstName),
			new SqlParameter("@LastName", employee.LastName),
			new SqlParameter("@AccountNumber", (employee.AccountNumber != null) ? employee.AccountNumber : (object)DBNull.Value),
			new SqlParameter("@ContractTypeID", (employee.ContractTypeID > 0) ? employee.ContractTypeID : (object)DBNull.Value),
			new SqlParameter("@RoleTypeID", (employee.RoleTypeID > 0) ? employee.RoleTypeID : (object)DBNull.Value),
			new SqlParameter("@DepartmentID", (employee.DepartmentID > 0) ? employee.DepartmentID : (object)DBNull.Value),
			new SqlParameter("@IsActiveEmployee", employee.IsActiveEmployee)
		};
		return SqlDBHelper.ExecuteScalar("Employee_Insert", CommandType.StoredProcedure, parametersEmployee);
	}

	public bool Update(Employee employee)
	{
		SqlParameter[] parametersEmployee = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", employee.NationalCode),
			new SqlParameter("@PersonalCode", (employee.PersonalCode != null) ? employee.PersonalCode : (object)DBNull.Value),
			new SqlParameter("@FirstName", employee.FirstName),
			new SqlParameter("@LastName", employee.LastName),
			new SqlParameter("@AccountNumber", (employee.AccountNumber != null) ? employee.AccountNumber : (object)DBNull.Value),
			new SqlParameter("@ContractTypeID", (employee.ContractTypeID != null && employee.ContractTypeID >0 ) ? employee.ContractTypeID : (object)DBNull.Value),
			new SqlParameter("@RoleTypeID", (employee.RoleTypeID != null && employee.RoleTypeID >0 ) ? employee.RoleTypeID : (object)DBNull.Value),
			new SqlParameter("@DepartmentID", (employee.DepartmentID != null && employee.DepartmentID >0 ) ? employee.DepartmentID : (object)DBNull.Value),
			new SqlParameter("@IsActiveEmployee", employee.IsActiveEmployee)
		};
		return SqlDBHelper.ExecuteNonQuery("Employee_Update", CommandType.StoredProcedure, parametersEmployee);
	}

	public bool Delete(Int64 nationalCode)
	{
		SqlParameter[] parametersEmployee = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", nationalCode)
		};
		return SqlDBHelper.ExecuteNonQuery("Employee_Delete", CommandType.StoredProcedure, parametersEmployee);
	}

	public Employee GetDetails(Int64 nationalCode)
	{
		Employee employee = new Employee();

		SqlParameter[] parametersEmployee = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", nationalCode)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Employee_GetDetails", CommandType.StoredProcedure, parametersEmployee))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

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
			}
		}

		return employee;
	}

	public List<Employee> GetListAll()
	{
		List<Employee> listEmployee = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Employee_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listEmployee = new List<Employee>();

				foreach (DataRow row in table.Rows)
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
					listEmployee.Add(employee);
				}
			}
		}

		return listEmployee;
	}

	public bool Exists(Int64 nationalCode)
	{
		SqlParameter[] parametersEmployee = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", nationalCode)
		};
		return (SqlDBHelper.ExecuteScalar("Employee_Exists", CommandType.StoredProcedure, parametersEmployee)>0);
	}

	public bool Exists(Employee employee)
	{
		SqlParameter[] parametersEmployee = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", employee.NationalCode)
		};
		return (SqlDBHelper.ExecuteScalar("Employee_Exists", CommandType.StoredProcedure, parametersEmployee)>0);
	}

	public List<Employee> SearchLike(Employee employee)
	{
		List<Employee> listEmployee = new List<Employee>();


		SqlParameter[] parametersEmployee = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", employee.NationalCode),
			new SqlParameter("@ContractTypeIDTitle", employee.ContractTypeIDTitle),
			new SqlParameter("@RoleTypeIDTitle", employee.RoleTypeIDTitle),
			new SqlParameter("@FullName", employee.FullName),
			new SqlParameter("@DepartmentIDTitle", employee.DepartmentIDTitle),
			new SqlParameter("@RoleTypeIDFactor", employee.RoleTypeIDFactor),
			new SqlParameter("@PersonalCode", employee.PersonalCode),
			new SqlParameter("@FirstName", employee.FirstName),
			new SqlParameter("@LastName", employee.LastName),
			new SqlParameter("@AccountNumber", employee.AccountNumber),
			new SqlParameter("@ContractTypeID", employee.ContractTypeID),
			new SqlParameter("@RoleTypeID", employee.RoleTypeID),
			new SqlParameter("@DepartmentID", employee.DepartmentID),
			new SqlParameter("@IsActiveEmployee", employee.IsActiveEmployee),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Employee_SearchLike", CommandType.StoredProcedure, parametersEmployee))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Employee tmpEmployee = new Employee();
					tmpEmployee.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
					tmpEmployee.ContractTypeIDTitle = row["ContractTypeIDTitle"].ToString();
					tmpEmployee.RoleTypeIDTitle = row["RoleTypeIDTitle"].ToString();
					tmpEmployee.FullName = row["FullName"].ToString();
					tmpEmployee.DepartmentIDTitle = row["DepartmentIDTitle"].ToString();
					tmpEmployee.RoleTypeIDFactor = (row["RoleTypeIDFactor"] != DBNull.Value) ? Convert.ToDecimal(row["RoleTypeIDFactor"]) : 0 ;
					tmpEmployee.PersonalCode = row["PersonalCode"].ToString();
					tmpEmployee.FirstName = row["FirstName"].ToString();
					tmpEmployee.LastName = row["LastName"].ToString();
					tmpEmployee.AccountNumber = row["AccountNumber"].ToString();
					tmpEmployee.ContractTypeID = (row["ContractTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ContractTypeID"]) : 0 ;
					tmpEmployee.RoleTypeID = (row["RoleTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RoleTypeID"]) : 0 ;
					tmpEmployee.DepartmentID = (row["DepartmentID"] != DBNull.Value) ? Convert.ToInt32(row["DepartmentID"]) : 0 ;
					tmpEmployee.IsActiveEmployee = (row["IsActiveEmployee"] != DBNull.Value) ? Convert.ToBoolean((row["IsActiveEmployee"].ToString() == "1" || row["IsActiveEmployee"].ToString().ToLower() == "true" ) ? true : false) : false ;

					listEmployee.Add(tmpEmployee);
				}
			}
		}

		return listEmployee;
	}

}
}
