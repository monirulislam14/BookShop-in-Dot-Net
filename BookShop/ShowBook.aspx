<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShowBook.aspx.cs" Inherits="BookShop.ShowBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>SHOW BOOK</h2>
     <div class="form-group row">
        <table style="width:100%;">
        <tr>
            <td style="width: 145px" class="text-center"><strong>Name</strong></td>
            <td class="modal-sm" style="width: 128px">
                <asp:TextBox ID="searchBookNameTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="searchButton" runat="server" Text="Search" CssClass="col-xs-offset-0" OnClick="searchButton_Click" />
            </td>
        </tr>
        </table>
    
    </div>
   <asp:GridView ID="showBookGrideView" runat="server" AutoGenerateColumns="False" AllowSorting="True" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
        <Columns>
            <asp:TemplateField HeaderText="#SL">
                <ItemTemplate>
                    <%#Eval(expression:"AddBookId") %>
                </ItemTemplate>
                </asp:TemplateField>
             <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    <%#Eval(expression:"AddBookName") %>
                </ItemTemplate>
                </asp:TemplateField>
             <asp:TemplateField HeaderText="ISBN">
                <ItemTemplate>
                    <%#Eval(expression:"AddBookIsbn") %>
                </ItemTemplate>
                </asp:TemplateField>
             <asp:TemplateField HeaderText="Author">
                <ItemTemplate>
                    <%#Eval(expression:"AddBookAuthor") %>
                </ItemTemplate>
                </asp:TemplateField>
                </Columns>
          <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <HeaderStyle BackColor="#003399" Font-Bold="True"  ForeColor="#CCCCFF" />
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
        <RowStyle BackColor="White" ForeColor="#003399" />
        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <SortedAscendingCellStyle BackColor="#EDF6F6" />
        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
        <SortedDescendingCellStyle BackColor="#D6DFDF" />
        <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView>
</asp:Content>
