using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.AxHost;
using System.Net;
using System.Xml.Linq;
namespace studentManage
{
    internal class courseClass
    {
        public string conString = "Data Source=DESKTOP-TI62AGU;Initial Catalog=StudentData;Integrated Security=True;Encrypt=False";

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
