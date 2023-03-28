using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrAttachment
{
    public Guid Id { get; set; }

    public Guid? ResId { get; set; }

    public Guid? TenantId { get; set; }

    public long? FileSize { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? ResModel { get; set; }

    public string? ResField { get; set; }

    public string? Type { get; set; }

    public string? Url { get; set; }

    public string? AccessToken { get; set; }

    public string? StoreFname { get; set; }

    public string? Checksum { get; set; }

    public string? Mimetype { get; set; }

    public string? Description { get; set; }

    public string? IndexContent { get; set; }

    public bool? Public { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public byte[]? DbDatas { get; set; }

    public Guid? OriginalId { get; set; }

    public Guid? WebsiteId { get; set; }

    public long? ThemeTemplateId { get; set; }

    public string? Key { get; set; }

    //public virtual ICollection<AccountAccountTemplate> AccountAccountTemplates { get; } = new List<AccountAccountTemplate>();

    //public virtual ICollection<AccountAccount> AccountAccounts { get; } = new List<AccountAccount>();

    //public virtual ICollection<AccountAnalyticAccount> AccountAnalyticAccounts { get; } = new List<AccountAnalyticAccount>();

    //public virtual ICollection<AccountAssetAsset> AccountAssetAssets { get; } = new List<AccountAssetAsset>();

    //public virtual ICollection<AccountAssetCategory> AccountAssetCategories { get; } = new List<AccountAssetCategory>();

    //public virtual ICollection<AccountEdiDocument> AccountEdiDocuments { get; } = new List<AccountEdiDocument>();

    //public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();

    //public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    //public virtual ICollection<AccountPayment> AccountPayments { get; } = new List<AccountPayment>();

    //public virtual ICollection<AccountReconcileModel> AccountReconcileModels { get; } = new List<AccountReconcileModel>();

    //public virtual ICollection<CalendarEvent> CalendarEvents { get; } = new List<CalendarEvent>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();

    //public virtual ICollection<CrmTeamMember> CrmTeamMembers { get; } = new List<CrmTeamMember>();

    //public virtual ICollection<CrmTeam> CrmTeams { get; } = new List<CrmTeam>();

    //public virtual ICollection<CrossoveredBudget> CrossoveredBudgets { get; } = new List<CrossoveredBudget>();

    //public virtual ICollection<FleetVehicleLogContract> FleetVehicleLogContracts { get; } = new List<FleetVehicleLogContract>();

    //public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServices { get; } = new List<FleetVehicleLogService>();

    //public virtual ICollection<FleetVehicle> FleetVehicles { get; } = new List<FleetVehicle>();

    //public virtual ICollection<HrApplicant> HrApplicants { get; } = new List<HrApplicant>();

    //public virtual ICollection<HrContract> HrContracts { get; } = new List<HrContract>();

    //public virtual ICollection<HrDepartment> HrDepartments { get; } = new List<HrDepartment>();

    //public virtual ICollection<HrEmployee> HrEmployees { get; } = new List<HrEmployee>();

    //public virtual ICollection<HrExpenseSheet> HrExpenseSheets { get; } = new List<HrExpenseSheet>();

    //public virtual ICollection<HrExpense> HrExpenses { get; } = new List<HrExpense>();

    //public virtual ICollection<HrJob> HrJobs { get; } = new List<HrJob>();

    //public virtual ICollection<HrLeaveAllocation> HrLeaveAllocations { get; } = new List<HrLeaveAllocation>();

    //public virtual ICollection<HrLeaveType> HrLeaveTypes { get; } = new List<HrLeaveType>();

    //public virtual ICollection<HrLeave> HrLeaves { get; } = new List<HrLeave>();

    //public virtual ICollection<IrAttachment> InverseOriginal { get; } = new List<IrAttachment>();

    //public virtual ICollection<LunchSupplier> LunchSuppliers { get; } = new List<LunchSupplier>();

    //public virtual ICollection<MailBlacklist> MailBlacklists { get; } = new List<MailBlacklist>();

    //public virtual ICollection<MailChannel> MailChannels { get; } = new List<MailChannel>();

    //public virtual ICollection<MaintenanceEquipmentCategory> MaintenanceEquipmentCategories { get; } = new List<MaintenanceEquipmentCategory>();

    //public virtual ICollection<MaintenanceEquipment> MaintenanceEquipments { get; } = new List<MaintenanceEquipment>();

    //public virtual ICollection<MaintenanceRequest> MaintenanceRequests { get; } = new List<MaintenanceRequest>();

    //public virtual ICollection<MrpBom> MrpBoms { get; } = new List<MrpBom>();

    //public virtual ICollection<MrpDocument> MrpDocuments { get; } = new List<MrpDocument>();

    //public virtual ICollection<MrpProduction> MrpProductions { get; } = new List<MrpProduction>();

    //public virtual ICollection<MrpUnbuild> MrpUnbuilds { get; } = new List<MrpUnbuild>();

    //public virtual ICollection<NoteNote> NoteNotes { get; } = new List<NoteNote>();

    public virtual IrAttachment? Original { get; set; }

    //public virtual ICollection<PhoneBlacklist> PhoneBlacklists { get; } = new List<PhoneBlacklist>();

    //public virtual ICollection<PosSession> PosSessions { get; } = new List<PosSession>();

    //public virtual ICollection<ProductProduct> ProductProducts { get; } = new List<ProductProduct>();

    //public virtual ICollection<ProductTemplate> ProductTemplates { get; } = new List<ProductTemplate>();

    //public virtual ICollection<ProjectMilestone> ProjectMilestones { get; } = new List<ProjectMilestone>();

    //public virtual ICollection<ProjectProject> ProjectProjects { get; } = new List<ProjectProject>();

    //public virtual ICollection<ProjectTask> ProjectTaskDisplayedImages { get; } = new List<ProjectTask>();

    //public virtual ICollection<ProjectTask> ProjectTaskMessageMainAttachments { get; } = new List<ProjectTask>();

    //public virtual ICollection<ProjectUpdate> ProjectUpdates { get; } = new List<ProjectUpdate>();

    //public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

    //public virtual ICollection<RepairOrder> RepairOrders { get; } = new List<RepairOrder>();

    //public virtual ICollection<ResCompany> ResCompanies { get; } = new List<ResCompany>();

    //public virtual ICollection<ResPartnerBank> ResPartnerBanks { get; } = new List<ResPartnerBank>();

    //public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();

    //public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    //public virtual ICollection<SnailmailLetter> SnailmailLetters { get; } = new List<SnailmailLetter>();

    //public virtual ICollection<StockLot> StockLots { get; } = new List<StockLot>();

    //public virtual ICollection<StockPicking> StockPickings { get; } = new List<StockPicking>();

    //public virtual ICollection<StockScrap> StockScraps { get; } = new List<StockScrap>();

    public virtual ThemeIrAttachment? ThemeTemplate { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountBankStatementImport> AccountBankStatementImports { get; } = new List<AccountBankStatementImport>();

    //public virtual ICollection<AccountBankStatement> AccountBankStatements { get; } = new List<AccountBankStatement>();

    //public virtual ICollection<AccountTourUploadBill> AccountTourUploadBills { get; } = new List<AccountTourUploadBill>();

    //public virtual ICollection<MailTemplate> EmailTemplates { get; } = new List<MailTemplate>();

    //public virtual ICollection<MailMessage> Messages { get; } = new List<MailMessage>();

    //public virtual ICollection<MailComposeMessage> Wizards { get; } = new List<MailComposeMessage>();
}
