using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Maticsoft.Common;
using NutLab.Grade;
using GS.Utility;

public partial class _Default : System.Web.UI.Page
{
    public grade GradeInfo;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        checkVerificationCode();
    }
    protected void checkVerificationCode()
    {
        string verificationCodeStr=TextBox4.Text.Trim();
        if(verificationCodeStr.Length<1) {
            MessageBox.Show(this,"验证码不能为空！");
            return;}
        if(verificationCodeStr.Equals(Request.Cookies["CheckCode"].Value.ToString())){
        checkPersonInfo();
        }
        else{  MessageBox.Show(this,"验证码错误！");
            return;}


    }

    protected void checkPersonInfo()
    {
        string studentIdStr = Tools.safeUserInput(TextBox1.Text.Trim());
        string nameStr = Tools.safeUserInput(TextBox2.Text.Trim());
        string idCodeStr = Tools.safeUserInput(TextBox3.Text.Trim());
        if (studentIdStr.Length < 1)
        {
            MessageBox.Show(this, "考试证号不能为空！");
            return;
        }
        if (nameStr.Length < 1)
        {
            MessageBox.Show(this, "考生姓名不能为空！");
            return;
        }
        if (idCodeStr.Length < 1)
        {
            MessageBox.Show(this, "身份证号不能为空！");
            return;
        }
        try
        {
            GradeInfo = new grade(studentIdStr);
        }
        catch
        {
            MessageBox.Show(this, "考试证号格式不正确或存在！");
            return;
        }
        if (GradeInfo == null)
        {
            MessageBox.Show(this, "考试证号格式不正确或存在！");
            return;
        }
        if (GradeInfo.name.Equals(nameStr) && GradeInfo.idCode.Equals(idCodeStr))
        {
            display();
        }
        else
        {
            MessageBox.Show(this, "您输入的个人信息不正确，请重新输入！");
            return;
        }
    }

    protected void display()
    {
        Panel1.Visible = false;
        Panel2.Visible = true;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = false;
    }
}