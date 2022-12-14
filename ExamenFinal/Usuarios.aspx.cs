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
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["ExamenFinalConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM Usuarios"))
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
        public void IngresarUsuarios()
        {
            SqlConnection Conn = new SqlConnection();
            using (Conn = DboConn.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IngresarUsuarios ";
                cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = TcorreoUsu.Text.Trim();
                cmd.Parameters.Add("@Clave", SqlDbType.VarChar).Value = Tclave.Text.Trim();
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Tnombre.Text.Trim();
                cmd.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = Tapellido.Text.Trim();

                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
            }


        }

        public void BorrarUsuarios()
        {
            SqlConnection Conn = new SqlConnection();
            using (Conn = DboConn.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BorrarUsuarios ";
                cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = TcorreoUsu.Text.Trim();

                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
            }


        }

        public void ActualizarUsuarios()
        {
            SqlConnection Conn = new SqlConnection();
            using (Conn = DboConn.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ActualizarUsuarios ";
                cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = TcorreoUsu.Text.Trim();
                cmd.Parameters.Add("@Clave", SqlDbType.VarChar).Value = Tclave.Text.Trim();
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Tnombre.Text.Trim();
                cmd.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = Tapellido.Text.Trim();

                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            IngresarUsuarios();
            LlenarGrid();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            BorrarUsuarios();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ActualizarUsuarios();
            LlenarGrid();
        }
    }
        
    }

    
