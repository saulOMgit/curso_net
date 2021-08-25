using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiPrimerASP.net
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Text = DateTime.Today.ToString("d");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Label1.Text);
            x++;Label1.Text = x.ToString();

            if (ListBox1.Items[0].Selected)
            {
                int resultado;
                int x1, x2;
                x1 = int.Parse(TextBox1.Text);
                x2 = int.Parse(TextBox2.Text);
                resultado = x1 + x2;
                Label4.Text = "La suma de los dos valores es:" + resultado;
            }
            else if (ListBox1.Items[1].Selected)
            {
                int resultado;
                int x1, x2;
                x1 = int.Parse(TextBox1.Text);
                x2 = int.Parse(TextBox2.Text);
                resultado = x1 - x2;
                Label4.Text = "La resta de los dos valores es:" + resultado;
            }
            else if (ListBox1.Items[2].Selected)
            {
                int resultado;
                int x1, x2;
                x1 = int.Parse(TextBox1.Text);
                x2 = int.Parse(TextBox2.Text);
                resultado = x1 * x2;
                Label4.Text = "La multiplicación de los dos valores es:" + resultado;
            }
            else if (ListBox1.Items[3].Selected)
            {
                int resultado;
                int x1, x2;
                x1 = int.Parse(TextBox1.Text);
                x2 = int.Parse(TextBox2.Text);
                resultado = x1 / x2;
                Label4.Text = "La división de los dos valores es:" + resultado;
            }
        }
       
    }
}