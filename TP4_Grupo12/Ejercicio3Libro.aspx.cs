using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TP4_Grupo12
{
    public partial class Ejercicio3Libro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MostrarLibro();
            }
        }
        private void MostrarLibro()
        {
            string connectionDB = "Data Source=localhost;Initial Catalog=Libreria;Integrated Security=True";

            SqlConnection sqlConnectionBook = new SqlConnection(connectionDB);
            sqlConnectionBook.Open();


        }
    }
}