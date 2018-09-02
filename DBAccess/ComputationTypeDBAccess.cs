using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.Models;

namespace Rewards.DBA
{
public class ComputationTypeDBAccess
{

	DepartmentDBAccess departmentDBAccess = new DepartmentDBAccess();

	public List<Department> GetListDepartment(int computationTypeID)
	{
		List<Department> listDepartment = new List<Department>() { };
		SqlParameter[] parametersComputationType = new SqlParameter[]
		{
			new SqlParameter("@ComputationTypeID", computationTypeID)
		};

		//Lets get the list of Department records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Department_GetList_UseInComputationType", CommandType.StoredProcedure, parametersComputationType))
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
	public Int64 Insert(ComputationType computationType)
	{
		SqlParameter[] parametersComputationType = new SqlParameter[]
		{
			new SqlParameter("@Title", computationType.Title)
		};
		computationType.ComputationTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("ComputationType_Insert", CommandType.StoredProcedure, parametersComputationType));
		return computationType.ComputationTypeID;
	}

	public bool Update(ComputationType computationType)
	{
		SqlParameter[] parametersComputationType = new SqlParameter[]
		{
			new SqlParameter("@ComputationTypeID", computationType.ComputationTypeID),
			new SqlParameter("@Title", computationType.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("ComputationType_Update", CommandType.StoredProcedure, parametersComputationType);
	}

	public bool Delete(int computationTypeID)
	{
		SqlParameter[] parametersComputationType = new SqlParameter[]
		{
			new SqlParameter("@ComputationTypeID", computationTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("ComputationType_Delete", CommandType.StoredProcedure, parametersComputationType);
	}

	public ComputationType GetDetails(int computationTypeID)
	{
		ComputationType computationType = new ComputationType();

		SqlParameter[] parametersComputationType = new SqlParameter[]
		{
			new SqlParameter("@ComputationTypeID", computationTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ComputationType_GetDetails", CommandType.StoredProcedure, parametersComputationType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				computationType.ComputationTypeID = (row["ComputationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ComputationTypeID"]) : 0 ;
				computationType.Title = row["Title"].ToString();
			}
		}

		return computationType;
	}

	public List<ComputationType> GetListAll()
	{
		List<ComputationType> listComputationType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("ComputationType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listComputationType = new List<ComputationType>();

				foreach (DataRow row in table.Rows)
				{
					ComputationType computationType = new ComputationType();
					computationType.ComputationTypeID = (row["ComputationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ComputationTypeID"]) : 0 ;
					computationType.Title = row["Title"].ToString();
					listComputationType.Add(computationType);
				}
			}
		}

		return listComputationType;
	}

	public bool Exists(int computationTypeID)
	{
		SqlParameter[] parametersComputationType = new SqlParameter[]
		{
			new SqlParameter("@ComputationTypeID", computationTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("ComputationType_Exists", CommandType.StoredProcedure, parametersComputationType)>0);
	}

	public bool Exists(ComputationType computationType)
	{
		SqlParameter[] parametersComputationType = new SqlParameter[]
		{
			new SqlParameter("@ComputationTypeID", computationType.ComputationTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("ComputationType_Exists", CommandType.StoredProcedure, parametersComputationType)>0);
	}

	public List<ComputationType> SearchLike(ComputationType computationType)
	{
		List<ComputationType> listComputationType = new List<ComputationType>();


		SqlParameter[] parametersComputationType = new SqlParameter[]
		{
			new SqlParameter("@ComputationTypeID", computationType.ComputationTypeID),
			new SqlParameter("@Title", computationType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ComputationType_SearchLike", CommandType.StoredProcedure, parametersComputationType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					ComputationType tmpComputationType = new ComputationType();
					tmpComputationType.ComputationTypeID = (row["ComputationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ComputationTypeID"]) : 0 ;
					tmpComputationType.Title = row["Title"].ToString();

					listComputationType.Add(tmpComputationType);
				}
			}
		}

		return listComputationType;
	}

}
}
