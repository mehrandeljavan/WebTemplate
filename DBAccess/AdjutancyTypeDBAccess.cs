using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.Models;

namespace Rewards.DBA
{
public class AdjutancyTypeDBAccess
{

	DepartmentDBAccess departmentDBAccess = new DepartmentDBAccess();

	DepartmentMonthlyInformationDBAccess departmentMonthlyInformationDBAccess = new DepartmentMonthlyInformationDBAccess();
	public List<DepartmentMonthlyInformation> GetListDepartmentMonthlyInformation(int adjutancyTypeID)
	{
		List<DepartmentMonthlyInformation> listDepartmentMonthlyInformation = new List<DepartmentMonthlyInformation>() { };
		SqlParameter[] parametersAdjutancyType = new SqlParameter[]
		{
			new SqlParameter("@AdjutancyTypeID", adjutancyTypeID)
		};

		//Lets get the list of DepartmentMonthlyInformation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("AdjutancyType_GetList_DepartmentMonthlyInformation", CommandType.StoredProcedure, parametersAdjutancyType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of DepartmentMonthlyInformation
				listDepartmentMonthlyInformation = new List<DepartmentMonthlyInformation>();

				//Now lets populate the DepartmentMonthlyInformation details into the list of DepartmentMonthlyInformations
				foreach (DataRow row in table.Rows)
				{
					DepartmentMonthlyInformation departmentMonthlyInformation = departmentMonthlyInformationDBAccess.GetDetails(Convert.ToInt32(row["YearTypeID"]), Convert.ToInt32(row["MonthTypeID"]), Convert.ToInt32(row["DepartmentID"]));
					listDepartmentMonthlyInformation.Add(departmentMonthlyInformation);
				}
			}
		}

		return listDepartmentMonthlyInformation;
	}

	public List<Department> GetListDepartment(int adjutancyTypeID)
	{
		List<Department> listDepartment = new List<Department>() { };
		SqlParameter[] parametersAdjutancyType = new SqlParameter[]
		{
			new SqlParameter("@AdjutancyTypeID", adjutancyTypeID)
		};

		//Lets get the list of Department records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Department_GetList_UseInAdjutancyType", CommandType.StoredProcedure, parametersAdjutancyType))
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
	public Int64 Insert(AdjutancyType adjutancyType)
	{
		SqlParameter[] parametersAdjutancyType = new SqlParameter[]
		{
			new SqlParameter("@AdjutantNationalCode", (adjutancyType.AdjutantNationalCode != null) ? adjutancyType.AdjutantNationalCode : (object)DBNull.Value),
			new SqlParameter("@Title", (adjutancyType.Title != null) ? adjutancyType.Title : (object)DBNull.Value)
		};
		adjutancyType.AdjutancyTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("AdjutancyType_Insert", CommandType.StoredProcedure, parametersAdjutancyType));
		return adjutancyType.AdjutancyTypeID;
	}

	public bool Update(AdjutancyType adjutancyType)
	{
		SqlParameter[] parametersAdjutancyType = new SqlParameter[]
		{
			new SqlParameter("@AdjutancyTypeID", adjutancyType.AdjutancyTypeID),
			new SqlParameter("@AdjutantNationalCode", (adjutancyType.AdjutantNationalCode != null) ? adjutancyType.AdjutantNationalCode : (object)DBNull.Value),
			new SqlParameter("@Title", (adjutancyType.Title != null) ? adjutancyType.Title : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("AdjutancyType_Update", CommandType.StoredProcedure, parametersAdjutancyType);
	}

	public bool Delete(int adjutancyTypeID)
	{
		SqlParameter[] parametersAdjutancyType = new SqlParameter[]
		{
			new SqlParameter("@AdjutancyTypeID", adjutancyTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("AdjutancyType_Delete", CommandType.StoredProcedure, parametersAdjutancyType);
	}

	public AdjutancyType GetDetails(int adjutancyTypeID)
	{
		AdjutancyType adjutancyType = new AdjutancyType();

		SqlParameter[] parametersAdjutancyType = new SqlParameter[]
		{
			new SqlParameter("@AdjutancyTypeID", adjutancyTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("AdjutancyType_GetDetails", CommandType.StoredProcedure, parametersAdjutancyType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				adjutancyType.AdjutancyTypeID = (row["AdjutancyTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AdjutancyTypeID"]) : 0 ;
				adjutancyType.AdjutantFullName = row["AdjutantFullName"].ToString();
				adjutancyType.AdjutantNationalCode = (row["AdjutantNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["AdjutantNationalCode"]) : 0 ;
				adjutancyType.Title = row["Title"].ToString();
			}
		}

		return adjutancyType;
	}

	public List<AdjutancyType> GetListAll()
	{
		List<AdjutancyType> listAdjutancyType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("AdjutancyType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listAdjutancyType = new List<AdjutancyType>();

				foreach (DataRow row in table.Rows)
				{
					AdjutancyType adjutancyType = new AdjutancyType();
					adjutancyType.AdjutancyTypeID = (row["AdjutancyTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AdjutancyTypeID"]) : 0 ;
					adjutancyType.AdjutantFullName = row["AdjutantFullName"].ToString();
					adjutancyType.AdjutantNationalCode = (row["AdjutantNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["AdjutantNationalCode"]) : 0 ;
					adjutancyType.Title = row["Title"].ToString();
					listAdjutancyType.Add(adjutancyType);
				}
			}
		}

		return listAdjutancyType;
	}

	public bool Exists(int adjutancyTypeID)
	{
		SqlParameter[] parametersAdjutancyType = new SqlParameter[]
		{
			new SqlParameter("@AdjutancyTypeID", adjutancyTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("AdjutancyType_Exists", CommandType.StoredProcedure, parametersAdjutancyType)>0);
	}

	public bool Exists(AdjutancyType adjutancyType)
	{
		SqlParameter[] parametersAdjutancyType = new SqlParameter[]
		{
			new SqlParameter("@AdjutancyTypeID", adjutancyType.AdjutancyTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("AdjutancyType_Exists", CommandType.StoredProcedure, parametersAdjutancyType)>0);
	}

	public List<AdjutancyType> SearchLike(AdjutancyType adjutancyType)
	{
		List<AdjutancyType> listAdjutancyType = new List<AdjutancyType>();


		SqlParameter[] parametersAdjutancyType = new SqlParameter[]
		{
			new SqlParameter("@AdjutancyTypeID", adjutancyType.AdjutancyTypeID),
			new SqlParameter("@AdjutantFullName", adjutancyType.AdjutantFullName),
			new SqlParameter("@AdjutantNationalCode", adjutancyType.AdjutantNationalCode),
			new SqlParameter("@Title", adjutancyType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("AdjutancyType_SearchLike", CommandType.StoredProcedure, parametersAdjutancyType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					AdjutancyType tmpAdjutancyType = new AdjutancyType();
					tmpAdjutancyType.AdjutancyTypeID = (row["AdjutancyTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AdjutancyTypeID"]) : 0 ;
					tmpAdjutancyType.AdjutantFullName = row["AdjutantFullName"].ToString();
					tmpAdjutancyType.AdjutantNationalCode = (row["AdjutantNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["AdjutantNationalCode"]) : 0 ;
					tmpAdjutancyType.Title = row["Title"].ToString();

					listAdjutancyType.Add(tmpAdjutancyType);
				}
			}
		}

		return listAdjutancyType;
	}

}
}
