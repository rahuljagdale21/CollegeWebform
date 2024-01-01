<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="college.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 182px;
        }
        .auto-style2 {
            width: 368px;
        }
        #main{
            background-color:burlywood;
            padding:20px;
            width:500px;
            border-radius:10px;
            height: 500px;
            display:flex;
            flex-direction:column;
            align-items:center;
            justify-content:center;
            margin-left:350px;
            margin-top:100px;
            
        }
        #form1{
            display:flex;
            flex-direction:column;
            align-items:center;
            justify-content:center;
            
           
                
        }
        #Header{
            margin-top:100px;
            font-size:30px;
        }
        body{
            background-color:saddlebrown;
           
        }
        #table{
            width:100%;
            display:flex;
            align-items:center;
            justify-content:center;
            
            padding-left:45px;
        }
        #label1{
            color:black;
            text-align:center;
        }

        
    </style>
</head>
<body style="width: 1153px">
    
    <form id="form1" runat="server">
        <div id="main">
           <h1>Registration Form</h1>
            <div id="table">
            <table style="width:100%;">
                
                <tr>
                    <td class="auto-style1">Name</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox1" runat="server" Width="266px"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    <td class="auto-style1">Address</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox2" runat="server" Width="266px"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    <td class="auto-style1">Gender</td>
                    <td class="auto-style2">
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                            <asp:ListItem>Others</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
                      <tr>
                    <td class="auto-style1">Age</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox3" runat="server" Width="271px"></asp:TextBox>
                          </td>
                    
                </tr>
                      <tr>
                    <td class="auto-style1">Contact</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox4" runat="server" Width="271px"></asp:TextBox>
                          </td>
                    
                </tr>
                      <tr>
                          <div id="button-div" >
                    <td class="button-1">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" Width="135px" Height="41px" BackColor="Blue" BorderStyle="None" ForeColor="White" />
                          </td>
                    <td class="button-2">
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Reset" Width="135px" Height="41px" BackColor="#0033CC" BorderStyle="None" ForeColor="White" />
                          </td>
                             </div>
                    
                </tr>
            </table>
                </div>
        <asp:Label ID="Label1"  runat="server" ></asp:Label>
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
