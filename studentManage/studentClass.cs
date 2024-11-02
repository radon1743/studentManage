using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace studentManage
{
    internal class studentClass
    {
        public string conString = "Data Source=DESKTOP-TI62AGU;Initial Catalog=StudentData;Integrated Security=True;Encrypt=False";
        public bool insertStudents(string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] image)
        {


            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "INSERT INTO STUDENT_TABLE(firstname,lastname,bdate,gender,phone,address,image) VALUES(@fn,@ln,@bd,@gn,@ph,@ad,@img)";


                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fn", fname);
                cmd.Parameters.AddWithValue("@ln", lname);
                cmd.Parameters.AddWithValue("@bd", bdate);
                cmd.Parameters.AddWithValue("@gn", gender);
                cmd.Parameters.AddWithValue("@ph", phone);
                cmd.Parameters.AddWithValue("@ad", address);
                cmd.Parameters.AddWithValue("@img", image);


                if (cmd.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {

                    return false;
                }
            }

            else
            {
                return false;
            }
        }

        public DataTable getStudentList()
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();


            string query = "SELECT * FROM STUDENT_TABLE";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);


            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public string exeCount(string query)
        {
            string conString = "Data Source=DESKTOP-TI62AGU;Initial Catalog=StudentData;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);
            string count = cmd.ExecuteScalar().ToString();
            conn.Close();
            return count;

        }
        public string totalStudents()
        {
            return exeCount("SELECT COUNT(*) FROM STUDENT_TABLE");
        }

        public string maleStudents()
        {
            return exeCount("SELECT COUNT(*) FROM STUDENT_TABLE WHERE GENDER = 'Male'");
        }
        public string femaleStudents()
        {
            return exeCount("SELECT COUNT(*) FROM STUDENT_TABLE WHERE GENDER = 'Female'");
        }

        
        public DataTable searchStudent(string searchdata)
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();


            string query = "SELECT * FROM STUDENT_TABLE WHERE " +
                            "address LIKE '%" + searchdata + "%' " +
                            "OR firstname LIKE '%" + searchdata + "%' " +
                            "OR lastname LIKE '%" + searchdata + "%'";


            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);


            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
