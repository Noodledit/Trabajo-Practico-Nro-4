using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace TP4_Grupo12
{
    public partial class WebForm3 : System.Web.UI.Page
    {

        // Punto 1: Creando la conexión y cargando información

        private const string connectionString = @"Data Source=localhost;Initial Catalog=Libreria;Integrated Security=True;TrustServerCertificate=True";

        //@"Data Source=DESKTOP-MHN7D94\SQLEXPRESS;Initial Catalog=Libreria;Integrated Security=True"

        private string consultaSQl = "SELECT DISTINCT IdTema, Tema FROM Temas";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                // se declara el Command para realizar la lectura de la base de datos
                SqlCommand sqlCommand = new SqlCommand(consultaSQl, connection);
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                //Aqui agregamos al dll
                ddlTema.DataSource = sqlReader;
                ddlTema.DataTextField = "Tema";
                ddlTema.DataValueField = "IdTema";

                // 
                ddlTema.DataBind();

                sqlReader.Close();

                connection.Close();

            }
        }
            protected void btnVerLibros_Click(object sender, EventArgs e)
            {
            string idTema = ddlTema.SelectedValue;
            Response.Redirect("Ejercicio3Libro.aspx?idTema=" + idTema);

            }   

        
    }
}