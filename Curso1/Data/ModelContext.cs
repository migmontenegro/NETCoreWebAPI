using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Curso1.Data;

public partial class ModelContext : DbContext
{
    public ModelContext()
    {
    }

    public ModelContext(DbContextOptions<ModelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CatalogoSolucione> CatalogoSoluciones { get; set; }

    public virtual DbSet<SOpty> SOpties { get; set; }

    public virtual DbSet<TbAfterSaleTrx> TbAfterSaleTrxes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseOracle("User Id=OSM_QRY;Password=osmqry2015#;Data Source=172.22.57.78:1521/CXMQA;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasDefaultSchema("OSM_QRY")
            .UseCollation("USING_NLS_COMP");

        modelBuilder.Entity<CatalogoSolucione>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CATALOGO_SOLUCIONES", "SBL_EXTERNALS");

            entity.Property(e => e.ChClassId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CH_CLASS_ID");
            entity.Property(e => e.ChClassName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CH_CLASS_NAME");
            entity.Property(e => e.ChConfgVersionId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CH_CONFG_VERSION_ID");
            entity.Property(e => e.ChFactCantFlag)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CH_FACT_CANT_FLAG");
            entity.Property(e => e.ChIdDomainRelation)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CH_ID_DOMAIN_RELATION");
            entity.Property(e => e.ChIdProductDomainRelation)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CH_ID_PRODUCT_DOMAIN_RELATION");
            entity.Property(e => e.ChNameProdDomainRelation)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CH_NAME_PROD_DOMAIN_RELATION");
            entity.Property(e => e.ChProdSysLegacyCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CH_PROD_SYS_LEGACY_CODE");
            entity.Property(e => e.ChRelId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CH_REL_ID");
            entity.Property(e => e.ChRelName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CH_REL_NAME");
            entity.Property(e => e.ChRelSequence)
                .HasColumnType("NUMBER")
                .HasColumnName("CH_REL_SEQUENCE");
            entity.Property(e => e.ChRootName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CH_ROOT_NAME");
            entity.Property(e => e.ChRootProdSysLegacyCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CH_ROOT_PROD_SYS_LEGACY_CODE");
            entity.Property(e => e.ChRootProductId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CH_ROOT_PRODUCT_ID");
            entity.Property(e => e.ChSeqDomainRelation)
                .HasColumnType("NUMBER")
                .HasColumnName("CH_SEQ_DOMAIN_RELATION");
            entity.Property(e => e.ChStartDate)
                .HasColumnType("DATE")
                .HasColumnName("CH_START_DATE");
            entity.Property(e => e.ChVerNum)
                .HasColumnType("NUMBER")
                .HasColumnName("CH_VER_NUM");
            entity.Property(e => e.ClassId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CLASS_ID");
            entity.Property(e => e.ClassName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CLASS_NAME");
            entity.Property(e => e.ConfgVersionId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CONFG_VERSION_ID");
            entity.Property(e => e.FstRootFactCantFlag)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("FST_ROOT_FACT_CANT_FLAG");
            entity.Property(e => e.IdDomainRelation)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ID_DOMAIN_RELATION");
            entity.Property(e => e.IdProductDomainRelation)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ID_PRODUCT_DOMAIN_RELATION");
            entity.Property(e => e.NameProdDomainRelation)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME_PROD_DOMAIN_RELATION");
            entity.Property(e => e.ProdSysLegacyCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PROD_SYS_LEGACY_CODE");
            entity.Property(e => e.RelId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("REL_ID");
            entity.Property(e => e.RelName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("REL_NAME");
            entity.Property(e => e.RelSequence)
                .HasColumnType("NUMBER")
                .HasColumnName("REL_SEQUENCE");
            entity.Property(e => e.RootName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ROOT_NAME");
            entity.Property(e => e.RootProdSysLegacyCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ROOT_PROD_SYS_LEGACY_CODE");
            entity.Property(e => e.RootProductId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ROOT_PRODUCT_ID");
            entity.Property(e => e.ScndFactCantFlag)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SCND_FACT_CANT_FLAG");
            entity.Property(e => e.SeqDomainRelation)
                .HasColumnType("NUMBER")
                .HasColumnName("SEQ_DOMAIN_RELATION");
            entity.Property(e => e.StartDate)
                .HasColumnType("DATE")
                .HasColumnName("START_DATE");
            entity.Property(e => e.VerNum)
                .HasColumnType("NUMBER")
                .HasColumnName("VER_NUM");
        });

        modelBuilder.Entity<SOpty>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("S_OPTY", "SIEBEL");

            entity.HasIndex(e => e.ParOptyId, "S_OPTY_F1");

            entity.HasIndex(e => e.CampConId, "S_OPTY_F10");

            entity.HasIndex(e => e.PrCmptOuId, "S_OPTY_F3");

            entity.HasIndex(e => e.SalesMethodId, "S_OPTY_F4");

            entity.HasIndex(e => e.CurrStgId, "S_OPTY_F5");

            entity.HasIndex(e => e.SrcConId, "S_OPTY_F50");

            entity.HasIndex(e => e.CustAccntId, "S_OPTY_F51");

            entity.HasIndex(e => e.SrcOrgId, "S_OPTY_F52");

            entity.HasIndex(e => e.CommId, "S_OPTY_F53");

            entity.HasIndex(e => e.PerAddrId, "S_OPTY_F54");

            entity.HasIndex(e => e.ApprId, "S_OPTY_F57");

            entity.HasIndex(e => e.PrActId, "S_OPTY_F58");

            entity.HasIndex(e => e.SrcEmpId, "S_OPTY_F59");

            entity.HasIndex(e => e.PrCsPathId, "S_OPTY_F6");

            entity.HasIndex(e => e.LastActId, "S_OPTY_F60");

            entity.HasIndex(e => e.IntmdAccntId, "S_OPTY_F61");

            entity.HasIndex(e => e.IntmdConId, "S_OPTY_F62");

            entity.HasIndex(e => e.ProjPrptyId, "S_OPTY_F63");

            entity.HasIndex(e => e.OrigPrptyId, "S_OPTY_F64");

            entity.HasIndex(e => e.SumRevnItemId, "S_OPTY_F7");

            entity.HasIndex(e => e.PrOptyIndustId, "S_OPTY_F8");

            entity.HasIndex(e => e.PrPrtnrId, "S_OPTY_F9");

            entity.HasIndex(e => e.IntegrationId, "S_OPTY_II");

            entity.HasIndex(e => e.SumEffectiveDt, "S_OPTY_M1");

            entity.HasIndex(e => new { e.DbLastUpd, e.RowId }, "S_OPTY_M10");

            entity.HasIndex(e => e.PrOuAddrId, "S_OPTY_M2");

            entity.HasIndex(e => e.PrPerId, "S_OPTY_M3");

            entity.HasIndex(e => e.AliasName, "S_OPTY_M4");

            entity.HasIndex(e => new { e.SecureFlg, e.Name }, "S_OPTY_M50");

            entity.HasIndex(e => new { e.ConsumerOptyFlg, e.Name }, "S_OPTY_M51");

            entity.HasIndex(e => new { e.RowId, e.PrPostnId, e.SecureFlg, e.ConsumerOptyFlg, e.Name }, "S_OPTY_M52");

            entity.HasIndex(e => new { e.PrDeptOuId, e.Name, e.RowId }, "S_OPTY_M53");

            entity.HasIndex(e => new { e.NewLoanFlg, e.Name }, "S_OPTY_M54");

            entity.HasIndex(e => new { e.SecureFlg, e.ConsumerOptyFlg, e.SumEffectiveDt }, "S_OPTY_M55");

            entity.HasIndex(e => new { e.SumWinProb, e.SecureFlg }, "S_OPTY_M56");

            entity.HasIndex(e => new { e.SumRevnAmt, e.SecureFlg }, "S_OPTY_M57");

            entity.HasIndex(e => new { e.RowId, e.BusinessTypeCd }, "S_OPTY_M58");

            entity.HasIndex(e => new { e.TemplateFlg, e.RowId, e.PrPostnId }, "S_OPTY_M59");

            entity.HasIndex(e => e.AsgnUsrExcldFlg, "S_OPTY_M6");

            entity.HasIndex(e => e.PgroupPublicFlg, "S_OPTY_M60");

            entity.HasIndex(e => new { e.PrDeptOuId, e.ConflictId }, "S_OPTY_M8");

            entity.HasIndex(e => e.PrConId, "S_OPTY_M9");

            entity.HasIndex(e => e.RowId, "S_OPTY_P1").IsUnique();

            entity.HasIndex(e => new { e.Name, e.PrDeptOuId, e.BuId, e.ConflictId }, "S_OPTY_U1").IsUnique();

            entity.HasIndex(e => new { e.BuId, e.Name, e.PrDeptOuId, e.ConflictId }, "S_OPTY_U2").IsUnique();

            entity.HasIndex(e => e.PrOuIndustId, "S_OPTY_V1");

            entity.HasIndex(e => new { e.PrPostnId, e.RowId }, "S_OPTY_V2").IsUnique();

            entity.HasIndex(e => e.PrProdId, "S_OPTY_V3");

            entity.HasIndex(e => e.PrQuoteId, "S_OPTY_V4");

            entity.HasIndex(e => e.PrTerrId, "S_OPTY_V5");

            entity.HasIndex(e => e.PrIntDeptOuId, "S_OPTY_V51");

            entity.HasIndex(e => e.PrPostnId, "S_OPTY_V52");

            entity.HasIndex(e => e.PrMktSegId, "S_OPTY_V53");

            entity.Property(e => e.ActlClsDt)
                .HasColumnType("DATE")
                .HasColumnName("ACTL_CLS_DT");
            entity.Property(e => e.AdjustedAmt)
                .HasColumnType("NUMBER(22,7)")
                .HasColumnName("ADJUSTED_AMT");
            entity.Property(e => e.AliasName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ALIAS_NAME");
            entity.Property(e => e.AlternateDates)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ALTERNATE_DATES");
            entity.Property(e => e.ApplOwnerTypeCd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("APPL_OWNER_TYPE_CD");
            entity.Property(e => e.ApprId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("APPR_ID");
            entity.Property(e => e.AsgnDt)
                .HasColumnType("DATE")
                .HasColumnName("ASGN_DT");
            entity.Property(e => e.AsgnUsrExcldFlg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ASGN_USR_EXCLD_FLG");
            entity.Property(e => e.BdgtAmt)
                .HasColumnType("NUMBER(22,7)")
                .HasColumnName("BDGT_AMT");
            entity.Property(e => e.BdgtAmtCurcyCd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BDGT_AMT_CURCY_CD");
            entity.Property(e => e.BdgtAmtDt)
                .HasColumnType("DATE")
                .HasColumnName("BDGT_AMT_DT");
            entity.Property(e => e.BdgtAvailableDt)
                .HasColumnType("DATE")
                .HasColumnName("BDGT_AVAILABLE_DT");
            entity.Property(e => e.BdgtFlgUpdBy)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("BDGT_FLG_UPD_BY");
            entity.Property(e => e.BdgtedFlg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BDGTED_FLG");
            entity.Property(e => e.BuId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("'0-R9NH' ")
                .HasColumnName("BU_ID");
            entity.Property(e => e.BudgetConsText)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("BUDGET_CONS_TEXT");
            entity.Property(e => e.BusinessTypeCd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BUSINESS_TYPE_CD");
            entity.Property(e => e.CampConId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CAMP_CON_ID");
            entity.Property(e => e.ChannelTypeCd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CHANNEL_TYPE_CD");
            entity.Property(e => e.ClosedFlg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N' ")
                .IsFixedLength()
                .HasColumnName("CLOSED_FLG");
            entity.Property(e => e.ClosureDesc)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CLOSURE_DESC");
            entity.Property(e => e.CmptStatusCd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CMPT_STATUS_CD");
            entity.Property(e => e.CommId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COMM_ID");
            entity.Property(e => e.CompetitionDesc)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("COMPETITION_DESC");
            entity.Property(e => e.ConflictId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("'0' ")
                .HasColumnName("CONFLICT_ID");
            entity.Property(e => e.ConsumerOptyAmt)
                .HasColumnType("NUMBER(22,7)")
                .HasColumnName("CONSUMER_OPTY_AMT");
            entity.Property(e => e.ConsumerOptyFlg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'")
                .IsFixedLength()
                .HasColumnName("CONSUMER_OPTY_FLG");
            entity.Property(e => e.ConsumerOptyNum)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CONSUMER_OPTY_NUM");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("sysdate ")
                .HasColumnType("DATE")
                .HasColumnName("CREATED");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CurcyCd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'USD'")
                .HasColumnName("CURCY_CD");
            entity.Property(e => e.CurrStgId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CURR_STG_ID");
            entity.Property(e => e.CustAccntId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CUST_ACCNT_ID");
            entity.Property(e => e.CustNeedsText)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CUST_NEEDS_TEXT");
            entity.Property(e => e.CustUrgencyCd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CUST_URGENCY_CD");
            entity.Property(e => e.DbLastUpd)
                .HasColumnType("DATE")
                .HasColumnName("DB_LAST_UPD");
            entity.Property(e => e.DbLastUpdSrc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DB_LAST_UPD_SRC");
            entity.Property(e => e.DckingNum)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(22,7)")
                .HasColumnName("DCKING_NUM");
            entity.Property(e => e.DescText)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DESC_TEXT");
            entity.Property(e => e.EnterpriseFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'")
                .IsFixedLength()
                .HasColumnName("ENTERPRISE_FLAG");
            entity.Property(e => e.EvalPeriod)
                .HasColumnType("NUMBER(22,7)")
                .HasColumnName("EVAL_PERIOD");
            entity.Property(e => e.EvalStartDt)
                .HasColumnType("DATE")
                .HasColumnName("EVAL_START_DT");
            entity.Property(e => e.EvtHistoryText)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("EVT_HISTORY_TEXT");
            entity.Property(e => e.ExchDt)
                .HasColumnType("DATE")
                .HasColumnName("EXCH_DT");
            entity.Property(e => e.ExecPriorityFlg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N' ")
                .IsFixedLength()
                .HasColumnName("EXEC_PRIORITY_FLG");
            entity.Property(e => e.ExecPriorityTs)
                .HasColumnType("DATE")
                .HasColumnName("EXEC_PRIORITY_TS");
            entity.Property(e => e.ExpectClsDt)
                .HasColumnType("DATE")
                .HasColumnName("EXPECT_CLS_DT");
            entity.Property(e => e.FundStatCd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("FUND_STAT_CD");
            entity.Property(e => e.HstAfflFlg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N' ")
                .IsFixedLength()
                .HasColumnName("HST_AFFL_FLG");
            entity.Property(e => e.InactiveFlg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N' ")
                .IsFixedLength()
                .HasColumnName("INACTIVE_FLG");
            entity.Property(e => e.IntegrationId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("INTEGRATION_ID");
            entity.Property(e => e.IntmdAccntId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("INTMD_ACCNT_ID");
            entity.Property(e => e.IntmdConId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("INTMD_CON_ID");
            entity.Property(e => e.InvstStgCd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("INVST_STG_CD");
            entity.Property(e => e.LastActId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("LAST_ACT_ID");
            entity.Property(e => e.LastUpd)
                .HasDefaultValueSql("sysdate ")
                .HasColumnType("DATE")
                .HasColumnName("LAST_UPD");
            entity.Property(e => e.LastUpdBy)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("LAST_UPD_BY");
            entity.Property(e => e.LeadQualityCd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LEAD_QUALITY_CD");
            entity.Property(e => e.ModificationNum)
                .HasPrecision(10)
                .HasDefaultValueSql("0 ")
                .HasColumnName("MODIFICATION_NUM");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NewLoanFlg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'")
                .IsFixedLength()
                .HasColumnName("NEW_LOAN_FLG");
            entity.Property(e => e.NumRcPeriods)
                .HasPrecision(10)
                .HasColumnName("NUM_RC_PERIODS");
            entity.Property(e => e.OdLastUpdBy)
                .HasMaxLength(125)
                .IsUnicode(false)
                .HasColumnName("OD_LAST_UPD_BY");
            entity.Property(e => e.OndemandSyncFlg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N' ")
                .IsFixedLength()
                .HasColumnName("ONDEMAND_SYNC_FLG");
            entity.Property(e => e.OptyCd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OPTY_CD");
            entity.Property(e => e.OrigPrptyId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ORIG_PRPTY_ID");
            entity.Property(e => e.OuAsgnPhAc)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("OU_ASGN_PH_AC");
            entity.Property(e => e.OuAsgnPhCc)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("OU_ASGN_PH_CC");
            entity.Property(e => e.OuRoleCd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OU_ROLE_CD");
            entity.Property(e => e.OuStatCd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OU_STAT_CD");
            entity.Property(e => e.OverviewText)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("OVERVIEW_TEXT");
            entity.Property(e => e.ParOptyId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PAR_OPTY_ID");
            entity.Property(e => e.PeakNumAttnds)
                .HasPrecision(10)
                .HasColumnName("PEAK_NUM_ATTNDS");
            entity.Property(e => e.PeakNumBrk)
                .HasPrecision(10)
                .HasColumnName("PEAK_NUM_BRK");
            entity.Property(e => e.PeakNumRooms)
                .HasPrecision(10)
                .HasColumnName("PEAK_NUM_ROOMS");
            entity.Property(e => e.PerAddrId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PER_ADDR_ID");
            entity.Property(e => e.PgroupPublicFlg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'")
                .IsFixedLength()
                .HasColumnName("PGROUP_PUBLIC_FLG");
            entity.Property(e => e.PrActId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_ACT_ID");
            entity.Property(e => e.PrBuDnrmFlg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N' ")
                .IsFixedLength()
                .HasColumnName("PR_BU_DNRM_FLG");
            entity.Property(e => e.PrBuManlFlg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N' ")
                .IsFixedLength()
                .HasColumnName("PR_BU_MANL_FLG");
            entity.Property(e => e.PrBuSysFlg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N' ")
                .IsFixedLength()
                .HasColumnName("PR_BU_SYS_FLG");
            entity.Property(e => e.PrCmptOuId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_CMPT_OU_ID");
            entity.Property(e => e.PrConId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_CON_ID");
            entity.Property(e => e.PrCsPathId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_CS_PATH_ID");
            entity.Property(e => e.PrDeptOuId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_DEPT_OU_ID");
            entity.Property(e => e.PrIntDeptOuId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_INT_DEPT_OU_ID");
            entity.Property(e => e.PrMktSegId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_MKT_SEG_ID");
            entity.Property(e => e.PrOptyIndustId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_OPTY_INDUST_ID");
            entity.Property(e => e.PrOptyorgId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_OPTYORG_ID");
            entity.Property(e => e.PrOptyprdId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_OPTYPRD_ID");
            entity.Property(e => e.PrOrggrpId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_ORGGRP_ID");
            entity.Property(e => e.PrOuAddrId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_OU_ADDR_ID");
            entity.Property(e => e.PrOuIndustId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_OU_INDUST_ID");
            entity.Property(e => e.PrPerAddrId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_PER_ADDR_ID");
            entity.Property(e => e.PrPerId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_PER_ID");
            entity.Property(e => e.PrPostnId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_POSTN_ID");
            entity.Property(e => e.PrProdId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_PROD_ID");
            entity.Property(e => e.PrProjId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_PROJ_ID");
            entity.Property(e => e.PrPrtnrId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_PRTNR_ID");
            entity.Property(e => e.PrQuoteId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_QUOTE_ID");
            entity.Property(e => e.PrRepAsgnType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PR_REP_ASGN_TYPE");
            entity.Property(e => e.PrRepDnrmFlg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'")
                .IsFixedLength()
                .HasColumnName("PR_REP_DNRM_FLG");
            entity.Property(e => e.PrRepManlFlg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'")
                .IsFixedLength()
                .HasColumnName("PR_REP_MANL_FLG");
            entity.Property(e => e.PrRepSysFlg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'")
                .IsFixedLength()
                .HasColumnName("PR_REP_SYS_FLG");
            entity.Property(e => e.PrSrcId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_SRC_ID");
            entity.Property(e => e.PrTerrId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_TERR_ID");
            entity.Property(e => e.PrefLangId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PREF_LANG_ID");
            entity.Property(e => e.Priority)
                .HasPrecision(10)
                .HasColumnName("PRIORITY");
            entity.Property(e => e.PrivFlg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PRIV_FLG");
            entity.Property(e => e.ProgName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PROG_NAME");
            entity.Property(e => e.ProjPrptyId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PROJ_PRPTY_ID");
            entity.Property(e => e.RcPeriodCd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RC_PERIOD_CD");
            entity.Property(e => e.ReasonWonLostCd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REASON_WON_LOST_CD");
            entity.Property(e => e.RecurFreqCd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RECUR_FREQ_CD");
            entity.Property(e => e.RevenueClass)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REVENUE_CLASS");
            entity.Property(e => e.RevnSplitFlg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N' ")
                .IsFixedLength()
                .HasColumnName("REVN_SPLIT_FLG");
            entity.Property(e => e.RowId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ROW_ID");
            entity.Property(e => e.SalesMethodId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SALES_METHOD_ID");
            entity.Property(e => e.SecureFlg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'")
                .IsFixedLength()
                .HasColumnName("SECURE_FLG");
            entity.Property(e => e.SortFlg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SORT_FLG");
            entity.Property(e => e.SpecStgCd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SPEC_STG_CD");
            entity.Property(e => e.SrcConId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SRC_CON_ID");
            entity.Property(e => e.SrcDesc)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SRC_DESC");
            entity.Property(e => e.SrcEmpId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SRC_EMP_ID");
            entity.Property(e => e.SrcOrgId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SRC_ORG_ID");
            entity.Property(e => e.SrcTypeCd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SRC_TYPE_CD");
            entity.Property(e => e.StatusCd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("STATUS_CD");
            entity.Property(e => e.StgName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("STG_NAME");
            entity.Property(e => e.StgStartDt)
                .HasColumnType("DATE")
                .HasColumnName("STG_START_DT");
            entity.Property(e => e.SumClassCd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SUM_CLASS_CD");
            entity.Property(e => e.SumCommitFlg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N' ")
                .IsFixedLength()
                .HasColumnName("SUM_COMMIT_FLG");
            entity.Property(e => e.SumCostAmt)
                .HasColumnType("NUMBER(22,7)")
                .HasColumnName("SUM_COST_AMT");
            entity.Property(e => e.SumDownsideAmt)
                .HasColumnType("NUMBER(22,7)")
                .HasColumnName("SUM_DOWNSIDE_AMT");
            entity.Property(e => e.SumEffectiveDt)
                .HasColumnType("DATE")
                .HasColumnName("SUM_EFFECTIVE_DT");
            entity.Property(e => e.SumMarginAmt)
                .HasColumnType("NUMBER(22,7)")
                .HasColumnName("SUM_MARGIN_AMT");
            entity.Property(e => e.SumRevnAmt)
                .HasColumnType("NUMBER(22,7)")
                .HasColumnName("SUM_REVN_AMT");
            entity.Property(e => e.SumRevnItemId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SUM_REVN_ITEM_ID");
            entity.Property(e => e.SumTypeCd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SUM_TYPE_CD");
            entity.Property(e => e.SumUpsideAmt)
                .HasColumnType("NUMBER(22,7)")
                .HasColumnName("SUM_UPSIDE_AMT");
            entity.Property(e => e.SumWinProb)
                .HasColumnType("NUMBER(22,7)")
                .HasColumnName("SUM_WIN_PROB");
            entity.Property(e => e.TemplateFlg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N' ")
                .IsFixedLength()
                .HasColumnName("TEMPLATE_FLG");
            entity.Property(e => e.TemplateName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TEMPLATE_NAME");
            entity.Property(e => e.WinConfidenceCd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("WIN_CONFIDENCE_CD");
        });

        modelBuilder.Entity<TbAfterSaleTrx>(entity =>
        {
            entity.HasKey(e => new { e.RefOfferId, e.LineNumber }).HasName("TB_AFTER_SALE_TRX_PK");

            entity.ToTable("TB_AFTER_SALE_TRX", "SBL_EXTERNALS");

            entity.Property(e => e.RefOfferId)
                .HasColumnType("NUMBER")
                .HasColumnName("REF_OFFER_ID");
            entity.Property(e => e.LineNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LINE_NUMBER");
            entity.Property(e => e.ActiveProduct)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ACTIVE_PRODUCT");
            entity.Property(e => e.ApprovedPrice)
                .HasColumnType("NUMBER(18,6)")
                .HasColumnName("APPROVED_PRICE");
            entity.Property(e => e.AsSolutionId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("AS_SOLUTION_ID");
            entity.Property(e => e.AssetId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ASSET_ID");
            entity.Property(e => e.AssetIntegrationId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ASSET_INTEGRATION_ID");
            entity.Property(e => e.BasePrice)
                .HasColumnType("NUMBER(18,6)")
                .HasColumnName("BASE_PRICE");
            entity.Property(e => e.Billable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("BILLABLE");
            entity.Property(e => e.BillingAccountId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("BILLING_ACCOUNT_ID");
            entity.Property(e => e.BillingProfileId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("BILLING_PROFILE_ID");
            entity.Property(e => e.BillingStartDate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BILLING_START_DATE");
            entity.Property(e => e.ContractPrice)
                .HasColumnType("NUMBER(18,6)")
                .HasColumnName("CONTRACT_PRICE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("DATE")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.DueDate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DUE_DATE");
            entity.Property(e => e.FinalAddressId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("FINAL_ADDRESS_ID");
            entity.Property(e => e.InitialAddressId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("INITIAL_ADDRESS_ID");
            entity.Property(e => e.IvaPrice)
                .HasColumnType("NUMBER(18,6)")
                .HasColumnName("IVA_PRICE");
            entity.Property(e => e.LastTransaction)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LAST_TRANSACTION");
            entity.Property(e => e.LineItem)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("LINE_ITEM");
            entity.Property(e => e.LinkNumber)
                .HasPrecision(9)
                .HasColumnName("LINK_NUMBER");
            entity.Property(e => e.ManualPrice)
                .HasColumnType("NUMBER(18,6)")
                .HasColumnName("MANUAL_PRICE");
            entity.Property(e => e.NafTransaction)
                .HasPrecision(9)
                .HasColumnName("NAF_TRANSACTION");
            entity.Property(e => e.NetPrice)
                .HasColumnType("NUMBER(18,6)")
                .HasColumnName("NET_PRICE");
            entity.Property(e => e.NewBasePrice)
                .HasColumnType("NUMBER(18,6)")
                .HasColumnName("NEW_BASE_PRICE");
            entity.Property(e => e.NewContractPrice)
                .HasColumnType("NUMBER(18,6)")
                .HasColumnName("NEW_CONTRACT_PRICE");
            entity.Property(e => e.NewCurrency)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("NEW_CURRENCY");
            entity.Property(e => e.NewFinalAddressId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("NEW_FINAL_ADDRESS_ID");
            entity.Property(e => e.NewInitialAddressId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("NEW_INITIAL_ADDRESS_ID");
            entity.Property(e => e.NewLineNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NEW_LINE_NUMBER");
            entity.Property(e => e.NewManualPrice)
                .HasColumnType("NUMBER(18,6)")
                .HasColumnName("NEW_MANUAL_PRICE");
            entity.Property(e => e.NewNafTransaction)
                .HasPrecision(9)
                .HasColumnName("NEW_NAF_TRANSACTION");
            entity.Property(e => e.NewNetPrice)
                .HasColumnType("NUMBER(18,6)")
                .HasColumnName("NEW_NET_PRICE");
            entity.Property(e => e.NewOtc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("NEW_OTC");
            entity.Property(e => e.NewOtcBlocked)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("NEW_OTC_BLOCKED");
            entity.Property(e => e.NewProductId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("NEW_PRODUCT_ID");
            entity.Property(e => e.NewQuantity)
                .HasPrecision(9)
                .HasColumnName("NEW_QUANTITY");
            entity.Property(e => e.NewUnitPrice)
                .HasColumnType("NUMBER(18,6)")
                .HasColumnName("NEW_UNIT_PRICE");
            entity.Property(e => e.OfferId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("OFFER_ID");
            entity.Property(e => e.OfferNumber)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("OFFER_NUMBER");
            entity.Property(e => e.OrderId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ORDER_NUMBER");
            entity.Property(e => e.Otc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OTC");
            entity.Property(e => e.OtcBlocked)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OTC_BLOCKED");
            entity.Property(e => e.PrevLineNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PREV_LINE_NUMBER");
            entity.Property(e => e.PrevLineNumberDisplay)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PREV_LINE_NUMBER_DISPLAY");
            entity.Property(e => e.PrevRefOfferId)
                .HasColumnType("NUMBER")
                .HasColumnName("PREV_REF_OFFER_ID");
            entity.Property(e => e.ProductId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_ID");
            entity.Property(e => e.ProductType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_TYPE");
            entity.Property(e => e.Quantity)
                .HasPrecision(9)
                .HasColumnName("QUANTITY");
            entity.Property(e => e.Recalculate)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("RECALCULATE");
            entity.Property(e => e.RemainingMonths)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("REMAINING_MONTHS");
            entity.Property(e => e.RequestedPrice)
                .HasColumnType("NUMBER(18,6)")
                .HasColumnName("REQUESTED_PRICE");
            entity.Property(e => e.RequiresQuantity)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("REQUIRES_QUANTITY");
            entity.Property(e => e.ServiceAccountId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SERVICE_ACCOUNT_ID");
            entity.Property(e => e.SolutionId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SOLUTION_ID");
            entity.Property(e => e.SrFactId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SR_FACT_ID");
            entity.Property(e => e.SrFactNumber)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SR_FACT_NUMBER");
            entity.Property(e => e.SrInstallId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SR_INSTALL_ID");
            entity.Property(e => e.SrInstallNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SR_INSTALL_NUMBER");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.TrackingNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TRACKING_NUMBER");
            entity.Property(e => e.TransactionName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TRANSACTION_NAME");
            entity.Property(e => e.TreeLevel)
                .HasPrecision(5)
                .HasColumnName("TREE_LEVEL");
            entity.Property(e => e.UnitPrice)
                .HasColumnType("NUMBER(18,6)")
                .HasColumnName("UNIT_PRICE");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("DATE")
                .HasColumnName("UPDATED_DATE");
        });
        modelBuilder.HasSequence("BPM_BITACORA_ID_SEQ", "SBL_EXTERNALS");
        modelBuilder.HasSequence("BPM_SEQ_DIRECCION", "SBL_EXTERNALS");
        modelBuilder.HasSequence("BPM_SEQ_REFERENCIA", "SBL_EXTERNALS");
        modelBuilder.HasSequence("BPM_SEQ_REPRESENTANTE_L", "SBL_EXTERNALS");
        modelBuilder.HasSequence("BPM_TIPO_ID_SEQ", "SBL_EXTERNALS");
        modelBuilder.HasSequence("DOCUMENTID_SEQ", "SBL_EXTERNALS");
        modelBuilder.HasSequence("INFO_NODOS_HOME_DETALLE_SEQ", "SBL_EXTERNALS");
        modelBuilder.HasSequence("INTERACTION_ADM_SEQ", "SBL_EXTERNALS");
        modelBuilder.HasSequence("LINKS_USER_SEQUENCE", "SBL_EXTERNALS");
        modelBuilder.HasSequence("LOG_DATOSCAMBIOSIMCARD_SEQ", "SBL_EXTERNALS");
        modelBuilder.HasSequence("NCO_SEQ", "SBL_EXTERNALS");
        modelBuilder.HasSequence("OFERTAID_SEQ", "SBL_EXTERNALS");
        modelBuilder.HasSequence("REVISION_ACTIVACIONESID_SEQ", "SBL_EXTERNALS");
        modelBuilder.HasSequence("REVISION_FRAUDEID_SEQ", "SBL_EXTERNALS");
        modelBuilder.HasSequence("SEGUIMIENTO_ACTIVACIONID_SEQ", "SBL_EXTERNALS");
        modelBuilder.HasSequence("SOLICITUD_OFERTAID_SEQ", "SBL_EXTERNALS");
        modelBuilder.HasSequence("SOLICITUDID_SEQ", "SBL_EXTERNALS");
        modelBuilder.HasSequence("SQ_TB_FIBERTEC_ALTA", "SBL_EXTERNALS");
        modelBuilder.HasSequence("SQ_TB_FIBERTEC_CTA_CTE", "SBL_EXTERNALS");
        modelBuilder.HasSequence("SQ_TB_FIBERTEC_CTA_FAC", "SBL_EXTERNALS");
        modelBuilder.HasSequence("SQ_TB_FIBERTEC_CTA_SRV", "SBL_EXTERNALS");
        modelBuilder.HasSequence("SQ_TB_FIBERTEC_INSTALACION", "SBL_EXTERNALS");
        modelBuilder.HasSequence("SQ_TB_FIBERTEC_TRANSACCION", "SBL_EXTERNALS");
        modelBuilder.HasSequence("SQ_TB_HISTORY", "SBL_EXTERNALS");
        modelBuilder.HasSequence("SQ_TB_SOLUTIONS", "SBL_EXTERNALS");
        modelBuilder.HasSequence("SQ_TB_TRX", "SBL_EXTERNALS");
        modelBuilder.HasSequence("SQSOLUCION", "SBL_EXTERNALS");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
