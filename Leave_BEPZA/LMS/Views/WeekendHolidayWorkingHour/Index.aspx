﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<LMS.Web.Models.WeekendHolidayWorkingHourModels>" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">


        $(document).ready(function () {

            setTitle("Set Weekend/Holiday Working Hour");

            $("#WeekendHolidayWorkingHour").click();

        });
    </script>
    <div id="divDataList">
    </div>
</asp:Content>
