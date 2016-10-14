<%@ Page Title="CounterStrike" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CounterStrike.aspx.cs" Inherits="TeamProject1._1.CounterStrike" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-offset-2 col-md-8">  
                <asp:GridView ID="CSGame1" runat="server" AutoGenerateColumns="false">

        <Columns>
            <asp:BoundField DataField="GAME" HeaderText="Counter_Strike" Visible ="true" />
             <asp:BoundField DataField="WEEK_NUMBER" HeaderText="WEEK_NUMBER" Visible ="true" />
             <asp:BoundField DataField="TEAM_1_ID" HeaderText="TEAM_1_ID" Visible ="true" />
             <asp:BoundField DataField="TEAM_2_ID" HeaderText="TEAM_2_ID" Visible ="true" />

        </Columns>

    </asp:GridView>

            </div>
        </div>
    </div>
    
</asp:Content>
