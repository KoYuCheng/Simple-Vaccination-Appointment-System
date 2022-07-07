<%@ Page Language="C#" AutoEventWireup="true" CodeFile="page1.aspx.cs" Inherits="page1" %>

<!DOCTYPE html>
<%--請用ASP .NET Web Form 常用控制項寫「疫苗注射預約與身體評估系統」網頁，至少要有2頁，要包含可以輸入資料的部分。要有個人基本資料。
預約部分至少要有3種疫苗，至少要有8家醫院，有多個日期、時段。 身體評估部分至少要有5種項目。使用的控制項總數要20個以上。
要使用網頁切換，可以存取上個網頁的資料。--%>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title></title>
<style>
.headertekst
{
    text-align: center;
    width:100%
}
.table 
{
    border:ridge;
}
</style>
    
</head>
<body>
<form id="form1" runat="server">
<div>
<h2 class="headertekst">疫苗注射預約與身體評估系統</h2>
    &nbsp;  
        
    <br />
    <br />
    <asp:Panel ID="Panel1" runat="server">
        <h3>基本資料</h3>
        姓&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 名:<asp:TextBox ID="name" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="name" ErrorMessage="姓名不可空白" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        身分證字號:<asp:TextBox ID="id" runat="server"></asp:TextBox>
            

        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="id" Display="Dynamic" ErrorMessage="身分證不可空白" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="id" Display="Dynamic" ErrorMessage="身分證格式不符" ForeColor="Red" ValidationExpression="^[A-Z]{1}[12]{1}\d{8}$"></asp:RegularExpressionValidator>
            

        <br />
        手&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 機:<asp:TextBox ID="phone" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="手機不可為空" ControlToValidate="phone" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="手機格式不符(09xxxxxxxx)" ControlToValidate="phone" Display="Dynamic" ForeColor="Red" ValidationExpression="^09\d{8}$"></asp:RegularExpressionValidator>
            

    </asp:Panel>
    
</div>
    <asp:Panel ID="Panel2" runat="server">
        <br />
        請選擇施打區域:<asp:DropDownList ID="areadropdown" runat="server" OnSelectedIndexChanged="areadropdown_SelectedIndexChanged" style="height: 23px" AutoPostBack="True">
            <asp:ListItem>==請選擇施打縣市==</asp:ListItem>
            <asp:ListItem Value="臺北市">臺北市</asp:ListItem>
            <asp:ListItem Value="新北市">新北市</asp:ListItem>
            <asp:ListItem Value="臺中市">臺中市</asp:ListItem>
            <asp:ListItem Value="高雄市">高雄市</asp:ListItem>
            <asp:ListItem Value="花蓮縣">花蓮縣</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
    </asp:Panel>
                <asp:Panel ID="Panel3" runat="server" Visible="False">
                    <asp:Label ID="Label1" runat="server" Text="施打醫院:"></asp:Label>
                    <asp:DropDownList ID="hospital" runat="server" AutoPostBack="True" OnSelectedIndexChanged="hospital_SelectedIndexChanged">
                        <asp:ListItem Value="0">臺北榮民總醫院</asp:ListItem>
                        <asp:ListItem Value="1">臺大醫院</asp:ListItem>
                        <asp:ListItem Value="2">長庚醫療財團法人臺北長庚紀念醫院</asp:ListItem>
                    </asp:DropDownList>
                    <br />
            預約疫苗種類:<asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem Value="BNT">BNT</asp:ListItem>
                <asp:ListItem Value="AZ">AZ</asp:ListItem>
                <asp:ListItem Value="Moderna">Moderna</asp:ListItem>
                <asp:ListItem Value="高端">高端</asp:ListItem>
            </asp:RadioButtonList>
                    <asp:RadioButtonList ID="RadioButtonList8" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow" OnSelectedIndexChanged="RadioButtonList8_SelectedIndexChanged" AutoPostBack="True" Visible="False">
                <asp:ListItem Value="BNT">BNT</asp:ListItem>
                <asp:ListItem Value="AZ">AZ</asp:ListItem>
                <asp:ListItem Value="高端">高端</asp:ListItem>
            </asp:RadioButtonList>
                    <asp:RadioButtonList ID="RadioButtonList9" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow" OnSelectedIndexChanged="RadioButtonList9_SelectedIndexChanged" AutoPostBack="True" Visible="False">
                <asp:ListItem Value="BNT">BNT</asp:ListItem>
                <asp:ListItem Value="AZ">AZ</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            時段:<asp:RadioButtonList ID="RadioButtonList2" runat="server" OnSelectedIndexChanged="RadioButtonList2_SelectedIndexChanged">
                <asp:ListItem>2021/11/23-9:30~10:30</asp:ListItem>
                <asp:ListItem>2021/11/23-10:30~11:30</asp:ListItem>
                <asp:ListItem>2021/11/24-9:30~10:30</asp:ListItem>
                <asp:ListItem>2021/11/24-10:30~11:30</asp:ListItem>
            </asp:RadioButtonList>
                    <asp:Button ID="check" runat="server" Height="22px" OnClick="check_Click" Text="確定" />
                    <br />
                    
        </asp:Panel>
    <asp:Panel ID="Panel4" runat="server" Visible="False" BorderWidth="1" ForeColor="Black">
        1.過去注射疫苗或藥物是否有嚴重過敏反應史。
                    <asp:RadioButtonList ID="RadioButtonList3" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                    <asp:ListItem>是</asp:ListItem>
                    <asp:ListItem>否</asp:ListItem>
                    </asp:RadioButtonList>
            
        <br />
        2.現在身體有無不適病徵 ( 如發燒 38℃、嘔吐、呼吸困難等 )。
        <asp:RadioButtonList ID="RadioButtonList4" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow"><asp:ListItem>是</asp:ListItem>
                    <asp:ListItem>否</asp:ListItem></asp:RadioButtonList>
        <br />
        3.是否為免疫低下者，包括接受免疫抑制劑治療者。<asp:RadioButtonList ID="RadioButtonList5" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow"><asp:ListItem>是</asp:ListItem>
                    <asp:ListItem>否</asp:ListItem></asp:RadioButtonList>
        <br />
        4.過去 7 天內是否曾接種其他疫苗。<asp:RadioButtonList ID="RadioButtonList6" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow"><asp:ListItem>是</asp:ListItem>
                    <asp:ListItem>否</asp:ListItem></asp:RadioButtonList>
        <br />
        5.目前是否懷孕。<asp:RadioButtonList ID="RadioButtonList7" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow"><asp:ListItem>是</asp:ListItem>
                    <asp:ListItem>否</asp:ListItem></asp:RadioButtonList>
        <br />
        6.體溫:<asp:TextBox ID="temperature" runat="server"></asp:TextBox>℃ (額溫正常值 : 37.5℃)</asp:Panel>
    <asp:Button ID="final_submit" runat="server" Text="送出" OnClick="final_submit_Click" Visible="False" />
&nbsp;
    <asp:Button ID="Button1" runat="server" Text="取消預約" type="reset" OnClick="Button1_Click" Visible="False"/>
</form>
</body>
</html>
