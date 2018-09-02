using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.Models;

namespace Rewards.DBA
{
public class ContractTypeDBAccess
{

	EmployeeDBAccess employeeDBAccess = new EmployeeDBAccess();

	public List<Employee> GetListEmployee(int contractTypeID)
	{
		List<Employee> listEmployee = new List<Employee>() { };
		SqlParameter[] parametersContractType = new SqlParameter[]
		{
			new SqlParameter("@ContractTypeID", contractTypeID)
		};

		//Lets get the list of Employee records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Employee_GetList_UseInContractType", CommandType.StoredProcedure, parametersContractType))
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
		employee.RoleTypeIDTitle = row["RoleTypeIDTitle"].ToString();
		employee.FullName = row["FullName"].ToString();
		employee.DepartmentIDTitle = row["DepartmentIDTitle"].ToString();
		employee.ContractTypeIDTitle = row["ContractTypeIDTitle"].ToString();
		employee.RoleTypeIDFactor = (row["RoleTypeIDFactor"] != DBNull.Value) ? Convert.ToDecimal(row["RoleTypeIDFactor"]) : 0 ;
		employee.Password = row["Password"].ToString();
		employee.PersonalCode = row["PersonalCode"].ToString();
		employee.LastPassChangeDate = row["LastPassChangeDate"].ToString();
		employee.FirstName = row["FirstName"].ToString();
		employee.LastName = row["LastName"].ToString();
		employee.AccountNumber = row["AccountNumber"].ToString();
		employee.ContractTypeID = (row["ContractTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ContractTypeID"]) : 0 ;
		employee.RoleTypeID = (row["RoleTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RoleTypeID"]) : 0 ;
		employee.DepartmentID = (row["DepartmentID"] != DBNull.Value) ? Convert.ToInt32(row["DepartmentID"]) : 0 ;
		employee.IsActiveEmployee = (row["IsActiveEmployee"] != DBNull.Value) ? Convert.ToBoolean((row["IsActiveEmployee"].ToString() == "1" || row["IsActiveEmployee"].ToString().ToLower() == "true" ) ? true : false) : false ;
		employee.IsActiveUser = (row["IsActiveUser"] != DBNull.Value) ? Convert.ToBoolean((row["IsActiveUser"].ToString() == "1" || row["IsActiveUser"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return employee;
	}
	public Int64 Insert(ContractType contractType)
	{
		SqlParameter[] parametersContractType = new SqlParameter[]
		{
			new SqlParameter("@Title", contractType.Title)
		};
		contractType.ContractTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("ContractType_Insert", CommandType.StoredProcedure, parametersContractType));
		return contractType.ContractTypeID;
	}

	public bool Update(ContractType contractType)
	{
		SqlParameter[] parametersContractType = new SqlParameter[]
		{
			new SqlParameter("@ContractTypeID", contractType.ContractTypeID),
			new SqlParameter("@Title", contractType.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("ContractType_Update", CommandType.StoredProcedure, parametersContractType);
	}

	public bool Delete(int contractTypeID)
	{
		SqlParameter[] parametersContractType = new SqlParameter[]
		{
			new SqlParameter("@ContractTypeID", contractTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("ContractType_Delete", CommandType.StoredProcedure, parametersContractType);
	}

	public ContractType GetDetails(int contractTypeID)
	{
		ContractType contractType = new ContractType();

		SqlParameter[] parametersContractType = new SqlParameter[]
		{
			new SqlParameter("@ContractTypeID", contractTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ContractType_GetDetails", CommandType.StoredProcedure, parametersContractType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				contractType.ContractTypeID = (row["ContractTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ContractTypeID"]) : 0 ;
				contractType.Title = row["Title"].ToString();
			}
		}

		return contractType;
	}

	public List<ContractType> GetListAll()
	{
		List<ContractType> listContractType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("ContractType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listContractType = new List<ContractType>();

				foreach (DataRow row in table.Rows)
				{
					ContractType contractType = new ContractType();
					contractType.ContractTypeID = (row["ContractTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ContractTypeID"]) : 0 ;
					contractType.Title = row["Title"].ToString();
					listContractType.Add(contractType);
				}
			}
		}

		return listContractType;
	}

	public bool Exists(int contractTypeID)
	{
		SqlParameter[] parametersContractType = new SqlParameter[]
		{
			new SqlParameter("@ContractTypeID", contractTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("ContractType_Exists", CommandType.StoredProcedure, parametersContractType)>0);
	}

	public bool Exists(ContractType contractType)
	{
		SqlParameter[] parametersContractType = new SqlParameter[]
		{
			new SqlParameter("@ContractTypeID", contractType.ContractTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("ContractType_Exists", CommandType.StoredProcedure, parametersContractType)>0);
	}

	public List<ContractType> SearchLike(ContractType contractType)
	{
		List<ContractType> listContractType = new List<ContractType>();


		SqlParameter[] parametersContractType = new SqlParameter[]
		{
			new SqlParameter("@ContractTypeID", contractType.ContractTypeID),
			new SqlParameter("@Title", contractType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ContractType_SearchLike", CommandType.StoredProcedure, parametersContractType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					ContractType tmpContractType = new ContractType();
					tmpContractType.ContractTypeID = (row["ContractTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ContractTypeID"]) : 0 ;
					tmpContractType.Title = row["Title"].ToString();

					listContractType.Add(tmpContractType);
				}
			}
		}

		return listContractType;
	}

}
}
