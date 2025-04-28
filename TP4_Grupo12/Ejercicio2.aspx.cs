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

        private const string sqlQueryProductos = "SELECT IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad FROM Productos";

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

                gvProductos.DataSource = reader;
                gvProductos.DataBind();

                reader.Close();

                connection.Close();

            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            //se asigna el evento al botón filtrar y se crean las consultas SQL
            // para filtrar los productos por IdProducto y IdCategoría con los valores seleccionados en los DropDownList 
            // y se generan las referencias a los parámetros de la consulta SQL

            string condicion1IdCat = "SELECT IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad FROM productos WHERE IdCategoría @condicion2 @IdCategoría";
            string condicion1IdProd = "SELECT IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad FROM productos WHERE IdProducto @condicion1 @IdProducto";
            string condicion2 = "SELECT IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad FROM productos WHERE IdProducto @condicion1 @IdProducto AND IdCategoría @condicion2 @IdCategoría";

            //Las Referencias a asignar son @codicion1, condicion2, @IdProducto y @IdCategoria
        }




    }

}
