﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Modal.Master" Inherits="System.Web.Mvc.ViewPage<LMS.Web.Models.MembershipTypeNameModels>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   <div id="dvMembershipTypeNameDetails">
        <% Html.RenderPartial("MembershipTypeNameDetails"); %>
    </div>

</asp:Content>
