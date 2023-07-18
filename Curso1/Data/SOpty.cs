using System;
using System.Collections.Generic;

namespace Curso1.Data;

public partial class SOpty
{
    public string RowId { get; set; } = null!;

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime LastUpd { get; set; }

    public string LastUpdBy { get; set; } = null!;

    public decimal? DckingNum { get; set; }

    public int ModificationNum { get; set; }

    public string ConflictId { get; set; } = null!;

    public string BuId { get; set; } = null!;

    public string ClosedFlg { get; set; } = null!;

    public string ExecPriorityFlg { get; set; } = null!;

    public string HstAfflFlg { get; set; } = null!;

    public string InactiveFlg { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string PrBuDnrmFlg { get; set; } = null!;

    public string PrBuManlFlg { get; set; } = null!;

    public string PrBuSysFlg { get; set; } = null!;

    public string RevnSplitFlg { get; set; } = null!;

    public string SumCommitFlg { get; set; } = null!;

    public string TemplateFlg { get; set; } = null!;

    public string? ConsumerOptyFlg { get; set; }

    public string? CurcyCd { get; set; }

    public string? EnterpriseFlag { get; set; }

    public string? NewLoanFlg { get; set; }

    public string? PgroupPublicFlg { get; set; }

    public string? PrRepDnrmFlg { get; set; }

    public string? PrRepManlFlg { get; set; }

    public string? PrRepSysFlg { get; set; }

    public string? SecureFlg { get; set; }

    public DateTime? ActlClsDt { get; set; }

    public decimal? AdjustedAmt { get; set; }

    public DateTime? AsgnDt { get; set; }

    public string? AsgnUsrExcldFlg { get; set; }

    public string? BdgtedFlg { get; set; }

    public decimal? BdgtAmt { get; set; }

    public DateTime? BdgtAmtDt { get; set; }

    public DateTime? BdgtAvailableDt { get; set; }

    public decimal? ConsumerOptyAmt { get; set; }

    public DateTime? DbLastUpd { get; set; }

    public decimal? EvalPeriod { get; set; }

    public DateTime? EvalStartDt { get; set; }

    public DateTime? ExchDt { get; set; }

    public DateTime? ExecPriorityTs { get; set; }

    public DateTime? ExpectClsDt { get; set; }

    public int? NumRcPeriods { get; set; }

    public int? PeakNumAttnds { get; set; }

    public int? PeakNumBrk { get; set; }

    public int? PeakNumRooms { get; set; }

    public int? Priority { get; set; }

    public string? PrivFlg { get; set; }

    public string? SortFlg { get; set; }

    public DateTime? StgStartDt { get; set; }

    public decimal? SumCostAmt { get; set; }

    public decimal? SumDownsideAmt { get; set; }

    public DateTime? SumEffectiveDt { get; set; }

    public decimal? SumMarginAmt { get; set; }

    public decimal? SumRevnAmt { get; set; }

    public decimal? SumUpsideAmt { get; set; }

    public decimal? SumWinProb { get; set; }

    public string? AliasName { get; set; }

    public string? AlternateDates { get; set; }

    public string? ApplOwnerTypeCd { get; set; }

    public string? ApprId { get; set; }

    public string? BdgtAmtCurcyCd { get; set; }

    public string? BdgtFlgUpdBy { get; set; }

    public string? BudgetConsText { get; set; }

    public string? BusinessTypeCd { get; set; }

    public string? CampConId { get; set; }

    public string? ChannelTypeCd { get; set; }

    public string? ClosureDesc { get; set; }

    public string? CmptStatusCd { get; set; }

    public string? CommId { get; set; }

    public string? CompetitionDesc { get; set; }

    public string? ConsumerOptyNum { get; set; }

    public string? CurrStgId { get; set; }

    public string? CustAccntId { get; set; }

    public string? CustNeedsText { get; set; }

    public string? CustUrgencyCd { get; set; }

    public string? DbLastUpdSrc { get; set; }

    public string? DescText { get; set; }

    public string? EvtHistoryText { get; set; }

    public string? FundStatCd { get; set; }

    public string? IntegrationId { get; set; }

    public string? IntmdAccntId { get; set; }

    public string? IntmdConId { get; set; }

    public string? InvstStgCd { get; set; }

    public string? LastActId { get; set; }

    public string? LeadQualityCd { get; set; }

    public string? OptyCd { get; set; }

    public string? OrigPrptyId { get; set; }

    public string? OuAsgnPhAc { get; set; }

    public string? OuAsgnPhCc { get; set; }

    public string? OuRoleCd { get; set; }

    public string? OuStatCd { get; set; }

    public string? OverviewText { get; set; }

    public string? ParOptyId { get; set; }

    public string? PerAddrId { get; set; }

    public string? PrefLangId { get; set; }

    public string? ProgName { get; set; }

    public string? ProjPrptyId { get; set; }

    public string? PrActId { get; set; }

    public string? PrCmptOuId { get; set; }

    public string? PrConId { get; set; }

    public string? PrCsPathId { get; set; }

    public string? PrDeptOuId { get; set; }

    public string? PrIntDeptOuId { get; set; }

    public string? PrMktSegId { get; set; }

    public string? PrOptyorgId { get; set; }

    public string? PrOptyprdId { get; set; }

    public string? PrOptyIndustId { get; set; }

    public string? PrOrggrpId { get; set; }

    public string? PrOuAddrId { get; set; }

    public string? PrOuIndustId { get; set; }

    public string? PrPerAddrId { get; set; }

    public string? PrPerId { get; set; }

    public string? PrPostnId { get; set; }

    public string? PrProdId { get; set; }

    public string? PrProjId { get; set; }

    public string? PrPrtnrId { get; set; }

    public string? PrQuoteId { get; set; }

    public string? PrRepAsgnType { get; set; }

    public string? PrSrcId { get; set; }

    public string? PrTerrId { get; set; }

    public string? RcPeriodCd { get; set; }

    public string? ReasonWonLostCd { get; set; }

    public string? RecurFreqCd { get; set; }

    public string? RevenueClass { get; set; }

    public string? SalesMethodId { get; set; }

    public string? SpecStgCd { get; set; }

    public string? SrcConId { get; set; }

    public string? SrcDesc { get; set; }

    public string? SrcEmpId { get; set; }

    public string? SrcOrgId { get; set; }

    public string? SrcTypeCd { get; set; }

    public string? StatusCd { get; set; }

    public string? StgName { get; set; }

    public string? SumClassCd { get; set; }

    public string? SumRevnItemId { get; set; }

    public string? SumTypeCd { get; set; }

    public string? TemplateName { get; set; }

    public string? WinConfidenceCd { get; set; }

    public string? OdLastUpdBy { get; set; }

    public string OndemandSyncFlg { get; set; } = null!;
}
