using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Bamboo.Core.Models;
using Microsoft.Extensions.Hosting.Internal;

namespace Bamboo.CodeGenerators;
/*
for file in *; do echo "lstTypes.Add(typeof(${file%.*}));"; done 
*/
public class CodeGenerator
{
    protected List<System.Type> _lstTypes = new List<System.Type>();
    public CodeGenerator()
    {
    }

    public void Init()
    {
        _lstTypes = GeneratedListType();
    }

    public void GenCode()
    {
        var contractTemplate =
@"
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Bamboo.Core.Models;

namespace Bamboo.Core.Services;
public interface I%NameModel%AppService :
    ICrudAppService<
        %NameModel%,
        %NameKey%,
        PagedAndSortedResultRequestDto>
{
}
";

        var serviceTemplate =
@"
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

using Bamboo.Core.Models;

namespace Bamboo.Core.Services;

public class %NameModel%AppService :
    CrudAppService<%NameModel%, %NameModel%, %NameKey%, PagedAndSortedResultRequestDto>,
    I%NameModel%AppService
{
    public %NameModel%AppService(IRepository<%NameModel%, %NameKey%> repository)
        : base(repository)
    {
    }
}
";

        var controllerTemplate =
@"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

using Bamboo.Core.Models;
using Bamboo.Core.Services;

namespace Bamboo.Core.Controllers;

[Area(CoreRemoteServiceConsts.ModuleName)]
[RemoteService(Name = CoreRemoteServiceConsts.RemoteServiceName)]
[Route(""api/Core/%NameModel%"")]
public class %NameModel%Controller : CoreController, I%NameModel%AppService
{
    private readonly I%NameModel%AppService _AppService;
    
    public %NameModel%Controller(I%NameModel%AppService AppService)
    {
        _AppService = AppService;
    }

    [HttpPost]
    public async Task<%NameModel%> CreateAsync(%NameModel% input)
    {
        return await _AppService.CreateAsync(input);
    }

    [HttpGet]
    [Route(""{id}"")]
    public async Task<%NameModel%> GetAsync(%NameKey% id)
    {
        return await _AppService.GetAsync(id);
    }

    [HttpGet]
    public async Task<PagedResultDto<%NameModel%>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        return await _AppService.GetListAsync(input);
    }

    [HttpPut]
    [Route(""{id}"")]
    public async Task<%NameModel%> UpdateAsync(%NameKey% id, %NameModel% input)
    {
        return await _AppService.UpdateAsync(id, input);
    }

    [HttpDelete]
    [Route(""{id}"")]
    public async Task DeleteAsync(%NameKey% id)
    {
        await _AppService.DeleteAsync(id);
    }

}
";
        var pathContract = Path.Combine("", string.Format("..{0}..{0}..{0}..{0}shared{0}core{0}Bamboo.Core.Application.Contracts{0}AppContract", Path.DirectorySeparatorChar));
        var pathService = Path.Combine("", string.Format("..{0}..{0}src{0}Bamboo.Core.Application{0}AppService", Path.DirectorySeparatorChar));
        var pathController = Path.Combine("", string.Format("..{0}..{0}src{0}Bamboo.Core.HttpApi{0}AppController", Path.DirectorySeparatorChar));
        if (!Directory.Exists(pathContract))
            Directory.CreateDirectory(pathContract);
        if (!Directory.Exists(pathService))
            Directory.CreateDirectory(pathService);
        if (!Directory.Exists(pathController))
            Directory.CreateDirectory(pathController);
        var lstString = new List<string>();
        foreach (var type in _lstTypes)
        {
            var props = type.GetProperties();
            var info = props.Where(x => x.Name == "Id").FirstOrDefault();
            if (info == null) continue;
            foreach (var prop in props)
            {
                var typeName = prop.PropertyType.Name;
                if (typeName == "Guid" || prop.PropertyType.FullName.StartsWith("System.Nullable`1[[System.Guid"))
                {
                    if(!prop.Name.EndsWith("Id"))
                        lstString.Add($"{type.Name}.{prop.Name}");
                }
            }
            var NameKey = info.Name;
            var NameType = info.PropertyType.Name;
            if (NameType == "Int64") NameType = "long";
            var NameTenant = props.Where(x => x.Name == "TenantId").FirstOrDefault();

            var contract = contractTemplate.Replace("%NameModel%", type.Name);
            contract = contract.Replace("%NameKey%", NameType);

            var service = serviceTemplate.Replace("%NameModel%", type.Name);
            service = service.Replace("%NameKey%", NameType);
            var controller = controllerTemplate.Replace("%NameModel%", type.Name);
            controller = controller.Replace("%NameKey%", NameType);

            File.WriteAllText($"{pathContract}{Path.DirectorySeparatorChar}{type.Name}Contract.cs", contract);
            if (type.Name.StartsWith("Res") || type.Name.StartsWith("Ir"))
            {
                File.WriteAllText($"{pathService}{Path.DirectorySeparatorChar}{type.Name}Service.cs", service);
                File.WriteAllText($"{pathController}{Path.DirectorySeparatorChar}{type.Name}Controller.cs", controller);
            }
            if (NameTenant != null)
            {
            }
            else
            {
            }
        }
        var str = String.Join(Environment.NewLine, lstString);
        if (lstString.Count > 0) 
        { }
            
    }

    protected List<System.Type> GeneratedListType()
    {
        var lstTypes = new List<System.Type>();
        lstTypes.Add(typeof(AccountAccount));
        lstTypes.Add(typeof(AccountAccountTag));
        lstTypes.Add(typeof(AccountAccountTemplate));
        lstTypes.Add(typeof(AccountAccountType));
        lstTypes.Add(typeof(AccountAccruedOrdersWizard));
        lstTypes.Add(typeof(AccountAgedTrialBalance));
        lstTypes.Add(typeof(AccountAnalyticAccount));
        lstTypes.Add(typeof(AccountAnalyticApplicability));
        lstTypes.Add(typeof(AccountAnalyticDistributionModel));
        lstTypes.Add(typeof(AccountAnalyticLine));
        lstTypes.Add(typeof(AccountAnalyticPlan));
        lstTypes.Add(typeof(AccountAssetAsset));
        lstTypes.Add(typeof(AccountAssetCategory));
        lstTypes.Add(typeof(AccountAssetDepreciationLine));
        lstTypes.Add(typeof(AccountAutomaticEntryWizard));
        lstTypes.Add(typeof(AccountBalanceReport));
        lstTypes.Add(typeof(AccountBankStatement));
        lstTypes.Add(typeof(AccountBankStatementImport));
        lstTypes.Add(typeof(AccountBankStatementImportJournalCreation));
        lstTypes.Add(typeof(AccountBankStatementLine));
        lstTypes.Add(typeof(AccountBankbookReport));
        lstTypes.Add(typeof(AccountBudgetPost));
        lstTypes.Add(typeof(AccountCashRounding));
        lstTypes.Add(typeof(AccountCashbookReport));
        lstTypes.Add(typeof(AccountChartTemplate));
        lstTypes.Add(typeof(AccountCommonAccountReport));
        lstTypes.Add(typeof(AccountCommonJournalReport));
        lstTypes.Add(typeof(AccountCommonPartnerReport));
        lstTypes.Add(typeof(AccountCommonReport));
        lstTypes.Add(typeof(AccountDaybookReport));
        lstTypes.Add(typeof(AccountEdiDocument));
        lstTypes.Add(typeof(AccountEdiFormat));
        lstTypes.Add(typeof(AccountFinancialReport));
        lstTypes.Add(typeof(AccountFinancialYearOp));
        lstTypes.Add(typeof(AccountFiscalPosition));
        lstTypes.Add(typeof(AccountFiscalPositionAccount));
        lstTypes.Add(typeof(AccountFiscalPositionAccountTemplate));
        lstTypes.Add(typeof(AccountFiscalPositionTax));
        lstTypes.Add(typeof(AccountFiscalPositionTaxTemplate));
        lstTypes.Add(typeof(AccountFiscalPositionTemplate));
        lstTypes.Add(typeof(AccountFiscalYear));
        lstTypes.Add(typeof(AccountFullReconcile));
        lstTypes.Add(typeof(AccountGroup));
        lstTypes.Add(typeof(AccountGroupTemplate));
        lstTypes.Add(typeof(AccountIncoterm));
        lstTypes.Add(typeof(AccountInvoiceSend));
        lstTypes.Add(typeof(AccountJournal));
        lstTypes.Add(typeof(AccountJournalGroup));
        lstTypes.Add(typeof(AccountMove));
        lstTypes.Add(typeof(AccountMoveLine));
        lstTypes.Add(typeof(AccountMoveReversal));
        lstTypes.Add(typeof(AccountPartialReconcile));
        lstTypes.Add(typeof(AccountPayment));
        lstTypes.Add(typeof(AccountPaymentMethod));
        lstTypes.Add(typeof(AccountPaymentMethodLine));
        lstTypes.Add(typeof(AccountPaymentRegister));
        lstTypes.Add(typeof(AccountPaymentTerm));
        lstTypes.Add(typeof(AccountPaymentTermLine));
        lstTypes.Add(typeof(AccountPrintJournal));
        lstTypes.Add(typeof(AccountReconcileModel));
        lstTypes.Add(typeof(AccountReconcileModelLine));
        lstTypes.Add(typeof(AccountReconcileModelLineTemplate));
        lstTypes.Add(typeof(AccountReconcileModelPartnerMapping));
        lstTypes.Add(typeof(AccountReconcileModelTemplate));
        lstTypes.Add(typeof(AccountRecurringTemplate));
        lstTypes.Add(typeof(AccountReport));
        lstTypes.Add(typeof(AccountReportColumn));
        lstTypes.Add(typeof(AccountReportExpression));
        lstTypes.Add(typeof(AccountReportExternalValue));
        lstTypes.Add(typeof(AccountReportGeneralLedger));
        lstTypes.Add(typeof(AccountReportLine));
        lstTypes.Add(typeof(AccountReportPartnerLedger));
        lstTypes.Add(typeof(AccountResequenceWizard));
        lstTypes.Add(typeof(AccountSetupBankManualConfig));
        lstTypes.Add(typeof(AccountTax));
        lstTypes.Add(typeof(AccountTaxGroup));
        lstTypes.Add(typeof(AccountTaxRepartitionLine));
        lstTypes.Add(typeof(AccountTaxRepartitionLineTemplate));
        lstTypes.Add(typeof(AccountTaxReportWizard));
        lstTypes.Add(typeof(AccountTaxTemplate));
        lstTypes.Add(typeof(AccountTourUploadBill));
        lstTypes.Add(typeof(AccountTourUploadBillEmailConfirm));
        lstTypes.Add(typeof(AccountUnreconcile));
        lstTypes.Add(typeof(AccountingReport));
        lstTypes.Add(typeof(ApplicantGetRefuseReason));
        lstTypes.Add(typeof(ApplicantSendMail));
        lstTypes.Add(typeof(AssetDepreciationConfirmationWizard));
        lstTypes.Add(typeof(AssetModify));
        lstTypes.Add(typeof(AuthTotpDevice));
        lstTypes.Add(typeof(AuthTotpWizard));
        lstTypes.Add(typeof(BarcodeNomenclature));
        lstTypes.Add(typeof(BarcodeRule));
        lstTypes.Add(typeof(BaseDocumentLayout));
        lstTypes.Add(typeof(BaseEnableProfilingWizard));
        lstTypes.Add(typeof(BaseImportImport));
        lstTypes.Add(typeof(BaseImportMapping));
        lstTypes.Add(typeof(BaseImportTestsModelsChar));
        lstTypes.Add(typeof(BaseImportTestsModelsCharNoreadonly));
        lstTypes.Add(typeof(BaseImportTestsModelsCharReadonly));
        lstTypes.Add(typeof(BaseImportTestsModelsCharRequired));
        lstTypes.Add(typeof(BaseImportTestsModelsCharState));
        lstTypes.Add(typeof(BaseImportTestsModelsCharStillreadonly));
        lstTypes.Add(typeof(BaseImportTestsModelsComplex));
        lstTypes.Add(typeof(BaseImportTestsModelsFloat));
        lstTypes.Add(typeof(BaseImportTestsModelsM2o));
        lstTypes.Add(typeof(BaseImportTestsModelsM2oRelated));
        lstTypes.Add(typeof(BaseImportTestsModelsM2oRequired));
        lstTypes.Add(typeof(BaseImportTestsModelsM2oRequiredRelated));
        lstTypes.Add(typeof(BaseImportTestsModelsO2m));
        lstTypes.Add(typeof(BaseImportTestsModelsO2mChild));
        lstTypes.Add(typeof(BaseImportTestsModelsPreview));
        lstTypes.Add(typeof(BaseLanguageExport));
        lstTypes.Add(typeof(BaseLanguageImport));
        lstTypes.Add(typeof(BaseLanguageInstall));
        lstTypes.Add(typeof(BaseModuleInstallRequest));
        lstTypes.Add(typeof(BaseModuleInstallReview));
        lstTypes.Add(typeof(BaseModuleUninstall));
        lstTypes.Add(typeof(BaseModuleUpdate));
        lstTypes.Add(typeof(BaseModuleUpgrade));
        lstTypes.Add(typeof(BasePartnerMergeAutomaticWizard));
        lstTypes.Add(typeof(BasePartnerMergeLine));
        lstTypes.Add(typeof(BusBu));
        lstTypes.Add(typeof(BusPresence));
        lstTypes.Add(typeof(CalendarAlarm));
        lstTypes.Add(typeof(CalendarAttendee));
        lstTypes.Add(typeof(CalendarEvent));
        lstTypes.Add(typeof(CalendarEventType));
        lstTypes.Add(typeof(CalendarFilter));
        lstTypes.Add(typeof(CalendarProviderConfig));
        lstTypes.Add(typeof(CalendarRecurrence));
        lstTypes.Add(typeof(ChangeLockDate));
        lstTypes.Add(typeof(ChangePasswordOwn));
        lstTypes.Add(typeof(ChangePasswordUser));
        lstTypes.Add(typeof(ChangePasswordWizard));
        lstTypes.Add(typeof(ChangeProductionQty));
        lstTypes.Add(typeof(ConfirmStockSm));
        lstTypes.Add(typeof(CrmIapLeadHelper));
        lstTypes.Add(typeof(CrmIapLeadIndustry));
        lstTypes.Add(typeof(CrmIapLeadMiningRequest));
        lstTypes.Add(typeof(CrmIapLeadRole));
        lstTypes.Add(typeof(CrmIapLeadSeniority));
        lstTypes.Add(typeof(CrmLead));
        lstTypes.Add(typeof(CrmLead2opportunityPartner));
        lstTypes.Add(typeof(CrmLead2opportunityPartnerMass));
        lstTypes.Add(typeof(CrmLeadLost));
        lstTypes.Add(typeof(CrmLeadPlsUpdate));
        lstTypes.Add(typeof(CrmLeadScoringFrequency));
        lstTypes.Add(typeof(CrmLeadScoringFrequencyField));
        lstTypes.Add(typeof(CrmLostReason));
        lstTypes.Add(typeof(CrmMergeOpportunity));
        lstTypes.Add(typeof(CrmQuotationPartner));
        lstTypes.Add(typeof(CrmRecurringPlan));
        lstTypes.Add(typeof(CrmStage));
        lstTypes.Add(typeof(CrmTag));
        lstTypes.Add(typeof(CrmTeam));
        lstTypes.Add(typeof(CrmTeamMember));
        lstTypes.Add(typeof(CrossoveredBudget));
        lstTypes.Add(typeof(CrossoveredBudgetLine));
        lstTypes.Add(typeof(DecimalPrecision));
        lstTypes.Add(typeof(DigestDigest));
        lstTypes.Add(typeof(DigestTip));
        lstTypes.Add(typeof(FetchmailServer));
        lstTypes.Add(typeof(FleetServiceType));
        lstTypes.Add(typeof(FleetVehicle));
        lstTypes.Add(typeof(FleetVehicleAssignationLog));
        lstTypes.Add(typeof(FleetVehicleLogContract));
        lstTypes.Add(typeof(FleetVehicleLogService));
        lstTypes.Add(typeof(FleetVehicleModel));
        lstTypes.Add(typeof(FleetVehicleModelBrand));
        lstTypes.Add(typeof(FleetVehicleModelCategory));
        lstTypes.Add(typeof(FleetVehicleOdometer));
        lstTypes.Add(typeof(FleetVehicleState));
        lstTypes.Add(typeof(FleetVehicleTag));
        lstTypes.Add(typeof(FollowupFollowup));
        lstTypes.Add(typeof(FollowupLine));
        lstTypes.Add(typeof(FollowupPrint));
        lstTypes.Add(typeof(FollowupSendingResult));
        lstTypes.Add(typeof(HrApplicant));
        lstTypes.Add(typeof(HrApplicantCategory));
        lstTypes.Add(typeof(HrApplicantRefuseReason));
        lstTypes.Add(typeof(HrApplicantSkill));
        lstTypes.Add(typeof(HrAttendance));
        lstTypes.Add(typeof(HrAttendanceOvertime));
        lstTypes.Add(typeof(HrContract));
        lstTypes.Add(typeof(HrContractType));
        lstTypes.Add(typeof(HrDepartment));
        lstTypes.Add(typeof(HrDepartureReason));
        lstTypes.Add(typeof(HrDepartureWizard));
        lstTypes.Add(typeof(HrEmployee));
        lstTypes.Add(typeof(HrEmployeeCategory));
        lstTypes.Add(typeof(HrEmployeeSkill));
        lstTypes.Add(typeof(HrEmployeeSkillLog));
        lstTypes.Add(typeof(HrExpense));
        lstTypes.Add(typeof(HrExpenseApproveDuplicate));
        lstTypes.Add(typeof(HrExpenseRefuseWizard));
        lstTypes.Add(typeof(HrExpenseSheet));
        lstTypes.Add(typeof(HrExpenseSplit));
        lstTypes.Add(typeof(HrExpenseSplitWizard));
        lstTypes.Add(typeof(HrHolidaysCancelLeave));
        lstTypes.Add(typeof(HrHolidaysSummaryEmployee));
        lstTypes.Add(typeof(HrJob));
        lstTypes.Add(typeof(HrLeave));
        lstTypes.Add(typeof(HrLeaveAccrualLevel));
        lstTypes.Add(typeof(HrLeaveAccrualPlan));
        lstTypes.Add(typeof(HrLeaveAllocation));
        lstTypes.Add(typeof(HrLeaveStressDay));
        lstTypes.Add(typeof(HrLeaveType));
        lstTypes.Add(typeof(HrPayrollStructureType));
        lstTypes.Add(typeof(HrPlan));
        lstTypes.Add(typeof(HrPlanActivityType));
        lstTypes.Add(typeof(HrPlanWizard));
        lstTypes.Add(typeof(HrRecruitmentDegree));
        lstTypes.Add(typeof(HrRecruitmentSource));
        lstTypes.Add(typeof(HrRecruitmentStage));
        lstTypes.Add(typeof(HrResumeLine));
        lstTypes.Add(typeof(HrResumeLineType));
        lstTypes.Add(typeof(HrSkill));
        lstTypes.Add(typeof(HrSkillLevel));
        lstTypes.Add(typeof(HrSkillType));
        lstTypes.Add(typeof(HrWorkLocation));
        lstTypes.Add(typeof(IapAccount));
        lstTypes.Add(typeof(IrActClient));
        lstTypes.Add(typeof(IrActReportXml));
        lstTypes.Add(typeof(IrActServer));
        lstTypes.Add(typeof(IrActUrl));
        lstTypes.Add(typeof(IrActWindow));
        lstTypes.Add(typeof(IrActWindowView));
        lstTypes.Add(typeof(IrAction));
        lstTypes.Add(typeof(IrActionsTodo));
        lstTypes.Add(typeof(IrAsset));
        lstTypes.Add(typeof(IrAttachment));
        lstTypes.Add(typeof(IrConfigParameter));
        lstTypes.Add(typeof(IrCron));
        lstTypes.Add(typeof(IrCronTrigger));
        lstTypes.Add(typeof(IrDefault));
        lstTypes.Add(typeof(IrDemo));
        lstTypes.Add(typeof(IrDemoFailure));
        lstTypes.Add(typeof(IrDemoFailureWizard));
        lstTypes.Add(typeof(IrExport));
        lstTypes.Add(typeof(IrExportsLine));
        lstTypes.Add(typeof(IrFilter));
        lstTypes.Add(typeof(IrLogging));
        lstTypes.Add(typeof(IrMailServer));
        lstTypes.Add(typeof(IrModel));
        lstTypes.Add(typeof(IrModelAccess));
        lstTypes.Add(typeof(IrModelConstraint));
        lstTypes.Add(typeof(IrModelDatum));
        lstTypes.Add(typeof(IrModelField));
        lstTypes.Add(typeof(IrModelFieldsSelection));
        lstTypes.Add(typeof(IrModelRelation));
        lstTypes.Add(typeof(IrModuleCategory));
        lstTypes.Add(typeof(IrModuleModule));
        lstTypes.Add(typeof(IrModuleModuleDependency));
        lstTypes.Add(typeof(IrModuleModuleExclusion));
        lstTypes.Add(typeof(IrProfile));
        lstTypes.Add(typeof(IrProperty));
        lstTypes.Add(typeof(IrRule));
        lstTypes.Add(typeof(IrSequence));
        lstTypes.Add(typeof(IrSequenceDateRange));
        lstTypes.Add(typeof(IrServerObjectLine));
        lstTypes.Add(typeof(IrUiMenu));
        lstTypes.Add(typeof(IrUiView));
        lstTypes.Add(typeof(IrUiViewCustom));
        lstTypes.Add(typeof(LotLabelLayout));
        lstTypes.Add(typeof(LunchAlert));
        lstTypes.Add(typeof(LunchCashmove));
        lstTypes.Add(typeof(LunchLocation));
        lstTypes.Add(typeof(LunchOrder));
        lstTypes.Add(typeof(LunchProduct));
        lstTypes.Add(typeof(LunchProductCategory));
        lstTypes.Add(typeof(LunchSupplier));
        lstTypes.Add(typeof(LunchTopping));
        lstTypes.Add(typeof(MailActivity));
        lstTypes.Add(typeof(MailActivityType));
        lstTypes.Add(typeof(MailAlias));
        lstTypes.Add(typeof(MailBlacklist));
        lstTypes.Add(typeof(MailBlacklistRemove));
        lstTypes.Add(typeof(MailChannel));
        lstTypes.Add(typeof(MailChannelMember));
        lstTypes.Add(typeof(MailChannelRtcSession));
        lstTypes.Add(typeof(MailComposeMessage));
        lstTypes.Add(typeof(MailFollower));
        lstTypes.Add(typeof(MailGatewayAllowed));
        lstTypes.Add(typeof(MailGuest));
        lstTypes.Add(typeof(MailIceServer));
        lstTypes.Add(typeof(MailLinkPreview));
        lstTypes.Add(typeof(MailMail));
        lstTypes.Add(typeof(MailMessage));
        lstTypes.Add(typeof(MailMessageReaction));
        lstTypes.Add(typeof(MailMessageSchedule));
        lstTypes.Add(typeof(MailMessageSubtype));
        lstTypes.Add(typeof(MailNotification));
        lstTypes.Add(typeof(MailResendMessage));
        lstTypes.Add(typeof(MailResendPartner));
        lstTypes.Add(typeof(MailShortcode));
        lstTypes.Add(typeof(MailTemplate));
        lstTypes.Add(typeof(MailTemplatePreview));
        lstTypes.Add(typeof(MailTemplateReset));
        lstTypes.Add(typeof(MailTrackingValue));
        lstTypes.Add(typeof(MailWizardInvite));
        lstTypes.Add(typeof(MaintenanceEquipment));
        lstTypes.Add(typeof(MaintenanceEquipmentCategory));
        lstTypes.Add(typeof(MaintenanceRequest));
        lstTypes.Add(typeof(MaintenanceStage));
        lstTypes.Add(typeof(MaintenanceTeam));
        lstTypes.Add(typeof(MrpBom));
        lstTypes.Add(typeof(MrpBomByproduct));
        lstTypes.Add(typeof(MrpBomLine));
        lstTypes.Add(typeof(MrpConsumptionWarning));
        lstTypes.Add(typeof(MrpConsumptionWarningLine));
        lstTypes.Add(typeof(MrpDocument));
        lstTypes.Add(typeof(MrpImmediateProduction));
        lstTypes.Add(typeof(MrpImmediateProductionLine));
        lstTypes.Add(typeof(MrpProduction));
        lstTypes.Add(typeof(MrpProductionBackorder));
        lstTypes.Add(typeof(MrpProductionBackorderLine));
        lstTypes.Add(typeof(MrpProductionSplit));
        lstTypes.Add(typeof(MrpProductionSplitLine));
        lstTypes.Add(typeof(MrpProductionSplitMulti));
        lstTypes.Add(typeof(MrpRoutingWorkcenter));
        lstTypes.Add(typeof(MrpUnbuild));
        lstTypes.Add(typeof(MrpWorkcenter));
        lstTypes.Add(typeof(MrpWorkcenterCapacity));
        lstTypes.Add(typeof(MrpWorkcenterProductivity));
        lstTypes.Add(typeof(MrpWorkcenterProductivityLoss));
        lstTypes.Add(typeof(MrpWorkcenterProductivityLossType));
        lstTypes.Add(typeof(MrpWorkcenterTag));
        lstTypes.Add(typeof(MrpWorkorder));
        lstTypes.Add(typeof(NoteNote));
        lstTypes.Add(typeof(NoteStage));
        lstTypes.Add(typeof(NoteTag));
        lstTypes.Add(typeof(PartnerStatRel));
        lstTypes.Add(typeof(PaymentIcon));
        lstTypes.Add(typeof(PaymentLinkWizard));
        lstTypes.Add(typeof(PaymentProvider));
        lstTypes.Add(typeof(PaymentProviderOnboardingWizard));
        lstTypes.Add(typeof(PaymentRefundWizard));
        lstTypes.Add(typeof(PaymentToken));
        lstTypes.Add(typeof(PaymentTransaction));
        lstTypes.Add(typeof(PhoneBlacklist));
        lstTypes.Add(typeof(PhoneBlacklistRemove));
        lstTypes.Add(typeof(PickingLabelType));
        lstTypes.Add(typeof(PortalShare));
        lstTypes.Add(typeof(PortalWizard));
        lstTypes.Add(typeof(PortalWizardUser));
        lstTypes.Add(typeof(PosBill));
        lstTypes.Add(typeof(PosCategory));
        lstTypes.Add(typeof(PosCloseSessionWizard));
        lstTypes.Add(typeof(PosConfig));
        lstTypes.Add(typeof(PosDetailsWizard));
        lstTypes.Add(typeof(PosMakePayment));
        lstTypes.Add(typeof(PosOrder));
        lstTypes.Add(typeof(PosOrderLine));
        lstTypes.Add(typeof(PosPackOperationLot));
        lstTypes.Add(typeof(PosPayment));
        lstTypes.Add(typeof(PosPaymentMethod));
        lstTypes.Add(typeof(PosSession));
        lstTypes.Add(typeof(PosSessionCheckProductWizard));
        lstTypes.Add(typeof(PrivacyLog));
        lstTypes.Add(typeof(PrivacyLookupWizard));
        lstTypes.Add(typeof(PrivacyLookupWizardLine));
        lstTypes.Add(typeof(ProcurementGroup));
        lstTypes.Add(typeof(ProductAttribute));
        lstTypes.Add(typeof(ProductAttributeCustomValue));
        lstTypes.Add(typeof(ProductAttributeValue));
        lstTypes.Add(typeof(ProductCategory));
        lstTypes.Add(typeof(ProductImage));
        lstTypes.Add(typeof(ProductLabelLayout));
        lstTypes.Add(typeof(ProductPackaging));
        lstTypes.Add(typeof(ProductPricelist));
        lstTypes.Add(typeof(ProductPricelistItem));
        lstTypes.Add(typeof(ProductProduct));
        lstTypes.Add(typeof(ProductPublicCategory));
        lstTypes.Add(typeof(ProductRemoval));
        lstTypes.Add(typeof(ProductReplenish));
        lstTypes.Add(typeof(ProductRibbon));
        lstTypes.Add(typeof(ProductSupplierinfo));
        lstTypes.Add(typeof(ProductTag));
        lstTypes.Add(typeof(ProductTemplate));
        lstTypes.Add(typeof(ProductTemplateAttributeExclusion));
        lstTypes.Add(typeof(ProductTemplateAttributeLine));
        lstTypes.Add(typeof(ProductTemplateAttributeValue));
        lstTypes.Add(typeof(ProjectCollaborator));
        lstTypes.Add(typeof(ProjectMilestone));
        lstTypes.Add(typeof(ProjectProject));
        lstTypes.Add(typeof(ProjectProjectStage));
        lstTypes.Add(typeof(ProjectShareWizard));
        lstTypes.Add(typeof(ProjectTag));
        lstTypes.Add(typeof(ProjectTask));
        lstTypes.Add(typeof(ProjectTaskRecurrence));
        lstTypes.Add(typeof(ProjectTaskType));
        lstTypes.Add(typeof(ProjectTaskTypeDeleteWizard));
        lstTypes.Add(typeof(ProjectTaskUserRel));
        lstTypes.Add(typeof(ProjectUpdate));
        lstTypes.Add(typeof(PurchaseOrder));
        lstTypes.Add(typeof(PurchaseOrderLine));
        lstTypes.Add(typeof(RatingRating));
        lstTypes.Add(typeof(RecurringPayment));
        lstTypes.Add(typeof(RecurringPaymentLine));
        lstTypes.Add(typeof(RepairFee));
        lstTypes.Add(typeof(RepairLine));
        lstTypes.Add(typeof(RepairOrder));
        lstTypes.Add(typeof(RepairOrderMakeInvoice));
        lstTypes.Add(typeof(RepairTag));
        lstTypes.Add(typeof(ReportLayout));
        lstTypes.Add(typeof(ReportPaperformat));
        lstTypes.Add(typeof(ResBank));
        lstTypes.Add(typeof(ResCompany));
        lstTypes.Add(typeof(ResConfig));
        lstTypes.Add(typeof(ResConfigInstaller));
        lstTypes.Add(typeof(ResConfigSetting));
        lstTypes.Add(typeof(ResCountry));
        lstTypes.Add(typeof(ResCountryGroup));
        lstTypes.Add(typeof(ResCountryState));
        lstTypes.Add(typeof(ResCurrency));
        lstTypes.Add(typeof(ResCurrencyRate));
        lstTypes.Add(typeof(ResGroup));
        lstTypes.Add(typeof(ResLang));
        lstTypes.Add(typeof(ResPartner));
        lstTypes.Add(typeof(ResPartnerAutocompleteSync));
        lstTypes.Add(typeof(ResPartnerBank));
        lstTypes.Add(typeof(ResPartnerCategory));
        lstTypes.Add(typeof(ResPartnerIndustry));
        lstTypes.Add(typeof(ResPartnerTitle));
        lstTypes.Add(typeof(ResUser));
        lstTypes.Add(typeof(ResUsersApikey));
        lstTypes.Add(typeof(ResUsersApikeysDescription));
        lstTypes.Add(typeof(ResUsersDeletion));
        lstTypes.Add(typeof(ResUsersIdentitycheck));
        lstTypes.Add(typeof(ResUsersLog));
        lstTypes.Add(typeof(ResUsersSetting));
        lstTypes.Add(typeof(ResUsersSettingsVolume));
        lstTypes.Add(typeof(ResetViewArchWizard));
        lstTypes.Add(typeof(ResourceCalendar));
        lstTypes.Add(typeof(ResourceCalendarAttendance));
        lstTypes.Add(typeof(ResourceCalendarLeaf));
        lstTypes.Add(typeof(ResourceResource));
        lstTypes.Add(typeof(SaleAdvancePaymentInv));
        lstTypes.Add(typeof(SaleOrder));
        lstTypes.Add(typeof(SaleOrderCancel));
        lstTypes.Add(typeof(SaleOrderLine));
        lstTypes.Add(typeof(SaleOrderOption));
        lstTypes.Add(typeof(SaleOrderTemplate));
        lstTypes.Add(typeof(SaleOrderTemplateLine));
        lstTypes.Add(typeof(SaleOrderTemplateOption));
        lstTypes.Add(typeof(SalePaymentProviderOnboardingWizard));
        lstTypes.Add(typeof(SmsComposer));
        lstTypes.Add(typeof(SmsResend));
        lstTypes.Add(typeof(SmsResendRecipient));
        lstTypes.Add(typeof(SmsSm));
        lstTypes.Add(typeof(SmsTemplate));
        lstTypes.Add(typeof(SmsTemplatePreview));
        lstTypes.Add(typeof(SmsTemplateReset));
        lstTypes.Add(typeof(SnailmailConfirmInvoice));
        lstTypes.Add(typeof(SnailmailLetter));
        lstTypes.Add(typeof(SnailmailLetterFormatError));
        lstTypes.Add(typeof(SnailmailLetterMissingRequiredField));
        lstTypes.Add(typeof(SpreadsheetDashboard));
        lstTypes.Add(typeof(SpreadsheetDashboardGroup));
        lstTypes.Add(typeof(StockAssignSerial));
        lstTypes.Add(typeof(StockBackorderConfirmation));
        lstTypes.Add(typeof(StockBackorderConfirmationLine));
        lstTypes.Add(typeof(StockChangeProductQty));
        lstTypes.Add(typeof(StockImmediateTransfer));
        lstTypes.Add(typeof(StockImmediateTransferLine));
        lstTypes.Add(typeof(StockInventoryAdjustmentName));
        lstTypes.Add(typeof(StockInventoryConflict));
        lstTypes.Add(typeof(StockInventoryWarning));
        lstTypes.Add(typeof(StockLocation));
        lstTypes.Add(typeof(StockLot));
        lstTypes.Add(typeof(StockMove));
        lstTypes.Add(typeof(StockMoveLine));
        lstTypes.Add(typeof(StockOrderpointSnooze));
        lstTypes.Add(typeof(StockPackageDestination));
        lstTypes.Add(typeof(StockPackageLevel));
        lstTypes.Add(typeof(StockPackageType));
        lstTypes.Add(typeof(StockPicking));
        lstTypes.Add(typeof(StockPickingType));
        lstTypes.Add(typeof(StockPutawayRule));
        lstTypes.Add(typeof(StockQuant));
        lstTypes.Add(typeof(StockQuantPackage));
        lstTypes.Add(typeof(StockQuantityHistory));
        lstTypes.Add(typeof(StockReplenishmentInfo));
        lstTypes.Add(typeof(StockReplenishmentOption));
        lstTypes.Add(typeof(StockRequestCount));
        lstTypes.Add(typeof(StockReturnPicking));
        lstTypes.Add(typeof(StockReturnPickingLine));
        lstTypes.Add(typeof(StockRoute));
        lstTypes.Add(typeof(StockRule));
        lstTypes.Add(typeof(StockRulesReport));
        lstTypes.Add(typeof(StockSchedulerCompute));
        lstTypes.Add(typeof(StockScrap));
        lstTypes.Add(typeof(StockStorageCategory));
        lstTypes.Add(typeof(StockStorageCategoryCapacity));
        lstTypes.Add(typeof(StockTraceabilityReport));
        lstTypes.Add(typeof(StockTrackConfirmation));
        lstTypes.Add(typeof(StockTrackLine));
        lstTypes.Add(typeof(StockValuationLayer));
        lstTypes.Add(typeof(StockValuationLayerRevaluation));
        lstTypes.Add(typeof(StockWarehouse));
        lstTypes.Add(typeof(StockWarehouseOrderpoint));
        lstTypes.Add(typeof(StockWarnInsufficientQtyRepair));
        lstTypes.Add(typeof(StockWarnInsufficientQtyScrap));
        lstTypes.Add(typeof(StockWarnInsufficientQtyUnbuild));
        lstTypes.Add(typeof(ThemeIrAsset));
        lstTypes.Add(typeof(ThemeIrAttachment));
        lstTypes.Add(typeof(ThemeIrUiView));
        lstTypes.Add(typeof(ThemeWebsiteMenu));
        lstTypes.Add(typeof(ThemeWebsitePage));
        lstTypes.Add(typeof(UomCategory));
        lstTypes.Add(typeof(UomUom));
        lstTypes.Add(typeof(UtmCampaign));
        lstTypes.Add(typeof(UtmMedium));
        lstTypes.Add(typeof(UtmSource));
        lstTypes.Add(typeof(UtmStage));
        lstTypes.Add(typeof(UtmTag));
        lstTypes.Add(typeof(ValidateAccountMove));
        lstTypes.Add(typeof(WebEditorConverterTest));
        lstTypes.Add(typeof(WebEditorConverterTestSub));
        lstTypes.Add(typeof(WebTourTour));
        lstTypes.Add(typeof(Website));
        lstTypes.Add(typeof(WebsiteBaseUnit));
        lstTypes.Add(typeof(WebsiteConfiguratorFeature));
        lstTypes.Add(typeof(WebsiteMenu));
        lstTypes.Add(typeof(WebsitePage));
        lstTypes.Add(typeof(WebsiteRewrite));
        lstTypes.Add(typeof(WebsiteRobot));
        lstTypes.Add(typeof(WebsiteRoute));
        lstTypes.Add(typeof(WebsiteSaleExtraField));
        lstTypes.Add(typeof(WebsiteSnippetFilter));
        lstTypes.Add(typeof(WebsiteTrack));
        lstTypes.Add(typeof(WebsiteVisitor));
        lstTypes.Add(typeof(WizardIrModelMenuCreate));
        return lstTypes;
    }
}