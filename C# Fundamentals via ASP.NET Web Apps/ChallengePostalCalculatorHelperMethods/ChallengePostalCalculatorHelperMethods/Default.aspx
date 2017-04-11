<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengePostalCalculatorHelperMethods.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Postal Calculator<br />
        <br />
        Width:
        <asp:TextBox ID="WidthTextBox" runat="server"></asp:TextBox>
        <br />
        Height:
        <asp:TextBox ID="HeightTextBox" runat="server"></asp:TextBox>
        <br />
        Length:
        <asp:TextBox ID="LengthTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="GroundRadioButton" runat="server" GroupName="ShippingGroup" OnCheckedChanged="handleChange" Text="Ground" AutoPostBack="True" />
        <br />
        <asp:RadioButton ID="AirRadioButton" runat="server" GroupName="ShippingGroup" OnCheckedChanged="handleChange" Text="Air" AutoPostBack="True" />
        <br />
        <asp:RadioButton ID="NextDayRadioButton" runat="server" GroupName="ShippingGroup" OnCheckedChanged="handleChange" Text="Next Day" AutoPostBack="True" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
