using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace studentManage
{
    internal class admin
    {
        public string conString = "Data Source=DESKTOP-TI62AGU;Initial Catalog=StudentData;Integrated Security=True;Encrypt=False";
        public bool checkIdPass(int id, string pass)
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();


            string query = "SELECT COUNT(*) FROM ADMIN_TABLE WHERE id = @id AND ps = @ps";


            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id",id);
            cmd.Parameters.AddWithValue("@ps",pass);

            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            conn.Close();
            return count==1;
        }
    }
}
