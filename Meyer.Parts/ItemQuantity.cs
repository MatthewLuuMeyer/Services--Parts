using System;
using System.Collections.Generic;
using System.Text;

namespace Meyer.Parts
{
    public class ItemQuantity
    {
        public string ItemNumber { get; set; }
        public string LocationCode { get; set; }
        public string BinNumber { get; set; }
        public short RecordType { get; set; }
        public string PrimaryVendor { get; set; }
        public byte ItemFreezeFlag { get; set; }
        public decimal BeginningQuantity { get; set; }
        public decimal LastOrderQuantity { get; set; }
        public decimal LastReceiptQuantity { get; set; }
        public DateTime LastOrderDate { get; set; }
        public string LastOrderVendor { get; set; }
        public DateTime LastReceiptDate { get; set; }
        public decimal QuantityRequisitioned { get; set; }
        public decimal QuantityOnOrder { get; set; }
        public decimal QuantityBackOrdered { get; set; }
        public decimal QuantityDropShipped { get; set; }
        public decimal QuantityInUse { get; set; }
        public decimal QuantityInService { get; set; }
        public decimal QuantityReturned { get; set; }
        public decimal QuantityDamaged { get; set; }
        public decimal QuantityOnHand { get; set; }
        public decimal QuantityAllocated { get; set; }
        public decimal QuantityCommitted { get; set; }
        public decimal QuantitySold { get; set; }
        public DateTime NextCountDate { get; set; }
        public DateTime NextCountTime { get; set; }
        public DateTime LastCountDate { get; set; }
        public DateTime LastCountTime { get; set; }
        public short StockCountInterval { get; set; }
        public string LandedCostGroupId { get; set; }
        public string BuyerId { get; set; }
        public string PlannerId { get; set; }
        public short OrderPolicy { get; set; }
        public decimal FixedOrderQuantity { get; set; }
        public decimal OrderPointQuantity { get; set; }
        public short NumberOfDays { get; set; }
        public decimal MinimumOrderQuantity { get; set; }
        public decimal MaximumOrderQuantity { get; set; }
        public decimal OrderMultiple { get; set; }
        public short ReplenishmentMethod { get; set; }
        public decimal ShrinkageFactor { get; set; }
        public decimal PurchasingLeadTime { get; set; }
        public decimal ManufacturingFixedLeadTime { get; set; }
        public decimal ManufacturingVariableLeadTime { get; set; }
        public decimal StagingLeadTime { get; set; }
        public short PlanningTimeFenceDays { get; set; }
        public short DemandTimeFencePeriods { get; set; }
        public byte IncludedInPlanning { get; set; }
        public byte CalculateATP { get; set; }
        public byte AutoCheckATP { get; set; }
        public byte PlanFinalPAB { get; set; }
        public short ForecastConsumptionPeriod { get; set; }
        public decimal OrderUpToLevel { get; set; }
        public decimal SafetyStockQuantity { get; set; }
        public decimal ReorderVariance { get; set; }
        public string PurchaseReceiptBin { get; set; }
        public string PurchaseReturnsBin { get; set; }
        public string SOFulfillmentBin { get; set; }
        public string SOReturnBin { get; set; }
        public string BOMReceiptBin { get; set; }
        public string MaterialIssueBin { get; set; }
        public string MOReceiptBin { get; set; }
        public string RepairIssuesBin { get; set; }
        public short ReplenishmentLevel { get; set; }
        public short POPOrderMethod { get; set; }
        public string MasterLocationCode { get; set; }
        public short POPVendorSelection { get; set; }
        public short POPPricingSelection { get; set; }
        public decimal PurchasePrice { get; set; }
        public byte IncludeAllocations { get; set; }
        public byte IncludeBackorders { get; set; }
        public byte IncludeRequisitions { get; set; }
        public short PickingTicketItemOption { get; set; }
        public byte IncludeMRPMoveIn { get; set; }
        public byte IncludeMRPMoveOut { get; set; }
        public byte IncludeMRPCancel { get; set; }
        public short MoveOutFence { get; set; }
        public byte Inactive { get; set; }
        public int IndexRowId { get; set; }
    }
}
