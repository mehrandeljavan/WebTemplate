using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.Models;

namespace Rewards.DBA
{
public class RoleTypeDBAccess
{

	EmployeeDBAccess employeeDBAccess = new EmployeeDBAccess();

	public List<Employee> GetListEmployee(int roleTypeID)
	{
		List<Employee> listEmployee = new List<Employee>() { };
		SqlParameter[] parametersRoleType = new SqlParameter[]
		{
			new SqlParameter("@RoleTypeID", roleTypeID)
		};

		//Lets get the list of Employee records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Employee_GetList_UseInRoleType", CommandType.StoredProcedure, parametersRoleType))
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
	public Int64 Insert(RoleType roleType)
	{
		SqlParameter[] parametersRoleType = new SqlParameter[]
		{
			new SqlParameter("@Factor", roleType.Factor),
			new SqlParameter("@Title", roleType.Title)
		};
		roleType.RoleTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("RoleType_Insert", CommandType.StoredProcedure, parametersRoleType));
		return roleType.RoleTypeID;
	}

	public bool Update(RoleType roleType)
	{
		SqlParameter[] parametersRoleType = new SqlParameter[]
		{
			new SqlParameter("@RoleTypeID", roleType.RoleTypeID),
			new SqlParameter("@Factor", roleType.Factor),
			new SqlParameter("@Title", roleType.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("RoleType_Update", CommandType.StoredProcedure, parametersRoleType);
	}

	public bool Delete(int roleTypeID)
	{
		SqlParameter[] parametersRoleType = new SqlParameter[]
		{
			new SqlParameter("@RoleTypeID", roleTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("RoleType_Delete", CommandType.StoredProcedure, parametersRoleType);
	}

	public RoleType GetDetails(int roleTypeID)
	{
		RoleType roleType = new RoleType();

		SqlParameter[] parametersRoleType = new SqlParameter[]
		{
			new SqlParameter("@RoleTypeID", roleTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("RoleType_GetDetails", CommandType.StoredProcedure, parametersRoleType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				roleType.RoleTypeID = (row["RoleTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RoleTypeID"]) : 0 ;
				roleType.Factor = (row["Factor"] != DBNull.Value) ? Convert.ToDecimal(row["Factor"]) : 0 ;
				roleType.Title = row["Title"].ToString();
			}
		}

		return roleType;
	}

	public List<RoleType> GetListAll()
	{
		List<RoleType> listRoleType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("RoleType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listRoleType = new List<RoleType>();

				foreach (DataRow row in table.Rows)
				{
					RoleType roleType = new RoleType();
					roleType.RoleTypeID = (row["RoleTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RoleTypeID"]) : 0 ;
					roleType.Factor = (row["Factor"] != DBNull.Value) ? Convert.ToDecimal(row["Factor"]) : 0 ;
					roleType.Title = row["Title"].ToString();
					listRoleType.Add(roleType);
				}
			}
		}

		return listRoleType;
	}

	public bool Exists(int roleTypeID)
	{
		SqlParameter[] parametersRoleType = new SqlParameter[]
		{
			new SqlParameter("@RoleTypeID", roleTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("RoleType_Exists", CommandType.StoredProcedure, parametersRoleType)>0);
	}

	public bool Exists(RoleType roleType)
	{
		SqlParameter[] parametersRoleType = new SqlParameter[]
		{
			new SqlParameter("@RoleTypeID", roleType.RoleTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("RoleType_Exists", CommandType.StoredProcedure, parametersRoleType)>0);
	}

	public List<RoleType> SearchLike(RoleType roleType)
	{
		List<RoleType> listRoleType = new List<RoleType>();


		SqlParameter[] parametersRoleType = new SqlParameter[]
		{
			new SqlParameter("@RoleTypeID", roleType.RoleTypeID),
			new SqlParameter("@Factor", roleType.Factor),
			new SqlParameter("@Title", roleType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("RoleType_SearchLike", CommandType.StoredProcedure, parametersRoleType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					RoleType tmpRoleType = new RoleType();
					tmpRoleType.RoleTypeID = (row["RoleTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RoleTypeID"]) : 0 ;
					tmpRoleType.Factor = (row["Factor"] != DBNull.Value) ? Convert.ToDecimal(row["Factor"]) : 0 ;
					tmpRoleType.Title = row["Title"].ToString();

					listRoleType.Add(tmpRoleType);
				}
			}
		}

		return listRoleType;
	}

}
}
