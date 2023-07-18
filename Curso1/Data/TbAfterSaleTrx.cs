using System;
using System.Collections.Generic;

namespace Curso1.Data;

public partial class TbAfterSaleTrx
{
    public decimal RefOfferId { get; set; }

    public string LineNumber { get; set; } = null!;

    public string? SolutionId { get; set; }

    public string? AsSolutionId { get; set; }

    public string? TrackingNumber { get; set; }

    public string? TransactionName { get; set; }

    public string? LastTransaction { get; set; }

    public string? ProductId { get; set; }

    public string? NewLineNumber { get; set; }

    public string? NewProductId { get; set; }

    public string? Currency { get; set; }

    public string? NewCurrency { get; set; }

    public string? Description { get; set; }

    public string? ProductType { get; set; }

    public decimal? BasePrice { get; set; }

    public decimal? NewBasePrice { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? NewUnitPrice { get; set; }

    public decimal? NetPrice { get; set; }

    public decimal? NewNetPrice { get; set; }

    public decimal? ManualPrice { get; set; }

    public decimal? NewManualPrice { get; set; }

    public decimal? RequestedPrice { get; set; }

    public decimal? ApprovedPrice { get; set; }

    public decimal? IvaPrice { get; set; }

    public decimal? ContractPrice { get; set; }

    public decimal? NewContractPrice { get; set; }

    public string? DueDate { get; set; }

    public string? Billable { get; set; }

    public string? Otc { get; set; }

    public string? OtcBlocked { get; set; }

    public string? NewOtc { get; set; }

    public string? NewOtcBlocked { get; set; }

    public string? RequiresQuantity { get; set; }

    public int? Quantity { get; set; }

    public string? OfferId { get; set; }

    public string? OfferNumber { get; set; }

    public string? LineItem { get; set; }

    public string? SrFactId { get; set; }

    public string? SrFactNumber { get; set; }

    public string? OrderId { get; set; }

    public string? OrderNumber { get; set; }

    public string? SrInstallId { get; set; }

    public string? SrInstallNumber { get; set; }

    public string? InitialAddressId { get; set; }

    public string? NewInitialAddressId { get; set; }

    public string? FinalAddressId { get; set; }

    public string? NewFinalAddressId { get; set; }

    public string? Status { get; set; }

    public short? TreeLevel { get; set; }

    public int? LinkNumber { get; set; }

    public int? NafTransaction { get; set; }

    public int? NewNafTransaction { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? NewQuantity { get; set; }

    public string? BillingStartDate { get; set; }

    public decimal? RemainingMonths { get; set; }

    public string? AssetIntegrationId { get; set; }

    public string? ServiceAccountId { get; set; }

    public string? BillingAccountId { get; set; }

    public string? BillingProfileId { get; set; }

    public string? AssetId { get; set; }

    public string? Recalculate { get; set; }

    public decimal? PrevRefOfferId { get; set; }

    public string? PrevLineNumber { get; set; }

    public string? PrevLineNumberDisplay { get; set; }

    public string? ActiveProduct { get; set; }
}
