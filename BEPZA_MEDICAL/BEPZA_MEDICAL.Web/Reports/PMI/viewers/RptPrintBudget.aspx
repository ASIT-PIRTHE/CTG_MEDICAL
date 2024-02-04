﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Reports/Common/MasterPage/ReportMaster.Master" AutoEventWireup="true" CodeBehind="RptPrintBudget.aspx.cs" Inherits="BEPZA_MEDICAL.Web.Reports.PMI.viewers.RptPrintBudget" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
        <ContentTemplate>
            <rsweb:reportviewer id="rvWorkWiseBudget" runat="server" width="100%" height="100%" AsyncRendering="true" SizeToReportContent="True"
                onreportrefresh="rvWorkWiseBudget_ReportRefresh">
            </rsweb:reportviewer>
            <div class="clear">
            </div>

        </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="rvWorkWiseBudget" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>