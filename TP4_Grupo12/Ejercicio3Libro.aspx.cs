﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

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


                string connectionDB = @"Data Source=localhost;DataBase=Libreria;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                // Data Source=localhost;Initial Catalog=Libreria;Integrated Security=True";
                // Data Source = DESKTOP - MHN7D94\\SQLEXPRESS; Initial Catalog = Libreria; Integrated Security = True

                // consulta SQL para obtener los libros y sus temas. Usando INNER JOIN para combinar las tablas Libros y Temas. 
                string sqlQueryTemas =
                        "SELECT L.IdLibro, L.Titulo, L.Autor, L.Precio, T.Tema " +
                        "FROM Libros L " +
                        "INNER JOIN Temas T ON L.IdTema = T.IdTema " +
                        "WHERE L.IdTema = @IdTema";
                // Data Source=DESKTOP-MHN7D94\SQLEXPRESS;Initial Catalog=Libreria;Integrated Security=True
                // Data Source=localhost;Initial Catalog=Libreria;Integrated Security=True

                SqlConnection sqlConnectionBook = new SqlConnection(connectionDB);
                sqlConnectionBook.Open();
                // se declara el Command para realizar la lectura de la base de datos
                SqlCommand sqlCommand = new SqlCommand(sqlQueryTemas, sqlConnectionBook);
                // se declaran los parametros para la consulta
                sqlCommand.Parameters.AddWithValue("@IdTema", Request.QueryString["idTema"]);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                GridView1.DataSource = dataTable;
                GridView1.DataBind();
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio3.aspx");
        }
    }
}