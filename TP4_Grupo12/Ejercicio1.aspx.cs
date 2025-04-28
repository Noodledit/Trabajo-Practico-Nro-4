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
        private string connectionString = "Data Source=DESKTOP-MHN7D94\\SQLEXPRESS;Initial Catalog=Viajes;Integrated Security=True";
        // @"Server=(local);DataBase=Viajes;Integrated Security=True"
        //  Cadena de conexion valen:  Data Source=DESKTOP-MHN7D94\\SQLEXPRESS;Initial Catalog=Viajes;Integrated Security=True
        private string sqlQueryProvincias = "SELECT * FROM Provincias";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Conexión a la base de datos
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                // Consulta SQL
                SqlCommand sqlCommand = new SqlCommand(sqlQueryProvincias, connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                // Llenar ddlProvincia1 con datos de la base de datos
                ddlProvincia1.DataSource = sqlDataReader;
                ddlProvincia1.DataTextField = "NombreProvincia";
                ddlProvincia1.DataValueField = "IdProvincia";
                ddlProvincia1.DataBind();

                // Agregar la opción por defecto solo una vez
                ddlProvincia1.Items.Insert(0, new ListItem("-- Seleccionar --", "0"));
                ddlProvincia1.SelectedIndex = 0;

                // Agregar la opción por defecto a los demás DropDownList
                ddlLocalidad1.Items.Insert(0, new ListItem("-- Seleccionar --", "0"));
                ddlLocalidad1.SelectedIndex = 0;

                ddlProvincia2.Items.Insert(0, new ListItem("-- Seleccionar --", "0"));
                ddlProvincia2.SelectedIndex = 0;

                ddlLocalidad2.Items.Insert(0, new ListItem("-- Seleccionar --", "0"));
                ddlLocalidad2.SelectedIndex = 0;

                sqlDataReader.Close();
                connection.Close();
            }
        }

        protected void ddlProvincia1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Conexión y lógica para ddlLocalidad1
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Localidades WHERE IdProvincia = @IdProvincia", connection);
            sqlCommand.Parameters.AddWithValue("@IdProvincia", ddlProvincia1.SelectedValue);
            connection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            ddlLocalidad1.Items.Clear();
            ddlLocalidad1.DataSource = sqlDataReader;
            ddlLocalidad1.DataTextField = "NombreLocalidad";
            ddlLocalidad1.DataValueField = "IdLocalidad";
            ddlLocalidad1.DataBind();

            // Agregar la opción por defecto solo una vez
            ddlLocalidad1.Items.Insert(0, new ListItem("-- Seleccionar --", "0"));
            ddlLocalidad1.SelectedIndex = 0;

            connection.Close();

            // Conexión y lógica para ddlProvincia2
            SqlConnection connection2 = new SqlConnection(connectionString);
            SqlCommand sqlCommand2 = new SqlCommand("SELECT * FROM Provincias WHERE IdProvincia != @IdProvincia", connection2);
            sqlCommand2.Parameters.AddWithValue("@IdProvincia", ddlProvincia1.SelectedValue);

            connection2.Open();

            SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();

            ddlProvincia2.Items.Clear();
            ddlProvincia2.DataSource = sqlDataReader2;
            ddlProvincia2.DataTextField = "NombreProvincia";
            ddlProvincia2.DataValueField = "IdProvincia";
            ddlProvincia2.DataBind();

            // Agregar la opción por defecto solo una vez
            ddlProvincia2.Items.Insert(0, new ListItem("-- Seleccionar --", "0"));
            ddlProvincia2.SelectedIndex = 0;

            // Limpiar ddlLocalidad2
            ddlLocalidad2.Items.Clear();
            ddlLocalidad2.Items.Insert(0, new ListItem("-- Seleccionar --", "0"));
            ddlLocalidad2.SelectedIndex = 0;

            sqlDataReader2.Close();
            connection2.Close();
        }

        protected void ddlProvincia2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Conexión y lógica para ddlLocalidad2
            SqlConnection connection3 = new SqlConnection(connectionString);
            SqlCommand sqlCommand3 = new SqlCommand("SELECT * FROM Localidades WHERE IdProvincia = @IdProvincia", connection3);
            sqlCommand3.Parameters.AddWithValue("@IdProvincia", ddlProvincia2.SelectedValue);
            connection3.Open();

            SqlDataReader sqlDataReader3 = sqlCommand3.ExecuteReader();

            ddlLocalidad2.Items.Clear();
            ddlLocalidad2.DataSource = sqlDataReader3;
            ddlLocalidad2.DataTextField = "NombreLocalidad";
            ddlLocalidad2.DataValueField = "IdLocalidad";
            ddlLocalidad2.DataBind();

            // Agregar la opción por defecto solo una vez
            ddlLocalidad2.Items.Insert(0, new ListItem("-- Seleccionar --", "0"));
            ddlLocalidad2.SelectedIndex = 0;

            sqlDataReader3.Close();
            connection3.Close();
        }


    }
}
