using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4_Grupo12
{
    public partial class WebForm2 : System.Web.UI.Page
    {

            private const string connectionString = @"Server=DESKTOP-JNJ0TAL\SQLEXPRESS;Database=Neptuno;Integrated Security=True";

            private const string sqlQueryProductos = "SELECT * FROM Productos";

        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQueryProductos, connection);

                ddlProducto.Items.Clear();
                ddlCategoria.Items.Clear();


                // Asignar valores al DropDownList IDProducto
                ddlProducto.Items.Add(new ListItem("Igual a:", "1"));
                ddlProducto.Items.Add(new ListItem("Mayor a:", "2"));
                ddlProducto.Items.Add(new ListItem("Menor a:", "3"));

               // Asignar valores al DropDownList IDCategoria
                ddlCategoria.Items.Add(new ListItem("Igual a:", "1"));
                ddlCategoria.Items.Add(new ListItem("Mayor a:", "2"));
                ddlCategoria.Items.Add(new ListItem("Menor a:", "3"));

                SqlDataReader reader = sqlCommand.ExecuteReader();

                GridView1.DataSource = reader;

                reader.Close();

                connection.Close();

            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




    }
}