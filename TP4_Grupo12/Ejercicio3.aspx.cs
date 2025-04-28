using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4_Grupo12
{
    public partial class WebForm3 : System.Web.UI.Page
    {

        // Punto 1: Creando la conexión y cargando información

        private const string connectionString = @"Server=DESKTOP-JNJ0TAL\SQLEXPRESS;Database=Libreria;Integrated Security=True";

        private string consultaSQl = "SELECT IdLibro, IdTema, Titulo, Precio, Autor FROM Libros";

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

            }
        }
    }
}