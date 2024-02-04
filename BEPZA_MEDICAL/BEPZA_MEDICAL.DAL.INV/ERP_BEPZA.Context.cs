﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BEPZA_MEDICAL.DAL.INV
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ERP_BEPZAINVEntities : DbContext
    {
        public ERP_BEPZAINVEntities()
            : base("name=ERP_BEPZAINVEntities")
        {
            // Get the ObjectContext related to this DbContext
            var objectContext = (this as IObjectContextAdapter).ObjectContext;

            // Sets the command timeout for all the commands
            objectContext.CommandTimeout = 3600;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CommonConfigType> CommonConfigTypes { get; set; }
        public virtual DbSet<INV_Category> INV_Category { get; set; }
        public virtual DbSet<INV_Color> INV_Color { get; set; }
        public virtual DbSet<INV_ItemStatus> INV_ItemStatus { get; set; }
        public virtual DbSet<INV_Manufacturer> INV_Manufacturer { get; set; }
        public virtual DbSet<INV_Model> INV_Model { get; set; }
        public virtual DbSet<INV_PurchaseType> INV_PurchaseType { get; set; }
        public virtual DbSet<INV_Unit> INV_Unit { get; set; }
        public virtual DbSet<INV_ItemInfo> INV_ItemInfo { get; set; }
        public virtual DbSet<PRM_ZoneInfo> PRM_ZoneInfo { get; set; }
        public virtual DbSet<INV_TransferInInfo> INV_TransferInInfo { get; set; }
        public virtual DbSet<INV_TransferOutInfo> INV_TransferOutInfo { get; set; }
        public virtual DbSet<INV_TransferInItem> INV_TransferInItem { get; set; }
        public virtual DbSet<INV_IssueItem> INV_IssueItem { get; set; }
        public virtual DbSet<INV_PurchaseItem> INV_PurchaseItem { get; set; }
        public virtual DbSet<INV_TransferOutItem> INV_TransferOutItem { get; set; }
        public virtual DbSet<INV_IssueReturnInfo> INV_IssueReturnInfo { get; set; }
        public virtual DbSet<INV_AdjustmentInfo> INV_AdjustmentInfo { get; set; }
        public virtual DbSet<INV_AdjustmentItem> INV_AdjustmentItem { get; set; }
        public virtual DbSet<INV_IssueReturnItem> INV_IssueReturnItem { get; set; }
        public virtual DbSet<INV_AssetQuotaInfo> INV_AssetQuotaInfo { get; set; }
        public virtual DbSet<INV_PeriodicAssetDuration> INV_PeriodicAssetDuration { get; set; }
        public virtual DbSet<INV_SupplierInfo> INV_SupplierInfo { get; set; }
        public virtual DbSet<INV_IssueInfo> INV_IssueInfo { get; set; }
        public virtual DbSet<INV_DelegationApprovalInfo> INV_DelegationApprovalInfo { get; set; }
        public virtual DbSet<vwINVItemHistory> vwINVItemHistory { get; set; }
        public virtual DbSet<PRM_EmploymentInfo> PRM_EmploymentInfo { get; set; }
        public virtual DbSet<INV_ScrapItem> INV_ScrapItem { get; set; }
        public virtual DbSet<INV_ItemType> INV_ItemType { get; set; }
        public virtual DbSet<INV_RequisitionInfo> INV_RequisitionInfo { get; set; }
        public virtual DbSet<INV_ScrapInfo> INV_ScrapInfo { get; set; }
        public virtual DbSet<INV_ScrapItemHistory> INV_ScrapItemHistory { get; set; }
        public virtual DbSet<vwINVBudgetHead> vwINVBudgetHead { get; set; }
        public virtual DbSet<INV_RequisitionItem> INV_RequisitionItem { get; set; }
        public virtual DbSet<INV_PurchaseInfo> INV_PurchaseInfo { get; set; }
    
        public virtual ObjectResult<sp_INV_RptPurchaseInfo_Result> sp_INV_RptPurchaseInfo(string zoneList, Nullable<System.DateTime> purchaseDateFrom, Nullable<System.DateTime> purchaseDateTo, Nullable<System.DateTime> pODateFrom, Nullable<System.DateTime> pODateTo, Nullable<System.DateTime> challanDateFrom, Nullable<System.DateTime> challanDateTo, Nullable<int> purchaseTypeId, Nullable<int> supplierId, Nullable<int> itemTypeId, Nullable<int> categoryId, Nullable<int> modelId, Nullable<int> colorId, Nullable<int> itemId, ObjectParameter numErrorCode, ObjectParameter strErrorMsg)
        {
            var zoneListParameter = zoneList != null ?
                new ObjectParameter("zoneList", zoneList) :
                new ObjectParameter("zoneList", typeof(string));
    
            var purchaseDateFromParameter = purchaseDateFrom.HasValue ?
                new ObjectParameter("PurchaseDateFrom", purchaseDateFrom) :
                new ObjectParameter("PurchaseDateFrom", typeof(System.DateTime));
    
            var purchaseDateToParameter = purchaseDateTo.HasValue ?
                new ObjectParameter("PurchaseDateTo", purchaseDateTo) :
                new ObjectParameter("PurchaseDateTo", typeof(System.DateTime));
    
            var pODateFromParameter = pODateFrom.HasValue ?
                new ObjectParameter("PODateFrom", pODateFrom) :
                new ObjectParameter("PODateFrom", typeof(System.DateTime));
    
            var pODateToParameter = pODateTo.HasValue ?
                new ObjectParameter("PODateTo", pODateTo) :
                new ObjectParameter("PODateTo", typeof(System.DateTime));
    
            var challanDateFromParameter = challanDateFrom.HasValue ?
                new ObjectParameter("ChallanDateFrom", challanDateFrom) :
                new ObjectParameter("ChallanDateFrom", typeof(System.DateTime));
    
            var challanDateToParameter = challanDateTo.HasValue ?
                new ObjectParameter("ChallanDateTo", challanDateTo) :
                new ObjectParameter("ChallanDateTo", typeof(System.DateTime));
    
            var purchaseTypeIdParameter = purchaseTypeId.HasValue ?
                new ObjectParameter("PurchaseTypeId", purchaseTypeId) :
                new ObjectParameter("PurchaseTypeId", typeof(int));
    
            var supplierIdParameter = supplierId.HasValue ?
                new ObjectParameter("SupplierId", supplierId) :
                new ObjectParameter("SupplierId", typeof(int));
    
            var itemTypeIdParameter = itemTypeId.HasValue ?
                new ObjectParameter("ItemTypeId", itemTypeId) :
                new ObjectParameter("ItemTypeId", typeof(int));
    
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("CategoryId", categoryId) :
                new ObjectParameter("CategoryId", typeof(int));
    
            var modelIdParameter = modelId.HasValue ?
                new ObjectParameter("ModelId", modelId) :
                new ObjectParameter("ModelId", typeof(int));
    
            var colorIdParameter = colorId.HasValue ?
                new ObjectParameter("ColorId", colorId) :
                new ObjectParameter("ColorId", typeof(int));
    
            var itemIdParameter = itemId.HasValue ?
                new ObjectParameter("ItemId", itemId) :
                new ObjectParameter("ItemId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_INV_RptPurchaseInfo_Result>("sp_INV_RptPurchaseInfo", zoneListParameter, purchaseDateFromParameter, purchaseDateToParameter, pODateFromParameter, pODateToParameter, challanDateFromParameter, challanDateToParameter, purchaseTypeIdParameter, supplierIdParameter, itemTypeIdParameter, categoryIdParameter, modelIdParameter, colorIdParameter, itemIdParameter, numErrorCode, strErrorMsg);
        }
    
        public virtual ObjectResult<sp_INV_RptTransferInInfo_Result> sp_INV_RptTransferInInfo(Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate, Nullable<System.DateTime> challanFromDate, Nullable<System.DateTime> challanToDate, Nullable<int> receivedFromId, Nullable<int> itemId, Nullable<int> categoryId, Nullable<int> typeId, Nullable<int> colorId, Nullable<int> modelId, string zoneList, ObjectParameter numErrorCode, ObjectParameter strErrorMsg)
        {
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("FromDate", fromDate) :
                new ObjectParameter("FromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("ToDate", toDate) :
                new ObjectParameter("ToDate", typeof(System.DateTime));
    
            var challanFromDateParameter = challanFromDate.HasValue ?
                new ObjectParameter("challanFromDate", challanFromDate) :
                new ObjectParameter("challanFromDate", typeof(System.DateTime));
    
            var challanToDateParameter = challanToDate.HasValue ?
                new ObjectParameter("challanToDate", challanToDate) :
                new ObjectParameter("challanToDate", typeof(System.DateTime));
    
            var receivedFromIdParameter = receivedFromId.HasValue ?
                new ObjectParameter("receivedFromId", receivedFromId) :
                new ObjectParameter("receivedFromId", typeof(int));
    
            var itemIdParameter = itemId.HasValue ?
                new ObjectParameter("itemId", itemId) :
                new ObjectParameter("itemId", typeof(int));
    
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("categoryId", categoryId) :
                new ObjectParameter("categoryId", typeof(int));
    
            var typeIdParameter = typeId.HasValue ?
                new ObjectParameter("typeId", typeId) :
                new ObjectParameter("typeId", typeof(int));
    
            var colorIdParameter = colorId.HasValue ?
                new ObjectParameter("colorId", colorId) :
                new ObjectParameter("colorId", typeof(int));
    
            var modelIdParameter = modelId.HasValue ?
                new ObjectParameter("modelId", modelId) :
                new ObjectParameter("modelId", typeof(int));
    
            var zoneListParameter = zoneList != null ?
                new ObjectParameter("zoneList", zoneList) :
                new ObjectParameter("zoneList", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_INV_RptTransferInInfo_Result>("sp_INV_RptTransferInInfo", fromDateParameter, toDateParameter, challanFromDateParameter, challanToDateParameter, receivedFromIdParameter, itemIdParameter, categoryIdParameter, typeIdParameter, colorIdParameter, modelIdParameter, zoneListParameter, numErrorCode, strErrorMsg);
        }
    
        public virtual ObjectResult<sp_INV_RptTransferOutInfo_Result> sp_INV_RptTransferOutInfo(Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate, Nullable<System.DateTime> challanFromDate, Nullable<System.DateTime> challanToDate, Nullable<int> transferredTo, Nullable<int> itemId, Nullable<int> categoryId, Nullable<int> typeId, Nullable<int> colorId, Nullable<int> modelId, string zoneList, ObjectParameter numErrorCode, ObjectParameter strErrorMsg)
        {
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("FromDate", fromDate) :
                new ObjectParameter("FromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("ToDate", toDate) :
                new ObjectParameter("ToDate", typeof(System.DateTime));
    
            var challanFromDateParameter = challanFromDate.HasValue ?
                new ObjectParameter("challanFromDate", challanFromDate) :
                new ObjectParameter("challanFromDate", typeof(System.DateTime));
    
            var challanToDateParameter = challanToDate.HasValue ?
                new ObjectParameter("challanToDate", challanToDate) :
                new ObjectParameter("challanToDate", typeof(System.DateTime));
    
            var transferredToParameter = transferredTo.HasValue ?
                new ObjectParameter("transferredTo", transferredTo) :
                new ObjectParameter("transferredTo", typeof(int));
    
            var itemIdParameter = itemId.HasValue ?
                new ObjectParameter("itemId", itemId) :
                new ObjectParameter("itemId", typeof(int));
    
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("categoryId", categoryId) :
                new ObjectParameter("categoryId", typeof(int));
    
            var typeIdParameter = typeId.HasValue ?
                new ObjectParameter("typeId", typeId) :
                new ObjectParameter("typeId", typeof(int));
    
            var colorIdParameter = colorId.HasValue ?
                new ObjectParameter("colorId", colorId) :
                new ObjectParameter("colorId", typeof(int));
    
            var modelIdParameter = modelId.HasValue ?
                new ObjectParameter("modelId", modelId) :
                new ObjectParameter("modelId", typeof(int));
    
            var zoneListParameter = zoneList != null ?
                new ObjectParameter("zoneList", zoneList) :
                new ObjectParameter("zoneList", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_INV_RptTransferOutInfo_Result>("sp_INV_RptTransferOutInfo", fromDateParameter, toDateParameter, challanFromDateParameter, challanToDateParameter, transferredToParameter, itemIdParameter, categoryIdParameter, typeIdParameter, colorIdParameter, modelIdParameter, zoneListParameter, numErrorCode, strErrorMsg);
        }
    
        public virtual ObjectResult<sp_INV_RptIssueInfo_Result> sp_INV_RptIssueInfo(string zoneList, Nullable<System.DateTime> issueDateFrom, Nullable<System.DateTime> issueDateTo, Nullable<System.DateTime> indentDateFrom, Nullable<System.DateTime> indentDateTo, Nullable<int> issuedToId, string issueNo, Nullable<int> indentId, Nullable<int> itemTypeId, Nullable<int> categoryId, Nullable<int> modelId, Nullable<int> colorId, Nullable<int> itemId, ObjectParameter numErrorCode, ObjectParameter strErrorMsg)
        {
            var zoneListParameter = zoneList != null ?
                new ObjectParameter("zoneList", zoneList) :
                new ObjectParameter("zoneList", typeof(string));
    
            var issueDateFromParameter = issueDateFrom.HasValue ?
                new ObjectParameter("IssueDateFrom", issueDateFrom) :
                new ObjectParameter("IssueDateFrom", typeof(System.DateTime));
    
            var issueDateToParameter = issueDateTo.HasValue ?
                new ObjectParameter("IssueDateTo", issueDateTo) :
                new ObjectParameter("IssueDateTo", typeof(System.DateTime));
    
            var indentDateFromParameter = indentDateFrom.HasValue ?
                new ObjectParameter("IndentDateFrom", indentDateFrom) :
                new ObjectParameter("IndentDateFrom", typeof(System.DateTime));
    
            var indentDateToParameter = indentDateTo.HasValue ?
                new ObjectParameter("IndentDateTo", indentDateTo) :
                new ObjectParameter("IndentDateTo", typeof(System.DateTime));
    
            var issuedToIdParameter = issuedToId.HasValue ?
                new ObjectParameter("IssuedToId", issuedToId) :
                new ObjectParameter("IssuedToId", typeof(int));
    
            var issueNoParameter = issueNo != null ?
                new ObjectParameter("IssueNo", issueNo) :
                new ObjectParameter("IssueNo", typeof(string));
    
            var indentIdParameter = indentId.HasValue ?
                new ObjectParameter("IndentId", indentId) :
                new ObjectParameter("IndentId", typeof(int));
    
            var itemTypeIdParameter = itemTypeId.HasValue ?
                new ObjectParameter("ItemTypeId", itemTypeId) :
                new ObjectParameter("ItemTypeId", typeof(int));
    
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("CategoryId", categoryId) :
                new ObjectParameter("CategoryId", typeof(int));
    
            var modelIdParameter = modelId.HasValue ?
                new ObjectParameter("ModelId", modelId) :
                new ObjectParameter("ModelId", typeof(int));
    
            var colorIdParameter = colorId.HasValue ?
                new ObjectParameter("ColorId", colorId) :
                new ObjectParameter("ColorId", typeof(int));
    
            var itemIdParameter = itemId.HasValue ?
                new ObjectParameter("ItemId", itemId) :
                new ObjectParameter("ItemId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_INV_RptIssueInfo_Result>("sp_INV_RptIssueInfo", zoneListParameter, issueDateFromParameter, issueDateToParameter, indentDateFromParameter, indentDateToParameter, issuedToIdParameter, issueNoParameter, indentIdParameter, itemTypeIdParameter, categoryIdParameter, modelIdParameter, colorIdParameter, itemIdParameter, numErrorCode, strErrorMsg);
        }
    
        public virtual ObjectResult<sp_INV_RptIssueReturn_Result> sp_INV_RptIssueReturn(string zoneList, Nullable<System.DateTime> returnDateFrom, Nullable<System.DateTime> returnDateTo, Nullable<int> receivedFromId, string returnNo, Nullable<int> itemTypeId, Nullable<int> categoryId, Nullable<int> modelId, Nullable<int> colorId, Nullable<int> itemId, ObjectParameter numErrorCode, ObjectParameter strErrorMsg)
        {
            var zoneListParameter = zoneList != null ?
                new ObjectParameter("zoneList", zoneList) :
                new ObjectParameter("zoneList", typeof(string));
    
            var returnDateFromParameter = returnDateFrom.HasValue ?
                new ObjectParameter("ReturnDateFrom", returnDateFrom) :
                new ObjectParameter("ReturnDateFrom", typeof(System.DateTime));
    
            var returnDateToParameter = returnDateTo.HasValue ?
                new ObjectParameter("ReturnDateTo", returnDateTo) :
                new ObjectParameter("ReturnDateTo", typeof(System.DateTime));
    
            var receivedFromIdParameter = receivedFromId.HasValue ?
                new ObjectParameter("ReceivedFromId", receivedFromId) :
                new ObjectParameter("ReceivedFromId", typeof(int));
    
            var returnNoParameter = returnNo != null ?
                new ObjectParameter("ReturnNo", returnNo) :
                new ObjectParameter("ReturnNo", typeof(string));
    
            var itemTypeIdParameter = itemTypeId.HasValue ?
                new ObjectParameter("ItemTypeId", itemTypeId) :
                new ObjectParameter("ItemTypeId", typeof(int));
    
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("CategoryId", categoryId) :
                new ObjectParameter("CategoryId", typeof(int));
    
            var modelIdParameter = modelId.HasValue ?
                new ObjectParameter("ModelId", modelId) :
                new ObjectParameter("ModelId", typeof(int));
    
            var colorIdParameter = colorId.HasValue ?
                new ObjectParameter("ColorId", colorId) :
                new ObjectParameter("ColorId", typeof(int));
    
            var itemIdParameter = itemId.HasValue ?
                new ObjectParameter("ItemId", itemId) :
                new ObjectParameter("ItemId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_INV_RptIssueReturn_Result>("sp_INV_RptIssueReturn", zoneListParameter, returnDateFromParameter, returnDateToParameter, receivedFromIdParameter, returnNoParameter, itemTypeIdParameter, categoryIdParameter, modelIdParameter, colorIdParameter, itemIdParameter, numErrorCode, strErrorMsg);
        }
    
        public virtual ObjectResult<sp_INV_RptItemLedger_Result> sp_INV_RptItemLedger(string zoneList, Nullable<System.DateTime> dateFrom, Nullable<System.DateTime> dateTo, Nullable<int> itemTypeId, Nullable<int> categoryId, Nullable<int> modelId, Nullable<int> colorId, Nullable<int> itemId, Nullable<int> assetGroupId, ObjectParameter numErrorCode, ObjectParameter strErrorMsg)
        {
            var zoneListParameter = zoneList != null ?
                new ObjectParameter("zoneList", zoneList) :
                new ObjectParameter("zoneList", typeof(string));
    
            var dateFromParameter = dateFrom.HasValue ?
                new ObjectParameter("DateFrom", dateFrom) :
                new ObjectParameter("DateFrom", typeof(System.DateTime));
    
            var dateToParameter = dateTo.HasValue ?
                new ObjectParameter("DateTo", dateTo) :
                new ObjectParameter("DateTo", typeof(System.DateTime));
    
            var itemTypeIdParameter = itemTypeId.HasValue ?
                new ObjectParameter("ItemTypeId", itemTypeId) :
                new ObjectParameter("ItemTypeId", typeof(int));
    
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("CategoryId", categoryId) :
                new ObjectParameter("CategoryId", typeof(int));
    
            var modelIdParameter = modelId.HasValue ?
                new ObjectParameter("ModelId", modelId) :
                new ObjectParameter("ModelId", typeof(int));
    
            var colorIdParameter = colorId.HasValue ?
                new ObjectParameter("ColorId", colorId) :
                new ObjectParameter("ColorId", typeof(int));
    
            var itemIdParameter = itemId.HasValue ?
                new ObjectParameter("ItemId", itemId) :
                new ObjectParameter("ItemId", typeof(int));
    
            var assetGroupIdParameter = assetGroupId.HasValue ?
                new ObjectParameter("AssetGroupId", assetGroupId) :
                new ObjectParameter("AssetGroupId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_INV_RptItemLedger_Result>("sp_INV_RptItemLedger", zoneListParameter, dateFromParameter, dateToParameter, itemTypeIdParameter, categoryIdParameter, modelIdParameter, colorIdParameter, itemIdParameter, assetGroupIdParameter, numErrorCode, strErrorMsg);
        }
    
        public virtual ObjectResult<sp_INV_RptEmployeeWiseItemLedger_Result> sp_INV_RptEmployeeWiseItemLedger(string zoneList, Nullable<System.DateTime> dateFrom, Nullable<System.DateTime> dateTo, Nullable<int> employeeId, Nullable<int> itemTypeId, Nullable<int> categoryId, Nullable<int> modelId, Nullable<int> colorId, Nullable<int> itemId, Nullable<int> assetGroupId, ObjectParameter numErrorCode, ObjectParameter strErrorMsg)
        {
            var zoneListParameter = zoneList != null ?
                new ObjectParameter("zoneList", zoneList) :
                new ObjectParameter("zoneList", typeof(string));
    
            var dateFromParameter = dateFrom.HasValue ?
                new ObjectParameter("DateFrom", dateFrom) :
                new ObjectParameter("DateFrom", typeof(System.DateTime));
    
            var dateToParameter = dateTo.HasValue ?
                new ObjectParameter("DateTo", dateTo) :
                new ObjectParameter("DateTo", typeof(System.DateTime));
    
            var employeeIdParameter = employeeId.HasValue ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(int));
    
            var itemTypeIdParameter = itemTypeId.HasValue ?
                new ObjectParameter("ItemTypeId", itemTypeId) :
                new ObjectParameter("ItemTypeId", typeof(int));
    
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("CategoryId", categoryId) :
                new ObjectParameter("CategoryId", typeof(int));
    
            var modelIdParameter = modelId.HasValue ?
                new ObjectParameter("ModelId", modelId) :
                new ObjectParameter("ModelId", typeof(int));
    
            var colorIdParameter = colorId.HasValue ?
                new ObjectParameter("ColorId", colorId) :
                new ObjectParameter("ColorId", typeof(int));
    
            var itemIdParameter = itemId.HasValue ?
                new ObjectParameter("ItemId", itemId) :
                new ObjectParameter("ItemId", typeof(int));
    
            var assetGroupIdParameter = assetGroupId.HasValue ?
                new ObjectParameter("AssetGroupId", assetGroupId) :
                new ObjectParameter("AssetGroupId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_INV_RptEmployeeWiseItemLedger_Result>("sp_INV_RptEmployeeWiseItemLedger", zoneListParameter, dateFromParameter, dateToParameter, employeeIdParameter, itemTypeIdParameter, categoryIdParameter, modelIdParameter, colorIdParameter, itemIdParameter, assetGroupIdParameter, numErrorCode, strErrorMsg);
        }
    
        [DbFunction("ERP_BEPZAINVEntities", "fn_INV_GetItemBalanceByMRR")]
        public virtual IQueryable<fn_INV_GetItemBalanceByMRR_Result> fn_INV_GetItemBalanceByMRR(Nullable<System.DateTime> dATE, Nullable<int> itemId, Nullable<int> purchaseId)
        {
            var dATEParameter = dATE.HasValue ?
                new ObjectParameter("DATE", dATE) :
                new ObjectParameter("DATE", typeof(System.DateTime));
    
            var itemIdParameter = itemId.HasValue ?
                new ObjectParameter("ItemId", itemId) :
                new ObjectParameter("ItemId", typeof(int));
    
            var purchaseIdParameter = purchaseId.HasValue ?
                new ObjectParameter("PurchaseId", purchaseId) :
                new ObjectParameter("PurchaseId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_INV_GetItemBalanceByMRR_Result>("[ERP_BEPZAINVEntities].[fn_INV_GetItemBalanceByMRR](@DATE, @ItemId, @PurchaseId)", dATEParameter, itemIdParameter, purchaseIdParameter);
        }
    
        [DbFunction("ERP_BEPZAINVEntities", "fn_INV_GetItemClosingBalance")]
        public virtual IQueryable<fn_INV_GetItemClosingBalance_Result> fn_INV_GetItemClosingBalance(Nullable<System.DateTime> dATE, Nullable<int> itemId, string zoneList)
        {
            var dATEParameter = dATE.HasValue ?
                new ObjectParameter("DATE", dATE) :
                new ObjectParameter("DATE", typeof(System.DateTime));
    
            var itemIdParameter = itemId.HasValue ?
                new ObjectParameter("ItemId", itemId) :
                new ObjectParameter("ItemId", typeof(int));
    
            var zoneListParameter = zoneList != null ?
                new ObjectParameter("zoneList", zoneList) :
                new ObjectParameter("zoneList", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_INV_GetItemClosingBalance_Result>("[ERP_BEPZAINVEntities].[fn_INV_GetItemClosingBalance](@DATE, @ItemId, @zoneList)", dATEParameter, itemIdParameter, zoneListParameter);
        }
    
        [DbFunction("ERP_BEPZAINVEntities", "fn_INV_GetItemOpeningBalance")]
        public virtual IQueryable<fn_INV_GetItemOpeningBalance_Result> fn_INV_GetItemOpeningBalance(Nullable<System.DateTime> dATE, Nullable<int> itemId, string zoneList)
        {
            var dATEParameter = dATE.HasValue ?
                new ObjectParameter("DATE", dATE) :
                new ObjectParameter("DATE", typeof(System.DateTime));
    
            var itemIdParameter = itemId.HasValue ?
                new ObjectParameter("ItemId", itemId) :
                new ObjectParameter("ItemId", typeof(int));
    
            var zoneListParameter = zoneList != null ?
                new ObjectParameter("zoneList", zoneList) :
                new ObjectParameter("zoneList", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_INV_GetItemOpeningBalance_Result>("[ERP_BEPZAINVEntities].[fn_INV_GetItemOpeningBalance](@DATE, @ItemId, @zoneList)", dATEParameter, itemIdParameter, zoneListParameter);
        }
    
        public virtual ObjectResult<sp_INV_PendingRequisitionList_Result> sp_INV_PendingRequisitionList(Nullable<int> zoneInfoId, Nullable<int> indentId)
        {
            var zoneInfoIdParameter = zoneInfoId.HasValue ?
                new ObjectParameter("ZoneInfoId", zoneInfoId) :
                new ObjectParameter("ZoneInfoId", typeof(int));
    
            var indentIdParameter = indentId.HasValue ?
                new ObjectParameter("IndentId", indentId) :
                new ObjectParameter("IndentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_INV_PendingRequisitionList_Result>("sp_INV_PendingRequisitionList", zoneInfoIdParameter, indentIdParameter);
        }
    
        public virtual ObjectResult<sp_INV_PendingTransferList_Result> sp_INV_PendingTransferList(Nullable<int> zoneInfoId, Nullable<int> transferOutId)
        {
            var zoneInfoIdParameter = zoneInfoId.HasValue ?
                new ObjectParameter("ZoneInfoId", zoneInfoId) :
                new ObjectParameter("ZoneInfoId", typeof(int));
    
            var transferOutIdParameter = transferOutId.HasValue ?
                new ObjectParameter("TransferOutId", transferOutId) :
                new ObjectParameter("TransferOutId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_INV_PendingTransferList_Result>("sp_INV_PendingTransferList", zoneInfoIdParameter, transferOutIdParameter);
        }
    
        public virtual ObjectResult<sp_INV_PendingScrapList_Result> sp_INV_PendingScrapList(Nullable<int> zoneInfoId, Nullable<int> scrapId)
        {
            var zoneInfoIdParameter = zoneInfoId.HasValue ?
                new ObjectParameter("ZoneInfoId", zoneInfoId) :
                new ObjectParameter("ZoneInfoId", typeof(int));
    
            var scrapIdParameter = scrapId.HasValue ?
                new ObjectParameter("ScrapId", scrapId) :
                new ObjectParameter("ScrapId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_INV_PendingScrapList_Result>("sp_INV_PendingScrapList", zoneInfoIdParameter, scrapIdParameter);
        }
    
        public virtual ObjectResult<APV_GetINVRequisitionApplication_Result> APV_GetINVRequisitionApplication(string approverId, Nullable<int> approvalProcessId, Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate, Nullable<int> approvalStatusId)
        {
            var approverIdParameter = approverId != null ?
                new ObjectParameter("ApproverId", approverId) :
                new ObjectParameter("ApproverId", typeof(string));
    
            var approvalProcessIdParameter = approvalProcessId.HasValue ?
                new ObjectParameter("ApprovalProcessId", approvalProcessId) :
                new ObjectParameter("ApprovalProcessId", typeof(int));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("EndDate", endDate) :
                new ObjectParameter("EndDate", typeof(System.DateTime));
    
            var approvalStatusIdParameter = approvalStatusId.HasValue ?
                new ObjectParameter("ApprovalStatusId", approvalStatusId) :
                new ObjectParameter("ApprovalStatusId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<APV_GetINVRequisitionApplication_Result>("APV_GetINVRequisitionApplication", approverIdParameter, approvalProcessIdParameter, startDateParameter, endDateParameter, approvalStatusIdParameter);
        }
    
        public virtual ObjectResult<sp_INV_RptStockBalance_Result> sp_INV_RptStockBalance(string zoneList, Nullable<System.DateTime> dateFrom, Nullable<System.DateTime> dateTo, Nullable<int> itemTypeId, Nullable<int> categoryId, Nullable<int> modelId, Nullable<int> colorId, Nullable<int> itemId, ObjectParameter numErrorCode, ObjectParameter strErrorMsg)
        {
            var zoneListParameter = zoneList != null ?
                new ObjectParameter("zoneList", zoneList) :
                new ObjectParameter("zoneList", typeof(string));
    
            var dateFromParameter = dateFrom.HasValue ?
                new ObjectParameter("DateFrom", dateFrom) :
                new ObjectParameter("DateFrom", typeof(System.DateTime));
    
            var dateToParameter = dateTo.HasValue ?
                new ObjectParameter("DateTo", dateTo) :
                new ObjectParameter("DateTo", typeof(System.DateTime));
    
            var itemTypeIdParameter = itemTypeId.HasValue ?
                new ObjectParameter("ItemTypeId", itemTypeId) :
                new ObjectParameter("ItemTypeId", typeof(int));
    
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("CategoryId", categoryId) :
                new ObjectParameter("CategoryId", typeof(int));
    
            var modelIdParameter = modelId.HasValue ?
                new ObjectParameter("ModelId", modelId) :
                new ObjectParameter("ModelId", typeof(int));
    
            var colorIdParameter = colorId.HasValue ?
                new ObjectParameter("ColorId", colorId) :
                new ObjectParameter("ColorId", typeof(int));
    
            var itemIdParameter = itemId.HasValue ?
                new ObjectParameter("ItemId", itemId) :
                new ObjectParameter("ItemId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_INV_RptStockBalance_Result>("sp_INV_RptStockBalance", zoneListParameter, dateFromParameter, dateToParameter, itemTypeIdParameter, categoryIdParameter, modelIdParameter, colorIdParameter, itemIdParameter, numErrorCode, strErrorMsg);
        }
    
        public virtual ObjectResult<INV_uspAdjustmentVoucherPosting_Result> INV_uspAdjustmentVoucherPosting(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<INV_uspAdjustmentVoucherPosting_Result>("INV_uspAdjustmentVoucherPosting", idParameter);
        }
    
        public virtual ObjectResult<INV_uspPurchaseVoucherPosting_Result> INV_uspPurchaseVoucherPosting(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<INV_uspPurchaseVoucherPosting_Result>("INV_uspPurchaseVoucherPosting", idParameter);
        }
    }
}