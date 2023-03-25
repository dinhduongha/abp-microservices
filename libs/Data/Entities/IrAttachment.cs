using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("ir_attachment")]
[Index("Checksum", Name = "ir_attachment_checksum_index")]
[Index("ResModel", "ResId", Name = "ir_attachment_res_idx")]
[Index("StoreFname", Name = "ir_attachment_store_fname_index")]
public partial class IrAttachment: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("res_id")]
    public Guid? ResId { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("file_size")]
    public long? FileSize { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("res_model")]
    public string? ResModel { get; set; }

    [Column("res_field")]
    public string? ResField { get; set; }

    [Column("type")]
    public string? Type { get; set; }

    [Column("url")]
    public string? Url { get; set; }

    [Column("access_token")]
    public string? AccessToken { get; set; }

    [Column("store_fname")]
    public string? StoreFname { get; set; }

    [Column("checksum")]
    public string? Checksum { get; set; }

    [Column("mimetype")]
    public string? Mimetype { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("index_content")]
    public string? IndexContent { get; set; }

    [Column("public")]
    public bool? Public { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("db_datas")]
    public byte[]? DbDatas { get; set; }

    [Column("original_id")]
    public Guid? OriginalId { get; set; }

    [Column("website_id")]
    public Guid? WebsiteId { get; set; }

    [Column("theme_template_id")]
    public long? ThemeTemplateId { get; set; }

    [Column("key")]
    public string? Key { get; set; }

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<AccountAccountTemplate> AccountAccountTemplates { get; } = new List<AccountAccountTemplate>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<AccountAccount> AccountAccounts { get; } = new List<AccountAccount>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<AccountAnalyticAccount> AccountAnalyticAccounts { get; } = new List<AccountAnalyticAccount>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<AccountAssetAsset> AccountAssetAssets { get; } = new List<AccountAssetAsset>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<AccountAssetCategory> AccountAssetCategories { get; } = new List<AccountAssetCategory>();

    [InverseProperty("Attachment")]
    public virtual ICollection<AccountEdiDocument> AccountEdiDocuments { get; } = new List<AccountEdiDocument>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<AccountPayment> AccountPayments { get; } = new List<AccountPayment>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<AccountReconcileModel> AccountReconcileModels { get; } = new List<AccountReconcileModel>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<CalendarEvent> CalendarEvents { get; } = new List<CalendarEvent>();

    [ForeignKey("TenantId")]
    [InverseProperty("IrAttachments")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("IrAttachmentCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<CrmTeamMember> CrmTeamMembers { get; } = new List<CrmTeamMember>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<CrmTeam> CrmTeams { get; } = new List<CrmTeam>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<CrossoveredBudget> CrossoveredBudgets { get; } = new List<CrossoveredBudget>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<FleetVehicleLogContract> FleetVehicleLogContracts { get; } = new List<FleetVehicleLogContract>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServices { get; } = new List<FleetVehicleLogService>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<FleetVehicle> FleetVehicles { get; } = new List<FleetVehicle>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<HrApplicant> HrApplicants { get; } = new List<HrApplicant>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<HrContract> HrContracts { get; } = new List<HrContract>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<HrDepartment> HrDepartments { get; } = new List<HrDepartment>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<HrEmployee> HrEmployees { get; } = new List<HrEmployee>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<HrExpenseSheet> HrExpenseSheets { get; } = new List<HrExpenseSheet>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<HrExpense> HrExpenses { get; } = new List<HrExpense>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<HrJob> HrJobs { get; } = new List<HrJob>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocations { get; } = new List<HrLeaveAllocation>();

    [InverseProperty("Icon")]
    public virtual ICollection<HrLeaveType> HrLeaveTypes { get; } = new List<HrLeaveType>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<HrLeave> HrLeaves { get; } = new List<HrLeave>();

    [InverseProperty("Original")]
    public virtual ICollection<IrAttachment> InverseOriginal { get; } = new List<IrAttachment>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<LunchSupplier> LunchSuppliers { get; } = new List<LunchSupplier>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<MailBlacklist> MailBlacklists { get; } = new List<MailBlacklist>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<MailChannel> MailChannels { get; } = new List<MailChannel>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<MaintenanceEquipmentCategory> MaintenanceEquipmentCategories { get; } = new List<MaintenanceEquipmentCategory>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<MaintenanceEquipment> MaintenanceEquipments { get; } = new List<MaintenanceEquipment>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<MaintenanceRequest> MaintenanceRequests { get; } = new List<MaintenanceRequest>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<MrpBom> MrpBoms { get; } = new List<MrpBom>();

    [InverseProperty("IrAttachment")]
    public virtual ICollection<MrpDocument> MrpDocuments { get; } = new List<MrpDocument>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<MrpProduction> MrpProductions { get; } = new List<MrpProduction>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<MrpUnbuild> MrpUnbuilds { get; } = new List<MrpUnbuild>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<NoteNote> NoteNotes { get; } = new List<NoteNote>();

    [ForeignKey("OriginalId")]
    [InverseProperty("InverseOriginal")]
    public virtual IrAttachment? Original { get; set; }

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<PhoneBlacklist> PhoneBlacklists { get; } = new List<PhoneBlacklist>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<PosSession> PosSessions { get; } = new List<PosSession>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<ProductProduct> ProductProducts { get; } = new List<ProductProduct>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<ProductTemplate> ProductTemplates { get; } = new List<ProductTemplate>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<ProjectMilestone> ProjectMilestones { get; } = new List<ProjectMilestone>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<ProjectProject> ProjectProjects { get; } = new List<ProjectProject>();

    [InverseProperty("DisplayedImage")]
    public virtual ICollection<ProjectTask> ProjectTaskDisplayedImages { get; } = new List<ProjectTask>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<ProjectTask> ProjectTaskMessageMainAttachments { get; } = new List<ProjectTask>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<ProjectUpdate> ProjectUpdates { get; } = new List<ProjectUpdate>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<RepairOrder> RepairOrders { get; } = new List<RepairOrder>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<ResCompany> ResCompanies { get; } = new List<ResCompany>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<ResPartnerBank> ResPartnerBanks { get; } = new List<ResPartnerBank>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    [InverseProperty("Attachment")]
    public virtual ICollection<SnailmailLetter> SnailmailLetters { get; } = new List<SnailmailLetter>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<StockLot> StockLots { get; } = new List<StockLot>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<StockPicking> StockPickings { get; } = new List<StockPicking>();

    [InverseProperty("MessageMainAttachment")]
    public virtual ICollection<StockScrap> StockScraps { get; } = new List<StockScrap>();

    [ForeignKey("ThemeTemplateId")]
    [InverseProperty("IrAttachments")]
    public virtual ThemeIrAttachment? ThemeTemplate { get; set; }

    [ForeignKey("WebsiteId")]
    [InverseProperty("IrAttachments")]
    public virtual Website? Website { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("IrAttachmentWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("IrAttachmentId")]
    [InverseProperty("IrAttachments")]
    public virtual ICollection<AccountBankStatementImport> AccountBankStatementImports { get; } = new List<AccountBankStatementImport>();

    [ForeignKey("IrAttachmentId")]
    [InverseProperty("IrAttachments")]
    public virtual ICollection<AccountBankStatement> AccountBankStatements { get; } = new List<AccountBankStatement>();

    [ForeignKey("IrAttachmentId")]
    [InverseProperty("IrAttachments")]
    public virtual ICollection<AccountTourUploadBill> AccountTourUploadBills { get; } = new List<AccountTourUploadBill>();

    [ForeignKey("AttachmentId")]
    [InverseProperty("Attachments")]
    public virtual ICollection<MailTemplate> EmailTemplates { get; } = new List<MailTemplate>();

    [ForeignKey("AttachmentId")]
    [InverseProperty("Attachments")]
    public virtual ICollection<MailMessage> Messages { get; } = new List<MailMessage>();

    [ForeignKey("AttachmentId")]
    [InverseProperty("Attachments")]
    public virtual ICollection<MailComposeMessage> Wizards { get; } = new List<MailComposeMessage>();
}
