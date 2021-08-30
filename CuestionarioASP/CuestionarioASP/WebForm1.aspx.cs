using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CuestionarioASP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int correctas = 0;

            if (RadioButton2.Checked == true) { correctas = correctas + 1; }
            if (RadioButton4.Checked == true) { correctas = correctas + 1; }
            if (RadioButton9.Checked == true) { correctas = correctas + 1; }

            Label4.Text = correctas+" preguntas correctas";

            
        }        
    }
}