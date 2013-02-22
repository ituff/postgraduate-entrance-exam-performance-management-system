<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>南京工业大学2013研究生硕士研究生入学考试成绩查询</title>
    <meta name="keywords" content="研究生院，南京工业大学,硕士研究生入学考试成绩查询" />
    <link href="css/ds.css" rel="stylesheet" type="text/css" media="all " />
</head>
<body class="bg1" text="#000000">
    <table width="1004" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
            <td height="100" align="center" valign="top" bgcolor="#EEEEEE">
                <table width="100%" border="0" cellpadding="0" cellspacing="0">
                    <tr>
                        <td width="55%" valign="middle">
                            <img src="image/logo.jpg" width="500" height="105" /></td>
                        <td align="right" valign="top">
                            <table border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="190" height="31" align="center" valign="top" background="image/bgtop.jpg">
                                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                            <tr>
                                                <td height="3"></td>
                                            </tr>
                                        </table>
                                        <img src="image/ico_webmap.gif" width="19" height="13" hspace="2" vspace="2" align="absmiddle" />
                                        <a href="http://gra.njut.edu.cn/sitemap.asp" target="_blank" class="index_right2">网站地图</a>&nbsp;<img src="image/ico_mail.gif" width="16" height="16" align="absmiddle" />
                                        <a href="mailto:yjs@njut.edu.cn" class="index_right2">电子邮件</a></td>
                                </tr>
                            </table>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <div style="width: 1004px; height: 260px; margin: 0 auto; background-image: url(image/top3.jpg);"></div>
    <form id="form1" runat="server">
        <div style="width: 1004px; min-height: 250px; margin: 0 auto; margin-top: 25px;">
            <asp:Panel ID="Panel1" runat="server" Visible="true">
                <p style="text-align: center;">考生编号:<asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox><span style="color: red;">（必填）</span></p>
                <p style="text-align: center;">考生姓名:<asp:TextBox ID="TextBox2" runat="server" Width="200px"></asp:TextBox><span style="color: red;">（必填）</span></p>
                <p style="text-align: center;">身份证号:<asp:TextBox ID="TextBox3" runat="server" Width="200px"></asp:TextBox><span style="color: red;">（必填）</span></p>
                <p style="text-align: center;">
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/VerifyCode.aspx" />
                </p>
                <p style="text-align: center;">验证码 :<asp:TextBox ID="TextBox4" runat="server" Width="200px"></asp:TextBox><span style="color: red;">（必填）</span></p>
                <p style="text-align: center;">
                    <asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click" />
                </p>
            </asp:Panel>

            <asp:Panel ID="Panel2" runat="server" Visible="true">
                <table style="margin: 0 auto; margin-top: 80px; border: 1px solid #000000; border-collapse: collapse;">
                    <tr style="border: 1px solid #000000;">
                        <th style="border: 1px solid #000000;">考生编号</th>
                        <th style="border: 1px solid #000000;">姓名</th>
                        <th style="border: 1px solid #000000;">身份证号</th>
                        <th style="border: 1px solid #000000;">政治理论</th>
                        <th style="border: 1px solid #000000;">外国语</th>
                        <th style="border: 1px solid #000000;">业务课一</th>
                        <th style="border: 1px solid #000000;">业务课二</th>
                        <th style="border: 1px solid #000000;">总分</th>
                    </tr>
                    <tr style="border: 1px solid #000000;">
                        <td style="border: 1px solid #000000;"><%=GradeInfo.studentId %></td>
                        <td style="border: 1px solid #000000;"><%=GradeInfo.name %></td>
                        <td style="border: 1px solid #000000;"><%=GradeInfo.idCode %></td>
                        <td style="border: 1px solid #000000;"><%=GradeInfo.politicalTheoryMark %></td>
                        <td style="border: 1px solid #000000;"><%=GradeInfo.foreignLanguageMark %></td>
                        <td style="border: 1px solid #000000;"><%=GradeInfo.specializedCourseOneMark %></td>
                        <td style="border: 1px solid #000000;"><%=GradeInfo.specializedCourseTwoMark %></td>
                        <td style="border: 1px solid #000000;"><%=GradeInfo.sumMark %></td>
                    </tr>
                </table>
                <br />
                <p style="text-align: center;">
                    <asp:Button ID="Button2" runat="server" Text="退出查询" OnClick="Button2_Click" />
                </p>
            </asp:Panel>
        </div>
    </form>
    <table width="1004" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
            <td height="110" align="center" valign="middle" background="image/bottom_bg.jpg">
                <table width="950" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                        <td height="25" align="center" valign="middle"><a href="admin_login.htm" target="_blank">
                            <img src="image/ico2.gif" width="11" height="11" border="0" align="absmiddle" /></a> Copyright <span class="STYLEbtom">&copy;</span> 2012-2014 南京工业大学研究生院 All Rights Reserved.</td>
                    </tr>
                    <tr>
                        <td height="25" align="center" valign="middle">地址：南京市浦口区浦珠南路30号 邮编：211816</td>
                    </tr>
                    <tr>
                        <td height="25" align="center" valign="middle">电话：(025)58139197</td>
                    </tr>
                    <tr>
                        <td height="25" align="center" valign="middle">Support By <a href="http://green.njut.edu.cn" style="color: green;">Green Studio</a> </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</body>
</html>

