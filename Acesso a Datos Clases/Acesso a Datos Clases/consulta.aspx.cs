﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Acesso_a_Datos_Clases
{
    public partial class consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqLConnection conexion = new SqLConnection();
            conexion.Open();
            SqlCommand comando = new SqlCommand("select nombre, clave, mail from usuarios " + " where nombre='" + this.TextBox1.Text + "'", conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read()) 
                {this.Label1.Text="Clave: "+registro["clave"]+"<br>"+"Mail: "+registro["mail"] }
            else
            {
                this.Label1.Text = "No existe un usuario con dicho nombre";
            }
            conexion.Close();
        }
    }
}