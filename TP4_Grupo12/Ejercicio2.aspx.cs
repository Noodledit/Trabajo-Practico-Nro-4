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
                // Asignar valores al DropDownList IDProducto
                ddlProducto.Items.Add(new ListItem("Igual a:", "1"));
                ddlProducto.Items.Add(new ListItem("Mayor a:", "2"));
                ddlProducto.Items.Add(new ListItem("Menor a:", "3"));
            }
    }
}