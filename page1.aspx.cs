using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void final_submit_Click(object sender, EventArgs e)
    {
        //判斷欄位不能為空RadioButton1~9 
        if (RadioButtonList9.Visible == true && RadioButtonList8.Visible == false && RadioButtonList1.Visible == false) 
        { 
            //出現9
            if (RadioButtonList9.SelectedIndex == -1 || RadioButtonList2.SelectedIndex == -1 || RadioButtonList3.SelectedIndex == -1
                || RadioButtonList4.SelectedIndex == -1 || RadioButtonList5.SelectedIndex == -1 || RadioButtonList6.SelectedIndex == -1
                || RadioButtonList7.SelectedIndex == -1 || temperature.Text == "")
            { Response.Write("<script>alert('尚未填寫完成 請檢查...')</script>"); }
            else
            {
                if (float.Parse(temperature.Text) >= 37.5) { Response.Write("<script>alert('體溫過高 無法預約')</script>"); }
                else { Response.Write("<script>alert('成功預約')</script>"); Server.Transfer("pag2-1.aspx"); }
            }
        }
        else if (RadioButtonList9.Visible == false && RadioButtonList8.Visible == true && RadioButtonList1.Visible == false)
        {
            //出現8
            if (RadioButtonList8.SelectedIndex == -1 || RadioButtonList2.SelectedIndex == -1 || RadioButtonList3.SelectedIndex == -1
            || RadioButtonList4.SelectedIndex == -1 || RadioButtonList5.SelectedIndex == -1 || RadioButtonList6.SelectedIndex == -1
            || RadioButtonList7.SelectedIndex == -1 || temperature.Text == "")
            { Response.Write("<script>alert('尚未填寫完成 請檢查...')</script>"); }
            else
            {
                if (float.Parse(temperature.Text) >= 37.5) { Response.Write("<script>alert('體溫過高 無法預約')</script>"); }
                else { Response.Write("<script>alert('成功預約')</script>"); Server.Transfer("pag2-1.aspx"); }
            }
        }
        else if (RadioButtonList9.Visible == false && RadioButtonList8.Visible == false && RadioButtonList1.Visible == true)
        {
            //出現1
            if (RadioButtonList1.SelectedIndex == -1 || RadioButtonList2.SelectedIndex == -1 || RadioButtonList3.SelectedIndex == -1
            || RadioButtonList4.SelectedIndex == -1 || RadioButtonList5.SelectedIndex == -1 || RadioButtonList6.SelectedIndex == -1
            || RadioButtonList7.SelectedIndex == -1||temperature.Text=="")
            {Response.Write("<script>alert('尚未填寫完成 請檢查...')</script>");}
            else
            {
                if (float.Parse(temperature.Text) >= 37.5) { Response.Write("<script>alert('體溫過高 無法預約')</script>"); }
                else { Response.Write("<script>alert('成功預約')</script>"); Server.Transfer("pag2-1.aspx"); }
            }
        }
        
    }
protected void areadropdown_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        switch (areadropdown.SelectedValue)
        {
            case "==請選擇施打縣市==":
                Panel3.Visible = false;
                break;
            case "臺北市":
                Panel3.Visible = true;
                hospital.Items[0].Value = "臺北榮民總醫院";
                hospital.Items[0].Text = "臺北榮民總醫院";
                hospital.Items[1].Value = "臺大醫院";
                hospital.Items[1].Text = "臺大醫院";
                hospital.Items[2].Value = "長庚醫療財團法人臺北長庚紀念醫院";
                hospital.Items[2].Text = "長庚醫療財團法人臺北長庚紀念醫院";
                break;
            case "新北市":
                Panel3.Visible = true;
                hospital.Items[0].Value = "衛生福利部臺北醫院";
                hospital.Items[0].Text = "衛生福利部臺北醫院";
                hospital.Items[1].Value = "天主教耕莘醫療財團法人永和耕莘醫院";
                hospital.Items[1].Text = "天主教耕莘醫療財團法人永和耕莘醫院";
                hospital.Items[2].Value = "臺北慈濟醫院";
                hospital.Items[2].Text = "臺北慈濟醫院";
                break;
            case "臺中市":
                Panel3.Visible = true;
                hospital.Items[0].Value = "衛生福利部臺中醫院";
                hospital.Items[0].Text = "衛生福利部臺中醫院";
                hospital.Items[1].Value = "臺中榮民總醫院";
                hospital.Items[1].Text = "臺中榮民總醫院";
                hospital.Items[2].Value = "臺中慈濟醫院";
                hospital.Items[2].Text= "臺中慈濟醫院";
                break;
            case "高雄市":
                Panel3.Visible = true;
                hospital.Items[0].Value = "長庚醫療財團法人高雄長庚紀念醫院";
                hospital.Items[0].Text = "長庚醫療財團法人高雄長庚紀念醫院";
                hospital.Items[1].Value = "高雄榮民總醫院";
                hospital.Items[1].Text = "高雄榮民總醫院";
                hospital.Items[2].Value = "高雄市立民生醫院";
                hospital.Items[2].Text = "高雄市立民生醫院";
                break;
            case "花蓮縣":
                Panel3.Visible = true;
                hospital.Items[0].Value = "衛生福利部花蓮醫院";
                hospital.Items[0].Text = "衛生福利部花蓮醫院";
                hospital.Items[1].Value = "國軍花蓮總醫院";
                hospital.Items[1].Text = "國軍花蓮總醫院";
                hospital.Items[2].Value = "玉里慈濟醫院";
                hospital.Items[2].Text = "玉里慈濟醫院";
                break;
        }
    }


    protected void hospital_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (hospital.SelectedValue) {
            case "臺北榮民總醫院":
                RadioButtonList1.Visible = true;
                RadioButtonList8.Visible = false;
                RadioButtonList9.Visible = false;
                RadioButtonList1.Items[0].Selected = false;
                RadioButtonList1.Items[1].Selected = false;
                RadioButtonList1.Items[2].Selected = false;
                RadioButtonList1.Items[3].Selected = false;
                RadioButtonList2.Items[0].Text = "2021/11/23-9:30~10:30";
                RadioButtonList2.Items[1].Text = "2021/11/23-10:30~11:30";
                RadioButtonList2.Items[2].Text = "2021/11/24-9:30~10:30";
                RadioButtonList2.Items[3].Text = "2021/11/24-10:30~11:30";
                RadioButtonList2.Items[0].Selected = false;
                RadioButtonList2.Items[1].Selected = false;
                RadioButtonList2.Items[2].Selected = false;
                RadioButtonList2.Items[3].Selected = false;
               
                break;
            case "臺大醫院":
                RadioButtonList8.Visible = true;
                RadioButtonList9.Visible = false;
                RadioButtonList1.Visible = false;
                RadioButtonList8.Items[0].Selected = false;
                RadioButtonList8.Items[1].Selected = false;
                RadioButtonList8.Items[2].Selected = false;
                RadioButtonList2.Items[0].Text = "2021/11/26-9:30~10:30";
                RadioButtonList2.Items[1].Text = "2021/11/26-10:30~11:30";
                RadioButtonList2.Items[2].Text = "2021/11/27-9:30~10:30";
                RadioButtonList2.Items[3].Text = "2021/11/27-10:30~11:30";
                RadioButtonList2.Items[0].Selected = false;
                RadioButtonList2.Items[1].Selected = false;
                RadioButtonList2.Items[2].Selected = false;
                RadioButtonList2.Items[3].Selected = false;
                break;
            case "長庚醫療財團法人臺北長庚紀念醫院":
                RadioButtonList9.Visible = true;
                RadioButtonList1.Visible = false;
                RadioButtonList8.Visible = false;
                RadioButtonList9.Items[0].Selected = false;
                RadioButtonList9.Items[1].Selected = false;
                RadioButtonList2.Items[0].Text = "2021/11/29-9:30~10:30";
                RadioButtonList2.Items[1].Text = "2021/11/29-13:30~14:30";
                RadioButtonList2.Items[2].Text = "2021/11/30-9:30~10:30";
                RadioButtonList2.Items[3].Text = "2021/11/30-13:30~14:30";
                RadioButtonList2.Items[0].Selected = false;
                RadioButtonList2.Items[1].Selected = false;
                RadioButtonList2.Items[2].Selected = false;
                RadioButtonList2.Items[3].Selected = false;
                
                break;
            case "天主教耕莘醫療財團法人永和耕莘醫院":
                RadioButtonList1.Visible = true;
                RadioButtonList8.Visible = false;
                RadioButtonList9.Visible = false;
                RadioButtonList1.Items[0].Selected = false;
                RadioButtonList1.Items[1].Selected = false;
                RadioButtonList1.Items[2].Selected = false;
                RadioButtonList1.Items[3].Selected = false;
                 RadioButtonList2.Items[0].Text = "2021/11/21-9:30~10:30";
                RadioButtonList2.Items[1].Text = "2021/11/21-10:30~11:30";
                RadioButtonList2.Items[2].Text = "2021/11/24-9:30~10:30";
                RadioButtonList2.Items[3].Text = "2021/11/24-10:30~11:30";
                RadioButtonList2.Items[0].Selected = false;
                RadioButtonList2.Items[1].Selected = false;
                RadioButtonList2.Items[2].Selected = false;
                RadioButtonList2.Items[3].Selected = false;
                break;
            case "臺北慈濟醫院":
                RadioButtonList8.Visible = true;
                RadioButtonList9.Visible = false;
                RadioButtonList1.Visible = false;
                RadioButtonList8.Items[0].Selected = false;
                RadioButtonList8.Items[1].Selected = false;
                RadioButtonList8.Items[2].Selected = false;
                  RadioButtonList2.Items[0].Text = "2021/11/26-9:30~10:30";
                RadioButtonList2.Items[1].Text = "2021/11/26-10:30~11:30";
                RadioButtonList2.Items[2].Text = "2021/11/27-9:30~10:30";
                RadioButtonList2.Items[3].Text = "2021/11/27-10:30~11:30";
                RadioButtonList2.Items[0].Selected = false;
                RadioButtonList2.Items[1].Selected = false;
                RadioButtonList2.Items[2].Selected = false;
                RadioButtonList2.Items[3].Selected = false;

                break;
            case "衛生福利部臺北醫院":
                RadioButtonList9.Visible = true;
                RadioButtonList1.Visible = false;
                RadioButtonList8.Visible = false;
                RadioButtonList9.Items[0].Selected = false;
                RadioButtonList9.Items[1].Selected = false;
                 RadioButtonList2.Items[0].Text = "2021/11/26-9:30~10:30";
                RadioButtonList2.Items[1].Text = "2021/11/26-10:30~11:30";
                RadioButtonList2.Items[2].Text = "2021/11/27-9:30~10:30";
                RadioButtonList2.Items[3].Text = "2021/11/27-10:30~11:30";
                RadioButtonList2.Items[0].Selected = false;
                RadioButtonList2.Items[1].Selected = false;
                RadioButtonList2.Items[2].Selected = false;
                RadioButtonList2.Items[3].Selected = false;
                break;
            case "衛生福利部臺中醫院":
                RadioButtonList1.Visible = true;
                RadioButtonList8.Visible = false;
                RadioButtonList9.Visible = false;
                RadioButtonList1.Items[0].Selected = false;
                RadioButtonList1.Items[1].Selected = false;
                RadioButtonList1.Items[2].Selected = false;
                RadioButtonList1.Items[3].Selected = false;
                  RadioButtonList2.Items[0].Text = "2021/11/21-9:30~10:30";
                RadioButtonList2.Items[1].Text = "2021/11/21-10:30~11:30";
                RadioButtonList2.Items[2].Text = "2021/11/24-9:30~10:30";
                RadioButtonList2.Items[3].Text = "2021/11/24-10:30~11:30";
                RadioButtonList2.Items[0].Selected = false;
                RadioButtonList2.Items[1].Selected = false;
                RadioButtonList2.Items[2].Selected = false;
                RadioButtonList2.Items[3].Selected = false;
                break;
            case "臺中慈濟醫院":
                RadioButtonList8.Visible = true;
                RadioButtonList9.Visible = false;
                RadioButtonList1.Visible = false;
                RadioButtonList8.Items[0].Selected = false;
                RadioButtonList8.Items[1].Selected = false;
                RadioButtonList8.Items[2].Selected = false;
                 RadioButtonList2.Items[0].Text = "2021/11/21-9:30~10:30";
                RadioButtonList2.Items[1].Text = "2021/11/21-10:30~11:30";
                RadioButtonList2.Items[2].Text = "2021/11/24-9:30~10:30";
                RadioButtonList2.Items[3].Text = "2021/11/24-10:30~11:30";
                RadioButtonList2.Items[0].Selected = false;
                RadioButtonList2.Items[1].Selected = false;
                RadioButtonList2.Items[2].Selected = false;
                RadioButtonList2.Items[3].Selected = false;
                break;
            case "臺中榮民總醫院":
                RadioButtonList9.Visible = true;
                RadioButtonList1.Visible = false;
                RadioButtonList8.Visible = false;
                RadioButtonList9.Items[0].Selected = false;
                RadioButtonList9.Items[1].Selected = false;
                 RadioButtonList2.Items[0].Text = "2021/11/21-9:30~10:30";
                RadioButtonList2.Items[1].Text = "2021/11/21-10:30~11:30";
                RadioButtonList2.Items[2].Text = "2021/11/24-9:30~10:30";
                RadioButtonList2.Items[3].Text = "2021/11/24-10:30~11:30";
                RadioButtonList2.Items[0].Selected = false;
                RadioButtonList2.Items[1].Selected = false;
                RadioButtonList2.Items[2].Selected = false;
                RadioButtonList2.Items[3].Selected = false;
                break;
            case "高雄榮民總醫院":
                RadioButtonList1.Visible = true;
                RadioButtonList8.Visible = false;
                RadioButtonList9.Visible = false;
                RadioButtonList1.Items[0].Selected = false;
                RadioButtonList1.Items[1].Selected = false;
                RadioButtonList1.Items[2].Selected = false;
                RadioButtonList1.Items[3].Selected = false;
                 RadioButtonList2.Items[0].Text = "2021/11/23-9:30~10:30";
                RadioButtonList2.Items[1].Text = "2021/11/23-10:30~11:30";
                RadioButtonList2.Items[2].Text = "2021/11/24-9:30~10:30";
                RadioButtonList2.Items[3].Text = "2021/11/24-10:30~11:30";
                RadioButtonList2.Items[0].Selected = false;
                RadioButtonList2.Items[1].Selected = false;
                RadioButtonList2.Items[2].Selected = false;
                RadioButtonList2.Items[3].Selected = false;
                break;
            case "高雄市立民生醫院":
                RadioButtonList8.Visible = true;
                RadioButtonList9.Visible = false;
                RadioButtonList1.Visible = false;
                RadioButtonList8.Items[0].Selected = false;
                RadioButtonList8.Items[1].Selected = false;
                RadioButtonList8.Items[2].Selected = false;
                 RadioButtonList2.Items[0].Text = "2021/11/21-9:30~10:30";
                RadioButtonList2.Items[1].Text = "2021/11/21-10:30~11:30";
                RadioButtonList2.Items[2].Text = "2021/11/24-9:30~10:30";
                RadioButtonList2.Items[3].Text = "2021/11/24-10:30~11:30";
                RadioButtonList2.Items[0].Selected = false;
                RadioButtonList2.Items[1].Selected = false;
                RadioButtonList2.Items[2].Selected = false;
                RadioButtonList2.Items[3].Selected = false;
                break;
            case "長庚醫療財團法人高雄長庚紀念醫院":
                RadioButtonList9.Visible = true;
                RadioButtonList1.Visible = false;
                RadioButtonList8.Visible = false;
                RadioButtonList9.Items[0].Selected = false;
                RadioButtonList9.Items[1].Selected = false;
                RadioButtonList2.Items[0].Text = "2021/11/21-9:30~10:30";
                RadioButtonList2.Items[1].Text = "2021/11/21-10:30~11:30";
                RadioButtonList2.Items[2].Text = "2021/11/24-9:30~10:30";
                RadioButtonList2.Items[3].Text = "2021/11/24-10:30~11:30";
                RadioButtonList2.Items[0].Selected = false;
                RadioButtonList2.Items[1].Selected = false;
                RadioButtonList2.Items[2].Selected = false;
                RadioButtonList2.Items[3].Selected = false;
                break;
            case "衛生福利部花蓮醫院":
                RadioButtonList1.Visible = true;
                RadioButtonList8.Visible = false;
                RadioButtonList9.Visible = false;
                RadioButtonList1.Items[0].Selected = false;
                RadioButtonList1.Items[1].Selected = false;
                RadioButtonList1.Items[2].Selected = false;
                RadioButtonList1.Items[3].Selected = false;
                  RadioButtonList2.Items[0].Text = "2021/11/26-9:30~10:30";
                RadioButtonList2.Items[1].Text = "2021/11/26-10:30~11:30";
                RadioButtonList2.Items[2].Text = "2021/11/27-9:30~10:30";
                RadioButtonList2.Items[3].Text = "2021/11/27-10:30~11:30";
                RadioButtonList2.Items[0].Selected = false;
                RadioButtonList2.Items[1].Selected = false;
                RadioButtonList2.Items[2].Selected = false;
                RadioButtonList2.Items[3].Selected = false;
                break;
            case "玉里慈濟醫院":
                RadioButtonList8.Visible = true;
                RadioButtonList9.Visible = false;
                RadioButtonList1.Visible = false;
                RadioButtonList8.Items[0].Selected = false;
                RadioButtonList8.Items[1].Selected = false;
                RadioButtonList8.Items[2].Selected = false;
                 RadioButtonList2.Items[0].Text = "2021/11/23-9:30~10:30";
                RadioButtonList2.Items[1].Text = "2021/11/23-10:30~11:30";
                RadioButtonList2.Items[2].Text = "2021/11/24-9:30~10:30";
                RadioButtonList2.Items[3].Text = "2021/11/24-10:30~11:30";
                RadioButtonList2.Items[0].Selected = false;
                RadioButtonList2.Items[1].Selected = false;
                RadioButtonList2.Items[2].Selected = false;
                RadioButtonList2.Items[3].Selected = false;
                break;
            case "國軍花蓮總醫院":
                RadioButtonList9.Visible = true;
                RadioButtonList1.Visible = false;
                RadioButtonList8.Visible = false;
                RadioButtonList9.Items[0].Selected = false;
                RadioButtonList9.Items[1].Selected = false;
                 RadioButtonList2.Items[0].Text = "2021/11/23-9:30~10:30";
                RadioButtonList2.Items[1].Text = "2021/11/23-10:30~11:30";
                RadioButtonList2.Items[2].Text = "2021/11/24-9:30~10:30";
                RadioButtonList2.Items[3].Text = "2021/11/24-10:30~11:30";
                RadioButtonList2.Items[0].Selected = false;
                RadioButtonList2.Items[1].Selected = false;
                RadioButtonList2.Items[2].Selected = false;
                RadioButtonList2.Items[3].Selected = false;
                break;
        }
    }
    
    
    protected void check_Click(object sender, EventArgs e)
    {
        Panel4.Visible = true;
        final_submit.Visible = true;
        check.Visible = false;
        Button1.Visible = true;
        RadioButtonList2.Enabled = false;
        RadioButtonList1.Enabled = false;
        RadioButtonList8.Enabled = false;
        RadioButtonList9.Enabled = false;
        hospital.Enabled = false;
        areadropdown.Enabled = false;

    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {     
    }
    protected void RadioButtonList8_SelectedIndexChanged(object sender, EventArgs e)
    {      
    }
    protected void RadioButtonList9_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //取消預約
        
        Server.Transfer("page1.aspx");
    }
    protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}