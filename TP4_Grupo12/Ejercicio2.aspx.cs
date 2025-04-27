using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4_Grupo12
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
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
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




    }
}