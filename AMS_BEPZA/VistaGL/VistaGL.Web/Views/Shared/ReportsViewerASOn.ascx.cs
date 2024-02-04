﻿using Microsoft.Reporting.WebForms;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Web.Mvc;
using VistaGL.Modules.Reports;

namespace VistaGL.Views.Shared
{
    public partial class ReportsViewerASOn : ViewUserControl
    {
        #region Fields
        public SqlConnection con;
        #endregion

        #region Ctor
        public ReportsViewerASOn()
        {
            string constr = ConfigurationManager.ConnectionStrings["ACCDB"].ToString();
            con = new SqlConnection(constr);
        }
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetDate();
            }
        }

        private void GetDate()
        {
            if (Session["dt"] != null)
            {
                var model = TempData["model"] as ReportSearchViewModel;
                ReportViewer1.Reset();
                ReportViewer1.ProcessingMode = ProcessingMode.Local;
                ReportViewer1.LocalReport.ReportPath = Server.MapPath(Session["rpath"].ToString());
                ReportViewer1.LocalReport.Refresh();
                ReportViewer1.LocalReport.DataSources.Clear();


                string pReportPeriod = "";
                CultureInfo ci = new CultureInfo("en-US");
                if (model.FromDate != null)
                    pReportPeriod = model.FromDate.Value.ToString("dd-MMM-yyyy", ci);

                if (model.FromDate != null && model.ToDate != null)
                    pReportPeriod = model.FromDate.Value.ToString("dd-MMM-yyyy", ci) + " to " +
                                    model.ToDate.Value.ToString("dd-MMM-yyyy", ci);

                ReportParameter p12 = new ReportParameter("pReportPeriod", pReportPeriod);
                ReportViewer1.LocalReport.SetParameters(new ReportParameter[] { p12 });

                try
                {
                    ReportParameter p13 = new ReportParameter("pEntityName", model.pEntityName);
                    ReportViewer1.LocalReport.SetParameters(new ReportParameter[] { p13 });
                }
                catch (Exception) { }

                var dt = Session["dt"];

                ReportDataSource rdc = new ReportDataSource(Session["DataSet"].ToString(), dt);
                ReportViewer1.LocalReport.DataSources.Add(rdc);

                this.ReportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(localReport_SubreportProcessing);

                ReportViewer1.DataBind();

                if (model.IsOpenReportInNewTab)
                {
                    //ExportToPDF
                    String fileName = "ACCReport_" + Guid.NewGuid() + ".pdf";
                    ExportToPDFUtil.ExportToPDF(ReportViewer1, fileName);
                }
            }
        }

        void localReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            //DynamicParameters param = new DynamicParameters();
            //param.Add("@ZoneId", ((UserDefinition)Authorization.UserDefinition).ZoneID);
            //con.Open();
            //var dsName = "ZoneInfo";
            //var data = con.Query<ZoneInfoViewModel>("SP_PRM_GetReportHeaderByZoneID", param, commandType: CommandType.StoredProcedure).ToList();
            //con.Close();
            //e.DataSources.Add(new ReportDataSource(dsName, data));
        }
    }
}