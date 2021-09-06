using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioDeValidacionASP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == false) 
            { btnEnviar.Enabled = false; }
            else
            { btnEnviar.Enabled = true; }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (IsValid && CheckBox1.Checked == true) Response.Redirect("Acesso.aspx");
            else if (CheckBox1.Checked == false) 
            {
                LabelEnvio.Text = "Debe Aceptar los terminos";
            }
        }
    }
}