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
        // Cambiar el campo const a readonly para evitar el error ENC0011  
        private string connectionString = @"Server=(local);DataBase=Viajes;Integrated Security=True";  //  Cadena de conexion valen:  Data Source=DESKTOP-MHN7D94\\SQLEXPRESS;Initial Catalog=Viajes;Integrated Security=True
        private string sqlQueryProvincias = "SELECT * FROM Provincias";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //conexion a la base de datos en sql server
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                // Consulta SQL que se desee ejecutar 
                SqlCommand sqlCommand = new SqlCommand(sqlQueryProvincias, connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                // Agregamos las opciones por defecto a los ddl con un ListItem

                ListItem porDefecto = new ListItem("-- Seleccionar --", "0");

                ddlProvincia1.Items.Add(porDefecto);
                ddlLocalidad1.Items.Add(porDefecto);
                ddlProvincia2.Items.Add(porDefecto);
                ddlLocalidad2.Items.Add(porDefecto);

                // Llenamos el ddl con los datos de la base de datos
                ddlProvincia1.DataSource = sqlDataReader;
                ddlProvincia1.DataTextField = "NombreProvincia";
                ddlProvincia1.DataValueField = "IdProvincia";
                ddlProvincia1.DataBind();

                sqlDataReader.Close();
                connection.Close();
            }
        }

        protected void ddlProvincia1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //conexion a la base de datos en sql server
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Localidades WHERE IdProvincia = @IdProvincia", connection);
            sqlCommand.Parameters.AddWithValue("@IdProvincia", ddlProvincia1.SelectedValue);
            connection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            ddlLocalidad1.DataSource = sqlDataReader;
            ddlLocalidad1.DataTextField = "NombreLocalidad";
            ddlLocalidad1.DataValueField = "IdLocalidad";
            //Llenar el ddl Localidad Inicio con los datos cargados. 
            ddlLocalidad1.DataBind();
            connection.Close();

            // Llenar el DDL PROVINCIAS FINAL con las provincias que no fueron seleccionadas en el DDL PROVINCIAS INICIO. 
            SqlConnection connection2 = new SqlConnection(connectionString); 
            SqlCommand sqlCommand2 = new SqlCommand("SELECT * FROM Provincias WHERE IdProvincia != @IdProvincia", connection2);
            sqlCommand2.Parameters.AddWithValue("@IdProvincia", ddlProvincia1.SelectedValue);
           
            connection2.Open();
            
            SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
            
            ddlProvincia2.DataSource = sqlDataReader2;
            ddlProvincia2.DataTextField = "NombreProvincia";
            ddlProvincia2.DataValueField = "IdProvincia";
            ddlProvincia2.DataBind();


            sqlDataReader.Close();
            connection2.Close();


        }
    }
}