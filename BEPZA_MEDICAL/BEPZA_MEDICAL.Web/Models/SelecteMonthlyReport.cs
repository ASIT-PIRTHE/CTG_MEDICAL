using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace BEPZA_MEDICAL.Web.Models
{
    public class SelecteMonthlyReport
    {
        public string EmpID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public int SortingOrder { get; set; }
        public string ZoneName { get; set; }
        public int ZoneSortingOrder { get; set; }
        public decimal AvgProfitRate { get; set; }
        public decimal TotalEmpOpening { get; set; }
        public decimal TotalEmpProfitOpening { get; set; }
        public decimal TotalEmpContribution { get; set; }
        public decimal AvgEmpProfit { get; set; }
        public decimal TotalEmpFinalPayment { get; set; }
        public decimal TotalEmpWithdrawnInPeriod { get; set; }
        public decimal TotalEmpClosingBalance { get; set; }
        public decimal TotalEmpClosingBalanceProfit { get; set; }
        public decimal TotalComOpening { get; set; }
        public decimal TotalComProfitOpening { get; set; }
        public decimal TotalComContribution { get; set; }
        public decimal AvgComProfit { get; set; }
        public decimal TotalComFinalPayment { get; set; }
        public decimal TotalComWithdrawnInPeriod { get; set; }
        public decimal TotalComClosingBalance { get; set; }
        public decimal TotalComClosingBalanceProfit { get; set; }
        public decimal TotalTotalBalance { get; set; }
    }
}