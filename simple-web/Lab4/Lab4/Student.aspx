<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="Lab4.Student" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Danh sach sinh vien</h1>
<p>Student ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtStudentCode" runat="server"></asp:TextBox>
</p>
<p>Student Name&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
</p>
<p>Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtEmail" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
</p>
<p>Phone Number&nbsp;&nbsp;
    <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Clear" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnAccept" runat="server" OnClick="btnAccept_Click" Text="Save" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
</p>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="StdCode" DataSourceID="SqlDataSourceStudent" Width="265px" OnSelectedIndexChanged="SelectedIndexChanged" CssClass="table">
    <Columns>
        <asp:BoundField DataField="StdCode" HeaderText="StdCode" ReadOnly="True" SortExpression="StdCode" HtmlEncode="False" />
        <asp:BoundField DataField="FullName" HeaderText="FullName" SortExpression="FullName" HtmlEncode="False" />
        <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" HtmlEncode="False" />
        <asp:BoundField DataField="MobilePhone" HeaderText="MobilePhone" SortExpression="MobilePhone" HtmlEncode="False" />
        <asp:CommandField ButtonType="Button" SelectText="Choose/Edit" ShowSelectButton="True" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSourceStudent" runat="server" ConnectionString="<%$ ConnectionStrings:QLSinhVienConnectionString %>" SelectCommand="SELECT * FROM [Student]" InsertCommand="INSERT INTO Student(StdCode, FullName, Email, MobilePhone) VALUES (@StdCode, @FullName, @Email, @MobilePhone)" DeleteCommand="DELETE FROM Student WHERE (StdCode = @StdCode)" UpdateCommand="UPDATE Student SET FullName = @FullName, MobilePhone = @MobiPhone, Email = @Email WHERE (StdCode = @StdCode)">
    <DeleteParameters>
        <asp:ControlParameter ControlID="txtStudentCode" Name="StdCode" PropertyName="Text" />
    </DeleteParameters>
    <InsertParameters>
        <asp:ControlParameter ControlID="txtStudentCode" Name="StdCode" PropertyName="Text" />
        <asp:ControlParameter ControlID="txtName" Name="FullName" PropertyName="Text" />
        <asp:ControlParameter ControlID="txtEmail" Name="Email" PropertyName="Text" />
        <asp:ControlParameter ControlID="txtPhoneNumber" Name="MobilePhone" PropertyName="Text" />
    </InsertParameters>
    <UpdateParameters>
        <asp:ControlParameter ControlID="txtName" Name="FullName" PropertyName="Text" />
        <asp:ControlParameter ControlID="txtPhoneNumber" Name="MobiPhone" PropertyName="Text" />
        <asp:ControlParameter ControlID="txtEmail" Name="Email" PropertyName="Text" />
        <asp:ControlParameter ControlID="txtStudentCode" Name="StdCode" PropertyName="Text" />
    </UpdateParameters>
</asp:SqlDataSource>
</asp:Content>
