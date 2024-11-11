using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
namespace studentManage
{
    internal class scoreClass
    {
        public string conString = "Data Source=DESKTOP-TI62AGU;Initial Catalog=StudentData;Integrated Security=True;Encrypt=False";
        public DataTable getScoreList()
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();


            string query = "SELECT * FROM SCORE_TABLE";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);


            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable getScoreList(string qry,int id)
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();


            string query = qry;
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);


            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool checkScore(int id, string cname) {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            string query = "SELECT COUNT(*) FROM SCORE_TABLE WHERE student_id=@id AND coursename=@cn";
            
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@cn", cname);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return count<1;



        }

        public bool insertScore(int id, string cname, float score, string desc)
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = "INSERT INTO SCORE_TABLE VALUES(@id,@cn,@sc,@dc)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@cn", cname);
                cmd.Parameters.AddWithValue("@sc", score);
                cmd.Parameters.AddWithValue("@dc", desc);

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
