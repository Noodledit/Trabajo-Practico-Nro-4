using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace TP4_Grupo12
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private const string connectionString = @"Server=DESKTOP-JNJ0TAL\SQLEXPRESS;DataBase=Viajes;Integrated Security=True";
        private string sqlQueryProvincias = "SELECT * FROM Provincias";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                //conexion a la base de datos en sql server
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                // Consulta SQL que se desee ejecutar 
                SqlCommand sqlCommand = new SqlCommand(sqlQueryProvincias, connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                // Agregamos las opciones por defecto a los ddl con un ListItem

                ListItem porDefecto = new ListItem("-- Seleccionar --" , "0");

                ddlProvincia1.Items.Add(porDefecto);

                ddlLocalidad1.Items.Add(porDefecto);

                ddlProvincia2.Items.Add(porDefecto);

                ddlLocalidad2.Items.Add(porDefecto);

                // Llenamos el ddl con los datos de la base de datos
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = new SqlCommand(sqlQueryProvincias, connection);

                connection.Close();

            }
        }
    }
}