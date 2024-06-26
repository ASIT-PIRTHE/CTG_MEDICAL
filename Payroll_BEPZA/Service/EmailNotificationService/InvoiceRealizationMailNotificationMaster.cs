﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;


namespace EmailNotificationService
{
    public class InvoiceRealizationMailNotificationMaster : LogFilesWritting
    {
        public string smpt;
        public string FromemailAddress;
        public string FromemailPassword;

        public int NoOfPreviousMonthsConsider = default(int);
        public string EmailSendDateInMonthList;
        public int EmailSendDateInMonth;
        public string ToEmailAddress;
        public string CCEmailAddress;
        public string BCCEmailAddress;
        public string Subject;
        public string Salutation;
        public string BodyHeader;
        public string BodyFooter;
        public string ToEmailPersonName;
        public string EmailBody;
        public string tableHeaderBackgroundColor;
        public string tableBorderColor;
        public string NoRecordFound;
        public bool IsNoRecord = true;
        string content = string.Empty;


        public InvoiceRealizationMailNotificationMaster()
        {
            try
            {
                var xmlpath = System.IO.Directory.GetCurrentDirectory() + "\\Configuration.xml";
                var doc = new System.Xml.XPath.XPathDocument(xmlpath);
                var navigator = doc.CreateNavigator();

                smpt = navigator.SelectSingleNode("//appsettings/SMTP").Value;
                FromemailAddress = navigator.SelectSingleNode("//appsettings/FromEmail").Value;
                FromemailPassword = navigator.SelectSingleNode("//appsettings/FromEmailPassword").Value;

                NoOfPreviousMonthsConsider = Convert.ToInt16(navigator.SelectSingleNode("//PIMEmailNotification/InvoiceRealizationEmailNotification/NoOfPreviousMonthsConsider").Value);
                EmailSendDateInMonthList = navigator.SelectSingleNode("//PIMEmailNotification/InvoiceRealizationEmailNotification/EmailSendDateInMonth").Value;
                ToEmailAddress = navigator.SelectSingleNode("//PIMEmailNotification/InvoiceRealizationEmailNotification/ToEmailAddress").Value;
                CCEmailAddress = navigator.SelectSingleNode("//PIMEmailNotification/InvoiceRealizationEmailNotification/CCEmailAddress").Value;
                BCCEmailAddress = navigator.SelectSingleNode("//PIMEmailNotification/InvoiceRealizationEmailNotification/BCCEmailAddress").Value;

                Subject = navigator.SelectSingleNode("//PIMEmailNotification/InvoiceRealizationEmailNotification/Subject").Value;
                Salutation = navigator.SelectSingleNode("//PIMEmailNotification/InvoiceRealizationEmailNotification/Salutation").Value;
                BodyHeader = navigator.SelectSingleNode("//PIMEmailNotification/InvoiceRealizationEmailNotification/BodyHeader").Value;
                BodyFooter = navigator.SelectSingleNode("//PIMEmailNotification/InvoiceRealizationEmailNotification/BodyFooter").Value;
                NoRecordFound = navigator.SelectSingleNode("//PIMEmailNotification/InvoiceRealizationEmailNotification/NoRecordFound").Value;
                ToEmailPersonName = navigator.SelectSingleNode("//PIMEmailNotification/InvoiceRealizationEmailNotification/ToEmailPersonName").Value;

                tableHeaderBackgroundColor = navigator.SelectSingleNode("//ColorCode/TableHeaderBackgroundColor").Value;
                tableBorderColor = navigator.SelectSingleNode("//ColorCode/TableBorderColor").Value;

                List<int> EmailSendDateInMonthLists = new List<int>();
                if (EmailSendDateInMonthList.Length > 0)
                {
                    string[] list = EmailSendDateInMonthList.Split(',');
                    if (list.Count() > 0)
                    {
                        foreach (var item in list.Distinct())
                        {
                            if (Convert.ToInt32(item) == System.DateTime.Now.Day)
                            {
                                EmailSendDateInMonth = Convert.ToInt32(item);
                                break;
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                LogInfo(ex.Message);
            }
        }


        public void InvoiceRealizationScheduleMailSending()
        {
            DataSet dsResult = new DataSet();
            SqlConnection connection = null;

            string content = string.Empty;

            try
            {
                connection = Settings.GetConnectionInstance() as SqlConnection;
                connection.Open();

                // Start date is equals to current date and End date is equals to (startDate+NoOfAfterMonthsConsider)
                DateTime startDate = Convert.ToDateTime(System.DateTime.Now.Year + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Day);
                DateTime endDate = startDate.AddMonths(-NoOfPreviousMonthsConsider);

                SqlCommand command = new SqlCommand("SP_PIM_SendEmailForInvoiceRealize".Trim(), connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@FromDate", startDate);
                command.Parameters.AddWithValue("@ToDate", endDate);
                command.Parameters.AddWithValue("@ProjectId", 0);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dsResult);

                //DataTable dt = dsResult.Tables[0].DefaultView.ToTable(true, "EmpID", "EmialAddress", "FullName");  // Use for distinct data

                if (dsResult.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow drItem in dsResult.Tables[0].Rows)
                    {
                        string localSubjet = string.Empty;

                        int Id = Convert.ToInt32(drItem["Id"]);
                        string ProjectNo = Convert.ToString(drItem["ProjectNo"]);
                        string toEmial = Convert.ToString(drItem["PLEmialAddress"]).Trim();
                        string toCCEmialAddress = Convert.ToString(drItem["PSEmialAddress"]).Trim();
                        string PLName = Convert.ToString(drItem["PLName"]);
                        string PSName = Convert.ToString(drItem["PSName"]);
                        string CurrencyName = Convert.ToString(drItem["CurrencyName"]);

                        if (!string.IsNullOrEmpty(toCCEmialAddress))
                        {
                            CCEmailAddress += "," + toCCEmialAddress;
                        }
                        localSubjet = Subject + " for the project No- " + ProjectNo + " from " + startDate.ToString("dd-MMM-yyyy") + " to " + endDate.ToString("dd-MMM-yyyy");

                        InvoiceRealizationMailNotificationChild tsBodyMST = new InvoiceRealizationMailNotificationChild();
                        content = tsBodyMST.CreateBody(Id, NoOfPreviousMonthsConsider, CurrencyName);

                        EmailBody = "<html><body> <div style='display:block;'>" + Salutation + " " + PLName + ",</div></br>";
                        EmailBody += BodyHeader + "</br></br>" + content + "</br></br>";
                        EmailBody += "<div style='display:block;margin:10px 0;'>" + BodyFooter + "</div></body></html>";

                        EmailSending emailSending = new EmailSending();

                        if (emailSending.SendEmail(smpt, FromemailAddress, FromemailPassword, toEmial, CCEmailAddress, BCCEmailAddress, localSubjet, EmailBody, ""))
                        {
                            LogInfo("Successful- Invoice Realization. E-mail sent.");
                        }
                    }
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
        }
    }
}
