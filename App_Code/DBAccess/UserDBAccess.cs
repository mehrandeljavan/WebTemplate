using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.Models;

namespace Rewards.DBA
{
public class UserDBAccess
{
	EmployeeDBAccess employeeDBAccess = new EmployeeDBAccess();


	public Int64 Insert(User user)
	{
		if (!employeeDBAccess.Exists(user))
			user.NationalCode = employeeDBAccess.Insert(user);

		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", (user.NationalCode > 0) ? user.NationalCode : (object)DBNull.Value),
			new SqlParameter("@Password", (user.Password != null) ? user.Password : (object)DBNull.Value),
			new SqlParameter("@LastPassChangeDate", (user.LastPassChangeDate != null) ? user.LastPassChangeDate : (object)DBNull.Value),
			new SqlParameter("@IsActiveUser", (user.IsActiveUser != null) ? user.IsActiveUser : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("User_Insert", CommandType.StoredProcedure, parametersUser);
	}

	public bool Update(User user)
	{
		employeeDBAccess.Update(user);

		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", user.NationalCode),
			new SqlParameter("@Password", (user.Password != null) ? user.Password : (object)DBNull.Value),
			new SqlParameter("@LastPassChangeDate", (user.LastPassChangeDate != null) ? user.LastPassChangeDate : (object)DBNull.Value),
			new SqlParameter("@IsActiveUser", (user.IsActiveUser != null) ? user.IsActiveUser : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("User_Update", CommandType.StoredProcedure, parametersUser);
	}

	public bool Delete(Int64 nationalCode)
	{
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", nationalCode)
		};
		return SqlDBHelper.ExecuteNonQuery("User_Delete", CommandType.StoredProcedure, parametersUser);
	}

	public User GetDetails(Int64 nationalCode)
	{
		User user = new User();

		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", nationalCode)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("User_GetDetails", CommandType.StoredProcedure, parametersUser))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				user.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
				user.Password = row["Password"].ToString();
				user.LastPassChangeDate = row["LastPassChangeDate"].ToString();
				user.IsActiveUser = (row["IsActiveUser"] != DBNull.Value) ? Convert.ToBoolean((row["IsActiveUser"].ToString() == "1" || row["IsActiveUser"].ToString().ToLower() == "true" ) ? true : false) : false ;

				Employee employee = employeeDBAccess.GetDetails(user.NationalCode);
				user.NationalCode = employee.NationalCode;
				user.ContractTypeIDTitle = employee.ContractTypeIDTitle;
				user.RoleTypeIDTitle = employee.RoleTypeIDTitle;
				user.FullName = employee.FullName;
				user.DepartmentIDTitle = employee.DepartmentIDTitle;
				user.RoleTypeIDFactor = employee.RoleTypeIDFactor;
				user.PersonalCode = employee.PersonalCode;
				user.FirstName = employee.FirstName;
				user.LastName = employee.LastName;
				user.AccountNumber = employee.AccountNumber;
				user.ContractTypeID = employee.ContractTypeID;
				user.RoleTypeID = employee.RoleTypeID;
				user.DepartmentID = employee.DepartmentID;
				user.IsActiveEmployee = employee.IsActiveEmployee;
			}
		}

		return user;
	}

	public List<User> GetListAll()
	{
		List<User> listUser = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("User_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listUser = new List<User>();

				foreach (DataRow row in table.Rows)
				{
					User user = new User();
					user.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
					user.Password = row["Password"].ToString();
					user.LastPassChangeDate = row["LastPassChangeDate"].ToString();
				user.IsActiveUser = (row["IsActiveUser"] != DBNull.Value) ? Convert.ToBoolean((row["IsActiveUser"].ToString() == "1" || row["IsActiveUser"].ToString().ToLower() == "true" ) ? true : false) : false ;

					Employee employee = employeeDBAccess.GetDetails(user.NationalCode);
					user.ContractTypeIDTitle = employee.ContractTypeIDTitle;
					user.RoleTypeIDTitle = employee.RoleTypeIDTitle;
					user.FullName = employee.FullName;
					user.DepartmentIDTitle = employee.DepartmentIDTitle;
					user.RoleTypeIDFactor = employee.RoleTypeIDFactor;
					user.PersonalCode = employee.PersonalCode;
					user.FirstName = employee.FirstName;
					user.LastName = employee.LastName;
					user.AccountNumber = employee.AccountNumber;
					user.ContractTypeID = employee.ContractTypeID;
					user.RoleTypeID = employee.RoleTypeID;
					user.DepartmentID = employee.DepartmentID;
					user.IsActiveEmployee = employee.IsActiveEmployee;
					listUser.Add(user);
				}
			}
		}

		return listUser;
	}

	public bool Exists(Int64 nationalCode)
	{
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", nationalCode)
		};
		return (SqlDBHelper.ExecuteScalar("User_Exists", CommandType.StoredProcedure, parametersUser)>0);
	}

	public bool Exists(User user)
	{
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", user.NationalCode)
		};
		return (SqlDBHelper.ExecuteScalar("User_Exists", CommandType.StoredProcedure, parametersUser)>0);
	}

	public List<User> SearchLike(User user)
	{
		List<User> listUser = new List<User>();


		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", user.NationalCode),
			new SqlParameter("@Password", user.Password),
			new SqlParameter("@LastPassChangeDate", user.LastPassChangeDate),
			new SqlParameter("@IsActiveUser", user.IsActiveUser),

			new SqlParameter("@ContractTypeIDTitle", user.ContractTypeIDTitle),
			new SqlParameter("@RoleTypeIDTitle", user.RoleTypeIDTitle),
			new SqlParameter("@FullName", user.FullName),
			new SqlParameter("@DepartmentIDTitle", user.DepartmentIDTitle),
			new SqlParameter("@RoleTypeIDFactor", user.RoleTypeIDFactor),
			new SqlParameter("@PersonalCode", user.PersonalCode),
			new SqlParameter("@FirstName", user.FirstName),
			new SqlParameter("@LastName", user.LastName),
			new SqlParameter("@AccountNumber", user.AccountNumber),
			new SqlParameter("@ContractTypeID", user.ContractTypeID),
			new SqlParameter("@RoleTypeID", user.RoleTypeID),
			new SqlParameter("@DepartmentID", user.DepartmentID),
			new SqlParameter("@IsActiveEmployee", user.IsActiveEmployee)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("User_SearchLike", CommandType.StoredProcedure, parametersUser))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					User tmpUser = new User();
					tmpUser.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
					tmpUser.Password = row["Password"].ToString();
					tmpUser.LastPassChangeDate = row["LastPassChangeDate"].ToString();
					tmpUser.IsActiveUser = (row["IsActiveUser"] != DBNull.Value) ? Convert.ToBoolean((row["IsActiveUser"].ToString() == "1" || row["IsActiveUser"].ToString().ToLower() == "true" ) ? true : false) : false ;

					Employee employee = employeeDBAccess.GetDetails(tmpUser.NationalCode);
					tmpUser.NationalCode = employee.NationalCode;
					tmpUser.ContractTypeIDTitle = employee.ContractTypeIDTitle;
					tmpUser.RoleTypeIDTitle = employee.RoleTypeIDTitle;
					tmpUser.FullName = employee.FullName;
					tmpUser.DepartmentIDTitle = employee.DepartmentIDTitle;
					tmpUser.RoleTypeIDFactor = employee.RoleTypeIDFactor;
					tmpUser.PersonalCode = employee.PersonalCode;
					tmpUser.FirstName = employee.FirstName;
					tmpUser.LastName = employee.LastName;
					tmpUser.AccountNumber = employee.AccountNumber;
					tmpUser.ContractTypeID = employee.ContractTypeID;
					tmpUser.RoleTypeID = employee.RoleTypeID;
					tmpUser.DepartmentID = employee.DepartmentID;
					tmpUser.IsActiveEmployee = employee.IsActiveEmployee;

					listUser.Add(tmpUser);
				}
			}
		}

		return listUser;
	}

}
}
