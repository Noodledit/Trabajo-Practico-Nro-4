using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4_Grupo12
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        private const string connectionString = @"Server=(local);Database=Neptuno;Integrated Security=True";

        private const string sqlQueryProductos = "SELECT * FROM Productos";

        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQueryProductos, connection);

                ddlProductoId.Items.Clear();
                ddlCategoriaId.Items.Clear();


                // Asignar valores al DropDownList IDProducto
                ddlProductoId.Items.Add(new ListItem("Igual a:", "1"));
                ddlProductoId.Items.Add(new ListItem("Mayor a:", "2"));
                ddlProductoId.Items.Add(new ListItem("Menor a:", "3"));

                // Asignar valores al DropDownList ddl
                ddlCategoriaId.Items.Add(new ListItem("Igual a:", "1"));
                ddlCategoriaId.Items.Add(new ListItem("Mayor a:", "2"));
                ddlCategoriaId.Items.Add(new ListItem("Menor a:", "3"));

                SqlDataReader reader = sqlCommand.ExecuteReader();

                //GridView1.DataSource = reader;

                reader.Close();

                connection.Close();

            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




    }

}
