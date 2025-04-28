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

        private const string connectionString = @"Data Source=localhost;Initial Catalog=Neptuno;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
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
            if (!string.IsNullOrEmpty(txtProductoId.Text) || !string.IsNullOrEmpty(txtCategoriaId.Text))
            {
                string SqlCondicion = "SELECT IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad FROM productos WHERE ";


                if (!string.IsNullOrEmpty(txtProductoId.Text))
                {
                    switch (ddlProductoId.SelectedValue)
                    {
                        case "1":
                            SqlCondicion += "IdProducto = @IdProducto";
                            break;
                        case "2":
                            SqlCondicion += "IdProducto > @IdProducto";
                            break;
                        case "3":
                            SqlCondicion += "IdProducto < @IdProducto";
                            break;
                    }
                }

                if (!string.IsNullOrEmpty(txtCategoriaId.Text) && !string.IsNullOrEmpty(txtProductoId.Text))
                {
                    SqlCondicion += " AND ";
                }

                if (!string.IsNullOrEmpty(txtCategoriaId.Text))
                {
                    switch (ddlCategoriaId.SelectedValue)
                    {
                        case "1":
                            SqlCondicion += "IdCategoría = @IdCategoría";
                            break;
                        case "2":
                            SqlCondicion += "IdCategoría > @IdCategoría";
                            break;
                        case "3":
                            SqlCondicion += "IdCategoría < @IdCategoría";
                            break;
                    }
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(SqlCondicion, connection);


                    if (!string.IsNullOrEmpty(txtProductoId.Text))
                    {
                        command.Parameters.AddWithValue("@IdProducto", int.Parse(txtProductoId.Text));
                    }

                    if (!string.IsNullOrEmpty(txtCategoriaId.Text))
                    {
                        command.Parameters.AddWithValue("@IdCategoría", int.Parse(txtCategoriaId.Text));
                    }

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    gvProductos.DataSource = reader;
                    gvProductos.DataBind();

                    reader.Close();
                }
            }

            if (string.IsNullOrWhiteSpace(txtProductoId.Text) && string.IsNullOrWhiteSpace(txtCategoriaId.Text))
            {
                lblMensaje.Text = "Por favor, ingrese valores en los campos.";
            }
            else
            {
                lblMensaje.Text = "";
            }

        }

        protected void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sqlQueryProductos, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            gvProductos.DataSource = reader;
            gvProductos.DataBind();

            reader.Close();
            connection.Close();

            // limpio los campos
            txtProductoId.Text = "";
            txtCategoriaId.Text = "";
            ddlProductoId.SelectedIndex = 0;
            ddlCategoriaId.SelectedIndex = 0;
        }
    }
}

 

