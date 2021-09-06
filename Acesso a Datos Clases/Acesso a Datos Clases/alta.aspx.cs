using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Acesso_a_Datos_Clases
{
    public partial class alta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqlConnection conexion = new SqlConnection();
            conexion.Open();
            SqlCommand comando = new SqlCommand("insert into usuarios(nombre,clave,mail) values('" + this.TextBox1.Text + "," + TextBox2.Text + "," + TextBox3.Text + "')", conexion);
            comando.ExecuteNonQuery();
            Label1.Text = "Se registro el usuario";
            conexion.close();
        }
    }
}