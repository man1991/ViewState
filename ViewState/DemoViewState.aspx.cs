using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewState
{
    public partial class DemoViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Declaration of a and b 
        //public string a, b;
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Value of Textbox1 and TectBox2 is assigin on the ViewState  
            ViewState["name"] = TextBox1.Text;
            ViewState["password"] = TextBox2.Text;
            ////TextBox1 and TextBox2 Value is Assigning on the variable a and b  
            //a = TextBox1.Text;
            //b = TextBox2.Text;
            ////after clicking on Button TextBox value Will be Cleared  
            TextBox1.Text = TextBox2.Text = String.Empty;

        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            //If ViewState Value is not Null then Value of View State is Assign to TextBox 
            if (ViewState["name"] != null)
            {
                TextBox1.Text = ViewState["name"].ToString();
            }
            if (ViewState["password"] != null)
            {
                TextBox2.Text = ViewState["password"].ToString();
            }
            //value of variable a and b is assingning on TextBox1 and Textbox2 
            //TextBox1.Text = a;
            //TextBox2.Text = b;
        }
    }
}