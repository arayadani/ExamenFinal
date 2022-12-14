using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenFinal
{
    public partial class Reportes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void LlenarGrid()
        {
            SqlConnection Conn = new SqlConnection();
            using (Conn = DboConn.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Reporte";
                cmd.Parameters.Add("@NumPlaca", SqlDbType.VarChar).Value = TextBox1.Text.Trim();
                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LlenarGrid();
        }
    }
}