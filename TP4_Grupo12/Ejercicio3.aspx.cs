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

        private const string connectionString = @"Data Source=localhost;Initial Catalog=Libreria;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        private string consultaSQl = "SELECT IdTema, Tema FROM Temas";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                // se declara el Command para realizar la lectura de la base de datos
                SqlCommand sqlCommand = new SqlCommand(consultaSQl, connection);
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
            }
        }
    }
}