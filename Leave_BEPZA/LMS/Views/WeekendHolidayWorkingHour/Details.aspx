﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Modal.Master" Inherits="System.Web.Mvc.ViewPage<LMS.Web.Models.WeekendHolidayWorkingHourModels>" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="divWeekendHolidayWorkingHourDetails">
        <% Html.RenderPartial("WeekendHolidayWorkingHourDetails"); %>
    </div>
</asp:Content>
