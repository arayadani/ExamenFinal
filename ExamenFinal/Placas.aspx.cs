using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenFinal
{
    public partial class Placas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["ExamenFinalConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM Placa"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
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
        }

        public void IngresarPlaca()
        {
            SqlConnection Conn = new SqlConnection();
            using (Conn = DboConn.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IngresarPlaca ";
                cmd.Parameters.Add("@NumPlaca", SqlDbType.VarChar).Value = Tnumplaca.Text.Trim();
                cmd.Parameters.Add("@IdUsuario", SqlDbType.VarChar).Value = Tid.Text.Trim();
                cmd.Parameters.Add("@Monto", SqlDbType.VarChar).Value = Tmonto.Text.Trim();
                

                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
            }


        }
        public void BorrarPlaca()
        {
            SqlConnection Conn = new SqlConnection();
            using (Conn = DboConn.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BorrarPlacas ";
                cmd.Parameters.Add("@NumPlaca", SqlDbType.VarChar).Value = Tnumplaca.Text.Trim();

                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
            }


        }

        public void ActualizarPlaca()
        {
            SqlConnection Conn = new SqlConnection();
            using (Conn = DboConn.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ActualizarPlacas ";
                cmd.Parameters.Add("@NumPlaca", SqlDbType.VarChar).Value = Tnumplaca.Text.Trim();
                cmd.Parameters.Add("@IdUsuario", SqlDbType.VarChar).Value = Tid.Text.Trim();
                cmd.Parameters.Add("@Monto", SqlDbType.VarChar).Value = Tmonto.Text.Trim();

                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
            }


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            IngresarPlaca();
            LlenarGrid();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            BorrarPlaca();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ActualizarPlaca();
            LlenarGrid();
        }
    }
}