﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace EmailNotificationService
{
   public class InvoiceMadeMailNotificationChild : LogFilesWritting
    {

        public string tableHeaderBackgroundColor;
        public string tableBorderColor;
        public bool IsNoRecord = true;
        string content = string.Empty;


        public InvoiceMadeMailNotificationChild()
        {
            try
            {
                var xmlpath = System.IO.Directory.GetCurrentDirectory() + "\\Configuration.xml";
                var doc = new System.Xml.XPath.XPathDocument(xmlpath);
                var navigator = doc.CreateNavigator();

                tableHeaderBackgroundColor = navigator.SelectSingleNode("//ColorCode/TableHeaderBackgroundColor").Value;
                tableBorderColor = navigator.SelectSingleNode("//ColorCode/TableBorderColor").Value;
            }

            catch (Exception ex)
            {
                LogInfo(ex.Message);
            }
        }

        public string CreateBody(int ProjectId, int NoOfAfterMonthsConsider, string CurrencyName)
        {
            DataSet dsResult = new DataSet();
            SqlConnection connection = null;

            try
            {
                connection = Settings.GetConnectionInstance() as SqlConnection;
                connection.Open();

                // Start date is equals to current date and End date is equals to (startDate+NoOfAfterMonthsConsider)
                DateTime startDate = Convert.ToDateTime(System.DateTime.Now.Year + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Day);
                DateTime endDate = startDate.AddMonths(NoOfAfterMonthsConsider);

                SqlCommand command = new SqlCommand("SP_PIM_SendEmailForInvoiceMade".Trim(), connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@FromDate", startDate);
                command.Parameters.AddWithValue("@ToDate", endDate);
                command.Parameters.AddWithValue("@ProjectId", ProjectId);


                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dsResult);

                if (dsResult.Tables[0].Rows.Count > 0)
                {

                    content = "<table id='contentTable' style='border-collapse:collapse;border:" + tableBorderColor + ";margin-left:10px; width:80%;'>";
                    content += "<thead style='width:80%;padding:1px;background:" + tableHeaderBackgroundColor + "; text-align:center; font-family:bold;'>";
                    content += "<th style='border-collapse:collapse;border:" + tableBorderColor + ";'>Invoice No.</th>";
                    content += "<th style='border-collapse:collapse;border:" + tableBorderColor + ";'>Installment No.</th>";
                    content += "<th style='border-collapse:collapse;border:" + tableBorderColor + ";'>Item Name</th>";
                    content += "<th style='border-collapse:collapse;border:" + tableBorderColor + ";'>Amount ("+CurrencyName+")</th>";
                    content += "<th style='border-collapse:collapse;border:" + tableBorderColor + ";'>Invoice Made Planed Date</th>";
                    content += "</thead><tbody style='width:80%;'>";

                    foreach (DataRow dr in dsResult.Tables[0].Rows)
                    {
                        var InvoiceNo = dr["InvoiceNo"];
                        var InstallmentNo = dr["InstallmentNo"];
                        var Item = dr["Item"];
                        var AmountInCurrency = string.Format("{0:N}", Convert.ToDecimal(dr["AmountInCurrency"]));  //("{0:N}", 2500000)
                        var DateofPlan = Convert.ToDateTime(dr["DateofPlan"]).ToString("dd-MMM-yyyy");

                        content += "<tr style='width:80%;'><td style='border-collapse:collapse;border:" + tableBorderColor + ";'>";
                        content += InvoiceNo + "</td><td style='border-collapse:collapse;border:" + tableBorderColor + ";'>";
                        content += InstallmentNo + "</td><td style='border-collapse:collapse;border:" + tableBorderColor + ";'>";
                        content += Item + "</td><td style='border-collapse:collapse;border:" + tableBorderColor + ";text-align:right;'>";
                        content += AmountInCurrency + "</td><td style='border-collapse:collapse;border:" + tableBorderColor + ";text-align:center;'>";
                        content += DateofPlan + "</td></tr>";

                    }
                    content += "</tbody></table>";
                }
                else
                {
                    IsNoRecord = false;
                }
            }
            catch (SqlException ex)
            {
                LogInfo(ex.Message);
            }

            return content;
        }
    }
}
