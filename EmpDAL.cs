using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Properties;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class EmpDAL
    {
        public int InsertEmpDB(EmpListDTO objEmpListDTO)
        {
            SqlConnection cn = null;
            SqlCommand cmd = null;
            SqlDataAdapter da = null;
            DataTable dt = null;
            try
            {
                cn = new SqlConnection("Data Source=Raghu;Initial Catalog=RevalDB;User Id=sa;Password=1234");
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                cmd = new SqlCommand("uspInsertEmp", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmployeeName", objEmpListDTO.EmployeeName);
                cmd.Parameters.AddWithValue("@Email", objEmpListDTO.Email);
                cmd.Parameters.AddWithValue("@Mobile", objEmpListDTO.Mobile);

                cmd.Parameters.AddWithValue("@Designation", objEmpListDTO.Designation);
                if (objEmpListDTO.Designation == null || objEmpListDTO.Designation == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@Designation", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Designation", objEmpListDTO.Designation);
                }
                //cmd.Parameters.AddWithValue("@Designation", objEmpListDTO.Designation);
                cmd.Parameters.AddWithValue("@Qualification", objEmpListDTO.Qualification);
                if (objEmpListDTO.Qualification == null || objEmpListDTO.Qualification == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@Qualification", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Qualification", objEmpListDTO.Designation);
                }
                //cmd.Parameters.AddWithValue("@Qualification", objEmpListDTO.Qualification);
                cmd.Parameters.AddWithValue("@Manager", objEmpListDTO.Manager);
                if (objEmpListDTO.Manager == null || objEmpListDTO.Manager == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@Manager", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Manager", objEmpListDTO.Designation);
                }
                //cmd.Parameters.AddWithValue("@Manager", objEmpListDTO.Manager);
                cmd.Parameters.AddWithValue("@Salary", objEmpListDTO.Salary);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
    }
}
