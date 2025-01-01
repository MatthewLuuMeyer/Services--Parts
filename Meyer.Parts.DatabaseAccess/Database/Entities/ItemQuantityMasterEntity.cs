using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meyer.Parts.DatabaseAccess.Database.Entities
{
    [Table("IV00102")]
    public class ItemQuantityMasterEntity
    {
        [Key]
        [Column("ITEMNMBR", TypeName = "char(31)")]
        public string ItemNumber { get; set; }

        [Key]
        [Column("LOCNCODE", TypeName = "char(11)")]
        public string LocationCode { get; set; }

        [Key]
        [Column("BINNMBR", TypeName = "char(21)")]
        public string BinNumber { get; set; }

        [Column("RCRDTYPE")]
        public short RecordType { get; set; }

        [Column("PRIMVNDR", TypeName = "char(15)")]
        public string PrimaryVendor { get; set; }

        [Column("ITMFRFLG")]
        public byte ItemFreezeFlag { get; set; }

        [Column("BGNGQTY", TypeName = "numeric(19, 5)")]
        public decimal BeginningQuantity { get; set; }

        [Column("LSORDQTY", TypeName = "numeric(19, 5)")]
        public decimal LastOrderQuantity { get; set; }

        [Column("LRCPTQTY", TypeName = "numeric(19, 5)")]
        public decimal LastReceiptQuantity { get; set; }

        [Column("LSTORDDT")]
        public DateTime LastOrderDate { get; set; }

        [Column("LSORDVND", TypeName = "char(15)")]
        public string LastOrderVendor { get; set; }

        [Column("LSRCPTDT")]
        public DateTime LastReceiptDate { get; set; }

        [Column("QTYRQSTN", TypeName = "numeric(19, 5)")]
        public decimal QuantityRequisitioned { get; set; }

        [Column("QTYONORD", TypeName = "numeric(19, 5)")]
        public decimal QuantityOnOrder { get; set; }

        [Column("QTYBKORD", TypeName = "numeric(19, 5)")]
        public decimal QuantityBackOrdered { get; set; }

        [Column("QTY_Drop_Shipped", TypeName = "numeric(19, 5)")]
        public decimal QuantityDropShipped { get; set; }

        [Column("QTYINUSE", TypeName = "numeric(19, 5)")]
        public decimal QuantityInUse { get; set; }

        [Column("QTYINSVC", TypeName = "numeric(19, 5)")]
        public decimal QuantityInService { get; set; }

        [Column("QTYRTRND", TypeName = "numeric(19, 5)")]
        public decimal QuantityReturned { get; set; }

        [Column("QTYDMGED", TypeName = "numeric(19, 5)")]
        public decimal QuantityDamaged { get; set; }

        [Column("QTYONHND", TypeName = "numeric(19, 5)")]
        public decimal QuantityOnHand { get; set; }

        [Column("ATYALLOC", TypeName = "numeric(19, 5)")]
        public decimal QuantityAllocated { get; set; }

        [Column("QTYCOMTD", TypeName = "numeric(19, 5)")]
        public decimal QuantityCommitted { get; set; }

        [Column("QTYSOLD", TypeName = "numeric(19, 5)")]
        public decimal QuantitySold { get; set; }

        [Column("NXTCNTDT")]
        public DateTime NextCountDate { get; set; }

        [Column("NXTCNTTM")]
        public DateTime NextCountTime { get; set; }

        [Column("LSTCNTDT")]
        public DateTime LastCountDate { get; set; }

        [Column("LSTCNTTM")]
        public DateTime LastCountTime { get; set; }

        [Column("STCKCNTINTRVL")]
        public short StockCountInterval { get; set; }

        [Column("Landed_Cost_Group_ID", TypeName = "char(15)")]
        public string LandedCostGroupId { get; set; }

        [Column("BUYERID", TypeName = "char(15)")]
        public string BuyerId { get; set; }

        [Column("PLANNERID", TypeName = "char(15)")]
        public string PlannerId { get; set; }

        [Column("ORDERPOLICY")]
        public short OrderPolicy { get; set; }

        [Column("FXDORDRQTY", TypeName = "numeric(19, 5)")]
        public decimal FixedOrderQuantity { get; set; }

        [Column("ORDRPNTQTY", TypeName = "numeric(19, 5)")]
        public decimal OrderPointQuantity { get; set; }

        [Column("NMBROFDYS")]
        public short NumberOfDays { get; set; }

        [Column("MNMMORDRQTY", TypeName = "numeric(19, 5)")]
        public decimal MinimumOrderQuantity { get; set; }

        [Column("MXMMORDRQTY", TypeName = "numeric(19, 5)")]
        public decimal MaximumOrderQuantity { get; set; }

        [Column("ORDERMULTIPLE", TypeName = "numeric(19, 5)")]
        public decimal OrderMultiple { get; set; }

        [Column("REPLENISHMENTMETHOD")]
        public short ReplenishmentMethod { get; set; }

        [Column("SHRINKAGEFACTOR", TypeName = "numeric(19, 5)")]
        public decimal ShrinkageFactor { get; set; }

        [Column("PRCHSNGLDTM", TypeName = "numeric(19, 5)")]
        public decimal PurchasingLeadTime { get; set; }

        [Column("MNFCTRNGFXDLDTM", TypeName = "numeric(19, 5)")]
        public decimal ManufacturingFixedLeadTime { get; set; }

        [Column("MNFCTRNGVRBLLDTM", TypeName = "numeric(19, 5)")]
        public decimal ManufacturingVariableLeadTime { get; set; }

        [Column("STAGINGLDTME", TypeName = "numeric(19, 5)")]
        public decimal StagingLeadTime { get; set; }

        [Column("PLNNNGTMFNCDYS")]
        public short PlanningTimeFenceDays { get; set; }

        [Column("DMNDTMFNCPRDS")]
        public short DemandTimeFencePeriods { get; set; }

        [Column("INCLDDINPLNNNG")]
        public byte IncludedInPlanning { get; set; }

        [Column("CALCULATEATP")]
        public byte CalculateATP { get; set; }

        [Column("AUTOCHKATP")]
        public byte AutoCheckATP { get; set; }

        [Column("PLNFNLPAB")]
        public byte PlanFinalPAB { get; set; }

        [Column("FRCSTCNSMPTNPRD")]
        public short ForecastConsumptionPeriod { get; set; }

        [Column("ORDRUPTOLVL", TypeName = "numeric(19, 5)")]
        public decimal OrderUpToLevel { get; set; }

        [Column("SFTYSTCKQTY", TypeName = "numeric(19, 5)")]
        public decimal SafetyStockQuantity { get; set; }

        [Column("REORDERVARIANCE", TypeName = "numeric(19, 5)")]
        public decimal ReorderVariance { get; set; }

        [Column("PORECEIPTBIN", TypeName = "char(15)")]
        public string PurchaseReceiptBin { get; set; }

        [Column("PORETRNBIN", TypeName = "char(15)")]
        public string PurchaseReturnsBin { get; set; }

        [Column("SOFULFILLMENTBIN", TypeName = "char(15)")]
        public string SOFulfillmentBin { get; set; }

        [Column("SORETURNBIN", TypeName = "char(15)")]
        public string SOReturnBin { get; set; }

        [Column("BOMRCPTBIN", TypeName = "char(15)")]
        public string BOMReceiptBin { get; set; }

        [Column("MATERIALISSUEBIN", TypeName = "char(15)")]
        public string MaterialIssueBin { get; set; }

        [Column("MORECEIPTBIN", TypeName = "char(15)")]
        public string MOReceiptBin { get; set; }

        [Column("REPAIRISSUESBIN", TypeName = "char(15)")]
        public string RepairIssuesBin { get; set; }

        [Column("ReplenishmentLevel")]
        public short ReplenishmentLevel { get; set; }

        [Column("POPOrderMethod")]
        public short POPOrderMethod { get; set; }

        [Column("MasterLocationCode", TypeName = "char(11)")]
        public string MasterLocationCode { get; set; }

        [Column("POPVendorSelection")]
        public short POPVendorSelection { get; set; }

        [Column("POPPricingSelection")]
        public short POPPricingSelection { get; set; }

        [Column("PurchasePrice", TypeName = "numeric(19, 5)")]
        public decimal PurchasePrice { get; set; }

        [Column("IncludeAllocations")]
        public byte IncludeAllocations { get; set; }

        [Column("IncludeBackorders")]
        public byte IncludeBackorders { get; set; }

        [Column("IncludeRequisitions")]
        public byte IncludeRequisitions { get; set; }

        [Column("PICKTICKETITEMOPT")]
        public short PickingTicketItemOption { get; set; }

        [Column("INCLDMRPMOVEIN")]
        public byte IncludeMRPMoveIn { get; set; }

        [Column("INCLDMRPMOVEOUT")]
        public byte IncludeMRPMoveOut { get; set; }

        [Column("INCLDMRPCANCEL")]
        public byte IncludeMRPCancel { get; set; }

        [Column("Move_Out_Fence")]
        public short MoveOutFence { get; set; }

        [Column("INACTIVE")]
        public byte Inactive { get; set; }

        [Column("DEX_ROW_ID")]
        public int IndexRowId { get; set; }
    }
}
