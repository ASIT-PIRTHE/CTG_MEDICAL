﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<LMS.Web.Models.ApprovalPathModels>" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">

        $(document).ready(function () {
            setTitle("Leave Approval Path");
            $("#ApprovalPath").click();

        });
    </script>
    <div id="divDataList">
    </div>
</asp:Content>
