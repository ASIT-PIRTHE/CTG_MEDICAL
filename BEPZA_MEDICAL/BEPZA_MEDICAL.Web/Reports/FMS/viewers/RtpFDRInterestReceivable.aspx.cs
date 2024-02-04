﻿using BEPZA_MEDICAL.Web.Utility;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEPZA_MEDICAL.Web.Reports.FMS.viewers
{
    public partial class RtpFDRInterestReceivable : ReportBase
    {
        #region Fields
        #endregion

        #region Ctor
        #endregion

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                PopulateDropdownList();
            }
        }

        #endregion

        #region Button Event

        protected void btnViewReport_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> zoneList = new List<int>();
                int[] arrZoneList = new int[] { };
                foreach (ListItem item in ddlZone.Items)
                {
                    if (item.Selected)
                    {
                        zoneList.Add(Convert.ToInt32(item.Value));
                    }
                }
                arrZoneList = zoneList.ToArray();

                string strZoneId = ConvertZoneArrayListToString(arrZoneList);
                var FDRNo = txtFDRNo.Text;
                DateTime FDRDateFrom = Convert.ToDateTime(txtFRDDateFrom.Text);
                DateTime FDRDateTo = DateTime.Now;
                decimal? InstallmentRateFrom = null;
                if (txtInstallmentRateFrom.Text == "")
                {
                    InstallmentRateFrom = null;
                }
                else
                {
                    InstallmentRateFrom = Convert.ToDecimal(txtInstallmentRateFrom.Text);
                }
                decimal? InstallmentRateTo = null;
                if (txtInstallmentRateTo.Text == "")
                {
                    InstallmentRateTo = null;
                }
                else
                {
                    InstallmentRateTo = Convert.ToDecimal(txtInstallmentRateTo.Text);
                }

                GenerateReport(strZoneId, FDRNo, FDRDateFrom, FDRDateTo, InstallmentRateFrom, InstallmentRateTo);
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
        }

        #endregion

        #region Generate Report

        public void GenerateReport(string strZoneList, string FDRNo, DateTime FDRDateFrom, DateTime FDRDateTo, decimal? InterestRateFrom, decimal? InterestRateTo)
        {
            #region Processing Report Data

            rvFDRInstallmentInfo.Reset();
            rvFDRInstallmentInfo.ProcessingMode = ProcessingMode.Local;
            rvFDRInstallmentInfo.LocalReport.ReportPath = Server.MapPath("~/Reports/FMS/rdlc/RtpFDRInterestReceivable.rdlc");

            var data = (from s in base.fmsContext.SP_FMS_FDRInterestReceivable(strZoneList, FDRNo, FDRDateFrom, FDRDateTo, InterestRateFrom, InterestRateTo) select s).ToList();

            #region Search parameter
            string searchParameters = "STATEMENT OF FDR AND FDR INTEREST RECEIVABLE UP TO : " + FDRDateFrom.AddMonths(1).AddDays(-1).ToString("dd MMM yyyy");
            ReportParameter p1 = new ReportParameter("BalanceAsOn", searchParameters);
            ReportParameter p2 = new ReportParameter("FDRToDate", FDRDateTo.ToString());

            rvFDRInstallmentInfo.LocalReport.SetParameters(new ReportParameter[] { p1, p2 });

            #endregion


            ReportDataSource dataSource = new ReportDataSource("DSFDRInterestReceivable", data);
            rvFDRInstallmentInfo.LocalReport.DataSources.Add(dataSource);
            this.rvFDRInstallmentInfo.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(localReport_SubreportProcessing);
            rvFDRInstallmentInfo.DataBind();

            //ExportToPDF
            String newFileName = "FDRInstallmentInfo_" + Guid.NewGuid() + ".pdf";
            String newFilePath = "~/Content/TempFiles/" + newFileName;
            FileStream fs = new FileStream(Server.MapPath(newFilePath), FileMode.Create);
            BEPZA_MEDICAL.Web.Utility.Common.ExportPDF(rvFDRInstallmentInfo, newFileName, fs);

            #endregion
        }

        void localReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            dynamic data = null;
            var dsName = "DSCompanyInfo";
            data = (from c in base.context.SP_PRM_GetReportHeaderByZoneID(LoggedUserZoneInfoId)
                    select c).ToList();
            e.DataSources.Add(new ReportDataSource(dsName, data));
        }

        #endregion

        #region User Methods

        private void PopulateDropdownList()
        {
            ddlZone.DataSource = GetZoneDDL();
            ddlZone.DataValueField = "Value";
            ddlZone.DataTextField = "Text";
            ddlZone.DataBind();
            ddlZone.Items.FindByValue(LoggedUserZoneInfoId.ToString()).Selected = true;
        }

        #endregion

        protected void rvFDRInstallmentInfo_ReportRefresh(object sender, CancelEventArgs e)
        {
            btnViewReport_Click(null, null);
        }
    }
}