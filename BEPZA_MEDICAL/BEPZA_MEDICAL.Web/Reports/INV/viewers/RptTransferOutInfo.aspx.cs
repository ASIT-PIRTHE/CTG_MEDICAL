﻿using BEPZA_MEDICAL.DAL.PRM;
using BEPZA_MEDICAL.DAL.PMI;
using BEPZA_MEDICAL.Web.Utility;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity.Core.Objects;
using System.IO;

namespace BEPZA_MEDICAL.Web.Reports.INV.viewers
{
    public partial class RptTransferOutInfo : ReportBase
    {
       #region Fields

        bool checkStatus;

        #endregion

        #region Ctor
        public RptTransferOutInfo()
        {
            //
        }
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

        DateTime transferFromDate;
        DateTime transferToDate;
        string strZoneId = string.Empty;
        DateTime? challanFromDate = null;
        DateTime? challanToDate = null;
        int transferredToId = 0;
        int itemId = 0;
        int categoryId = 0;
        int typeId = 0;
        int colorId = 0;
        int modelId = 0;

        protected void btnViewReport_Click(object sender, EventArgs e)
        {
            try
            {
                checkStatus = false;

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

                strZoneId = ConvertZoneArrayListToString(arrZoneList);
                transferFromDate = Convert.ToDateTime(transferDtFromDate.Text);
                transferToDate = Convert.ToDateTime(transferDtToDate.Text);

                if (challanDtFromDate.Text != "")
                {
                    challanFromDate = Convert.ToDateTime(challanDtFromDate.Text);
                }
                if (challanDtToDate.Text != "")
                {
                    challanToDate = Convert.ToDateTime(challanDtToDate.Text);
                }
                if (ddlTransferredTo.SelectedIndex > 0)
                {
                    transferredToId = Convert.ToInt32(ddlTransferredTo.SelectedValue);
                }
                if (ddlItem.SelectedIndex > 0)
                {
                    itemId = Convert.ToInt32(ddlItem.SelectedValue);
                }
                if (ddlItemCategory.SelectedIndex > 0)
                {
                    categoryId = Convert.ToInt32(ddlItemCategory.SelectedValue);
                }
                if (ddlItemType.SelectedIndex > 0)
                {
                    typeId = Convert.ToInt32(ddlItemType.SelectedValue);
                }
                if (ddlItemColor.SelectedIndex > 0)
                {
                    colorId = Convert.ToInt32(ddlItemColor.SelectedValue);
                }
                if (ddlItemModel.SelectedIndex > 0)
                {
                    modelId = Convert.ToInt32(ddlItemModel.SelectedValue);
                }

                GenerateReport(transferFromDate, transferToDate, challanFromDate, challanToDate, transferredToId, itemId, categoryId, typeId, colorId, modelId, strZoneId);

                lblMsg.Text = "";

                if (checkStatus == true)
                {
                    lblMsg.Text = Utility.Common.GetCommomMessage(CommonMessage.DataNotFound);
                    lblMsg.ForeColor = System.Drawing.Color.Red;
                    rvTransferOutInfo.Reset();
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
        }

        #endregion

        #region Generate Report
        public void GenerateReport(DateTime transferFromDate, DateTime transferToDate, DateTime? challanFromDate, DateTime? challanToDate, int? transferredToId, int? itemId, int? categoryId, int? typeId, int? colorId, int? modelId, string strZoneId)
        {
            var numErrorCode = new ObjectParameter("numErrorCode", typeof(int));
            var strErrorMsg = new ObjectParameter("strErrorMsg", typeof(string));

            #region Processing Report Data

            rvTransferOutInfo.Reset();
            rvTransferOutInfo.ProcessingMode = ProcessingMode.Local;
            rvTransferOutInfo.LocalReport.ReportPath = Server.MapPath("~/Reports/INV/rdlc/RptTransferOutInfo.rdlc");

            var data = invContext.sp_INV_RptTransferOutInfo(transferFromDate, transferToDate, challanFromDate, challanToDate, transferredToId, itemId, categoryId, typeId, colorId, modelId, strZoneId, numErrorCode, strErrorMsg).ToList();

            if (data.Count() > 0)
            {
                #region Search parameter

                string searchParameters = string.Empty;
                searchParameters = "For the period from: "+transferFromDate.ToShortDateString() + " To " + transferToDate.ToShortDateString();
                ReportParameter p1 = new ReportParameter("param", searchParameters);
                rvTransferOutInfo.LocalReport.SetParameters(new ReportParameter[] { p1 });

                #endregion


                ReportDataSource dataSource = new ReportDataSource("dsTransferOutInfo", data);
                rvTransferOutInfo.LocalReport.DataSources.Add(dataSource);
                this.rvTransferOutInfo.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(localReport_SubreportProcessing);
            }
            else
            {
                checkStatus = true;
                rvTransferOutInfo.Reset();
            }
            rvTransferOutInfo.DataBind();


            //ExportToPDF
            String newFileName = "TransferOutInfo_" + Guid.NewGuid() + ".pdf";
            String newFilePath = "~/Content/TempFiles/" + newFileName;
            FileStream fs = new FileStream(Server.MapPath(newFilePath), FileMode.Create);
            BEPZA_MEDICAL.Web.Utility.Common.ExportPDF(rvTransferOutInfo, newFileName, fs);

            #endregion
        }

        void localReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            

            dynamic data = null;

            var dsName = string.Empty;
            
            switch (e.ReportPath)
            {
    

                case "_ReportHeader":
                    data = (from c in base.context.SP_PRM_GetReportHeaderByZoneID(LoggedUserZoneInfoId)
                            select c).ToList();
                    dsName = "DSCompanyInfo";
                    break;

                default:
                    break;
            }
            e.DataSources.Add(new ReportDataSource(dsName, data));
        }
        #endregion

        #region User Methods
        private void PopulateDropdownList()
        {
            var transferOutInfo = invContext.INV_TransferOutInfo.ToList();

            ddlItem.DataSource = invContext.INV_ItemInfo.OrderByDescending(x => x.ItemName).ToList();
            ddlItem.DataValueField = "Id";
            ddlItem.DataTextField = "ItemName";
            ddlItem.DataBind();
            ddlItem.Items.Insert(0, new ListItem("[Select One]", "0"));

            ddlItemCategory.DataSource = invContext.INV_Category.OrderBy(x => x.Name).ToList();
            ddlItemCategory.DataValueField = "Id";
            ddlItemCategory.DataTextField = "Name";
            ddlItemCategory.DataBind();
            ddlItemCategory.Items.Insert(0, new ListItem("[Select One]", "0"));

            ddlItemType.DataSource = invContext.INV_ItemType.OrderBy(x => x.ItemTypeName).ToList();
            ddlItemType.DataValueField = "Id";
            ddlItemType.DataTextField = "ItemTypeName";
            ddlItemType.DataBind();
            ddlItemType.Items.Insert(0, new ListItem("[Select One]", "0"));

            ddlItemColor.DataSource = invContext.INV_Color.OrderBy(x => x.Name).ToList();
            ddlItemColor.DataValueField = "Id";
            ddlItemColor.DataTextField = "Name";
            ddlItemColor.DataBind();
            ddlItemColor.Items.Insert(0, new ListItem("[Select One]", "0"));

            ddlItemModel.DataSource = invContext.INV_Model.OrderBy(x => x.Name).ToList();
            ddlItemModel.DataValueField = "Id";
            ddlItemModel.DataTextField = "Name";
            ddlItemModel.DataBind();
            ddlItemModel.Items.Insert(0, new ListItem("[Select One]", "0"));

            ddlTransferredTo.DataSource = prmContext.PRM_ZoneInfo.OrderByDescending(x => x.ZoneName).ToList();
            ddlTransferredTo.DataValueField = "Id";
            ddlTransferredTo.DataTextField = "ZoneName";
            ddlTransferredTo.DataBind();
            ddlTransferredTo.Items.Insert(0, new ListItem("[Select One]", "0"));

            ddlZone.DataSource = GetZoneDDL();
            ddlZone.DataValueField = "Value";
            ddlZone.DataTextField = "Text";
            ddlZone.DataBind();
            ddlZone.Items.FindByValue(LoggedUserZoneInfoId.ToString()).Selected = true;
        }
        #endregion

        protected void rvTransferOutInfo_ReportRefresh(object sender, CancelEventArgs e)
        {
            btnViewReport_Click(null, null);
        }


    }
}