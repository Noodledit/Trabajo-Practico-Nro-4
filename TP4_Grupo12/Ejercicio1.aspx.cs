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
        private const string connectionString = "Data Source=NOODLE-DESK;Initial Catalog=Viajes;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
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
                connection.Close();

            }
        }
    }
}