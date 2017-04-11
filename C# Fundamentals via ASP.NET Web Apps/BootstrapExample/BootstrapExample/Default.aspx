<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BootstrapExample.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">

        <div class="page-header">
            <h1>Page Header</h1>
            <p class="lead">By line (lead)</p>
        </div>

        <div class="row">
            <div class="col-md-8 col-sm-6 col-xs-8">
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse a lacus a neque blandit aliquet. Donec quis erat luctus, placerat mauris porttitor, iaculis nunc. Interdum et malesuada fames ac ante ipsum primis in faucibus. Fusce vulputate nisl vitae laoreet luctus. Morbi aliquam metus vel eros mollis luctus in non dolor. Etiam lobortis, magna vel dictum sollicitudin, nisl tellus luctus felis, in pretium felis dui sed nunc. Fusce lorem lorem, commodo et turpis non, suscipit feugiat erat. Vestibulum quis commodo odio, id tempor diam. Nam ullamcorper nulla id eleifend maximus. Suspendisse sodales pharetra sagittis. Aliquam consequat, tellus vel semper laoreet, turpis mi sodales nisi, ac hendrerit nisl tellus eu neque. Interdum et malesuada fames ac ante ipsum primis in faucibus. Etiam non semper nibh. Morbi eu metus in dolor sodales viverra sed et arcu. Duis fermentum nisi a commodo faucibus.
            </div>
            <div class="col-md-4 col-sm-6 col-xs-4">
                Aenean vulputate hendrerit risus, a efficitur est faucibus vel. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Proin id orci non justo laoreet molestie. In hac habitasse platea dictumst. Pellentesque nec metus imperdiet, imperdiet magna sit amet, imperdiet libero. Interdum et malesuada fames ac ante ipsum primis in faucibus. Phasellus sodales, tortor a iaculis sagittis, libero ligula suscipit est, eget finibus mauris sapien vitae turpis.
            </div>
        </div>

    <div class="form-group">
        <label>TextBox: </label>
        <asp:TextBox ID="testTextBox" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="form-group">
        <label>DropDownList:</label>
        <asp:DropDownList ID="testDropDownList" runat="server" CssClass="form-control">
            <asp:ListItem Text="Option 1" Value="Small" />
            <asp:ListItem Text="Option 2" Value="Medium" />
            <asp:ListItem Text="Option 3" Value="Large" />
        </asp:DropDownList>
    </div>

    <div class="checkbox"><label><asp:CheckBox ID="testCheckBox" runat="server"></asp:CheckBox> CheckBox</label></div>

    <div class="radio"><label><asp:RadioButton ID="testRadioButton1" runat="server" GroupName="TestGroup"></asp:RadioButton> RadioButton 1</label></div>
    <div class="radio"><label><asp:RadioButton ID="testRadioButton2" runat="server" GroupName="TestGroup"></asp:RadioButton> RadioButton 2</label></div>


    <asp:Button ID="testButton" runat="server" Text="Test" CssClass="btn btn-lg btn-primary" />

    </div>
    </form>

    <script src="Scripts/jquery-2.1.3.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>