using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pag2_1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.PreviousPage != null) {
            TextBox Name = (TextBox)Page.PreviousPage.FindControl("name");
            TextBox Id = (TextBox)Page.PreviousPage.FindControl("id");
            TextBox Phone = (TextBox)Page.PreviousPage.FindControl("phone");
            DropDownList Area = (DropDownList)Page.PreviousPage.FindControl("areadropdown");
            DropDownList Hospital = (DropDownList)Page.PreviousPage.FindControl("hospital");
            RadioButtonList Type1 = (RadioButtonList)Page.PreviousPage.FindControl("RadioButtonList1");
            RadioButtonList Type8 = (RadioButtonList)Page.PreviousPage.FindControl("RadioButtonList8");
            RadioButtonList Type9 = (RadioButtonList)Page.PreviousPage.FindControl("RadioButtonList9");
            RadioButtonList Time = (RadioButtonList)Page.PreviousPage.FindControl("RadioButtonList2");
            TextBox Temperature = (TextBox)Page.PreviousPage.FindControl("temperature");


            Label1.Text = Name.Text + " ";      //Temperature.Text;
            Label2.Text = Id.Text + " ";
            Label3.Text = Phone.Text + " ";
            Label4.Text = Area.Text + " " + Hospital.Text + " ";
            if (Type1.Text == "" && Type8.Text == "" && Type9.Text != "") { Label5.Text = Type9.Text + " "; }
            else if (Type1.Text == "" && Type8.Text != "" && Type9.Text == "") { Label5.Text = Type8.Text + " "; }
            else if (Type1.Text != "" && Type8.Text == "" && Type9.Text == "") { Label5.Text = Type1.Text + " "; }
            
            Label6.Text = Time.Text + " ";
            Label7.Text = Temperature.Text;
        }
    }
}