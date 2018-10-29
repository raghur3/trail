using BusinessLogic;
using Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Reval
{
    public partial class RegisterEmp : System.Web.UI.Page
    {
        SqlConnection cn = null;
        SqlCommand cmd = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=raghu;Initial Catalog=realtime;User Id=sa;Password=1234");
            //InsertUser();
        }
        public void InsertUser()
        {
            EmpListDTO objEmpListDTO = null;
            EmpBAL objEmpBAL = null;
            objEmpListDTO = new EmpListDTO();
            objEmpBAL = new EmpBAL();
            try
            {
                objEmpListDTO.EmployeeName = txtEmployeeName.Text.Trim();
                objEmpListDTO.Mobile = txtMobile.Text.Trim();
                objEmpListDTO.Salary = txtSalary.Text.Trim();
                objEmpListDTO.Designation = DDLDesignation.SelectedItem.Value;
                objEmpListDTO.Qualification = DDLQualification.SelectedItem.Value;
            }
            catch (Exception EX)
            {
                throw EX;
            }
        }
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            InsertUser();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}