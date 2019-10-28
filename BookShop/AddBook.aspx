<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="BookShop.AddBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>ADD BOOK</h2>
    
  <div class="form-group row">
    <label for="inputPassword" class="col-sm-2 col-form-label">NAME</label>
    <div class="col-sm-10">
      <input type="Text" class="form-control" id="addBookName" runat="server" placeholder="Enter Book Name">
    </div>
  </div>
         <div class="form-group row">
    <label for="inputPassword" class="col-sm-2 col-form-label">ISBN</label>
    <div class="col-sm-10">
      <input type="Text" class="form-control" id="addBookIsbn" runat="server"  placeholder="Enter ISBN Number">
    </div>
  </div>
         <div class="form-group row">
    <label for="inputPassword" class="col-sm-2 col-form-label">AUTHOR</label>
    <div class="col-sm-10">
      <input type="Text" class="form-control" id="addBookAuthor" runat="server"  placeholder="Enter Author Name">
    </div>
  </div>
  
     <asp:Button ID="saveButton" class="btn btn-primary" runat="server" Text="Save" OnClick="saveButton_Click" />
      <br/>
   <label id="messageLebel" runat="server" class="col-sm-2 col-form-label"></label>

</asp:Content>
