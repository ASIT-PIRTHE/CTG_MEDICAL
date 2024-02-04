using BEPZA_MEDICAL.DAL.CPF;
using BEPZA_MEDICAL.Domain.CPF;
using BEPZA_MEDICAL.Domain.PRM;
using BEPZA_MEDICAL.Utility;
using BEPZA_MEDICAL.Web.Areas.CPF.Models.Report;
using BEPZA_MEDICAL.Web.Models;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Web.Mvc;

namespace BEPZA_MEDICAL.Web.Areas.CPF.Controllers
{
    public class ReportController : Controller
    {
        #region Fields

        private readonly ReportViewModel model;

        #endregion
      

        #region Ctor

        public ReportController()
        {
            model = new ReportViewModel();
        }

        #endregion

        public ActionResult CPFReportMaster(int Id)
        {
            model.ReportPath = Url.Content("~/Reports/CPF/viewers/CPFReportMaster.aspx?Id=" + Id);
            model.Id = Id;
            return View("ReportViewer", model);
        }

        public ActionResult IndividualMonthlyPFStatement()
        {
            model.ReportPath = Url.Content("~/Reports/CPF/viewers/CPFReportMaster.aspx?Id=" + Convert.ToByte(CPFEnum.CPFReports.Individual_Monthly_PF_Statement));
            return View("ReportViewer", model);
        }

        public ActionResult MonthlyPFStatement()
        {
            model.ReportPath = Url.Content("~/Reports/CPF/viewers/CPFReportMaster.aspx?Id=" + Convert.ToByte(CPFEnum.CPFReports.Monthly_PF_Statement));
            return View("ReportViewer", model);
        }

        public ActionResult MonthlyPFandLoanStatement1()
        {
            model.ReportPath = Url.Content("~/Reports/CPF/viewers/CPFReportMaster.aspx?Id=" + Convert.ToByte(CPFEnum.CPFReports.Monthly_PF_and_Loan_Statement_1));
            return View("ReportViewer", model);
        }
        public ActionResult MonthlyPFandLoanStatement2()
        {
            model.ReportPath = Url.Content("~/Reports/CPF/viewers/CPFReportMaster.aspx?Id=" + Convert.ToByte(CPFEnum.CPFReports.Monthly_PF_and_Loan_Statement_2));
            return View("ReportViewer", model);
        }

        public ActionResult MonthlyRefundableLoanStatement()
        {
            model.ReportPath = Url.Content("~/Reports/CPF/viewers/CPFReportMaster.aspx?Id=" + Convert.ToByte(CPFEnum.CPFReports.Monthly_Refundable_Loan_Statement));
            return View("ReportViewer", model);
        }
        public ActionResult MonthlyNonRefundableLoanStatement()
        {
            model.ReportPath = Url.Content("~/Reports/CPF/viewers/CPFReportMaster.aspx?Id=" + Convert.ToByte(CPFEnum.CPFReports.Monthly_Non_Refundable_Loan_Statement));
            return View("ReportViewer", model);
        }

        public ActionResult IndividualLoanCollectionStatement1()
        {
            model.ReportPath = Url.Content("~/Reports/CPF/viewers/CPFReportMaster.aspx?Id=" + Convert.ToByte(CPFEnum.CPFReports.Individual_Loan_Collection_Statement_1));
            return View("ReportViewer", model);
        }
        public ActionResult IndividualLoanCollectionStatement2()
        {
            model.ReportPath = Url.Content("~/Reports/CPF/viewers/CPFReportMaster.aspx?Id=" + Convert.ToByte(CPFEnum.CPFReports.Individual_Loan_Collection_Statement_2));
            return View("ReportViewer", model);
        }

        public ActionResult PFMembershipApplicationForm()
        {
            model.ReportPath = Url.Content("~/Reports/CPF/viewers/CPFReportMaster.aspx?Id=" + Convert.ToByte(CPFEnum.CPFReports.PF_Membership_Application_Form));
            return View("ReportViewer", model);
        }

        public ActionResult PFNomineeForm()
        {
            model.ReportPath = Url.Content("~/Reports/CPF/viewers/CPFReportMaster.aspx?Id=" + Convert.ToByte(CPFEnum.CPFReports.PF_Nominee_Form));
            return View("ReportViewer", model);
        }

        public ActionResult PFLoanApplicationForm()
        {
            model.ReportPath = Url.Content("~/Reports/CPF/viewers/CPFReportMaster.aspx?Id=" + Convert.ToByte(CPFEnum.CPFReports.PF_Loan_Application_Form));
            return View("ReportViewer", model);
        }

        public ActionResult MyPFStatement()
        {
            model.ReportPath = Url.Content("~/Reports/CPF/viewers/CPFReportMaster.aspx?Id=" + Convert.ToByte(CPFEnum.CPFReports.My_PF_Statement));
            return View("ReportViewer", model);
        }

        public ActionResult PFMembershipActiveInactive()
        {
            model.ReportPath = Url.Content("~/Reports/CPF/viewers/CPFReportMaster.aspx?Id=" + Convert.ToByte(CPFEnum.CPFReports.PF_Membership_Active_Inactive));
            return View("ReportViewer", model);
        }
        public ActionResult PFStatementHistory()
        {
            model.ReportPath = Url.Content("~/Reports/CPF/viewers/CPFReportMaster.aspx?Id=" + Convert.ToByte(CPFEnum.CPFReports.PF_Statement_History));
            return View("ReportViewer", model);
        }
        //public ActionResult SelectedMonthStatement()
        //{
        //    model.ReportPath = Url.Content("~/Reports/CPF/viewers/SelectedMonthlyStatement.html");
        //    return View("ReportViewer", model);
        //}
        public ActionResult SelectedMonthStatement()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GenerateReport(DateTime fromDate, DateTime toDate)
        {
            try
            {
                var list = ExecuteStoredProc(fromDate, toDate);
				try

                {
					LocalReport localReport = new LocalReport();
					localReport.ReportPath = Server.MapPath("~/Reports/CPF/rdlc/SelectedMonthStatement.rdlc");
					// Replace "YourNamespace" with the actual namespace where your report is located
					//var reportPath = @"BEPZA_MEDICAL\BEPZA_MEDICAL\BEPZA_MEDICAL.Web\Reports\CPF\rdlc\SelectedMonthStatement.rdlc";

                    // Use FileStream to read the report file
                    using (FileStream stream = new FileStream(localReport.ReportPath, FileMode.Open))
                    {
                        if (stream != null)
                        {
                            string frdat = fromDate.ToString("yyy-MM-dd");
                            string todat = toDate.ToString("yyy-MM-dd");
                           
                            localReport.LoadReportDefinition(stream);
                            localReport.DataSources.Add(new ReportDataSource("SelectedMonthlyStatement", list));

                            localReport.SetParameters(new ReportParameter("FromDate", frdat));
                            localReport.SetParameters(new ReportParameter("ToDate", todat));

                            var result = localReport.Render("PDF");
                            return File(result, "application/pdf", "MonthlySalaryStatement.pdf");
                        }
                        else
                        {
                            // Handle the case where the stream is null (report not found)
                            return HttpNotFound("Report not found");
                        }
                    }
                }
                catch (Exception e)
                {
                    // Handle exceptions
                    Console.WriteLine(e.ToString());
                }

                return View();
            }
            catch (Exception ex)
            {
                throw;
            }
         
        }
        // Define a method to execute the stored procedure and return the result
        List<SelecteMonthlyReport> ExecuteStoredProc(DateTime fromDate, DateTime toDate)
        {
            //var connectionString = "YourConnectionString"; // Replace with your actual connection string
            //var connectionString = ConfigurationManager.ConnectionStrings["ERP_BEPZACPFEntities"].ConnectionString;
            var connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            var list = new List<SelecteMonthlyReport>();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("dbo.CPF_SP_RptSelectedMonthStatement", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@StartDate", fromDate.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@EndDate", toDate.ToString("yyyy-MM-dd"));

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new SelecteMonthlyReport
                            {
                                EmpID = reader.GetString(reader.GetOrdinal("EmpID")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                Designation = reader.GetString(reader.GetOrdinal("Designation")),
                                SortingOrder = reader.GetInt32(reader.GetOrdinal("SortingOrder")),
                                ZoneName = reader.GetString(reader.GetOrdinal("ZoneName")),
                                ZoneSortingOrder = reader.GetInt32(reader.GetOrdinal("ZoneSortingOrder")),
                                AvgProfitRate = reader.GetDecimal(reader.GetOrdinal("AvgProfitRate")),
                                TotalEmpOpening = reader.GetDecimal(reader.GetOrdinal("TotalEmpOpening")),
                                TotalEmpProfitOpening = reader.GetDecimal(reader.GetOrdinal("TotalEmpProfitOpening")),
                                TotalEmpContribution = reader.GetDecimal(reader.GetOrdinal("TotalEmpContribution")),
                                AvgEmpProfit = reader.GetDecimal(reader.GetOrdinal("AvgEmpProfit")),
                                TotalEmpFinalPayment = reader.GetDecimal(reader.GetOrdinal("TotalEmpFinalPayment")),
                                TotalEmpWithdrawnInPeriod = reader.GetDecimal(reader.GetOrdinal("TotalEmpWithdrawnInPeriod")),
                                TotalEmpClosingBalance = reader.GetDecimal(reader.GetOrdinal("TotalEmpClosingBalance")),
                                TotalEmpClosingBalanceProfit = reader.GetDecimal(reader.GetOrdinal("TotalEmpClosingBalanceProfit")),
                                TotalComOpening = reader.GetDecimal(reader.GetOrdinal("TotalComOpening")),
                                TotalComProfitOpening = reader.GetDecimal(reader.GetOrdinal("TotalComProfitOpening")),
                                TotalComContribution = reader.GetDecimal(reader.GetOrdinal("TotalComContribution")),
                                AvgComProfit = reader.GetDecimal(reader.GetOrdinal("AvgComProfit")),
                                TotalComFinalPayment = reader.GetDecimal(reader.GetOrdinal("TotalComFinalPayment")),
                                TotalComWithdrawnInPeriod = reader.GetDecimal(reader.GetOrdinal("TotalComWithdrawnInPeriod")),
                                TotalComClosingBalance = reader.GetDecimal(reader.GetOrdinal("TotalComClosingBalance")),
                                TotalComClosingBalanceProfit = reader.GetDecimal(reader.GetOrdinal("TotalComClosingBalanceProfit")),
                                TotalTotalBalance = reader.GetDecimal(reader.GetOrdinal("TotalTotalBalance"))
                            };

                            list.Add(item);
                        }

                    }
                }
            }

            return list;
        }
        //-------------------
        public ActionResult CPFYearlyStatement()
        {
            model.ReportPath = Url.Content("~/Reports/CPF/viewers/CPFYearlyStatement.aspx");
            return View("ReportViewer", model);
        }

    }
}
