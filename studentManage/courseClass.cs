using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.AxHost;
using System.Net;
using System.Xml.Linq;
using System.Data;
namespace studentManage
{
    internal class courseClass
    {


        public string conString = "Data Source=DESKTOP-TI62AGU;Initial Catalog=StudentData;Integrated Security=True;Encrypt=False";

        public DataTable getCourseList()
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();


            string query = "SELECT * FROM COURSE_TABLE";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);


            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable searchCourse(string searchdata)
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();


            string query = "SELECT * FROM COURSE_TABLE WHERE " +
                            "coursename LIKE '%" + searchdata + "%' " +
                            "OR coursedesc LIKE '%" + searchdata + "%'";


            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);


            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool updateCourse(int id, string cname, int chours, string desc, string opt) {

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "UPDATE COURSE_TABLE SET " +
                                "coursename = @cn" +
                                ",coursehours = @ch" +
                                ",coursedesc = @cd" +
                                ",optional = @op" +
                                " WHERE courseid = @id";


                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@cn", cname);
                cmd.Parameters.AddWithValue("@ch", chours);
                cmd.Parameters.AddWithValue("@cd", desc);
                cmd.Parameters.AddWithValue("@op", opt);


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
        public DataTable getCourselist_opt(string query)
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();


            //string query = "SELECT * FROM COURSE_TABLE";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);


            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool deleteCourse(int id)
        {

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "DELETE FROM COURSE_TABLE " +
                                "WHERE courseid = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

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
        public bool insertCourse(string cname, int chours, string desc, string opt) {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "INSERT INTO COURSE_TABLE(coursename,coursehours,coursedesc,optional) VALUES(@cn,@ch,@cd,@op)";


                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cn", cname);
                cmd.Parameters.AddWithValue("@ch", chours);
                cmd.Parameters.AddWithValue("@cd", desc);
                cmd.Parameters.AddWithValue("@op", opt);
               
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
    }
}
