using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Bamboo.Core.Entities;

namespace Bamboo.Core.EntityFrameworkCore;
public static class CoreDbtModelCreatingExtensions
{
    public static void ConfigureCoreExt(
        this ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresExtension("pg_trgm");

        modelBuilder.Entity<AccountAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_account_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountAccounts)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_account_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountAccountCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_account_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.AccountAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_account_currency_id_fkey");

            entity.HasOne(d => d.Group).WithMany(p => p.AccountAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_account_group_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.AccountAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_account_message_main_attachment_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountAccountWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_account_write_uid_fkey");

            entity.HasMany(d => d.AccountAccountTags).WithMany(p => p.AccountAccounts)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountAccountAccountTag",
                    r => r.HasOne<AccountAccountTag>().WithMany()
                        .HasForeignKey("AccountAccountTagId")
                        .HasConstraintName("account_account_account_tag_account_account_tag_id_fkey"),
                    l => l.HasOne<AccountAccount>().WithMany()
                        .HasForeignKey("AccountAccountId")
                        .HasConstraintName("account_account_account_tag_account_account_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountAccountId", "AccountAccountTagId").HasName("account_account_account_tag_pkey");
                        j.ToTable("account_account_account_tag");
                        j.HasIndex(new[] { "AccountAccountTagId", "AccountAccountId" }, "account_account_account_tag_account_account_tag_id_account__idx");
                    });

            entity.HasMany(d => d.AccountJournals).WithMany(p => p.AccountAccounts)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountAccountAccountJournalRel",
                    r => r.HasOne<AccountJournal>().WithMany()
                        .HasForeignKey("AccountJournalId")
                        .HasConstraintName("account_account_account_journal_rel_account_journal_id_fkey"),
                    l => l.HasOne<AccountAccount>().WithMany()
                        .HasForeignKey("AccountAccountId")
                        .HasConstraintName("account_account_account_journal_rel_account_account_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountAccountId", "AccountJournalId").HasName("account_account_account_journal_rel_pkey");
                        j.ToTable("account_account_account_journal_rel");
                        j.HasIndex(new[] { "AccountJournalId", "AccountAccountId" }, "account_account_account_journ_account_journal_id_account_ac_idx");
                    });

            entity.HasMany(d => d.Taxes).WithMany(p => p.Accounts)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountAccountTaxDefaultRel",
                    r => r.HasOne<AccountTax>().WithMany()
                        .HasForeignKey("TaxId")
                        .HasConstraintName("account_account_tax_default_rel_tax_id_fkey"),
                    l => l.HasOne<AccountAccount>().WithMany()
                        .HasForeignKey("AccountId")
                        .HasConstraintName("account_account_tax_default_rel_account_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountId", "TaxId").HasName("account_account_tax_default_rel_pkey");
                        j.ToTable("account_account_tax_default_rel");
                        j.HasIndex(new[] { "TaxId", "AccountId" }, "account_account_tax_default_rel_tax_id_account_id_idx");
                    });
        });

        modelBuilder.Entity<AccountAccountTag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_account_tag_pkey");

            entity.HasOne(d => d.Country).WithMany(p => p.AccountAccountTags)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_account_tag_country_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountAccountTagCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_account_tag_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountAccountTagWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_account_tag_write_uid_fkey");
        });

        modelBuilder.Entity<AccountAccountTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_account_template_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.ChartTemplate).WithMany(p => p.AccountAccountTemplates)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_account_template_chart_template_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountAccountTemplateCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_account_template_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.AccountAccountTemplates)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_account_template_currency_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.AccountAccountTemplates)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_account_template_message_main_attachment_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountAccountTemplateWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_account_template_write_uid_fkey");

            entity.HasMany(d => d.AccountAccountTags).WithMany(p => p.AccountAccountTemplates)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountAccountTemplateAccountTag",
                    r => r.HasOne<AccountAccountTag>().WithMany()
                        .HasForeignKey("AccountAccountTagId")
                        .HasConstraintName("account_account_template_account_ta_account_account_tag_id_fkey"),
                    l => l.HasOne<AccountAccountTemplate>().WithMany()
                        .HasForeignKey("AccountAccountTemplateId")
                        .HasConstraintName("account_account_template_accou_account_account_template_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountAccountTemplateId", "AccountAccountTagId").HasName("account_account_template_account_tag_pkey");
                        j.ToTable("account_account_template_account_tag");
                        j.HasIndex(new[] { "AccountAccountTagId", "AccountAccountTemplateId" }, "account_account_template_acco_account_account_tag_id_accoun_idx");
                    });

            entity.HasMany(d => d.Taxes).WithMany(p => p.Accounts)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountAccountTemplateTaxRel",
                    r => r.HasOne<AccountTaxTemplate>().WithMany()
                        .HasForeignKey("TaxId")
                        .HasConstraintName("account_account_template_tax_rel_tax_id_fkey"),
                    l => l.HasOne<AccountAccountTemplate>().WithMany()
                        .HasForeignKey("AccountId")
                        .HasConstraintName("account_account_template_tax_rel_account_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountId", "TaxId").HasName("account_account_template_tax_rel_pkey");
                        j.ToTable("account_account_template_tax_rel");
                        j.HasIndex(new[] { "TaxId", "AccountId" }, "account_account_template_tax_rel_tax_id_account_id_idx");
                    });
        });

        modelBuilder.Entity<AccountAccountType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_account_type_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountAccountTypeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_account_type_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountAccountTypeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_account_type_write_uid_fkey");
        });

        modelBuilder.Entity<AccountAccruedOrdersWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_accrued_orders_wizard_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Account).WithMany(p => p.AccountAccruedOrdersWizards)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_accrued_orders_wizard_account_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountAccruedOrdersWizards)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_accrued_orders_wizard_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountAccruedOrdersWizardCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_accrued_orders_wizard_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.AccountAccruedOrdersWizards)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_accrued_orders_wizard_currency_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountAccruedOrdersWizardWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_accrued_orders_wizard_write_uid_fkey");
        });

        modelBuilder.Entity<AccountAgedTrialBalance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_aged_trial_balance_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountAgedTrialBalances)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_aged_trial_balance_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountAgedTrialBalanceCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_aged_trial_balance_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountAgedTrialBalanceWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_aged_trial_balance_write_uid_fkey");

            entity.HasMany(d => d.AccountJournals).WithMany(p => p.AccountAgedTrialBalances)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountAgedTrialBalanceAccountJournalRel",
                    r => r.HasOne<AccountJournal>().WithMany()
                        .HasForeignKey("AccountJournalId")
                        .HasConstraintName("account_aged_trial_balance_account_jour_account_journal_id_fkey"),
                    l => l.HasOne<AccountAgedTrialBalance>().WithMany()
                        .HasForeignKey("AccountAgedTrialBalanceId")
                        .HasConstraintName("account_aged_trial_balance_ac_account_aged_trial_balance_i_fkey"),
                    j =>
                    {
                        j.HasKey("AccountAgedTrialBalanceId", "AccountJournalId").HasName("account_aged_trial_balance_account_journal_rel_pkey");
                        j.ToTable("account_aged_trial_balance_account_journal_rel");
                        j.HasIndex(new[] { "AccountJournalId", "AccountAgedTrialBalanceId" }, "account_aged_trial_balance_ac_account_journal_id_account_ag_idx");
                    });

            entity.HasMany(d => d.ResPartners).WithMany(p => p.AccountAgedTrialBalances)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountAgedTrialBalanceResPartnerRel",
                    r => r.HasOne<ResPartner>().WithMany()
                        .HasForeignKey("ResPartnerId")
                        .HasConstraintName("account_aged_trial_balance_res_partner_rel_res_partner_id_fkey"),
                    l => l.HasOne<AccountAgedTrialBalance>().WithMany()
                        .HasForeignKey("AccountAgedTrialBalanceId")
                        .HasConstraintName("account_aged_trial_balance_re_account_aged_trial_balance_i_fkey"),
                    j =>
                    {
                        j.HasKey("AccountAgedTrialBalanceId", "ResPartnerId").HasName("account_aged_trial_balance_res_partner_rel_pkey");
                        j.ToTable("account_aged_trial_balance_res_partner_rel");
                        j.HasIndex(new[] { "ResPartnerId", "AccountAgedTrialBalanceId" }, "account_aged_trial_balance_re_res_partner_id_account_aged_t_idx");
                    });
        });

        modelBuilder.Entity<AccountAnalyticAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_analytic_account_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountAnalyticAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_analytic_account_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountAnalyticAccountCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_analytic_account_create_uid_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.AccountAnalyticAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_analytic_account_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.AccountAnalyticAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_analytic_account_partner_id_fkey");

            entity.HasOne(d => d.Plan).WithMany(p => p.AccountAnalyticAccountPlans)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_analytic_account_plan_id_fkey");

            entity.HasOne(d => d.RootPlan).WithMany(p => p.AccountAnalyticAccountRootPlans)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_analytic_account_root_plan_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountAnalyticAccountWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_analytic_account_write_uid_fkey");
        });

        modelBuilder.Entity<AccountAnalyticApplicability>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_analytic_applicability_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.AnalyticPlan).WithMany(p => p.AccountAnalyticApplicabilities)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_analytic_applicability_analytic_plan_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountAnalyticApplicabilityCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_analytic_applicability_create_uid_fkey");

            entity.HasOne(d => d.ProductCateg).WithMany(p => p.AccountAnalyticApplicabilities)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_analytic_applicability_product_categ_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountAnalyticApplicabilityWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_analytic_applicability_write_uid_fkey");
        });

        modelBuilder.Entity<AccountAnalyticDistributionModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_analytic_distribution_model_pkey");

            entity.HasIndex(e => e.AnalyticDistribution, "account_analytic_distribution_model_analytic_distribution_gin_i").HasMethod("gin");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountAnalyticDistributionModels)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_analytic_distribution_model_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountAnalyticDistributionModelCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_analytic_distribution_model_create_uid_fkey");

            entity.HasOne(d => d.PartnerCategory).WithMany(p => p.AccountAnalyticDistributionModels)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_analytic_distribution_model_partner_category_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.AccountAnalyticDistributionModels)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_analytic_distribution_model_partner_id_fkey");

            entity.HasOne(d => d.ProductCateg).WithMany(p => p.AccountAnalyticDistributionModels)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_analytic_distribution_model_product_categ_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.AccountAnalyticDistributionModels)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_analytic_distribution_model_product_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountAnalyticDistributionModelWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_analytic_distribution_model_write_uid_fkey");
        });

        modelBuilder.Entity<AccountAnalyticLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_analytic_line_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Account).WithMany(p => p.AccountAnalyticLines)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_analytic_line_account_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountAnalyticLines)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_analytic_line_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountAnalyticLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_analytic_line_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.AccountAnalyticLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_analytic_line_currency_id_fkey");

            entity.HasOne(d => d.GeneralAccount).WithMany(p => p.AccountAnalyticLines)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_analytic_line_general_account_id_fkey");

            entity.HasOne(d => d.Journal).WithMany(p => p.AccountAnalyticLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_analytic_line_journal_id_fkey");

            entity.HasOne(d => d.MoveLine).WithMany(p => p.AccountAnalyticLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_analytic_line_move_line_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.AccountAnalyticLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_analytic_line_partner_id_fkey");

            entity.HasOne(d => d.Plan).WithMany(p => p.AccountAnalyticLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_analytic_line_plan_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.AccountAnalyticLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_analytic_line_product_id_fkey");

            entity.HasOne(d => d.ProductUom).WithMany(p => p.AccountAnalyticLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_analytic_line_product_uom_id_fkey");

            entity.HasOne(d => d.SoLineNavigation).WithMany(p => p.AccountAnalyticLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_analytic_line_so_line_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.AccountAnalyticLineUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_analytic_line_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountAnalyticLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_analytic_line_write_uid_fkey");
        });

        modelBuilder.Entity<AccountAnalyticPlan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_analytic_plan_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountAnalyticPlans)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_analytic_plan_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountAnalyticPlanCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_analytic_plan_create_uid_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_analytic_plan_parent_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountAnalyticPlanWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_analytic_plan_write_uid_fkey");
        });

        modelBuilder.Entity<AccountAssetAsset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_asset_asset_pkey");

            entity.HasIndex(e => e.AnalyticDistribution, "account_asset_asset_analytic_distribution_gin_index").HasMethod("gin");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.AccountAnalytic).WithMany(p => p.AccountAssetAssets)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_asset_asset_account_analytic_id_fkey");

            entity.HasOne(d => d.Category).WithMany(p => p.AccountAssetAssets)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_asset_asset_category_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountAssetAssets)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_asset_asset_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountAssetAssetCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_asset_asset_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.AccountAssetAssets)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_asset_asset_currency_id_fkey");

            entity.HasOne(d => d.Invoice).WithMany(p => p.AccountAssetAssets)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_asset_asset_invoice_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.AccountAssetAssets)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_asset_asset_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.AccountAssetAssets)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_asset_asset_partner_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountAssetAssetWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_asset_asset_write_uid_fkey");
        });

        modelBuilder.Entity<AccountAssetCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_asset_category_pkey");

            entity.HasIndex(e => e.AnalyticDistribution, "account_asset_category_analytic_distribution_gin_index").HasMethod("gin");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.AccountAnalytic).WithMany(p => p.AccountAssetCategories)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_asset_category_account_analytic_id_fkey");

            entity.HasOne(d => d.AccountAsset).WithMany(p => p.AccountAssetCategoryAccountAssets)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_asset_category_account_asset_id_fkey");

            entity.HasOne(d => d.AccountDepreciationExpense).WithMany(p => p.AccountAssetCategoryAccountDepreciationExpenses)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_asset_category_account_depreciation_expense_id_fkey");

            entity.HasOne(d => d.AccountDepreciation).WithMany(p => p.AccountAssetCategoryAccountDepreciations)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_asset_category_account_depreciation_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountAssetCategories)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_asset_category_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountAssetCategoryCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_asset_category_create_uid_fkey");

            entity.HasOne(d => d.Journal).WithMany(p => p.AccountAssetCategories)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_asset_category_journal_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.AccountAssetCategories)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_asset_category_message_main_attachment_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountAssetCategoryWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_asset_category_write_uid_fkey");
        });

        modelBuilder.Entity<AccountAssetDepreciationLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_asset_depreciation_line_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Asset).WithMany(p => p.AccountAssetDepreciationLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_asset_depreciation_line_asset_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountAssetDepreciationLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_asset_depreciation_line_create_uid_fkey");

            entity.HasOne(d => d.Move).WithMany(p => p.AccountAssetDepreciationLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_asset_depreciation_line_move_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountAssetDepreciationLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_asset_depreciation_line_write_uid_fkey");
        });

        modelBuilder.Entity<AccountAutomaticEntryWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_automatic_entry_wizard_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountAutomaticEntryWizards)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_automatic_entry_wizard_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountAutomaticEntryWizardCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_automatic_entry_wizard_create_uid_fkey");

            entity.HasOne(d => d.DestinationAccount).WithMany(p => p.AccountAutomaticEntryWizards)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_automatic_entry_wizard_destination_account_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountAutomaticEntryWizardWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_automatic_entry_wizard_write_uid_fkey");

            entity.HasMany(d => d.AccountMoveLines).WithMany(p => p.AccountAutomaticEntryWizards)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountAutomaticEntryWizardAccountMoveLineRel",
                    r => r.HasOne<AccountMoveLine>().WithMany()
                        .HasForeignKey("AccountMoveLineId")
                        .HasConstraintName("account_automatic_entry_wizard_accoun_account_move_line_id_fkey"),
                    l => l.HasOne<AccountAutomaticEntryWizard>().WithMany()
                        .HasForeignKey("AccountAutomaticEntryWizardId")
                        .HasConstraintName("account_automatic_entry_wizar_account_automatic_entry_wiza_fkey"),
                    j =>
                    {
                        j.HasKey("AccountAutomaticEntryWizardId", "AccountMoveLineId").HasName("account_automatic_entry_wizard_account_move_line_rel_pkey");
                        j.ToTable("account_automatic_entry_wizard_account_move_line_rel");
                        j.HasIndex(new[] { "AccountMoveLineId", "AccountAutomaticEntryWizardId" }, "account_automatic_entry_wizar_account_move_line_id_account__idx");
                    });
        });

        modelBuilder.Entity<AccountBalanceReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_balance_report_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountBalanceReports)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_balance_report_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountBalanceReportCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_balance_report_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountBalanceReportWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_balance_report_write_uid_fkey");

            entity.HasMany(d => d.AccountAccounts).WithMany(p => p.AccountBalanceReports)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountAccountAccountBalanceReportRel",
                    r => r.HasOne<AccountAccount>().WithMany()
                        .HasForeignKey("AccountAccountId")
                        .HasConstraintName("account_account_account_balance_report__account_account_id_fkey"),
                    l => l.HasOne<AccountBalanceReport>().WithMany()
                        .HasForeignKey("AccountBalanceReportId")
                        .HasConstraintName("account_account_account_balance__account_balance_report_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountBalanceReportId", "AccountAccountId").HasName("account_account_account_balance_report_rel_pkey");
                        j.ToTable("account_account_account_balance_report_rel");
                        j.HasIndex(new[] { "AccountAccountId", "AccountBalanceReportId" }, "account_account_account_balan_account_account_id_account_ba_idx");
                    });

            entity.HasMany(d => d.AccountAnalyticAccounts).WithMany(p => p.AccountBalanceReports)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountTrialBalanceAnalyticRel",
                    r => r.HasOne<AccountAnalyticAccount>().WithMany()
                        .HasForeignKey("AccountAnalyticAccountId")
                        .HasConstraintName("account_trial_balance_analytic_account_analytic_account_id_fkey"),
                    l => l.HasOne<AccountBalanceReport>().WithMany()
                        .HasForeignKey("AccountBalanceReportId")
                        .HasConstraintName("account_trial_balance_analytic_r_account_balance_report_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountBalanceReportId", "AccountAnalyticAccountId").HasName("account_trial_balance_analytic_rel_pkey");
                        j.ToTable("account_trial_balance_analytic_rel");
                        j.HasIndex(new[] { "AccountAnalyticAccountId", "AccountBalanceReportId" }, "account_trial_balance_analyti_account_analytic_account_id_a_idx");
                    });

            entity.HasMany(d => d.Journals).WithMany(p => p.Accounts)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountBalanceReportJournalRel",
                    r => r.HasOne<AccountJournal>().WithMany()
                        .HasForeignKey("JournalId")
                        .HasConstraintName("account_balance_report_journal_rel_journal_id_fkey"),
                    l => l.HasOne<AccountBalanceReport>().WithMany()
                        .HasForeignKey("AccountId")
                        .HasConstraintName("account_balance_report_journal_rel_account_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountId", "JournalId").HasName("account_balance_report_journal_rel_pkey");
                        j.ToTable("account_balance_report_journal_rel");
                        j.HasIndex(new[] { "JournalId", "AccountId" }, "account_balance_report_journal_rel_journal_id_account_id_idx");
                    });

            entity.HasMany(d => d.ResPartners).WithMany(p => p.AccountBalanceReports)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountBalanceReportResPartnerRel",
                    r => r.HasOne<ResPartner>().WithMany()
                        .HasForeignKey("ResPartnerId")
                        .HasConstraintName("account_balance_report_res_partner_rel_res_partner_id_fkey"),
                    l => l.HasOne<AccountBalanceReport>().WithMany()
                        .HasForeignKey("AccountBalanceReportId")
                        .HasConstraintName("account_balance_report_res_partn_account_balance_report_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountBalanceReportId", "ResPartnerId").HasName("account_balance_report_res_partner_rel_pkey");
                        j.ToTable("account_balance_report_res_partner_rel");
                        j.HasIndex(new[] { "ResPartnerId", "AccountBalanceReportId" }, "account_balance_report_res_pa_res_partner_id_account_balanc_idx");
                    });
        });

        modelBuilder.Entity<AccountBankStatement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_bank_statement_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountBankStatements)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_bank_statement_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountBankStatementCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_bank_statement_create_uid_fkey");

            entity.HasOne(d => d.Journal).WithMany(p => p.AccountBankStatements)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_bank_statement_journal_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountBankStatementWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_bank_statement_write_uid_fkey");

            entity.HasMany(d => d.IrAttachments).WithMany(p => p.AccountBankStatements)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountBankStatementIrAttachmentRel",
                    r => r.HasOne<IrAttachment>().WithMany()
                        .HasForeignKey("IrAttachmentId")
                        .HasConstraintName("account_bank_statement_ir_attachment_rel_ir_attachment_id_fkey"),
                    l => l.HasOne<AccountBankStatement>().WithMany()
                        .HasForeignKey("AccountBankStatementId")
                        .HasConstraintName("account_bank_statement_ir_attach_account_bank_statement_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountBankStatementId", "IrAttachmentId").HasName("account_bank_statement_ir_attachment_rel_pkey");
                        j.ToTable("account_bank_statement_ir_attachment_rel");
                        j.HasIndex(new[] { "IrAttachmentId", "AccountBankStatementId" }, "account_bank_statement_ir_att_ir_attachment_id_account_bank_idx");
                    });
        });

        modelBuilder.Entity<AccountBankStatementImport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_bank_statement_import_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountBankStatementImportCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_bank_statement_import_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountBankStatementImportWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_bank_statement_import_write_uid_fkey");

            entity.HasMany(d => d.IrAttachments).WithMany(p => p.AccountBankStatementImports)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountBankStatementImportIrAttachmentRel",
                    r => r.HasOne<IrAttachment>().WithMany()
                        .HasForeignKey("IrAttachmentId")
                        .HasConstraintName("account_bank_statement_import_ir_attachme_ir_attachment_id_fkey"),
                    l => l.HasOne<AccountBankStatementImport>().WithMany()
                        .HasForeignKey("AccountBankStatementImportId")
                        .HasConstraintName("account_bank_statement_import_account_bank_statement_impor_fkey"),
                    j =>
                    {
                        j.HasKey("AccountBankStatementImportId", "IrAttachmentId").HasName("account_bank_statement_import_ir_attachment_rel_pkey");
                        j.ToTable("account_bank_statement_import_ir_attachment_rel");
                        j.HasIndex(new[] { "IrAttachmentId", "AccountBankStatementImportId" }, "account_bank_statement_import_ir_attachment_id_account_bank_idx");
                    });
        });

        modelBuilder.Entity<AccountBankStatementImportJournalCreation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_bank_statement_import_journal_creation_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountBankStatementImportJournalCreationCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_bank_statement_import_journal_creation_create_uid_fkey");

            entity.HasOne(d => d.Journal).WithMany(p => p.AccountBankStatementImportJournalCreations)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_bank_statement_import_journal_creation_journal_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountBankStatementImportJournalCreationWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_bank_statement_import_journal_creation_write_uid_fkey");
        });

        modelBuilder.Entity<AccountBankStatementLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_bank_statement_line_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountBankStatementLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_bank_statement_line_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.AccountBankStatementLineCurrencies)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_bank_statement_line_currency_id_fkey");

            entity.HasOne(d => d.ForeignCurrency).WithMany(p => p.AccountBankStatementLineForeignCurrencies)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_bank_statement_line_foreign_currency_id_fkey");

            entity.HasOne(d => d.Move).WithMany(p => p.AccountBankStatementLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_bank_statement_line_move_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.AccountBankStatementLines)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_bank_statement_line_partner_id_fkey");

            entity.HasOne(d => d.PosSession).WithMany(p => p.AccountBankStatementLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_bank_statement_line_pos_session_id_fkey");

            entity.HasOne(d => d.Statement).WithMany(p => p.AccountBankStatementLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_bank_statement_line_statement_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountBankStatementLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_bank_statement_line_write_uid_fkey");

            entity.HasMany(d => d.AccountPayments).WithMany(p => p.AccountBankStatementLines)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountPaymentAccountBankStatementLineRel",
                    r => r.HasOne<AccountPayment>().WithMany()
                        .HasForeignKey("AccountPaymentId")
                        .HasConstraintName("account_payment_account_bank_statement__account_payment_id_fkey"),
                    l => l.HasOne<AccountBankStatementLine>().WithMany()
                        .HasForeignKey("AccountBankStatementLineId")
                        .HasConstraintName("account_payment_account_bank__account_bank_statement_line__fkey"),
                    j =>
                    {
                        j.HasKey("AccountBankStatementLineId", "AccountPaymentId").HasName("account_payment_account_bank_statement_line_rel_pkey");
                        j.ToTable("account_payment_account_bank_statement_line_rel");
                        j.HasIndex(new[] { "AccountPaymentId", "AccountBankStatementLineId" }, "account_payment_account_bank__account_payment_id_account_ba_idx");
                    });
        });

        modelBuilder.Entity<AccountBankbookReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_bankbook_report_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountBankbookReportCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_bankbook_report_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountBankbookReportWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_bankbook_report_write_uid_fkey");

            entity.HasMany(d => d.AccountJournals).WithMany(p => p.AccountBankbookReports)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountBankbookReportAccountJournalRel",
                    r => r.HasOne<AccountJournal>().WithMany()
                        .HasForeignKey("AccountJournalId")
                        .HasConstraintName("account_bankbook_report_account_journal_account_journal_id_fkey"),
                    l => l.HasOne<AccountBankbookReport>().WithMany()
                        .HasForeignKey("AccountBankbookReportId")
                        .HasConstraintName("account_bankbook_report_account_account_bankbook_report_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountBankbookReportId", "AccountJournalId").HasName("account_bankbook_report_account_journal_rel_pkey");
                        j.ToTable("account_bankbook_report_account_journal_rel");
                        j.HasIndex(new[] { "AccountJournalId", "AccountBankbookReportId" }, "account_bankbook_report_accou_account_journal_id_account_ba_idx");
                    });

            entity.HasMany(d => d.Accounts).WithMany(p => p.ReportLines)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountAccountBankbookReport",
                    r => r.HasOne<AccountAccount>().WithMany()
                        .HasForeignKey("AccountId")
                        .HasConstraintName("account_account_bankbook_report_account_id_fkey"),
                    l => l.HasOne<AccountBankbookReport>().WithMany()
                        .HasForeignKey("ReportLineId")
                        .HasConstraintName("account_account_bankbook_report_report_line_id_fkey"),
                    j =>
                    {
                        j.HasKey("ReportLineId", "AccountId").HasName("account_account_bankbook_report_pkey");
                        j.ToTable("account_account_bankbook_report");
                        j.HasIndex(new[] { "AccountId", "ReportLineId" }, "account_account_bankbook_report_account_id_report_line_id_idx");
                    });
        });

        modelBuilder.Entity<AccountBudgetPost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_budget_post_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountBudgetPosts)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_budget_post_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountBudgetPostCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_budget_post_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountBudgetPostWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_budget_post_write_uid_fkey");

            entity.HasMany(d => d.Accounts).WithMany(p => p.Budgets)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountBudgetRel",
                    r => r.HasOne<AccountAccount>().WithMany()
                        .HasForeignKey("AccountId")
                        .HasConstraintName("account_budget_rel_account_id_fkey"),
                    l => l.HasOne<AccountBudgetPost>().WithMany()
                        .HasForeignKey("BudgetId")
                        .HasConstraintName("account_budget_rel_budget_id_fkey"),
                    j =>
                    {
                        j.HasKey("BudgetId", "AccountId").HasName("account_budget_rel_pkey");
                        j.ToTable("account_budget_rel");
                        j.HasIndex(new[] { "AccountId", "BudgetId" }, "account_budget_rel_account_id_budget_id_idx");
                    });
        });

        modelBuilder.Entity<AccountCashRounding>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_cash_rounding_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountCashRoundingCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_cash_rounding_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountCashRoundingWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_cash_rounding_write_uid_fkey");
        });

        modelBuilder.Entity<AccountCashbookReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_cashbook_report_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountCashbookReportCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_cashbook_report_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountCashbookReportWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_cashbook_report_write_uid_fkey");

            entity.HasMany(d => d.AccountJournals).WithMany(p => p.AccountCashbookReports)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountCashbookReportAccountJournalRel",
                    r => r.HasOne<AccountJournal>().WithMany()
                        .HasForeignKey("AccountJournalId")
                        .HasConstraintName("account_cashbook_report_account_journal_account_journal_id_fkey"),
                    l => l.HasOne<AccountCashbookReport>().WithMany()
                        .HasForeignKey("AccountCashbookReportId")
                        .HasConstraintName("account_cashbook_report_account_account_cashbook_report_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountCashbookReportId", "AccountJournalId").HasName("account_cashbook_report_account_journal_rel_pkey");
                        j.ToTable("account_cashbook_report_account_journal_rel");
                        j.HasIndex(new[] { "AccountJournalId", "AccountCashbookReportId" }, "account_cashbook_report_accou_account_journal_id_account_ca_idx");
                    });

            entity.HasMany(d => d.Accounts).WithMany(p => p.ReportLinesNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountAccountCashbookReport",
                    r => r.HasOne<AccountAccount>().WithMany()
                        .HasForeignKey("AccountId")
                        .HasConstraintName("account_account_cashbook_report_account_id_fkey"),
                    l => l.HasOne<AccountCashbookReport>().WithMany()
                        .HasForeignKey("ReportLineId")
                        .HasConstraintName("account_account_cashbook_report_report_line_id_fkey"),
                    j =>
                    {
                        j.HasKey("ReportLineId", "AccountId").HasName("account_account_cashbook_report_pkey");
                        j.ToTable("account_account_cashbook_report");
                        j.HasIndex(new[] { "AccountId", "ReportLineId" }, "account_account_cashbook_report_account_id_report_line_id_idx");
                    });
        });

        modelBuilder.Entity<AccountChartTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_chart_template_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.AccountJournalEarlyPayDiscountGainAccount).WithMany(p => p.AccountChartTemplateAccountJournalEarlyPayDiscountGainAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_chart_template_account_journal_early_pay_discount_fkey1");

            entity.HasOne(d => d.AccountJournalEarlyPayDiscountLossAccount).WithMany(p => p.AccountChartTemplateAccountJournalEarlyPayDiscountLossAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_chart_template_account_journal_early_pay_discount__fkey");

            entity.HasOne(d => d.AccountJournalPaymentCreditAccount).WithMany(p => p.AccountChartTemplateAccountJournalPaymentCreditAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_chart_template_account_journal_payment_credit_acco_fkey");

            entity.HasOne(d => d.AccountJournalPaymentDebitAccount).WithMany(p => p.AccountChartTemplateAccountJournalPaymentDebitAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_chart_template_account_journal_payment_debit_accou_fkey");

            entity.HasOne(d => d.AccountJournalSuspenseAccount).WithMany(p => p.AccountChartTemplateAccountJournalSuspenseAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_chart_template_account_journal_suspense_account_id_fkey");

            entity.HasOne(d => d.Country).WithMany(p => p.AccountChartTemplates)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_chart_template_country_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountChartTemplateCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_chart_template_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.AccountChartTemplates)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_chart_template_currency_id_fkey");

            entity.HasOne(d => d.DefaultCashDifferenceExpenseAccount).WithMany(p => p.AccountChartTemplateDefaultCashDifferenceExpenseAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_chart_template_default_cash_difference_expense_acc_fkey");

            entity.HasOne(d => d.DefaultCashDifferenceIncomeAccount).WithMany(p => p.AccountChartTemplateDefaultCashDifferenceIncomeAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_chart_template_default_cash_difference_income_acco_fkey");

            entity.HasOne(d => d.DefaultPosReceivableAccount).WithMany(p => p.AccountChartTemplateDefaultPosReceivableAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_chart_template_default_pos_receivable_account_id_fkey");

            entity.HasOne(d => d.ExpenseCurrencyExchangeAccount).WithMany(p => p.AccountChartTemplateExpenseCurrencyExchangeAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_chart_template_expense_currency_exchange_account_i_fkey");

            entity.HasOne(d => d.IncomeCurrencyExchangeAccount).WithMany(p => p.AccountChartTemplateIncomeCurrencyExchangeAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_chart_template_income_currency_exchange_account_id_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_chart_template_parent_id_fkey");

            entity.HasOne(d => d.PropertyAccountExpenseCateg).WithMany(p => p.AccountChartTemplatePropertyAccountExpenseCategs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_chart_template_property_account_expense_categ_id_fkey");

            entity.HasOne(d => d.PropertyAccountExpense).WithMany(p => p.AccountChartTemplatePropertyAccountExpenses)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_chart_template_property_account_expense_id_fkey");

            entity.HasOne(d => d.PropertyAccountIncomeCateg).WithMany(p => p.AccountChartTemplatePropertyAccountIncomeCategs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_chart_template_property_account_income_categ_id_fkey");

            entity.HasOne(d => d.PropertyAccountIncome).WithMany(p => p.AccountChartTemplatePropertyAccountIncomes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_chart_template_property_account_income_id_fkey");

            entity.HasOne(d => d.PropertyAccountPayable).WithMany(p => p.AccountChartTemplatePropertyAccountPayables)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_chart_template_property_account_payable_id_fkey");

            entity.HasOne(d => d.PropertyAccountReceivable).WithMany(p => p.AccountChartTemplatePropertyAccountReceivables)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_chart_template_property_account_receivable_id_fkey");

            entity.HasOne(d => d.PropertyAdvanceTaxPaymentAccount).WithMany(p => p.AccountChartTemplatePropertyAdvanceTaxPaymentAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_chart_template_property_advance_tax_payment_accoun_fkey");

            entity.HasOne(d => d.PropertyCashBasisBaseAccount).WithMany(p => p.AccountChartTemplatePropertyCashBasisBaseAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_chart_template_property_cash_basis_base_account_id_fkey");

            entity.HasOne(d => d.PropertyStockAccountInputCateg).WithMany(p => p.AccountChartTemplatePropertyStockAccountInputCategs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_chart_template_property_stock_account_input_categ__fkey");

            entity.HasOne(d => d.PropertyStockAccountOutputCateg).WithMany(p => p.AccountChartTemplatePropertyStockAccountOutputCategs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_chart_template_property_stock_account_output_categ_fkey");

            entity.HasOne(d => d.PropertyStockValuationAccount).WithMany(p => p.AccountChartTemplatePropertyStockValuationAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_chart_template_property_stock_valuation_account_id_fkey");

            entity.HasOne(d => d.PropertyTaxPayableAccount).WithMany(p => p.AccountChartTemplatePropertyTaxPayableAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_chart_template_property_tax_payable_account_id_fkey");

            entity.HasOne(d => d.PropertyTaxReceivableAccount).WithMany(p => p.AccountChartTemplatePropertyTaxReceivableAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_chart_template_property_tax_receivable_account_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountChartTemplateWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_chart_template_write_uid_fkey");
        });

        modelBuilder.Entity<AccountCommonAccountReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_common_account_report_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountCommonAccountReports)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_common_account_report_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountCommonAccountReportCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_common_account_report_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountCommonAccountReportWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_common_account_report_write_uid_fkey");

            entity.HasMany(d => d.AccountAccounts).WithMany(p => p.AccountCommonAccountReports)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountAccountAccountCommonAccountReportRel",
                    r => r.HasOne<AccountAccount>().WithMany()
                        .HasForeignKey("AccountAccountId")
                        .HasConstraintName("account_account_account_common_account__account_account_id_fkey"),
                    l => l.HasOne<AccountCommonAccountReport>().WithMany()
                        .HasForeignKey("AccountCommonAccountReportId")
                        .HasConstraintName("account_account_account_commo_account_common_account_repor_fkey"),
                    j =>
                    {
                        j.HasKey("AccountCommonAccountReportId", "AccountAccountId").HasName("account_account_account_common_account_report_rel_pkey");
                        j.ToTable("account_account_account_common_account_report_rel");
                        j.HasIndex(new[] { "AccountAccountId", "AccountCommonAccountReportId" }, "account_account_account_commo_account_account_id_account_co_idx");
                    });

            entity.HasMany(d => d.AccountAnalyticAccounts).WithMany(p => p.AccountCommonAccountReports)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountAnalyticAccountAccountCommonAccountReportRel",
                    r => r.HasOne<AccountAnalyticAccount>().WithMany()
                        .HasForeignKey("AccountAnalyticAccountId")
                        .HasConstraintName("account_analytic_account_accou_account_analytic_account_id_fkey"),
                    l => l.HasOne<AccountCommonAccountReport>().WithMany()
                        .HasForeignKey("AccountCommonAccountReportId")
                        .HasConstraintName("account_analytic_account_acco_account_common_account_repor_fkey"),
                    j =>
                    {
                        j.HasKey("AccountCommonAccountReportId", "AccountAnalyticAccountId").HasName("account_analytic_account_account_common_account_report_rel_pkey");
                        j.ToTable("account_analytic_account_account_common_account_report_rel");
                        j.HasIndex(new[] { "AccountAnalyticAccountId", "AccountCommonAccountReportId" }, "account_analytic_account_acco_account_analytic_account_id_a_idx");
                    });

            entity.HasMany(d => d.AccountJournals).WithMany(p => p.AccountCommonAccountReports)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountCommonAccountReportAccountJournalRel",
                    r => r.HasOne<AccountJournal>().WithMany()
                        .HasForeignKey("AccountJournalId")
                        .HasConstraintName("account_common_account_report_account_j_account_journal_id_fkey"),
                    l => l.HasOne<AccountCommonAccountReport>().WithMany()
                        .HasForeignKey("AccountCommonAccountReportId")
                        .HasConstraintName("account_common_account_report_account_common_account_repor_fkey"),
                    j =>
                    {
                        j.HasKey("AccountCommonAccountReportId", "AccountJournalId").HasName("account_common_account_report_account_journal_rel_pkey");
                        j.ToTable("account_common_account_report_account_journal_rel");
                        j.HasIndex(new[] { "AccountJournalId", "AccountCommonAccountReportId" }, "account_common_account_report_account_journal_id_account_co_idx");
                    });

            entity.HasMany(d => d.ResPartners).WithMany(p => p.AccountCommonAccountReports)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountCommonAccountReportResPartnerRel",
                    r => r.HasOne<ResPartner>().WithMany()
                        .HasForeignKey("ResPartnerId")
                        .HasConstraintName("account_common_account_report_res_partner_r_res_partner_id_fkey"),
                    l => l.HasOne<AccountCommonAccountReport>().WithMany()
                        .HasForeignKey("AccountCommonAccountReportId")
                        .HasConstraintName("account_common_account_repor_account_common_account_repor_fkey1"),
                    j =>
                    {
                        j.HasKey("AccountCommonAccountReportId", "ResPartnerId").HasName("account_common_account_report_res_partner_rel_pkey");
                        j.ToTable("account_common_account_report_res_partner_rel");
                        j.HasIndex(new[] { "ResPartnerId", "AccountCommonAccountReportId" }, "account_common_account_report_res_partner_id_account_common_idx");
                    });
        });

        modelBuilder.Entity<AccountCommonJournalReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_common_journal_report_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountCommonJournalReports)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_common_journal_report_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountCommonJournalReportCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_common_journal_report_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountCommonJournalReportWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_common_journal_report_write_uid_fkey");

            entity.HasMany(d => d.AccountJournals).WithMany(p => p.AccountCommonJournalReports)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountCommonJournalReportAccountJournalRel",
                    r => r.HasOne<AccountJournal>().WithMany()
                        .HasForeignKey("AccountJournalId")
                        .HasConstraintName("account_common_journal_report_account_j_account_journal_id_fkey"),
                    l => l.HasOne<AccountCommonJournalReport>().WithMany()
                        .HasForeignKey("AccountCommonJournalReportId")
                        .HasConstraintName("account_common_journal_report_account_common_journal_repor_fkey"),
                    j =>
                    {
                        j.HasKey("AccountCommonJournalReportId", "AccountJournalId").HasName("account_common_journal_report_account_journal_rel_pkey");
                        j.ToTable("account_common_journal_report_account_journal_rel");
                        j.HasIndex(new[] { "AccountJournalId", "AccountCommonJournalReportId" }, "account_common_journal_report_account_journal_id_account_co_idx");
                    });
        });

        modelBuilder.Entity<AccountCommonPartnerReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_common_partner_report_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountCommonPartnerReports)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_common_partner_report_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountCommonPartnerReportCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_common_partner_report_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountCommonPartnerReportWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_common_partner_report_write_uid_fkey");

            entity.HasMany(d => d.AccountJournals).WithMany(p => p.AccountCommonPartnerReports)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountCommonPartnerReportAccountJournalRel",
                    r => r.HasOne<AccountJournal>().WithMany()
                        .HasForeignKey("AccountJournalId")
                        .HasConstraintName("account_common_partner_report_account_j_account_journal_id_fkey"),
                    l => l.HasOne<AccountCommonPartnerReport>().WithMany()
                        .HasForeignKey("AccountCommonPartnerReportId")
                        .HasConstraintName("account_common_partner_report_account_common_partner_repor_fkey"),
                    j =>
                    {
                        j.HasKey("AccountCommonPartnerReportId", "AccountJournalId").HasName("account_common_partner_report_account_journal_rel_pkey");
                        j.ToTable("account_common_partner_report_account_journal_rel");
                        j.HasIndex(new[] { "AccountJournalId", "AccountCommonPartnerReportId" }, "account_common_partner_report_account_journal_id_account_co_idx");
                    });

            entity.HasMany(d => d.ResPartners).WithMany(p => p.AccountCommonPartnerReports)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountCommonPartnerReportResPartnerRel",
                    r => r.HasOne<ResPartner>().WithMany()
                        .HasForeignKey("ResPartnerId")
                        .HasConstraintName("account_common_partner_report_res_partner_r_res_partner_id_fkey"),
                    l => l.HasOne<AccountCommonPartnerReport>().WithMany()
                        .HasForeignKey("AccountCommonPartnerReportId")
                        .HasConstraintName("account_common_partner_repor_account_common_partner_repor_fkey1"),
                    j =>
                    {
                        j.HasKey("AccountCommonPartnerReportId", "ResPartnerId").HasName("account_common_partner_report_res_partner_rel_pkey");
                        j.ToTable("account_common_partner_report_res_partner_rel");
                        j.HasIndex(new[] { "ResPartnerId", "AccountCommonPartnerReportId" }, "account_common_partner_report_res_partner_id_account_common_idx");
                    });
        });

        modelBuilder.Entity<AccountCommonReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_common_report_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountCommonReports)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_common_report_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountCommonReportCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_common_report_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountCommonReportWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_common_report_write_uid_fkey");

            entity.HasMany(d => d.AccountJournals).WithMany(p => p.AccountCommonReports)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountCommonReportAccountJournalRel",
                    r => r.HasOne<AccountJournal>().WithMany()
                        .HasForeignKey("AccountJournalId")
                        .HasConstraintName("account_common_report_account_journal_r_account_journal_id_fkey"),
                    l => l.HasOne<AccountCommonReport>().WithMany()
                        .HasForeignKey("AccountCommonReportId")
                        .HasConstraintName("account_common_report_account_jou_account_common_report_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountCommonReportId", "AccountJournalId").HasName("account_common_report_account_journal_rel_pkey");
                        j.ToTable("account_common_report_account_journal_rel");
                        j.HasIndex(new[] { "AccountJournalId", "AccountCommonReportId" }, "account_common_report_account_account_journal_id_account_co_idx");
                    });
        });

        modelBuilder.Entity<AccountDaybookReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_daybook_report_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountDaybookReportCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_daybook_report_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountDaybookReportWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_daybook_report_write_uid_fkey");

            entity.HasMany(d => d.AccountJournals).WithMany(p => p.AccountDaybookReports)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountDaybookReportAccountJournalRel",
                    r => r.HasOne<AccountJournal>().WithMany()
                        .HasForeignKey("AccountJournalId")
                        .HasConstraintName("account_daybook_report_account_journal__account_journal_id_fkey"),
                    l => l.HasOne<AccountDaybookReport>().WithMany()
                        .HasForeignKey("AccountDaybookReportId")
                        .HasConstraintName("account_daybook_report_account_j_account_daybook_report_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountDaybookReportId", "AccountJournalId").HasName("account_daybook_report_account_journal_rel_pkey");
                        j.ToTable("account_daybook_report_account_journal_rel");
                        j.HasIndex(new[] { "AccountJournalId", "AccountDaybookReportId" }, "account_daybook_report_accoun_account_journal_id_account_da_idx");
                    });

            entity.HasMany(d => d.Accounts).WithMany(p => p.ReportLines1)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountAccountDaybookReport",
                    r => r.HasOne<AccountAccount>().WithMany()
                        .HasForeignKey("AccountId")
                        .HasConstraintName("account_account_daybook_report_account_id_fkey"),
                    l => l.HasOne<AccountDaybookReport>().WithMany()
                        .HasForeignKey("ReportLineId")
                        .HasConstraintName("account_account_daybook_report_report_line_id_fkey"),
                    j =>
                    {
                        j.HasKey("ReportLineId", "AccountId").HasName("account_account_daybook_report_pkey");
                        j.ToTable("account_account_daybook_report");
                        j.HasIndex(new[] { "AccountId", "ReportLineId" }, "account_account_daybook_report_account_id_report_line_id_idx");
                    });
        });

        modelBuilder.Entity<AccountEdiDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_edi_document_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Attachment).WithMany(p => p.AccountEdiDocuments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_edi_document_attachment_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountEdiDocumentCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_edi_document_create_uid_fkey");

            entity.HasOne(d => d.EdiFormat).WithMany(p => p.AccountEdiDocuments)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_edi_document_edi_format_id_fkey");

            entity.HasOne(d => d.Move).WithMany(p => p.AccountEdiDocuments)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_edi_document_move_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountEdiDocumentWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_edi_document_write_uid_fkey");
        });

        modelBuilder.Entity<AccountEdiFormat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_edi_format_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountEdiFormatCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_edi_format_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountEdiFormatWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_edi_format_write_uid_fkey");
        });

        modelBuilder.Entity<AccountFinancialReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_financial_report_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.AccountReport).WithMany(p => p.InverseAccountReport)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_financial_report_account_report_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountFinancialReportCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_financial_report_create_uid_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_financial_report_parent_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountFinancialReportWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_financial_report_write_uid_fkey");

            entity.HasMany(d => d.AccountTypes).WithMany(p => p.Reports)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountAccountFinancialReportType",
                    r => r.HasOne<AccountAccountType>().WithMany()
                        .HasForeignKey("AccountTypeId")
                        .HasConstraintName("account_account_financial_report_type_account_type_id_fkey"),
                    l => l.HasOne<AccountFinancialReport>().WithMany()
                        .HasForeignKey("ReportId")
                        .HasConstraintName("account_account_financial_report_type_report_id_fkey"),
                    j =>
                    {
                        j.HasKey("ReportId", "AccountTypeId").HasName("account_account_financial_report_type_pkey");
                        j.ToTable("account_account_financial_report_type");
                        j.HasIndex(new[] { "AccountTypeId", "ReportId" }, "account_account_financial_report__account_type_id_report_id_idx");
                    });

            entity.HasMany(d => d.Accounts).WithMany(p => p.ReportLines2)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountAccountFinancialReport",
                    r => r.HasOne<AccountAccount>().WithMany()
                        .HasForeignKey("AccountId")
                        .HasConstraintName("account_account_financial_report_account_id_fkey"),
                    l => l.HasOne<AccountFinancialReport>().WithMany()
                        .HasForeignKey("ReportLineId")
                        .HasConstraintName("account_account_financial_report_report_line_id_fkey"),
                    j =>
                    {
                        j.HasKey("ReportLineId", "AccountId").HasName("account_account_financial_report_pkey");
                        j.ToTable("account_account_financial_report");
                        j.HasIndex(new[] { "AccountId", "ReportLineId" }, "account_account_financial_report_account_id_report_line_id_idx");
                    });
        });

        modelBuilder.Entity<AccountFinancialYearOp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_financial_year_op_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountFinancialYearOps)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_financial_year_op_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountFinancialYearOpCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_financial_year_op_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountFinancialYearOpWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_financial_year_op_write_uid_fkey");
        });

        modelBuilder.Entity<AccountFiscalPosition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_fiscal_position_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Company).WithMany(p => p.AccountFiscalPositions)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_fiscal_position_company_id_fkey");

            entity.HasOne(d => d.CountryGroup).WithMany(p => p.AccountFiscalPositions)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_fiscal_position_country_group_id_fkey");

            entity.HasOne(d => d.Country).WithMany(p => p.AccountFiscalPositions)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_fiscal_position_country_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountFiscalPositionCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_fiscal_position_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountFiscalPositionWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_fiscal_position_write_uid_fkey");

            entity.HasMany(d => d.ResCountryStates).WithMany(p => p.AccountFiscalPositions)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountFiscalPositionResCountryStateRel",
                    r => r.HasOne<ResCountryState>().WithMany()
                        .HasForeignKey("ResCountryStateId")
                        .HasConstraintName("account_fiscal_position_res_country_s_res_country_state_id_fkey"),
                    l => l.HasOne<AccountFiscalPosition>().WithMany()
                        .HasForeignKey("AccountFiscalPositionId")
                        .HasConstraintName("account_fiscal_position_res_cou_account_fiscal_position_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountFiscalPositionId", "ResCountryStateId").HasName("account_fiscal_position_res_country_state_rel_pkey");
                        j.ToTable("account_fiscal_position_res_country_state_rel");
                        j.HasIndex(new[] { "ResCountryStateId", "AccountFiscalPositionId" }, "account_fiscal_position_res_c_res_country_state_id_account__idx");
                    });
        });

        modelBuilder.Entity<AccountFiscalPositionAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_fiscal_position_account_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.AccountDest).WithMany(p => p.AccountFiscalPositionAccountAccountDests)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_fiscal_position_account_account_dest_id_fkey");

            entity.HasOne(d => d.AccountSrc).WithMany(p => p.AccountFiscalPositionAccountAccountSrcs)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_fiscal_position_account_account_src_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountFiscalPositionAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_fiscal_position_account_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountFiscalPositionAccountCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_fiscal_position_account_create_uid_fkey");

            entity.HasOne(d => d.Position).WithMany(p => p.AccountFiscalPositionAccounts)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_fiscal_position_account_position_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountFiscalPositionAccountWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_fiscal_position_account_write_uid_fkey");
        });

        modelBuilder.Entity<AccountFiscalPositionAccountTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_fiscal_position_account_template_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.AccountDest).WithMany(p => p.AccountFiscalPositionAccountTemplateAccountDests)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_fiscal_position_account_template_account_dest_id_fkey");

            entity.HasOne(d => d.AccountSrc).WithMany(p => p.AccountFiscalPositionAccountTemplateAccountSrcs)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_fiscal_position_account_template_account_src_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountFiscalPositionAccountTemplateCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_fiscal_position_account_template_create_uid_fkey");

            entity.HasOne(d => d.Position).WithMany(p => p.AccountFiscalPositionAccountTemplates)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_fiscal_position_account_template_position_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountFiscalPositionAccountTemplateWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_fiscal_position_account_template_write_uid_fkey");
        });

        modelBuilder.Entity<AccountFiscalPositionTax>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_fiscal_position_tax_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountFiscalPositionTaxes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_fiscal_position_tax_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountFiscalPositionTaxCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_fiscal_position_tax_create_uid_fkey");

            entity.HasOne(d => d.Position).WithMany(p => p.AccountFiscalPositionTaxes)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_fiscal_position_tax_position_id_fkey");

            entity.HasOne(d => d.TaxDest).WithMany(p => p.AccountFiscalPositionTaxTaxDests)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_fiscal_position_tax_tax_dest_id_fkey");

            entity.HasOne(d => d.TaxSrc).WithMany(p => p.AccountFiscalPositionTaxTaxSrcs)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_fiscal_position_tax_tax_src_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountFiscalPositionTaxWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_fiscal_position_tax_write_uid_fkey");
        });

        modelBuilder.Entity<AccountFiscalPositionTaxTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_fiscal_position_tax_template_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountFiscalPositionTaxTemplateCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_fiscal_position_tax_template_create_uid_fkey");

            entity.HasOne(d => d.Position).WithMany(p => p.AccountFiscalPositionTaxTemplates)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_fiscal_position_tax_template_position_id_fkey");

            entity.HasOne(d => d.TaxDest).WithMany(p => p.AccountFiscalPositionTaxTemplateTaxDests)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_fiscal_position_tax_template_tax_dest_id_fkey");

            entity.HasOne(d => d.TaxSrc).WithMany(p => p.AccountFiscalPositionTaxTemplateTaxSrcs)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_fiscal_position_tax_template_tax_src_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountFiscalPositionTaxTemplateWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_fiscal_position_tax_template_write_uid_fkey");
        });

        modelBuilder.Entity<AccountFiscalPositionTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_fiscal_position_template_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.ChartTemplate).WithMany(p => p.AccountFiscalPositionTemplates)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_fiscal_position_template_chart_template_id_fkey");

            entity.HasOne(d => d.CountryGroup).WithMany(p => p.AccountFiscalPositionTemplates)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_fiscal_position_template_country_group_id_fkey");

            entity.HasOne(d => d.Country).WithMany(p => p.AccountFiscalPositionTemplates)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_fiscal_position_template_country_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountFiscalPositionTemplateCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_fiscal_position_template_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountFiscalPositionTemplateWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_fiscal_position_template_write_uid_fkey");

            entity.HasMany(d => d.ResCountryStates).WithMany(p => p.AccountFiscalPositionTemplates)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountFiscalPositionTemplateResCountryStateRel",
                    r => r.HasOne<ResCountryState>().WithMany()
                        .HasForeignKey("ResCountryStateId")
                        .HasConstraintName("account_fiscal_position_template_res__res_country_state_id_fkey"),
                    l => l.HasOne<AccountFiscalPositionTemplate>().WithMany()
                        .HasForeignKey("AccountFiscalPositionTemplateId")
                        .HasConstraintName("account_fiscal_position_templ_account_fiscal_position_temp_fkey"),
                    j =>
                    {
                        j.HasKey("AccountFiscalPositionTemplateId", "ResCountryStateId").HasName("account_fiscal_position_template_res_country_state_rel_pkey");
                        j.ToTable("account_fiscal_position_template_res_country_state_rel");
                        j.HasIndex(new[] { "ResCountryStateId", "AccountFiscalPositionTemplateId" }, "account_fiscal_position_templ_res_country_state_id_account__idx");
                    });
        });

        modelBuilder.Entity<AccountFiscalYear>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_fiscal_year_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountFiscalYears)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_fiscal_year_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountFiscalYearCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_fiscal_year_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountFiscalYearWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_fiscal_year_write_uid_fkey");
        });

        modelBuilder.Entity<AccountFullReconcile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_full_reconcile_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountFullReconcileCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_full_reconcile_create_uid_fkey");

            entity.HasOne(d => d.ExchangeMove).WithMany(p => p.AccountFullReconciles)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_full_reconcile_exchange_move_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountFullReconcileWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_full_reconcile_write_uid_fkey");
        });

        modelBuilder.Entity<AccountGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_group_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountGroups)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_group_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountGroupCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_group_create_uid_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_group_parent_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountGroupWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_group_write_uid_fkey");
        });

        modelBuilder.Entity<AccountGroupTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_group_template_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.ChartTemplate).WithMany(p => p.AccountGroupTemplates)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_group_template_chart_template_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountGroupTemplateCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_group_template_create_uid_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_group_template_parent_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountGroupTemplateWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_group_template_write_uid_fkey");
        });

        modelBuilder.Entity<AccountIncoterm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_incoterms_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountIncotermCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_incoterms_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountIncotermWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_incoterms_write_uid_fkey");
        });

        modelBuilder.Entity<AccountInvoiceSend>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_invoice_send_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Composer).WithMany(p => p.AccountInvoiceSends)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_invoice_send_composer_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountInvoiceSendCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_invoice_send_create_uid_fkey");

            entity.HasOne(d => d.Template).WithMany(p => p.AccountInvoiceSends)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_invoice_send_template_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountInvoiceSendWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_invoice_send_write_uid_fkey");

            entity.HasMany(d => d.AccountMoves).WithMany(p => p.AccountInvoiceSends)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountMoveAccountInvoiceSendRel",
                    r => r.HasOne<AccountMove>().WithMany()
                        .HasForeignKey("AccountMoveId")
                        .HasConstraintName("account_move_account_invoice_send_rel_account_move_id_fkey"),
                    l => l.HasOne<AccountInvoiceSend>().WithMany()
                        .HasForeignKey("AccountInvoiceSendId")
                        .HasConstraintName("account_move_account_invoice_send__account_invoice_send_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountInvoiceSendId", "AccountMoveId").HasName("account_move_account_invoice_send_rel_pkey");
                        j.ToTable("account_move_account_invoice_send_rel");
                        j.HasIndex(new[] { "AccountMoveId", "AccountInvoiceSendId" }, "account_move_account_invoice__account_move_id_account_invoi_idx");
                    });
        });

        modelBuilder.Entity<AccountJournal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_journal_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Alias).WithMany(p => p.AccountJournals)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_journal_alias_id_fkey");

            entity.HasOne(d => d.BankAccount).WithMany(p => p.AccountJournals)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_journal_bank_account_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountJournals)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_journal_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountJournalCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_journal_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.AccountJournals)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_journal_currency_id_fkey");

            entity.HasOne(d => d.DefaultAccount).WithMany(p => p.AccountJournalDefaultAccounts)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_journal_default_account_id_fkey");

            entity.HasOne(d => d.LossAccount).WithMany(p => p.AccountJournalLossAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_journal_loss_account_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.AccountJournals)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_journal_message_main_attachment_id_fkey");

            entity.HasOne(d => d.ProfitAccount).WithMany(p => p.AccountJournalProfitAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_journal_profit_account_id_fkey");

            entity.HasOne(d => d.SaleActivityType).WithMany(p => p.AccountJournals)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_journal_sale_activity_type_id_fkey");

            entity.HasOne(d => d.SaleActivityUser).WithMany(p => p.AccountJournalSaleActivityUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_journal_sale_activity_user_id_fkey");

            entity.HasOne(d => d.SecureSequence).WithMany(p => p.AccountJournals)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_journal_secure_sequence_id_fkey");

            entity.HasOne(d => d.SuspenseAccount).WithMany(p => p.AccountJournalSuspenseAccounts)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_journal_suspense_account_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountJournalWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_journal_write_uid_fkey");

            entity.HasMany(d => d.AccountEdiFormats).WithMany(p => p.AccountJournals)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountEdiFormatAccountJournalRel",
                    r => r.HasOne<AccountEdiFormat>().WithMany()
                        .HasForeignKey("AccountEdiFormatId")
                        .HasConstraintName("account_edi_format_account_journal_r_account_edi_format_id_fkey"),
                    l => l.HasOne<AccountJournal>().WithMany()
                        .HasForeignKey("AccountJournalId")
                        .HasConstraintName("account_edi_format_account_journal_rel_account_journal_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountJournalId", "AccountEdiFormatId").HasName("account_edi_format_account_journal_rel_pkey");
                        j.ToTable("account_edi_format_account_journal_rel");
                        j.HasIndex(new[] { "AccountEdiFormatId", "AccountJournalId" }, "account_edi_format_account_jo_account_edi_format_id_account_idx");
                    });

            entity.HasMany(d => d.Accounts1).WithMany(p => p.Journals)
                .UsingEntity<Dictionary<string, object>>(
                    "JournalAccountControlRel",
                    r => r.HasOne<AccountAccount>().WithMany()
                        .HasForeignKey("AccountId")
                        .HasConstraintName("journal_account_control_rel_account_id_fkey"),
                    l => l.HasOne<AccountJournal>().WithMany()
                        .HasForeignKey("JournalId")
                        .HasConstraintName("journal_account_control_rel_journal_id_fkey"),
                    j =>
                    {
                        j.HasKey("JournalId", "AccountId").HasName("journal_account_control_rel_pkey");
                        j.ToTable("journal_account_control_rel");
                        j.HasIndex(new[] { "AccountId", "JournalId" }, "journal_account_control_rel_account_id_journal_id_idx");
                    });
        });

        modelBuilder.Entity<AccountJournalGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_journal_group_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Company).WithMany(p => p.AccountJournalGroups)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_journal_group_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountJournalGroupCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_journal_group_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountJournalGroupWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_journal_group_write_uid_fkey");

            entity.HasMany(d => d.AccountJournals).WithMany(p => p.AccountJournalGroups)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountJournalAccountJournalGroupRel",
                    r => r.HasOne<AccountJournal>().WithMany()
                        .HasForeignKey("AccountJournalId")
                        .HasConstraintName("account_journal_account_journal_group_r_account_journal_id_fkey"),
                    l => l.HasOne<AccountJournalGroup>().WithMany()
                        .HasForeignKey("AccountJournalGroupId")
                        .HasConstraintName("account_journal_account_journal_g_account_journal_group_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountJournalGroupId", "AccountJournalId").HasName("account_journal_account_journal_group_rel_pkey");
                        j.ToTable("account_journal_account_journal_group_rel");
                        j.HasIndex(new[] { "AccountJournalId", "AccountJournalGroupId" }, "account_journal_account_journ_account_journal_id_account_jo_idx");
                    });
        });

        modelBuilder.Entity<AccountMove>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_move_pkey");

            entity.HasIndex(e => e.Name, "account_move_name_trigram_index")
                .HasMethod("gin")
                .HasOperators(new[] { "gin_trgm_ops" });

            entity.HasIndex(e => e.PaymentId, "account_move_payment_id_index").HasFilter("(payment_id IS NOT NULL)");

            entity.HasIndex(e => e.PaymentReference, "account_move_payment_reference_index")
                .HasMethod("gin")
                .HasOperators(new[] { "gin_trgm_ops" });

            entity.HasIndex(e => e.ReversedEntryId, "account_move_reversed_entry_id_index").HasFilter("(reversed_entry_id IS NOT NULL)");

            entity.HasIndex(e => e.StockMoveId, "account_move_stock_move_id_index").HasFilter("(stock_move_id IS NOT NULL)");

            entity.HasIndex(e => e.TaxCashBasisOriginMoveId, "account_move_tax_cash_basis_origin_move_id_index").HasFilter("(tax_cash_basis_origin_move_id IS NOT NULL)");

            entity.HasIndex(e => e.JournalId, "account_move_to_check_idx").HasFilter("(to_check = true)");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.SequenceNumber).ValueGeneratedOnAdd();

            entity.HasOne(d => d.AutoPostOrigin).WithMany(p => p.InverseAutoPostOrigin)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_auto_post_origin_id_fkey");

            entity.HasOne(d => d.Campaign).WithMany(p => p.AccountMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_campaign_id_fkey");

            entity.HasOne(d => d.CommercialPartner).WithMany(p => p.AccountMoveCommercialPartners)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_move_commercial_partner_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountMoveCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.AccountMoves)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_move_currency_id_fkey");

            entity.HasOne(d => d.FiscalPosition).WithMany(p => p.AccountMoves)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_move_fiscal_position_id_fkey");

            entity.HasOne(d => d.InvoiceCashRounding).WithMany(p => p.AccountMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_invoice_cash_rounding_id_fkey");

            entity.HasOne(d => d.InvoiceIncoterm).WithMany(p => p.AccountMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_invoice_incoterm_id_fkey");

            entity.HasOne(d => d.InvoicePaymentTerm).WithMany(p => p.AccountMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_invoice_payment_term_id_fkey");

            entity.HasOne(d => d.InvoiceUser).WithMany(p => p.AccountMoveInvoiceUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_invoice_user_id_fkey");

            entity.HasOne(d => d.Journal).WithMany(p => p.AccountMoves)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_move_journal_id_fkey");

            entity.HasOne(d => d.Medium).WithMany(p => p.AccountMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_medium_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.AccountMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_message_main_attachment_id_fkey");

            entity.HasOne(d => d.PartnerBank).WithMany(p => p.AccountMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_partner_bank_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.AccountMovePartners)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_move_partner_id_fkey");

            entity.HasOne(d => d.PartnerShipping).WithMany(p => p.AccountMovePartnerShippings)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_partner_shipping_id_fkey");

            entity.HasOne(d => d.Payment).WithMany(p => p.AccountMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_payment_id_fkey");

            entity.HasOne(d => d.ReversedEntry).WithMany(p => p.InverseReversedEntry)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_reversed_entry_id_fkey");

            entity.HasOne(d => d.Source).WithMany(p => p.AccountMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_source_id_fkey");

            entity.HasOne(d => d.StatementLine).WithMany(p => p.AccountMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_statement_line_id_fkey");

            entity.HasOne(d => d.StockMove).WithMany(p => p.AccountMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_stock_move_id_fkey");

            entity.HasOne(d => d.TaxCashBasisOriginMove).WithMany(p => p.InverseTaxCashBasisOriginMove)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_tax_cash_basis_origin_move_id_fkey");

            entity.HasOne(d => d.TaxCashBasisRec).WithMany(p => p.AccountMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_tax_cash_basis_rec_id_fkey");

            entity.HasOne(d => d.Team).WithMany(p => p.AccountMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_team_id_fkey");

            entity.HasOne(d => d.Website).WithMany(p => p.AccountMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_website_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountMoveWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_write_uid_fkey");

            entity.HasMany(d => d.Transactions).WithMany(p => p.Invoices)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountInvoiceTransactionRel",
                    r => r.HasOne<PaymentTransaction>().WithMany()
                        .HasForeignKey("TransactionId")
                        .HasConstraintName("account_invoice_transaction_rel_transaction_id_fkey"),
                    l => l.HasOne<AccountMove>().WithMany()
                        .HasForeignKey("InvoiceId")
                        .HasConstraintName("account_invoice_transaction_rel_invoice_id_fkey"),
                    j =>
                    {
                        j.HasKey("InvoiceId", "TransactionId").HasName("account_invoice_transaction_rel_pkey");
                        j.ToTable("account_invoice_transaction_rel");
                        j.HasIndex(new[] { "TransactionId", "InvoiceId" }, "account_invoice_transaction_rel_transaction_id_invoice_id_idx");
                    });
        });

        modelBuilder.Entity<AccountMoveLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_move_line_pkey");

            entity.HasIndex(e => e.FullReconcileId, "account_move_line_full_reconcile_id_index").HasFilter("(full_reconcile_id IS NOT NULL)");

            entity.HasIndex(e => e.GroupTaxId, "account_move_line_group_tax_id_index").HasFilter("(group_tax_id IS NOT NULL)");

            entity.HasIndex(e => e.PaymentId, "account_move_line_payment_id_index").HasFilter("(payment_id IS NOT NULL)");

            entity.HasIndex(e => e.PurchaseLineId, "account_move_line_purchase_line_id_index").HasFilter("(purchase_line_id IS NOT NULL)");

            entity.HasIndex(e => e.Ref, "account_move_line_ref_index")
                .HasMethod("gin")
                .HasOperators(new[] { "gin_trgm_ops" });

            entity.HasIndex(e => e.StatementId, "account_move_line_statement_id_index").HasFilter("(statement_id IS NOT NULL)");

            entity.HasIndex(e => e.StatementLineId, "account_move_line_statement_line_id_index").HasFilter("(statement_line_id IS NOT NULL)");

            entity.HasIndex(e => e.VehicleId, "account_move_line_vehicle_id_index").HasFilter("(vehicle_id IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Account).WithMany(p => p.AccountMoveLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_move_line_account_id_fkey");

            entity.HasOne(d => d.AssetCategory).WithMany(p => p.AccountMoveLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_line_asset_category_id_fkey");

            entity.HasOne(d => d.CompanyCurrency).WithMany(p => p.AccountMoveLineCompanyCurrencies)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_line_company_currency_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountMoveLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_line_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountMoveLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_line_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.AccountMoveLineCurrencies)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_move_line_currency_id_fkey");

            entity.HasOne(d => d.Expense).WithMany(p => p.AccountMoveLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_line_expense_id_fkey");

            entity.HasOne(d => d.FollowupLine).WithMany(p => p.AccountMoveLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_line_followup_line_id_fkey");

            entity.HasOne(d => d.FullReconcile).WithMany(p => p.AccountMoveLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_line_full_reconcile_id_fkey");

            entity.HasOne(d => d.GroupTax).WithMany(p => p.AccountMoveLineGroupTaxes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_line_group_tax_id_fkey");

            entity.HasOne(d => d.Journal).WithMany(p => p.AccountMoveLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_line_journal_id_fkey");

            entity.HasOne(d => d.Move).WithMany(p => p.AccountMoveLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_move_line_move_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.AccountMoveLines)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_move_line_partner_id_fkey");

            entity.HasOne(d => d.Payment).WithMany(p => p.AccountMoveLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_line_payment_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.AccountMoveLines)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_move_line_product_id_fkey");

            entity.HasOne(d => d.ProductUom).WithMany(p => p.AccountMoveLines)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_move_line_product_uom_id_fkey");

            entity.HasOne(d => d.PurchaseLine).WithMany(p => p.AccountMoveLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_line_purchase_line_id_fkey");

            entity.HasOne(d => d.ReconcileModel).WithMany(p => p.AccountMoveLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_line_reconcile_model_id_fkey");

            entity.HasOne(d => d.Statement).WithMany(p => p.AccountMoveLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_line_statement_id_fkey");

            entity.HasOne(d => d.StatementLine).WithMany(p => p.AccountMoveLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_line_statement_line_id_fkey");

            entity.HasOne(d => d.TaxGroup).WithMany(p => p.AccountMoveLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_line_tax_group_id_fkey");

            entity.HasOne(d => d.TaxLine).WithMany(p => p.AccountMoveLineTaxLines)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_move_line_tax_line_id_fkey");

            entity.HasOne(d => d.TaxRepartitionLine).WithMany(p => p.AccountMoveLines)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_move_line_tax_repartition_line_id_fkey");

            entity.HasOne(d => d.Vehicle).WithMany(p => p.AccountMoveLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_line_vehicle_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountMoveLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_line_write_uid_fkey");

            entity.HasMany(d => d.AccountAccountTags).WithMany(p => p.AccountMoveLines)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountAccountTagAccountMoveLineRel",
                    r => r.HasOne<AccountAccountTag>().WithMany()
                        .HasForeignKey("AccountAccountTagId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("account_account_tag_account_move_li_account_account_tag_id_fkey"),
                    l => l.HasOne<AccountMoveLine>().WithMany()
                        .HasForeignKey("AccountMoveLineId")
                        .HasConstraintName("account_account_tag_account_move_line_account_move_line_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountMoveLineId", "AccountAccountTagId").HasName("account_account_tag_account_move_line_rel_pkey");
                        j.ToTable("account_account_tag_account_move_line_rel");
                        j.HasIndex(new[] { "AccountAccountTagId", "AccountMoveLineId" }, "account_account_tag_account_m_account_account_tag_id_accoun_idx");
                    });

            entity.HasMany(d => d.AccountTaxes).WithMany(p => p.AccountMoveLines)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountMoveLineAccountTaxRel",
                    r => r.HasOne<AccountTax>().WithMany()
                        .HasForeignKey("AccountTaxId")
                        .HasConstraintName("account_move_line_account_tax_rel_account_tax_id_fkey"),
                    l => l.HasOne<AccountMoveLine>().WithMany()
                        .HasForeignKey("AccountMoveLineId")
                        .HasConstraintName("account_move_line_account_tax_rel_account_move_line_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountMoveLineId", "AccountTaxId").HasName("account_move_line_account_tax_rel_pkey");
                        j.ToTable("account_move_line_account_tax_rel");
                        j.HasIndex(new[] { "AccountTaxId", "AccountMoveLineId" }, "account_move_line_account_tax_account_tax_id_account_move_l_idx");
                    });

            entity.HasMany(d => d.OrderLines).WithMany(p => p.InvoiceLines)
                .UsingEntity<Dictionary<string, object>>(
                    "SaleOrderLineInvoiceRel",
                    r => r.HasOne<SaleOrderLine>().WithMany()
                        .HasForeignKey("OrderLineId")
                        .HasConstraintName("sale_order_line_invoice_rel_order_line_id_fkey"),
                    l => l.HasOne<AccountMoveLine>().WithMany()
                        .HasForeignKey("InvoiceLineId")
                        .HasConstraintName("sale_order_line_invoice_rel_invoice_line_id_fkey"),
                    j =>
                    {
                        j.HasKey("InvoiceLineId", "OrderLineId").HasName("sale_order_line_invoice_rel_pkey");
                        j.ToTable("sale_order_line_invoice_rel");
                        j.HasIndex(new[] { "OrderLineId", "InvoiceLineId" }, "sale_order_line_invoice_rel_order_line_id_invoice_line_id_idx");
                    });
        });

        modelBuilder.Entity<AccountMoveReversal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_move_reversal_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountMoveReversals)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_move_reversal_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountMoveReversalCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_reversal_create_uid_fkey");

            entity.HasOne(d => d.Journal).WithMany(p => p.AccountMoveReversals)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_move_reversal_journal_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountMoveReversalWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_move_reversal_write_uid_fkey");

            entity.HasMany(d => d.Moves).WithMany(p => p.Reversals)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountMoveReversalMove",
                    r => r.HasOne<AccountMove>().WithMany()
                        .HasForeignKey("MoveId")
                        .HasConstraintName("account_move_reversal_move_move_id_fkey"),
                    l => l.HasOne<AccountMoveReversal>().WithMany()
                        .HasForeignKey("ReversalId")
                        .HasConstraintName("account_move_reversal_move_reversal_id_fkey"),
                    j =>
                    {
                        j.HasKey("ReversalId", "MoveId").HasName("account_move_reversal_move_pkey");
                        j.ToTable("account_move_reversal_move");
                        j.HasIndex(new[] { "MoveId", "ReversalId" }, "account_move_reversal_move_move_id_reversal_id_idx");
                    });

            entity.HasMany(d => d.NewMoves).WithMany(p => p.ReversalsNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountMoveReversalNewMove",
                    r => r.HasOne<AccountMove>().WithMany()
                        .HasForeignKey("NewMoveId")
                        .HasConstraintName("account_move_reversal_new_move_new_move_id_fkey"),
                    l => l.HasOne<AccountMoveReversal>().WithMany()
                        .HasForeignKey("ReversalId")
                        .HasConstraintName("account_move_reversal_new_move_reversal_id_fkey"),
                    j =>
                    {
                        j.HasKey("ReversalId", "NewMoveId").HasName("account_move_reversal_new_move_pkey");
                        j.ToTable("account_move_reversal_new_move");
                        j.HasIndex(new[] { "NewMoveId", "ReversalId" }, "account_move_reversal_new_move_new_move_id_reversal_id_idx");
                    });
        });

        modelBuilder.Entity<AccountPartialReconcile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_partial_reconcile_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountPartialReconciles)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_partial_reconcile_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountPartialReconcileCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_partial_reconcile_create_uid_fkey");

            entity.HasOne(d => d.CreditCurrency).WithMany(p => p.AccountPartialReconcileCreditCurrencies)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_partial_reconcile_credit_currency_id_fkey");

            entity.HasOne(d => d.CreditMove).WithMany(p => p.AccountPartialReconcileCreditMoves)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_partial_reconcile_credit_move_id_fkey");

            entity.HasOne(d => d.DebitCurrency).WithMany(p => p.AccountPartialReconcileDebitCurrencies)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_partial_reconcile_debit_currency_id_fkey");

            entity.HasOne(d => d.DebitMove).WithMany(p => p.AccountPartialReconcileDebitMoves)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_partial_reconcile_debit_move_id_fkey");

            entity.HasOne(d => d.ExchangeMove).WithMany(p => p.AccountPartialReconciles)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_partial_reconcile_exchange_move_id_fkey");

            entity.HasOne(d => d.FullReconcile).WithMany(p => p.AccountPartialReconciles)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_partial_reconcile_full_reconcile_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountPartialReconcileWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_partial_reconcile_write_uid_fkey");
        });

        modelBuilder.Entity<AccountPayment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_payment_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountPaymentCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.AccountPayments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_currency_id_fkey");

            entity.HasOne(d => d.DestinationAccount).WithMany(p => p.AccountPaymentDestinationAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_destination_account_id_fkey");

            entity.HasOne(d => d.DestinationJournal).WithMany(p => p.AccountPayments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_destination_journal_id_fkey");

            entity.HasOne(d => d.ForceOutstandingAccount).WithMany(p => p.AccountPaymentForceOutstandingAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_force_outstanding_account_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.AccountPayments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Move).WithMany(p => p.AccountPayments)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_payment_move_id_fkey");

            entity.HasOne(d => d.OutstandingAccount).WithMany(p => p.AccountPaymentOutstandingAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_outstanding_account_id_fkey");

            entity.HasOne(d => d.PairedInternalTransferPayment).WithMany(p => p.InversePairedInternalTransferPayment)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_paired_internal_transfer_payment_id_fkey");

            entity.HasOne(d => d.PartnerBank).WithMany(p => p.AccountPayments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_partner_bank_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.AccountPayments)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_payment_partner_id_fkey");

            entity.HasOne(d => d.PaymentMethod).WithMany(p => p.AccountPayments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_payment_method_id_fkey");

            entity.HasOne(d => d.PaymentMethodLine).WithMany(p => p.AccountPayments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_payment_method_line_id_fkey");

            entity.HasOne(d => d.PaymentToken).WithMany(p => p.AccountPayments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_payment_token_id_fkey");

            entity.HasOne(d => d.PaymentTransaction).WithMany(p => p.AccountPayments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_payment_transaction_id_fkey");

            entity.HasOne(d => d.PosPaymentMethod).WithMany(p => p.AccountPayments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_pos_payment_method_id_fkey");

            entity.HasOne(d => d.PosSession).WithMany(p => p.AccountPayments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_pos_session_id_fkey");

            entity.HasOne(d => d.SourcePayment).WithMany(p => p.InverseSourcePayment)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_source_payment_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountPaymentWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_write_uid_fkey");
        });

        modelBuilder.Entity<AccountPaymentMethod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_payment_method_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountPaymentMethodCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_method_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountPaymentMethodWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_method_write_uid_fkey");
        });

        modelBuilder.Entity<AccountPaymentMethodLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_payment_method_line_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountPaymentMethodLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_method_line_create_uid_fkey");

            entity.HasOne(d => d.Journal).WithMany(p => p.AccountPaymentMethodLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_payment_method_line_journal_id_fkey");

            entity.HasOne(d => d.PaymentAccount).WithMany(p => p.AccountPaymentMethodLines)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_payment_method_line_payment_account_id_fkey");

            entity.HasOne(d => d.PaymentMethod).WithMany(p => p.AccountPaymentMethodLines)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_payment_method_line_payment_method_id_fkey");

            entity.HasOne(d => d.PaymentProvider).WithMany(p => p.AccountPaymentMethodLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_method_line_payment_provider_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountPaymentMethodLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_method_line_write_uid_fkey");
        });

        modelBuilder.Entity<AccountPaymentRegister>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_payment_register_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountPaymentRegisters)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_register_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountPaymentRegisterCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_register_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.AccountPaymentRegisterCurrencies)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_register_currency_id_fkey");

            entity.HasOne(d => d.Journal).WithMany(p => p.AccountPaymentRegisters)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_register_journal_id_fkey");

            entity.HasOne(d => d.PartnerBank).WithMany(p => p.AccountPaymentRegisters)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_register_partner_bank_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.AccountPaymentRegisters)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_payment_register_partner_id_fkey");

            entity.HasOne(d => d.PaymentMethodLine).WithMany(p => p.AccountPaymentRegisters)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_register_payment_method_line_id_fkey");

            entity.HasOne(d => d.PaymentToken).WithMany(p => p.AccountPaymentRegisters)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_register_payment_token_id_fkey");

            entity.HasOne(d => d.SourceCurrency).WithMany(p => p.AccountPaymentRegisterSourceCurrencies)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_register_source_currency_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountPaymentRegisterWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_register_write_uid_fkey");

            entity.HasOne(d => d.WriteoffAccount).WithMany(p => p.AccountPaymentRegisters)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_register_writeoff_account_id_fkey");

            entity.HasMany(d => d.Lines).WithMany(p => p.Wizards)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountPaymentRegisterMoveLineRel",
                    r => r.HasOne<AccountMoveLine>().WithMany()
                        .HasForeignKey("LineId")
                        .HasConstraintName("account_payment_register_move_line_rel_line_id_fkey"),
                    l => l.HasOne<AccountPaymentRegister>().WithMany()
                        .HasForeignKey("WizardId")
                        .HasConstraintName("account_payment_register_move_line_rel_wizard_id_fkey"),
                    j =>
                    {
                        j.HasKey("WizardId", "LineId").HasName("account_payment_register_move_line_rel_pkey");
                        j.ToTable("account_payment_register_move_line_rel");
                        j.HasIndex(new[] { "LineId", "WizardId" }, "account_payment_register_move_line_rel_line_id_wizard_id_idx");
                    });
        });

        modelBuilder.Entity<AccountPaymentTerm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_payment_term_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Company).WithMany(p => p.AccountPaymentTerms)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_term_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountPaymentTermCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_term_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountPaymentTermWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_term_write_uid_fkey");
        });

        modelBuilder.Entity<AccountPaymentTermLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_payment_term_line_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountPaymentTermLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_term_line_create_uid_fkey");

            entity.HasOne(d => d.Payment).WithMany(p => p.AccountPaymentTermLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_payment_term_line_payment_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountPaymentTermLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_payment_term_line_write_uid_fkey");
        });

        modelBuilder.Entity<AccountPrintJournal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_print_journal_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountPrintJournals)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_print_journal_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountPrintJournalCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_print_journal_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountPrintJournalWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_print_journal_write_uid_fkey");

            entity.HasMany(d => d.AccountJournals).WithMany(p => p.AccountPrintJournals)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountJournalAccountPrintJournalRel",
                    r => r.HasOne<AccountJournal>().WithMany()
                        .HasForeignKey("AccountJournalId")
                        .HasConstraintName("account_journal_account_print_journal_r_account_journal_id_fkey"),
                    l => l.HasOne<AccountPrintJournal>().WithMany()
                        .HasForeignKey("AccountPrintJournalId")
                        .HasConstraintName("account_journal_account_print_jou_account_print_journal_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountPrintJournalId", "AccountJournalId").HasName("account_journal_account_print_journal_rel_pkey");
                        j.ToTable("account_journal_account_print_journal_rel");
                        j.HasIndex(new[] { "AccountJournalId", "AccountPrintJournalId" }, "account_journal_account_print_account_journal_id_account_pr_idx");
                    });
        });

        modelBuilder.Entity<AccountReconcileModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_reconcile_model_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Company).WithMany(p => p.AccountReconcileModels)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_reconcile_model_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountReconcileModelCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_reconcile_model_create_uid_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.AccountReconcileModels)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_reconcile_model_message_main_attachment_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountReconcileModelWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_reconcile_model_write_uid_fkey");

            entity.HasMany(d => d.AccountJournals).WithMany(p => p.AccountReconcileModels)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountJournalAccountReconcileModelRel",
                    r => r.HasOne<AccountJournal>().WithMany()
                        .HasForeignKey("AccountJournalId")
                        .HasConstraintName("account_journal_account_reconcile_model_account_journal_id_fkey"),
                    l => l.HasOne<AccountReconcileModel>().WithMany()
                        .HasForeignKey("AccountReconcileModelId")
                        .HasConstraintName("account_journal_account_reconci_account_reconcile_model_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountReconcileModelId", "AccountJournalId").HasName("account_journal_account_reconcile_model_rel_pkey");
                        j.ToTable("account_journal_account_reconcile_model_rel");
                        j.HasIndex(new[] { "AccountJournalId", "AccountReconcileModelId" }, "account_journal_account_recon_account_journal_id_account_re_idx");
                    });

            entity.HasMany(d => d.ResPartnerCategories).WithMany(p => p.AccountReconcileModels)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountReconcileModelResPartnerCategoryRel",
                    r => r.HasOne<ResPartnerCategory>().WithMany()
                        .HasForeignKey("ResPartnerCategoryId")
                        .HasConstraintName("account_reconcile_model_res_partne_res_partner_category_id_fkey"),
                    l => l.HasOne<AccountReconcileModel>().WithMany()
                        .HasForeignKey("AccountReconcileModelId")
                        .HasConstraintName("account_reconcile_model_res_pa_account_reconcile_model_id_fkey1"),
                    j =>
                    {
                        j.HasKey("AccountReconcileModelId", "ResPartnerCategoryId").HasName("account_reconcile_model_res_partner_category_rel_pkey");
                        j.ToTable("account_reconcile_model_res_partner_category_rel");
                        j.HasIndex(new[] { "ResPartnerCategoryId", "AccountReconcileModelId" }, "account_reconcile_model_res_p_res_partner_category_id_accou_idx");
                    });

            entity.HasMany(d => d.ResPartners).WithMany(p => p.AccountReconcileModels)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountReconcileModelResPartnerRel",
                    r => r.HasOne<ResPartner>().WithMany()
                        .HasForeignKey("ResPartnerId")
                        .HasConstraintName("account_reconcile_model_res_partner_rel_res_partner_id_fkey"),
                    l => l.HasOne<AccountReconcileModel>().WithMany()
                        .HasForeignKey("AccountReconcileModelId")
                        .HasConstraintName("account_reconcile_model_res_par_account_reconcile_model_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountReconcileModelId", "ResPartnerId").HasName("account_reconcile_model_res_partner_rel_pkey");
                        j.ToTable("account_reconcile_model_res_partner_rel");
                        j.HasIndex(new[] { "ResPartnerId", "AccountReconcileModelId" }, "account_reconcile_model_res_p_res_partner_id_account_reconc_idx");
                    });
        });

        modelBuilder.Entity<AccountReconcileModelLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_reconcile_model_line_pkey");

            entity.HasIndex(e => e.AnalyticDistribution, "account_reconcile_model_line_analytic_distribution_gin_index").HasMethod("gin");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Account).WithMany(p => p.AccountReconcileModelLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_reconcile_model_line_account_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountReconcileModelLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_reconcile_model_line_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountReconcileModelLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_reconcile_model_line_create_uid_fkey");

            entity.HasOne(d => d.Journal).WithMany(p => p.AccountReconcileModelLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_reconcile_model_line_journal_id_fkey");

            entity.HasOne(d => d.Model).WithMany(p => p.AccountReconcileModelLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_reconcile_model_line_model_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountReconcileModelLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_reconcile_model_line_write_uid_fkey");

            entity.HasMany(d => d.AccountTaxes).WithMany(p => p.AccountReconcileModelLines)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountReconcileModelLineAccountTaxRel",
                    r => r.HasOne<AccountTax>().WithMany()
                        .HasForeignKey("AccountTaxId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("account_reconcile_model_line_account_tax_re_account_tax_id_fkey"),
                    l => l.HasOne<AccountReconcileModelLine>().WithMany()
                        .HasForeignKey("AccountReconcileModelLineId")
                        .HasConstraintName("account_reconcile_model_line__account_reconcile_model_line_fkey"),
                    j =>
                    {
                        j.HasKey("AccountReconcileModelLineId", "AccountTaxId").HasName("account_reconcile_model_line_account_tax_rel_pkey");
                        j.ToTable("account_reconcile_model_line_account_tax_rel");
                        j.HasIndex(new[] { "AccountTaxId", "AccountReconcileModelLineId" }, "account_reconcile_model_line__account_tax_id_account_reconc_idx");
                    });
        });

        modelBuilder.Entity<AccountReconcileModelLineTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_reconcile_model_line_template_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Account).WithMany(p => p.AccountReconcileModelLineTemplates)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_reconcile_model_line_template_account_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountReconcileModelLineTemplateCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_reconcile_model_line_template_create_uid_fkey");

            entity.HasOne(d => d.Model).WithMany(p => p.AccountReconcileModelLineTemplates)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_reconcile_model_line_template_model_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountReconcileModelLineTemplateWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_reconcile_model_line_template_write_uid_fkey");

            entity.HasMany(d => d.AccountTaxTemplates).WithMany(p => p.AccountReconcileModelLineTemplates)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountReconcileModelLineTemplateAccountTaxTemplateRel",
                    r => r.HasOne<AccountTaxTemplate>().WithMany()
                        .HasForeignKey("AccountTaxTemplateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("account_reconcile_model_line_templ_account_tax_template_id_fkey"),
                    l => l.HasOne<AccountReconcileModelLineTemplate>().WithMany()
                        .HasForeignKey("AccountReconcileModelLineTemplateId")
                        .HasConstraintName("account_reconcile_model_line_account_reconcile_model_line_fkey1"),
                    j =>
                    {
                        j.HasKey("AccountReconcileModelLineTemplateId", "AccountTaxTemplateId").HasName("account_reconcile_model_line_template_account_tax_template_pkey");
                        j.ToTable("account_reconcile_model_line_template_account_tax_template_rel");
                        j.HasIndex(new[] { "AccountTaxTemplateId", "AccountReconcileModelLineTemplateId" }, "account_reconcile_model_line__account_tax_template_id_accou_idx");
                    });
        });

        modelBuilder.Entity<AccountReconcileModelPartnerMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_reconcile_model_partner_mapping_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountReconcileModelPartnerMappingCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_reconcile_model_partner_mapping_create_uid_fkey");

            entity.HasOne(d => d.Model).WithMany(p => p.AccountReconcileModelPartnerMappings)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_reconcile_model_partner_mapping_model_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.AccountReconcileModelPartnerMappings)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_reconcile_model_partner_mapping_partner_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountReconcileModelPartnerMappingWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_reconcile_model_partner_mapping_write_uid_fkey");
        });

        modelBuilder.Entity<AccountReconcileModelTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_reconcile_model_template_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.ChartTemplate).WithMany(p => p.AccountReconcileModelTemplates)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_reconcile_model_template_chart_template_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountReconcileModelTemplateCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_reconcile_model_template_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountReconcileModelTemplateWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_reconcile_model_template_write_uid_fkey");

            entity.HasMany(d => d.AccountJournals).WithMany(p => p.AccountReconcileModelTemplates)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountJournalAccountReconcileModelTemplateRel",
                    r => r.HasOne<AccountJournal>().WithMany()
                        .HasForeignKey("AccountJournalId")
                        .HasConstraintName("account_journal_account_reconcile_mode_account_journal_id_fkey1"),
                    l => l.HasOne<AccountReconcileModelTemplate>().WithMany()
                        .HasForeignKey("AccountReconcileModelTemplateId")
                        .HasConstraintName("account_journal_account_recon_account_reconcile_model_temp_fkey"),
                    j =>
                    {
                        j.HasKey("AccountReconcileModelTemplateId", "AccountJournalId").HasName("account_journal_account_reconcile_model_template_rel_pkey");
                        j.ToTable("account_journal_account_reconcile_model_template_rel");
                        j.HasIndex(new[] { "AccountJournalId", "AccountReconcileModelTemplateId" }, "account_journal_account_recon_account_journal_id_account_r_idx1");
                    });

            entity.HasMany(d => d.ResPartnerCategories).WithMany(p => p.AccountReconcileModelTemplates)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountReconcileModelTemplateResPartnerCategoryRel",
                    r => r.HasOne<ResPartnerCategory>().WithMany()
                        .HasForeignKey("ResPartnerCategoryId")
                        .HasConstraintName("account_reconcile_model_template_r_res_partner_category_id_fkey"),
                    l => l.HasOne<AccountReconcileModelTemplate>().WithMany()
                        .HasForeignKey("AccountReconcileModelTemplateId")
                        .HasConstraintName("account_reconcile_model_temp_account_reconcile_model_temp_fkey1"),
                    j =>
                    {
                        j.HasKey("AccountReconcileModelTemplateId", "ResPartnerCategoryId").HasName("account_reconcile_model_template_res_partner_category_rel_pkey");
                        j.ToTable("account_reconcile_model_template_res_partner_category_rel");
                        j.HasIndex(new[] { "ResPartnerCategoryId", "AccountReconcileModelTemplateId" }, "account_reconcile_model_templ_res_partner_category_id_accou_idx");
                    });

            entity.HasMany(d => d.ResPartners).WithMany(p => p.AccountReconcileModelTemplates)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountReconcileModelTemplateResPartnerRel",
                    r => r.HasOne<ResPartner>().WithMany()
                        .HasForeignKey("ResPartnerId")
                        .HasConstraintName("account_reconcile_model_template_res_partne_res_partner_id_fkey"),
                    l => l.HasOne<AccountReconcileModelTemplate>().WithMany()
                        .HasForeignKey("AccountReconcileModelTemplateId")
                        .HasConstraintName("account_reconcile_model_templ_account_reconcile_model_temp_fkey"),
                    j =>
                    {
                        j.HasKey("AccountReconcileModelTemplateId", "ResPartnerId").HasName("account_reconcile_model_template_res_partner_rel_pkey");
                        j.ToTable("account_reconcile_model_template_res_partner_rel");
                        j.HasIndex(new[] { "ResPartnerId", "AccountReconcileModelTemplateId" }, "account_reconcile_model_templ_res_partner_id_account_reconc_idx");
                    });
        });

        modelBuilder.Entity<AccountRecurringTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_recurring_template_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountRecurringTemplates)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_recurring_template_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountRecurringTemplateCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_recurring_template_create_uid_fkey");

            entity.HasOne(d => d.Journal).WithMany(p => p.AccountRecurringTemplates)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_recurring_template_journal_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountRecurringTemplateWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_recurring_template_write_uid_fkey");
        });

        modelBuilder.Entity<AccountReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_report_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.ChartTemplate).WithMany(p => p.AccountReports)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_report_chart_template_id_fkey");

            entity.HasOne(d => d.Country).WithMany(p => p.AccountReports)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_report_country_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountReportCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_report_create_uid_fkey");

            entity.HasOne(d => d.RootReport).WithMany(p => p.InverseRootReport)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_report_root_report_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountReportWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_report_write_uid_fkey");
        });

        modelBuilder.Entity<AccountReportColumn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_report_column_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountReportColumnCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_report_column_create_uid_fkey");

            entity.HasOne(d => d.CustomAuditAction).WithMany(p => p.AccountReportColumns)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_report_column_custom_audit_action_id_fkey");

            entity.HasOne(d => d.Report).WithMany(p => p.AccountReportColumns)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_report_column_report_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountReportColumnWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_report_column_write_uid_fkey");
        });

        modelBuilder.Entity<AccountReportExpression>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_report_expression_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountReportExpressionCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_report_expression_create_uid_fkey");

            entity.HasOne(d => d.ReportLine).WithMany(p => p.AccountReportExpressions)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_report_expression_report_line_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountReportExpressionWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_report_expression_write_uid_fkey");
        });

        modelBuilder.Entity<AccountReportExternalValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_report_external_value_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CarryoverOriginReportLine).WithMany(p => p.AccountReportExternalValues)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_report_external_value_carryover_origin_report_line_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountReportExternalValues)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_report_external_value_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountReportExternalValueCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_report_external_value_create_uid_fkey");

            entity.HasOne(d => d.ForeignVatFiscalPosition).WithMany(p => p.AccountReportExternalValues)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_report_external_value_foreign_vat_fiscal_position__fkey");

            entity.HasOne(d => d.TargetReportExpression).WithMany(p => p.AccountReportExternalValues)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_report_external_value_target_report_expression_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountReportExternalValueWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_report_external_value_write_uid_fkey");
        });

        modelBuilder.Entity<AccountReportGeneralLedger>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_report_general_ledger_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountReportGeneralLedgers)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_report_general_ledger_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountReportGeneralLedgerCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_report_general_ledger_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountReportGeneralLedgerWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_report_general_ledger_write_uid_fkey");

            entity.HasMany(d => d.AccountAccounts).WithMany(p => p.AccountReportGeneralLedgers)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountAccountAccountReportGeneralLedgerRel",
                    r => r.HasOne<AccountAccount>().WithMany()
                        .HasForeignKey("AccountAccountId")
                        .HasConstraintName("account_account_account_report_general__account_account_id_fkey"),
                    l => l.HasOne<AccountReportGeneralLedger>().WithMany()
                        .HasForeignKey("AccountReportGeneralLedgerId")
                        .HasConstraintName("account_account_account_repor_account_report_general_ledge_fkey"),
                    j =>
                    {
                        j.HasKey("AccountReportGeneralLedgerId", "AccountAccountId").HasName("account_account_account_report_general_ledger_rel_pkey");
                        j.ToTable("account_account_account_report_general_ledger_rel");
                        j.HasIndex(new[] { "AccountAccountId", "AccountReportGeneralLedgerId" }, "account_account_account_repor_account_account_id_account_re_idx");
                    });

            entity.HasMany(d => d.AccountAnalyticAccounts).WithMany(p => p.AccountReportGeneralLedgers)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountAnalyticAccountAccountReportGeneralLedgerRel",
                    r => r.HasOne<AccountAnalyticAccount>().WithMany()
                        .HasForeignKey("AccountAnalyticAccountId")
                        .HasConstraintName("account_analytic_account_acco_account_analytic_account_id_fkey1"),
                    l => l.HasOne<AccountReportGeneralLedger>().WithMany()
                        .HasForeignKey("AccountReportGeneralLedgerId")
                        .HasConstraintName("account_analytic_account_acco_account_report_general_ledge_fkey"),
                    j =>
                    {
                        j.HasKey("AccountReportGeneralLedgerId", "AccountAnalyticAccountId").HasName("account_analytic_account_account_report_general_ledger_rel_pkey");
                        j.ToTable("account_analytic_account_account_report_general_ledger_rel");
                        j.HasIndex(new[] { "AccountAnalyticAccountId", "AccountReportGeneralLedgerId" }, "account_analytic_account_acco_account_analytic_account_id__idx1");
                    });

            entity.HasMany(d => d.Journals).WithMany(p => p.AccountsNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountReportGeneralLedgerJournalRel",
                    r => r.HasOne<AccountJournal>().WithMany()
                        .HasForeignKey("JournalId")
                        .HasConstraintName("account_report_general_ledger_journal_rel_journal_id_fkey"),
                    l => l.HasOne<AccountReportGeneralLedger>().WithMany()
                        .HasForeignKey("AccountId")
                        .HasConstraintName("account_report_general_ledger_journal_rel_account_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountId", "JournalId").HasName("account_report_general_ledger_journal_rel_pkey");
                        j.ToTable("account_report_general_ledger_journal_rel");
                        j.HasIndex(new[] { "JournalId", "AccountId" }, "account_report_general_ledger_journal_journal_id_account_id_idx");
                    });

            entity.HasMany(d => d.ResPartners).WithMany(p => p.AccountReportGeneralLedgers)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountReportGeneralLedgerResPartnerRel",
                    r => r.HasOne<ResPartner>().WithMany()
                        .HasForeignKey("ResPartnerId")
                        .HasConstraintName("account_report_general_ledger_res_partner_r_res_partner_id_fkey"),
                    l => l.HasOne<AccountReportGeneralLedger>().WithMany()
                        .HasForeignKey("AccountReportGeneralLedgerId")
                        .HasConstraintName("account_report_general_ledger_account_report_general_ledge_fkey"),
                    j =>
                    {
                        j.HasKey("AccountReportGeneralLedgerId", "ResPartnerId").HasName("account_report_general_ledger_res_partner_rel_pkey");
                        j.ToTable("account_report_general_ledger_res_partner_rel");
                        j.HasIndex(new[] { "ResPartnerId", "AccountReportGeneralLedgerId" }, "account_report_general_ledger_res_partner_id_account_report_idx");
                    });
        });

        modelBuilder.Entity<AccountReportLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_report_line_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountReportLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_report_line_create_uid_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_report_line_parent_id_fkey");

            entity.HasOne(d => d.Report).WithMany(p => p.AccountReportLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_report_line_report_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountReportLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_report_line_write_uid_fkey");
        });

        modelBuilder.Entity<AccountReportPartnerLedger>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_report_partner_ledger_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountReportPartnerLedgers)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_report_partner_ledger_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountReportPartnerLedgerCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_report_partner_ledger_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountReportPartnerLedgerWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_report_partner_ledger_write_uid_fkey");

            entity.HasMany(d => d.AccountJournals).WithMany(p => p.AccountReportPartnerLedgers)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountJournalAccountReportPartnerLedgerRel",
                    r => r.HasOne<AccountJournal>().WithMany()
                        .HasForeignKey("AccountJournalId")
                        .HasConstraintName("account_journal_account_report_partner__account_journal_id_fkey"),
                    l => l.HasOne<AccountReportPartnerLedger>().WithMany()
                        .HasForeignKey("AccountReportPartnerLedgerId")
                        .HasConstraintName("account_journal_account_repor_account_report_partner_ledge_fkey"),
                    j =>
                    {
                        j.HasKey("AccountReportPartnerLedgerId", "AccountJournalId").HasName("account_journal_account_report_partner_ledger_rel_pkey");
                        j.ToTable("account_journal_account_report_partner_ledger_rel");
                        j.HasIndex(new[] { "AccountJournalId", "AccountReportPartnerLedgerId" }, "account_journal_account_repor_account_journal_id_account_re_idx");
                    });

            entity.HasMany(d => d.ResPartners).WithMany(p => p.AccountReportPartnerLedgers)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountReportPartnerLedgerResPartnerRel",
                    r => r.HasOne<ResPartner>().WithMany()
                        .HasForeignKey("ResPartnerId")
                        .HasConstraintName("account_report_partner_ledger_res_partner_r_res_partner_id_fkey"),
                    l => l.HasOne<AccountReportPartnerLedger>().WithMany()
                        .HasForeignKey("AccountReportPartnerLedgerId")
                        .HasConstraintName("account_report_partner_ledger_account_report_partner_ledge_fkey"),
                    j =>
                    {
                        j.HasKey("AccountReportPartnerLedgerId", "ResPartnerId").HasName("account_report_partner_ledger_res_partner_rel_pkey");
                        j.ToTable("account_report_partner_ledger_res_partner_rel");
                        j.HasIndex(new[] { "ResPartnerId", "AccountReportPartnerLedgerId" }, "account_report_partner_ledger_res_partner_id_account_report_idx");
                    });
        });

        modelBuilder.Entity<AccountResequenceWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_resequence_wizard_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountResequenceWizardCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_resequence_wizard_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountResequenceWizardWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_resequence_wizard_write_uid_fkey");

            entity.HasMany(d => d.AccountMoves).WithMany(p => p.AccountResequenceWizards)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountMoveAccountResequenceWizardRel",
                    r => r.HasOne<AccountMove>().WithMany()
                        .HasForeignKey("AccountMoveId")
                        .HasConstraintName("account_move_account_resequence_wizard_rel_account_move_id_fkey"),
                    l => l.HasOne<AccountResequenceWizard>().WithMany()
                        .HasForeignKey("AccountResequenceWizardId")
                        .HasConstraintName("account_move_account_resequen_account_resequence_wizard_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountResequenceWizardId", "AccountMoveId").HasName("account_move_account_resequence_wizard_rel_pkey");
                        j.ToTable("account_move_account_resequence_wizard_rel");
                        j.HasIndex(new[] { "AccountMoveId", "AccountResequenceWizardId" }, "account_move_account_resequen_account_move_id_account_reseq_idx");
                    });
        });

        modelBuilder.Entity<AccountSetupBankManualConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_setup_bank_manual_config_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountSetupBankManualConfigCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_setup_bank_manual_config_create_uid_fkey");

            entity.HasOne(d => d.ResPartnerBank).WithMany(p => p.AccountSetupBankManualConfigs)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_setup_bank_manual_config_res_partner_bank_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountSetupBankManualConfigWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_setup_bank_manual_config_write_uid_fkey");
        });

        modelBuilder.Entity<AccountTax>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_tax_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CashBasisTransitionAccount).WithMany(p => p.AccountTaxes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_tax_cash_basis_transition_account_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountTaxes)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_tax_company_id_fkey");

            entity.HasOne(d => d.Country).WithMany(p => p.AccountTaxes)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_tax_country_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountTaxCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_tax_create_uid_fkey");

            entity.HasOne(d => d.TaxGroup).WithMany(p => p.AccountTaxes)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_tax_tax_group_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountTaxWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_tax_write_uid_fkey");

            entity.HasMany(d => d.ChildTaxes).WithMany(p => p.ParentTaxes)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountTaxFiliationRel",
                    r => r.HasOne<AccountTax>().WithMany()
                        .HasForeignKey("ChildTax")
                        .HasConstraintName("account_tax_filiation_rel_child_tax_fkey"),
                    l => l.HasOne<AccountTax>().WithMany()
                        .HasForeignKey("ParentTax")
                        .HasConstraintName("account_tax_filiation_rel_parent_tax_fkey"),
                    j =>
                    {
                        j.HasKey("ParentTax", "ChildTax").HasName("account_tax_filiation_rel_pkey");
                        j.ToTable("account_tax_filiation_rel");
                        j.HasIndex(new[] { "ChildTax", "ParentTax" }, "account_tax_filiation_rel_child_tax_parent_tax_idx");
                    });

            entity.HasMany(d => d.ParentTaxes).WithMany(p => p.ChildTaxes)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountTaxFiliationRel",
                    r => r.HasOne<AccountTax>().WithMany()
                        .HasForeignKey("ParentTax")
                        .HasConstraintName("account_tax_filiation_rel_parent_tax_fkey"),
                    l => l.HasOne<AccountTax>().WithMany()
                        .HasForeignKey("ChildTax")
                        .HasConstraintName("account_tax_filiation_rel_child_tax_fkey"),
                    j =>
                    {
                        j.HasKey("ParentTax", "ChildTax").HasName("account_tax_filiation_rel_pkey");
                        j.ToTable("account_tax_filiation_rel");
                        j.HasIndex(new[] { "ChildTax", "ParentTax" }, "account_tax_filiation_rel_child_tax_parent_tax_idx");
                    });
        });

        modelBuilder.Entity<AccountTaxGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_tax_group_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Country).WithMany(p => p.AccountTaxGroups)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_tax_group_country_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountTaxGroupCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_tax_group_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountTaxGroupWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_tax_group_write_uid_fkey");
        });

        modelBuilder.Entity<AccountTaxRepartitionLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_tax_repartition_line_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Account).WithMany(p => p.AccountTaxRepartitionLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_tax_repartition_line_account_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountTaxRepartitionLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_tax_repartition_line_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountTaxRepartitionLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_tax_repartition_line_create_uid_fkey");

            entity.HasOne(d => d.InvoiceTax).WithMany(p => p.AccountTaxRepartitionLineInvoiceTaxes)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_tax_repartition_line_invoice_tax_id_fkey");

            entity.HasOne(d => d.RefundTax).WithMany(p => p.AccountTaxRepartitionLineRefundTaxes)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_tax_repartition_line_refund_tax_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountTaxRepartitionLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_tax_repartition_line_write_uid_fkey");

            entity.HasMany(d => d.AccountAccountTags).WithMany(p => p.AccountTaxRepartitionLines)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountAccountTagAccountTaxRepartitionLineRel",
                    r => r.HasOne<AccountAccountTag>().WithMany()
                        .HasForeignKey("AccountAccountTagId")
                        .HasConstraintName("account_account_tag_account_tax_rep_account_account_tag_id_fkey"),
                    l => l.HasOne<AccountTaxRepartitionLine>().WithMany()
                        .HasForeignKey("AccountTaxRepartitionLineId")
                        .HasConstraintName("account_account_tag_account_t_account_tax_repartition_line_fkey"),
                    j =>
                    {
                        j.HasKey("AccountTaxRepartitionLineId", "AccountAccountTagId").HasName("account_account_tag_account_tax_repartition_line_rel_pkey");
                        j.ToTable("account_account_tag_account_tax_repartition_line_rel");
                        j.HasIndex(new[] { "AccountAccountTagId", "AccountTaxRepartitionLineId" }, "account_account_tag_account_t_account_account_tag_id_accoun_idx");
                    });
        });

        modelBuilder.Entity<AccountTaxRepartitionLineTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_tax_repartition_line_template_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Account).WithMany(p => p.AccountTaxRepartitionLineTemplates)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_tax_repartition_line_template_account_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountTaxRepartitionLineTemplateCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_tax_repartition_line_template_create_uid_fkey");

            entity.HasOne(d => d.InvoiceTax).WithMany(p => p.AccountTaxRepartitionLineTemplateInvoiceTaxes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_tax_repartition_line_template_invoice_tax_id_fkey");

            entity.HasOne(d => d.RefundTax).WithMany(p => p.AccountTaxRepartitionLineTemplateRefundTaxes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_tax_repartition_line_template_refund_tax_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountTaxRepartitionLineTemplateWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_tax_repartition_line_template_write_uid_fkey");

            entity.HasMany(d => d.AccountAccountTags).WithMany(p => p.AccountTaxRepartitionLineTemplates)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountTaxRepartitionFinancialTag",
                    r => r.HasOne<AccountAccountTag>().WithMany()
                        .HasForeignKey("AccountAccountTagId")
                        .HasConstraintName("account_tax_repartition_financial_t_account_account_tag_id_fkey"),
                    l => l.HasOne<AccountTaxRepartitionLineTemplate>().WithMany()
                        .HasForeignKey("AccountTaxRepartitionLineTemplateId")
                        .HasConstraintName("account_tax_repartition_finan_account_tax_repartition_line_fkey"),
                    j =>
                    {
                        j.HasKey("AccountTaxRepartitionLineTemplateId", "AccountAccountTagId").HasName("account_tax_repartition_financial_tags_pkey");
                        j.ToTable("account_tax_repartition_financial_tags");
                        j.HasIndex(new[] { "AccountAccountTagId", "AccountTaxRepartitionLineTemplateId" }, "account_tax_repartition_finan_account_account_tag_id_accoun_idx");
                    });

            entity.HasMany(d => d.AccountReportExpressions).WithMany(p => p.AccountTaxRepartitionLineTemplates)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountTaxRepTemplateMinu",
                    r => r.HasOne<AccountReportExpression>().WithMany()
                        .HasForeignKey("AccountReportExpressionId")
                        .HasConstraintName("account_tax_rep_template_minu_account_report_expression_id_fkey"),
                    l => l.HasOne<AccountTaxRepartitionLineTemplate>().WithMany()
                        .HasForeignKey("AccountTaxRepartitionLineTemplateId")
                        .HasConstraintName("account_tax_rep_template_minu_account_tax_repartition_line_fkey"),
                    j =>
                    {
                        j.HasKey("AccountTaxRepartitionLineTemplateId", "AccountReportExpressionId").HasName("account_tax_rep_template_minus_pkey");
                        j.ToTable("account_tax_rep_template_minus");
                        j.HasIndex(new[] { "AccountReportExpressionId", "AccountTaxRepartitionLineTemplateId" }, "account_tax_rep_template_minu_account_report_expression_id__idx");
                    });

            entity.HasMany(d => d.AccountReportExpressionsNavigation).WithMany(p => p.AccountTaxRepartitionLineTemplatesNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountTaxRepTemplatePlu",
                    r => r.HasOne<AccountReportExpression>().WithMany()
                        .HasForeignKey("AccountReportExpressionId")
                        .HasConstraintName("account_tax_rep_template_plus_account_report_expression_id_fkey"),
                    l => l.HasOne<AccountTaxRepartitionLineTemplate>().WithMany()
                        .HasForeignKey("AccountTaxRepartitionLineTemplateId")
                        .HasConstraintName("account_tax_rep_template_plus_account_tax_repartition_line_fkey"),
                    j =>
                    {
                        j.HasKey("AccountTaxRepartitionLineTemplateId", "AccountReportExpressionId").HasName("account_tax_rep_template_plus_pkey");
                        j.ToTable("account_tax_rep_template_plus");
                        j.HasIndex(new[] { "AccountReportExpressionId", "AccountTaxRepartitionLineTemplateId" }, "account_tax_rep_template_plus_account_report_expression_id__idx");
                    });
        });

        modelBuilder.Entity<AccountTaxReportWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_tax_report_wizard_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountTaxReportWizards)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("account_tax_report_wizard_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountTaxReportWizardCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_tax_report_wizard_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountTaxReportWizardWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_tax_report_wizard_write_uid_fkey");

            entity.HasMany(d => d.AccountJournals).WithMany(p => p.AccountTaxReportWizards)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountJournalAccountTaxReportWizardRel",
                    r => r.HasOne<AccountJournal>().WithMany()
                        .HasForeignKey("AccountJournalId")
                        .HasConstraintName("account_journal_account_tax_report_wiza_account_journal_id_fkey"),
                    l => l.HasOne<AccountTaxReportWizard>().WithMany()
                        .HasForeignKey("AccountTaxReportWizardId")
                        .HasConstraintName("account_journal_account_tax_r_account_tax_report_wizard_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountTaxReportWizardId", "AccountJournalId").HasName("account_journal_account_tax_report_wizard_rel_pkey");
                        j.ToTable("account_journal_account_tax_report_wizard_rel");
                        j.HasIndex(new[] { "AccountJournalId", "AccountTaxReportWizardId" }, "account_journal_account_tax_r_account_journal_id_account_ta_idx");
                    });
        });

        modelBuilder.Entity<AccountTaxTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_tax_template_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CashBasisTransitionAccount).WithMany(p => p.AccountTaxTemplates)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_tax_template_cash_basis_transition_account_id_fkey");

            entity.HasOne(d => d.ChartTemplate).WithMany(p => p.AccountTaxTemplates)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("account_tax_template_chart_template_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountTaxTemplateCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_tax_template_create_uid_fkey");

            entity.HasOne(d => d.TaxGroup).WithMany(p => p.AccountTaxTemplates)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_tax_template_tax_group_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountTaxTemplateWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_tax_template_write_uid_fkey");

            entity.HasMany(d => d.ChildTaxes).WithMany(p => p.ParentTaxes)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountTaxTemplateFiliationRel",
                    r => r.HasOne<AccountTaxTemplate>().WithMany()
                        .HasForeignKey("ChildTax")
                        .HasConstraintName("account_tax_template_filiation_rel_child_tax_fkey"),
                    l => l.HasOne<AccountTaxTemplate>().WithMany()
                        .HasForeignKey("ParentTax")
                        .HasConstraintName("account_tax_template_filiation_rel_parent_tax_fkey"),
                    j =>
                    {
                        j.HasKey("ParentTax", "ChildTax").HasName("account_tax_template_filiation_rel_pkey");
                        j.ToTable("account_tax_template_filiation_rel");
                        j.HasIndex(new[] { "ChildTax", "ParentTax" }, "account_tax_template_filiation_rel_child_tax_parent_tax_idx");
                    });

            entity.HasMany(d => d.ParentTaxes).WithMany(p => p.ChildTaxes)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountTaxTemplateFiliationRel",
                    r => r.HasOne<AccountTaxTemplate>().WithMany()
                        .HasForeignKey("ParentTax")
                        .HasConstraintName("account_tax_template_filiation_rel_parent_tax_fkey"),
                    l => l.HasOne<AccountTaxTemplate>().WithMany()
                        .HasForeignKey("ChildTax")
                        .HasConstraintName("account_tax_template_filiation_rel_child_tax_fkey"),
                    j =>
                    {
                        j.HasKey("ParentTax", "ChildTax").HasName("account_tax_template_filiation_rel_pkey");
                        j.ToTable("account_tax_template_filiation_rel");
                        j.HasIndex(new[] { "ChildTax", "ParentTax" }, "account_tax_template_filiation_rel_child_tax_parent_tax_idx");
                    });
        });

        modelBuilder.Entity<AccountTourUploadBill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_tour_upload_bill_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountTourUploadBillCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_tour_upload_bill_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountTourUploadBillWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_tour_upload_bill_write_uid_fkey");

            entity.HasMany(d => d.IrAttachments).WithMany(p => p.AccountTourUploadBills)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountTourUploadBillIrAttachmentsRel",
                    r => r.HasOne<IrAttachment>().WithMany()
                        .HasForeignKey("IrAttachmentId")
                        .HasConstraintName("account_tour_upload_bill_ir_attachments_r_ir_attachment_id_fkey"),
                    l => l.HasOne<AccountTourUploadBill>().WithMany()
                        .HasForeignKey("AccountTourUploadBillId")
                        .HasConstraintName("account_tour_upload_bill_ir_at_account_tour_upload_bill_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountTourUploadBillId", "IrAttachmentId").HasName("account_tour_upload_bill_ir_attachments_rel_pkey");
                        j.ToTable("account_tour_upload_bill_ir_attachments_rel");
                        j.HasIndex(new[] { "IrAttachmentId", "AccountTourUploadBillId" }, "account_tour_upload_bill_ir_a_ir_attachment_id_account_tour_idx");
                    });
        });

        modelBuilder.Entity<AccountTourUploadBillEmailConfirm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_tour_upload_bill_email_confirm_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountTourUploadBillEmailConfirmCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_tour_upload_bill_email_confirm_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountTourUploadBillEmailConfirmWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_tour_upload_bill_email_confirm_write_uid_fkey");
        });

        modelBuilder.Entity<AccountUnreconcile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_unreconcile_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountUnreconcileCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_unreconcile_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountUnreconcileWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("account_unreconcile_write_uid_fkey");
        });

        modelBuilder.Entity<AccountingReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("accounting_report_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.AccountReport).WithMany(p => p.AccountingReports)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("accounting_report_account_report_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountingReports)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("accounting_report_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AccountingReportCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("accounting_report_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AccountingReportWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("accounting_report_write_uid_fkey");

            entity.HasMany(d => d.AccountJournals).WithMany(p => p.AccountingReports)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountJournalAccountingReportRel",
                    r => r.HasOne<AccountJournal>().WithMany()
                        .HasForeignKey("AccountJournalId")
                        .HasConstraintName("account_journal_accounting_report_rel_account_journal_id_fkey"),
                    l => l.HasOne<AccountingReport>().WithMany()
                        .HasForeignKey("AccountingReportId")
                        .HasConstraintName("account_journal_accounting_report_rel_accounting_report_id_fkey"),
                    j =>
                    {
                        j.HasKey("AccountingReportId", "AccountJournalId").HasName("account_journal_accounting_report_rel_pkey");
                        j.ToTable("account_journal_accounting_report_rel");
                        j.HasIndex(new[] { "AccountJournalId", "AccountingReportId" }, "account_journal_accounting_re_account_journal_id_accounting_idx");
                    });
        });

        modelBuilder.Entity<ApplicantGetRefuseReason>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("applicant_get_refuse_reason_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ApplicantGetRefuseReasonCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("applicant_get_refuse_reason_create_uid_fkey");

            entity.HasOne(d => d.RefuseReason).WithMany(p => p.ApplicantGetRefuseReasons)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("applicant_get_refuse_reason_refuse_reason_id_fkey");

            entity.HasOne(d => d.Template).WithMany(p => p.ApplicantGetRefuseReasons)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("applicant_get_refuse_reason_template_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ApplicantGetRefuseReasonWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("applicant_get_refuse_reason_write_uid_fkey");

            entity.HasMany(d => d.HrApplicants).WithMany(p => p.ApplicantGetRefuseReasons)
                .UsingEntity<Dictionary<string, object>>(
                    "ApplicantGetRefuseReasonHrApplicantRel",
                    r => r.HasOne<HrApplicant>().WithMany()
                        .HasForeignKey("HrApplicantId")
                        .HasConstraintName("applicant_get_refuse_reason_hr_applicant_r_hr_applicant_id_fkey"),
                    l => l.HasOne<ApplicantGetRefuseReason>().WithMany()
                        .HasForeignKey("ApplicantGetRefuseReasonId")
                        .HasConstraintName("applicant_get_refuse_reason_h_applicant_get_refuse_reason__fkey"),
                    j =>
                    {
                        j.HasKey("ApplicantGetRefuseReasonId", "HrApplicantId").HasName("applicant_get_refuse_reason_hr_applicant_rel_pkey");
                        j.ToTable("applicant_get_refuse_reason_hr_applicant_rel");
                        j.HasIndex(new[] { "HrApplicantId", "ApplicantGetRefuseReasonId" }, "applicant_get_refuse_reason_h_hr_applicant_id_applicant_get_idx");
                    });
        });

        modelBuilder.Entity<ApplicantSendMail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("applicant_send_mail_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Author).WithMany(p => p.ApplicantSendMails)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("applicant_send_mail_author_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ApplicantSendMailCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("applicant_send_mail_create_uid_fkey");

            entity.HasOne(d => d.Template).WithMany(p => p.ApplicantSendMails)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("applicant_send_mail_template_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ApplicantSendMailWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("applicant_send_mail_write_uid_fkey");

            entity.HasMany(d => d.HrApplicants).WithMany(p => p.ApplicantSendMails)
                .UsingEntity<Dictionary<string, object>>(
                    "ApplicantSendMailHrApplicantRel",
                    r => r.HasOne<HrApplicant>().WithMany()
                        .HasForeignKey("HrApplicantId")
                        .HasConstraintName("applicant_send_mail_hr_applicant_rel_hr_applicant_id_fkey"),
                    l => l.HasOne<ApplicantSendMail>().WithMany()
                        .HasForeignKey("ApplicantSendMailId")
                        .HasConstraintName("applicant_send_mail_hr_applicant_re_applicant_send_mail_id_fkey"),
                    j =>
                    {
                        j.HasKey("ApplicantSendMailId", "HrApplicantId").HasName("applicant_send_mail_hr_applicant_rel_pkey");
                        j.ToTable("applicant_send_mail_hr_applicant_rel");
                        j.HasIndex(new[] { "HrApplicantId", "ApplicantSendMailId" }, "applicant_send_mail_hr_applic_hr_applicant_id_applicant_sen_idx");
                    });
        });

        modelBuilder.Entity<AssetDepreciationConfirmationWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("asset_depreciation_confirmation_wizard_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AssetDepreciationConfirmationWizardCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("asset_depreciation_confirmation_wizard_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AssetDepreciationConfirmationWizardWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("asset_depreciation_confirmation_wizard_write_uid_fkey");
        });

        modelBuilder.Entity<AssetModify>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("asset_modify_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AssetModifyCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("asset_modify_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AssetModifyWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("asset_modify_write_uid_fkey");
        });

        modelBuilder.Entity<AuthTotpDevice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_totp_device_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.CreateDate).HasDefaultValueSql("(now() AT TIME ZONE 'utc'::text)");

            entity.HasOne(d => d.User).WithMany(p => p.AuthTotpDevices).HasConstraintName("auth_totp_device_user_id_fkey");
        });

        modelBuilder.Entity<AuthTotpWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_totp_wizard_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AuthTotpWizardCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("auth_totp_wizard_create_uid_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.AuthTotpWizardUsers)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("auth_totp_wizard_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AuthTotpWizardWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("auth_totp_wizard_write_uid_fkey");
        });

        modelBuilder.Entity<BarcodeNomenclature>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("barcode_nomenclature_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BarcodeNomenclatureCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("barcode_nomenclature_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BarcodeNomenclatureWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("barcode_nomenclature_write_uid_fkey");
        });

        modelBuilder.Entity<BarcodeRule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("barcode_rule_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.AssociatedUom).WithMany(p => p.BarcodeRules)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("barcode_rule_associated_uom_id_fkey");

            entity.HasOne(d => d.BarcodeNomenclature).WithMany(p => p.BarcodeRules)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("barcode_rule_barcode_nomenclature_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BarcodeRuleCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("barcode_rule_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BarcodeRuleWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("barcode_rule_write_uid_fkey");
        });

        modelBuilder.Entity<BaseDocumentLayout>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_document_layout_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.BaseDocumentLayouts)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("base_document_layout_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseDocumentLayoutCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_document_layout_create_uid_fkey");

            entity.HasOne(d => d.ReportLayout).WithMany(p => p.BaseDocumentLayouts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_document_layout_report_layout_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseDocumentLayoutWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_document_layout_write_uid_fkey");
        });

        modelBuilder.Entity<BaseEnableProfilingWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_enable_profiling_wizard_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseEnableProfilingWizardCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_enable_profiling_wizard_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseEnableProfilingWizardWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_enable_profiling_wizard_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportImport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_import_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportImportCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_import_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportImportWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_import_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_mapping_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportMappingCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_mapping_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportMappingWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_mapping_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsChar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_char_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsCharCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_char_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsCharWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_char_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsCharNoreadonly>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_char_noreadonly_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsCharNoreadonlyCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_char_noreadonly_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsCharNoreadonlyWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_char_noreadonly_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsCharReadonly>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_char_readonly_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsCharReadonlyCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_char_readonly_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsCharReadonlyWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_char_readonly_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsCharRequired>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_char_required_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsCharRequiredCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_char_required_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsCharRequiredWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_char_required_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsCharState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_char_states_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsCharStateCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_char_states_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsCharStateWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_char_states_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsCharStillreadonly>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_char_stillreadonly_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsCharStillreadonlyCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_char_stillreadonly_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsCharStillreadonlyWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_char_stillreadonly_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsComplex>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_complex_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsComplexCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_complex_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.BaseImportTestsModelsComplexes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_complex_currency_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsComplexWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_complex_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsFloat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_float_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsFloatCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_float_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.BaseImportTestsModelsFloats)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_float_currency_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsFloatWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_float_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsM2o>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_m2o_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsM2oCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_m2o_create_uid_fkey");

            entity.HasOne(d => d.ValueNavigation).WithMany(p => p.BaseImportTestsModelsM2os)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_m2o_value_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsM2oWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_m2o_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsM2oRelated>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_m2o_related_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsM2oRelatedCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_m2o_related_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsM2oRelatedWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_m2o_related_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsM2oRequired>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_m2o_required_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsM2oRequiredCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_m2o_required_create_uid_fkey");

            entity.HasOne(d => d.ValueNavigation).WithMany(p => p.BaseImportTestsModelsM2oRequireds)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("base_import_tests_models_m2o_required_value_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsM2oRequiredWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_m2o_required_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsM2oRequiredRelated>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_m2o_required_related_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsM2oRequiredRelatedCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_m2o_required_related_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsM2oRequiredRelatedWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_m2o_required_related_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsO2m>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_o2m_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsO2mCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_o2m_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsO2mWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_o2m_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsO2mChild>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_o2m_child_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsO2mChildCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_o2m_child_create_uid_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.BaseImportTestsModelsO2mChildren)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_o2m_child_parent_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsO2mChildWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_o2m_child_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsPreview>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_preview_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsPreviewCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_preview_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsPreviewWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_preview_write_uid_fkey");
        });

        modelBuilder.Entity<BaseLanguageExport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_language_export_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseLanguageExportCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_language_export_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseLanguageExportWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_language_export_write_uid_fkey");

            entity.HasMany(d => d.Modules).WithMany(p => p.Wizs)
                .UsingEntity<Dictionary<string, object>>(
                    "RelModulesLangexport",
                    r => r.HasOne<IrModuleModule>().WithMany()
                        .HasForeignKey("ModuleId")
                        .HasConstraintName("rel_modules_langexport_module_id_fkey"),
                    l => l.HasOne<BaseLanguageExport>().WithMany()
                        .HasForeignKey("WizId")
                        .HasConstraintName("rel_modules_langexport_wiz_id_fkey"),
                    j =>
                    {
                        j.HasKey("WizId", "ModuleId").HasName("rel_modules_langexport_pkey");
                        j.ToTable("rel_modules_langexport");
                        j.HasIndex(new[] { "ModuleId", "WizId" }, "rel_modules_langexport_module_id_wiz_id_idx");
                    });
        });

        modelBuilder.Entity<BaseLanguageImport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_language_import_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseLanguageImportCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_language_import_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseLanguageImportWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_language_import_write_uid_fkey");
        });

        modelBuilder.Entity<BaseLanguageInstall>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_language_install_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseLanguageInstallCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_language_install_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseLanguageInstallWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_language_install_write_uid_fkey");

            entity.HasMany(d => d.Langs).WithMany(p => p.LanguageWizards)
                .UsingEntity<Dictionary<string, object>>(
                    "ResLangInstallRel",
                    r => r.HasOne<ResLang>().WithMany()
                        .HasForeignKey("LangId")
                        .HasConstraintName("res_lang_install_rel_lang_id_fkey"),
                    l => l.HasOne<BaseLanguageInstall>().WithMany()
                        .HasForeignKey("LanguageWizardId")
                        .HasConstraintName("res_lang_install_rel_language_wizard_id_fkey"),
                    j =>
                    {
                        j.HasKey("LanguageWizardId", "LangId").HasName("res_lang_install_rel_pkey");
                        j.ToTable("res_lang_install_rel");
                        j.HasIndex(new[] { "LangId", "LanguageWizardId" }, "res_lang_install_rel_lang_id_language_wizard_id_idx");
                    });

            entity.HasMany(d => d.Websites).WithMany(p => p.BaseLanguageInstalls)
                .UsingEntity<Dictionary<string, object>>(
                    "BaseLanguageInstallWebsiteRel",
                    r => r.HasOne<Website>().WithMany()
                        .HasForeignKey("WebsiteId")
                        .HasConstraintName("base_language_install_website_rel_website_id_fkey"),
                    l => l.HasOne<BaseLanguageInstall>().WithMany()
                        .HasForeignKey("BaseLanguageInstallId")
                        .HasConstraintName("base_language_install_website_rel_base_language_install_id_fkey"),
                    j =>
                    {
                        j.HasKey("BaseLanguageInstallId", "WebsiteId").HasName("base_language_install_website_rel_pkey");
                        j.ToTable("base_language_install_website_rel");
                        j.HasIndex(new[] { "WebsiteId", "BaseLanguageInstallId" }, "base_language_install_website_website_id_base_language_inst_idx");
                    });
        });

        modelBuilder.Entity<BaseModuleInstallRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_module_install_request_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseModuleInstallRequestCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_module_install_request_create_uid_fkey");

            entity.HasOne(d => d.Module).WithMany(p => p.BaseModuleInstallRequests)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("base_module_install_request_module_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.BaseModuleInstallRequestUsers)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("base_module_install_request_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseModuleInstallRequestWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_module_install_request_write_uid_fkey");
        });

        modelBuilder.Entity<BaseModuleInstallReview>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_module_install_review_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseModuleInstallReviewCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_module_install_review_create_uid_fkey");

            entity.HasOne(d => d.Module).WithMany(p => p.BaseModuleInstallReviews)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("base_module_install_review_module_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseModuleInstallReviewWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_module_install_review_write_uid_fkey");
        });

        modelBuilder.Entity<BaseModuleUninstall>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_module_uninstall_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseModuleUninstallCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_module_uninstall_create_uid_fkey");

            entity.HasOne(d => d.Module).WithMany(p => p.BaseModuleUninstalls)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("base_module_uninstall_module_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseModuleUninstallWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_module_uninstall_write_uid_fkey");
        });

        modelBuilder.Entity<BaseModuleUpdate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_module_update_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseModuleUpdateCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_module_update_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseModuleUpdateWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_module_update_write_uid_fkey");
        });

        modelBuilder.Entity<BaseModuleUpgrade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_module_upgrade_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseModuleUpgradeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_module_upgrade_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseModuleUpgradeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_module_upgrade_write_uid_fkey");
        });

        modelBuilder.Entity<BasePartnerMergeAutomaticWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_partner_merge_automatic_wizard_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BasePartnerMergeAutomaticWizardCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_partner_merge_automatic_wizard_create_uid_fkey");

            entity.HasOne(d => d.CurrentLine).WithMany(p => p.BasePartnerMergeAutomaticWizards)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_partner_merge_automatic_wizard_current_line_id_fkey");

            entity.HasOne(d => d.DstPartner).WithMany(p => p.BasePartnerMergeAutomaticWizards)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_partner_merge_automatic_wizard_dst_partner_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BasePartnerMergeAutomaticWizardWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_partner_merge_automatic_wizard_write_uid_fkey");

            entity.HasMany(d => d.ResPartners).WithMany(p => p.BasePartnerMergeAutomaticWizardsNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "BasePartnerMergeAutomaticWizardResPartnerRel",
                    r => r.HasOne<ResPartner>().WithMany()
                        .HasForeignKey("ResPartnerId")
                        .HasConstraintName("base_partner_merge_automatic_wizard_res_par_res_partner_id_fkey"),
                    l => l.HasOne<BasePartnerMergeAutomaticWizard>().WithMany()
                        .HasForeignKey("BasePartnerMergeAutomaticWizardId")
                        .HasConstraintName("base_partner_merge_automatic__base_partner_merge_automatic_fkey"),
                    j =>
                    {
                        j.HasKey("BasePartnerMergeAutomaticWizardId", "ResPartnerId").HasName("base_partner_merge_automatic_wizard_res_partner_rel_pkey");
                        j.ToTable("base_partner_merge_automatic_wizard_res_partner_rel");
                        j.HasIndex(new[] { "ResPartnerId", "BasePartnerMergeAutomaticWizardId" }, "base_partner_merge_automatic__res_partner_id_base_partner_m_idx");
                    });
        });

        modelBuilder.Entity<BasePartnerMergeLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_partner_merge_line_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BasePartnerMergeLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_partner_merge_line_create_uid_fkey");

            entity.HasOne(d => d.Wizard).WithMany(p => p.BasePartnerMergeLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_partner_merge_line_wizard_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BasePartnerMergeLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_partner_merge_line_write_uid_fkey");
        });

        modelBuilder.Entity<BusBu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("bus_bus_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BusBuCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("bus_bus_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BusBuWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("bus_bus_write_uid_fkey");
        });

        modelBuilder.Entity<BusPresence>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("bus_presence_pkey");

            entity.HasIndex(e => e.GuestId, "bus_presence_guest_unique")
                .IsUnique()
                .HasFilter("(guest_id IS NOT NULL)");

            entity.HasIndex(e => e.UserId, "bus_presence_user_unique")
                .IsUnique()
                .HasFilter("(user_id IS NOT NULL)");

            entity.HasOne(d => d.Guest).WithOne(p => p.BusPresence)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("bus_presence_guest_id_fkey");

            entity.HasOne(d => d.User).WithOne(p => p.BusPresence)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("bus_presence_user_id_fkey");
        });

        modelBuilder.Entity<CalendarAlarm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("calendar_alarm_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CalendarAlarmCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("calendar_alarm_create_uid_fkey");

            entity.HasOne(d => d.MailTemplate).WithMany(p => p.CalendarAlarms)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("calendar_alarm_mail_template_id_fkey");

            entity.HasOne(d => d.SmsTemplate).WithMany(p => p.CalendarAlarms)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("calendar_alarm_sms_template_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CalendarAlarmWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("calendar_alarm_write_uid_fkey");
        });

        modelBuilder.Entity<CalendarAttendee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("calendar_attendee_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CalendarAttendeeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("calendar_attendee_create_uid_fkey");

            entity.HasOne(d => d.Event).WithMany(p => p.CalendarAttendees)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("calendar_attendee_event_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.CalendarAttendees)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("calendar_attendee_partner_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CalendarAttendeeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("calendar_attendee_write_uid_fkey");
        });

        modelBuilder.Entity<CalendarEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("calendar_event_pkey");

            entity.HasIndex(e => e.ApplicantId, "calendar_event_applicant_id_index").HasFilter("(applicant_id IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Applicant).WithMany(p => p.CalendarEvents)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("calendar_event_applicant_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CalendarEventCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("calendar_event_create_uid_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.CalendarEvents)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("calendar_event_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Opportunity).WithMany(p => p.CalendarEvents)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("calendar_event_opportunity_id_fkey");

            entity.HasOne(d => d.Recurrence).WithMany(p => p.CalendarEvents)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("calendar_event_recurrence_id_fkey");

            entity.HasOne(d => d.ResModelNavigation).WithMany(p => p.CalendarEvents)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("calendar_event_res_model_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.CalendarEventUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("calendar_event_user_id_fkey");

            entity.HasOne(d => d.VideocallChannel).WithMany(p => p.CalendarEvents)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("calendar_event_videocall_channel_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CalendarEventWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("calendar_event_write_uid_fkey");

            entity.HasMany(d => d.CalendarAlarms).WithMany(p => p.CalendarEvents)
                .UsingEntity<Dictionary<string, object>>(
                    "CalendarAlarmCalendarEventRel",
                    r => r.HasOne<CalendarAlarm>().WithMany()
                        .HasForeignKey("CalendarAlarmId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("calendar_alarm_calendar_event_rel_calendar_alarm_id_fkey"),
                    l => l.HasOne<CalendarEvent>().WithMany()
                        .HasForeignKey("CalendarEventId")
                        .HasConstraintName("calendar_alarm_calendar_event_rel_calendar_event_id_fkey"),
                    j =>
                    {
                        j.HasKey("CalendarEventId", "CalendarAlarmId").HasName("calendar_alarm_calendar_event_rel_pkey");
                        j.ToTable("calendar_alarm_calendar_event_rel");
                        j.HasIndex(new[] { "CalendarAlarmId", "CalendarEventId" }, "calendar_alarm_calendar_event_calendar_alarm_id_calendar_ev_idx");
                    });

            entity.HasMany(d => d.Types).WithMany(p => p.Events)
                .UsingEntity<Dictionary<string, object>>(
                    "MeetingCategoryRel",
                    r => r.HasOne<CalendarEventType>().WithMany()
                        .HasForeignKey("TypeId")
                        .HasConstraintName("meeting_category_rel_type_id_fkey"),
                    l => l.HasOne<CalendarEvent>().WithMany()
                        .HasForeignKey("EventId")
                        .HasConstraintName("meeting_category_rel_event_id_fkey"),
                    j =>
                    {
                        j.HasKey("EventId", "TypeId").HasName("meeting_category_rel_pkey");
                        j.ToTable("meeting_category_rel");
                        j.HasIndex(new[] { "TypeId", "EventId" }, "meeting_category_rel_type_id_event_id_idx");
                    });
        });

        modelBuilder.Entity<CalendarEventType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("calendar_event_type_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CalendarEventTypeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("calendar_event_type_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CalendarEventTypeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("calendar_event_type_write_uid_fkey");
        });

        modelBuilder.Entity<CalendarFilter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("calendar_filters_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CalendarFilterCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("calendar_filters_create_uid_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.CalendarFilters)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("calendar_filters_partner_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.CalendarFilterUsers)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("calendar_filters_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CalendarFilterWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("calendar_filters_write_uid_fkey");
        });

        modelBuilder.Entity<CalendarProviderConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("calendar_provider_config_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CalendarProviderConfigCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("calendar_provider_config_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CalendarProviderConfigWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("calendar_provider_config_write_uid_fkey");
        });

        modelBuilder.Entity<CalendarRecurrence>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("calendar_recurrence_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.BaseEvent).WithMany(p => p.CalendarRecurrences)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("calendar_recurrence_base_event_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CalendarRecurrenceCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("calendar_recurrence_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CalendarRecurrenceWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("calendar_recurrence_write_uid_fkey");
        });

        modelBuilder.Entity<ChangeLockDate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("change_lock_date_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.ChangeLockDates)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("change_lock_date_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ChangeLockDateCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("change_lock_date_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ChangeLockDateWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("change_lock_date_write_uid_fkey");
        });

        modelBuilder.Entity<ChangePasswordOwn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("change_password_own_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ChangePasswordOwnCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("change_password_own_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ChangePasswordOwnWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("change_password_own_write_uid_fkey");
        });

        modelBuilder.Entity<ChangePasswordUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("change_password_user_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ChangePasswordUserCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("change_password_user_create_uid_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.ChangePasswordUserUsers)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("change_password_user_user_id_fkey");

            entity.HasOne(d => d.Wizard).WithMany(p => p.ChangePasswordUsers)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("change_password_user_wizard_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ChangePasswordUserWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("change_password_user_write_uid_fkey");
        });

        modelBuilder.Entity<ChangePasswordWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("change_password_wizard_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ChangePasswordWizardCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("change_password_wizard_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ChangePasswordWizardWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("change_password_wizard_write_uid_fkey");
        });

        modelBuilder.Entity<ChangeProductionQty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("change_production_qty_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ChangeProductionQtyCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("change_production_qty_create_uid_fkey");

            entity.HasOne(d => d.Mo).WithMany(p => p.ChangeProductionQties)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("change_production_qty_mo_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ChangeProductionQtyWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("change_production_qty_write_uid_fkey");
        });

        modelBuilder.Entity<ConfirmStockSm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("confirm_stock_sms_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ConfirmStockSmCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("confirm_stock_sms_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ConfirmStockSmWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("confirm_stock_sms_write_uid_fkey");

            entity.HasMany(d => d.StockPickings).WithMany(p => p.ConfirmStockSms)
                .UsingEntity<Dictionary<string, object>>(
                    "StockPickingSmsRel",
                    r => r.HasOne<StockPicking>().WithMany()
                        .HasForeignKey("StockPickingId")
                        .HasConstraintName("stock_picking_sms_rel_stock_picking_id_fkey"),
                    l => l.HasOne<ConfirmStockSm>().WithMany()
                        .HasForeignKey("ConfirmStockSmsId")
                        .HasConstraintName("stock_picking_sms_rel_confirm_stock_sms_id_fkey"),
                    j =>
                    {
                        j.HasKey("ConfirmStockSmsId", "StockPickingId").HasName("stock_picking_sms_rel_pkey");
                        j.ToTable("stock_picking_sms_rel");
                        j.HasIndex(new[] { "StockPickingId", "ConfirmStockSmsId" }, "stock_picking_sms_rel_stock_picking_id_confirm_stock_sms_id_idx");
                    });
        });

        modelBuilder.Entity<CrmIapLeadHelper>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("crm_iap_lead_helpers_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CrmIapLeadHelperCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_iap_lead_helpers_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CrmIapLeadHelperWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_iap_lead_helpers_write_uid_fkey");
        });

        modelBuilder.Entity<CrmIapLeadIndustry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("crm_iap_lead_industry_pkey");

            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.CrmIapLeadIndustryCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_iap_lead_industry_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CrmIapLeadIndustryWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_iap_lead_industry_write_uid_fkey");
        });

        modelBuilder.Entity<CrmIapLeadMiningRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("crm_iap_lead_mining_request_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CrmIapLeadMiningRequestCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_iap_lead_mining_request_create_uid_fkey");

            entity.HasOne(d => d.PreferredRole).WithMany(p => p.CrmIapLeadMiningRequests)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_iap_lead_mining_request_preferred_role_id_fkey");

            entity.HasOne(d => d.Seniority).WithMany(p => p.CrmIapLeadMiningRequests)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_iap_lead_mining_request_seniority_id_fkey");

            entity.HasOne(d => d.Team).WithMany(p => p.CrmIapLeadMiningRequests)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_iap_lead_mining_request_team_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.CrmIapLeadMiningRequestUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_iap_lead_mining_request_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CrmIapLeadMiningRequestWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_iap_lead_mining_request_write_uid_fkey");

            entity.HasMany(d => d.CrmIapLeadIndustries).WithMany(p => p.CrmIapLeadMiningRequests)
                .UsingEntity<Dictionary<string, object>>(
                    "CrmIapLeadIndustryCrmIapLeadMiningRequestRel",
                    r => r.HasOne<CrmIapLeadIndustry>().WithMany()
                        .HasForeignKey("CrmIapLeadIndustryId")
                        .HasConstraintName("crm_iap_lead_industry_crm_iap_lea_crm_iap_lead_industry_id_fkey"),
                    l => l.HasOne<CrmIapLeadMiningRequest>().WithMany()
                        .HasForeignKey("CrmIapLeadMiningRequestId")
                        .HasConstraintName("crm_iap_lead_industry_crm_iap_crm_iap_lead_mining_request__fkey"),
                    j =>
                    {
                        j.HasKey("CrmIapLeadMiningRequestId", "CrmIapLeadIndustryId").HasName("crm_iap_lead_industry_crm_iap_lead_mining_request_rel_pkey");
                        j.ToTable("crm_iap_lead_industry_crm_iap_lead_mining_request_rel");
                        j.HasIndex(new[] { "CrmIapLeadIndustryId", "CrmIapLeadMiningRequestId" }, "crm_iap_lead_industry_crm_iap_crm_iap_lead_industry_id_crm__idx");
                    });

            entity.HasMany(d => d.CrmIapLeadRoles).WithMany(p => p.CrmIapLeadMiningRequestsNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "CrmIapLeadMiningRequestCrmIapLeadRoleRel",
                    r => r.HasOne<CrmIapLeadRole>().WithMany()
                        .HasForeignKey("CrmIapLeadRoleId")
                        .HasConstraintName("crm_iap_lead_mining_request_crm_iap_l_crm_iap_lead_role_id_fkey"),
                    l => l.HasOne<CrmIapLeadMiningRequest>().WithMany()
                        .HasForeignKey("CrmIapLeadMiningRequestId")
                        .HasConstraintName("crm_iap_lead_mining_request__crm_iap_lead_mining_request__fkey2"),
                    j =>
                    {
                        j.HasKey("CrmIapLeadMiningRequestId", "CrmIapLeadRoleId").HasName("crm_iap_lead_mining_request_crm_iap_lead_role_rel_pkey");
                        j.ToTable("crm_iap_lead_mining_request_crm_iap_lead_role_rel");
                        j.HasIndex(new[] { "CrmIapLeadRoleId", "CrmIapLeadMiningRequestId" }, "crm_iap_lead_mining_request_c_crm_iap_lead_role_id_crm_iap__idx");
                    });

            entity.HasMany(d => d.CrmTags).WithMany(p => p.CrmIapLeadMiningRequests)
                .UsingEntity<Dictionary<string, object>>(
                    "CrmIapLeadMiningRequestCrmTagRel",
                    r => r.HasOne<CrmTag>().WithMany()
                        .HasForeignKey("CrmTagId")
                        .HasConstraintName("crm_iap_lead_mining_request_crm_tag_rel_crm_tag_id_fkey"),
                    l => l.HasOne<CrmIapLeadMiningRequest>().WithMany()
                        .HasForeignKey("CrmIapLeadMiningRequestId")
                        .HasConstraintName("crm_iap_lead_mining_request_c_crm_iap_lead_mining_request__fkey"),
                    j =>
                    {
                        j.HasKey("CrmIapLeadMiningRequestId", "CrmTagId").HasName("crm_iap_lead_mining_request_crm_tag_rel_pkey");
                        j.ToTable("crm_iap_lead_mining_request_crm_tag_rel");
                        j.HasIndex(new[] { "CrmTagId", "CrmIapLeadMiningRequestId" }, "crm_iap_lead_mining_request_c_crm_tag_id_crm_iap_lead_minin_idx");
                    });

            entity.HasMany(d => d.ResCountries).WithMany(p => p.CrmIapLeadMiningRequests)
                .UsingEntity<Dictionary<string, object>>(
                    "CrmIapLeadMiningRequestResCountryRel",
                    r => r.HasOne<ResCountry>().WithMany()
                        .HasForeignKey("ResCountryId")
                        .HasConstraintName("crm_iap_lead_mining_request_res_country_rel_res_country_id_fkey"),
                    l => l.HasOne<CrmIapLeadMiningRequest>().WithMany()
                        .HasForeignKey("CrmIapLeadMiningRequestId")
                        .HasConstraintName("crm_iap_lead_mining_request_r_crm_iap_lead_mining_request__fkey"),
                    j =>
                    {
                        j.HasKey("CrmIapLeadMiningRequestId", "ResCountryId").HasName("crm_iap_lead_mining_request_res_country_rel_pkey");
                        j.ToTable("crm_iap_lead_mining_request_res_country_rel");
                        j.HasIndex(new[] { "ResCountryId", "CrmIapLeadMiningRequestId" }, "crm_iap_lead_mining_request_r_res_country_id_crm_iap_lead_m_idx");
                    });

            entity.HasMany(d => d.ResCountryStates).WithMany(p => p.CrmIapLeadMiningRequests)
                .UsingEntity<Dictionary<string, object>>(
                    "CrmIapLeadMiningRequestResCountryStateRel",
                    r => r.HasOne<ResCountryState>().WithMany()
                        .HasForeignKey("ResCountryStateId")
                        .HasConstraintName("crm_iap_lead_mining_request_res_count_res_country_state_id_fkey"),
                    l => l.HasOne<CrmIapLeadMiningRequest>().WithMany()
                        .HasForeignKey("CrmIapLeadMiningRequestId")
                        .HasConstraintName("crm_iap_lead_mining_request__crm_iap_lead_mining_request__fkey1"),
                    j =>
                    {
                        j.HasKey("CrmIapLeadMiningRequestId", "ResCountryStateId").HasName("crm_iap_lead_mining_request_res_country_state_rel_pkey");
                        j.ToTable("crm_iap_lead_mining_request_res_country_state_rel");
                        j.HasIndex(new[] { "ResCountryStateId", "CrmIapLeadMiningRequestId" }, "crm_iap_lead_mining_request_r_res_country_state_id_crm_iap__idx");
                    });
        });

        modelBuilder.Entity<CrmIapLeadRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("crm_iap_lead_role_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CrmIapLeadRoleCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_iap_lead_role_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CrmIapLeadRoleWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_iap_lead_role_write_uid_fkey");
        });

        modelBuilder.Entity<CrmIapLeadSeniority>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("crm_iap_lead_seniority_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CrmIapLeadSeniorityCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_iap_lead_seniority_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CrmIapLeadSeniorityWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_iap_lead_seniority_write_uid_fkey");
        });

        modelBuilder.Entity<CrmLead>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("crm_lead_pkey");

            entity.HasIndex(e => e.EmailFrom, "crm_lead_email_from_index")
                .HasMethod("gin")
                .HasOperators(new[] { "gin_trgm_ops" });

            entity.HasIndex(e => e.LeadMiningRequestId, "crm_lead_lead_mining_request_id_index").HasFilter("(lead_mining_request_id IS NOT NULL)");

            entity.HasIndex(e => e.Name, "crm_lead_name_index")
                .HasMethod("gin")
                .HasOperators(new[] { "gin_trgm_ops" });

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Campaign).WithMany(p => p.CrmLeads)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead_campaign_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.CrmLeads)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead_company_id_fkey");

            entity.HasOne(d => d.Country).WithMany(p => p.CrmLeads)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead_country_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CrmLeadCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead_create_uid_fkey");

            entity.HasOne(d => d.Lang).WithMany(p => p.CrmLeads)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead_lang_id_fkey");

            entity.HasOne(d => d.LeadMiningRequest).WithMany(p => p.CrmLeads)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead_lead_mining_request_id_fkey");

            entity.HasOne(d => d.LostReason).WithMany(p => p.CrmLeads)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("crm_lead_lost_reason_id_fkey");

            entity.HasOne(d => d.Medium).WithMany(p => p.CrmLeads)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead_medium_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.CrmLeads)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.CrmLeads)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead_partner_id_fkey");

            entity.HasOne(d => d.RecurringPlanNavigation).WithMany(p => p.CrmLeads)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead_recurring_plan_fkey");

            entity.HasOne(d => d.Source).WithMany(p => p.CrmLeads)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead_source_id_fkey");

            entity.HasOne(d => d.Stage).WithMany(p => p.CrmLeads)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("crm_lead_stage_id_fkey");

            entity.HasOne(d => d.State).WithMany(p => p.CrmLeads)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead_state_id_fkey");

            entity.HasOne(d => d.Team).WithMany(p => p.CrmLeads)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead_team_id_fkey");

            entity.HasOne(d => d.TitleNavigation).WithMany(p => p.CrmLeads)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead_title_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.CrmLeadUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CrmLeadWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead_write_uid_fkey");

            entity.HasMany(d => d.Tags).WithMany(p => p.Leads)
                .UsingEntity<Dictionary<string, object>>(
                    "CrmTagRel",
                    r => r.HasOne<CrmTag>().WithMany()
                        .HasForeignKey("TagId")
                        .HasConstraintName("crm_tag_rel_tag_id_fkey"),
                    l => l.HasOne<CrmLead>().WithMany()
                        .HasForeignKey("LeadId")
                        .HasConstraintName("crm_tag_rel_lead_id_fkey"),
                    j =>
                    {
                        j.HasKey("LeadId", "TagId").HasName("crm_tag_rel_pkey");
                        j.ToTable("crm_tag_rel");
                        j.HasIndex(new[] { "TagId", "LeadId" }, "crm_tag_rel_tag_id_lead_id_idx");
                    });

            entity.HasMany(d => d.WebsiteVisitors).WithMany(p => p.CrmLeads)
                .UsingEntity<Dictionary<string, object>>(
                    "CrmLeadWebsiteVisitorRel",
                    r => r.HasOne<WebsiteVisitor>().WithMany()
                        .HasForeignKey("WebsiteVisitorId")
                        .HasConstraintName("crm_lead_website_visitor_rel_website_visitor_id_fkey"),
                    l => l.HasOne<CrmLead>().WithMany()
                        .HasForeignKey("CrmLeadId")
                        .HasConstraintName("crm_lead_website_visitor_rel_crm_lead_id_fkey"),
                    j =>
                    {
                        j.HasKey("CrmLeadId", "WebsiteVisitorId").HasName("crm_lead_website_visitor_rel_pkey");
                        j.ToTable("crm_lead_website_visitor_rel");
                        j.HasIndex(new[] { "WebsiteVisitorId", "CrmLeadId" }, "crm_lead_website_visitor_rel_website_visitor_id_crm_lead_id_idx");
                    });
        });

        modelBuilder.Entity<CrmLead2opportunityPartner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("crm_lead2opportunity_partner_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CrmLead2opportunityPartnerCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead2opportunity_partner_create_uid_fkey");

            entity.HasOne(d => d.Lead).WithMany(p => p.CrmLead2opportunityPartners)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("crm_lead2opportunity_partner_lead_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.CrmLead2opportunityPartners)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead2opportunity_partner_partner_id_fkey");

            entity.HasOne(d => d.Team).WithMany(p => p.CrmLead2opportunityPartners)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead2opportunity_partner_team_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.CrmLead2opportunityPartnerUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead2opportunity_partner_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CrmLead2opportunityPartnerWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead2opportunity_partner_write_uid_fkey");

            entity.HasMany(d => d.CrmLeads).WithMany(p => p.CrmLead2opportunityPartnersNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "CrmLeadCrmLead2opportunityPartnerRel",
                    r => r.HasOne<CrmLead>().WithMany()
                        .HasForeignKey("CrmLeadId")
                        .HasConstraintName("crm_lead_crm_lead2opportunity_partner_rel_crm_lead_id_fkey"),
                    l => l.HasOne<CrmLead2opportunityPartner>().WithMany()
                        .HasForeignKey("CrmLead2opportunityPartnerId")
                        .HasConstraintName("crm_lead_crm_lead2opportunity_crm_lead2opportunity_partner_fkey"),
                    j =>
                    {
                        j.HasKey("CrmLead2opportunityPartnerId", "CrmLeadId").HasName("crm_lead_crm_lead2opportunity_partner_rel_pkey");
                        j.ToTable("crm_lead_crm_lead2opportunity_partner_rel");
                        j.HasIndex(new[] { "CrmLeadId", "CrmLead2opportunityPartnerId" }, "crm_lead_crm_lead2opportunity_crm_lead_id_crm_lead2opportun_idx");
                    });
        });

        modelBuilder.Entity<CrmLead2opportunityPartnerMass>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("crm_lead2opportunity_partner_mass_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CrmLead2opportunityPartnerMassCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead2opportunity_partner_mass_create_uid_fkey");

            entity.HasOne(d => d.Lead).WithMany(p => p.CrmLead2opportunityPartnerMassesNavigation)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead2opportunity_partner_mass_lead_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.CrmLead2opportunityPartnerMasses)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead2opportunity_partner_mass_partner_id_fkey");

            entity.HasOne(d => d.Team).WithMany(p => p.CrmLead2opportunityPartnerMasses)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead2opportunity_partner_mass_team_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.CrmLead2opportunityPartnerMassUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead2opportunity_partner_mass_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CrmLead2opportunityPartnerMassWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead2opportunity_partner_mass_write_uid_fkey");

            entity.HasMany(d => d.CrmLeads).WithMany(p => p.CrmLead2opportunityPartnerMasses)
                .UsingEntity<Dictionary<string, object>>(
                    "CrmConvertLeadMassLeadRel",
                    r => r.HasOne<CrmLead>().WithMany()
                        .HasForeignKey("CrmLeadId")
                        .HasConstraintName("crm_convert_lead_mass_lead_rel_crm_lead_id_fkey"),
                    l => l.HasOne<CrmLead2opportunityPartnerMass>().WithMany()
                        .HasForeignKey("CrmLead2opportunityPartnerMassId")
                        .HasConstraintName("crm_convert_lead_mass_lead_re_crm_lead2opportunity_partner_fkey"),
                    j =>
                    {
                        j.HasKey("CrmLead2opportunityPartnerMassId", "CrmLeadId").HasName("crm_convert_lead_mass_lead_rel_pkey");
                        j.ToTable("crm_convert_lead_mass_lead_rel");
                        j.HasIndex(new[] { "CrmLeadId", "CrmLead2opportunityPartnerMassId" }, "crm_convert_lead_mass_lead_re_crm_lead_id_crm_lead2opportun_idx");
                    });

            entity.HasMany(d => d.CrmLeadsNavigation).WithMany(p => p.CrmLead2opportunityPartnerMasses1)
                .UsingEntity<Dictionary<string, object>>(
                    "CrmLeadCrmLead2opportunityPartnerMassRel",
                    r => r.HasOne<CrmLead>().WithMany()
                        .HasForeignKey("CrmLeadId")
                        .HasConstraintName("crm_lead_crm_lead2opportunity_partner_mass_rel_crm_lead_id_fkey"),
                    l => l.HasOne<CrmLead2opportunityPartnerMass>().WithMany()
                        .HasForeignKey("CrmLead2opportunityPartnerMassId")
                        .HasConstraintName("crm_lead_crm_lead2opportunit_crm_lead2opportunity_partner_fkey1"),
                    j =>
                    {
                        j.HasKey("CrmLead2opportunityPartnerMassId", "CrmLeadId").HasName("crm_lead_crm_lead2opportunity_partner_mass_rel_pkey");
                        j.ToTable("crm_lead_crm_lead2opportunity_partner_mass_rel");
                        j.HasIndex(new[] { "CrmLeadId", "CrmLead2opportunityPartnerMassId" }, "crm_lead_crm_lead2opportunity_crm_lead_id_crm_lead2opportu_idx1");
                    });

            entity.HasMany(d => d.ResUsers).WithMany(p => p.CrmLead2opportunityPartnerMasses)
                .UsingEntity<Dictionary<string, object>>(
                    "CrmLead2opportunityPartnerMassResUsersRel",
                    r => r.HasOne<ResUser>().WithMany()
                        .HasForeignKey("ResUsersId")
                        .HasConstraintName("crm_lead2opportunity_partner_mass_res_users_r_res_users_id_fkey"),
                    l => l.HasOne<CrmLead2opportunityPartnerMass>().WithMany()
                        .HasForeignKey("CrmLead2opportunityPartnerMassId")
                        .HasConstraintName("crm_lead2opportunity_partner__crm_lead2opportunity_partner_fkey"),
                    j =>
                    {
                        j.HasKey("CrmLead2opportunityPartnerMassId", "ResUsersId").HasName("crm_lead2opportunity_partner_mass_res_users_rel_pkey");
                        j.ToTable("crm_lead2opportunity_partner_mass_res_users_rel");
                        j.HasIndex(new[] { "ResUsersId", "CrmLead2opportunityPartnerMassId" }, "crm_lead2opportunity_partner__res_users_id_crm_lead2opportu_idx");
                    });
        });

        modelBuilder.Entity<CrmLeadLost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("crm_lead_lost_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CrmLeadLostCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead_lost_create_uid_fkey");

            entity.HasOne(d => d.LostReason).WithMany(p => p.CrmLeadLosts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead_lost_lost_reason_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CrmLeadLostWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead_lost_write_uid_fkey");
        });

        modelBuilder.Entity<CrmLeadPlsUpdate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("crm_lead_pls_update_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CrmLeadPlsUpdateCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead_pls_update_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CrmLeadPlsUpdateWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead_pls_update_write_uid_fkey");

            entity.HasMany(d => d.CrmLeadScoringFrequencyFields).WithMany(p => p.CrmLeadPlsUpdates)
                .UsingEntity<Dictionary<string, object>>(
                    "CrmLeadPlsUpdateCrmLeadScoringFrequencyFieldRel",
                    r => r.HasOne<CrmLeadScoringFrequencyField>().WithMany()
                        .HasForeignKey("CrmLeadScoringFrequencyFieldId")
                        .HasConstraintName("crm_lead_pls_update_crm_lead__crm_lead_scoring_frequency_f_fkey"),
                    l => l.HasOne<CrmLeadPlsUpdate>().WithMany()
                        .HasForeignKey("CrmLeadPlsUpdateId")
                        .HasConstraintName("crm_lead_pls_update_crm_lead_scorin_crm_lead_pls_update_id_fkey"),
                    j =>
                    {
                        j.HasKey("CrmLeadPlsUpdateId", "CrmLeadScoringFrequencyFieldId").HasName("crm_lead_pls_update_crm_lead_scoring_frequency_field_rel_pkey");
                        j.ToTable("crm_lead_pls_update_crm_lead_scoring_frequency_field_rel");
                        j.HasIndex(new[] { "CrmLeadScoringFrequencyFieldId", "CrmLeadPlsUpdateId" }, "crm_lead_pls_update_crm_lead__crm_lead_scoring_frequency_fi_idx");
                    });
        });

        modelBuilder.Entity<CrmLeadScoringFrequency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("crm_lead_scoring_frequency_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CrmLeadScoringFrequencyCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead_scoring_frequency_create_uid_fkey");

            entity.HasOne(d => d.Team).WithMany(p => p.CrmLeadScoringFrequencies)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("crm_lead_scoring_frequency_team_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CrmLeadScoringFrequencyWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead_scoring_frequency_write_uid_fkey");
        });

        modelBuilder.Entity<CrmLeadScoringFrequencyField>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("crm_lead_scoring_frequency_field_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CrmLeadScoringFrequencyFieldCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead_scoring_frequency_field_create_uid_fkey");

            entity.HasOne(d => d.Field).WithMany(p => p.CrmLeadScoringFrequencyFields)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("crm_lead_scoring_frequency_field_field_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CrmLeadScoringFrequencyFieldWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lead_scoring_frequency_field_write_uid_fkey");
        });

        modelBuilder.Entity<CrmLostReason>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("crm_lost_reason_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CrmLostReasonCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lost_reason_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CrmLostReasonWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_lost_reason_write_uid_fkey");
        });

        modelBuilder.Entity<CrmMergeOpportunity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("crm_merge_opportunity_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CrmMergeOpportunityCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_merge_opportunity_create_uid_fkey");

            entity.HasOne(d => d.Team).WithMany(p => p.CrmMergeOpportunities)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_merge_opportunity_team_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.CrmMergeOpportunityUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_merge_opportunity_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CrmMergeOpportunityWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_merge_opportunity_write_uid_fkey");

            entity.HasMany(d => d.Opportunities).WithMany(p => p.Merges)
                .UsingEntity<Dictionary<string, object>>(
                    "MergeOpportunityRel",
                    r => r.HasOne<CrmLead>().WithMany()
                        .HasForeignKey("OpportunityId")
                        .HasConstraintName("merge_opportunity_rel_opportunity_id_fkey"),
                    l => l.HasOne<CrmMergeOpportunity>().WithMany()
                        .HasForeignKey("MergeId")
                        .HasConstraintName("merge_opportunity_rel_merge_id_fkey"),
                    j =>
                    {
                        j.HasKey("MergeId", "OpportunityId").HasName("merge_opportunity_rel_pkey");
                        j.ToTable("merge_opportunity_rel");
                        j.HasIndex(new[] { "OpportunityId", "MergeId" }, "merge_opportunity_rel_opportunity_id_merge_id_idx");
                    });
        });

        modelBuilder.Entity<CrmQuotationPartner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("crm_quotation_partner_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CrmQuotationPartnerCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_quotation_partner_create_uid_fkey");

            entity.HasOne(d => d.Lead).WithMany(p => p.CrmQuotationPartners)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("crm_quotation_partner_lead_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.CrmQuotationPartners)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_quotation_partner_partner_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CrmQuotationPartnerWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_quotation_partner_write_uid_fkey");
        });

        modelBuilder.Entity<CrmRecurringPlan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("crm_recurring_plan_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.CrmRecurringPlanCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_recurring_plan_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CrmRecurringPlanWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_recurring_plan_write_uid_fkey");
        });

        modelBuilder.Entity<CrmStage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("crm_stage_pkey");

            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.CrmStageCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_stage_create_uid_fkey");

            entity.HasOne(d => d.Team).WithMany(p => p.CrmStages)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_stage_team_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CrmStageWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_stage_write_uid_fkey");
        });

        modelBuilder.Entity<CrmTag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("crm_tag_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CrmTagCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_tag_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CrmTagWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_tag_write_uid_fkey");
        });

        modelBuilder.Entity<CrmTeam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("crm_team_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Alias).WithMany(p => p.CrmTeams)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("crm_team_alias_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.CrmTeams)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_team_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CrmTeamCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_team_create_uid_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.CrmTeams)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_team_message_main_attachment_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.CrmTeamUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_team_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CrmTeamWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_team_write_uid_fkey");

            entity.HasMany(d => d.Users).WithMany(p => p.Teams)
                .UsingEntity<Dictionary<string, object>>(
                    "TeamFavoriteUserRel",
                    r => r.HasOne<ResUser>().WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("team_favorite_user_rel_user_id_fkey"),
                    l => l.HasOne<CrmTeam>().WithMany()
                        .HasForeignKey("TeamId")
                        .HasConstraintName("team_favorite_user_rel_team_id_fkey"),
                    j =>
                    {
                        j.HasKey("TeamId", "UserId").HasName("team_favorite_user_rel_pkey");
                        j.ToTable("team_favorite_user_rel");
                        j.HasIndex(new[] { "UserId", "TeamId" }, "team_favorite_user_rel_user_id_team_id_idx");
                    });
        });

        modelBuilder.Entity<CrmTeamMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("crm_team_member_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CrmTeamMemberCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_team_member_create_uid_fkey");

            entity.HasOne(d => d.CrmTeam).WithMany(p => p.CrmTeamMembers)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("crm_team_member_crm_team_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.CrmTeamMembers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_team_member_message_main_attachment_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.CrmTeamMemberUsers)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("crm_team_member_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CrmTeamMemberWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_team_member_write_uid_fkey");
        });

        modelBuilder.Entity<CrossoveredBudget>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("crossovered_budget_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.CrossoveredBudgets)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("crossovered_budget_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CrossoveredBudgetCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crossovered_budget_create_uid_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.CrossoveredBudgets)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crossovered_budget_message_main_attachment_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.CrossoveredBudgetUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crossovered_budget_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CrossoveredBudgetWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crossovered_budget_write_uid_fkey");
        });

        modelBuilder.Entity<CrossoveredBudgetLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("crossovered_budget_lines_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.AnalyticAccount).WithMany(p => p.CrossoveredBudgetLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crossovered_budget_lines_analytic_account_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.CrossoveredBudgetLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crossovered_budget_lines_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CrossoveredBudgetLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crossovered_budget_lines_create_uid_fkey");

            entity.HasOne(d => d.CrossoveredBudget).WithMany(p => p.CrossoveredBudgetLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("crossovered_budget_lines_crossovered_budget_id_fkey");

            entity.HasOne(d => d.GeneralBudget).WithMany(p => p.CrossoveredBudgetLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crossovered_budget_lines_general_budget_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CrossoveredBudgetLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crossovered_budget_lines_write_uid_fkey");
        });

        modelBuilder.Entity<DecimalPrecision>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("decimal_precision_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.DecimalPrecisionCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("decimal_precision_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.DecimalPrecisionWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("decimal_precision_write_uid_fkey");
        });

        modelBuilder.Entity<DigestDigest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("digest_digest_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.DigestDigests)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("digest_digest_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.DigestDigestCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("digest_digest_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.DigestDigestWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("digest_digest_write_uid_fkey");

            entity.HasMany(d => d.ResUsers).WithMany(p => p.DigestDigests)
                .UsingEntity<Dictionary<string, object>>(
                    "DigestDigestResUsersRel",
                    r => r.HasOne<ResUser>().WithMany()
                        .HasForeignKey("ResUsersId")
                        .HasConstraintName("digest_digest_res_users_rel_res_users_id_fkey"),
                    l => l.HasOne<DigestDigest>().WithMany()
                        .HasForeignKey("DigestDigestId")
                        .HasConstraintName("digest_digest_res_users_rel_digest_digest_id_fkey"),
                    j =>
                    {
                        j.HasKey("DigestDigestId", "ResUsersId").HasName("digest_digest_res_users_rel_pkey");
                        j.ToTable("digest_digest_res_users_rel");
                        j.HasIndex(new[] { "ResUsersId", "DigestDigestId" }, "digest_digest_res_users_rel_res_users_id_digest_digest_id_idx");
                    });
        });

        modelBuilder.Entity<DigestTip>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("digest_tip_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.DigestTipCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("digest_tip_create_uid_fkey");

            entity.HasOne(d => d.Group).WithMany(p => p.DigestTips)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("digest_tip_group_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.DigestTipWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("digest_tip_write_uid_fkey");

            entity.HasMany(d => d.ResUsers).WithMany(p => p.DigestTips)
                .UsingEntity<Dictionary<string, object>>(
                    "DigestTipResUsersRel",
                    r => r.HasOne<ResUser>().WithMany()
                        .HasForeignKey("ResUsersId")
                        .HasConstraintName("digest_tip_res_users_rel_res_users_id_fkey"),
                    l => l.HasOne<DigestTip>().WithMany()
                        .HasForeignKey("DigestTipId")
                        .HasConstraintName("digest_tip_res_users_rel_digest_tip_id_fkey"),
                    j =>
                    {
                        j.HasKey("DigestTipId", "ResUsersId").HasName("digest_tip_res_users_rel_pkey");
                        j.ToTable("digest_tip_res_users_rel");
                        j.HasIndex(new[] { "ResUsersId", "DigestTipId" }, "digest_tip_res_users_rel_res_users_id_digest_tip_id_idx");
                    });
        });

        modelBuilder.Entity<FetchmailServer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fetchmail_server_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.FetchmailServerCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fetchmail_server_create_uid_fkey");

            entity.HasOne(d => d.Object).WithMany(p => p.FetchmailServers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fetchmail_server_object_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.FetchmailServerWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fetchmail_server_write_uid_fkey");
        });

        modelBuilder.Entity<FleetServiceType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fleet_service_type_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.FleetServiceTypeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_service_type_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.FleetServiceTypeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_service_type_write_uid_fkey");
        });

        modelBuilder.Entity<FleetVehicle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fleet_vehicle_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Brand).WithMany(p => p.FleetVehicles)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_brand_id_fkey");

            entity.HasOne(d => d.Category).WithMany(p => p.FleetVehicles)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_category_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.FleetVehicles)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.FleetVehicleCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_create_uid_fkey");

            entity.HasOne(d => d.DriverEmployee).WithMany(p => p.FleetVehicleDriverEmployees)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_driver_employee_id_fkey");

            entity.HasOne(d => d.Driver).WithMany(p => p.FleetVehicleDrivers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_driver_id_fkey");

            entity.HasOne(d => d.FutureDriverEmployee).WithMany(p => p.FleetVehicleFutureDriverEmployees)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_future_driver_employee_id_fkey");

            entity.HasOne(d => d.FutureDriver).WithMany(p => p.FleetVehicleFutureDrivers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_future_driver_id_fkey");

            entity.HasOne(d => d.Manager).WithMany(p => p.FleetVehicleManagers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_manager_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.FleetVehicles)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Model).WithMany(p => p.FleetVehicles)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fleet_vehicle_model_id_fkey");

            entity.HasOne(d => d.State).WithMany(p => p.FleetVehicles)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_state_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.FleetVehicleWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_write_uid_fkey");

            entity.HasMany(d => d.Tags).WithMany(p => p.VehicleTags)
                .UsingEntity<Dictionary<string, object>>(
                    "FleetVehicleVehicleTagRel",
                    r => r.HasOne<FleetVehicleTag>().WithMany()
                        .HasForeignKey("TagId")
                        .HasConstraintName("fleet_vehicle_vehicle_tag_rel_tag_id_fkey"),
                    l => l.HasOne<FleetVehicle>().WithMany()
                        .HasForeignKey("VehicleTagId")
                        .HasConstraintName("fleet_vehicle_vehicle_tag_rel_vehicle_tag_id_fkey"),
                    j =>
                    {
                        j.HasKey("VehicleTagId", "TagId").HasName("fleet_vehicle_vehicle_tag_rel_pkey");
                        j.ToTable("fleet_vehicle_vehicle_tag_rel");
                        j.HasIndex(new[] { "TagId", "VehicleTagId" }, "fleet_vehicle_vehicle_tag_rel_tag_id_vehicle_tag_id_idx");
                    });
        });

        modelBuilder.Entity<FleetVehicleAssignationLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fleet_vehicle_assignation_log_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.FleetVehicleAssignationLogCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_assignation_log_create_uid_fkey");

            entity.HasOne(d => d.DriverEmployee).WithMany(p => p.FleetVehicleAssignationLogs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_assignation_log_driver_employee_id_fkey");

            entity.HasOne(d => d.Driver).WithMany(p => p.FleetVehicleAssignationLogs)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fleet_vehicle_assignation_log_driver_id_fkey");

            entity.HasOne(d => d.Vehicle).WithMany(p => p.FleetVehicleAssignationLogs)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fleet_vehicle_assignation_log_vehicle_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.FleetVehicleAssignationLogWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_assignation_log_write_uid_fkey");
        });

        modelBuilder.Entity<FleetVehicleLogContract>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fleet_vehicle_log_contract_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.FleetVehicleLogContracts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_log_contract_company_id_fkey");

            entity.HasOne(d => d.CostSubtype).WithMany(p => p.FleetVehicleLogContractsNavigation)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_log_contract_cost_subtype_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.FleetVehicleLogContractCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_log_contract_create_uid_fkey");

            entity.HasOne(d => d.Insurer).WithMany(p => p.FleetVehicleLogContracts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_log_contract_insurer_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.FleetVehicleLogContracts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_log_contract_message_main_attachment_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.FleetVehicleLogContractUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_log_contract_user_id_fkey");

            entity.HasOne(d => d.Vehicle).WithMany(p => p.FleetVehicleLogContracts)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fleet_vehicle_log_contract_vehicle_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.FleetVehicleLogContractWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_log_contract_write_uid_fkey");

            entity.HasMany(d => d.FleetServiceTypes).WithMany(p => p.FleetVehicleLogContracts)
                .UsingEntity<Dictionary<string, object>>(
                    "FleetServiceTypeFleetVehicleLogContractRel",
                    r => r.HasOne<FleetServiceType>().WithMany()
                        .HasForeignKey("FleetServiceTypeId")
                        .HasConstraintName("fleet_service_type_fleet_vehicle_log_fleet_service_type_id_fkey"),
                    l => l.HasOne<FleetVehicleLogContract>().WithMany()
                        .HasForeignKey("FleetVehicleLogContractId")
                        .HasConstraintName("fleet_service_type_fleet_vehi_fleet_vehicle_log_contract_i_fkey"),
                    j =>
                    {
                        j.HasKey("FleetVehicleLogContractId", "FleetServiceTypeId").HasName("fleet_service_type_fleet_vehicle_log_contract_rel_pkey");
                        j.ToTable("fleet_service_type_fleet_vehicle_log_contract_rel");
                        j.HasIndex(new[] { "FleetServiceTypeId", "FleetVehicleLogContractId" }, "fleet_service_type_fleet_vehi_fleet_service_type_id_fleet_v_idx");
                    });
        });

        modelBuilder.Entity<FleetVehicleLogService>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fleet_vehicle_log_services_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.FleetVehicleLogServices)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_log_services_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.FleetVehicleLogServiceCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_log_services_create_uid_fkey");

            entity.HasOne(d => d.Manager).WithMany(p => p.FleetVehicleLogServiceManagers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_log_services_manager_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.FleetVehicleLogServices)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_log_services_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Odometer).WithMany(p => p.FleetVehicleLogServices)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_log_services_odometer_id_fkey");

            entity.HasOne(d => d.PurchaserEmployee).WithMany(p => p.FleetVehicleLogServices)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_log_services_purchaser_employee_id_fkey");

            entity.HasOne(d => d.Purchaser).WithMany(p => p.FleetVehicleLogServicePurchasers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_log_services_purchaser_id_fkey");

            entity.HasOne(d => d.ServiceType).WithMany(p => p.FleetVehicleLogServices)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fleet_vehicle_log_services_service_type_id_fkey");

            entity.HasOne(d => d.Vehicle).WithMany(p => p.FleetVehicleLogServices)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fleet_vehicle_log_services_vehicle_id_fkey");

            entity.HasOne(d => d.Vendor).WithMany(p => p.FleetVehicleLogServiceVendors)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_log_services_vendor_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.FleetVehicleLogServiceWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_log_services_write_uid_fkey");
        });

        modelBuilder.Entity<FleetVehicleModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fleet_vehicle_model_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Brand).WithMany(p => p.FleetVehicleModels)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fleet_vehicle_model_brand_id_fkey");

            entity.HasOne(d => d.Category).WithMany(p => p.FleetVehicleModels)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_model_category_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.FleetVehicleModelCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_model_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.FleetVehicleModelWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_model_write_uid_fkey");

            entity.HasMany(d => d.Partners).WithMany(p => p.Models)
                .UsingEntity<Dictionary<string, object>>(
                    "FleetVehicleModelVendor",
                    r => r.HasOne<ResPartner>().WithMany()
                        .HasForeignKey("PartnerId")
                        .HasConstraintName("fleet_vehicle_model_vendors_partner_id_fkey"),
                    l => l.HasOne<FleetVehicleModel>().WithMany()
                        .HasForeignKey("ModelId")
                        .HasConstraintName("fleet_vehicle_model_vendors_model_id_fkey"),
                    j =>
                    {
                        j.HasKey("ModelId", "PartnerId").HasName("fleet_vehicle_model_vendors_pkey");
                        j.ToTable("fleet_vehicle_model_vendors");
                        j.HasIndex(new[] { "PartnerId", "ModelId" }, "fleet_vehicle_model_vendors_partner_id_model_id_idx");
                    });
        });

        modelBuilder.Entity<FleetVehicleModelBrand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fleet_vehicle_model_brand_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.FleetVehicleModelBrandCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_model_brand_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.FleetVehicleModelBrandWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_model_brand_write_uid_fkey");
        });

        modelBuilder.Entity<FleetVehicleModelCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fleet_vehicle_model_category_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.FleetVehicleModelCategoryCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_model_category_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.FleetVehicleModelCategoryWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_model_category_write_uid_fkey");
        });

        modelBuilder.Entity<FleetVehicleOdometer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fleet_vehicle_odometer_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.FleetVehicleOdometerCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_odometer_create_uid_fkey");

            entity.HasOne(d => d.Vehicle).WithMany(p => p.FleetVehicleOdometers)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fleet_vehicle_odometer_vehicle_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.FleetVehicleOdometerWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_odometer_write_uid_fkey");
        });

        modelBuilder.Entity<FleetVehicleState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fleet_vehicle_state_pkey");

            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.FleetVehicleStateCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_state_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.FleetVehicleStateWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_state_write_uid_fkey");
        });

        modelBuilder.Entity<FleetVehicleTag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fleet_vehicle_tag_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.FleetVehicleTagCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_tag_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.FleetVehicleTagWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fleet_vehicle_tag_write_uid_fkey");
        });

        modelBuilder.Entity<FollowupFollowup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("followup_followup_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithOne(p => p.FollowupFollowup)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("followup_followup_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.FollowupFollowupCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("followup_followup_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.FollowupFollowupWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("followup_followup_write_uid_fkey");
        });

        modelBuilder.Entity<FollowupLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("followup_line_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.FollowupLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("followup_line_create_uid_fkey");

            entity.HasOne(d => d.EmailTemplate).WithMany(p => p.FollowupLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("followup_line_email_template_id_fkey");

            entity.HasOne(d => d.Followup).WithMany(p => p.FollowupLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("followup_line_followup_id_fkey");

            entity.HasOne(d => d.ManualActionResponsible).WithMany(p => p.FollowupLineManualActionResponsibles)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("followup_line_manual_action_responsible_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.FollowupLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("followup_line_write_uid_fkey");
        });

        modelBuilder.Entity<FollowupPrint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("followup_print_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.FollowupPrintCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("followup_print_create_uid_fkey");

            entity.HasOne(d => d.Followup).WithMany(p => p.FollowupPrints)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("followup_print_followup_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.FollowupPrintWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("followup_print_write_uid_fkey");
        });

        modelBuilder.Entity<FollowupSendingResult>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("followup_sending_results_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.FollowupSendingResultCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("followup_sending_results_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.FollowupSendingResultWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("followup_sending_results_write_uid_fkey");
        });

        modelBuilder.Entity<HrApplicant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_applicant_pkey");

            entity.HasIndex(e => e.Name, "hr_applicant_name_index")
                .HasMethod("gin")
                .HasOperators(new[] { "gin_trgm_ops" });

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Campaign).WithMany(p => p.HrApplicants)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_applicant_campaign_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.HrApplicants)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_applicant_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrApplicantCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_applicant_create_uid_fkey");

            entity.HasOne(d => d.Department).WithMany(p => p.HrApplicants)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_applicant_department_id_fkey");

            entity.HasOne(d => d.Emp).WithMany(p => p.HrApplicants)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_applicant_emp_id_fkey");

            entity.HasOne(d => d.Job).WithMany(p => p.HrApplicants)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_applicant_job_id_fkey");

            entity.HasOne(d => d.LastStage).WithMany(p => p.HrApplicantLastStages)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_applicant_last_stage_id_fkey");

            entity.HasOne(d => d.Medium).WithMany(p => p.HrApplicants)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_applicant_medium_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.HrApplicants)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_applicant_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.HrApplicants)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_applicant_partner_id_fkey");

            entity.HasOne(d => d.RefuseReason).WithMany(p => p.HrApplicants)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_applicant_refuse_reason_id_fkey");

            entity.HasOne(d => d.Source).WithMany(p => p.HrApplicants)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_applicant_source_id_fkey");

            entity.HasOne(d => d.Stage).WithMany(p => p.HrApplicantStages)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_applicant_stage_id_fkey");

            entity.HasOne(d => d.Type).WithMany(p => p.HrApplicants)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_applicant_type_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.HrApplicantUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_applicant_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrApplicantWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_applicant_write_uid_fkey");

            entity.HasMany(d => d.HrApplicantCategories).WithMany(p => p.HrApplicants)
                .UsingEntity<Dictionary<string, object>>(
                    "HrApplicantHrApplicantCategoryRel",
                    r => r.HasOne<HrApplicantCategory>().WithMany()
                        .HasForeignKey("HrApplicantCategoryId")
                        .HasConstraintName("hr_applicant_hr_applicant_categor_hr_applicant_category_id_fkey"),
                    l => l.HasOne<HrApplicant>().WithMany()
                        .HasForeignKey("HrApplicantId")
                        .HasConstraintName("hr_applicant_hr_applicant_category_rel_hr_applicant_id_fkey"),
                    j =>
                    {
                        j.HasKey("HrApplicantId", "HrApplicantCategoryId").HasName("hr_applicant_hr_applicant_category_rel_pkey");
                        j.ToTable("hr_applicant_hr_applicant_category_rel");
                        j.HasIndex(new[] { "HrApplicantCategoryId", "HrApplicantId" }, "hr_applicant_hr_applicant_cat_hr_applicant_category_id_hr_a_idx");
                    });

            entity.HasMany(d => d.HrSkills).WithMany(p => p.HrApplicants)
                .UsingEntity<Dictionary<string, object>>(
                    "HrApplicantHrSkillRel",
                    r => r.HasOne<HrSkill>().WithMany()
                        .HasForeignKey("HrSkillId")
                        .HasConstraintName("hr_applicant_hr_skill_rel_hr_skill_id_fkey"),
                    l => l.HasOne<HrApplicant>().WithMany()
                        .HasForeignKey("HrApplicantId")
                        .HasConstraintName("hr_applicant_hr_skill_rel_hr_applicant_id_fkey"),
                    j =>
                    {
                        j.HasKey("HrApplicantId", "HrSkillId").HasName("hr_applicant_hr_skill_rel_pkey");
                        j.ToTable("hr_applicant_hr_skill_rel");
                        j.HasIndex(new[] { "HrSkillId", "HrApplicantId" }, "hr_applicant_hr_skill_rel_hr_skill_id_hr_applicant_id_idx");
                    });

            entity.HasMany(d => d.ResUsers).WithMany(p => p.HrApplicants)
                .UsingEntity<Dictionary<string, object>>(
                    "HrApplicantResUsersInterviewersRel",
                    r => r.HasOne<ResUser>().WithMany()
                        .HasForeignKey("ResUsersId")
                        .HasConstraintName("hr_applicant_res_users_interviewers_rel_res_users_id_fkey"),
                    l => l.HasOne<HrApplicant>().WithMany()
                        .HasForeignKey("HrApplicantId")
                        .HasConstraintName("hr_applicant_res_users_interviewers_rel_hr_applicant_id_fkey"),
                    j =>
                    {
                        j.HasKey("HrApplicantId", "ResUsersId").HasName("hr_applicant_res_users_interviewers_rel_pkey");
                        j.ToTable("hr_applicant_res_users_interviewers_rel");
                        j.HasIndex(new[] { "ResUsersId", "HrApplicantId" }, "hr_applicant_res_users_intervi_res_users_id_hr_applicant_id_idx");
                    });
        });

        modelBuilder.Entity<HrApplicantCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_applicant_category_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrApplicantCategoryCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_applicant_category_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrApplicantCategoryWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_applicant_category_write_uid_fkey");
        });

        modelBuilder.Entity<HrApplicantRefuseReason>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_applicant_refuse_reason_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrApplicantRefuseReasonCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_applicant_refuse_reason_create_uid_fkey");

            entity.HasOne(d => d.Template).WithMany(p => p.HrApplicantRefuseReasons)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_applicant_refuse_reason_template_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrApplicantRefuseReasonWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_applicant_refuse_reason_write_uid_fkey");
        });

        modelBuilder.Entity<HrApplicantSkill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_applicant_skill_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Applicant).WithMany(p => p.HrApplicantSkills)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("hr_applicant_skill_applicant_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrApplicantSkillCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_applicant_skill_create_uid_fkey");

            entity.HasOne(d => d.Skill).WithMany(p => p.HrApplicantSkills)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_applicant_skill_skill_id_fkey");

            entity.HasOne(d => d.SkillLevel).WithMany(p => p.HrApplicantSkills)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_applicant_skill_skill_level_id_fkey");

            entity.HasOne(d => d.SkillType).WithMany(p => p.HrApplicantSkills)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_applicant_skill_skill_type_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrApplicantSkillWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_applicant_skill_write_uid_fkey");
        });

        modelBuilder.Entity<HrAttendance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_attendance_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrAttendanceCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_attendance_create_uid_fkey");

            entity.HasOne(d => d.Employee).WithMany(p => p.HrAttendances)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("hr_attendance_employee_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrAttendanceWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_attendance_write_uid_fkey");
        });

        modelBuilder.Entity<HrAttendanceOvertime>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_attendance_overtime_pkey");

            entity.HasIndex(e => new { e.EmployeeId, e.Date }, "hr_attendance_overtime_unique_employee_per_day")
                .IsUnique()
                .HasFilter("(adjustment IS FALSE)");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrAttendanceOvertimeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_attendance_overtime_create_uid_fkey");

            entity.HasOne(d => d.Employee).WithMany(p => p.HrAttendanceOvertimes)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("hr_attendance_overtime_employee_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrAttendanceOvertimeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_attendance_overtime_write_uid_fkey");
        });

        modelBuilder.Entity<HrContract>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_contract_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.HrContracts)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_contract_company_id_fkey");

            entity.HasOne(d => d.ContractType).WithMany(p => p.HrContracts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_contract_contract_type_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrContractCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_contract_create_uid_fkey");

            entity.HasOne(d => d.Department).WithMany(p => p.HrContracts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_contract_department_id_fkey");

            entity.HasOne(d => d.Employee).WithMany(p => p.HrContracts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_contract_employee_id_fkey");

            entity.HasOne(d => d.HrResponsible).WithMany(p => p.HrContractHrResponsibles)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_contract_hr_responsible_id_fkey");

            entity.HasOne(d => d.Job).WithMany(p => p.HrContracts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_contract_job_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.HrContracts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_contract_message_main_attachment_id_fkey");

            entity.HasOne(d => d.ResourceCalendar).WithMany(p => p.HrContracts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_contract_resource_calendar_id_fkey");

            entity.HasOne(d => d.StructureType).WithMany(p => p.HrContracts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_contract_structure_type_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrContractWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_contract_write_uid_fkey");
        });

        modelBuilder.Entity<HrContractType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_contract_type_pkey");

            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrContractTypeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_contract_type_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrContractTypeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_contract_type_write_uid_fkey");
        });

        modelBuilder.Entity<HrDepartment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_department_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.HrDepartments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_department_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrDepartmentCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_department_create_uid_fkey");

            entity.HasOne(d => d.Manager).WithMany(p => p.HrDepartments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_department_manager_id_fkey");

            entity.HasOne(d => d.MasterDepartment).WithMany(p => p.InverseMasterDepartment)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_department_master_department_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.HrDepartments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_department_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_department_parent_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrDepartmentWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_department_write_uid_fkey");
        });

        modelBuilder.Entity<HrDepartureReason>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_departure_reason_pkey");

            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrDepartureReasonCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_departure_reason_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrDepartureReasonWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_departure_reason_write_uid_fkey");
        });

        modelBuilder.Entity<HrDepartureWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_departure_wizard_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrDepartureWizardCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_departure_wizard_create_uid_fkey");

            entity.HasOne(d => d.DepartureReason).WithMany(p => p.HrDepartureWizards)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("hr_departure_wizard_departure_reason_id_fkey");

            entity.HasOne(d => d.Employee).WithMany(p => p.HrDepartureWizards)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("hr_departure_wizard_employee_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrDepartureWizardWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_departure_wizard_write_uid_fkey");
        });

        modelBuilder.Entity<HrEmployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_employee_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.AddressHome).WithMany(p => p.HrEmployeeAddressHomes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_address_home_id_fkey");

            entity.HasOne(d => d.Address).WithMany(p => p.HrEmployeeAddresses)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_address_id_fkey");

            entity.HasOne(d => d.BankAccount).WithMany(p => p.HrEmployees)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_bank_account_id_fkey");

            entity.HasOne(d => d.Coach).WithMany(p => p.InverseCoach)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_coach_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.HrEmployees)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_company_id_fkey");

            entity.HasOne(d => d.Contract).WithMany(p => p.HrEmployees)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_contract_id_fkey");

            entity.HasOne(d => d.Country).WithMany(p => p.HrEmployeeCountries)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_country_id_fkey");

            entity.HasOne(d => d.CountryOfBirthNavigation).WithMany(p => p.HrEmployeeCountryOfBirthNavigations)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_country_of_birth_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrEmployeeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_create_uid_fkey");

            entity.HasOne(d => d.Department).WithMany(p => p.HrEmployees)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_department_id_fkey");

            entity.HasOne(d => d.DepartureReason).WithMany(p => p.HrEmployees)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_employee_departure_reason_id_fkey");

            entity.HasOne(d => d.ExpenseManager).WithMany(p => p.HrEmployeeExpenseManagers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_expense_manager_id_fkey");

            entity.HasOne(d => d.Job).WithMany(p => p.HrEmployees)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_job_id_fkey");

            entity.HasOne(d => d.LastAttendance).WithMany(p => p.HrEmployees)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_last_attendance_id_fkey");

            entity.HasOne(d => d.LeaveManager).WithMany(p => p.HrEmployeeLeaveManagers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_leave_manager_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.HrEmployees)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_parent_id_fkey");

            entity.HasOne(d => d.ResourceCalendar).WithMany(p => p.HrEmployees)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_resource_calendar_id_fkey");

            entity.HasOne(d => d.Resource).WithMany(p => p.HrEmployees)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_employee_resource_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.HrEmployeeUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_user_id_fkey");

            entity.HasOne(d => d.WorkContact).WithMany(p => p.HrEmployeeWorkContacts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_work_contact_id_fkey");

            entity.HasOne(d => d.WorkLocation).WithMany(p => p.HrEmployees)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_work_location_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrEmployeeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_write_uid_fkey");

            entity.HasMany(d => d.Categories).WithMany(p => p.Emps)
                .UsingEntity<Dictionary<string, object>>(
                    "EmployeeCategoryRel",
                    r => r.HasOne<HrEmployeeCategory>().WithMany()
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("employee_category_rel_category_id_fkey"),
                    l => l.HasOne<HrEmployee>().WithMany()
                        .HasForeignKey("EmpId")
                        .HasConstraintName("employee_category_rel_emp_id_fkey"),
                    j =>
                    {
                        j.HasKey("EmpId", "CategoryId").HasName("employee_category_rel_pkey");
                        j.ToTable("employee_category_rel");
                        j.HasIndex(new[] { "CategoryId", "EmpId" }, "employee_category_rel_category_id_emp_id_idx");
                    });

            entity.HasMany(d => d.HrSkills).WithMany(p => p.HrEmployees)
                .UsingEntity<Dictionary<string, object>>(
                    "HrEmployeeHrSkillRel",
                    r => r.HasOne<HrSkill>().WithMany()
                        .HasForeignKey("HrSkillId")
                        .HasConstraintName("hr_employee_hr_skill_rel_hr_skill_id_fkey"),
                    l => l.HasOne<HrEmployee>().WithMany()
                        .HasForeignKey("HrEmployeeId")
                        .HasConstraintName("hr_employee_hr_skill_rel_hr_employee_id_fkey"),
                    j =>
                    {
                        j.HasKey("HrEmployeeId", "HrSkillId").HasName("hr_employee_hr_skill_rel_pkey");
                        j.ToTable("hr_employee_hr_skill_rel");
                        j.HasIndex(new[] { "HrSkillId", "HrEmployeeId" }, "hr_employee_hr_skill_rel_hr_skill_id_hr_employee_id_idx");
                    });
        });

        modelBuilder.Entity<HrEmployeeCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_employee_category_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrEmployeeCategoryCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_category_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrEmployeeCategoryWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_category_write_uid_fkey");
        });

        modelBuilder.Entity<HrEmployeeSkill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_employee_skill_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrEmployeeSkillCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_skill_create_uid_fkey");

            entity.HasOne(d => d.Employee).WithMany(p => p.HrEmployeeSkills)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("hr_employee_skill_employee_id_fkey");

            entity.HasOne(d => d.Skill).WithMany(p => p.HrEmployeeSkills)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_employee_skill_skill_id_fkey");

            entity.HasOne(d => d.SkillLevel).WithMany(p => p.HrEmployeeSkills)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_employee_skill_skill_level_id_fkey");

            entity.HasOne(d => d.SkillType).WithMany(p => p.HrEmployeeSkills)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_employee_skill_skill_type_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrEmployeeSkillWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_skill_write_uid_fkey");
        });

        modelBuilder.Entity<HrEmployeeSkillLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_employee_skill_log_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrEmployeeSkillLogCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_skill_log_create_uid_fkey");

            entity.HasOne(d => d.Department).WithMany(p => p.HrEmployeeSkillLogs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_skill_log_department_id_fkey");

            entity.HasOne(d => d.Employee).WithMany(p => p.HrEmployeeSkillLogs)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("hr_employee_skill_log_employee_id_fkey");

            entity.HasOne(d => d.Skill).WithMany(p => p.HrEmployeeSkillLogs)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_employee_skill_log_skill_id_fkey");

            entity.HasOne(d => d.SkillLevel).WithMany(p => p.HrEmployeeSkillLogs)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_employee_skill_log_skill_level_id_fkey");

            entity.HasOne(d => d.SkillType).WithMany(p => p.HrEmployeeSkillLogs)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_employee_skill_log_skill_type_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrEmployeeSkillLogWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_skill_log_write_uid_fkey");
        });

        modelBuilder.Entity<HrExpense>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_expense_pkey");

            entity.HasIndex(e => e.AnalyticDistribution, "hr_expense_analytic_distribution_gin_index").HasMethod("gin");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Account).WithMany(p => p.HrExpenses)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_account_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.HrExpenses)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_expense_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrExpenseCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.HrExpenses)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_expense_currency_id_fkey");

            entity.HasOne(d => d.Employee).WithMany(p => p.HrExpenses)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_expense_employee_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.HrExpenses)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.HrExpenses)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_expense_product_id_fkey");

            entity.HasOne(d => d.ProductUom).WithMany(p => p.HrExpenses)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_product_uom_id_fkey");

            entity.HasOne(d => d.SaleOrder).WithMany(p => p.HrExpenses)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_sale_order_id_fkey");

            entity.HasOne(d => d.Sheet).WithMany(p => p.HrExpenses)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_sheet_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrExpenseWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_write_uid_fkey");

            entity.HasMany(d => d.Taxes).WithMany(p => p.Expenses)
                .UsingEntity<Dictionary<string, object>>(
                    "ExpenseTax",
                    r => r.HasOne<AccountTax>().WithMany()
                        .HasForeignKey("TaxId")
                        .HasConstraintName("expense_tax_tax_id_fkey"),
                    l => l.HasOne<HrExpense>().WithMany()
                        .HasForeignKey("ExpenseId")
                        .HasConstraintName("expense_tax_expense_id_fkey"),
                    j =>
                    {
                        j.HasKey("ExpenseId", "TaxId").HasName("expense_tax_pkey");
                        j.ToTable("expense_tax");
                        j.HasIndex(new[] { "TaxId", "ExpenseId" }, "expense_tax_tax_id_expense_id_idx");
                    });
        });

        modelBuilder.Entity<HrExpenseApproveDuplicate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_expense_approve_duplicate_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrExpenseApproveDuplicateCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_approve_duplicate_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrExpenseApproveDuplicateWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_approve_duplicate_write_uid_fkey");

            entity.HasMany(d => d.HrExpenseSheets).WithMany(p => p.HrExpenseApproveDuplicates)
                .UsingEntity<Dictionary<string, object>>(
                    "HrExpenseApproveDuplicateHrExpenseSheetRel",
                    r => r.HasOne<HrExpenseSheet>().WithMany()
                        .HasForeignKey("HrExpenseSheetId")
                        .HasConstraintName("hr_expense_approve_duplicate_hr_expens_hr_expense_sheet_id_fkey"),
                    l => l.HasOne<HrExpenseApproveDuplicate>().WithMany()
                        .HasForeignKey("HrExpenseApproveDuplicateId")
                        .HasConstraintName("hr_expense_approve_duplicate__hr_expense_approve_duplicate_fkey"),
                    j =>
                    {
                        j.HasKey("HrExpenseApproveDuplicateId", "HrExpenseSheetId").HasName("hr_expense_approve_duplicate_hr_expense_sheet_rel_pkey");
                        j.ToTable("hr_expense_approve_duplicate_hr_expense_sheet_rel");
                        j.HasIndex(new[] { "HrExpenseSheetId", "HrExpenseApproveDuplicateId" }, "hr_expense_approve_duplicate__hr_expense_sheet_id_hr_expens_idx");
                    });

            entity.HasMany(d => d.HrExpenses).WithMany(p => p.HrExpenseApproveDuplicates)
                .UsingEntity<Dictionary<string, object>>(
                    "HrExpenseHrExpenseApproveDuplicateRel",
                    r => r.HasOne<HrExpense>().WithMany()
                        .HasForeignKey("HrExpenseId")
                        .HasConstraintName("hr_expense_hr_expense_approve_duplicate_rel_hr_expense_id_fkey"),
                    l => l.HasOne<HrExpenseApproveDuplicate>().WithMany()
                        .HasForeignKey("HrExpenseApproveDuplicateId")
                        .HasConstraintName("hr_expense_hr_expense_approve_hr_expense_approve_duplicate_fkey"),
                    j =>
                    {
                        j.HasKey("HrExpenseApproveDuplicateId", "HrExpenseId").HasName("hr_expense_hr_expense_approve_duplicate_rel_pkey");
                        j.ToTable("hr_expense_hr_expense_approve_duplicate_rel");
                        j.HasIndex(new[] { "HrExpenseId", "HrExpenseApproveDuplicateId" }, "hr_expense_hr_expense_approve_hr_expense_id_hr_expense_appr_idx");
                    });
        });

        modelBuilder.Entity<HrExpenseRefuseWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_expense_refuse_wizard_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrExpenseRefuseWizardCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_refuse_wizard_create_uid_fkey");

            entity.HasOne(d => d.HrExpenseSheet).WithMany(p => p.HrExpenseRefuseWizards)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_refuse_wizard_hr_expense_sheet_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrExpenseRefuseWizardWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_refuse_wizard_write_uid_fkey");

            entity.HasMany(d => d.HrExpenses).WithMany(p => p.HrExpenseRefuseWizards)
                .UsingEntity<Dictionary<string, object>>(
                    "HrExpenseHrExpenseRefuseWizardRel",
                    r => r.HasOne<HrExpense>().WithMany()
                        .HasForeignKey("HrExpenseId")
                        .HasConstraintName("hr_expense_hr_expense_refuse_wizard_rel_hr_expense_id_fkey"),
                    l => l.HasOne<HrExpenseRefuseWizard>().WithMany()
                        .HasForeignKey("HrExpenseRefuseWizardId")
                        .HasConstraintName("hr_expense_hr_expense_refuse_w_hr_expense_refuse_wizard_id_fkey"),
                    j =>
                    {
                        j.HasKey("HrExpenseRefuseWizardId", "HrExpenseId").HasName("hr_expense_hr_expense_refuse_wizard_rel_pkey");
                        j.ToTable("hr_expense_hr_expense_refuse_wizard_rel");
                        j.HasIndex(new[] { "HrExpenseId", "HrExpenseRefuseWizardId" }, "hr_expense_hr_expense_refuse__hr_expense_id_hr_expense_refu_idx");
                    });
        });

        modelBuilder.Entity<HrExpenseSheet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_expense_sheet_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.AccountMove).WithMany(p => p.HrExpenseSheets)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_expense_sheet_account_move_id_fkey");

            entity.HasOne(d => d.Address).WithMany(p => p.HrExpenseSheets)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_sheet_address_id_fkey");

            entity.HasOne(d => d.BankJournal).WithMany(p => p.HrExpenseSheetBankJournals)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_sheet_bank_journal_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.HrExpenseSheets)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_expense_sheet_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrExpenseSheetCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_sheet_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.HrExpenseSheets)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_sheet_currency_id_fkey");

            entity.HasOne(d => d.Department).WithMany(p => p.HrExpenseSheets)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_sheet_department_id_fkey");

            entity.HasOne(d => d.Employee).WithMany(p => p.HrExpenseSheets)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_expense_sheet_employee_id_fkey");

            entity.HasOne(d => d.Journal).WithMany(p => p.HrExpenseSheetJournals)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_sheet_journal_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.HrExpenseSheets)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_sheet_message_main_attachment_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.HrExpenseSheetUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_sheet_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrExpenseSheetWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_sheet_write_uid_fkey");
        });

        modelBuilder.Entity<HrExpenseSplit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_expense_split_pkey");

            entity.HasIndex(e => e.AnalyticDistribution, "hr_expense_split_analytic_distribution_gin_index").HasMethod("gin");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.HrExpenseSplits)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_split_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrExpenseSplitCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_split_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.HrExpenseSplits)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_split_currency_id_fkey");

            entity.HasOne(d => d.Employee).WithMany(p => p.HrExpenseSplits)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("hr_expense_split_employee_id_fkey");

            entity.HasOne(d => d.Expense).WithMany(p => p.HrExpenseSplits)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_split_expense_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.HrExpenseSplits)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("hr_expense_split_product_id_fkey");

            entity.HasOne(d => d.SaleOrder).WithMany(p => p.HrExpenseSplits)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_split_sale_order_id_fkey");

            entity.HasOne(d => d.Wizard).WithMany(p => p.HrExpenseSplits)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_split_wizard_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrExpenseSplitWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_split_write_uid_fkey");

            entity.HasMany(d => d.AccountTaxes).WithMany(p => p.HrExpenseSplits)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountTaxHrExpenseSplitRel",
                    r => r.HasOne<AccountTax>().WithMany()
                        .HasForeignKey("AccountTaxId")
                        .HasConstraintName("account_tax_hr_expense_split_rel_account_tax_id_fkey"),
                    l => l.HasOne<HrExpenseSplit>().WithMany()
                        .HasForeignKey("HrExpenseSplitId")
                        .HasConstraintName("account_tax_hr_expense_split_rel_hr_expense_split_id_fkey"),
                    j =>
                    {
                        j.HasKey("HrExpenseSplitId", "AccountTaxId").HasName("account_tax_hr_expense_split_rel_pkey");
                        j.ToTable("account_tax_hr_expense_split_rel");
                        j.HasIndex(new[] { "AccountTaxId", "HrExpenseSplitId" }, "account_tax_hr_expense_split__account_tax_id_hr_expense_spl_idx");
                    });
        });

        modelBuilder.Entity<HrExpenseSplitWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_expense_split_wizard_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrExpenseSplitWizardCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_split_wizard_create_uid_fkey");

            entity.HasOne(d => d.Expense).WithMany(p => p.HrExpenseSplitWizards)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("hr_expense_split_wizard_expense_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrExpenseSplitWizardWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_expense_split_wizard_write_uid_fkey");
        });

        modelBuilder.Entity<HrHolidaysCancelLeave>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_holidays_cancel_leave_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrHolidaysCancelLeaveCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_holidays_cancel_leave_create_uid_fkey");

            entity.HasOne(d => d.Leave).WithMany(p => p.HrHolidaysCancelLeaves)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("hr_holidays_cancel_leave_leave_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrHolidaysCancelLeaveWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_holidays_cancel_leave_write_uid_fkey");
        });

        modelBuilder.Entity<HrHolidaysSummaryEmployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_holidays_summary_employee_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrHolidaysSummaryEmployeeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_holidays_summary_employee_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrHolidaysSummaryEmployeeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_holidays_summary_employee_write_uid_fkey");

            entity.HasMany(d => d.Emps).WithMany(p => p.Sums)
                .UsingEntity<Dictionary<string, object>>(
                    "SummaryEmpRel",
                    r => r.HasOne<HrEmployee>().WithMany()
                        .HasForeignKey("EmpId")
                        .HasConstraintName("summary_emp_rel_emp_id_fkey"),
                    l => l.HasOne<HrHolidaysSummaryEmployee>().WithMany()
                        .HasForeignKey("SumId")
                        .HasConstraintName("summary_emp_rel_sum_id_fkey"),
                    j =>
                    {
                        j.HasKey("SumId", "EmpId").HasName("summary_emp_rel_pkey");
                        j.ToTable("summary_emp_rel");
                        j.HasIndex(new[] { "EmpId", "SumId" }, "summary_emp_rel_emp_id_sum_id_idx");
                    });
        });

        modelBuilder.Entity<HrJob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_job_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Address).WithMany(p => p.HrJobs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_job_address_id_fkey");

            entity.HasOne(d => d.Alias).WithMany(p => p.HrJobs)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_job_alias_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.HrJobs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_job_company_id_fkey");

            entity.HasOne(d => d.ContractType).WithMany(p => p.HrJobs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_job_contract_type_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrJobCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_job_create_uid_fkey");

            entity.HasOne(d => d.Department).WithMany(p => p.HrJobs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_job_department_id_fkey");

            entity.HasOne(d => d.HrResponsible).WithMany(p => p.HrJobHrResponsibles)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_job_hr_responsible_id_fkey");

            entity.HasOne(d => d.Manager).WithMany(p => p.HrJobs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_job_manager_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.HrJobs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_job_message_main_attachment_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.HrJobUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_job_user_id_fkey");

            entity.HasOne(d => d.Website).WithMany(p => p.HrJobs)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_job_website_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrJobWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_job_write_uid_fkey");

            entity.HasMany(d => d.ResUsers).WithMany(p => p.HrJobs)
                .UsingEntity<Dictionary<string, object>>(
                    "HrJobExtendedInterviewerResUser",
                    r => r.HasOne<ResUser>().WithMany()
                        .HasForeignKey("ResUsersId")
                        .HasConstraintName("hr_job_extended_interviewer_res_users_res_users_id_fkey"),
                    l => l.HasOne<HrJob>().WithMany()
                        .HasForeignKey("HrJobId")
                        .HasConstraintName("hr_job_extended_interviewer_res_users_hr_job_id_fkey"),
                    j =>
                    {
                        j.HasKey("HrJobId", "ResUsersId").HasName("hr_job_extended_interviewer_res_users_pkey");
                        j.ToTable("hr_job_extended_interviewer_res_users");
                        j.HasIndex(new[] { "ResUsersId", "HrJobId" }, "hr_job_extended_interviewer_res_user_res_users_id_hr_job_id_idx");
                    });

            entity.HasMany(d => d.ResUsersNavigation).WithMany(p => p.HrJobsNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "HrJobResUsersRel",
                    r => r.HasOne<ResUser>().WithMany()
                        .HasForeignKey("ResUsersId")
                        .HasConstraintName("hr_job_res_users_rel_res_users_id_fkey"),
                    l => l.HasOne<HrJob>().WithMany()
                        .HasForeignKey("HrJobId")
                        .HasConstraintName("hr_job_res_users_rel_hr_job_id_fkey"),
                    j =>
                    {
                        j.HasKey("HrJobId", "ResUsersId").HasName("hr_job_res_users_rel_pkey");
                        j.ToTable("hr_job_res_users_rel");
                        j.HasIndex(new[] { "ResUsersId", "HrJobId" }, "hr_job_res_users_rel_res_users_id_hr_job_id_idx");
                    });

            entity.HasMany(d => d.Users).WithMany(p => p.Jobs)
                .UsingEntity<Dictionary<string, object>>(
                    "JobFavoriteUserRel",
                    r => r.HasOne<ResUser>().WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("job_favorite_user_rel_user_id_fkey"),
                    l => l.HasOne<HrJob>().WithMany()
                        .HasForeignKey("JobId")
                        .HasConstraintName("job_favorite_user_rel_job_id_fkey"),
                    j =>
                    {
                        j.HasKey("JobId", "UserId").HasName("job_favorite_user_rel_pkey");
                        j.ToTable("job_favorite_user_rel");
                        j.HasIndex(new[] { "UserId", "JobId" }, "job_favorite_user_rel_user_id_job_id_idx");
                    });
        });

        modelBuilder.Entity<HrLeave>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_leave_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Category).WithMany(p => p.HrLeaves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_category_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrLeaveCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_create_uid_fkey");

            entity.HasOne(d => d.Department).WithMany(p => p.HrLeaves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_department_id_fkey");

            entity.HasOne(d => d.EmployeeCompany).WithMany(p => p.HrLeaveEmployeeCompanies)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_employee_company_id_fkey");

            entity.HasOne(d => d.Employee).WithMany(p => p.HrLeaveEmployees)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_leave_employee_id_fkey");

            entity.HasOne(d => d.FirstApprover).WithMany(p => p.HrLeaveFirstApprovers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_first_approver_id_fkey");

            entity.HasOne(d => d.HolidayAllocation).WithMany(p => p.HrLeaves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_holiday_allocation_id_fkey");

            entity.HasOne(d => d.HolidayStatus).WithMany(p => p.HrLeaves)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_leave_holiday_status_id_fkey");

            entity.HasOne(d => d.Manager).WithMany(p => p.HrLeaveManagers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_manager_id_fkey");

            entity.HasOne(d => d.Meeting).WithMany(p => p.HrLeaves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_meeting_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.HrLeaves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_message_main_attachment_id_fkey");

            entity.HasOne(d => d.ModeCompany).WithMany(p => p.HrLeaveModeCompanies)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_mode_company_id_fkey");

            entity.HasOne(d => d.Overtime).WithMany(p => p.HrLeaves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_overtime_id_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_parent_id_fkey");

            entity.HasOne(d => d.SecondApprover).WithMany(p => p.HrLeaveSecondApprovers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_second_approver_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.HrLeaveUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrLeaveWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_write_uid_fkey");

            entity.HasMany(d => d.HrEmployees).WithMany(p => p.HrLeaves)
                .UsingEntity<Dictionary<string, object>>(
                    "HrEmployeeHrLeaveRel",
                    r => r.HasOne<HrEmployee>().WithMany()
                        .HasForeignKey("HrEmployeeId")
                        .HasConstraintName("hr_employee_hr_leave_rel_hr_employee_id_fkey"),
                    l => l.HasOne<HrLeave>().WithMany()
                        .HasForeignKey("HrLeaveId")
                        .HasConstraintName("hr_employee_hr_leave_rel_hr_leave_id_fkey"),
                    j =>
                    {
                        j.HasKey("HrLeaveId", "HrEmployeeId").HasName("hr_employee_hr_leave_rel_pkey");
                        j.ToTable("hr_employee_hr_leave_rel");
                        j.HasIndex(new[] { "HrEmployeeId", "HrLeaveId" }, "hr_employee_hr_leave_rel_hr_employee_id_hr_leave_id_idx");
                    });
        });

        modelBuilder.Entity<HrLeaveAccrualLevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_leave_accrual_level_pkey");

            entity.HasOne(d => d.AccrualPlan).WithMany(p => p.HrLeaveAccrualLevels)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_leave_accrual_level_accrual_plan_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrLeaveAccrualLevelCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_accrual_level_create_uid_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_accrual_level_parent_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrLeaveAccrualLevelWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_accrual_level_write_uid_fkey");
        });

        modelBuilder.Entity<HrLeaveAccrualPlan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_leave_accrual_plan_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrLeaveAccrualPlanCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_accrual_plan_create_uid_fkey");

            entity.HasOne(d => d.TimeOffType).WithMany(p => p.HrLeaveAccrualPlans)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_accrual_plan_time_off_type_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrLeaveAccrualPlanWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_accrual_plan_write_uid_fkey");
        });

        modelBuilder.Entity<HrLeaveAllocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_leave_allocation_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.AccrualPlan).WithMany(p => p.HrLeaveAllocations)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_allocation_accrual_plan_id_fkey");

            entity.HasOne(d => d.Approver).WithMany(p => p.HrLeaveAllocationApprovers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_allocation_approver_id_fkey");

            entity.HasOne(d => d.Category).WithMany(p => p.HrLeaveAllocations)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_allocation_category_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrLeaveAllocationCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_allocation_create_uid_fkey");

            entity.HasOne(d => d.Department).WithMany(p => p.HrLeaveAllocations)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_allocation_department_id_fkey");

            entity.HasOne(d => d.EmployeeCompany).WithMany(p => p.HrLeaveAllocationEmployeeCompanies)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_allocation_employee_company_id_fkey");

            entity.HasOne(d => d.Employee).WithMany(p => p.HrLeaveAllocationEmployees)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_leave_allocation_employee_id_fkey");

            entity.HasOne(d => d.HolidayStatus).WithMany(p => p.HrLeaveAllocations)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_leave_allocation_holiday_status_id_fkey");

            entity.HasOne(d => d.Manager).WithMany(p => p.HrLeaveAllocationManagers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_allocation_manager_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.HrLeaveAllocations)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_allocation_message_main_attachment_id_fkey");

            entity.HasOne(d => d.ModeCompany).WithMany(p => p.HrLeaveAllocationModeCompanies)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_allocation_mode_company_id_fkey");

            entity.HasOne(d => d.Overtime).WithMany(p => p.HrLeaveAllocations)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_allocation_overtime_id_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_allocation_parent_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrLeaveAllocationWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_allocation_write_uid_fkey");

            entity.HasMany(d => d.HrEmployees).WithMany(p => p.HrLeaveAllocations)
                .UsingEntity<Dictionary<string, object>>(
                    "HrEmployeeHrLeaveAllocationRel",
                    r => r.HasOne<HrEmployee>().WithMany()
                        .HasForeignKey("HrEmployeeId")
                        .HasConstraintName("hr_employee_hr_leave_allocation_rel_hr_employee_id_fkey"),
                    l => l.HasOne<HrLeaveAllocation>().WithMany()
                        .HasForeignKey("HrLeaveAllocationId")
                        .HasConstraintName("hr_employee_hr_leave_allocation_rel_hr_leave_allocation_id_fkey"),
                    j =>
                    {
                        j.HasKey("HrLeaveAllocationId", "HrEmployeeId").HasName("hr_employee_hr_leave_allocation_rel_pkey");
                        j.ToTable("hr_employee_hr_leave_allocation_rel");
                        j.HasIndex(new[] { "HrEmployeeId", "HrLeaveAllocationId" }, "hr_employee_hr_leave_allocati_hr_employee_id_hr_leave_alloc_idx");
                    });
        });

        modelBuilder.Entity<HrLeaveStressDay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_leave_stress_day_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.HrLeaveStressDays)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_leave_stress_day_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrLeaveStressDayCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_stress_day_create_uid_fkey");

            entity.HasOne(d => d.ResourceCalendar).WithMany(p => p.HrLeaveStressDays)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_stress_day_resource_calendar_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrLeaveStressDayWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_stress_day_write_uid_fkey");

            entity.HasMany(d => d.HrDepartments).WithMany(p => p.HrLeaveStressDays)
                .UsingEntity<Dictionary<string, object>>(
                    "HrDepartmentHrLeaveStressDayRel",
                    r => r.HasOne<HrDepartment>().WithMany()
                        .HasForeignKey("HrDepartmentId")
                        .HasConstraintName("hr_department_hr_leave_stress_day_rel_hr_department_id_fkey"),
                    l => l.HasOne<HrLeaveStressDay>().WithMany()
                        .HasForeignKey("HrLeaveStressDayId")
                        .HasConstraintName("hr_department_hr_leave_stress_day_r_hr_leave_stress_day_id_fkey"),
                    j =>
                    {
                        j.HasKey("HrLeaveStressDayId", "HrDepartmentId").HasName("hr_department_hr_leave_stress_day_rel_pkey");
                        j.ToTable("hr_department_hr_leave_stress_day_rel");
                        j.HasIndex(new[] { "HrDepartmentId", "HrLeaveStressDayId" }, "hr_department_hr_leave_stress_hr_department_id_hr_leave_str_idx");
                    });
        });

        modelBuilder.Entity<HrLeaveType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_leave_type_pkey");

            entity.HasOne(d => d.AllocationNotifSubtype).WithMany(p => p.HrLeaveTypeAllocationNotifSubtypes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_type_allocation_notif_subtype_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.HrLeaveTypes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_type_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrLeaveTypeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_type_create_uid_fkey");

            entity.HasOne(d => d.Icon).WithMany(p => p.HrLeaveTypes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_type_icon_id_fkey");

            entity.HasOne(d => d.LeaveNotifSubtype).WithMany(p => p.HrLeaveTypeLeaveNotifSubtypes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_type_leave_notif_subtype_id_fkey");

            entity.HasOne(d => d.Responsible).WithMany(p => p.HrLeaveTypeResponsibles)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_type_responsible_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrLeaveTypeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_leave_type_write_uid_fkey");
        });

        modelBuilder.Entity<HrPayrollStructureType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_payroll_structure_type_pkey");

            entity.HasOne(d => d.Country).WithMany(p => p.HrPayrollStructureTypes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_payroll_structure_type_country_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrPayrollStructureTypeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_payroll_structure_type_create_uid_fkey");

            entity.HasOne(d => d.DefaultResourceCalendar).WithMany(p => p.HrPayrollStructureTypes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_payroll_structure_type_default_resource_calendar_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrPayrollStructureTypeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_payroll_structure_type_write_uid_fkey");
        });

        modelBuilder.Entity<HrPlan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_plan_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.HrPlans)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_plan_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrPlanCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_plan_create_uid_fkey");

            entity.HasOne(d => d.Department).WithMany(p => p.HrPlans)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_plan_department_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrPlanWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_plan_write_uid_fkey");
        });

        modelBuilder.Entity<HrPlanActivityType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_plan_activity_type_pkey");

            entity.HasOne(d => d.ActivityType).WithMany(p => p.HrPlanActivityTypes)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_plan_activity_type_activity_type_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.HrPlanActivityTypes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_plan_activity_type_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrPlanActivityTypeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_plan_activity_type_create_uid_fkey");

            entity.HasOne(d => d.Plan).WithMany(p => p.HrPlanActivityTypes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_plan_activity_type_plan_id_fkey");

            entity.HasOne(d => d.ResponsibleNavigation).WithMany(p => p.HrPlanActivityTypeResponsibleNavigations)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_plan_activity_type_responsible_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrPlanActivityTypeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_plan_activity_type_write_uid_fkey");
        });

        modelBuilder.Entity<HrPlanWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_plan_wizard_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrPlanWizardCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_plan_wizard_create_uid_fkey");

            entity.HasOne(d => d.Plan).WithMany(p => p.HrPlanWizards)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_plan_wizard_plan_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrPlanWizardWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_plan_wizard_write_uid_fkey");

            entity.HasMany(d => d.PlanWizards).WithMany(p => p.Employees)
                .UsingEntity<Dictionary<string, object>>(
                    "HrEmployeeHrPlanWizardRel",
                    r => r.HasOne<HrEmployee>().WithMany()
                        .HasForeignKey("PlanWizardId")
                        .HasConstraintName("hr_employee_hr_plan_wizard_rel_plan_wizard_id_fkey"),
                    l => l.HasOne<HrPlanWizard>().WithMany()
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("hr_employee_hr_plan_wizard_rel_employee_id_fkey"),
                    j =>
                    {
                        j.HasKey("EmployeeId", "PlanWizardId").HasName("hr_employee_hr_plan_wizard_rel_pkey");
                        j.ToTable("hr_employee_hr_plan_wizard_rel");
                        j.HasIndex(new[] { "PlanWizardId", "EmployeeId" }, "hr_employee_hr_plan_wizard_rel_plan_wizard_id_employee_id_idx");
                    });
        });

        modelBuilder.Entity<HrRecruitmentDegree>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_recruitment_degree_pkey");

            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrRecruitmentDegreeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_recruitment_degree_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrRecruitmentDegreeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_recruitment_degree_write_uid_fkey");
        });

        modelBuilder.Entity<HrRecruitmentSource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_recruitment_source_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Alias).WithMany(p => p.HrRecruitmentSources)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_recruitment_source_alias_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrRecruitmentSourceCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_recruitment_source_create_uid_fkey");

            entity.HasOne(d => d.Job).WithMany(p => p.HrRecruitmentSources)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("hr_recruitment_source_job_id_fkey");

            entity.HasOne(d => d.Medium).WithMany(p => p.HrRecruitmentSources)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_recruitment_source_medium_id_fkey");

            entity.HasOne(d => d.Source).WithMany(p => p.HrRecruitmentSources)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_recruitment_source_source_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrRecruitmentSourceWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_recruitment_source_write_uid_fkey");
        });

        modelBuilder.Entity<HrRecruitmentStage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_recruitment_stage_pkey");

            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrRecruitmentStageCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_recruitment_stage_create_uid_fkey");

            entity.HasOne(d => d.Template).WithMany(p => p.HrRecruitmentStages)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_recruitment_stage_template_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrRecruitmentStageWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_recruitment_stage_write_uid_fkey");

            entity.HasMany(d => d.HrJobs).WithMany(p => p.HrRecruitmentStages)
                .UsingEntity<Dictionary<string, object>>(
                    "HrJobHrRecruitmentStageRel",
                    r => r.HasOne<HrJob>().WithMany()
                        .HasForeignKey("HrJobId")
                        .HasConstraintName("hr_job_hr_recruitment_stage_rel_hr_job_id_fkey"),
                    l => l.HasOne<HrRecruitmentStage>().WithMany()
                        .HasForeignKey("HrRecruitmentStageId")
                        .HasConstraintName("hr_job_hr_recruitment_stage_rel_hr_recruitment_stage_id_fkey"),
                    j =>
                    {
                        j.HasKey("HrRecruitmentStageId", "HrJobId").HasName("hr_job_hr_recruitment_stage_rel_pkey");
                        j.ToTable("hr_job_hr_recruitment_stage_rel");
                        j.HasIndex(new[] { "HrJobId", "HrRecruitmentStageId" }, "hr_job_hr_recruitment_stage_r_hr_job_id_hr_recruitment_stag_idx");
                    });
        });

        modelBuilder.Entity<HrResumeLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_resume_line_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrResumeLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_resume_line_create_uid_fkey");

            entity.HasOne(d => d.Employee).WithMany(p => p.HrResumeLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("hr_resume_line_employee_id_fkey");

            entity.HasOne(d => d.LineType).WithMany(p => p.HrResumeLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_resume_line_line_type_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrResumeLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_resume_line_write_uid_fkey");
        });

        modelBuilder.Entity<HrResumeLineType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_resume_line_type_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrResumeLineTypeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_resume_line_type_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrResumeLineTypeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_resume_line_type_write_uid_fkey");
        });

        modelBuilder.Entity<HrSkill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_skill_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrSkillCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_skill_create_uid_fkey");

            entity.HasOne(d => d.SkillType).WithMany(p => p.HrSkills)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("hr_skill_skill_type_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrSkillWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_skill_write_uid_fkey");
        });

        modelBuilder.Entity<HrSkillLevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_skill_level_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrSkillLevelCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_skill_level_create_uid_fkey");

            entity.HasOne(d => d.SkillType).WithMany(p => p.HrSkillLevels)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("hr_skill_level_skill_type_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrSkillLevelWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_skill_level_write_uid_fkey");
        });

        modelBuilder.Entity<HrSkillType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_skill_type_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrSkillTypeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_skill_type_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrSkillTypeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_skill_type_write_uid_fkey");
        });

        modelBuilder.Entity<HrWorkLocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_work_location_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Address).WithMany(p => p.HrWorkLocations)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_work_location_address_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.HrWorkLocations)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_work_location_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrWorkLocationCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_work_location_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrWorkLocationWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_work_location_write_uid_fkey");
        });

        modelBuilder.Entity<IapAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("iap_account_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IapAccountCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("iap_account_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IapAccountWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("iap_account_write_uid_fkey");

            entity.HasMany(d => d.ResCompanies).WithMany(p => p.IapAccounts)
                .UsingEntity<Dictionary<string, object>>(
                    "IapAccountResCompanyRel",
                    r => r.HasOne<ResCompany>().WithMany()
                        .HasForeignKey("ResCompanyId")
                        .HasConstraintName("iap_account_res_company_rel_res_company_id_fkey"),
                    l => l.HasOne<IapAccount>().WithMany()
                        .HasForeignKey("IapAccountId")
                        .HasConstraintName("iap_account_res_company_rel_iap_account_id_fkey"),
                    j =>
                    {
                        j.HasKey("IapAccountId", "ResCompanyId").HasName("iap_account_res_company_rel_pkey");
                        j.ToTable("iap_account_res_company_rel");
                        j.HasIndex(new[] { "ResCompanyId", "IapAccountId" }, "iap_account_res_company_rel_res_company_id_iap_account_id_idx");
                    });
        });

        modelBuilder.Entity<IrActClient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_act_client_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.BindingModel).WithMany(p => p.IrActClients)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_act_client_binding_model_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrActClientCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_client_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrActClientWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_client_write_uid_fkey");
        });

        modelBuilder.Entity<IrActReportXml>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_act_report_xml_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.BindingModel).WithMany(p => p.IrActReportXmls)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_act_report_xml_binding_model_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrActReportXmlCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_report_xml_create_uid_fkey");

            entity.HasOne(d => d.Paperformat).WithMany(p => p.IrActReportXmls)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_report_xml_paperformat_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrActReportXmlWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_report_xml_write_uid_fkey");

            entity.HasMany(d => d.Gids).WithMany(p => p.Uids)
                .UsingEntity<Dictionary<string, object>>(
                    "ResGroupsReportRel",
                    r => r.HasOne<ResGroup>().WithMany()
                        .HasForeignKey("Gid")
                        .HasConstraintName("res_groups_report_rel_gid_fkey"),
                    l => l.HasOne<IrActReportXml>().WithMany()
                        .HasForeignKey("Uid")
                        .HasConstraintName("res_groups_report_rel_uid_fkey"),
                    j =>
                    {
                        j.HasKey("Uid", "Gid").HasName("res_groups_report_rel_pkey");
                        j.ToTable("res_groups_report_rel");
                        j.HasIndex(new[] { "Gid", "Uid" }, "res_groups_report_rel_gid_uid_idx");
                    });
        });

        modelBuilder.Entity<IrActServer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_act_server_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.ActivityType).WithMany(p => p.IrActServers)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("ir_act_server_activity_type_id_fkey");

            entity.HasOne(d => d.ActivityUser).WithMany(p => p.IrActServerActivityUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_server_activity_user_id_fkey");

            entity.HasOne(d => d.BindingModel).WithMany(p => p.IrActServerBindingModels)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_act_server_binding_model_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrActServerCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_server_create_uid_fkey");

            entity.HasOne(d => d.CrudModel).WithMany(p => p.IrActServerCrudModels)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_server_crud_model_id_fkey");

            entity.HasOne(d => d.LinkField).WithMany(p => p.IrActServers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_server_link_field_id_fkey");

            entity.HasOne(d => d.Model).WithMany(p => p.IrActServerModels)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_act_server_model_id_fkey");

            entity.HasOne(d => d.SmsTemplate).WithMany(p => p.IrActServers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_server_sms_template_id_fkey");

            entity.HasOne(d => d.Template).WithMany(p => p.IrActServers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_server_template_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrActServerWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_server_write_uid_fkey");

            entity.HasMany(d => d.Actions).WithMany(p => p.Servers)
                .UsingEntity<Dictionary<string, object>>(
                    "RelServerAction",
                    r => r.HasOne<IrActServer>().WithMany()
                        .HasForeignKey("ActionId")
                        .HasConstraintName("rel_server_actions_action_id_fkey"),
                    l => l.HasOne<IrActServer>().WithMany()
                        .HasForeignKey("ServerId")
                        .HasConstraintName("rel_server_actions_server_id_fkey"),
                    j =>
                    {
                        j.HasKey("ServerId", "ActionId").HasName("rel_server_actions_pkey");
                        j.ToTable("rel_server_actions");
                        j.HasIndex(new[] { "ActionId", "ServerId" }, "rel_server_actions_action_id_server_id_idx");
                    });

            entity.HasMany(d => d.Gids).WithMany(p => p.Acts)
                .UsingEntity<Dictionary<string, object>>(
                    "IrActServerGroupRel",
                    r => r.HasOne<ResGroup>().WithMany()
                        .HasForeignKey("Gid")
                        .HasConstraintName("ir_act_server_group_rel_gid_fkey"),
                    l => l.HasOne<IrActServer>().WithMany()
                        .HasForeignKey("ActId")
                        .HasConstraintName("ir_act_server_group_rel_act_id_fkey"),
                    j =>
                    {
                        j.HasKey("ActId", "Gid").HasName("ir_act_server_group_rel_pkey");
                        j.ToTable("ir_act_server_group_rel");
                        j.HasIndex(new[] { "Gid", "ActId" }, "ir_act_server_group_rel_gid_act_id_idx");
                    });

            entity.HasMany(d => d.ResPartners).WithMany(p => p.IrActServers)
                .UsingEntity<Dictionary<string, object>>(
                    "IrActServerResPartnerRel",
                    r => r.HasOne<ResPartner>().WithMany()
                        .HasForeignKey("ResPartnerId")
                        .HasConstraintName("ir_act_server_res_partner_rel_res_partner_id_fkey"),
                    l => l.HasOne<IrActServer>().WithMany()
                        .HasForeignKey("IrActServerId")
                        .HasConstraintName("ir_act_server_res_partner_rel_ir_act_server_id_fkey"),
                    j =>
                    {
                        j.HasKey("IrActServerId", "ResPartnerId").HasName("ir_act_server_res_partner_rel_pkey");
                        j.ToTable("ir_act_server_res_partner_rel");
                        j.HasIndex(new[] { "ResPartnerId", "IrActServerId" }, "ir_act_server_res_partner_rel_res_partner_id_ir_act_server__idx");
                    });

            entity.HasMany(d => d.Servers).WithMany(p => p.Actions)
                .UsingEntity<Dictionary<string, object>>(
                    "RelServerAction",
                    r => r.HasOne<IrActServer>().WithMany()
                        .HasForeignKey("ServerId")
                        .HasConstraintName("rel_server_actions_server_id_fkey"),
                    l => l.HasOne<IrActServer>().WithMany()
                        .HasForeignKey("ActionId")
                        .HasConstraintName("rel_server_actions_action_id_fkey"),
                    j =>
                    {
                        j.HasKey("ServerId", "ActionId").HasName("rel_server_actions_pkey");
                        j.ToTable("rel_server_actions");
                        j.HasIndex(new[] { "ActionId", "ServerId" }, "rel_server_actions_action_id_server_id_idx");
                    });
        });

        modelBuilder.Entity<IrActUrl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_act_url_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.BindingModel).WithMany(p => p.IrActUrls)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_act_url_binding_model_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrActUrlCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_url_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrActUrlWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_url_write_uid_fkey");
        });

        modelBuilder.Entity<IrActWindow>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_act_window_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.BindingModel).WithMany(p => p.IrActWindows)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_act_window_binding_model_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrActWindowCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_window_create_uid_fkey");

            entity.HasOne(d => d.SearchView).WithMany(p => p.IrActWindowSearchViews)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_window_search_view_id_fkey");

            entity.HasOne(d => d.View).WithMany(p => p.IrActWindowViews)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_window_view_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrActWindowWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_window_write_uid_fkey");

            entity.HasMany(d => d.Gids).WithMany(p => p.ActsNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "IrActWindowGroupRel",
                    r => r.HasOne<ResGroup>().WithMany()
                        .HasForeignKey("Gid")
                        .HasConstraintName("ir_act_window_group_rel_gid_fkey"),
                    l => l.HasOne<IrActWindow>().WithMany()
                        .HasForeignKey("ActId")
                        .HasConstraintName("ir_act_window_group_rel_act_id_fkey"),
                    j =>
                    {
                        j.HasKey("ActId", "Gid").HasName("ir_act_window_group_rel_pkey");
                        j.ToTable("ir_act_window_group_rel");
                        j.HasIndex(new[] { "Gid", "ActId" }, "ir_act_window_group_rel_gid_act_id_idx");
                    });
        });

        modelBuilder.Entity<IrActWindowView>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_act_window_view_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.ActWindow).WithMany(p => p.IrActWindowViews)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_act_window_view_act_window_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrActWindowViewCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_window_view_create_uid_fkey");

            entity.HasOne(d => d.View).WithMany(p => p.IrActWindowViewsNavigation)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_window_view_view_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrActWindowViewWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_window_view_write_uid_fkey");
        });

        modelBuilder.Entity<IrAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_actions_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.BindingModel).WithMany(p => p.IrActions)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_actions_binding_model_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrActionCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_actions_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrActionWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_actions_write_uid_fkey");
        });

        modelBuilder.Entity<IrActionsTodo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_actions_todo_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrActionsTodoCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_actions_todo_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrActionsTodoWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_actions_todo_write_uid_fkey");
        });

        modelBuilder.Entity<IrAsset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_asset_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrAssetCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_asset_create_uid_fkey");

            entity.HasOne(d => d.ThemeTemplate).WithMany(p => p.IrAssets)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_asset_theme_template_id_fkey");

            entity.HasOne(d => d.Website).WithMany(p => p.IrAssets)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_asset_website_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrAssetWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_asset_write_uid_fkey");
        });

        modelBuilder.Entity<IrAttachment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_attachment_pkey");

            entity.HasIndex(e => e.Url, "ir_attachment_url_index").HasFilter("(url IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.IrAttachments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_attachment_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrAttachmentCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_attachment_create_uid_fkey");

            entity.HasOne(d => d.Original).WithMany(p => p.InverseOriginal)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_attachment_original_id_fkey");

            entity.HasOne(d => d.ThemeTemplate).WithMany(p => p.IrAttachments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_attachment_theme_template_id_fkey");

            entity.HasOne(d => d.Website).WithMany(p => p.IrAttachments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_attachment_website_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrAttachmentWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_attachment_write_uid_fkey");
        });

        modelBuilder.Entity<IrConfigParameter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_config_parameter_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrConfigParameterCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_config_parameter_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrConfigParameterWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_config_parameter_write_uid_fkey");
        });

        modelBuilder.Entity<IrCron>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_cron_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrCronCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_cron_create_uid_fkey");

            entity.HasOne(d => d.IrActionsServer).WithMany(p => p.IrCrons)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("ir_cron_ir_actions_server_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.IrCronUsers)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("ir_cron_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrCronWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_cron_write_uid_fkey");
        });

        modelBuilder.Entity<IrCronTrigger>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_cron_trigger_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrCronTriggerCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_cron_trigger_create_uid_fkey");

            entity.HasOne(d => d.Cron).WithMany(p => p.IrCronTriggers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_cron_trigger_cron_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrCronTriggerWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_cron_trigger_write_uid_fkey");
        });

        modelBuilder.Entity<IrDefault>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_default_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.IrDefaults)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_default_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrDefaultCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_default_create_uid_fkey");

            entity.HasOne(d => d.Field).WithMany(p => p.IrDefaults)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_default_field_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.IrDefaultUsers)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_default_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrDefaultWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_default_write_uid_fkey");
        });

        modelBuilder.Entity<IrDemo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_demo_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrDemoCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_demo_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrDemoWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_demo_write_uid_fkey");
        });

        modelBuilder.Entity<IrDemoFailure>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_demo_failure_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrDemoFailureCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_demo_failure_create_uid_fkey");

            entity.HasOne(d => d.Module).WithMany(p => p.IrDemoFailures)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_demo_failure_module_id_fkey");

            entity.HasOne(d => d.Wizard).WithMany(p => p.IrDemoFailures)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_demo_failure_wizard_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrDemoFailureWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_demo_failure_write_uid_fkey");
        });

        modelBuilder.Entity<IrDemoFailureWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_demo_failure_wizard_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrDemoFailureWizardCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_demo_failure_wizard_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrDemoFailureWizardWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_demo_failure_wizard_write_uid_fkey");
        });

        modelBuilder.Entity<IrExport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_exports_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrExportCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_exports_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrExportWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_exports_write_uid_fkey");
        });

        modelBuilder.Entity<IrExportsLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_exports_line_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrExportsLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_exports_line_create_uid_fkey");

            entity.HasOne(d => d.Export).WithMany(p => p.IrExportsLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_exports_line_export_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrExportsLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_exports_line_write_uid_fkey");
        });

        modelBuilder.Entity<IrFilter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_filters_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrFilterCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_filters_create_uid_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.IrFilterUsers)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_filters_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrFilterWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_filters_write_uid_fkey");
        });

        modelBuilder.Entity<IrLogging>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_logging_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
        });

        modelBuilder.Entity<IrMailServer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_mail_server_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrMailServerCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_mail_server_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrMailServerWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_mail_server_write_uid_fkey");
        });

        modelBuilder.Entity<IrModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_model_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrModelCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_create_uid_fkey");

            entity.HasOne(d => d.WebsiteFormDefaultField).WithMany(p => p.IrModels)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_website_form_default_field_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrModelWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_write_uid_fkey");
        });

        modelBuilder.Entity<IrModelAccess>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_model_access_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrModelAccessCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_access_create_uid_fkey");

            entity.HasOne(d => d.Group).WithMany(p => p.IrModelAccesses)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("ir_model_access_group_id_fkey");

            entity.HasOne(d => d.Model).WithMany(p => p.IrModelAccesses)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_model_access_model_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrModelAccessWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_access_write_uid_fkey");
        });

        modelBuilder.Entity<IrModelConstraint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_model_constraint_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrModelConstraintCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_constraint_create_uid_fkey");

            entity.HasOne(d => d.ModelNavigation).WithMany(p => p.IrModelConstraints)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_model_constraint_model_fkey");

            entity.HasOne(d => d.ModuleNavigation).WithMany(p => p.IrModelConstraints)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_model_constraint_module_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrModelConstraintWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_constraint_write_uid_fkey");
        });

        modelBuilder.Entity<IrModelDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_model_data_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.CreateDate).HasDefaultValueSql("(now() AT TIME ZONE 'UTC'::text)");
            entity.Property(e => e.Noupdate).HasDefaultValueSql("false");
            entity.Property(e => e.WriteDate).HasDefaultValueSql("(now() AT TIME ZONE 'UTC'::text)");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrModelDatumCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_data_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrModelDatumWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_data_write_uid_fkey");
        });

        modelBuilder.Entity<IrModelField>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_model_fields_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.WebsiteFormBlacklisted).HasDefaultValueSql("true");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrModelFieldCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_fields_create_uid_fkey");

            entity.HasOne(d => d.ModelNavigation).WithMany(p => p.IrModelFields)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_model_fields_model_id_fkey");

            entity.HasOne(d => d.RelatedField).WithMany(p => p.InverseRelatedField)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_model_fields_related_field_id_fkey");

            entity.HasOne(d => d.RelationFieldNavigation).WithMany(p => p.InverseRelationFieldNavigation)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_model_fields_relation_field_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrModelFieldWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_fields_write_uid_fkey");

            entity.HasMany(d => d.Groups).WithMany(p => p.Fields)
                .UsingEntity<Dictionary<string, object>>(
                    "IrModelFieldsGroupRel",
                    r => r.HasOne<ResGroup>().WithMany()
                        .HasForeignKey("GroupId")
                        .HasConstraintName("ir_model_fields_group_rel_group_id_fkey"),
                    l => l.HasOne<IrModelField>().WithMany()
                        .HasForeignKey("FieldId")
                        .HasConstraintName("ir_model_fields_group_rel_field_id_fkey"),
                    j =>
                    {
                        j.HasKey("FieldId", "GroupId").HasName("ir_model_fields_group_rel_pkey");
                        j.ToTable("ir_model_fields_group_rel");
                        j.HasIndex(new[] { "GroupId", "FieldId" }, "ir_model_fields_group_rel_group_id_field_id_idx");
                    });
        });

        modelBuilder.Entity<IrModelFieldsSelection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_model_fields_selection_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrModelFieldsSelectionCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_fields_selection_create_uid_fkey");

            entity.HasOne(d => d.Field).WithMany(p => p.IrModelFieldsSelections)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_model_fields_selection_field_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrModelFieldsSelectionWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_fields_selection_write_uid_fkey");
        });

        modelBuilder.Entity<IrModelRelation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_model_relation_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrModelRelationCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_relation_create_uid_fkey");

            entity.HasOne(d => d.ModelNavigation).WithMany(p => p.IrModelRelations)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_model_relation_model_fkey");

            entity.HasOne(d => d.ModuleNavigation).WithMany(p => p.IrModelRelations)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_model_relation_module_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrModelRelationWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_relation_write_uid_fkey");
        });

        modelBuilder.Entity<IrModuleCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_module_category_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrModuleCategoryCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_module_category_create_uid_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_module_category_parent_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrModuleCategoryWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_module_category_write_uid_fkey");
        });

        modelBuilder.Entity<IrModuleModule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_module_module_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Application).HasDefaultValueSql("false");
            entity.Property(e => e.AutoInstall).HasDefaultValueSql("false");
            entity.Property(e => e.Demo).HasDefaultValueSql("false");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();
            entity.Property(e => e.ToBuy).HasDefaultValueSql("false");
            entity.Property(e => e.Web).HasDefaultValueSql("false");

            entity.HasOne(d => d.Category).WithMany(p => p.IrModuleModules)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_module_module_category_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrModuleModuleCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_module_module_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrModuleModuleWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_module_module_write_uid_fkey");
        });

        modelBuilder.Entity<IrModuleModuleDependency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_module_module_dependency_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.AutoInstallRequired).HasDefaultValueSql("true");

            entity.HasOne(d => d.Module).WithMany(p => p.IrModuleModuleDependencies)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_module_module_dependency_module_id_fkey");
        });

        modelBuilder.Entity<IrModuleModuleExclusion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_module_module_exclusion_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrModuleModuleExclusionCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_module_module_exclusion_create_uid_fkey");

            entity.HasOne(d => d.Module).WithMany(p => p.IrModuleModuleExclusions)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_module_module_exclusion_module_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrModuleModuleExclusionWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_module_module_exclusion_write_uid_fkey");
        });

        modelBuilder.Entity<IrProfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_profile_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
        });

        modelBuilder.Entity<IrProperty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_property_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.IrProperties)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_property_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrPropertyCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_property_create_uid_fkey");

            entity.HasOne(d => d.Fields).WithMany(p => p.IrProperties)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_property_fields_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrPropertyWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_property_write_uid_fkey");
        });

        modelBuilder.Entity<IrRule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_rule_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrRuleCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_rule_create_uid_fkey");

            entity.HasOne(d => d.Model).WithMany(p => p.IrRules)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_rule_model_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrRuleWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_rule_write_uid_fkey");

            entity.HasMany(d => d.Groups).WithMany(p => p.RuleGroups)
                .UsingEntity<Dictionary<string, object>>(
                    "RuleGroupRel",
                    r => r.HasOne<ResGroup>().WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("rule_group_rel_group_id_fkey"),
                    l => l.HasOne<IrRule>().WithMany()
                        .HasForeignKey("RuleGroupId")
                        .HasConstraintName("rule_group_rel_rule_group_id_fkey"),
                    j =>
                    {
                        j.HasKey("RuleGroupId", "GroupId").HasName("rule_group_rel_pkey");
                        j.ToTable("rule_group_rel");
                        j.HasIndex(new[] { "GroupId", "RuleGroupId" }, "rule_group_rel_group_id_rule_group_id_idx");
                    });
        });

        modelBuilder.Entity<IrSequence>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_sequence_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.IrSequences)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_sequence_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrSequenceCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_sequence_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrSequenceWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_sequence_write_uid_fkey");
        });

        modelBuilder.Entity<IrSequenceDateRange>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_sequence_date_range_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrSequenceDateRangeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_sequence_date_range_create_uid_fkey");

            entity.HasOne(d => d.Sequence).WithMany(p => p.IrSequenceDateRanges)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_sequence_date_range_sequence_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrSequenceDateRangeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_sequence_date_range_write_uid_fkey");
        });

        modelBuilder.Entity<IrServerObjectLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_server_object_lines_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Col1Navigation).WithMany(p => p.IrServerObjectLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_server_object_lines_col1_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrServerObjectLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_server_object_lines_create_uid_fkey");

            entity.HasOne(d => d.Server).WithMany(p => p.IrServerObjectLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_server_object_lines_server_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrServerObjectLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_server_object_lines_write_uid_fkey");
        });

        modelBuilder.Entity<IrUiMenu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_ui_menu_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrUiMenuCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_ui_menu_create_uid_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("ir_ui_menu_parent_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrUiMenuWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_ui_menu_write_uid_fkey");

            entity.HasMany(d => d.Gids).WithMany(p => p.Menus)
                .UsingEntity<Dictionary<string, object>>(
                    "IrUiMenuGroupRel",
                    r => r.HasOne<ResGroup>().WithMany()
                        .HasForeignKey("Gid")
                        .HasConstraintName("ir_ui_menu_group_rel_gid_fkey"),
                    l => l.HasOne<IrUiMenu>().WithMany()
                        .HasForeignKey("MenuId")
                        .HasConstraintName("ir_ui_menu_group_rel_menu_id_fkey"),
                    j =>
                    {
                        j.HasKey("MenuId", "Gid").HasName("ir_ui_menu_group_rel_pkey");
                        j.ToTable("ir_ui_menu_group_rel");
                        j.HasIndex(new[] { "Gid", "MenuId" }, "ir_ui_menu_group_rel_gid_menu_id_idx");
                    });
        });

        modelBuilder.Entity<IrUiView>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_ui_view_pkey");

            entity.HasIndex(e => e.Key, "ir_ui_view_key_index").HasFilter("(key IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrUiViewCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_ui_view_create_uid_fkey");

            entity.HasOne(d => d.Inherit).WithMany(p => p.InverseInherit)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("ir_ui_view_inherit_id_fkey");

            entity.HasOne(d => d.ThemeTemplate).WithMany(p => p.IrUiViews)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_ui_view_theme_template_id_fkey");

            entity.HasOne(d => d.Website).WithMany(p => p.IrUiViews)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_ui_view_website_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrUiViewWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_ui_view_write_uid_fkey");

            entity.HasMany(d => d.Groups).WithMany(p => p.Views)
                .UsingEntity<Dictionary<string, object>>(
                    "IrUiViewGroupRel",
                    r => r.HasOne<ResGroup>().WithMany()
                        .HasForeignKey("GroupId")
                        .HasConstraintName("ir_ui_view_group_rel_group_id_fkey"),
                    l => l.HasOne<IrUiView>().WithMany()
                        .HasForeignKey("ViewId")
                        .HasConstraintName("ir_ui_view_group_rel_view_id_fkey"),
                    j =>
                    {
                        j.HasKey("ViewId", "GroupId").HasName("ir_ui_view_group_rel_pkey");
                        j.ToTable("ir_ui_view_group_rel");
                        j.HasIndex(new[] { "GroupId", "ViewId" }, "ir_ui_view_group_rel_group_id_view_id_idx");
                    });
        });

        modelBuilder.Entity<IrUiViewCustom>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_ui_view_custom_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrUiViewCustomCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_ui_view_custom_create_uid_fkey");

            entity.HasOne(d => d.Ref).WithMany(p => p.IrUiViewCustoms)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_ui_view_custom_ref_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.IrUiViewCustomUsers)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_ui_view_custom_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrUiViewCustomWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_ui_view_custom_write_uid_fkey");
        });

        modelBuilder.Entity<LotLabelLayout>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("lot_label_layout_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.LotLabelLayoutCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lot_label_layout_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.LotLabelLayoutWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lot_label_layout_write_uid_fkey");

            entity.HasMany(d => d.StockPickings).WithMany(p => p.LotLabelLayouts)
                .UsingEntity<Dictionary<string, object>>(
                    "LotLabelLayoutStockPickingRel",
                    r => r.HasOne<StockPicking>().WithMany()
                        .HasForeignKey("StockPickingId")
                        .HasConstraintName("lot_label_layout_stock_picking_rel_stock_picking_id_fkey"),
                    l => l.HasOne<LotLabelLayout>().WithMany()
                        .HasForeignKey("LotLabelLayoutId")
                        .HasConstraintName("lot_label_layout_stock_picking_rel_lot_label_layout_id_fkey"),
                    j =>
                    {
                        j.HasKey("LotLabelLayoutId", "StockPickingId").HasName("lot_label_layout_stock_picking_rel_pkey");
                        j.ToTable("lot_label_layout_stock_picking_rel");
                        j.HasIndex(new[] { "StockPickingId", "LotLabelLayoutId" }, "lot_label_layout_stock_pickin_stock_picking_id_lot_label_la_idx");
                    });
        });

        modelBuilder.Entity<LunchAlert>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("lunch_alert_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.LunchAlertCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_alert_create_uid_fkey");

            entity.HasOne(d => d.Cron).WithMany(p => p.LunchAlerts)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("lunch_alert_cron_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.LunchAlertWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_alert_write_uid_fkey");

            entity.HasMany(d => d.LunchLocations).WithMany(p => p.LunchAlerts)
                .UsingEntity<Dictionary<string, object>>(
                    "LunchAlertLunchLocationRel",
                    r => r.HasOne<LunchLocation>().WithMany()
                        .HasForeignKey("LunchLocationId")
                        .HasConstraintName("lunch_alert_lunch_location_rel_lunch_location_id_fkey"),
                    l => l.HasOne<LunchAlert>().WithMany()
                        .HasForeignKey("LunchAlertId")
                        .HasConstraintName("lunch_alert_lunch_location_rel_lunch_alert_id_fkey"),
                    j =>
                    {
                        j.HasKey("LunchAlertId", "LunchLocationId").HasName("lunch_alert_lunch_location_rel_pkey");
                        j.ToTable("lunch_alert_lunch_location_rel");
                        j.HasIndex(new[] { "LunchLocationId", "LunchAlertId" }, "lunch_alert_lunch_location_re_lunch_location_id_lunch_alert_idx");
                    });
        });

        modelBuilder.Entity<LunchCashmove>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("lunch_cashmove_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.LunchCashmoveCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_cashmove_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.LunchCashmoves)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("lunch_cashmove_currency_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.LunchCashmoveUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_cashmove_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.LunchCashmoveWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_cashmove_write_uid_fkey");
        });

        modelBuilder.Entity<LunchLocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("lunch_location_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.LunchLocations)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_location_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.LunchLocationCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_location_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.LunchLocationWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_location_write_uid_fkey");
        });

        modelBuilder.Entity<LunchOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("lunch_order_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Category).WithMany(p => p.LunchOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_order_category_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.LunchOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_order_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.LunchOrderCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_order_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.LunchOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_order_currency_id_fkey");

            entity.HasOne(d => d.LunchLocation).WithMany(p => p.LunchOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_order_lunch_location_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.LunchOrders)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("lunch_order_product_id_fkey");

            entity.HasOne(d => d.Supplier).WithMany(p => p.LunchOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_order_supplier_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.LunchOrderUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_order_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.LunchOrderWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_order_write_uid_fkey");

            entity.HasMany(d => d.Toppings).WithMany(p => p.Orders)
                .UsingEntity<Dictionary<string, object>>(
                    "LunchOrderTopping",
                    r => r.HasOne<LunchTopping>().WithMany()
                        .HasForeignKey("ToppingId")
                        .HasConstraintName("lunch_order_topping_topping_id_fkey"),
                    l => l.HasOne<LunchOrder>().WithMany()
                        .HasForeignKey("OrderId")
                        .HasConstraintName("lunch_order_topping_order_id_fkey"),
                    j =>
                    {
                        j.HasKey("OrderId", "ToppingId").HasName("lunch_order_topping_pkey");
                        j.ToTable("lunch_order_topping");
                        j.HasIndex(new[] { "ToppingId", "OrderId" }, "lunch_order_topping_topping_id_order_id_idx");
                    });
        });

        modelBuilder.Entity<LunchProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("lunch_product_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Category).WithMany(p => p.LunchProducts)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("lunch_product_category_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.LunchProducts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_product_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.LunchProductCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_product_create_uid_fkey");

            entity.HasOne(d => d.Supplier).WithMany(p => p.LunchProducts)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("lunch_product_supplier_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.LunchProductWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_product_write_uid_fkey");

            entity.HasMany(d => d.Users).WithMany(p => p.Products)
                .UsingEntity<Dictionary<string, object>>(
                    "LunchProductFavoriteUserRel",
                    r => r.HasOne<ResUser>().WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("lunch_product_favorite_user_rel_user_id_fkey"),
                    l => l.HasOne<LunchProduct>().WithMany()
                        .HasForeignKey("ProductId")
                        .HasConstraintName("lunch_product_favorite_user_rel_product_id_fkey"),
                    j =>
                    {
                        j.HasKey("ProductId", "UserId").HasName("lunch_product_favorite_user_rel_pkey");
                        j.ToTable("lunch_product_favorite_user_rel");
                        j.HasIndex(new[] { "UserId", "ProductId" }, "lunch_product_favorite_user_rel_user_id_product_id_idx");
                    });
        });

        modelBuilder.Entity<LunchProductCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("lunch_product_category_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.LunchProductCategories)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_product_category_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.LunchProductCategoryCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_product_category_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.LunchProductCategoryWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_product_category_write_uid_fkey");
        });

        modelBuilder.Entity<LunchSupplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("lunch_supplier_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.LunchSuppliers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_supplier_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.LunchSupplierCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_supplier_create_uid_fkey");

            entity.HasOne(d => d.Cron).WithMany(p => p.LunchSuppliers)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("lunch_supplier_cron_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.LunchSuppliers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_supplier_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.LunchSuppliers)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("lunch_supplier_partner_id_fkey");

            entity.HasOne(d => d.Responsible).WithMany(p => p.LunchSupplierResponsibles)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_supplier_responsible_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.LunchSupplierWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_supplier_write_uid_fkey");

            entity.HasMany(d => d.LunchLocations).WithMany(p => p.LunchSuppliers)
                .UsingEntity<Dictionary<string, object>>(
                    "LunchLocationLunchSupplierRel",
                    r => r.HasOne<LunchLocation>().WithMany()
                        .HasForeignKey("LunchLocationId")
                        .HasConstraintName("lunch_location_lunch_supplier_rel_lunch_location_id_fkey"),
                    l => l.HasOne<LunchSupplier>().WithMany()
                        .HasForeignKey("LunchSupplierId")
                        .HasConstraintName("lunch_location_lunch_supplier_rel_lunch_supplier_id_fkey"),
                    j =>
                    {
                        j.HasKey("LunchSupplierId", "LunchLocationId").HasName("lunch_location_lunch_supplier_rel_pkey");
                        j.ToTable("lunch_location_lunch_supplier_rel");
                        j.HasIndex(new[] { "LunchLocationId", "LunchSupplierId" }, "lunch_location_lunch_supplier_lunch_location_id_lunch_suppl_idx");
                    });
        });

        modelBuilder.Entity<LunchTopping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("lunch_topping_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.LunchToppings)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_topping_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.LunchToppingCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_topping_create_uid_fkey");

            entity.HasOne(d => d.Supplier).WithMany(p => p.LunchToppings)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("lunch_topping_supplier_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.LunchToppingWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lunch_topping_write_uid_fkey");
        });

        modelBuilder.Entity<MailActivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_activity_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.ActivityType).WithMany(p => p.MailActivityActivityTypes)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mail_activity_activity_type_id_fkey");

            entity.HasOne(d => d.CalendarEvent).WithMany(p => p.MailActivities)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mail_activity_calendar_event_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailActivityCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_activity_create_uid_fkey");

            entity.HasOne(d => d.NoteNavigation).WithMany(p => p.MailActivities)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mail_activity_note_id_fkey");

            entity.HasOne(d => d.PreviousActivityType).WithMany(p => p.MailActivityPreviousActivityTypes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_activity_previous_activity_type_id_fkey");

            entity.HasOne(d => d.RecommendedActivityType).WithMany(p => p.MailActivityRecommendedActivityTypes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_activity_recommended_activity_type_id_fkey");

            entity.HasOne(d => d.RequestPartner).WithMany(p => p.MailActivities)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_activity_request_partner_id_fkey");

            entity.HasOne(d => d.ResModelNavigation).WithMany(p => p.MailActivities)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mail_activity_res_model_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.MailActivityUsers)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mail_activity_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailActivityWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_activity_write_uid_fkey");
        });

        modelBuilder.Entity<MailActivityType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_activity_type_pkey");

            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailActivityTypeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_activity_type_create_uid_fkey");

            entity.HasOne(d => d.DefaultUser).WithMany(p => p.MailActivityTypeDefaultUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_activity_type_default_user_id_fkey");

            entity.HasOne(d => d.TriggeredNextType).WithMany(p => p.InverseTriggeredNextType)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mail_activity_type_triggered_next_type_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailActivityTypeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_activity_type_write_uid_fkey");

            entity.HasMany(d => d.Activities).WithMany(p => p.Recommendeds)
                .UsingEntity<Dictionary<string, object>>(
                    "MailActivityRel",
                    r => r.HasOne<MailActivityType>().WithMany()
                        .HasForeignKey("ActivityId")
                        .HasConstraintName("mail_activity_rel_activity_id_fkey"),
                    l => l.HasOne<MailActivityType>().WithMany()
                        .HasForeignKey("RecommendedId")
                        .HasConstraintName("mail_activity_rel_recommended_id_fkey"),
                    j =>
                    {
                        j.HasKey("ActivityId", "RecommendedId").HasName("mail_activity_rel_pkey");
                        j.ToTable("mail_activity_rel");
                        j.HasIndex(new[] { "RecommendedId", "ActivityId" }, "mail_activity_rel_recommended_id_activity_id_idx");
                    });

            entity.HasMany(d => d.MailTemplates).WithMany(p => p.MailActivityTypes)
                .UsingEntity<Dictionary<string, object>>(
                    "MailActivityTypeMailTemplateRel",
                    r => r.HasOne<MailTemplate>().WithMany()
                        .HasForeignKey("MailTemplateId")
                        .HasConstraintName("mail_activity_type_mail_template_rel_mail_template_id_fkey"),
                    l => l.HasOne<MailActivityType>().WithMany()
                        .HasForeignKey("MailActivityTypeId")
                        .HasConstraintName("mail_activity_type_mail_template_rel_mail_activity_type_id_fkey"),
                    j =>
                    {
                        j.HasKey("MailActivityTypeId", "MailTemplateId").HasName("mail_activity_type_mail_template_rel_pkey");
                        j.ToTable("mail_activity_type_mail_template_rel");
                        j.HasIndex(new[] { "MailTemplateId", "MailActivityTypeId" }, "mail_activity_type_mail_templ_mail_template_id_mail_activit_idx");
                    });

            entity.HasMany(d => d.Recommendeds).WithMany(p => p.Activities)
                .UsingEntity<Dictionary<string, object>>(
                    "MailActivityRel",
                    r => r.HasOne<MailActivityType>().WithMany()
                        .HasForeignKey("RecommendedId")
                        .HasConstraintName("mail_activity_rel_recommended_id_fkey"),
                    l => l.HasOne<MailActivityType>().WithMany()
                        .HasForeignKey("ActivityId")
                        .HasConstraintName("mail_activity_rel_activity_id_fkey"),
                    j =>
                    {
                        j.HasKey("ActivityId", "RecommendedId").HasName("mail_activity_rel_pkey");
                        j.ToTable("mail_activity_rel");
                        j.HasIndex(new[] { "RecommendedId", "ActivityId" }, "mail_activity_rel_recommended_id_activity_id_idx");
                    });
        });

        modelBuilder.Entity<MailAlias>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_alias_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.AliasModel).WithMany(p => p.MailAliasAliasModels)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mail_alias_alias_model_id_fkey");

            entity.HasOne(d => d.AliasParentModel).WithMany(p => p.MailAliasAliasParentModels)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_alias_alias_parent_model_id_fkey");

            entity.HasOne(d => d.AliasUser).WithMany(p => p.MailAliasAliasUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_alias_alias_user_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailAliasCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_alias_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailAliasWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_alias_write_uid_fkey");
        });

        modelBuilder.Entity<MailBlacklist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_blacklist_pkey");

            entity.HasIndex(e => e.Email, "mail_blacklist_email_index")
                .HasMethod("gin")
                .HasOperators(new[] { "gin_trgm_ops" });

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailBlacklistCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_blacklist_create_uid_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.MailBlacklists)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_blacklist_message_main_attachment_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailBlacklistWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_blacklist_write_uid_fkey");
        });

        modelBuilder.Entity<MailBlacklistRemove>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_blacklist_remove_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailBlacklistRemoveCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_blacklist_remove_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailBlacklistRemoveWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_blacklist_remove_write_uid_fkey");
        });

        modelBuilder.Entity<MailChannel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_channel_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailChannelCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_channel_create_uid_fkey");

            entity.HasOne(d => d.GroupPublic).WithMany(p => p.MailChannels)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_channel_group_public_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.MailChannels)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_channel_message_main_attachment_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailChannelWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_channel_write_uid_fkey");

            entity.HasMany(d => d.HrDepartments).WithMany(p => p.MailChannels)
                .UsingEntity<Dictionary<string, object>>(
                    "HrDepartmentMailChannelRel",
                    r => r.HasOne<HrDepartment>().WithMany()
                        .HasForeignKey("HrDepartmentId")
                        .HasConstraintName("hr_department_mail_channel_rel_hr_department_id_fkey"),
                    l => l.HasOne<MailChannel>().WithMany()
                        .HasForeignKey("MailChannelId")
                        .HasConstraintName("hr_department_mail_channel_rel_mail_channel_id_fkey"),
                    j =>
                    {
                        j.HasKey("MailChannelId", "HrDepartmentId").HasName("hr_department_mail_channel_rel_pkey");
                        j.ToTable("hr_department_mail_channel_rel");
                        j.HasIndex(new[] { "HrDepartmentId", "MailChannelId" }, "hr_department_mail_channel_re_hr_department_id_mail_channel_idx");
                    });

            entity.HasMany(d => d.ResGroups).WithMany(p => p.MailChannelsNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "MailChannelResGroupsRel",
                    r => r.HasOne<ResGroup>().WithMany()
                        .HasForeignKey("ResGroupsId")
                        .HasConstraintName("mail_channel_res_groups_rel_res_groups_id_fkey"),
                    l => l.HasOne<MailChannel>().WithMany()
                        .HasForeignKey("MailChannelId")
                        .HasConstraintName("mail_channel_res_groups_rel_mail_channel_id_fkey"),
                    j =>
                    {
                        j.HasKey("MailChannelId", "ResGroupsId").HasName("mail_channel_res_groups_rel_pkey");
                        j.ToTable("mail_channel_res_groups_rel");
                        j.HasIndex(new[] { "ResGroupsId", "MailChannelId" }, "mail_channel_res_groups_rel_res_groups_id_mail_channel_id_idx");
                    });
        });

        modelBuilder.Entity<MailChannelMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_channel_member_pkey");

            entity.HasIndex(e => new { e.ChannelId, e.GuestId }, "mail_channel_member_guest_unique")
                .IsUnique()
                .HasFilter("(guest_id IS NOT NULL)");

            entity.HasIndex(e => new { e.ChannelId, e.PartnerId }, "mail_channel_member_partner_unique")
                .IsUnique()
                .HasFilter("(partner_id IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Channel).WithMany(p => p.MailChannelMembers)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mail_channel_member_channel_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailChannelMemberCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_channel_member_create_uid_fkey");

            entity.HasOne(d => d.FetchedMessage).WithMany(p => p.MailChannelMemberFetchedMessages)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_channel_member_fetched_message_id_fkey");

            entity.HasOne(d => d.Guest).WithMany(p => p.MailChannelMembers)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mail_channel_member_guest_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.MailChannelMembers)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mail_channel_member_partner_id_fkey");

            entity.HasOne(d => d.RtcInvitingSession).WithMany(p => p.MailChannelMembers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_channel_member_rtc_inviting_session_id_fkey");

            entity.HasOne(d => d.SeenMessage).WithMany(p => p.MailChannelMemberSeenMessages)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_channel_member_seen_message_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailChannelMemberWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_channel_member_write_uid_fkey");
        });

        modelBuilder.Entity<MailChannelRtcSession>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_channel_rtc_session_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Channel).WithMany(p => p.MailChannelRtcSessions)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_channel_rtc_session_channel_id_fkey");

            entity.HasOne(d => d.ChannelMember).WithOne(p => p.MailChannelRtcSession)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mail_channel_rtc_session_channel_member_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailChannelRtcSessionCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_channel_rtc_session_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailChannelRtcSessionWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_channel_rtc_session_write_uid_fkey");
        });

        modelBuilder.Entity<MailComposeMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_compose_message_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Author).WithMany(p => p.MailComposeMessages)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_compose_message_author_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailComposeMessageCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_compose_message_create_uid_fkey");

            entity.HasOne(d => d.MailActivityType).WithMany(p => p.MailComposeMessages)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_compose_message_mail_activity_type_id_fkey");

            entity.HasOne(d => d.MailServer).WithMany(p => p.MailComposeMessages)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_compose_message_mail_server_id_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.MailComposeMessages)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_compose_message_parent_id_fkey");

            entity.HasOne(d => d.Subtype).WithMany(p => p.MailComposeMessages)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_compose_message_subtype_id_fkey");

            entity.HasOne(d => d.Template).WithMany(p => p.MailComposeMessages)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_compose_message_template_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailComposeMessageWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_compose_message_write_uid_fkey");

            entity.HasMany(d => d.Attachments).WithMany(p => p.Wizards)
                .UsingEntity<Dictionary<string, object>>(
                    "MailComposeMessageIrAttachmentsRel",
                    r => r.HasOne<IrAttachment>().WithMany()
                        .HasForeignKey("AttachmentId")
                        .HasConstraintName("mail_compose_message_ir_attachments_rel_attachment_id_fkey"),
                    l => l.HasOne<MailComposeMessage>().WithMany()
                        .HasForeignKey("WizardId")
                        .HasConstraintName("mail_compose_message_ir_attachments_rel_wizard_id_fkey"),
                    j =>
                    {
                        j.HasKey("WizardId", "AttachmentId").HasName("mail_compose_message_ir_attachments_rel_pkey");
                        j.ToTable("mail_compose_message_ir_attachments_rel");
                        j.HasIndex(new[] { "AttachmentId", "WizardId" }, "mail_compose_message_ir_attachments_attachment_id_wizard_id_idx");
                    });

            entity.HasMany(d => d.Partners).WithMany(p => p.Wizards)
                .UsingEntity<Dictionary<string, object>>(
                    "MailComposeMessageResPartnerRel",
                    r => r.HasOne<ResPartner>().WithMany()
                        .HasForeignKey("PartnerId")
                        .HasConstraintName("mail_compose_message_res_partner_rel_partner_id_fkey"),
                    l => l.HasOne<MailComposeMessage>().WithMany()
                        .HasForeignKey("WizardId")
                        .HasConstraintName("mail_compose_message_res_partner_rel_wizard_id_fkey"),
                    j =>
                    {
                        j.HasKey("WizardId", "PartnerId").HasName("mail_compose_message_res_partner_rel_pkey");
                        j.ToTable("mail_compose_message_res_partner_rel");
                        j.HasIndex(new[] { "PartnerId", "WizardId" }, "mail_compose_message_res_partner_rel_partner_id_wizard_id_idx");
                    });
        });

        modelBuilder.Entity<MailFollower>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_followers_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Partner).WithMany(p => p.MailFollowers)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mail_followers_partner_id_fkey");

            entity.HasMany(d => d.MailMessageSubtypes).WithMany(p => p.MailFollowers)
                .UsingEntity<Dictionary<string, object>>(
                    "MailFollowersMailMessageSubtypeRel",
                    r => r.HasOne<MailMessageSubtype>().WithMany()
                        .HasForeignKey("MailMessageSubtypeId")
                        .HasConstraintName("mail_followers_mail_message_subtyp_mail_message_subtype_id_fkey"),
                    l => l.HasOne<MailFollower>().WithMany()
                        .HasForeignKey("MailFollowersId")
                        .HasConstraintName("mail_followers_mail_message_subtype_rel_mail_followers_id_fkey"),
                    j =>
                    {
                        j.HasKey("MailFollowersId", "MailMessageSubtypeId").HasName("mail_followers_mail_message_subtype_rel_pkey");
                        j.ToTable("mail_followers_mail_message_subtype_rel");
                        j.HasIndex(new[] { "MailMessageSubtypeId", "MailFollowersId" }, "mail_followers_mail_message_s_mail_message_subtype_id_mail__idx");
                    });
        });

        modelBuilder.Entity<MailGatewayAllowed>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_gateway_allowed_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailGatewayAllowedCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_gateway_allowed_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailGatewayAllowedWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_gateway_allowed_write_uid_fkey");
        });

        modelBuilder.Entity<MailGuest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_guest_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Country).WithMany(p => p.MailGuests)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_guest_country_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailGuestCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_guest_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailGuestWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_guest_write_uid_fkey");
        });

        modelBuilder.Entity<MailIceServer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_ice_server_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailIceServerCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_ice_server_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailIceServerWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_ice_server_write_uid_fkey");
        });

        modelBuilder.Entity<MailLinkPreview>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_link_preview_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailLinkPreviewCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_link_preview_create_uid_fkey");

            entity.HasOne(d => d.Message).WithMany(p => p.MailLinkPreviews)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mail_link_preview_message_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailLinkPreviewWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_link_preview_write_uid_fkey");
        });

        modelBuilder.Entity<MailMail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_mail_pkey");

            entity.HasIndex(e => e.Id, "mail_mail_to_delete_idx").HasFilter("(to_delete = true)");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailMailCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_mail_create_uid_fkey");

            entity.HasOne(d => d.FetchmailServer).WithMany(p => p.MailMails)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_mail_fetchmail_server_id_fkey");

            entity.HasOne(d => d.MailMessage).WithMany(p => p.MailMails)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mail_mail_mail_message_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailMailWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_mail_write_uid_fkey");

            entity.HasMany(d => d.ResPartners).WithMany(p => p.MailMails)
                .UsingEntity<Dictionary<string, object>>(
                    "MailMailResPartnerRel",
                    r => r.HasOne<ResPartner>().WithMany()
                        .HasForeignKey("ResPartnerId")
                        .HasConstraintName("mail_mail_res_partner_rel_res_partner_id_fkey"),
                    l => l.HasOne<MailMail>().WithMany()
                        .HasForeignKey("MailMailId")
                        .HasConstraintName("mail_mail_res_partner_rel_mail_mail_id_fkey"),
                    j =>
                    {
                        j.HasKey("MailMailId", "ResPartnerId").HasName("mail_mail_res_partner_rel_pkey");
                        j.ToTable("mail_mail_res_partner_rel");
                        j.HasIndex(new[] { "ResPartnerId", "MailMailId" }, "mail_mail_res_partner_rel_res_partner_id_mail_mail_id_idx");
                    });
        });

        modelBuilder.Entity<MailMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_message_pkey");

            entity.HasIndex(e => e.ParentId, "mail_message_parent_id_index").HasFilter("(parent_id IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.AuthorGuest).WithMany(p => p.MailMessages)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_message_author_guest_id_fkey");

            entity.HasOne(d => d.Author).WithMany(p => p.MailMessages)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_message_author_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailMessageCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_message_create_uid_fkey");

            entity.HasOne(d => d.MailActivityType).WithMany(p => p.MailMessages)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_message_mail_activity_type_id_fkey");

            entity.HasOne(d => d.MailServer).WithMany(p => p.MailMessages)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_message_mail_server_id_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_message_parent_id_fkey");

            entity.HasOne(d => d.Subtype).WithMany(p => p.MailMessages)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_message_subtype_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailMessageWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_message_write_uid_fkey");

            entity.HasMany(d => d.Attachments).WithMany(p => p.Messages)
                .UsingEntity<Dictionary<string, object>>(
                    "MessageAttachmentRel",
                    r => r.HasOne<IrAttachment>().WithMany()
                        .HasForeignKey("AttachmentId")
                        .HasConstraintName("message_attachment_rel_attachment_id_fkey"),
                    l => l.HasOne<MailMessage>().WithMany()
                        .HasForeignKey("MessageId")
                        .HasConstraintName("message_attachment_rel_message_id_fkey"),
                    j =>
                    {
                        j.HasKey("MessageId", "AttachmentId").HasName("message_attachment_rel_pkey");
                        j.ToTable("message_attachment_rel");
                        j.HasIndex(new[] { "AttachmentId", "MessageId" }, "message_attachment_rel_attachment_id_message_id_idx");
                    });

            entity.HasMany(d => d.ResPartners).WithMany(p => p.MailMessagesNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "MailMessageResPartnerRel",
                    r => r.HasOne<ResPartner>().WithMany()
                        .HasForeignKey("ResPartnerId")
                        .HasConstraintName("mail_message_res_partner_rel_res_partner_id_fkey"),
                    l => l.HasOne<MailMessage>().WithMany()
                        .HasForeignKey("MailMessageId")
                        .HasConstraintName("mail_message_res_partner_rel_mail_message_id_fkey"),
                    j =>
                    {
                        j.HasKey("MailMessageId", "ResPartnerId").HasName("mail_message_res_partner_rel_pkey");
                        j.ToTable("mail_message_res_partner_rel");
                        j.HasIndex(new[] { "ResPartnerId", "MailMessageId" }, "mail_message_res_partner_rel_res_partner_id_mail_message_id_idx");
                    });

            entity.HasMany(d => d.ResPartnersNavigation).WithMany(p => p.MailMessages1)
                .UsingEntity<Dictionary<string, object>>(
                    "MailMessageResPartnerStarredRel",
                    r => r.HasOne<ResPartner>().WithMany()
                        .HasForeignKey("ResPartnerId")
                        .HasConstraintName("mail_message_res_partner_starred_rel_res_partner_id_fkey"),
                    l => l.HasOne<MailMessage>().WithMany()
                        .HasForeignKey("MailMessageId")
                        .HasConstraintName("mail_message_res_partner_starred_rel_mail_message_id_fkey"),
                    j =>
                    {
                        j.HasKey("MailMessageId", "ResPartnerId").HasName("mail_message_res_partner_starred_rel_pkey");
                        j.ToTable("mail_message_res_partner_starred_rel");
                        j.HasIndex(new[] { "ResPartnerId", "MailMessageId" }, "mail_message_res_partner_star_res_partner_id_mail_message_i_idx");
                    });
        });

        modelBuilder.Entity<MailMessageReaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_message_reaction_pkey");

            entity.HasIndex(e => new { e.MessageId, e.Content, e.GuestId }, "mail_message_reaction_guest_unique")
                .IsUnique()
                .HasFilter("(guest_id IS NOT NULL)");

            entity.HasIndex(e => new { e.MessageId, e.Content, e.PartnerId }, "mail_message_reaction_partner_unique")
                .IsUnique()
                .HasFilter("(partner_id IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Guest).WithMany(p => p.MailMessageReactions)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mail_message_reaction_guest_id_fkey");

            entity.HasOne(d => d.Message).WithMany(p => p.MailMessageReactions)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mail_message_reaction_message_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.MailMessageReactions)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mail_message_reaction_partner_id_fkey");
        });

        modelBuilder.Entity<MailMessageSchedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_message_schedule_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailMessageScheduleCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_message_schedule_create_uid_fkey");

            entity.HasOne(d => d.MailMessage).WithMany(p => p.MailMessageSchedules)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mail_message_schedule_mail_message_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailMessageScheduleWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_message_schedule_write_uid_fkey");
        });

        modelBuilder.Entity<MailMessageSubtype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_message_subtype_pkey");

            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailMessageSubtypeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_message_subtype_create_uid_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_message_subtype_parent_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailMessageSubtypeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_message_subtype_write_uid_fkey");
        });

        modelBuilder.Entity<MailNotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_notification_pkey");

            entity.HasIndex(e => new { e.AuthorId, e.NotificationStatus }, "mail_notification_author_id_notification_status_failure").HasFilter("(notification_status = ANY (ARRAY[('bounce'::character varying)::text, ('exception'::character varying)::text]))");

            entity.HasIndex(e => e.LetterId, "mail_notification_letter_id_index").HasFilter("(letter_id IS NOT NULL)");

            entity.HasIndex(e => e.SmsId, "mail_notification_sms_id_index").HasFilter("(sms_id IS NOT NULL)");

            entity.HasIndex(e => new { e.MailMessageId, e.ResPartnerId }, "unique_mail_message_id_res_partner_id_if_set")
                .IsUnique()
                .HasFilter("(res_partner_id IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Author).WithMany(p => p.MailNotificationAuthors)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_notification_author_id_fkey");

            entity.HasOne(d => d.Letter).WithMany(p => p.MailNotifications)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mail_notification_letter_id_fkey");

            entity.HasOne(d => d.MailMail).WithMany(p => p.MailNotifications)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_notification_mail_mail_id_fkey");

            entity.HasOne(d => d.MailMessage).WithMany(p => p.MailNotifications)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mail_notification_mail_message_id_fkey");

            entity.HasOne(d => d.ResPartner).WithMany(p => p.MailNotificationResPartners)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mail_notification_res_partner_id_fkey");

            entity.HasOne(d => d.Sms).WithMany(p => p.MailNotifications)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_notification_sms_id_fkey");
        });

        modelBuilder.Entity<MailResendMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_resend_message_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailResendMessageCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_resend_message_create_uid_fkey");

            entity.HasOne(d => d.MailMessage).WithMany(p => p.MailResendMessages)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_resend_message_mail_message_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailResendMessageWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_resend_message_write_uid_fkey");

            entity.HasMany(d => d.MailNotifications).WithMany(p => p.MailResendMessages)
                .UsingEntity<Dictionary<string, object>>(
                    "MailNotificationMailResendMessageRel",
                    r => r.HasOne<MailNotification>().WithMany()
                        .HasForeignKey("MailNotificationId")
                        .HasConstraintName("mail_notification_mail_resend_message_mail_notification_id_fkey"),
                    l => l.HasOne<MailResendMessage>().WithMany()
                        .HasForeignKey("MailResendMessageId")
                        .HasConstraintName("mail_notification_mail_resend_messa_mail_resend_message_id_fkey"),
                    j =>
                    {
                        j.HasKey("MailResendMessageId", "MailNotificationId").HasName("mail_notification_mail_resend_message_rel_pkey");
                        j.ToTable("mail_notification_mail_resend_message_rel");
                        j.HasIndex(new[] { "MailNotificationId", "MailResendMessageId" }, "mail_notification_mail_resend_mail_notification_id_mail_res_idx");
                    });
        });

        modelBuilder.Entity<MailResendPartner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_resend_partner_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailResendPartnerCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_resend_partner_create_uid_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.MailResendPartners)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mail_resend_partner_partner_id_fkey");

            entity.HasOne(d => d.ResendWizard).WithMany(p => p.MailResendPartners)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_resend_partner_resend_wizard_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailResendPartnerWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_resend_partner_write_uid_fkey");
        });

        modelBuilder.Entity<MailShortcode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_shortcode_pkey");

            entity.HasIndex(e => e.Source, "mail_shortcode_source_index")
                .HasMethod("gin")
                .HasOperators(new[] { "gin_trgm_ops" });

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailShortcodeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_shortcode_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailShortcodeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_shortcode_write_uid_fkey");
        });

        modelBuilder.Entity<MailTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_template_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailTemplateCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_template_create_uid_fkey");

            entity.HasOne(d => d.MailServer).WithMany(p => p.MailTemplates)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_template_mail_server_id_fkey");

            entity.HasOne(d => d.ModelNavigation).WithMany(p => p.MailTemplates)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_template_model_id_fkey");

            entity.HasOne(d => d.RefIrActWindowNavigation).WithMany(p => p.MailTemplates)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_template_ref_ir_act_window_fkey");

            entity.HasOne(d => d.ReportTemplateNavigation).WithMany(p => p.MailTemplates)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_template_report_template_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailTemplateWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_template_write_uid_fkey");

            entity.HasMany(d => d.Attachments).WithMany(p => p.EmailTemplates)
                .UsingEntity<Dictionary<string, object>>(
                    "EmailTemplateAttachmentRel",
                    r => r.HasOne<IrAttachment>().WithMany()
                        .HasForeignKey("AttachmentId")
                        .HasConstraintName("email_template_attachment_rel_attachment_id_fkey"),
                    l => l.HasOne<MailTemplate>().WithMany()
                        .HasForeignKey("EmailTemplateId")
                        .HasConstraintName("email_template_attachment_rel_email_template_id_fkey"),
                    j =>
                    {
                        j.HasKey("EmailTemplateId", "AttachmentId").HasName("email_template_attachment_rel_pkey");
                        j.ToTable("email_template_attachment_rel");
                        j.HasIndex(new[] { "AttachmentId", "EmailTemplateId" }, "email_template_attachment_rel_attachment_id_email_template__idx");
                    });
        });

        modelBuilder.Entity<MailTemplatePreview>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_template_preview_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailTemplatePreviewCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_template_preview_create_uid_fkey");

            entity.HasOne(d => d.MailTemplate).WithMany(p => p.MailTemplatePreviews)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mail_template_preview_mail_template_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailTemplatePreviewWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_template_preview_write_uid_fkey");
        });

        modelBuilder.Entity<MailTemplateReset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_template_reset_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailTemplateResetCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_template_reset_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailTemplateResetWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_template_reset_write_uid_fkey");

            entity.HasMany(d => d.MailTemplates).WithMany(p => p.MailTemplateResets)
                .UsingEntity<Dictionary<string, object>>(
                    "MailTemplateMailTemplateResetRel",
                    r => r.HasOne<MailTemplate>().WithMany()
                        .HasForeignKey("MailTemplateId")
                        .HasConstraintName("mail_template_mail_template_reset_rel_mail_template_id_fkey"),
                    l => l.HasOne<MailTemplateReset>().WithMany()
                        .HasForeignKey("MailTemplateResetId")
                        .HasConstraintName("mail_template_mail_template_reset_r_mail_template_reset_id_fkey"),
                    j =>
                    {
                        j.HasKey("MailTemplateResetId", "MailTemplateId").HasName("mail_template_mail_template_reset_rel_pkey");
                        j.ToTable("mail_template_mail_template_reset_rel");
                        j.HasIndex(new[] { "MailTemplateId", "MailTemplateResetId" }, "mail_template_mail_template_r_mail_template_id_mail_templat_idx");
                    });
        });

        modelBuilder.Entity<MailTrackingValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_tracking_value_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailTrackingValueCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_tracking_value_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.MailTrackingValues)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_tracking_value_currency_id_fkey");

            entity.HasOne(d => d.FieldNavigation).WithMany(p => p.MailTrackingValues)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mail_tracking_value_field_fkey");

            entity.HasOne(d => d.MailMessage).WithMany(p => p.MailTrackingValues)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mail_tracking_value_mail_message_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailTrackingValueWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_tracking_value_write_uid_fkey");
        });

        modelBuilder.Entity<MailWizardInvite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_wizard_invite_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailWizardInviteCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_wizard_invite_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailWizardInviteWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_wizard_invite_write_uid_fkey");

            entity.HasMany(d => d.ResPartners).WithMany(p => p.MailWizardInvites)
                .UsingEntity<Dictionary<string, object>>(
                    "MailWizardInviteResPartnerRel",
                    r => r.HasOne<ResPartner>().WithMany()
                        .HasForeignKey("ResPartnerId")
                        .HasConstraintName("mail_wizard_invite_res_partner_rel_res_partner_id_fkey"),
                    l => l.HasOne<MailWizardInvite>().WithMany()
                        .HasForeignKey("MailWizardInviteId")
                        .HasConstraintName("mail_wizard_invite_res_partner_rel_mail_wizard_invite_id_fkey"),
                    j =>
                    {
                        j.HasKey("MailWizardInviteId", "ResPartnerId").HasName("mail_wizard_invite_res_partner_rel_pkey");
                        j.ToTable("mail_wizard_invite_res_partner_rel");
                        j.HasIndex(new[] { "ResPartnerId", "MailWizardInviteId" }, "mail_wizard_invite_res_partne_res_partner_id_mail_wizard_in_idx");
                    });
        });

        modelBuilder.Entity<MaintenanceEquipment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("maintenance_equipment_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Category).WithMany(p => p.MaintenanceEquipments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_equipment_category_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.MaintenanceEquipments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_equipment_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MaintenanceEquipmentCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_equipment_create_uid_fkey");

            entity.HasOne(d => d.Department).WithMany(p => p.MaintenanceEquipments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_equipment_department_id_fkey");

            entity.HasOne(d => d.Employee).WithMany(p => p.MaintenanceEquipments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_equipment_employee_id_fkey");

            entity.HasOne(d => d.MaintenanceTeam).WithMany(p => p.MaintenanceEquipments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_equipment_maintenance_team_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.MaintenanceEquipments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_equipment_message_main_attachment_id_fkey");

            entity.HasOne(d => d.OwnerUser).WithMany(p => p.MaintenanceEquipmentOwnerUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_equipment_owner_user_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.MaintenanceEquipments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_equipment_partner_id_fkey");

            entity.HasOne(d => d.TechnicianUser).WithMany(p => p.MaintenanceEquipmentTechnicianUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_equipment_technician_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MaintenanceEquipmentWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_equipment_write_uid_fkey");
        });

        modelBuilder.Entity<MaintenanceEquipmentCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("maintenance_equipment_category_pkey");

            entity.HasOne(d => d.Alias).WithMany(p => p.MaintenanceEquipmentCategories)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("maintenance_equipment_category_alias_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.MaintenanceEquipmentCategories)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_equipment_category_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MaintenanceEquipmentCategoryCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_equipment_category_create_uid_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.MaintenanceEquipmentCategories)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_equipment_category_message_main_attachment_id_fkey");

            entity.HasOne(d => d.TechnicianUser).WithMany(p => p.MaintenanceEquipmentCategoryTechnicianUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_equipment_category_technician_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MaintenanceEquipmentCategoryWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_equipment_category_write_uid_fkey");
        });

        modelBuilder.Entity<MaintenanceRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("maintenance_request_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Category).WithMany(p => p.MaintenanceRequests)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_request_category_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.MaintenanceRequests)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_request_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MaintenanceRequestCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_request_create_uid_fkey");

            entity.HasOne(d => d.Employee).WithMany(p => p.MaintenanceRequests)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_request_employee_id_fkey");

            entity.HasOne(d => d.Equipment).WithMany(p => p.MaintenanceRequests)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("maintenance_request_equipment_id_fkey");

            entity.HasOne(d => d.MaintenanceTeam).WithMany(p => p.MaintenanceRequests)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("maintenance_request_maintenance_team_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.MaintenanceRequests)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_request_message_main_attachment_id_fkey");

            entity.HasOne(d => d.OwnerUser).WithMany(p => p.MaintenanceRequestOwnerUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_request_owner_user_id_fkey");

            entity.HasOne(d => d.Stage).WithMany(p => p.MaintenanceRequests)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("maintenance_request_stage_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.MaintenanceRequestUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_request_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MaintenanceRequestWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_request_write_uid_fkey");
        });

        modelBuilder.Entity<MaintenanceStage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("maintenance_stage_pkey");

            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.MaintenanceStageCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_stage_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MaintenanceStageWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_stage_write_uid_fkey");
        });

        modelBuilder.Entity<MaintenanceTeam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("maintenance_team_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.MaintenanceTeams)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_team_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MaintenanceTeamCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_team_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MaintenanceTeamWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("maintenance_team_write_uid_fkey");

            entity.HasMany(d => d.ResUsers).WithMany(p => p.MaintenanceTeams)
                .UsingEntity<Dictionary<string, object>>(
                    "MaintenanceTeamUsersRel",
                    r => r.HasOne<ResUser>().WithMany()
                        .HasForeignKey("ResUsersId")
                        .HasConstraintName("maintenance_team_users_rel_res_users_id_fkey"),
                    l => l.HasOne<MaintenanceTeam>().WithMany()
                        .HasForeignKey("MaintenanceTeamId")
                        .HasConstraintName("maintenance_team_users_rel_maintenance_team_id_fkey"),
                    j =>
                    {
                        j.HasKey("MaintenanceTeamId", "ResUsersId").HasName("maintenance_team_users_rel_pkey");
                        j.ToTable("maintenance_team_users_rel");
                        j.HasIndex(new[] { "ResUsersId", "MaintenanceTeamId" }, "maintenance_team_users_rel_res_users_id_maintenance_team_id_idx");
                    });
        });

        modelBuilder.Entity<MrpBom>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mrp_bom_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Company).WithMany(p => p.MrpBoms)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_bom_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MrpBomCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_bom_create_uid_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.MrpBoms)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_bom_message_main_attachment_id_fkey");

            entity.HasOne(d => d.PickingType).WithMany(p => p.MrpBoms)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_bom_picking_type_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.MrpBoms)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_bom_product_id_fkey");

            entity.HasOne(d => d.ProductTmpl).WithMany(p => p.MrpBoms)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_bom_product_tmpl_id_fkey");

            entity.HasOne(d => d.ProductUom).WithMany(p => p.MrpBoms)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_bom_product_uom_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MrpBomWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_bom_write_uid_fkey");
        });

        modelBuilder.Entity<MrpBomByproduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mrp_bom_byproduct_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Bom).WithMany(p => p.MrpBomByproducts)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mrp_bom_byproduct_bom_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.MrpBomByproducts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_bom_byproduct_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MrpBomByproductCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_bom_byproduct_create_uid_fkey");

            entity.HasOne(d => d.Operation).WithMany(p => p.MrpBomByproducts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_bom_byproduct_operation_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.MrpBomByproducts)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_bom_byproduct_product_id_fkey");

            entity.HasOne(d => d.ProductUom).WithMany(p => p.MrpBomByproducts)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_bom_byproduct_product_uom_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MrpBomByproductWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_bom_byproduct_write_uid_fkey");

            entity.HasMany(d => d.ProductTemplateAttributeValues).WithMany(p => p.MrpBomByproducts)
                .UsingEntity<Dictionary<string, object>>(
                    "MrpBomByproductProductTemplateAttributeValueRel",
                    r => r.HasOne<ProductTemplateAttributeValue>().WithMany()
                        .HasForeignKey("ProductTemplateAttributeValueId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("mrp_bom_byproduct_product_tem_product_template_attribute_v_fkey"),
                    l => l.HasOne<MrpBomByproduct>().WithMany()
                        .HasForeignKey("MrpBomByproductId")
                        .HasConstraintName("mrp_bom_byproduct_product_template_at_mrp_bom_byproduct_id_fkey"),
                    j =>
                    {
                        j.HasKey("MrpBomByproductId", "ProductTemplateAttributeValueId").HasName("mrp_bom_byproduct_product_template_attribute_value_rel_pkey");
                        j.ToTable("mrp_bom_byproduct_product_template_attribute_value_rel");
                        j.HasIndex(new[] { "ProductTemplateAttributeValueId", "MrpBomByproductId" }, "mrp_bom_byproduct_product_tem_product_template_attribute_va_idx");
                    });
        });

        modelBuilder.Entity<MrpBomLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mrp_bom_line_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Bom).WithMany(p => p.MrpBomLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mrp_bom_line_bom_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.MrpBomLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_bom_line_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MrpBomLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_bom_line_create_uid_fkey");

            entity.HasOne(d => d.Operation).WithMany(p => p.MrpBomLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_bom_line_operation_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.MrpBomLines)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_bom_line_product_id_fkey");

            entity.HasOne(d => d.ProductTmpl).WithMany(p => p.MrpBomLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_bom_line_product_tmpl_id_fkey");

            entity.HasOne(d => d.ProductUom).WithMany(p => p.MrpBomLines)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_bom_line_product_uom_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MrpBomLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_bom_line_write_uid_fkey");

            entity.HasMany(d => d.ProductTemplateAttributeValues).WithMany(p => p.MrpBomLines)
                .UsingEntity<Dictionary<string, object>>(
                    "MrpBomLineProductTemplateAttributeValueRel",
                    r => r.HasOne<ProductTemplateAttributeValue>().WithMany()
                        .HasForeignKey("ProductTemplateAttributeValueId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("mrp_bom_line_product_template_product_template_attribute_v_fkey"),
                    l => l.HasOne<MrpBomLine>().WithMany()
                        .HasForeignKey("MrpBomLineId")
                        .HasConstraintName("mrp_bom_line_product_template_attribute_va_mrp_bom_line_id_fkey"),
                    j =>
                    {
                        j.HasKey("MrpBomLineId", "ProductTemplateAttributeValueId").HasName("mrp_bom_line_product_template_attribute_value_rel_pkey");
                        j.ToTable("mrp_bom_line_product_template_attribute_value_rel");
                        j.HasIndex(new[] { "ProductTemplateAttributeValueId", "MrpBomLineId" }, "mrp_bom_line_product_template_product_template_attribute_va_idx");
                    });
        });

        modelBuilder.Entity<MrpConsumptionWarning>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mrp_consumption_warning_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MrpConsumptionWarningCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_consumption_warning_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MrpConsumptionWarningWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_consumption_warning_write_uid_fkey");

            entity.HasMany(d => d.MrpProductions).WithMany(p => p.MrpConsumptionWarnings)
                .UsingEntity<Dictionary<string, object>>(
                    "MrpConsumptionWarningMrpProductionRel",
                    r => r.HasOne<MrpProduction>().WithMany()
                        .HasForeignKey("MrpProductionId")
                        .HasConstraintName("mrp_consumption_warning_mrp_production_r_mrp_production_id_fkey"),
                    l => l.HasOne<MrpConsumptionWarning>().WithMany()
                        .HasForeignKey("MrpConsumptionWarningId")
                        .HasConstraintName("mrp_consumption_warning_mrp_pro_mrp_consumption_warning_id_fkey"),
                    j =>
                    {
                        j.HasKey("MrpConsumptionWarningId", "MrpProductionId").HasName("mrp_consumption_warning_mrp_production_rel_pkey");
                        j.ToTable("mrp_consumption_warning_mrp_production_rel");
                        j.HasIndex(new[] { "MrpProductionId", "MrpConsumptionWarningId" }, "mrp_consumption_warning_mrp_p_mrp_production_id_mrp_consump_idx");
                    });
        });

        modelBuilder.Entity<MrpConsumptionWarningLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mrp_consumption_warning_line_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MrpConsumptionWarningLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_consumption_warning_line_create_uid_fkey");

            entity.HasOne(d => d.MrpConsumptionWarning).WithMany(p => p.MrpConsumptionWarningLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mrp_consumption_warning_line_mrp_consumption_warning_id_fkey");

            entity.HasOne(d => d.MrpProduction).WithMany(p => p.MrpConsumptionWarningLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mrp_consumption_warning_line_mrp_production_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.MrpConsumptionWarningLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mrp_consumption_warning_line_product_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MrpConsumptionWarningLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_consumption_warning_line_write_uid_fkey");
        });

        modelBuilder.Entity<MrpDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mrp_document_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MrpDocumentCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_document_create_uid_fkey");

            entity.HasOne(d => d.IrAttachment).WithMany(p => p.MrpDocuments)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mrp_document_ir_attachment_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MrpDocumentWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_document_write_uid_fkey");
        });

        modelBuilder.Entity<MrpImmediateProduction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mrp_immediate_production_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MrpImmediateProductionCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_immediate_production_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MrpImmediateProductionWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_immediate_production_write_uid_fkey");

            entity.HasMany(d => d.MrpProductions).WithMany(p => p.MrpImmediateProductions)
                .UsingEntity<Dictionary<string, object>>(
                    "MrpProductionProductionRel",
                    r => r.HasOne<MrpProduction>().WithMany()
                        .HasForeignKey("MrpProductionId")
                        .HasConstraintName("mrp_production_production_rel_mrp_production_id_fkey"),
                    l => l.HasOne<MrpImmediateProduction>().WithMany()
                        .HasForeignKey("MrpImmediateProductionId")
                        .HasConstraintName("mrp_production_production_rel_mrp_immediate_production_id_fkey"),
                    j =>
                    {
                        j.HasKey("MrpImmediateProductionId", "MrpProductionId").HasName("mrp_production_production_rel_pkey");
                        j.ToTable("mrp_production_production_rel");
                        j.HasIndex(new[] { "MrpProductionId", "MrpImmediateProductionId" }, "mrp_production_production_rel_mrp_production_id_mrp_immedia_idx");
                    });
        });

        modelBuilder.Entity<MrpImmediateProductionLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mrp_immediate_production_line_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MrpImmediateProductionLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_immediate_production_line_create_uid_fkey");

            entity.HasOne(d => d.ImmediateProduction).WithMany(p => p.MrpImmediateProductionLines)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_immediate_production_line_immediate_production_id_fkey");

            entity.HasOne(d => d.Production).WithMany(p => p.MrpImmediateProductionLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mrp_immediate_production_line_production_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MrpImmediateProductionLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_immediate_production_line_write_uid_fkey");
        });

        modelBuilder.Entity<MrpProduction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mrp_production_pkey");

            entity.HasIndex(e => e.OrderpointId, "mrp_production_orderpoint_id_index").HasFilter("(orderpoint_id IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.BackorderSequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.AnalyticAccount).WithMany(p => p.MrpProductions)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_production_analytic_account_id_fkey");

            entity.HasOne(d => d.Bom).WithMany(p => p.MrpProductions)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_production_bom_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.MrpProductions)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_production_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MrpProductionCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_production_create_uid_fkey");

            entity.HasOne(d => d.LocationDest).WithMany(p => p.MrpProductionLocationDests)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_production_location_dest_id_fkey");

            entity.HasOne(d => d.LocationSrc).WithMany(p => p.MrpProductionLocationSrcs)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_production_location_src_id_fkey");

            entity.HasOne(d => d.LotProducing).WithMany(p => p.MrpProductions)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_production_lot_producing_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.MrpProductions)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_production_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Orderpoint).WithMany(p => p.MrpProductions)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_production_orderpoint_id_fkey");

            entity.HasOne(d => d.PickingType).WithMany(p => p.MrpProductions)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_production_picking_type_id_fkey");

            entity.HasOne(d => d.ProcurementGroup).WithMany(p => p.MrpProductions)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_production_procurement_group_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.MrpProductions)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_production_product_id_fkey");

            entity.HasOne(d => d.ProductUom).WithMany(p => p.MrpProductions)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_production_product_uom_id_fkey");

            entity.HasOne(d => d.ProductionLocation).WithMany(p => p.MrpProductionProductionLocations)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_production_production_location_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.MrpProductionUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_production_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MrpProductionWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_production_write_uid_fkey");
        });

        modelBuilder.Entity<MrpProductionBackorder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mrp_production_backorder_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MrpProductionBackorderCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_production_backorder_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MrpProductionBackorderWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_production_backorder_write_uid_fkey");

            entity.HasMany(d => d.MrpProductions).WithMany(p => p.MrpProductionBackorders)
                .UsingEntity<Dictionary<string, object>>(
                    "MrpProductionMrpProductionBackorderRel",
                    r => r.HasOne<MrpProduction>().WithMany()
                        .HasForeignKey("MrpProductionId")
                        .HasConstraintName("mrp_production_mrp_production_backorder__mrp_production_id_fkey"),
                    l => l.HasOne<MrpProductionBackorder>().WithMany()
                        .HasForeignKey("MrpProductionBackorderId")
                        .HasConstraintName("mrp_production_mrp_production__mrp_production_backorder_id_fkey"),
                    j =>
                    {
                        j.HasKey("MrpProductionBackorderId", "MrpProductionId").HasName("mrp_production_mrp_production_backorder_rel_pkey");
                        j.ToTable("mrp_production_mrp_production_backorder_rel");
                        j.HasIndex(new[] { "MrpProductionId", "MrpProductionBackorderId" }, "mrp_production_mrp_production_mrp_production_id_mrp_product_idx");
                    });
        });

        modelBuilder.Entity<MrpProductionBackorderLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mrp_production_backorder_line_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MrpProductionBackorderLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_production_backorder_line_create_uid_fkey");

            entity.HasOne(d => d.MrpProductionBackorder).WithMany(p => p.MrpProductionBackorderLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mrp_production_backorder_line_mrp_production_backorder_id_fkey");

            entity.HasOne(d => d.MrpProduction).WithMany(p => p.MrpProductionBackorderLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mrp_production_backorder_line_mrp_production_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MrpProductionBackorderLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_production_backorder_line_write_uid_fkey");
        });

        modelBuilder.Entity<MrpProductionSplit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mrp_production_split_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MrpProductionSplitCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_production_split_create_uid_fkey");

            entity.HasOne(d => d.Production).WithMany(p => p.MrpProductionSplits)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_production_split_production_id_fkey");

            entity.HasOne(d => d.ProductionSplitMulti).WithMany(p => p.MrpProductionSplits)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_production_split_production_split_multi_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MrpProductionSplitWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_production_split_write_uid_fkey");
        });

        modelBuilder.Entity<MrpProductionSplitLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mrp_production_split_line_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MrpProductionSplitLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_production_split_line_create_uid_fkey");

            entity.HasOne(d => d.MrpProductionSplit).WithMany(p => p.MrpProductionSplitLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mrp_production_split_line_mrp_production_split_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.MrpProductionSplitLineUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_production_split_line_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MrpProductionSplitLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_production_split_line_write_uid_fkey");
        });

        modelBuilder.Entity<MrpProductionSplitMulti>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mrp_production_split_multi_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MrpProductionSplitMultiCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_production_split_multi_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MrpProductionSplitMultiWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_production_split_multi_write_uid_fkey");
        });

        modelBuilder.Entity<MrpRoutingWorkcenter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mrp_routing_workcenter_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Bom).WithMany(p => p.MrpRoutingWorkcenters)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("mrp_routing_workcenter_bom_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MrpRoutingWorkcenterCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_routing_workcenter_create_uid_fkey");

            entity.HasOne(d => d.Workcenter).WithMany(p => p.MrpRoutingWorkcenters)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_routing_workcenter_workcenter_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MrpRoutingWorkcenterWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_routing_workcenter_write_uid_fkey");

            entity.HasMany(d => d.BlockedBies).WithMany(p => p.Operations)
                .UsingEntity<Dictionary<string, object>>(
                    "MrpRoutingWorkcenterDependenciesRel",
                    r => r.HasOne<MrpRoutingWorkcenter>().WithMany()
                        .HasForeignKey("BlockedById")
                        .HasConstraintName("mrp_routing_workcenter_dependencies_rel_blocked_by_id_fkey"),
                    l => l.HasOne<MrpRoutingWorkcenter>().WithMany()
                        .HasForeignKey("OperationId")
                        .HasConstraintName("mrp_routing_workcenter_dependencies_rel_operation_id_fkey"),
                    j =>
                    {
                        j.HasKey("OperationId", "BlockedById").HasName("mrp_routing_workcenter_dependencies_rel_pkey");
                        j.ToTable("mrp_routing_workcenter_dependencies_rel");
                        j.HasIndex(new[] { "BlockedById", "OperationId" }, "mrp_routing_workcenter_dependenc_blocked_by_id_operation_id_idx");
                    });

            entity.HasMany(d => d.Operations).WithMany(p => p.BlockedBies)
                .UsingEntity<Dictionary<string, object>>(
                    "MrpRoutingWorkcenterDependenciesRel",
                    r => r.HasOne<MrpRoutingWorkcenter>().WithMany()
                        .HasForeignKey("OperationId")
                        .HasConstraintName("mrp_routing_workcenter_dependencies_rel_operation_id_fkey"),
                    l => l.HasOne<MrpRoutingWorkcenter>().WithMany()
                        .HasForeignKey("BlockedById")
                        .HasConstraintName("mrp_routing_workcenter_dependencies_rel_blocked_by_id_fkey"),
                    j =>
                    {
                        j.HasKey("OperationId", "BlockedById").HasName("mrp_routing_workcenter_dependencies_rel_pkey");
                        j.ToTable("mrp_routing_workcenter_dependencies_rel");
                        j.HasIndex(new[] { "BlockedById", "OperationId" }, "mrp_routing_workcenter_dependenc_blocked_by_id_operation_id_idx");
                    });

            entity.HasMany(d => d.ProductTemplateAttributeValues).WithMany(p => p.MrpRoutingWorkcenters)
                .UsingEntity<Dictionary<string, object>>(
                    "MrpRoutingWorkcenterProductTemplateAttributeValueRel",
                    r => r.HasOne<ProductTemplateAttributeValue>().WithMany()
                        .HasForeignKey("ProductTemplateAttributeValueId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("mrp_routing_workcenter_produc_product_template_attribute_v_fkey"),
                    l => l.HasOne<MrpRoutingWorkcenter>().WithMany()
                        .HasForeignKey("MrpRoutingWorkcenterId")
                        .HasConstraintName("mrp_routing_workcenter_product_t_mrp_routing_workcenter_id_fkey"),
                    j =>
                    {
                        j.HasKey("MrpRoutingWorkcenterId", "ProductTemplateAttributeValueId").HasName("mrp_routing_workcenter_product_template_attribute_value_re_pkey");
                        j.ToTable("mrp_routing_workcenter_product_template_attribute_value_rel");
                        j.HasIndex(new[] { "ProductTemplateAttributeValueId", "MrpRoutingWorkcenterId" }, "mrp_routing_workcenter_produc_product_template_attribute_va_idx");
                    });
        });

        modelBuilder.Entity<MrpUnbuild>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mrp_unbuild_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Bom).WithMany(p => p.MrpUnbuilds)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_unbuild_bom_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.MrpUnbuilds)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_unbuild_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MrpUnbuildCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_unbuild_create_uid_fkey");

            entity.HasOne(d => d.LocationDest).WithMany(p => p.MrpUnbuildLocationDests)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_unbuild_location_dest_id_fkey");

            entity.HasOne(d => d.Location).WithMany(p => p.MrpUnbuildLocations)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_unbuild_location_id_fkey");

            entity.HasOne(d => d.Lot).WithMany(p => p.MrpUnbuilds)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_unbuild_lot_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.MrpUnbuilds)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_unbuild_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Mo).WithMany(p => p.MrpUnbuilds)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_unbuild_mo_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.MrpUnbuilds)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_unbuild_product_id_fkey");

            entity.HasOne(d => d.ProductUom).WithMany(p => p.MrpUnbuilds)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_unbuild_product_uom_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MrpUnbuildWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_unbuild_write_uid_fkey");
        });

        modelBuilder.Entity<MrpWorkcenter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mrp_workcenter_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Company).WithMany(p => p.MrpWorkcenters)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_workcenter_company_id_fkey");

            entity.HasOne(d => d.CostsHourAccount).WithMany(p => p.MrpWorkcenters)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_workcenter_costs_hour_account_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MrpWorkcenterCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_workcenter_create_uid_fkey");

            entity.HasOne(d => d.ResourceCalendar).WithMany(p => p.MrpWorkcenters)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_workcenter_resource_calendar_id_fkey");

            entity.HasOne(d => d.Resource).WithMany(p => p.MrpWorkcenters)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_workcenter_resource_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MrpWorkcenterWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_workcenter_write_uid_fkey");

            entity.HasMany(d => d.AlternativeWorkcenters).WithMany(p => p.Workcenters)
                .UsingEntity<Dictionary<string, object>>(
                    "MrpWorkcenterAlternativeRel",
                    r => r.HasOne<MrpWorkcenter>().WithMany()
                        .HasForeignKey("AlternativeWorkcenterId")
                        .HasConstraintName("mrp_workcenter_alternative_rel_alternative_workcenter_id_fkey"),
                    l => l.HasOne<MrpWorkcenter>().WithMany()
                        .HasForeignKey("WorkcenterId")
                        .HasConstraintName("mrp_workcenter_alternative_rel_workcenter_id_fkey"),
                    j =>
                    {
                        j.HasKey("WorkcenterId", "AlternativeWorkcenterId").HasName("mrp_workcenter_alternative_rel_pkey");
                        j.ToTable("mrp_workcenter_alternative_rel");
                        j.HasIndex(new[] { "AlternativeWorkcenterId", "WorkcenterId" }, "mrp_workcenter_alternative_re_alternative_workcenter_id_wor_idx");
                    });

            entity.HasMany(d => d.MrpWorkcenterTags).WithMany(p => p.MrpWorkcenters)
                .UsingEntity<Dictionary<string, object>>(
                    "MrpWorkcenterMrpWorkcenterTagRel",
                    r => r.HasOne<MrpWorkcenterTag>().WithMany()
                        .HasForeignKey("MrpWorkcenterTagId")
                        .HasConstraintName("mrp_workcenter_mrp_workcenter_tag_re_mrp_workcenter_tag_id_fkey"),
                    l => l.HasOne<MrpWorkcenter>().WithMany()
                        .HasForeignKey("MrpWorkcenterId")
                        .HasConstraintName("mrp_workcenter_mrp_workcenter_tag_rel_mrp_workcenter_id_fkey"),
                    j =>
                    {
                        j.HasKey("MrpWorkcenterId", "MrpWorkcenterTagId").HasName("mrp_workcenter_mrp_workcenter_tag_rel_pkey");
                        j.ToTable("mrp_workcenter_mrp_workcenter_tag_rel");
                        j.HasIndex(new[] { "MrpWorkcenterTagId", "MrpWorkcenterId" }, "mrp_workcenter_mrp_workcenter_mrp_workcenter_tag_id_mrp_wor_idx");
                    });

            entity.HasMany(d => d.Workcenters).WithMany(p => p.AlternativeWorkcenters)
                .UsingEntity<Dictionary<string, object>>(
                    "MrpWorkcenterAlternativeRel",
                    r => r.HasOne<MrpWorkcenter>().WithMany()
                        .HasForeignKey("WorkcenterId")
                        .HasConstraintName("mrp_workcenter_alternative_rel_workcenter_id_fkey"),
                    l => l.HasOne<MrpWorkcenter>().WithMany()
                        .HasForeignKey("AlternativeWorkcenterId")
                        .HasConstraintName("mrp_workcenter_alternative_rel_alternative_workcenter_id_fkey"),
                    j =>
                    {
                        j.HasKey("WorkcenterId", "AlternativeWorkcenterId").HasName("mrp_workcenter_alternative_rel_pkey");
                        j.ToTable("mrp_workcenter_alternative_rel");
                        j.HasIndex(new[] { "AlternativeWorkcenterId", "WorkcenterId" }, "mrp_workcenter_alternative_re_alternative_workcenter_id_wor_idx");
                    });
        });

        modelBuilder.Entity<MrpWorkcenterCapacity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mrp_workcenter_capacity_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MrpWorkcenterCapacityCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_workcenter_capacity_create_uid_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.MrpWorkcenterCapacities)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_workcenter_capacity_product_id_fkey");

            entity.HasOne(d => d.Workcenter).WithMany(p => p.MrpWorkcenterCapacities)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_workcenter_capacity_workcenter_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MrpWorkcenterCapacityWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_workcenter_capacity_write_uid_fkey");
        });

        modelBuilder.Entity<MrpWorkcenterProductivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mrp_workcenter_productivity_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.MrpWorkcenterProductivities)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_workcenter_productivity_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MrpWorkcenterProductivityCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_workcenter_productivity_create_uid_fkey");

            entity.HasOne(d => d.Loss).WithMany(p => p.MrpWorkcenterProductivities)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_workcenter_productivity_loss_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.MrpWorkcenterProductivityUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_workcenter_productivity_user_id_fkey");

            entity.HasOne(d => d.Workcenter).WithMany(p => p.MrpWorkcenterProductivities)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_workcenter_productivity_workcenter_id_fkey");

            entity.HasOne(d => d.Workorder).WithMany(p => p.MrpWorkcenterProductivities)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_workcenter_productivity_workorder_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MrpWorkcenterProductivityWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_workcenter_productivity_write_uid_fkey");
        });

        modelBuilder.Entity<MrpWorkcenterProductivityLoss>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mrp_workcenter_productivity_loss_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.MrpWorkcenterProductivityLossCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_workcenter_productivity_loss_create_uid_fkey");

            entity.HasOne(d => d.Loss).WithMany(p => p.MrpWorkcenterProductivityLosses)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_workcenter_productivity_loss_loss_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MrpWorkcenterProductivityLossWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_workcenter_productivity_loss_write_uid_fkey");
        });

        modelBuilder.Entity<MrpWorkcenterProductivityLossType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mrp_workcenter_productivity_loss_type_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MrpWorkcenterProductivityLossTypeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_workcenter_productivity_loss_type_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MrpWorkcenterProductivityLossTypeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_workcenter_productivity_loss_type_write_uid_fkey");
        });

        modelBuilder.Entity<MrpWorkcenterTag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mrp_workcenter_tag_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MrpWorkcenterTagCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_workcenter_tag_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MrpWorkcenterTagWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_workcenter_tag_write_uid_fkey");
        });

        modelBuilder.Entity<MrpWorkorder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mrp_workorder_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MrpWorkorderCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_workorder_create_uid_fkey");

            entity.HasOne(d => d.Leave).WithMany(p => p.MrpWorkorders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_workorder_leave_id_fkey");

            entity.HasOne(d => d.MoAnalyticAccountLine).WithMany(p => p.MrpWorkorderMoAnalyticAccountLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_workorder_mo_analytic_account_line_id_fkey");

            entity.HasOne(d => d.Operation).WithMany(p => p.MrpWorkorders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_workorder_operation_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.MrpWorkorders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_workorder_product_id_fkey");

            entity.HasOne(d => d.ProductUom).WithMany(p => p.MrpWorkorders)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_workorder_product_uom_id_fkey");

            entity.HasOne(d => d.Production).WithMany(p => p.MrpWorkorders)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_workorder_production_id_fkey");

            entity.HasOne(d => d.WcAnalyticAccountLine).WithMany(p => p.MrpWorkorderWcAnalyticAccountLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_workorder_wc_analytic_account_line_id_fkey");

            entity.HasOne(d => d.Workcenter).WithMany(p => p.MrpWorkorders)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mrp_workorder_workcenter_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MrpWorkorderWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mrp_workorder_write_uid_fkey");

            entity.HasMany(d => d.BlockedBies).WithMany(p => p.Workorders)
                .UsingEntity<Dictionary<string, object>>(
                    "MrpWorkorderDependenciesRel",
                    r => r.HasOne<MrpWorkorder>().WithMany()
                        .HasForeignKey("BlockedById")
                        .HasConstraintName("mrp_workorder_dependencies_rel_blocked_by_id_fkey"),
                    l => l.HasOne<MrpWorkorder>().WithMany()
                        .HasForeignKey("WorkorderId")
                        .HasConstraintName("mrp_workorder_dependencies_rel_workorder_id_fkey"),
                    j =>
                    {
                        j.HasKey("WorkorderId", "BlockedById").HasName("mrp_workorder_dependencies_rel_pkey");
                        j.ToTable("mrp_workorder_dependencies_rel");
                        j.HasIndex(new[] { "BlockedById", "WorkorderId" }, "mrp_workorder_dependencies_rel_blocked_by_id_workorder_id_idx");
                    });

            entity.HasMany(d => d.Workorders).WithMany(p => p.BlockedBies)
                .UsingEntity<Dictionary<string, object>>(
                    "MrpWorkorderDependenciesRel",
                    r => r.HasOne<MrpWorkorder>().WithMany()
                        .HasForeignKey("WorkorderId")
                        .HasConstraintName("mrp_workorder_dependencies_rel_workorder_id_fkey"),
                    l => l.HasOne<MrpWorkorder>().WithMany()
                        .HasForeignKey("BlockedById")
                        .HasConstraintName("mrp_workorder_dependencies_rel_blocked_by_id_fkey"),
                    j =>
                    {
                        j.HasKey("WorkorderId", "BlockedById").HasName("mrp_workorder_dependencies_rel_pkey");
                        j.ToTable("mrp_workorder_dependencies_rel");
                        j.HasIndex(new[] { "BlockedById", "WorkorderId" }, "mrp_workorder_dependencies_rel_blocked_by_id_workorder_id_idx");
                    });
        });

        modelBuilder.Entity<NoteNote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("note_note_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Company).WithMany(p => p.NoteNotes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("note_note_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.NoteNoteCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("note_note_create_uid_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.NoteNotes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("note_note_message_main_attachment_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.NoteNoteUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("note_note_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.NoteNoteWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("note_note_write_uid_fkey");

            entity.HasMany(d => d.Stages).WithMany(p => p.Notes)
                .UsingEntity<Dictionary<string, object>>(
                    "NoteStageRel",
                    r => r.HasOne<NoteStage>().WithMany()
                        .HasForeignKey("StageId")
                        .HasConstraintName("note_stage_rel_stage_id_fkey"),
                    l => l.HasOne<NoteNote>().WithMany()
                        .HasForeignKey("NoteId")
                        .HasConstraintName("note_stage_rel_note_id_fkey"),
                    j =>
                    {
                        j.HasKey("NoteId", "StageId").HasName("note_stage_rel_pkey");
                        j.ToTable("note_stage_rel");
                        j.HasIndex(new[] { "StageId", "NoteId" }, "note_stage_rel_stage_id_note_id_idx");
                    });

            entity.HasMany(d => d.Tags).WithMany(p => p.Notes)
                .UsingEntity<Dictionary<string, object>>(
                    "NoteTagsRel",
                    r => r.HasOne<NoteTag>().WithMany()
                        .HasForeignKey("TagId")
                        .HasConstraintName("note_tags_rel_tag_id_fkey"),
                    l => l.HasOne<NoteNote>().WithMany()
                        .HasForeignKey("NoteId")
                        .HasConstraintName("note_tags_rel_note_id_fkey"),
                    j =>
                    {
                        j.HasKey("NoteId", "TagId").HasName("note_tags_rel_pkey");
                        j.ToTable("note_tags_rel");
                        j.HasIndex(new[] { "TagId", "NoteId" }, "note_tags_rel_tag_id_note_id_idx");
                    });
        });

        modelBuilder.Entity<NoteStage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("note_stage_pkey");

            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.NoteStageCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("note_stage_create_uid_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.NoteStageUsers)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("note_stage_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.NoteStageWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("note_stage_write_uid_fkey");
        });

        modelBuilder.Entity<NoteTag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("note_tag_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.NoteTagCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("note_tag_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.NoteTagWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("note_tag_write_uid_fkey");
        });

        modelBuilder.Entity<PartnerStatRel>(entity =>
        {
            entity.HasKey(e => new { e.OsvMemoryId, e.PartnerId }).HasName("partner_stat_rel_pkey");

            entity.HasOne(d => d.OsvMemory).WithMany(p => p.PartnerStatRels).HasConstraintName("partner_stat_rel_osv_memory_id_fkey");
        });

        modelBuilder.Entity<PaymentIcon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payment_icon_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.PaymentIconCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("payment_icon_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PaymentIconWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("payment_icon_write_uid_fkey");
        });

        modelBuilder.Entity<PaymentLinkWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payment_link_wizard_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PaymentLinkWizardCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("payment_link_wizard_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.PaymentLinkWizards)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("payment_link_wizard_currency_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.PaymentLinkWizards)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("payment_link_wizard_partner_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PaymentLinkWizardWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("payment_link_wizard_write_uid_fkey");
        });

        modelBuilder.Entity<PaymentProvider>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payment_provider_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.PaymentProviders)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("payment_provider_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PaymentProviderCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("payment_provider_create_uid_fkey");

            entity.HasOne(d => d.ExpressCheckoutFormView).WithMany(p => p.PaymentProviderExpressCheckoutFormViews)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("payment_provider_express_checkout_form_view_id_fkey");

            entity.HasOne(d => d.InlineFormView).WithMany(p => p.PaymentProviderInlineFormViews)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("payment_provider_inline_form_view_id_fkey");

            entity.HasOne(d => d.Module).WithMany(p => p.PaymentProviders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("payment_provider_module_id_fkey");

            entity.HasOne(d => d.RedirectFormView).WithMany(p => p.PaymentProviderRedirectFormViews)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("payment_provider_redirect_form_view_id_fkey");

            entity.HasOne(d => d.TokenInlineFormView).WithMany(p => p.PaymentProviderTokenInlineFormViews)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("payment_provider_token_inline_form_view_id_fkey");

            entity.HasOne(d => d.Website).WithMany(p => p.PaymentProviders)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("payment_provider_website_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PaymentProviderWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("payment_provider_write_uid_fkey");

            entity.HasMany(d => d.Countries).WithMany(p => p.Payments)
                .UsingEntity<Dictionary<string, object>>(
                    "PaymentCountryRel",
                    r => r.HasOne<ResCountry>().WithMany()
                        .HasForeignKey("CountryId")
                        .HasConstraintName("payment_country_rel_country_id_fkey"),
                    l => l.HasOne<PaymentProvider>().WithMany()
                        .HasForeignKey("PaymentId")
                        .HasConstraintName("payment_country_rel_payment_id_fkey"),
                    j =>
                    {
                        j.HasKey("PaymentId", "CountryId").HasName("payment_country_rel_pkey");
                        j.ToTable("payment_country_rel");
                        j.HasIndex(new[] { "CountryId", "PaymentId" }, "payment_country_rel_country_id_payment_id_idx");
                    });

            entity.HasMany(d => d.PaymentIcons).WithMany(p => p.PaymentProviders)
                .UsingEntity<Dictionary<string, object>>(
                    "PaymentIconPaymentProviderRel",
                    r => r.HasOne<PaymentIcon>().WithMany()
                        .HasForeignKey("PaymentIconId")
                        .HasConstraintName("payment_icon_payment_provider_rel_payment_icon_id_fkey"),
                    l => l.HasOne<PaymentProvider>().WithMany()
                        .HasForeignKey("PaymentProviderId")
                        .HasConstraintName("payment_icon_payment_provider_rel_payment_provider_id_fkey"),
                    j =>
                    {
                        j.HasKey("PaymentProviderId", "PaymentIconId").HasName("payment_icon_payment_provider_rel_pkey");
                        j.ToTable("payment_icon_payment_provider_rel");
                        j.HasIndex(new[] { "PaymentIconId", "PaymentProviderId" }, "payment_icon_payment_provider_payment_icon_id_payment_provi_idx");
                    });
        });

        modelBuilder.Entity<PaymentProviderOnboardingWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payment_provider_onboarding_wizard_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PaymentProviderOnboardingWizardCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("payment_provider_onboarding_wizard_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PaymentProviderOnboardingWizardWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("payment_provider_onboarding_wizard_write_uid_fkey");
        });

        modelBuilder.Entity<PaymentRefundWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payment_refund_wizard_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PaymentRefundWizardCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("payment_refund_wizard_create_uid_fkey");

            entity.HasOne(d => d.Payment).WithMany(p => p.PaymentRefundWizards)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("payment_refund_wizard_payment_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PaymentRefundWizardWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("payment_refund_wizard_write_uid_fkey");
        });

        modelBuilder.Entity<PaymentToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payment_token_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.PaymentTokens)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("payment_token_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PaymentTokenCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("payment_token_create_uid_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.PaymentTokens)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("payment_token_partner_id_fkey");

            entity.HasOne(d => d.Provider).WithMany(p => p.PaymentTokens)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("payment_token_provider_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PaymentTokenWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("payment_token_write_uid_fkey");
        });

        modelBuilder.Entity<PaymentTransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payment_transaction_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CallbackModel).WithMany(p => p.PaymentTransactions)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("payment_transaction_callback_model_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.PaymentTransactions)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("payment_transaction_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PaymentTransactionCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("payment_transaction_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.PaymentTransactions)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("payment_transaction_currency_id_fkey");

            entity.HasOne(d => d.PartnerCountry).WithMany(p => p.PaymentTransactions)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("payment_transaction_partner_country_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.PaymentTransactions)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("payment_transaction_partner_id_fkey");

            entity.HasOne(d => d.PartnerState).WithMany(p => p.PaymentTransactions)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("payment_transaction_partner_state_id_fkey");

            entity.HasOne(d => d.Payment).WithMany(p => p.PaymentTransactions)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("payment_transaction_payment_id_fkey");

            entity.HasOne(d => d.Provider).WithMany(p => p.PaymentTransactions)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("payment_transaction_provider_id_fkey");

            entity.HasOne(d => d.SourceTransaction).WithMany(p => p.InverseSourceTransaction)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("payment_transaction_source_transaction_id_fkey");

            entity.HasOne(d => d.Token).WithMany(p => p.PaymentTransactions)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("payment_transaction_token_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PaymentTransactionWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("payment_transaction_write_uid_fkey");

            entity.HasMany(d => d.SaleOrders).WithMany(p => p.Transactions)
                .UsingEntity<Dictionary<string, object>>(
                    "SaleOrderTransactionRel",
                    r => r.HasOne<SaleOrder>().WithMany()
                        .HasForeignKey("SaleOrderId")
                        .HasConstraintName("sale_order_transaction_rel_sale_order_id_fkey"),
                    l => l.HasOne<PaymentTransaction>().WithMany()
                        .HasForeignKey("TransactionId")
                        .HasConstraintName("sale_order_transaction_rel_transaction_id_fkey"),
                    j =>
                    {
                        j.HasKey("TransactionId", "SaleOrderId").HasName("sale_order_transaction_rel_pkey");
                        j.ToTable("sale_order_transaction_rel");
                        j.HasIndex(new[] { "SaleOrderId", "TransactionId" }, "sale_order_transaction_rel_sale_order_id_transaction_id_idx");
                    });
        });

        modelBuilder.Entity<PhoneBlacklist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("phone_blacklist_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PhoneBlacklistCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("phone_blacklist_create_uid_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.PhoneBlacklists)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("phone_blacklist_message_main_attachment_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PhoneBlacklistWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("phone_blacklist_write_uid_fkey");
        });

        modelBuilder.Entity<PhoneBlacklistRemove>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("phone_blacklist_remove_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PhoneBlacklistRemoveCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("phone_blacklist_remove_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PhoneBlacklistRemoveWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("phone_blacklist_remove_write_uid_fkey");
        });

        modelBuilder.Entity<PickingLabelType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("picking_label_type_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PickingLabelTypeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("picking_label_type_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PickingLabelTypeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("picking_label_type_write_uid_fkey");

            entity.HasMany(d => d.StockPickings).WithMany(p => p.PickingLabelTypes)
                .UsingEntity<Dictionary<string, object>>(
                    "PickingLabelTypeStockPickingRel",
                    r => r.HasOne<StockPicking>().WithMany()
                        .HasForeignKey("StockPickingId")
                        .HasConstraintName("picking_label_type_stock_picking_rel_stock_picking_id_fkey"),
                    l => l.HasOne<PickingLabelType>().WithMany()
                        .HasForeignKey("PickingLabelTypeId")
                        .HasConstraintName("picking_label_type_stock_picking_rel_picking_label_type_id_fkey"),
                    j =>
                    {
                        j.HasKey("PickingLabelTypeId", "StockPickingId").HasName("picking_label_type_stock_picking_rel_pkey");
                        j.ToTable("picking_label_type_stock_picking_rel");
                        j.HasIndex(new[] { "StockPickingId", "PickingLabelTypeId" }, "picking_label_type_stock_pick_stock_picking_id_picking_labe_idx");
                    });
        });

        modelBuilder.Entity<PortalShare>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("portal_share_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PortalShareCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("portal_share_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PortalShareWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("portal_share_write_uid_fkey");

            entity.HasMany(d => d.ResPartners).WithMany(p => p.PortalShares)
                .UsingEntity<Dictionary<string, object>>(
                    "PortalShareResPartnerRel",
                    r => r.HasOne<ResPartner>().WithMany()
                        .HasForeignKey("ResPartnerId")
                        .HasConstraintName("portal_share_res_partner_rel_res_partner_id_fkey"),
                    l => l.HasOne<PortalShare>().WithMany()
                        .HasForeignKey("PortalShareId")
                        .HasConstraintName("portal_share_res_partner_rel_portal_share_id_fkey"),
                    j =>
                    {
                        j.HasKey("PortalShareId", "ResPartnerId").HasName("portal_share_res_partner_rel_pkey");
                        j.ToTable("portal_share_res_partner_rel");
                        j.HasIndex(new[] { "ResPartnerId", "PortalShareId" }, "portal_share_res_partner_rel_res_partner_id_portal_share_id_idx");
                    });
        });

        modelBuilder.Entity<PortalWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("portal_wizard_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PortalWizardCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("portal_wizard_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PortalWizardWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("portal_wizard_write_uid_fkey");

            entity.HasMany(d => d.ResPartners).WithMany(p => p.PortalWizards)
                .UsingEntity<Dictionary<string, object>>(
                    "PortalWizardResPartnerRel",
                    r => r.HasOne<ResPartner>().WithMany()
                        .HasForeignKey("ResPartnerId")
                        .HasConstraintName("portal_wizard_res_partner_rel_res_partner_id_fkey"),
                    l => l.HasOne<PortalWizard>().WithMany()
                        .HasForeignKey("PortalWizardId")
                        .HasConstraintName("portal_wizard_res_partner_rel_portal_wizard_id_fkey"),
                    j =>
                    {
                        j.HasKey("PortalWizardId", "ResPartnerId").HasName("portal_wizard_res_partner_rel_pkey");
                        j.ToTable("portal_wizard_res_partner_rel");
                        j.HasIndex(new[] { "ResPartnerId", "PortalWizardId" }, "portal_wizard_res_partner_rel_res_partner_id_portal_wizard__idx");
                    });
        });

        modelBuilder.Entity<PortalWizardUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("portal_wizard_user_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PortalWizardUserCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("portal_wizard_user_create_uid_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.PortalWizardUsers)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("portal_wizard_user_partner_id_fkey");

            entity.HasOne(d => d.Wizard).WithMany(p => p.PortalWizardUsers)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("portal_wizard_user_wizard_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PortalWizardUserWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("portal_wizard_user_write_uid_fkey");
        });

        modelBuilder.Entity<PosBill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pos_bill_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PosBillCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_bill_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PosBillWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_bill_write_uid_fkey");
        });

        modelBuilder.Entity<PosCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pos_category_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PosCategoryCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_category_create_uid_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_category_parent_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PosCategoryWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_category_write_uid_fkey");
        });

        modelBuilder.Entity<PosCloseSessionWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pos_close_session_wizard_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Account).WithMany(p => p.PosCloseSessionWizards)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_close_session_wizard_account_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PosCloseSessionWizardCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_close_session_wizard_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PosCloseSessionWizardWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_close_session_wizard_write_uid_fkey");
        });

        modelBuilder.Entity<PosConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pos_config_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.PosConfigs)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("pos_config_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PosConfigCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_config_create_uid_fkey");

            entity.HasOne(d => d.CrmTeam).WithMany(p => p.PosConfigs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_config_crm_team_id_fkey");

            entity.HasOne(d => d.DefaultFiscalPosition).WithMany(p => p.PosConfigsNavigation)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_config_default_fiscal_position_id_fkey");

            entity.HasOne(d => d.DownPaymentProduct).WithMany(p => p.PosConfigDownPaymentProducts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_config_down_payment_product_id_fkey");

            entity.HasOne(d => d.GroupPosManager).WithMany(p => p.PosConfigGroupPosManagers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_config_group_pos_manager_id_fkey");

            entity.HasOne(d => d.GroupPosUser).WithMany(p => p.PosConfigGroupPosUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_config_group_pos_user_id_fkey");

            entity.HasOne(d => d.IfaceStartCateg).WithMany(p => p.PosConfigsNavigation)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_config_iface_start_categ_id_fkey");

            entity.HasOne(d => d.InvoiceJournal).WithMany(p => p.PosConfigInvoiceJournals)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_config_invoice_journal_id_fkey");

            entity.HasOne(d => d.Journal).WithMany(p => p.PosConfigJournals)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("pos_config_journal_id_fkey");

            entity.HasOne(d => d.PickingType).WithMany(p => p.PosConfigs)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("pos_config_picking_type_id_fkey");

            entity.HasOne(d => d.Pricelist).WithMany(p => p.PosConfigs)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("pos_config_pricelist_id_fkey");

            entity.HasOne(d => d.RoundingMethodNavigation).WithMany(p => p.PosConfigs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_config_rounding_method_fkey");

            entity.HasOne(d => d.Route).WithMany(p => p.PosConfigs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_config_route_id_fkey");

            entity.HasOne(d => d.Sequence).WithMany(p => p.PosConfigSequences)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("pos_config_sequence_id_fkey");

            entity.HasOne(d => d.SequenceLine).WithMany(p => p.PosConfigSequenceLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_config_sequence_line_id_fkey");

            entity.HasOne(d => d.TipProduct).WithMany(p => p.PosConfigTipProducts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_config_tip_product_id_fkey");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.PosConfigs)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("pos_config_warehouse_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PosConfigWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_config_write_uid_fkey");

            entity.HasMany(d => d.AccountFiscalPositions).WithMany(p => p.PosConfigs)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountFiscalPositionPosConfigRel",
                    r => r.HasOne<AccountFiscalPosition>().WithMany()
                        .HasForeignKey("AccountFiscalPositionId")
                        .HasConstraintName("account_fiscal_position_pos_con_account_fiscal_position_id_fkey"),
                    l => l.HasOne<PosConfig>().WithMany()
                        .HasForeignKey("PosConfigId")
                        .HasConstraintName("account_fiscal_position_pos_config_rel_pos_config_id_fkey"),
                    j =>
                    {
                        j.HasKey("PosConfigId", "AccountFiscalPositionId").HasName("account_fiscal_position_pos_config_rel_pkey");
                        j.ToTable("account_fiscal_position_pos_config_rel");
                        j.HasIndex(new[] { "AccountFiscalPositionId", "PosConfigId" }, "account_fiscal_position_pos_c_account_fiscal_position_id_po_idx");
                    });

            entity.HasMany(d => d.HrEmployees).WithMany(p => p.PosConfigs)
                .UsingEntity<Dictionary<string, object>>(
                    "HrEmployeePosConfigRel",
                    r => r.HasOne<HrEmployee>().WithMany()
                        .HasForeignKey("HrEmployeeId")
                        .HasConstraintName("hr_employee_pos_config_rel_hr_employee_id_fkey"),
                    l => l.HasOne<PosConfig>().WithMany()
                        .HasForeignKey("PosConfigId")
                        .HasConstraintName("hr_employee_pos_config_rel_pos_config_id_fkey"),
                    j =>
                    {
                        j.HasKey("PosConfigId", "HrEmployeeId").HasName("hr_employee_pos_config_rel_pkey");
                        j.ToTable("hr_employee_pos_config_rel");
                        j.HasIndex(new[] { "HrEmployeeId", "PosConfigId" }, "hr_employee_pos_config_rel_hr_employee_id_pos_config_id_idx");
                    });

            entity.HasMany(d => d.PosBills).WithMany(p => p.PosConfigs)
                .UsingEntity<Dictionary<string, object>>(
                    "PosBillPosConfigRel",
                    r => r.HasOne<PosBill>().WithMany()
                        .HasForeignKey("PosBillId")
                        .HasConstraintName("pos_bill_pos_config_rel_pos_bill_id_fkey"),
                    l => l.HasOne<PosConfig>().WithMany()
                        .HasForeignKey("PosConfigId")
                        .HasConstraintName("pos_bill_pos_config_rel_pos_config_id_fkey"),
                    j =>
                    {
                        j.HasKey("PosConfigId", "PosBillId").HasName("pos_bill_pos_config_rel_pkey");
                        j.ToTable("pos_bill_pos_config_rel");
                        j.HasIndex(new[] { "PosBillId", "PosConfigId" }, "pos_bill_pos_config_rel_pos_bill_id_pos_config_id_idx");
                    });

            entity.HasMany(d => d.PosCategories).WithMany(p => p.PosConfigs)
                .UsingEntity<Dictionary<string, object>>(
                    "PosCategoryPosConfigRel",
                    r => r.HasOne<PosCategory>().WithMany()
                        .HasForeignKey("PosCategoryId")
                        .HasConstraintName("pos_category_pos_config_rel_pos_category_id_fkey"),
                    l => l.HasOne<PosConfig>().WithMany()
                        .HasForeignKey("PosConfigId")
                        .HasConstraintName("pos_category_pos_config_rel_pos_config_id_fkey"),
                    j =>
                    {
                        j.HasKey("PosConfigId", "PosCategoryId").HasName("pos_category_pos_config_rel_pkey");
                        j.ToTable("pos_category_pos_config_rel");
                        j.HasIndex(new[] { "PosCategoryId", "PosConfigId" }, "pos_category_pos_config_rel_pos_category_id_pos_config_id_idx");
                    });

            entity.HasMany(d => d.PosPaymentMethods).WithMany(p => p.PosConfigs)
                .UsingEntity<Dictionary<string, object>>(
                    "PosConfigPosPaymentMethodRel",
                    r => r.HasOne<PosPaymentMethod>().WithMany()
                        .HasForeignKey("PosPaymentMethodId")
                        .HasConstraintName("pos_config_pos_payment_method_rel_pos_payment_method_id_fkey"),
                    l => l.HasOne<PosConfig>().WithMany()
                        .HasForeignKey("PosConfigId")
                        .HasConstraintName("pos_config_pos_payment_method_rel_pos_config_id_fkey"),
                    j =>
                    {
                        j.HasKey("PosConfigId", "PosPaymentMethodId").HasName("pos_config_pos_payment_method_rel_pkey");
                        j.ToTable("pos_config_pos_payment_method_rel");
                        j.HasIndex(new[] { "PosPaymentMethodId", "PosConfigId" }, "pos_config_pos_payment_method_pos_payment_method_id_pos_con_idx");
                    });

            entity.HasMany(d => d.ProductPricelists).WithMany(p => p.PosConfigsNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "PosConfigProductPricelistRel",
                    r => r.HasOne<ProductPricelist>().WithMany()
                        .HasForeignKey("ProductPricelistId")
                        .HasConstraintName("pos_config_product_pricelist_rel_product_pricelist_id_fkey"),
                    l => l.HasOne<PosConfig>().WithMany()
                        .HasForeignKey("PosConfigId")
                        .HasConstraintName("pos_config_product_pricelist_rel_pos_config_id_fkey"),
                    j =>
                    {
                        j.HasKey("PosConfigId", "ProductPricelistId").HasName("pos_config_product_pricelist_rel_pkey");
                        j.ToTable("pos_config_product_pricelist_rel");
                        j.HasIndex(new[] { "ProductPricelistId", "PosConfigId" }, "pos_config_product_pricelist__product_pricelist_id_pos_conf_idx");
                    });
        });

        modelBuilder.Entity<PosDetailsWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pos_details_wizard_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PosDetailsWizardCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_details_wizard_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PosDetailsWizardWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_details_wizard_write_uid_fkey");

            entity.HasMany(d => d.PosConfigs).WithMany(p => p.PosDetailsWizards)
                .UsingEntity<Dictionary<string, object>>(
                    "PosDetailConfig",
                    r => r.HasOne<PosConfig>().WithMany()
                        .HasForeignKey("PosConfigId")
                        .HasConstraintName("pos_detail_configs_pos_config_id_fkey"),
                    l => l.HasOne<PosDetailsWizard>().WithMany()
                        .HasForeignKey("PosDetailsWizardId")
                        .HasConstraintName("pos_detail_configs_pos_details_wizard_id_fkey"),
                    j =>
                    {
                        j.HasKey("PosDetailsWizardId", "PosConfigId").HasName("pos_detail_configs_pkey");
                        j.ToTable("pos_detail_configs");
                        j.HasIndex(new[] { "PosConfigId", "PosDetailsWizardId" }, "pos_detail_configs_pos_config_id_pos_details_wizard_id_idx");
                    });
        });

        modelBuilder.Entity<PosMakePayment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pos_make_payment_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Config).WithMany(p => p.PosMakePayments)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("pos_make_payment_config_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PosMakePaymentCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_make_payment_create_uid_fkey");

            entity.HasOne(d => d.PaymentMethod).WithMany(p => p.PosMakePayments)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("pos_make_payment_payment_method_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PosMakePaymentWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_make_payment_write_uid_fkey");
        });

        modelBuilder.Entity<PosOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pos_order_pkey");

            entity.HasIndex(e => e.PartnerId, "pos_order_partner_id_index").HasFilter("(partner_id IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.SequenceNumber).ValueGeneratedOnAdd();

            entity.HasOne(d => d.AccountMoveNavigation).WithMany(p => p.PosOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_order_account_move_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.PosOrders)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("pos_order_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PosOrderCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_order_create_uid_fkey");

            entity.HasOne(d => d.CrmTeam).WithMany(p => p.PosOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_order_crm_team_id_fkey");

            entity.HasOne(d => d.Employee).WithMany(p => p.PosOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_order_employee_id_fkey");

            entity.HasOne(d => d.FiscalPosition).WithMany(p => p.PosOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_order_fiscal_position_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.PosOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_order_partner_id_fkey");

            entity.HasOne(d => d.Pricelist).WithMany(p => p.PosOrders)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("pos_order_pricelist_id_fkey");

            entity.HasOne(d => d.ProcurementGroup).WithMany(p => p.PosOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_order_procurement_group_id_fkey");

            entity.HasOne(d => d.SaleJournalNavigation).WithMany(p => p.PosOrders)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("pos_order_sale_journal_fkey");

            entity.HasOne(d => d.Session).WithMany(p => p.PosOrders)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("pos_order_session_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.PosOrderUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_order_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PosOrderWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_order_write_uid_fkey");
        });

        modelBuilder.Entity<PosOrderLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pos_order_line_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.PosOrderLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_order_line_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PosOrderLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_order_line_create_uid_fkey");

            entity.HasOne(d => d.Order).WithMany(p => p.PosOrderLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("pos_order_line_order_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.PosOrderLines)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("pos_order_line_product_id_fkey");

            entity.HasOne(d => d.RefundedOrderline).WithMany(p => p.InverseRefundedOrderline)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_order_line_refunded_orderline_id_fkey");

            entity.HasOne(d => d.SaleOrderLine).WithMany(p => p.PosOrderLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_order_line_sale_order_line_id_fkey");

            entity.HasOne(d => d.SaleOrderOrigin).WithMany(p => p.PosOrderLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_order_line_sale_order_origin_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PosOrderLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_order_line_write_uid_fkey");

            entity.HasMany(d => d.AccountTaxes).WithMany(p => p.PosOrderLines)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountTaxPosOrderLineRel",
                    r => r.HasOne<AccountTax>().WithMany()
                        .HasForeignKey("AccountTaxId")
                        .HasConstraintName("account_tax_pos_order_line_rel_account_tax_id_fkey"),
                    l => l.HasOne<PosOrderLine>().WithMany()
                        .HasForeignKey("PosOrderLineId")
                        .HasConstraintName("account_tax_pos_order_line_rel_pos_order_line_id_fkey"),
                    j =>
                    {
                        j.HasKey("PosOrderLineId", "AccountTaxId").HasName("account_tax_pos_order_line_rel_pkey");
                        j.ToTable("account_tax_pos_order_line_rel");
                        j.HasIndex(new[] { "AccountTaxId", "PosOrderLineId" }, "account_tax_pos_order_line_re_account_tax_id_pos_order_line_idx");
                    });
        });

        modelBuilder.Entity<PosPackOperationLot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pos_pack_operation_lot_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PosPackOperationLotCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_pack_operation_lot_create_uid_fkey");

            entity.HasOne(d => d.PosOrderLine).WithMany(p => p.PosPackOperationLots)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_pack_operation_lot_pos_order_line_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PosPackOperationLotWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_pack_operation_lot_write_uid_fkey");
        });

        modelBuilder.Entity<PosPayment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pos_payment_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.AccountMove).WithMany(p => p.PosPayments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_payment_account_move_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.PosPayments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_payment_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PosPaymentCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_payment_create_uid_fkey");

            entity.HasOne(d => d.PaymentMethod).WithMany(p => p.PosPayments)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("pos_payment_payment_method_id_fkey");

            entity.HasOne(d => d.PosOrder).WithMany(p => p.PosPayments)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("pos_payment_pos_order_id_fkey");

            entity.HasOne(d => d.Session).WithMany(p => p.PosPayments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_payment_session_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PosPaymentWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_payment_write_uid_fkey");
        });

        modelBuilder.Entity<PosPaymentMethod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pos_payment_method_pkey");

            entity.HasOne(d => d.Company).WithMany(p => p.PosPaymentMethods)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_payment_method_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PosPaymentMethodCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_payment_method_create_uid_fkey");

            entity.HasOne(d => d.Journal).WithMany(p => p.PosPaymentMethods)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("pos_payment_method_journal_id_fkey");

            entity.HasOne(d => d.OutstandingAccount).WithMany(p => p.PosPaymentMethodOutstandingAccounts)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("pos_payment_method_outstanding_account_id_fkey");

            entity.HasOne(d => d.ReceivableAccount).WithMany(p => p.PosPaymentMethodReceivableAccounts)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("pos_payment_method_receivable_account_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PosPaymentMethodWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_payment_method_write_uid_fkey");
        });

        modelBuilder.Entity<PosSession>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pos_session_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CashJournal).WithMany(p => p.PosSessions)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_session_cash_journal_id_fkey");

            entity.HasOne(d => d.Config).WithMany(p => p.PosSessions)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("pos_session_config_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PosSessionCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_session_create_uid_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.PosSessions)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_session_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Move).WithMany(p => p.PosSessions)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_session_move_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.PosSessionUsers)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("pos_session_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PosSessionWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_session_write_uid_fkey");
        });

        modelBuilder.Entity<PosSessionCheckProductWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pos_session_check_product_wizard_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PosSessionCheckProductWizardCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_session_check_product_wizard_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PosSessionCheckProductWizardWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pos_session_check_product_wizard_write_uid_fkey");
        });

        modelBuilder.Entity<PrivacyLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("privacy_log_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PrivacyLogCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("privacy_log_create_uid_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.PrivacyLogUsers)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("privacy_log_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PrivacyLogWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("privacy_log_write_uid_fkey");
        });

        modelBuilder.Entity<PrivacyLookupWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("privacy_lookup_wizard_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PrivacyLookupWizardCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("privacy_lookup_wizard_create_uid_fkey");

            entity.HasOne(d => d.Log).WithMany(p => p.PrivacyLookupWizards)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("privacy_lookup_wizard_log_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PrivacyLookupWizardWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("privacy_lookup_wizard_write_uid_fkey");
        });

        modelBuilder.Entity<PrivacyLookupWizardLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("privacy_lookup_wizard_line_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PrivacyLookupWizardLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("privacy_lookup_wizard_line_create_uid_fkey");

            entity.HasOne(d => d.ResModelNavigation).WithMany(p => p.PrivacyLookupWizardLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("privacy_lookup_wizard_line_res_model_id_fkey");

            entity.HasOne(d => d.Wizard).WithMany(p => p.PrivacyLookupWizardLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("privacy_lookup_wizard_line_wizard_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PrivacyLookupWizardLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("privacy_lookup_wizard_line_write_uid_fkey");
        });

        modelBuilder.Entity<ProcurementGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("procurement_group_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProcurementGroupCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_group_create_uid_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.ProcurementGroups)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_group_partner_id_fkey");

            entity.HasOne(d => d.PosOrder).WithMany(p => p.ProcurementGroups)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_group_pos_order_id_fkey");

            entity.HasOne(d => d.Sale).WithMany(p => p.ProcurementGroups)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_group_sale_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProcurementGroupWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_group_write_uid_fkey");
        });

        modelBuilder.Entity<ProductAttribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_attribute_pkey");

            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductAttributeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_attribute_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductAttributeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_attribute_write_uid_fkey");

            entity.HasMany(d => d.ProductTemplates).WithMany(p => p.ProductAttributes)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductAttributeProductTemplateRel",
                    r => r.HasOne<ProductTemplate>().WithMany()
                        .HasForeignKey("ProductTemplateId")
                        .HasConstraintName("product_attribute_product_template_rel_product_template_id_fkey"),
                    l => l.HasOne<ProductAttribute>().WithMany()
                        .HasForeignKey("ProductAttributeId")
                        .HasConstraintName("product_attribute_product_template_re_product_attribute_id_fkey"),
                    j =>
                    {
                        j.HasKey("ProductAttributeId", "ProductTemplateId").HasName("product_attribute_product_template_rel_pkey");
                        j.ToTable("product_attribute_product_template_rel");
                        j.HasIndex(new[] { "ProductTemplateId", "ProductAttributeId" }, "product_attribute_product_tem_product_template_id_product_a_idx");
                    });
        });

        modelBuilder.Entity<ProductAttributeCustomValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_attribute_custom_value_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductAttributeCustomValueCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_attribute_custom_value_create_uid_fkey");

            entity.HasOne(d => d.CustomProductTemplateAttributeValue).WithMany(p => p.ProductAttributeCustomValues)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("product_attribute_custom_valu_custom_product_template_attr_fkey");

            entity.HasOne(d => d.SaleOrderLine).WithMany(p => p.ProductAttributeCustomValues)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("product_attribute_custom_value_sale_order_line_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductAttributeCustomValueWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_attribute_custom_value_write_uid_fkey");
        });

        modelBuilder.Entity<ProductAttributeValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_attribute_value_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Attribute).WithMany(p => p.ProductAttributeValues)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("product_attribute_value_attribute_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductAttributeValueCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_attribute_value_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductAttributeValueWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_attribute_value_write_uid_fkey");

            entity.HasMany(d => d.ProductTemplateAttributeLines).WithMany(p => p.ProductAttributeValues)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductAttributeValueProductTemplateAttributeLineRel",
                    r => r.HasOne<ProductTemplateAttributeLine>().WithMany()
                        .HasForeignKey("ProductTemplateAttributeLineId")
                        .HasConstraintName("product_attribute_value_produ_product_template_attribute_l_fkey"),
                    l => l.HasOne<ProductAttributeValue>().WithMany()
                        .HasForeignKey("ProductAttributeValueId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("product_attribute_value_product_product_attribute_value_id_fkey"),
                    j =>
                    {
                        j.HasKey("ProductAttributeValueId", "ProductTemplateAttributeLineId").HasName("product_attribute_value_product_template_attribute_line_re_pkey");
                        j.ToTable("product_attribute_value_product_template_attribute_line_rel");
                        j.HasIndex(new[] { "ProductTemplateAttributeLineId", "ProductAttributeValueId" }, "product_attribute_value_produ_product_template_attribute_li_idx");
                    });
        });

        modelBuilder.Entity<ProductCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_category_pkey");

            entity.HasIndex(e => e.Name, "product_category_name_index")
                .HasMethod("gin")
                .HasOperators(new[] { "gin_trgm_ops" });

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductCategoryCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_category_create_uid_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("product_category_parent_id_fkey");

            entity.HasOne(d => d.RemovalStrategy).WithMany(p => p.ProductCategories)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_category_removal_strategy_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductCategoryWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_category_write_uid_fkey");
        });

        modelBuilder.Entity<ProductImage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_image_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductImageCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_image_create_uid_fkey");

            entity.HasOne(d => d.ProductTmpl).WithMany(p => p.ProductImages)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("product_image_product_tmpl_id_fkey");

            entity.HasOne(d => d.ProductVariant).WithMany(p => p.ProductImages)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("product_image_product_variant_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductImageWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_image_write_uid_fkey");
        });

        modelBuilder.Entity<ProductLabelLayout>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_label_layout_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductLabelLayoutCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_label_layout_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductLabelLayoutWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_label_layout_write_uid_fkey");

            entity.HasMany(d => d.ProductProducts).WithMany(p => p.ProductLabelLayouts)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductLabelLayoutProductProductRel",
                    r => r.HasOne<ProductProduct>().WithMany()
                        .HasForeignKey("ProductProductId")
                        .HasConstraintName("product_label_layout_product_product_re_product_product_id_fkey"),
                    l => l.HasOne<ProductLabelLayout>().WithMany()
                        .HasForeignKey("ProductLabelLayoutId")
                        .HasConstraintName("product_label_layout_product_produ_product_label_layout_id_fkey"),
                    j =>
                    {
                        j.HasKey("ProductLabelLayoutId", "ProductProductId").HasName("product_label_layout_product_product_rel_pkey");
                        j.ToTable("product_label_layout_product_product_rel");
                        j.HasIndex(new[] { "ProductProductId", "ProductLabelLayoutId" }, "product_label_layout_product__product_product_id_product_la_idx");
                    });

            entity.HasMany(d => d.ProductTemplates).WithMany(p => p.ProductLabelLayouts)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductLabelLayoutProductTemplateRel",
                    r => r.HasOne<ProductTemplate>().WithMany()
                        .HasForeignKey("ProductTemplateId")
                        .HasConstraintName("product_label_layout_product_template__product_template_id_fkey"),
                    l => l.HasOne<ProductLabelLayout>().WithMany()
                        .HasForeignKey("ProductLabelLayoutId")
                        .HasConstraintName("product_label_layout_product_templ_product_label_layout_id_fkey"),
                    j =>
                    {
                        j.HasKey("ProductLabelLayoutId", "ProductTemplateId").HasName("product_label_layout_product_template_rel_pkey");
                        j.ToTable("product_label_layout_product_template_rel");
                        j.HasIndex(new[] { "ProductTemplateId", "ProductLabelLayoutId" }, "product_label_layout_product__product_template_id_product_l_idx");
                    });

            entity.HasMany(d => d.StockMoveLines).WithMany(p => p.ProductLabelLayouts)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductLabelLayoutStockMoveLineRel",
                    r => r.HasOne<StockMoveLine>().WithMany()
                        .HasForeignKey("StockMoveLineId")
                        .HasConstraintName("product_label_layout_stock_move_line_re_stock_move_line_id_fkey"),
                    l => l.HasOne<ProductLabelLayout>().WithMany()
                        .HasForeignKey("ProductLabelLayoutId")
                        .HasConstraintName("product_label_layout_stock_move_li_product_label_layout_id_fkey"),
                    j =>
                    {
                        j.HasKey("ProductLabelLayoutId", "StockMoveLineId").HasName("product_label_layout_stock_move_line_rel_pkey");
                        j.ToTable("product_label_layout_stock_move_line_rel");
                        j.HasIndex(new[] { "StockMoveLineId", "ProductLabelLayoutId" }, "product_label_layout_stock_mo_stock_move_line_id_product_la_idx");
                    });
        });

        modelBuilder.Entity<ProductPackaging>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_packaging_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Company).WithMany(p => p.ProductPackagings)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_packaging_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductPackagingCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_packaging_create_uid_fkey");

            entity.HasOne(d => d.PackageType).WithMany(p => p.ProductPackagings)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_packaging_package_type_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductPackagings)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_packaging_product_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductPackagingWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_packaging_write_uid_fkey");
        });

        modelBuilder.Entity<ProductPricelist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_pricelist_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Company).WithMany(p => p.ProductPricelists)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_pricelist_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductPricelistCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_pricelist_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.ProductPricelists)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("product_pricelist_currency_id_fkey");

            entity.HasOne(d => d.Website).WithMany(p => p.ProductPricelists)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("product_pricelist_website_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductPricelistWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_pricelist_write_uid_fkey");

            entity.HasMany(d => d.ResCountryGroups).WithMany(p => p.Pricelists)
                .UsingEntity<Dictionary<string, object>>(
                    "ResCountryGroupPricelistRel",
                    r => r.HasOne<ResCountryGroup>().WithMany()
                        .HasForeignKey("ResCountryGroupId")
                        .HasConstraintName("res_country_group_pricelist_rel_res_country_group_id_fkey"),
                    l => l.HasOne<ProductPricelist>().WithMany()
                        .HasForeignKey("PricelistId")
                        .HasConstraintName("res_country_group_pricelist_rel_pricelist_id_fkey"),
                    j =>
                    {
                        j.HasKey("PricelistId", "ResCountryGroupId").HasName("res_country_group_pricelist_rel_pkey");
                        j.ToTable("res_country_group_pricelist_rel");
                        j.HasIndex(new[] { "ResCountryGroupId", "PricelistId" }, "res_country_group_pricelist_r_res_country_group_id_pricelis_idx");
                    });
        });

        modelBuilder.Entity<ProductPricelistItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_pricelist_item_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.BasePricelist).WithMany(p => p.ProductPricelistItemBasePricelists)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_pricelist_item_base_pricelist_id_fkey");

            entity.HasOne(d => d.Categ).WithMany(p => p.ProductPricelistItems)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("product_pricelist_item_categ_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.ProductPricelistItems)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_pricelist_item_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductPricelistItemCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_pricelist_item_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.ProductPricelistItems)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_pricelist_item_currency_id_fkey");

            entity.HasOne(d => d.Pricelist).WithMany(p => p.ProductPricelistItemPricelists)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("product_pricelist_item_pricelist_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductPricelistItems)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("product_pricelist_item_product_id_fkey");

            entity.HasOne(d => d.ProductTmpl).WithMany(p => p.ProductPricelistItems)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("product_pricelist_item_product_tmpl_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductPricelistItemWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_pricelist_item_write_uid_fkey");
        });

        modelBuilder.Entity<ProductProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_product_pkey");

            entity.HasIndex(e => e.Barcode, "product_product_barcode_index").HasFilter("(barcode IS NOT NULL)");

            entity.HasIndex(e => new { e.ProductTmplId, e.CombinationIndices }, "product_product_combination_unique")
                .IsUnique()
                .HasFilter("(active IS TRUE)");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.BaseUnit).WithMany(p => p.ProductProducts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_product_base_unit_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductProductCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_product_create_uid_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.ProductProducts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_product_message_main_attachment_id_fkey");

            entity.HasOne(d => d.ProductTmpl).WithMany(p => p.ProductProducts)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("product_product_product_tmpl_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductProductWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_product_write_uid_fkey");

            entity.HasMany(d => d.ProductTags).WithMany(p => p.ProductProducts)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductTagProductProductRel",
                    r => r.HasOne<ProductTag>().WithMany()
                        .HasForeignKey("ProductTagId")
                        .HasConstraintName("product_tag_product_product_rel_product_tag_id_fkey"),
                    l => l.HasOne<ProductProduct>().WithMany()
                        .HasForeignKey("ProductProductId")
                        .HasConstraintName("product_tag_product_product_rel_product_product_id_fkey"),
                    j =>
                    {
                        j.HasKey("ProductProductId", "ProductTagId").HasName("product_tag_product_product_rel_pkey");
                        j.ToTable("product_tag_product_product_rel");
                        j.HasIndex(new[] { "ProductTagId", "ProductProductId" }, "product_tag_product_product_r_product_tag_id_product_produc_idx");
                    });

            entity.HasMany(d => d.ProductTemplateAttributeValues).WithMany(p => p.ProductProducts)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductVariantCombination",
                    r => r.HasOne<ProductTemplateAttributeValue>().WithMany()
                        .HasForeignKey("ProductTemplateAttributeValueId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("product_variant_combination_product_template_attribute_val_fkey"),
                    l => l.HasOne<ProductProduct>().WithMany()
                        .HasForeignKey("ProductProductId")
                        .HasConstraintName("product_variant_combination_product_product_id_fkey"),
                    j =>
                    {
                        j.HasKey("ProductProductId", "ProductTemplateAttributeValueId").HasName("product_variant_combination_pkey");
                        j.ToTable("product_variant_combination");
                        j.HasIndex(new[] { "ProductTemplateAttributeValueId", "ProductProductId" }, "product_variant_combination_product_template_attribute_valu_idx");
                    });

            entity.HasMany(d => d.ResPartners).WithMany(p => p.ProductProducts)
                .UsingEntity<Dictionary<string, object>>(
                    "StockNotificationProductPartnerRel",
                    r => r.HasOne<ResPartner>().WithMany()
                        .HasForeignKey("ResPartnerId")
                        .HasConstraintName("stock_notification_product_partner_rel_res_partner_id_fkey"),
                    l => l.HasOne<ProductProduct>().WithMany()
                        .HasForeignKey("ProductProductId")
                        .HasConstraintName("stock_notification_product_partner_rel_product_product_id_fkey"),
                    j =>
                    {
                        j.HasKey("ProductProductId", "ResPartnerId").HasName("stock_notification_product_partner_rel_pkey");
                        j.ToTable("stock_notification_product_partner_rel");
                        j.HasIndex(new[] { "ResPartnerId", "ProductProductId" }, "stock_notification_product_pa_res_partner_id_product_produc_idx");
                    });
        });

        modelBuilder.Entity<ProductPublicCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_public_category_pkey");

            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductPublicCategoryCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_public_category_create_uid_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("product_public_category_parent_id_fkey");

            entity.HasOne(d => d.Website).WithMany(p => p.ProductPublicCategories)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("product_public_category_website_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductPublicCategoryWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_public_category_write_uid_fkey");

            entity.HasMany(d => d.ProductTemplates).WithMany(p => p.ProductPublicCategories)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductPublicCategoryProductTemplateRel",
                    r => r.HasOne<ProductTemplate>().WithMany()
                        .HasForeignKey("ProductTemplateId")
                        .HasConstraintName("product_public_category_product_templa_product_template_id_fkey"),
                    l => l.HasOne<ProductPublicCategory>().WithMany()
                        .HasForeignKey("ProductPublicCategoryId")
                        .HasConstraintName("product_public_category_product_product_public_category_id_fkey"),
                    j =>
                    {
                        j.HasKey("ProductPublicCategoryId", "ProductTemplateId").HasName("product_public_category_product_template_rel_pkey");
                        j.ToTable("product_public_category_product_template_rel");
                        j.HasIndex(new[] { "ProductTemplateId", "ProductPublicCategoryId" }, "product_public_category_produ_product_template_id_product_p_idx");
                    });
        });

        modelBuilder.Entity<ProductRemoval>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_removal_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductRemovalCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_removal_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductRemovalWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_removal_write_uid_fkey");
        });

        modelBuilder.Entity<ProductReplenish>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_replenish_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.ProductReplenishes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_replenish_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductReplenishCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_replenish_create_uid_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductReplenishes)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("product_replenish_product_id_fkey");

            entity.HasOne(d => d.ProductTmpl).WithMany(p => p.ProductReplenishes)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("product_replenish_product_tmpl_id_fkey");

            entity.HasOne(d => d.ProductUom).WithMany(p => p.ProductReplenishes)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("product_replenish_product_uom_id_fkey");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.ProductReplenishes)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("product_replenish_warehouse_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductReplenishWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_replenish_write_uid_fkey");

            entity.HasMany(d => d.StockRoutes).WithMany(p => p.ProductReplenishes)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductReplenishStockRouteRel",
                    r => r.HasOne<StockRoute>().WithMany()
                        .HasForeignKey("StockRouteId")
                        .HasConstraintName("product_replenish_stock_route_rel_stock_route_id_fkey"),
                    l => l.HasOne<ProductReplenish>().WithMany()
                        .HasForeignKey("ProductReplenishId")
                        .HasConstraintName("product_replenish_stock_route_rel_product_replenish_id_fkey"),
                    j =>
                    {
                        j.HasKey("ProductReplenishId", "StockRouteId").HasName("product_replenish_stock_route_rel_pkey");
                        j.ToTable("product_replenish_stock_route_rel");
                        j.HasIndex(new[] { "StockRouteId", "ProductReplenishId" }, "product_replenish_stock_route_stock_route_id_product_replen_idx");
                    });
        });

        modelBuilder.Entity<ProductRibbon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_ribbon_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductRibbonCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_ribbon_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductRibbonWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_ribbon_write_uid_fkey");
        });

        modelBuilder.Entity<ProductSupplierinfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_supplierinfo_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Company).WithMany(p => p.ProductSupplierinfos)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_supplierinfo_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductSupplierinfoCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_supplierinfo_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.ProductSupplierinfos)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("product_supplierinfo_currency_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.ProductSupplierinfos)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("product_supplierinfo_partner_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductSupplierinfos)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_supplierinfo_product_id_fkey");

            entity.HasOne(d => d.ProductTmpl).WithMany(p => p.ProductSupplierinfos)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("product_supplierinfo_product_tmpl_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductSupplierinfoWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_supplierinfo_write_uid_fkey");
        });

        modelBuilder.Entity<ProductTag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_tag_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductTagCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_tag_create_uid_fkey");

            entity.HasOne(d => d.Ribbon).WithMany(p => p.ProductTags)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_tag_ribbon_id_fkey");

            entity.HasOne(d => d.Website).WithMany(p => p.ProductTags)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("product_tag_website_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductTagWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_tag_write_uid_fkey");
        });

        modelBuilder.Entity<ProductTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_template_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.BaseUnit).WithMany(p => p.ProductTemplates)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_template_base_unit_id_fkey");

            entity.HasOne(d => d.Categ).WithMany(p => p.ProductTemplates)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("product_template_categ_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.ProductTemplates)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_template_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductTemplateCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_template_create_uid_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.ProductTemplates)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_template_message_main_attachment_id_fkey");

            entity.HasOne(d => d.PosCateg).WithMany(p => p.ProductTemplates)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_template_pos_categ_id_fkey");

            entity.HasOne(d => d.Uom).WithMany(p => p.ProductTemplateUoms)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("product_template_uom_id_fkey");

            entity.HasOne(d => d.UomPo).WithMany(p => p.ProductTemplateUomPos)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("product_template_uom_po_id_fkey");

            entity.HasOne(d => d.Website).WithMany(p => p.ProductTemplates)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("product_template_website_id_fkey");

            entity.HasOne(d => d.WebsiteRibbon).WithMany(p => p.ProductTemplates)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_template_website_ribbon_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductTemplateWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_template_write_uid_fkey");

            entity.HasMany(d => d.AccountAccountTags).WithMany(p => p.ProductTemplates)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountAccountTagProductTemplateRel",
                    r => r.HasOne<AccountAccountTag>().WithMany()
                        .HasForeignKey("AccountAccountTagId")
                        .HasConstraintName("account_account_tag_product_templat_account_account_tag_id_fkey"),
                    l => l.HasOne<ProductTemplate>().WithMany()
                        .HasForeignKey("ProductTemplateId")
                        .HasConstraintName("account_account_tag_product_template_r_product_template_id_fkey"),
                    j =>
                    {
                        j.HasKey("ProductTemplateId", "AccountAccountTagId").HasName("account_account_tag_product_template_rel_pkey");
                        j.ToTable("account_account_tag_product_template_rel");
                        j.HasIndex(new[] { "AccountAccountTagId", "ProductTemplateId" }, "account_account_tag_product_t_account_account_tag_id_produc_idx");
                    });

            entity.HasMany(d => d.Dests).WithMany(p => p.Srcs)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductAccessoryRel",
                    r => r.HasOne<ProductProduct>().WithMany()
                        .HasForeignKey("DestId")
                        .HasConstraintName("product_accessory_rel_dest_id_fkey"),
                    l => l.HasOne<ProductTemplate>().WithMany()
                        .HasForeignKey("SrcId")
                        .HasConstraintName("product_accessory_rel_src_id_fkey"),
                    j =>
                    {
                        j.HasKey("SrcId", "DestId").HasName("product_accessory_rel_pkey");
                        j.ToTable("product_accessory_rel");
                        j.HasIndex(new[] { "DestId", "SrcId" }, "product_accessory_rel_dest_id_src_id_idx");
                    });

            entity.HasMany(d => d.Dests1).WithMany(p => p.SrcsNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductOptionalRel",
                    r => r.HasOne<ProductTemplate>().WithMany()
                        .HasForeignKey("DestId")
                        .HasConstraintName("product_optional_rel_dest_id_fkey"),
                    l => l.HasOne<ProductTemplate>().WithMany()
                        .HasForeignKey("SrcId")
                        .HasConstraintName("product_optional_rel_src_id_fkey"),
                    j =>
                    {
                        j.HasKey("SrcId", "DestId").HasName("product_optional_rel_pkey");
                        j.ToTable("product_optional_rel");
                        j.HasIndex(new[] { "DestId", "SrcId" }, "product_optional_rel_dest_id_src_id_idx");
                    });

            entity.HasMany(d => d.DestsNavigation).WithMany(p => p.Srcs)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductAlternativeRel",
                    r => r.HasOne<ProductTemplate>().WithMany()
                        .HasForeignKey("DestId")
                        .HasConstraintName("product_alternative_rel_dest_id_fkey"),
                    l => l.HasOne<ProductTemplate>().WithMany()
                        .HasForeignKey("SrcId")
                        .HasConstraintName("product_alternative_rel_src_id_fkey"),
                    j =>
                    {
                        j.HasKey("SrcId", "DestId").HasName("product_alternative_rel_pkey");
                        j.ToTable("product_alternative_rel");
                        j.HasIndex(new[] { "DestId", "SrcId" }, "product_alternative_rel_dest_id_src_id_idx");
                    });

            entity.HasMany(d => d.ProductTags).WithMany(p => p.ProductTemplates)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductTagProductTemplateRel",
                    r => r.HasOne<ProductTag>().WithMany()
                        .HasForeignKey("ProductTagId")
                        .HasConstraintName("product_tag_product_template_rel_product_tag_id_fkey"),
                    l => l.HasOne<ProductTemplate>().WithMany()
                        .HasForeignKey("ProductTemplateId")
                        .HasConstraintName("product_tag_product_template_rel_product_template_id_fkey"),
                    j =>
                    {
                        j.HasKey("ProductTemplateId", "ProductTagId").HasName("product_tag_product_template_rel_pkey");
                        j.ToTable("product_tag_product_template_rel");
                        j.HasIndex(new[] { "ProductTagId", "ProductTemplateId" }, "product_tag_product_template__product_tag_id_product_templa_idx");
                    });

            entity.HasMany(d => d.Srcs).WithMany(p => p.DestsNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductAlternativeRel",
                    r => r.HasOne<ProductTemplate>().WithMany()
                        .HasForeignKey("SrcId")
                        .HasConstraintName("product_alternative_rel_src_id_fkey"),
                    l => l.HasOne<ProductTemplate>().WithMany()
                        .HasForeignKey("DestId")
                        .HasConstraintName("product_alternative_rel_dest_id_fkey"),
                    j =>
                    {
                        j.HasKey("SrcId", "DestId").HasName("product_alternative_rel_pkey");
                        j.ToTable("product_alternative_rel");
                        j.HasIndex(new[] { "DestId", "SrcId" }, "product_alternative_rel_dest_id_src_id_idx");
                    });

            entity.HasMany(d => d.SrcsNavigation).WithMany(p => p.Dests1)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductOptionalRel",
                    r => r.HasOne<ProductTemplate>().WithMany()
                        .HasForeignKey("SrcId")
                        .HasConstraintName("product_optional_rel_src_id_fkey"),
                    l => l.HasOne<ProductTemplate>().WithMany()
                        .HasForeignKey("DestId")
                        .HasConstraintName("product_optional_rel_dest_id_fkey"),
                    j =>
                    {
                        j.HasKey("SrcId", "DestId").HasName("product_optional_rel_pkey");
                        j.ToTable("product_optional_rel");
                        j.HasIndex(new[] { "DestId", "SrcId" }, "product_optional_rel_dest_id_src_id_idx");
                    });

            entity.HasMany(d => d.Taxes).WithMany(p => p.Prods)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductSupplierTaxesRel",
                    r => r.HasOne<AccountTax>().WithMany()
                        .HasForeignKey("TaxId")
                        .HasConstraintName("product_supplier_taxes_rel_tax_id_fkey"),
                    l => l.HasOne<ProductTemplate>().WithMany()
                        .HasForeignKey("ProdId")
                        .HasConstraintName("product_supplier_taxes_rel_prod_id_fkey"),
                    j =>
                    {
                        j.HasKey("ProdId", "TaxId").HasName("product_supplier_taxes_rel_pkey");
                        j.ToTable("product_supplier_taxes_rel");
                        j.HasIndex(new[] { "TaxId", "ProdId" }, "product_supplier_taxes_rel_tax_id_prod_id_idx");
                    });

            entity.HasMany(d => d.TaxesNavigation).WithMany(p => p.ProdsNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductTaxesRel",
                    r => r.HasOne<AccountTax>().WithMany()
                        .HasForeignKey("TaxId")
                        .HasConstraintName("product_taxes_rel_tax_id_fkey"),
                    l => l.HasOne<ProductTemplate>().WithMany()
                        .HasForeignKey("ProdId")
                        .HasConstraintName("product_taxes_rel_prod_id_fkey"),
                    j =>
                    {
                        j.HasKey("ProdId", "TaxId").HasName("product_taxes_rel_pkey");
                        j.ToTable("product_taxes_rel");
                        j.HasIndex(new[] { "TaxId", "ProdId" }, "product_taxes_rel_tax_id_prod_id_idx");
                    });
        });

        modelBuilder.Entity<ProductTemplateAttributeExclusion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_template_attribute_exclusion_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductTemplateAttributeExclusionCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_template_attribute_exclusion_create_uid_fkey");

            entity.HasOne(d => d.ProductTemplateAttributeValue).WithMany(p => p.ProductTemplateAttributeExclusionsNavigation)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("product_template_attribute_ex_product_template_attribute_v_fkey");

            entity.HasOne(d => d.ProductTmpl).WithMany(p => p.ProductTemplateAttributeExclusions)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("product_template_attribute_exclusion_product_tmpl_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductTemplateAttributeExclusionWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_template_attribute_exclusion_write_uid_fkey");

            entity.HasMany(d => d.ProductTemplateAttributeValues).WithMany(p => p.ProductTemplateAttributeExclusions)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductAttrExclusionValueIdsRel",
                    r => r.HasOne<ProductTemplateAttributeValue>().WithMany()
                        .HasForeignKey("ProductTemplateAttributeValueId")
                        .HasConstraintName("product_attr_exclusion_value__product_template_attribute_v_fkey"),
                    l => l.HasOne<ProductTemplateAttributeExclusion>().WithMany()
                        .HasForeignKey("ProductTemplateAttributeExclusionId")
                        .HasConstraintName("product_attr_exclusion_value__product_template_attribute_e_fkey"),
                    j =>
                    {
                        j.HasKey("ProductTemplateAttributeExclusionId", "ProductTemplateAttributeValueId").HasName("product_attr_exclusion_value_ids_rel_pkey");
                        j.ToTable("product_attr_exclusion_value_ids_rel");
                        j.HasIndex(new[] { "ProductTemplateAttributeValueId", "ProductTemplateAttributeExclusionId" }, "product_attr_exclusion_value__product_template_attribute_va_idx");
                    });
        });

        modelBuilder.Entity<ProductTemplateAttributeLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_template_attribute_line_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Attribute).WithMany(p => p.ProductTemplateAttributeLines)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("product_template_attribute_line_attribute_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductTemplateAttributeLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_template_attribute_line_create_uid_fkey");

            entity.HasOne(d => d.ProductTmpl).WithMany(p => p.ProductTemplateAttributeLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("product_template_attribute_line_product_tmpl_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductTemplateAttributeLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_template_attribute_line_write_uid_fkey");
        });

        modelBuilder.Entity<ProductTemplateAttributeValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_template_attribute_value_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Attribute).WithMany(p => p.ProductTemplateAttributeValues)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_template_attribute_value_attribute_id_fkey");

            entity.HasOne(d => d.AttributeLine).WithMany(p => p.ProductTemplateAttributeValues)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("product_template_attribute_value_attribute_line_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductTemplateAttributeValueCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_template_attribute_value_create_uid_fkey");

            entity.HasOne(d => d.ProductAttributeValue).WithMany(p => p.ProductTemplateAttributeValues)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("product_template_attribute_valu_product_attribute_value_id_fkey");

            entity.HasOne(d => d.ProductTmpl).WithMany(p => p.ProductTemplateAttributeValues)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_template_attribute_value_product_tmpl_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductTemplateAttributeValueWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_template_attribute_value_write_uid_fkey");
        });

        modelBuilder.Entity<ProjectCollaborator>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("project_collaborator_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProjectCollaboratorCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_collaborator_create_uid_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.ProjectCollaborators)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("project_collaborator_partner_id_fkey");

            entity.HasOne(d => d.Project).WithMany(p => p.ProjectCollaborators)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("project_collaborator_project_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProjectCollaboratorWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_collaborator_write_uid_fkey");
        });

        modelBuilder.Entity<ProjectMilestone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("project_milestone_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProjectMilestoneCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_milestone_create_uid_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.ProjectMilestones)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_milestone_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Project).WithMany(p => p.ProjectMilestones)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("project_milestone_project_id_fkey");

            entity.HasOne(d => d.SaleLine).WithMany(p => p.ProjectMilestones)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_milestone_sale_line_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProjectMilestoneWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_milestone_write_uid_fkey");
        });

        modelBuilder.Entity<ProjectProject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("project_project_pkey");

            entity.HasIndex(e => e.SaleLineId, "project_project_sale_line_id_index").HasFilter("(sale_line_id IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Alias).WithMany(p => p.ProjectProjects)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("project_project_alias_id_fkey");

            entity.HasOne(d => d.AnalyticAccount).WithMany(p => p.ProjectProjects)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_project_analytic_account_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.ProjectProjects)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("project_project_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProjectProjectCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_project_create_uid_fkey");

            entity.HasOne(d => d.LastUpdate).WithMany(p => p.ProjectProjects)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_project_last_update_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.ProjectProjects)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_project_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.ProjectProjects)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_project_partner_id_fkey");

            entity.HasOne(d => d.SaleLine).WithMany(p => p.ProjectProjects)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_project_sale_line_id_fkey");

            entity.HasOne(d => d.Stage).WithMany(p => p.ProjectProjects)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("project_project_stage_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.ProjectProjectUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_project_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProjectProjectWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_project_write_uid_fkey");

            entity.HasMany(d => d.ProjectTags).WithMany(p => p.ProjectProjects)
                .UsingEntity<Dictionary<string, object>>(
                    "ProjectProjectProjectTagsRel",
                    r => r.HasOne<ProjectTag>().WithMany()
                        .HasForeignKey("ProjectTagsId")
                        .HasConstraintName("project_project_project_tags_rel_project_tags_id_fkey"),
                    l => l.HasOne<ProjectProject>().WithMany()
                        .HasForeignKey("ProjectProjectId")
                        .HasConstraintName("project_project_project_tags_rel_project_project_id_fkey"),
                    j =>
                    {
                        j.HasKey("ProjectProjectId", "ProjectTagsId").HasName("project_project_project_tags_rel_pkey");
                        j.ToTable("project_project_project_tags_rel");
                        j.HasIndex(new[] { "ProjectTagsId", "ProjectProjectId" }, "project_project_project_tags__project_tags_id_project_proje_idx");
                    });

            entity.HasMany(d => d.Users).WithMany(p => p.Projects)
                .UsingEntity<Dictionary<string, object>>(
                    "ProjectFavoriteUserRel",
                    r => r.HasOne<ResUser>().WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("project_favorite_user_rel_user_id_fkey"),
                    l => l.HasOne<ProjectProject>().WithMany()
                        .HasForeignKey("ProjectId")
                        .HasConstraintName("project_favorite_user_rel_project_id_fkey"),
                    j =>
                    {
                        j.HasKey("ProjectId", "UserId").HasName("project_favorite_user_rel_pkey");
                        j.ToTable("project_favorite_user_rel");
                        j.HasIndex(new[] { "UserId", "ProjectId" }, "project_favorite_user_rel_user_id_project_id_idx");
                    });
        });

        modelBuilder.Entity<ProjectProjectStage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("project_project_stage_pkey");

            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProjectProjectStageCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_project_stage_create_uid_fkey");

            entity.HasOne(d => d.MailTemplate).WithMany(p => p.ProjectProjectStages)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_project_stage_mail_template_id_fkey");

            entity.HasOne(d => d.SmsTemplate).WithMany(p => p.ProjectProjectStages)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_project_stage_sms_template_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProjectProjectStageWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_project_stage_write_uid_fkey");
        });

        modelBuilder.Entity<ProjectShareWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("project_share_wizard_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProjectShareWizardCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_share_wizard_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProjectShareWizardWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_share_wizard_write_uid_fkey");

            entity.HasMany(d => d.ResPartners).WithMany(p => p.ProjectShareWizards)
                .UsingEntity<Dictionary<string, object>>(
                    "ProjectShareWizardResPartnerRel",
                    r => r.HasOne<ResPartner>().WithMany()
                        .HasForeignKey("ResPartnerId")
                        .HasConstraintName("project_share_wizard_res_partner_rel_res_partner_id_fkey"),
                    l => l.HasOne<ProjectShareWizard>().WithMany()
                        .HasForeignKey("ProjectShareWizardId")
                        .HasConstraintName("project_share_wizard_res_partner_r_project_share_wizard_id_fkey"),
                    j =>
                    {
                        j.HasKey("ProjectShareWizardId", "ResPartnerId").HasName("project_share_wizard_res_partner_rel_pkey");
                        j.ToTable("project_share_wizard_res_partner_rel");
                        j.HasIndex(new[] { "ResPartnerId", "ProjectShareWizardId" }, "project_share_wizard_res_part_res_partner_id_project_share__idx");
                    });
        });

        modelBuilder.Entity<ProjectTag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("project_tags_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProjectTagCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_tags_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProjectTagWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_tags_write_uid_fkey");
        });

        modelBuilder.Entity<ProjectTask>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("project_task_pkey");

            entity.HasIndex(e => e.AncestorId, "project_task_ancestor_id_index").HasFilter("(ancestor_id IS NOT NULL)");

            entity.HasIndex(e => e.EmailFrom, "project_task_email_from_index")
                .HasMethod("gin")
                .HasOperators(new[] { "gin_trgm_ops" });

            entity.HasIndex(e => e.Name, "project_task_name_index")
                .HasMethod("gin")
                .HasOperators(new[] { "gin_trgm_ops" });

            entity.HasIndex(e => e.SaleLineId, "project_task_sale_line_id_index").HasFilter("(sale_line_id IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.AnalyticAccount).WithMany(p => p.ProjectTasks)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_task_analytic_account_id_fkey");

            entity.HasOne(d => d.Ancestor).WithMany(p => p.InverseAncestor)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_task_ancestor_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.ProjectTasks)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("project_task_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProjectTaskCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_task_create_uid_fkey");

            entity.HasOne(d => d.DisplayProject).WithMany(p => p.ProjectTaskDisplayProjects)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_task_display_project_id_fkey");

            entity.HasOne(d => d.DisplayedImage).WithMany(p => p.ProjectTaskDisplayedImages)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_task_displayed_image_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.ProjectTaskMessageMainAttachments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_task_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Milestone).WithMany(p => p.ProjectTasks)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_task_milestone_id_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_task_parent_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.ProjectTasks)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_task_partner_id_fkey");

            entity.HasOne(d => d.Project).WithMany(p => p.ProjectTaskProjects)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_task_project_id_fkey");

            entity.HasOne(d => d.Recurrence).WithMany(p => p.ProjectTasks)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_task_recurrence_id_fkey");

            entity.HasOne(d => d.SaleLine).WithMany(p => p.ProjectTasks)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_task_sale_line_id_fkey");

            entity.HasOne(d => d.SaleOrder).WithMany(p => p.ProjectTasks)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_task_sale_order_id_fkey");

            entity.HasOne(d => d.Stage).WithMany(p => p.ProjectTasks)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("project_task_stage_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProjectTaskWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_task_write_uid_fkey");

            entity.HasMany(d => d.DependsOns).WithMany(p => p.Tasks)
                .UsingEntity<Dictionary<string, object>>(
                    "TaskDependenciesRel",
                    r => r.HasOne<ProjectTask>().WithMany()
                        .HasForeignKey("DependsOnId")
                        .HasConstraintName("task_dependencies_rel_depends_on_id_fkey"),
                    l => l.HasOne<ProjectTask>().WithMany()
                        .HasForeignKey("TaskId")
                        .HasConstraintName("task_dependencies_rel_task_id_fkey"),
                    j =>
                    {
                        j.HasKey("TaskId", "DependsOnId").HasName("task_dependencies_rel_pkey");
                        j.ToTable("task_dependencies_rel");
                        j.HasIndex(new[] { "DependsOnId", "TaskId" }, "task_dependencies_rel_depends_on_id_task_id_idx");
                    });

            entity.HasMany(d => d.ProjectTags).WithMany(p => p.ProjectTasks)
                .UsingEntity<Dictionary<string, object>>(
                    "ProjectTagsProjectTaskRel",
                    r => r.HasOne<ProjectTag>().WithMany()
                        .HasForeignKey("ProjectTagsId")
                        .HasConstraintName("project_tags_project_task_rel_project_tags_id_fkey"),
                    l => l.HasOne<ProjectTask>().WithMany()
                        .HasForeignKey("ProjectTaskId")
                        .HasConstraintName("project_tags_project_task_rel_project_task_id_fkey"),
                    j =>
                    {
                        j.HasKey("ProjectTaskId", "ProjectTagsId").HasName("project_tags_project_task_rel_pkey");
                        j.ToTable("project_tags_project_task_rel");
                        j.HasIndex(new[] { "ProjectTagsId", "ProjectTaskId" }, "project_tags_project_task_rel_project_tags_id_project_task__idx");
                    });

            entity.HasMany(d => d.Tasks).WithMany(p => p.DependsOns)
                .UsingEntity<Dictionary<string, object>>(
                    "TaskDependenciesRel",
                    r => r.HasOne<ProjectTask>().WithMany()
                        .HasForeignKey("TaskId")
                        .HasConstraintName("task_dependencies_rel_task_id_fkey"),
                    l => l.HasOne<ProjectTask>().WithMany()
                        .HasForeignKey("DependsOnId")
                        .HasConstraintName("task_dependencies_rel_depends_on_id_fkey"),
                    j =>
                    {
                        j.HasKey("TaskId", "DependsOnId").HasName("task_dependencies_rel_pkey");
                        j.ToTable("task_dependencies_rel");
                        j.HasIndex(new[] { "DependsOnId", "TaskId" }, "task_dependencies_rel_depends_on_id_task_id_idx");
                    });
        });

        modelBuilder.Entity<ProjectTaskRecurrence>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("project_task_recurrence_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProjectTaskRecurrenceCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_task_recurrence_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProjectTaskRecurrenceWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_task_recurrence_write_uid_fkey");
        });

        modelBuilder.Entity<ProjectTaskType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("project_task_type_pkey");

            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProjectTaskTypeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_task_type_create_uid_fkey");

            entity.HasOne(d => d.MailTemplate).WithMany(p => p.ProjectTaskTypeMailTemplates)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_task_type_mail_template_id_fkey");

            entity.HasOne(d => d.RatingTemplate).WithMany(p => p.ProjectTaskTypeRatingTemplates)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_task_type_rating_template_id_fkey");

            entity.HasOne(d => d.SmsTemplate).WithMany(p => p.ProjectTaskTypes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_task_type_sms_template_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.ProjectTaskTypeUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_task_type_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProjectTaskTypeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_task_type_write_uid_fkey");

            entity.HasMany(d => d.Projects).WithMany(p => p.Types)
                .UsingEntity<Dictionary<string, object>>(
                    "ProjectTaskTypeRel",
                    r => r.HasOne<ProjectProject>().WithMany()
                        .HasForeignKey("ProjectId")
                        .HasConstraintName("project_task_type_rel_project_id_fkey"),
                    l => l.HasOne<ProjectTaskType>().WithMany()
                        .HasForeignKey("TypeId")
                        .HasConstraintName("project_task_type_rel_type_id_fkey"),
                    j =>
                    {
                        j.HasKey("TypeId", "ProjectId").HasName("project_task_type_rel_pkey");
                        j.ToTable("project_task_type_rel");
                        j.HasIndex(new[] { "ProjectId", "TypeId" }, "project_task_type_rel_project_id_type_id_idx");
                    });
        });

        modelBuilder.Entity<ProjectTaskTypeDeleteWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("project_task_type_delete_wizard_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProjectTaskTypeDeleteWizardCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_task_type_delete_wizard_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProjectTaskTypeDeleteWizardWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_task_type_delete_wizard_write_uid_fkey");

            entity.HasMany(d => d.ProjectProjects).WithMany(p => p.ProjectTaskTypeDeleteWizards)
                .UsingEntity<Dictionary<string, object>>(
                    "ProjectProjectProjectTaskTypeDeleteWizardRel",
                    r => r.HasOne<ProjectProject>().WithMany()
                        .HasForeignKey("ProjectProjectId")
                        .HasConstraintName("project_project_project_task_type_delet_project_project_id_fkey"),
                    l => l.HasOne<ProjectTaskTypeDeleteWizard>().WithMany()
                        .HasForeignKey("ProjectTaskTypeDeleteWizardId")
                        .HasConstraintName("project_project_project_task__project_task_type_delete_wiz_fkey"),
                    j =>
                    {
                        j.HasKey("ProjectTaskTypeDeleteWizardId", "ProjectProjectId").HasName("project_project_project_task_type_delete_wizard_rel_pkey");
                        j.ToTable("project_project_project_task_type_delete_wizard_rel");
                        j.HasIndex(new[] { "ProjectProjectId", "ProjectTaskTypeDeleteWizardId" }, "project_project_project_task__project_project_id_project_ta_idx");
                    });

            entity.HasMany(d => d.ProjectTaskTypes).WithMany(p => p.ProjectTaskTypeDeleteWizards)
                .UsingEntity<Dictionary<string, object>>(
                    "ProjectTaskTypeProjectTaskTypeDeleteWizardRel",
                    r => r.HasOne<ProjectTaskType>().WithMany()
                        .HasForeignKey("ProjectTaskTypeId")
                        .HasConstraintName("project_task_type_project_task_type_d_project_task_type_id_fkey"),
                    l => l.HasOne<ProjectTaskTypeDeleteWizard>().WithMany()
                        .HasForeignKey("ProjectTaskTypeDeleteWizardId")
                        .HasConstraintName("project_task_type_project_tas_project_task_type_delete_wiz_fkey"),
                    j =>
                    {
                        j.HasKey("ProjectTaskTypeDeleteWizardId", "ProjectTaskTypeId").HasName("project_task_type_project_task_type_delete_wizard_rel_pkey");
                        j.ToTable("project_task_type_project_task_type_delete_wizard_rel");
                        j.HasIndex(new[] { "ProjectTaskTypeId", "ProjectTaskTypeDeleteWizardId" }, "project_task_type_project_tas_project_task_type_id_project__idx");
                    });
        });

        modelBuilder.Entity<ProjectTaskUserRel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("project_task_user_rel_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProjectTaskUserRelCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_task_user_rel_create_uid_fkey");

            entity.HasOne(d => d.Stage).WithMany(p => p.ProjectTaskUserRels)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("project_task_user_rel_stage_id_fkey");

            entity.HasOne(d => d.Task).WithMany(p => p.ProjectTaskUserRels)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("project_task_user_rel_task_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.ProjectTaskUserRelUsers)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("project_task_user_rel_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProjectTaskUserRelWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_task_user_rel_write_uid_fkey");
        });

        modelBuilder.Entity<ProjectUpdate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("project_update_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProjectUpdateCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_update_create_uid_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.ProjectUpdates)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_update_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Project).WithMany(p => p.ProjectUpdates)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("project_update_project_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.ProjectUpdateUsers)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("project_update_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProjectUpdateWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("project_update_write_uid_fkey");
        });

        modelBuilder.Entity<PurchaseOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("purchase_order_pkey");

            entity.HasIndex(e => e.Name, "purchase_order_name_index")
                .HasMethod("gin")
                .HasOperators(new[] { "gin_trgm_ops" });

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.PurchaseOrders)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("purchase_order_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PurchaseOrderCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("purchase_order_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.PurchaseOrders)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("purchase_order_currency_id_fkey");

            entity.HasOne(d => d.DestAddress).WithMany(p => p.PurchaseOrderDestAddresses)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("purchase_order_dest_address_id_fkey");

            entity.HasOne(d => d.FiscalPosition).WithMany(p => p.PurchaseOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("purchase_order_fiscal_position_id_fkey");

            entity.HasOne(d => d.Group).WithMany(p => p.PurchaseOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("purchase_order_group_id_fkey");

            entity.HasOne(d => d.Incoterm).WithMany(p => p.PurchaseOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("purchase_order_incoterm_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.PurchaseOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("purchase_order_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.PurchaseOrderPartners)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("purchase_order_partner_id_fkey");

            entity.HasOne(d => d.PaymentTerm).WithMany(p => p.PurchaseOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("purchase_order_payment_term_id_fkey");

            entity.HasOne(d => d.PickingType).WithMany(p => p.PurchaseOrders)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("purchase_order_picking_type_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.PurchaseOrderUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("purchase_order_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PurchaseOrderWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("purchase_order_write_uid_fkey");

            entity.HasMany(d => d.AccountMoves).WithMany(p => p.PurchaseOrders)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountMovePurchaseOrderRel",
                    r => r.HasOne<AccountMove>().WithMany()
                        .HasForeignKey("AccountMoveId")
                        .HasConstraintName("account_move_purchase_order_rel_account_move_id_fkey"),
                    l => l.HasOne<PurchaseOrder>().WithMany()
                        .HasForeignKey("PurchaseOrderId")
                        .HasConstraintName("account_move_purchase_order_rel_purchase_order_id_fkey"),
                    j =>
                    {
                        j.HasKey("PurchaseOrderId", "AccountMoveId").HasName("account_move_purchase_order_rel_pkey");
                        j.ToTable("account_move_purchase_order_rel");
                        j.HasIndex(new[] { "AccountMoveId", "PurchaseOrderId" }, "account_move_purchase_order_r_account_move_id_purchase_orde_idx");
                    });

            entity.HasMany(d => d.StockPickings).WithMany(p => p.PurchaseOrders)
                .UsingEntity<Dictionary<string, object>>(
                    "PurchaseOrderStockPickingRel",
                    r => r.HasOne<StockPicking>().WithMany()
                        .HasForeignKey("StockPickingId")
                        .HasConstraintName("purchase_order_stock_picking_rel_stock_picking_id_fkey"),
                    l => l.HasOne<PurchaseOrder>().WithMany()
                        .HasForeignKey("PurchaseOrderId")
                        .HasConstraintName("purchase_order_stock_picking_rel_purchase_order_id_fkey"),
                    j =>
                    {
                        j.HasKey("PurchaseOrderId", "StockPickingId").HasName("purchase_order_stock_picking_rel_pkey");
                        j.ToTable("purchase_order_stock_picking_rel");
                        j.HasIndex(new[] { "StockPickingId", "PurchaseOrderId" }, "purchase_order_stock_picking__stock_picking_id_purchase_ord_idx");
                    });
        });

        modelBuilder.Entity<PurchaseOrderLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("purchase_order_line_pkey");

            entity.HasIndex(e => e.AnalyticDistribution, "purchase_order_line_analytic_distribution_gin_index").HasMethod("gin");

            entity.HasIndex(e => e.OrderpointId, "purchase_order_line_orderpoint_id_index").HasFilter("(orderpoint_id IS NOT NULL)");

            entity.HasIndex(e => e.ProductId, "purchase_order_line_product_id_index").HasFilter("(product_id IS NOT NULL)");

            entity.HasIndex(e => e.SaleLineId, "purchase_order_line_sale_line_id_index").HasFilter("(sale_line_id IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Company).WithMany(p => p.PurchaseOrderLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("purchase_order_line_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PurchaseOrderLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("purchase_order_line_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.PurchaseOrderLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("purchase_order_line_currency_id_fkey");

            entity.HasOne(d => d.Order).WithMany(p => p.PurchaseOrderLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("purchase_order_line_order_id_fkey");

            entity.HasOne(d => d.Orderpoint).WithMany(p => p.PurchaseOrderLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("purchase_order_line_orderpoint_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.PurchaseOrderLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("purchase_order_line_partner_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.PurchaseOrderLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("purchase_order_line_product_id_fkey");

            entity.HasOne(d => d.ProductPackaging).WithMany(p => p.PurchaseOrderLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("purchase_order_line_product_packaging_id_fkey");

            entity.HasOne(d => d.ProductUomNavigation).WithMany(p => p.PurchaseOrderLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("purchase_order_line_product_uom_fkey");

            entity.HasOne(d => d.SaleLine).WithMany(p => p.PurchaseOrderLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("purchase_order_line_sale_line_id_fkey");

            entity.HasOne(d => d.SaleOrder).WithMany(p => p.PurchaseOrderLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("purchase_order_line_sale_order_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PurchaseOrderLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("purchase_order_line_write_uid_fkey");

            entity.HasMany(d => d.AccountTaxes).WithMany(p => p.PurchaseOrderLines)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountTaxPurchaseOrderLineRel",
                    r => r.HasOne<AccountTax>().WithMany()
                        .HasForeignKey("AccountTaxId")
                        .HasConstraintName("account_tax_purchase_order_line_rel_account_tax_id_fkey"),
                    l => l.HasOne<PurchaseOrderLine>().WithMany()
                        .HasForeignKey("PurchaseOrderLineId")
                        .HasConstraintName("account_tax_purchase_order_line_rel_purchase_order_line_id_fkey"),
                    j =>
                    {
                        j.HasKey("PurchaseOrderLineId", "AccountTaxId").HasName("account_tax_purchase_order_line_rel_pkey");
                        j.ToTable("account_tax_purchase_order_line_rel");
                        j.HasIndex(new[] { "AccountTaxId", "PurchaseOrderLineId" }, "account_tax_purchase_order_li_account_tax_id_purchase_order_idx");
                    });
        });

        modelBuilder.Entity<RatingRating>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("rating_rating_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.RatingRatingCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("rating_rating_create_uid_fkey");

            entity.HasOne(d => d.Message).WithMany(p => p.RatingRatings)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("rating_rating_message_id_fkey");

            entity.HasOne(d => d.ParentResModelNavigation).WithMany(p => p.RatingRatingParentResModelNavigations)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("rating_rating_parent_res_model_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.RatingRatingPartners)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("rating_rating_partner_id_fkey");

            entity.HasOne(d => d.Publisher).WithMany(p => p.RatingRatingPublishers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("rating_rating_publisher_id_fkey");

            entity.HasOne(d => d.RatedPartner).WithMany(p => p.RatingRatingRatedPartners)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("rating_rating_rated_partner_id_fkey");

            entity.HasOne(d => d.ResModelNavigation).WithMany(p => p.RatingRatingResModelNavigations)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("rating_rating_res_model_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.RatingRatingWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("rating_rating_write_uid_fkey");
        });

        modelBuilder.Entity<RecurringPayment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("recurring_payment_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.RecurringPayments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("recurring_payment_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.RecurringPaymentCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("recurring_payment_create_uid_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.RecurringPayments)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("recurring_payment_partner_id_fkey");

            entity.HasOne(d => d.Template).WithMany(p => p.RecurringPayments)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("recurring_payment_template_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.RecurringPaymentWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("recurring_payment_write_uid_fkey");
        });

        modelBuilder.Entity<RecurringPaymentLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("recurring_payment_line_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.RecurringPaymentLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("recurring_payment_line_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.RecurringPaymentLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("recurring_payment_line_create_uid_fkey");

            entity.HasOne(d => d.Journal).WithMany(p => p.RecurringPaymentLines)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("recurring_payment_line_journal_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.RecurringPaymentLines)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("recurring_payment_line_partner_id_fkey");

            entity.HasOne(d => d.Payment).WithMany(p => p.RecurringPaymentLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("recurring_payment_line_payment_id_fkey");

            entity.HasOne(d => d.RecurringPayment).WithMany(p => p.RecurringPaymentLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("recurring_payment_line_recurring_payment_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.RecurringPaymentLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("recurring_payment_line_write_uid_fkey");
        });

        modelBuilder.Entity<RepairFee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("repair_fee_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.RepairFees)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_fee_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.RepairFeeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_fee_create_uid_fkey");

            entity.HasOne(d => d.InvoiceLine).WithMany(p => p.RepairFees)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_fee_invoice_line_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.RepairFees)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_fee_product_id_fkey");

            entity.HasOne(d => d.ProductUomNavigation).WithMany(p => p.RepairFees)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("repair_fee_product_uom_fkey");

            entity.HasOne(d => d.Repair).WithMany(p => p.RepairFees)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("repair_fee_repair_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.RepairFeeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_fee_write_uid_fkey");

            entity.HasMany(d => d.Taxes).WithMany(p => p.RepairFeeLines)
                .UsingEntity<Dictionary<string, object>>(
                    "RepairFeeLineTax",
                    r => r.HasOne<AccountTax>().WithMany()
                        .HasForeignKey("TaxId")
                        .HasConstraintName("repair_fee_line_tax_tax_id_fkey"),
                    l => l.HasOne<RepairFee>().WithMany()
                        .HasForeignKey("RepairFeeLineId")
                        .HasConstraintName("repair_fee_line_tax_repair_fee_line_id_fkey"),
                    j =>
                    {
                        j.HasKey("RepairFeeLineId", "TaxId").HasName("repair_fee_line_tax_pkey");
                        j.ToTable("repair_fee_line_tax");
                        j.HasIndex(new[] { "TaxId", "RepairFeeLineId" }, "repair_fee_line_tax_tax_id_repair_fee_line_id_idx");
                    });
        });

        modelBuilder.Entity<RepairLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("repair_line_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.RepairLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_line_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.RepairLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_line_create_uid_fkey");

            entity.HasOne(d => d.InvoiceLine).WithMany(p => p.RepairLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_line_invoice_line_id_fkey");

            entity.HasOne(d => d.LocationDest).WithMany(p => p.RepairLineLocationDests)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("repair_line_location_dest_id_fkey");

            entity.HasOne(d => d.Location).WithMany(p => p.RepairLineLocations)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("repair_line_location_id_fkey");

            entity.HasOne(d => d.Lot).WithMany(p => p.RepairLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_line_lot_id_fkey");

            entity.HasOne(d => d.Move).WithMany(p => p.RepairLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_line_move_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.RepairLines)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("repair_line_product_id_fkey");

            entity.HasOne(d => d.ProductUomNavigation).WithMany(p => p.RepairLines)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("repair_line_product_uom_fkey");

            entity.HasOne(d => d.Repair).WithMany(p => p.RepairLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("repair_line_repair_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.RepairLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_line_write_uid_fkey");

            entity.HasMany(d => d.Taxes).WithMany(p => p.RepairOperationLines)
                .UsingEntity<Dictionary<string, object>>(
                    "RepairOperationLineTax",
                    r => r.HasOne<AccountTax>().WithMany()
                        .HasForeignKey("TaxId")
                        .HasConstraintName("repair_operation_line_tax_tax_id_fkey"),
                    l => l.HasOne<RepairLine>().WithMany()
                        .HasForeignKey("RepairOperationLineId")
                        .HasConstraintName("repair_operation_line_tax_repair_operation_line_id_fkey"),
                    j =>
                    {
                        j.HasKey("RepairOperationLineId", "TaxId").HasName("repair_operation_line_tax_pkey");
                        j.ToTable("repair_operation_line_tax");
                        j.HasIndex(new[] { "TaxId", "RepairOperationLineId" }, "repair_operation_line_tax_tax_id_repair_operation_line_id_idx");
                    });
        });

        modelBuilder.Entity<RepairOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("repair_order_pkey");

            entity.HasIndex(e => e.Name, "repair_order_name_index")
                .HasMethod("gin")
                .HasOperators(new[] { "gin_trgm_ops" });

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Address).WithMany(p => p.RepairOrderAddresses)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_order_address_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.RepairOrders)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("repair_order_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.RepairOrderCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_order_create_uid_fkey");

            entity.HasOne(d => d.Invoice).WithMany(p => p.RepairOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_order_invoice_id_fkey");

            entity.HasOne(d => d.Location).WithMany(p => p.RepairOrders)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("repair_order_location_id_fkey");

            entity.HasOne(d => d.Lot).WithMany(p => p.RepairOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_order_lot_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.RepairOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_order_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Move).WithMany(p => p.RepairOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_order_move_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.RepairOrderPartners)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_order_partner_id_fkey");

            entity.HasOne(d => d.PartnerInvoice).WithMany(p => p.RepairOrderPartnerInvoices)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_order_partner_invoice_id_fkey");

            entity.HasOne(d => d.Picking).WithMany(p => p.RepairOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_order_picking_id_fkey");

            entity.HasOne(d => d.Pricelist).WithMany(p => p.RepairOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_order_pricelist_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.RepairOrders)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("repair_order_product_id_fkey");

            entity.HasOne(d => d.ProductUomNavigation).WithMany(p => p.RepairOrders)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("repair_order_product_uom_fkey");

            entity.HasOne(d => d.SaleOrder).WithMany(p => p.RepairOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_order_sale_order_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.RepairOrderUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_order_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.RepairOrderWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_order_write_uid_fkey");

            entity.HasMany(d => d.RepairTags).WithMany(p => p.RepairOrders)
                .UsingEntity<Dictionary<string, object>>(
                    "RepairOrderRepairTagsRel",
                    r => r.HasOne<RepairTag>().WithMany()
                        .HasForeignKey("RepairTagsId")
                        .HasConstraintName("repair_order_repair_tags_rel_repair_tags_id_fkey"),
                    l => l.HasOne<RepairOrder>().WithMany()
                        .HasForeignKey("RepairOrderId")
                        .HasConstraintName("repair_order_repair_tags_rel_repair_order_id_fkey"),
                    j =>
                    {
                        j.HasKey("RepairOrderId", "RepairTagsId").HasName("repair_order_repair_tags_rel_pkey");
                        j.ToTable("repair_order_repair_tags_rel");
                        j.HasIndex(new[] { "RepairTagsId", "RepairOrderId" }, "repair_order_repair_tags_rel_repair_tags_id_repair_order_id_idx");
                    });
        });

        modelBuilder.Entity<RepairOrderMakeInvoice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("repair_order_make_invoice_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.RepairOrderMakeInvoiceCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_order_make_invoice_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.RepairOrderMakeInvoiceWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_order_make_invoice_write_uid_fkey");
        });

        modelBuilder.Entity<RepairTag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("repair_tags_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.RepairTagCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_tags_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.RepairTagWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("repair_tags_write_uid_fkey");
        });

        modelBuilder.Entity<ReportLayout>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("report_layout_pkey");

            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.ReportLayoutCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("report_layout_create_uid_fkey");

            entity.HasOne(d => d.View).WithMany(p => p.ReportLayouts)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("report_layout_view_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ReportLayoutWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("report_layout_write_uid_fkey");
        });

        modelBuilder.Entity<ReportPaperformat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("report_paperformat_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ReportPaperformatCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("report_paperformat_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ReportPaperformatWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("report_paperformat_write_uid_fkey");
        });

        modelBuilder.Entity<ResBank>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_bank_pkey");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.CountryNavigation).WithMany(p => p.ResBanks)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_bank_country_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResBankCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_bank_create_uid_fkey");

            entity.HasOne(d => d.StateNavigation).WithMany(p => p.ResBanks)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_bank_state_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResBankWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_bank_write_uid_fkey");
        });

        modelBuilder.Entity<ResCompany>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_company_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.AccountCashBasisBaseAccount).WithMany(p => p.ResCompanyAccountCashBasisBaseAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_account_cash_basis_base_account_id_fkey");

            entity.HasOne(d => d.AccountDefaultPosReceivableAccount).WithMany(p => p.ResCompanyAccountDefaultPosReceivableAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_account_default_pos_receivable_account_id_fkey");

            entity.HasOne(d => d.AccountFiscalCountry).WithMany(p => p.ResCompanies)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_account_fiscal_country_id_fkey");

            entity.HasOne(d => d.AccountJournalEarlyPayDiscountGainAccount).WithMany(p => p.ResCompanyAccountJournalEarlyPayDiscountGainAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_account_journal_early_pay_discount_gain_accoun_fkey");

            entity.HasOne(d => d.AccountJournalEarlyPayDiscountLossAccount).WithMany(p => p.ResCompanyAccountJournalEarlyPayDiscountLossAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_account_journal_early_pay_discount_loss_accoun_fkey");

            entity.HasOne(d => d.AccountJournalPaymentCreditAccount).WithMany(p => p.ResCompanyAccountJournalPaymentCreditAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_account_journal_payment_credit_account_id_fkey");

            entity.HasOne(d => d.AccountJournalPaymentDebitAccount).WithMany(p => p.ResCompanyAccountJournalPaymentDebitAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_account_journal_payment_debit_account_id_fkey");

            entity.HasOne(d => d.AccountJournalSuspenseAccount).WithMany(p => p.ResCompanyAccountJournalSuspenseAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_account_journal_suspense_account_id_fkey");

            entity.HasOne(d => d.AccountOpeningMove).WithMany(p => p.ResCompanies)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_account_opening_move_id_fkey");

            entity.HasOne(d => d.AccountPurchaseTax).WithMany(p => p.ResCompanyAccountPurchaseTaxes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_account_purchase_tax_id_fkey");

            entity.HasOne(d => d.AccountSaleTax).WithMany(p => p.ResCompanyAccountSaleTaxes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_account_sale_tax_id_fkey");

            entity.HasOne(d => d.AutomaticEntryDefaultJournal).WithMany(p => p.ResCompanyAutomaticEntryDefaultJournals)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_automatic_entry_default_journal_id_fkey");

            entity.HasOne(d => d.ChartTemplate).WithMany(p => p.ResCompanies)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_chart_template_id_fkey");

            entity.HasOne(d => d.CompanyExpenseJournal).WithMany(p => p.ResCompanyCompanyExpenseJournals)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_company_expense_journal_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResCompanyCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_create_uid_fkey");

            entity.HasOne(d => d.CurrencyExchangeJournal).WithMany(p => p.ResCompanyCurrencyExchangeJournals)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_currency_exchange_journal_id_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.ResCompanies)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("res_company_currency_id_fkey");

            entity.HasOne(d => d.DefaultCashDifferenceExpenseAccount).WithMany(p => p.ResCompanyDefaultCashDifferenceExpenseAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_default_cash_difference_expense_account_id_fkey");

            entity.HasOne(d => d.DefaultCashDifferenceIncomeAccount).WithMany(p => p.ResCompanyDefaultCashDifferenceIncomeAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_default_cash_difference_income_account_id_fkey");

            entity.HasOne(d => d.ExpenseAccrualAccount).WithMany(p => p.ResCompanyExpenseAccrualAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_expense_accrual_account_id_fkey");

            entity.HasOne(d => d.ExpenseCurrencyExchangeAccount).WithMany(p => p.ResCompanyExpenseCurrencyExchangeAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_expense_currency_exchange_account_id_fkey");

            entity.HasOne(d => d.ExpenseJournal).WithMany(p => p.ResCompanyExpenseJournals)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_expense_journal_id_fkey");

            entity.HasOne(d => d.ExternalReportLayout).WithMany(p => p.ResCompanies)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_external_report_layout_id_fkey");

            entity.HasOne(d => d.IncomeCurrencyExchangeAccount).WithMany(p => p.ResCompanyIncomeCurrencyExchangeAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_income_currency_exchange_account_id_fkey");

            entity.HasOne(d => d.Incoterm).WithMany(p => p.ResCompanies)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_incoterm_id_fkey");

            entity.HasOne(d => d.InternalTransitLocation).WithMany(p => p.ResCompanies)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("res_company_internal_transit_location_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.ResCompanies)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Nomenclature).WithMany(p => p.ResCompanies)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_nomenclature_id_fkey");

            entity.HasOne(d => d.Paperformat).WithMany(p => p.ResCompanies)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_paperformat_id_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_parent_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.ResCompanies)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("res_company_partner_id_fkey");

            entity.HasOne(d => d.PropertyStockAccountInputCateg).WithMany(p => p.ResCompanyPropertyStockAccountInputCategs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_property_stock_account_input_categ_id_fkey");

            entity.HasOne(d => d.PropertyStockAccountOutputCateg).WithMany(p => p.ResCompanyPropertyStockAccountOutputCategs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_property_stock_account_output_categ_id_fkey");

            entity.HasOne(d => d.PropertyStockValuationAccount).WithMany(p => p.ResCompanyPropertyStockValuationAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_property_stock_valuation_account_id_fkey");

            entity.HasOne(d => d.ResourceCalendar).WithMany(p => p.ResCompanies)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("res_company_resource_calendar_id_fkey");

            entity.HasOne(d => d.RevenueAccrualAccount).WithMany(p => p.ResCompanyRevenueAccrualAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_revenue_accrual_account_id_fkey");

            entity.HasOne(d => d.SaleOrderTemplate).WithMany(p => p.ResCompanies)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_sale_order_template_id_fkey");

            entity.HasOne(d => d.StockMailConfirmationTemplate).WithMany(p => p.ResCompanies)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_stock_mail_confirmation_template_id_fkey");

            entity.HasOne(d => d.StockSmsConfirmationTemplate).WithMany(p => p.ResCompanies)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_stock_sms_confirmation_template_id_fkey");

            entity.HasOne(d => d.TaxCashBasisJournal).WithMany(p => p.ResCompanyTaxCashBasisJournals)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_tax_cash_basis_journal_id_fkey");

            entity.HasOne(d => d.TransferAccount).WithMany(p => p.ResCompanyTransferAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_transfer_account_id_fkey");

            entity.HasOne(d => d.Website).WithMany(p => p.ResCompanies)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_website_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResCompanyWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_write_uid_fkey");

            entity.HasMany(d => d.Users).WithMany(p => p.Cids)
                .UsingEntity<Dictionary<string, object>>(
                    "ResCompanyUsersRel",
                    r => r.HasOne<ResUser>().WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("res_company_users_rel_user_id_fkey"),
                    l => l.HasOne<ResCompany>().WithMany()
                        .HasForeignKey("Cid")
                        .HasConstraintName("res_company_users_rel_cid_fkey"),
                    j =>
                    {
                        j.HasKey("Cid", "UserId").HasName("res_company_users_rel_pkey");
                        j.ToTable("res_company_users_rel");
                        j.HasIndex(new[] { "UserId", "Cid" }, "res_company_users_rel_user_id_cid_idx");
                    });
        });

        modelBuilder.Entity<ResConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_config_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResConfigCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_config_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResConfigWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_config_write_uid_fkey");
        });

        modelBuilder.Entity<ResConfigInstaller>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_config_installer_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResConfigInstallerCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_config_installer_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResConfigInstallerWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_config_installer_write_uid_fkey");
        });

        modelBuilder.Entity<ResConfigSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_config_settings_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.AuthSignupTemplateUser).WithMany(p => p.ResConfigSettingAuthSignupTemplateUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_config_settings_auth_signup_template_user_id_fkey");

            entity.HasOne(d => d.ChartTemplate).WithMany(p => p.ResConfigSettings)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_config_settings_chart_template_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.ResConfigSettings)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("res_config_settings_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResConfigSettingCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_config_settings_create_uid_fkey");

            entity.HasOne(d => d.DepositDefaultProduct).WithMany(p => p.ResConfigSettingDepositDefaultProducts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_config_settings_deposit_default_product_id_fkey");

            entity.HasOne(d => d.Digest).WithMany(p => p.ResConfigSettings)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_config_settings_digest_id_fkey");

            entity.HasOne(d => d.InvoiceMailTemplate).WithMany(p => p.ResConfigSettings)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_config_settings_invoice_mail_template_id_fkey");

            entity.HasOne(d => d.PosConfig).WithMany(p => p.ResConfigSettings)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_config_settings_pos_config_id_fkey");

            entity.HasOne(d => d.PosDefaultFiscalPosition).WithMany(p => p.ResConfigSettingsNavigation)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_config_settings_pos_default_fiscal_position_id_fkey");

            entity.HasOne(d => d.PosIfaceStartCateg).WithMany(p => p.ResConfigSettingsNavigation)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_config_settings_pos_iface_start_categ_id_fkey");

            entity.HasOne(d => d.PosPricelist).WithMany(p => p.ResConfigSettingsNavigation)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_config_settings_pos_pricelist_id_fkey");

            entity.HasOne(d => d.PosTipProduct).WithMany(p => p.ResConfigSettingPosTipProducts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_config_settings_pos_tip_product_id_fkey");

            entity.HasOne(d => d.Website).WithMany(p => p.ResConfigSettings)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("res_config_settings_website_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResConfigSettingWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_config_settings_write_uid_fkey");

            entity.HasMany(d => d.AccountFiscalPositions).WithMany(p => p.ResConfigSettings)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountFiscalPositionResConfigSettingsRel",
                    r => r.HasOne<AccountFiscalPosition>().WithMany()
                        .HasForeignKey("AccountFiscalPositionId")
                        .HasConstraintName("account_fiscal_position_res_con_account_fiscal_position_id_fkey"),
                    l => l.HasOne<ResConfigSetting>().WithMany()
                        .HasForeignKey("ResConfigSettingsId")
                        .HasConstraintName("account_fiscal_position_res_config__res_config_settings_id_fkey"),
                    j =>
                    {
                        j.HasKey("ResConfigSettingsId", "AccountFiscalPositionId").HasName("account_fiscal_position_res_config_settings_rel_pkey");
                        j.ToTable("account_fiscal_position_res_config_settings_rel");
                        j.HasIndex(new[] { "AccountFiscalPositionId", "ResConfigSettingsId" }, "account_fiscal_position_res_c_account_fiscal_position_id_re_idx");
                    });

            entity.HasMany(d => d.PosCategories).WithMany(p => p.ResConfigSettings)
                .UsingEntity<Dictionary<string, object>>(
                    "PosCategoryResConfigSettingsRel",
                    r => r.HasOne<PosCategory>().WithMany()
                        .HasForeignKey("PosCategoryId")
                        .HasConstraintName("pos_category_res_config_settings_rel_pos_category_id_fkey"),
                    l => l.HasOne<ResConfigSetting>().WithMany()
                        .HasForeignKey("ResConfigSettingsId")
                        .HasConstraintName("pos_category_res_config_settings_re_res_config_settings_id_fkey"),
                    j =>
                    {
                        j.HasKey("ResConfigSettingsId", "PosCategoryId").HasName("pos_category_res_config_settings_rel_pkey");
                        j.ToTable("pos_category_res_config_settings_rel");
                        j.HasIndex(new[] { "PosCategoryId", "ResConfigSettingsId" }, "pos_category_res_config_setti_pos_category_id_res_config_se_idx");
                    });

            entity.HasMany(d => d.ProductPricelists).WithMany(p => p.ResConfigSettings)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductPricelistResConfigSettingsRel",
                    r => r.HasOne<ProductPricelist>().WithMany()
                        .HasForeignKey("ProductPricelistId")
                        .HasConstraintName("product_pricelist_res_config_settings_product_pricelist_id_fkey"),
                    l => l.HasOne<ResConfigSetting>().WithMany()
                        .HasForeignKey("ResConfigSettingsId")
                        .HasConstraintName("product_pricelist_res_config_settin_res_config_settings_id_fkey"),
                    j =>
                    {
                        j.HasKey("ResConfigSettingsId", "ProductPricelistId").HasName("product_pricelist_res_config_settings_rel_pkey");
                        j.ToTable("product_pricelist_res_config_settings_rel");
                        j.HasIndex(new[] { "ProductPricelistId", "ResConfigSettingsId" }, "product_pricelist_res_config__product_pricelist_id_res_conf_idx");
                    });
        });

        modelBuilder.Entity<ResCountry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_country_pkey");

            entity.HasOne(d => d.AddressView).WithMany(p => p.ResCountries)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_country_address_view_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResCountryCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_country_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.ResCountries)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_country_currency_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResCountryWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_country_write_uid_fkey");

            entity.HasMany(d => d.ResCountryGroups).WithMany(p => p.ResCountries)
                .UsingEntity<Dictionary<string, object>>(
                    "ResCountryResCountryGroupRel",
                    r => r.HasOne<ResCountryGroup>().WithMany()
                        .HasForeignKey("ResCountryGroupId")
                        .HasConstraintName("res_country_res_country_group_rel_res_country_group_id_fkey"),
                    l => l.HasOne<ResCountry>().WithMany()
                        .HasForeignKey("ResCountryId")
                        .HasConstraintName("res_country_res_country_group_rel_res_country_id_fkey"),
                    j =>
                    {
                        j.HasKey("ResCountryId", "ResCountryGroupId").HasName("res_country_res_country_group_rel_pkey");
                        j.ToTable("res_country_res_country_group_rel");
                        j.HasIndex(new[] { "ResCountryGroupId", "ResCountryId" }, "res_country_res_country_group_res_country_group_id_res_coun_idx");
                    });
        });

        modelBuilder.Entity<ResCountryGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_country_group_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResCountryGroupCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_country_group_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResCountryGroupWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_country_group_write_uid_fkey");
        });

        modelBuilder.Entity<ResCountryState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_country_state_pkey");

            entity.HasOne(d => d.Country).WithMany(p => p.ResCountryStates)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("res_country_state_country_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResCountryStateCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_country_state_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResCountryStateWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_country_state_write_uid_fkey");
        });

        modelBuilder.Entity<ResCurrency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_currency_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResCurrencyCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_currency_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResCurrencyWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_currency_write_uid_fkey");
        });

        modelBuilder.Entity<ResCurrencyRate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_currency_rate_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.ResCurrencyRates)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_currency_rate_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResCurrencyRateCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_currency_rate_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.ResCurrencyRates)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("res_currency_rate_currency_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResCurrencyRateWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_currency_rate_write_uid_fkey");
        });

        modelBuilder.Entity<ResGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_groups_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Category).WithMany(p => p.ResGroups)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_groups_category_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResGroupCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_groups_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResGroupWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_groups_write_uid_fkey");

            entity.HasMany(d => d.Gids).WithMany(p => p.Hids)
                .UsingEntity<Dictionary<string, object>>(
                    "ResGroupsImpliedRel",
                    r => r.HasOne<ResGroup>().WithMany()
                        .HasForeignKey("Gid")
                        .HasConstraintName("res_groups_implied_rel_gid_fkey"),
                    l => l.HasOne<ResGroup>().WithMany()
                        .HasForeignKey("Hid")
                        .HasConstraintName("res_groups_implied_rel_hid_fkey"),
                    j =>
                    {
                        j.HasKey("Gid", "Hid").HasName("res_groups_implied_rel_pkey");
                        j.ToTable("res_groups_implied_rel");
                        j.HasIndex(new[] { "Hid", "Gid" }, "res_groups_implied_rel_hid_gid_idx");
                    });

            entity.HasMany(d => d.Hids).WithMany(p => p.Gids)
                .UsingEntity<Dictionary<string, object>>(
                    "ResGroupsImpliedRel",
                    r => r.HasOne<ResGroup>().WithMany()
                        .HasForeignKey("Hid")
                        .HasConstraintName("res_groups_implied_rel_hid_fkey"),
                    l => l.HasOne<ResGroup>().WithMany()
                        .HasForeignKey("Gid")
                        .HasConstraintName("res_groups_implied_rel_gid_fkey"),
                    j =>
                    {
                        j.HasKey("Gid", "Hid").HasName("res_groups_implied_rel_pkey");
                        j.ToTable("res_groups_implied_rel");
                        j.HasIndex(new[] { "Hid", "Gid" }, "res_groups_implied_rel_hid_gid_idx");
                    });

            entity.HasMany(d => d.UidsNavigation).WithMany(p => p.Gids)
                .UsingEntity<Dictionary<string, object>>(
                    "ResGroupsUsersRel",
                    r => r.HasOne<ResUser>().WithMany()
                        .HasForeignKey("Uid")
                        .HasConstraintName("res_groups_users_rel_uid_fkey"),
                    l => l.HasOne<ResGroup>().WithMany()
                        .HasForeignKey("Gid")
                        .HasConstraintName("res_groups_users_rel_gid_fkey"),
                    j =>
                    {
                        j.HasKey("Gid", "Uid").HasName("res_groups_users_rel_pkey");
                        j.ToTable("res_groups_users_rel");
                        j.HasIndex(new[] { "Uid", "Gid" }, "res_groups_users_rel_uid_gid_idx");
                    });
        });

        modelBuilder.Entity<ResLang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_lang_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResLangCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_lang_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResLangWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_lang_write_uid_fkey");
        });

        modelBuilder.Entity<ResPartner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_partner_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CommercialPartner).WithMany(p => p.InverseCommercialPartner)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_commercial_partner_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.ResPartners)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_company_id_fkey");

            entity.HasOne(d => d.Country).WithMany(p => p.ResPartners)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("res_partner_country_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResPartnerCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_create_uid_fkey");

            entity.HasOne(d => d.Industry).WithMany(p => p.ResPartners)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_industry_id_fkey");

            entity.HasOne(d => d.LatestFollowupLevelIdWithoutLitNavigation).WithMany(p => p.ResPartners)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_latest_followup_level_id_without_lit_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.ResPartners)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_parent_id_fkey");

            entity.HasOne(d => d.PaymentResponsible).WithMany(p => p.ResPartnerPaymentResponsibles)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_payment_responsible_id_fkey");

            entity.HasOne(d => d.State).WithMany(p => p.ResPartners)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("res_partner_state_id_fkey");

            entity.HasOne(d => d.Team).WithMany(p => p.ResPartners)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_team_id_fkey");

            entity.HasOne(d => d.TitleNavigation).WithMany(p => p.ResPartners)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_title_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.ResPartnerUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_user_id_fkey");

            entity.HasOne(d => d.WebsiteNavigation).WithMany(p => p.ResPartners)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("res_partner_website_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResPartnerWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_write_uid_fkey");

            entity.HasMany(d => d.CalendarEvents).WithMany(p => p.ResPartners)
                .UsingEntity<Dictionary<string, object>>(
                    "CalendarEventResPartnerRel",
                    r => r.HasOne<CalendarEvent>().WithMany()
                        .HasForeignKey("CalendarEventId")
                        .HasConstraintName("calendar_event_res_partner_rel_calendar_event_id_fkey"),
                    l => l.HasOne<ResPartner>().WithMany()
                        .HasForeignKey("ResPartnerId")
                        .HasConstraintName("calendar_event_res_partner_rel_res_partner_id_fkey"),
                    j =>
                    {
                        j.HasKey("ResPartnerId", "CalendarEventId").HasName("calendar_event_res_partner_rel_pkey");
                        j.ToTable("calendar_event_res_partner_rel");
                        j.HasIndex(new[] { "CalendarEventId", "ResPartnerId" }, "calendar_event_res_partner_re_calendar_event_id_res_partner_idx");
                    });
        });

        modelBuilder.Entity<ResPartnerAutocompleteSync>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_partner_autocomplete_sync_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResPartnerAutocompleteSyncCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_autocomplete_sync_create_uid_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.ResPartnerAutocompleteSyncs)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("res_partner_autocomplete_sync_partner_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResPartnerAutocompleteSyncWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_autocomplete_sync_write_uid_fkey");
        });

        modelBuilder.Entity<ResPartnerBank>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_partner_bank_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Bank).WithMany(p => p.ResPartnerBanks)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_bank_bank_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.ResPartnerBanks)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_bank_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResPartnerBankCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_bank_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.ResPartnerBanks)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_bank_currency_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.ResPartnerBanks)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_bank_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.ResPartnerBanks)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("res_partner_bank_partner_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResPartnerBankWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_bank_write_uid_fkey");
        });

        modelBuilder.Entity<ResPartnerCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_partner_category_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResPartnerCategoryCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_category_create_uid_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("res_partner_category_parent_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResPartnerCategoryWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_category_write_uid_fkey");

            entity.HasMany(d => d.Partners).WithMany(p => p.Categories)
                .UsingEntity<Dictionary<string, object>>(
                    "ResPartnerResPartnerCategoryRel",
                    r => r.HasOne<ResPartner>().WithMany()
                        .HasForeignKey("PartnerId")
                        .HasConstraintName("res_partner_res_partner_category_rel_partner_id_fkey"),
                    l => l.HasOne<ResPartnerCategory>().WithMany()
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("res_partner_res_partner_category_rel_category_id_fkey"),
                    j =>
                    {
                        j.HasKey("CategoryId", "PartnerId").HasName("res_partner_res_partner_category_rel_pkey");
                        j.ToTable("res_partner_res_partner_category_rel");
                        j.HasIndex(new[] { "PartnerId", "CategoryId" }, "res_partner_res_partner_category_rel_partner_id_category_id_idx");
                    });
        });

        modelBuilder.Entity<ResPartnerIndustry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_partner_industry_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResPartnerIndustryCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_industry_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResPartnerIndustryWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_industry_write_uid_fkey");
        });

        modelBuilder.Entity<ResPartnerTitle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_partner_title_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResPartnerTitleCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_title_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResPartnerTitleWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_title_write_uid_fkey");
        });

        modelBuilder.Entity<ResUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_users_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Active).HasDefaultValueSql("true");

            entity.HasOne(d => d.Company).WithMany(p => p.ResUsers)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("res_users_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.InverseCreateU)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_users_create_uid_fkey");

            entity.HasOne(d => d.LastLunchLocation).WithMany(p => p.ResUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_users_last_lunch_location_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.ResUsers)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("res_users_partner_id_fkey");

            entity.HasOne(d => d.SaleTeam).WithMany(p => p.ResUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_users_sale_team_id_fkey");

            entity.HasOne(d => d.Website).WithMany(p => p.ResUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_users_website_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.InverseWriteU)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_users_write_uid_fkey");
        });

        modelBuilder.Entity<ResUsersApikey>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_users_apikeys_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.CreateDate).HasDefaultValueSql("(now() AT TIME ZONE 'utc'::text)");

            entity.HasOne(d => d.User).WithMany(p => p.ResUsersApikeys).HasConstraintName("res_users_apikeys_user_id_fkey");
        });

        modelBuilder.Entity<ResUsersApikeysDescription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_users_apikeys_description_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResUsersApikeysDescriptionCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_users_apikeys_description_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResUsersApikeysDescriptionWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_users_apikeys_description_write_uid_fkey");
        });

        modelBuilder.Entity<ResUsersDeletion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_users_deletion_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResUsersDeletionCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_users_deletion_create_uid_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.ResUsersDeletionUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_users_deletion_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResUsersDeletionWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_users_deletion_write_uid_fkey");
        });

        modelBuilder.Entity<ResUsersIdentitycheck>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_users_identitycheck_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResUsersIdentitycheckCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_users_identitycheck_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResUsersIdentitycheckWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_users_identitycheck_write_uid_fkey");
        });

        modelBuilder.Entity<ResUsersLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_users_log_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResUsersLogCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_users_log_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResUsersLogWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_users_log_write_uid_fkey");
        });

        modelBuilder.Entity<ResUsersSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_users_settings_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResUsersSettingCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_users_settings_create_uid_fkey");

            entity.HasOne(d => d.User).WithOne(p => p.ResUsersSettingUser)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("res_users_settings_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResUsersSettingWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_users_settings_write_uid_fkey");
        });

        modelBuilder.Entity<ResUsersSettingsVolume>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_users_settings_volumes_pkey");

            entity.HasIndex(e => new { e.UserSettingId, e.GuestId }, "res_users_settings_volumes_guest_unique")
                .IsUnique()
                .HasFilter("(guest_id IS NOT NULL)");

            entity.HasIndex(e => new { e.UserSettingId, e.PartnerId }, "res_users_settings_volumes_partner_unique")
                .IsUnique()
                .HasFilter("(partner_id IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResUsersSettingsVolumeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_users_settings_volumes_create_uid_fkey");

            entity.HasOne(d => d.Guest).WithMany(p => p.ResUsersSettingsVolumeGuests)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("res_users_settings_volumes_guest_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.ResUsersSettingsVolumePartners)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("res_users_settings_volumes_partner_id_fkey");

            entity.HasOne(d => d.UserSetting).WithMany(p => p.ResUsersSettingsVolumes)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("res_users_settings_volumes_user_setting_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResUsersSettingsVolumeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_users_settings_volumes_write_uid_fkey");
        });

        modelBuilder.Entity<ResetViewArchWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("reset_view_arch_wizard_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CompareView).WithMany(p => p.ResetViewArchWizardCompareViews)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("reset_view_arch_wizard_compare_view_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResetViewArchWizardCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("reset_view_arch_wizard_create_uid_fkey");

            entity.HasOne(d => d.View).WithMany(p => p.ResetViewArchWizardViews)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("reset_view_arch_wizard_view_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResetViewArchWizardWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("reset_view_arch_wizard_write_uid_fkey");
        });

        modelBuilder.Entity<ResourceCalendar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("resource_calendar_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.ResourceCalendars)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_calendar_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResourceCalendarCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_calendar_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResourceCalendarWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_calendar_write_uid_fkey");
        });

        modelBuilder.Entity<ResourceCalendarAttendance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("resource_calendar_attendance_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Calendar).WithMany(p => p.ResourceCalendarAttendances)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("resource_calendar_attendance_calendar_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResourceCalendarAttendanceCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_calendar_attendance_create_uid_fkey");

            entity.HasOne(d => d.Resource).WithMany(p => p.ResourceCalendarAttendances)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_calendar_attendance_resource_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResourceCalendarAttendanceWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_calendar_attendance_write_uid_fkey");
        });

        modelBuilder.Entity<ResourceCalendarLeaf>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("resource_calendar_leaves_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Calendar).WithMany(p => p.ResourceCalendarLeaves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_calendar_leaves_calendar_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.ResourceCalendarLeaves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_calendar_leaves_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResourceCalendarLeafCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_calendar_leaves_create_uid_fkey");

            entity.HasOne(d => d.Holiday).WithMany(p => p.ResourceCalendarLeaves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_calendar_leaves_holiday_id_fkey");

            entity.HasOne(d => d.Resource).WithMany(p => p.ResourceCalendarLeaves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_calendar_leaves_resource_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResourceCalendarLeafWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_calendar_leaves_write_uid_fkey");
        });

        modelBuilder.Entity<ResourceResource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("resource_resource_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Calendar).WithMany(p => p.ResourceResources)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("resource_resource_calendar_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.ResourceResources)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_resource_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResourceResourceCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_resource_create_uid_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.ResourceResourceUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_resource_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResourceResourceWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_resource_write_uid_fkey");
        });

        modelBuilder.Entity<SaleAdvancePaymentInv>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sale_advance_payment_inv_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.SaleAdvancePaymentInvs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_advance_payment_inv_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.SaleAdvancePaymentInvCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_advance_payment_inv_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.SaleAdvancePaymentInvs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_advance_payment_inv_currency_id_fkey");

            entity.HasOne(d => d.DepositAccount).WithMany(p => p.SaleAdvancePaymentInvs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_advance_payment_inv_deposit_account_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.SaleAdvancePaymentInvs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_advance_payment_inv_product_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.SaleAdvancePaymentInvWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_advance_payment_inv_write_uid_fkey");

            entity.HasMany(d => d.AccountTaxes).WithMany(p => p.SaleAdvancePaymentInvs)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountTaxSaleAdvancePaymentInvRel",
                    r => r.HasOne<AccountTax>().WithMany()
                        .HasForeignKey("AccountTaxId")
                        .HasConstraintName("account_tax_sale_advance_payment_inv_rel_account_tax_id_fkey"),
                    l => l.HasOne<SaleAdvancePaymentInv>().WithMany()
                        .HasForeignKey("SaleAdvancePaymentInvId")
                        .HasConstraintName("account_tax_sale_advance_payme_sale_advance_payment_inv_id_fkey"),
                    j =>
                    {
                        j.HasKey("SaleAdvancePaymentInvId", "AccountTaxId").HasName("account_tax_sale_advance_payment_inv_rel_pkey");
                        j.ToTable("account_tax_sale_advance_payment_inv_rel");
                        j.HasIndex(new[] { "AccountTaxId", "SaleAdvancePaymentInvId" }, "account_tax_sale_advance_paym_account_tax_id_sale_advance_p_idx");
                    });

            entity.HasMany(d => d.SaleOrders).WithMany(p => p.SaleAdvancePaymentInvs)
                .UsingEntity<Dictionary<string, object>>(
                    "SaleAdvancePaymentInvSaleOrderRel",
                    r => r.HasOne<SaleOrder>().WithMany()
                        .HasForeignKey("SaleOrderId")
                        .HasConstraintName("sale_advance_payment_inv_sale_order_rel_sale_order_id_fkey"),
                    l => l.HasOne<SaleAdvancePaymentInv>().WithMany()
                        .HasForeignKey("SaleAdvancePaymentInvId")
                        .HasConstraintName("sale_advance_payment_inv_sale__sale_advance_payment_inv_id_fkey"),
                    j =>
                    {
                        j.HasKey("SaleAdvancePaymentInvId", "SaleOrderId").HasName("sale_advance_payment_inv_sale_order_rel_pkey");
                        j.ToTable("sale_advance_payment_inv_sale_order_rel");
                        j.HasIndex(new[] { "SaleOrderId", "SaleAdvancePaymentInvId" }, "sale_advance_payment_inv_sale_sale_order_id_sale_advance_pa_idx");
                    });
        });

        modelBuilder.Entity<SaleOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sale_order_pkey");

            entity.HasIndex(e => e.Name, "sale_order_name_index")
                .HasMethod("gin")
                .HasOperators(new[] { "gin_trgm_ops" });

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.AnalyticAccount).WithMany(p => p.SaleOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_analytic_account_id_fkey");

            entity.HasOne(d => d.Campaign).WithMany(p => p.SaleOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_campaign_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.SaleOrders)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("sale_order_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.SaleOrderCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.SaleOrders)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("sale_order_currency_id_fkey");

            entity.HasOne(d => d.FiscalPosition).WithMany(p => p.SaleOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_fiscal_position_id_fkey");

            entity.HasOne(d => d.IncotermNavigation).WithMany(p => p.SaleOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_incoterm_fkey");

            entity.HasOne(d => d.Medium).WithMany(p => p.SaleOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_medium_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.SaleOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Opportunity).WithMany(p => p.SaleOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_opportunity_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.SaleOrderPartners)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("sale_order_partner_id_fkey");

            entity.HasOne(d => d.PartnerInvoice).WithMany(p => p.SaleOrderPartnerInvoices)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("sale_order_partner_invoice_id_fkey");

            entity.HasOne(d => d.PartnerShipping).WithMany(p => p.SaleOrderPartnerShippings)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("sale_order_partner_shipping_id_fkey");

            entity.HasOne(d => d.PaymentTerm).WithMany(p => p.SaleOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_payment_term_id_fkey");

            entity.HasOne(d => d.Pricelist).WithMany(p => p.SaleOrders)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("sale_order_pricelist_id_fkey");

            entity.HasOne(d => d.ProcurementGroup).WithMany(p => p.SaleOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_procurement_group_id_fkey");

            entity.HasOne(d => d.Project).WithMany(p => p.SaleOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_project_id_fkey");

            entity.HasOne(d => d.SaleOrderTemplate).WithMany(p => p.SaleOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_sale_order_template_id_fkey");

            entity.HasOne(d => d.Source).WithMany(p => p.SaleOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_source_id_fkey");

            entity.HasOne(d => d.Team).WithMany(p => p.SaleOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_team_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.SaleOrderUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_user_id_fkey");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.SaleOrders)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("sale_order_warehouse_id_fkey");

            entity.HasOne(d => d.Website).WithMany(p => p.SaleOrders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_website_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.SaleOrderWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_write_uid_fkey");

            entity.HasMany(d => d.Tags).WithMany(p => p.Orders)
                .UsingEntity<Dictionary<string, object>>(
                    "SaleOrderTagRel",
                    r => r.HasOne<CrmTag>().WithMany()
                        .HasForeignKey("TagId")
                        .HasConstraintName("sale_order_tag_rel_tag_id_fkey"),
                    l => l.HasOne<SaleOrder>().WithMany()
                        .HasForeignKey("OrderId")
                        .HasConstraintName("sale_order_tag_rel_order_id_fkey"),
                    j =>
                    {
                        j.HasKey("OrderId", "TagId").HasName("sale_order_tag_rel_pkey");
                        j.ToTable("sale_order_tag_rel");
                        j.HasIndex(new[] { "TagId", "OrderId" }, "sale_order_tag_rel_tag_id_order_id_idx");
                    });
        });

        modelBuilder.Entity<SaleOrderCancel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sale_order_cancel_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Author).WithMany(p => p.SaleOrderCancels)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_cancel_author_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.SaleOrderCancelCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_cancel_create_uid_fkey");

            entity.HasOne(d => d.Order).WithMany(p => p.SaleOrderCancels)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("sale_order_cancel_order_id_fkey");

            entity.HasOne(d => d.Template).WithMany(p => p.SaleOrderCancels)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_cancel_template_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.SaleOrderCancelWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_cancel_write_uid_fkey");
        });

        modelBuilder.Entity<SaleOrderLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sale_order_line_pkey");

            entity.HasIndex(e => e.AnalyticDistribution, "sale_order_line_analytic_distribution_gin_index").HasMethod("gin");

            entity.HasIndex(e => e.ProductId, "sale_order_line_product_id_index").HasFilter("(product_id IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Company).WithMany(p => p.SaleOrderLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_line_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.SaleOrderLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_line_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.SaleOrderLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_line_currency_id_fkey");

            entity.HasOne(d => d.LinkedLine).WithMany(p => p.InverseLinkedLine)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("sale_order_line_linked_line_id_fkey");

            entity.HasOne(d => d.Order).WithMany(p => p.SaleOrderLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("sale_order_line_order_id_fkey");

            entity.HasOne(d => d.OrderPartner).WithMany(p => p.SaleOrderLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_line_order_partner_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.SaleOrderLines)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("sale_order_line_product_id_fkey");

            entity.HasOne(d => d.ProductPackaging).WithMany(p => p.SaleOrderLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_line_product_packaging_id_fkey");

            entity.HasOne(d => d.ProductUomNavigation).WithMany(p => p.SaleOrderLines)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("sale_order_line_product_uom_fkey");

            entity.HasOne(d => d.Project).WithMany(p => p.SaleOrderLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_line_project_id_fkey");

            entity.HasOne(d => d.Route).WithMany(p => p.SaleOrderLines)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("sale_order_line_route_id_fkey");

            entity.HasOne(d => d.Salesman).WithMany(p => p.SaleOrderLineSalesmen)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_line_salesman_id_fkey");

            entity.HasOne(d => d.Task).WithMany(p => p.SaleOrderLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_line_task_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.SaleOrderLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_line_write_uid_fkey");

            entity.HasMany(d => d.AccountTaxes).WithMany(p => p.SaleOrderLines)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountTaxSaleOrderLineRel",
                    r => r.HasOne<AccountTax>().WithMany()
                        .HasForeignKey("AccountTaxId")
                        .HasConstraintName("account_tax_sale_order_line_rel_account_tax_id_fkey"),
                    l => l.HasOne<SaleOrderLine>().WithMany()
                        .HasForeignKey("SaleOrderLineId")
                        .HasConstraintName("account_tax_sale_order_line_rel_sale_order_line_id_fkey"),
                    j =>
                    {
                        j.HasKey("SaleOrderLineId", "AccountTaxId").HasName("account_tax_sale_order_line_rel_pkey");
                        j.ToTable("account_tax_sale_order_line_rel");
                        j.HasIndex(new[] { "AccountTaxId", "SaleOrderLineId" }, "account_tax_sale_order_line_r_account_tax_id_sale_order_lin_idx");
                    });

            entity.HasMany(d => d.ProductTemplateAttributeValues).WithMany(p => p.SaleOrderLines)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductTemplateAttributeValueSaleOrderLineRel",
                    r => r.HasOne<ProductTemplateAttributeValue>().WithMany()
                        .HasForeignKey("ProductTemplateAttributeValueId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("product_template_attribute_va_product_template_attribute_v_fkey"),
                    l => l.HasOne<SaleOrderLine>().WithMany()
                        .HasForeignKey("SaleOrderLineId")
                        .HasConstraintName("product_template_attribute_value_sale_o_sale_order_line_id_fkey"),
                    j =>
                    {
                        j.HasKey("SaleOrderLineId", "ProductTemplateAttributeValueId").HasName("product_template_attribute_value_sale_order_line_rel_pkey");
                        j.ToTable("product_template_attribute_value_sale_order_line_rel");
                        j.HasIndex(new[] { "ProductTemplateAttributeValueId", "SaleOrderLineId" }, "product_template_attribute_va_product_template_attribute_va_idx");
                    });
        });

        modelBuilder.Entity<SaleOrderOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sale_order_option_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.SaleOrderOptionCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_option_create_uid_fkey");

            entity.HasOne(d => d.Line).WithMany(p => p.SaleOrderOptions)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_option_line_id_fkey");

            entity.HasOne(d => d.Order).WithMany(p => p.SaleOrderOptions)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("sale_order_option_order_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.SaleOrderOptions)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("sale_order_option_product_id_fkey");

            entity.HasOne(d => d.Uom).WithMany(p => p.SaleOrderOptions)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("sale_order_option_uom_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.SaleOrderOptionWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_option_write_uid_fkey");
        });

        modelBuilder.Entity<SaleOrderTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sale_order_template_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.SaleOrderTemplates)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_template_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.SaleOrderTemplateCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_template_create_uid_fkey");

            entity.HasOne(d => d.MailTemplate).WithMany(p => p.SaleOrderTemplates)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_template_mail_template_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.SaleOrderTemplateWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_template_write_uid_fkey");
        });

        modelBuilder.Entity<SaleOrderTemplateLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sale_order_template_line_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Company).WithMany(p => p.SaleOrderTemplateLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_template_line_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.SaleOrderTemplateLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_template_line_create_uid_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.SaleOrderTemplateLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_template_line_product_id_fkey");

            entity.HasOne(d => d.ProductUom).WithMany(p => p.SaleOrderTemplateLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_template_line_product_uom_id_fkey");

            entity.HasOne(d => d.SaleOrderTemplate).WithMany(p => p.SaleOrderTemplateLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("sale_order_template_line_sale_order_template_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.SaleOrderTemplateLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_template_line_write_uid_fkey");
        });

        modelBuilder.Entity<SaleOrderTemplateOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sale_order_template_option_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.SaleOrderTemplateOptions)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_template_option_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.SaleOrderTemplateOptionCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_template_option_create_uid_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.SaleOrderTemplateOptions)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("sale_order_template_option_product_id_fkey");

            entity.HasOne(d => d.SaleOrderTemplate).WithMany(p => p.SaleOrderTemplateOptions)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("sale_order_template_option_sale_order_template_id_fkey");

            entity.HasOne(d => d.Uom).WithMany(p => p.SaleOrderTemplateOptions)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("sale_order_template_option_uom_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.SaleOrderTemplateOptionWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_order_template_option_write_uid_fkey");
        });

        modelBuilder.Entity<SalePaymentProviderOnboardingWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sale_payment_provider_onboarding_wizard_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.SalePaymentProviderOnboardingWizardCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_payment_provider_onboarding_wizard_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.SalePaymentProviderOnboardingWizardWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_payment_provider_onboarding_wizard_write_uid_fkey");
        });

        modelBuilder.Entity<SmsComposer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sms_composer_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.SmsComposerCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sms_composer_create_uid_fkey");

            entity.HasOne(d => d.Template).WithMany(p => p.SmsComposers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sms_composer_template_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.SmsComposerWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sms_composer_write_uid_fkey");
        });

        modelBuilder.Entity<SmsResend>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sms_resend_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.SmsResendCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sms_resend_create_uid_fkey");

            entity.HasOne(d => d.MailMessage).WithMany(p => p.SmsResends)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("sms_resend_mail_message_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.SmsResendWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sms_resend_write_uid_fkey");
        });

        modelBuilder.Entity<SmsResendRecipient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sms_resend_recipient_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.SmsResendRecipientCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sms_resend_recipient_create_uid_fkey");

            entity.HasOne(d => d.Notification).WithMany(p => p.SmsResendRecipients)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("sms_resend_recipient_notification_id_fkey");

            entity.HasOne(d => d.SmsResend).WithMany(p => p.SmsResendRecipients)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("sms_resend_recipient_sms_resend_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.SmsResendRecipientWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sms_resend_recipient_write_uid_fkey");
        });

        modelBuilder.Entity<SmsSm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sms_sms_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.SmsSmCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sms_sms_create_uid_fkey");

            entity.HasOne(d => d.MailMessage).WithMany(p => p.SmsSms)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sms_sms_mail_message_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.SmsSms)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sms_sms_partner_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.SmsSmWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sms_sms_write_uid_fkey");
        });

        modelBuilder.Entity<SmsTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sms_template_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.SmsTemplateCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sms_template_create_uid_fkey");

            entity.HasOne(d => d.ModelNavigation).WithMany(p => p.SmsTemplates)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("sms_template_model_id_fkey");

            entity.HasOne(d => d.SidebarAction).WithMany(p => p.SmsTemplates)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sms_template_sidebar_action_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.SmsTemplateWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sms_template_write_uid_fkey");
        });

        modelBuilder.Entity<SmsTemplatePreview>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sms_template_preview_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.SmsTemplatePreviewCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sms_template_preview_create_uid_fkey");

            entity.HasOne(d => d.SmsTemplate).WithMany(p => p.SmsTemplatePreviews)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("sms_template_preview_sms_template_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.SmsTemplatePreviewWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sms_template_preview_write_uid_fkey");
        });

        modelBuilder.Entity<SmsTemplateReset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sms_template_reset_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.SmsTemplateResetCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sms_template_reset_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.SmsTemplateResetWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sms_template_reset_write_uid_fkey");

            entity.HasMany(d => d.SmsTemplates).WithMany(p => p.SmsTemplateResets)
                .UsingEntity<Dictionary<string, object>>(
                    "SmsTemplateSmsTemplateResetRel",
                    r => r.HasOne<SmsTemplate>().WithMany()
                        .HasForeignKey("SmsTemplateId")
                        .HasConstraintName("sms_template_sms_template_reset_rel_sms_template_id_fkey"),
                    l => l.HasOne<SmsTemplateReset>().WithMany()
                        .HasForeignKey("SmsTemplateResetId")
                        .HasConstraintName("sms_template_sms_template_reset_rel_sms_template_reset_id_fkey"),
                    j =>
                    {
                        j.HasKey("SmsTemplateResetId", "SmsTemplateId").HasName("sms_template_sms_template_reset_rel_pkey");
                        j.ToTable("sms_template_sms_template_reset_rel");
                        j.HasIndex(new[] { "SmsTemplateId", "SmsTemplateResetId" }, "sms_template_sms_template_res_sms_template_id_sms_template__idx");
                    });
        });

        modelBuilder.Entity<SnailmailConfirmInvoice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("snailmail_confirm_invoice_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.SnailmailConfirmInvoiceCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("snailmail_confirm_invoice_create_uid_fkey");

            entity.HasOne(d => d.InvoiceSend).WithMany(p => p.SnailmailConfirmInvoices)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("snailmail_confirm_invoice_invoice_send_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.SnailmailConfirmInvoiceWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("snailmail_confirm_invoice_write_uid_fkey");
        });

        modelBuilder.Entity<SnailmailLetter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("snailmail_letter_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Attachment).WithMany(p => p.SnailmailLetters)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("snailmail_letter_attachment_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.SnailmailLetters)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("snailmail_letter_company_id_fkey");

            entity.HasOne(d => d.Country).WithMany(p => p.SnailmailLetters)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("snailmail_letter_country_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.SnailmailLetterCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("snailmail_letter_create_uid_fkey");

            entity.HasOne(d => d.Message).WithMany(p => p.SnailmailLetters)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("snailmail_letter_message_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.SnailmailLetters)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("snailmail_letter_partner_id_fkey");

            entity.HasOne(d => d.ReportTemplateNavigation).WithMany(p => p.SnailmailLetters)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("snailmail_letter_report_template_fkey");

            entity.HasOne(d => d.StateNavigation).WithMany(p => p.SnailmailLetters)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("snailmail_letter_state_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.SnailmailLetterUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("snailmail_letter_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.SnailmailLetterWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("snailmail_letter_write_uid_fkey");
        });

        modelBuilder.Entity<SnailmailLetterFormatError>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("snailmail_letter_format_error_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.SnailmailLetterFormatErrorCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("snailmail_letter_format_error_create_uid_fkey");

            entity.HasOne(d => d.Message).WithMany(p => p.SnailmailLetterFormatErrors)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("snailmail_letter_format_error_message_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.SnailmailLetterFormatErrorWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("snailmail_letter_format_error_write_uid_fkey");
        });

        modelBuilder.Entity<SnailmailLetterMissingRequiredField>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("snailmail_letter_missing_required_fields_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Country).WithMany(p => p.SnailmailLetterMissingRequiredFields)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("snailmail_letter_missing_required_fields_country_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.SnailmailLetterMissingRequiredFieldCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("snailmail_letter_missing_required_fields_create_uid_fkey");

            entity.HasOne(d => d.Letter).WithMany(p => p.SnailmailLetterMissingRequiredFields)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("snailmail_letter_missing_required_fields_letter_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.SnailmailLetterMissingRequiredFields)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("snailmail_letter_missing_required_fields_partner_id_fkey");

            entity.HasOne(d => d.State).WithMany(p => p.SnailmailLetterMissingRequiredFields)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("snailmail_letter_missing_required_fields_state_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.SnailmailLetterMissingRequiredFieldWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("snailmail_letter_missing_required_fields_write_uid_fkey");
        });

        modelBuilder.Entity<SpreadsheetDashboard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("spreadsheet_dashboard_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.SpreadsheetDashboardCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("spreadsheet_dashboard_create_uid_fkey");

            entity.HasOne(d => d.DashboardGroup).WithMany(p => p.SpreadsheetDashboards)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("spreadsheet_dashboard_dashboard_group_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.SpreadsheetDashboardWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("spreadsheet_dashboard_write_uid_fkey");

            entity.HasMany(d => d.ResGroups).WithMany(p => p.SpreadsheetDashboards)
                .UsingEntity<Dictionary<string, object>>(
                    "ResGroupsSpreadsheetDashboardRel",
                    r => r.HasOne<ResGroup>().WithMany()
                        .HasForeignKey("ResGroupsId")
                        .HasConstraintName("res_groups_spreadsheet_dashboard_rel_res_groups_id_fkey"),
                    l => l.HasOne<SpreadsheetDashboard>().WithMany()
                        .HasForeignKey("SpreadsheetDashboardId")
                        .HasConstraintName("res_groups_spreadsheet_dashboard__spreadsheet_dashboard_id_fkey"),
                    j =>
                    {
                        j.HasKey("SpreadsheetDashboardId", "ResGroupsId").HasName("res_groups_spreadsheet_dashboard_rel_pkey");
                        j.ToTable("res_groups_spreadsheet_dashboard_rel");
                        j.HasIndex(new[] { "ResGroupsId", "SpreadsheetDashboardId" }, "res_groups_spreadsheet_dashbo_res_groups_id_spreadsheet_das_idx");
                    });
        });

        modelBuilder.Entity<SpreadsheetDashboardGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("spreadsheet_dashboard_group_pkey");

            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.SpreadsheetDashboardGroupCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("spreadsheet_dashboard_group_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.SpreadsheetDashboardGroupWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("spreadsheet_dashboard_group_write_uid_fkey");
        });

        modelBuilder.Entity<StockAssignSerial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_assign_serial_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockAssignSerialCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_assign_serial_create_uid_fkey");

            entity.HasOne(d => d.Move).WithMany(p => p.StockAssignSerials)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_assign_serial_move_id_fkey");

            entity.HasOne(d => d.Production).WithMany(p => p.StockAssignSerials)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_assign_serial_production_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockAssignSerialWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_assign_serial_write_uid_fkey");
        });

        modelBuilder.Entity<StockBackorderConfirmation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_backorder_confirmation_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockBackorderConfirmationCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_backorder_confirmation_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockBackorderConfirmationWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_backorder_confirmation_write_uid_fkey");

            entity.HasMany(d => d.StockPickings).WithMany(p => p.StockBackorderConfirmations)
                .UsingEntity<Dictionary<string, object>>(
                    "StockPickingBackorderRel",
                    r => r.HasOne<StockPicking>().WithMany()
                        .HasForeignKey("StockPickingId")
                        .HasConstraintName("stock_picking_backorder_rel_stock_picking_id_fkey"),
                    l => l.HasOne<StockBackorderConfirmation>().WithMany()
                        .HasForeignKey("StockBackorderConfirmationId")
                        .HasConstraintName("stock_picking_backorder_rel_stock_backorder_confirmation_i_fkey"),
                    j =>
                    {
                        j.HasKey("StockBackorderConfirmationId", "StockPickingId").HasName("stock_picking_backorder_rel_pkey");
                        j.ToTable("stock_picking_backorder_rel");
                        j.HasIndex(new[] { "StockPickingId", "StockBackorderConfirmationId" }, "stock_picking_backorder_rel_stock_picking_id_stock_backorde_idx");
                    });
        });

        modelBuilder.Entity<StockBackorderConfirmationLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_backorder_confirmation_line_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.BackorderConfirmation).WithMany(p => p.StockBackorderConfirmationLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_backorder_confirmation_lin_backorder_confirmation_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockBackorderConfirmationLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_backorder_confirmation_line_create_uid_fkey");

            entity.HasOne(d => d.Picking).WithMany(p => p.StockBackorderConfirmationLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_backorder_confirmation_line_picking_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockBackorderConfirmationLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_backorder_confirmation_line_write_uid_fkey");
        });

        modelBuilder.Entity<StockChangeProductQty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_change_product_qty_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockChangeProductQtyCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_change_product_qty_create_uid_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockChangeProductQties)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_change_product_qty_product_id_fkey");

            entity.HasOne(d => d.ProductTmpl).WithMany(p => p.StockChangeProductQties)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_change_product_qty_product_tmpl_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockChangeProductQtyWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_change_product_qty_write_uid_fkey");
        });

        modelBuilder.Entity<StockImmediateTransfer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_immediate_transfer_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockImmediateTransferCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_immediate_transfer_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockImmediateTransferWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_immediate_transfer_write_uid_fkey");

            entity.HasMany(d => d.StockPickings).WithMany(p => p.StockImmediateTransfers)
                .UsingEntity<Dictionary<string, object>>(
                    "StockPickingTransferRel",
                    r => r.HasOne<StockPicking>().WithMany()
                        .HasForeignKey("StockPickingId")
                        .HasConstraintName("stock_picking_transfer_rel_stock_picking_id_fkey"),
                    l => l.HasOne<StockImmediateTransfer>().WithMany()
                        .HasForeignKey("StockImmediateTransferId")
                        .HasConstraintName("stock_picking_transfer_rel_stock_immediate_transfer_id_fkey"),
                    j =>
                    {
                        j.HasKey("StockImmediateTransferId", "StockPickingId").HasName("stock_picking_transfer_rel_pkey");
                        j.ToTable("stock_picking_transfer_rel");
                        j.HasIndex(new[] { "StockPickingId", "StockImmediateTransferId" }, "stock_picking_transfer_rel_stock_picking_id_stock_immediate_idx");
                    });
        });

        modelBuilder.Entity<StockImmediateTransferLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_immediate_transfer_line_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockImmediateTransferLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_immediate_transfer_line_create_uid_fkey");

            entity.HasOne(d => d.ImmediateTransfer).WithMany(p => p.StockImmediateTransferLines)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_immediate_transfer_line_immediate_transfer_id_fkey");

            entity.HasOne(d => d.Picking).WithMany(p => p.StockImmediateTransferLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_immediate_transfer_line_picking_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockImmediateTransferLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_immediate_transfer_line_write_uid_fkey");
        });

        modelBuilder.Entity<StockInventoryAdjustmentName>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_inventory_adjustment_name_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockInventoryAdjustmentNameCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_inventory_adjustment_name_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockInventoryAdjustmentNameWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_inventory_adjustment_name_write_uid_fkey");

            entity.HasMany(d => d.StockQuants).WithMany(p => p.StockInventoryAdjustmentNames)
                .UsingEntity<Dictionary<string, object>>(
                    "StockInventoryAdjustmentNameStockQuantRel",
                    r => r.HasOne<StockQuant>().WithMany()
                        .HasForeignKey("StockQuantId")
                        .HasConstraintName("stock_inventory_adjustment_name_stock_quant_stock_quant_id_fkey"),
                    l => l.HasOne<StockInventoryAdjustmentName>().WithMany()
                        .HasForeignKey("StockInventoryAdjustmentNameId")
                        .HasConstraintName("stock_inventory_adjustment_na_stock_inventory_adjustment_n_fkey"),
                    j =>
                    {
                        j.HasKey("StockInventoryAdjustmentNameId", "StockQuantId").HasName("stock_inventory_adjustment_name_stock_quant_rel_pkey");
                        j.ToTable("stock_inventory_adjustment_name_stock_quant_rel");
                        j.HasIndex(new[] { "StockQuantId", "StockInventoryAdjustmentNameId" }, "stock_inventory_adjustment_na_stock_quant_id_stock_inventor_idx");
                    });
        });

        modelBuilder.Entity<StockInventoryConflict>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_inventory_conflict_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockInventoryConflictCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_inventory_conflict_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockInventoryConflictWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_inventory_conflict_write_uid_fkey");

            entity.HasMany(d => d.StockQuants).WithMany(p => p.StockInventoryConflicts)
                .UsingEntity<Dictionary<string, object>>(
                    "StockConflictQuantRel",
                    r => r.HasOne<StockQuant>().WithMany()
                        .HasForeignKey("StockQuantId")
                        .HasConstraintName("stock_conflict_quant_rel_stock_quant_id_fkey"),
                    l => l.HasOne<StockInventoryConflict>().WithMany()
                        .HasForeignKey("StockInventoryConflictId")
                        .HasConstraintName("stock_conflict_quant_rel_stock_inventory_conflict_id_fkey"),
                    j =>
                    {
                        j.HasKey("StockInventoryConflictId", "StockQuantId").HasName("stock_conflict_quant_rel_pkey");
                        j.ToTable("stock_conflict_quant_rel");
                        j.HasIndex(new[] { "StockQuantId", "StockInventoryConflictId" }, "stock_conflict_quant_rel_stock_quant_id_stock_inventory_con_idx");
                    });

            entity.HasMany(d => d.StockQuantsNavigation).WithMany(p => p.StockInventoryConflictsNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "StockInventoryConflictStockQuantRel",
                    r => r.HasOne<StockQuant>().WithMany()
                        .HasForeignKey("StockQuantId")
                        .HasConstraintName("stock_inventory_conflict_stock_quant_rel_stock_quant_id_fkey"),
                    l => l.HasOne<StockInventoryConflict>().WithMany()
                        .HasForeignKey("StockInventoryConflictId")
                        .HasConstraintName("stock_inventory_conflict_stock_stock_inventory_conflict_id_fkey"),
                    j =>
                    {
                        j.HasKey("StockInventoryConflictId", "StockQuantId").HasName("stock_inventory_conflict_stock_quant_rel_pkey");
                        j.ToTable("stock_inventory_conflict_stock_quant_rel");
                        j.HasIndex(new[] { "StockQuantId", "StockInventoryConflictId" }, "stock_inventory_conflict_stoc_stock_quant_id_stock_inventor_idx");
                    });
        });

        modelBuilder.Entity<StockInventoryWarning>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_inventory_warning_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockInventoryWarningCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_inventory_warning_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockInventoryWarningWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_inventory_warning_write_uid_fkey");

            entity.HasMany(d => d.StockQuants).WithMany(p => p.StockInventoryWarnings)
                .UsingEntity<Dictionary<string, object>>(
                    "StockInventoryWarningStockQuantRel",
                    r => r.HasOne<StockQuant>().WithMany()
                        .HasForeignKey("StockQuantId")
                        .HasConstraintName("stock_inventory_warning_stock_quant_rel_stock_quant_id_fkey"),
                    l => l.HasOne<StockInventoryWarning>().WithMany()
                        .HasForeignKey("StockInventoryWarningId")
                        .HasConstraintName("stock_inventory_warning_stock_q_stock_inventory_warning_id_fkey"),
                    j =>
                    {
                        j.HasKey("StockInventoryWarningId", "StockQuantId").HasName("stock_inventory_warning_stock_quant_rel_pkey");
                        j.ToTable("stock_inventory_warning_stock_quant_rel");
                        j.HasIndex(new[] { "StockQuantId", "StockInventoryWarningId" }, "stock_inventory_warning_stock_stock_quant_id_stock_inventor_idx");
                    });
        });

        modelBuilder.Entity<StockLocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_location_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.StockLocations)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_location_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockLocationCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_location_create_uid_fkey");

            entity.HasOne(d => d.Location).WithMany(p => p.InverseLocation)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_location_location_id_fkey");

            entity.HasOne(d => d.RemovalStrategy).WithMany(p => p.StockLocations)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_location_removal_strategy_id_fkey");

            entity.HasOne(d => d.StorageCategory).WithMany(p => p.StockLocations)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_location_storage_category_id_fkey");

            entity.HasOne(d => d.ValuationInAccount).WithMany(p => p.StockLocationValuationInAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_location_valuation_in_account_id_fkey");

            entity.HasOne(d => d.ValuationOutAccount).WithMany(p => p.StockLocationValuationOutAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_location_valuation_out_account_id_fkey");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.StockLocations)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_location_warehouse_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockLocationWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_location_write_uid_fkey");
        });

        modelBuilder.Entity<StockLot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_lot_pkey");

            entity.HasIndex(e => e.Name, "stock_lot_name_index")
                .HasMethod("gin")
                .HasOperators(new[] { "gin_trgm_ops" });

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.StockLots)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_lot_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockLotCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_lot_create_uid_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.StockLots)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_lot_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockLots)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_lot_product_id_fkey");

            entity.HasOne(d => d.ProductUom).WithMany(p => p.StockLots)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_lot_product_uom_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockLotWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_lot_write_uid_fkey");
        });

        modelBuilder.Entity<StockMove>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_move_pkey");

            entity.HasIndex(e => e.CreatedPurchaseLineId, "stock_move_created_purchase_line_id_index").HasFilter("(created_purchase_line_id IS NOT NULL)");

            entity.HasIndex(e => e.ProductionId, "stock_move_production_id_index").HasFilter("(production_id IS NOT NULL)");

            entity.HasIndex(e => e.PurchaseLineId, "stock_move_purchase_line_id_index").HasFilter("(purchase_line_id IS NOT NULL)");

            entity.HasIndex(e => e.RawMaterialProductionId, "stock_move_raw_material_production_id_index").HasFilter("(raw_material_production_id IS NOT NULL)");

            entity.HasIndex(e => e.SaleLineId, "stock_move_sale_line_id_index").HasFilter("(sale_line_id IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.AnalyticAccountLine).WithMany(p => p.StockMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_analytic_account_line_id_fkey");

            entity.HasOne(d => d.BomLine).WithMany(p => p.StockMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_bom_line_id_fkey");

            entity.HasOne(d => d.Byproduct).WithMany(p => p.StockMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_byproduct_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.StockMoves)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_move_company_id_fkey");

            entity.HasOne(d => d.ConsumeUnbuild).WithMany(p => p.StockMoveConsumeUnbuilds)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_consume_unbuild_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockMoveCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_create_uid_fkey");

            entity.HasOne(d => d.CreatedProduction).WithMany(p => p.StockMoveCreatedProductions)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_created_production_id_fkey");

            entity.HasOne(d => d.CreatedPurchaseLine).WithMany(p => p.StockMoveCreatedPurchaseLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_created_purchase_line_id_fkey");

            entity.HasOne(d => d.Group).WithMany(p => p.StockMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_group_id_fkey");

            entity.HasOne(d => d.LocationDest).WithMany(p => p.StockMoveLocationDests)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_move_location_dest_id_fkey");

            entity.HasOne(d => d.Location).WithMany(p => p.StockMoveLocations)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_move_location_id_fkey");

            entity.HasOne(d => d.Operation).WithMany(p => p.StockMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_operation_id_fkey");

            entity.HasOne(d => d.OrderFinishedLot).WithMany(p => p.StockMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_order_finished_lot_id_fkey");

            entity.HasOne(d => d.Orderpoint).WithMany(p => p.StockMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_orderpoint_id_fkey");

            entity.HasOne(d => d.OriginReturnedMove).WithMany(p => p.InverseOriginReturnedMove)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_origin_returned_move_id_fkey");

            entity.HasOne(d => d.PackageLevel).WithMany(p => p.StockMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_package_level_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.StockMovePartners)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_partner_id_fkey");

            entity.HasOne(d => d.Picking).WithMany(p => p.StockMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_picking_id_fkey");

            entity.HasOne(d => d.PickingType).WithMany(p => p.StockMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_picking_type_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockMoves)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_move_product_id_fkey");

            entity.HasOne(d => d.ProductPackaging).WithMany(p => p.StockMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_product_packaging_id_fkey");

            entity.HasOne(d => d.ProductUomNavigation).WithMany(p => p.StockMoves)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_move_product_uom_fkey");

            entity.HasOne(d => d.Production).WithMany(p => p.StockMoveProductions)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_production_id_fkey");

            entity.HasOne(d => d.PurchaseLine).WithMany(p => p.StockMovePurchaseLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_purchase_line_id_fkey");

            entity.HasOne(d => d.RawMaterialProduction).WithMany(p => p.StockMoveRawMaterialProductions)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_raw_material_production_id_fkey");

            entity.HasOne(d => d.Repair).WithMany(p => p.StockMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_repair_id_fkey");

            entity.HasOne(d => d.RestrictPartner).WithMany(p => p.StockMoveRestrictPartners)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_restrict_partner_id_fkey");

            entity.HasOne(d => d.Rule).WithMany(p => p.StockMoves)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_move_rule_id_fkey");

            entity.HasOne(d => d.SaleLine).WithMany(p => p.StockMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_sale_line_id_fkey");

            entity.HasOne(d => d.Unbuild).WithMany(p => p.StockMoveUnbuilds)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_unbuild_id_fkey");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.StockMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_warehouse_id_fkey");

            entity.HasOne(d => d.Workorder).WithMany(p => p.StockMoves)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_workorder_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockMoveWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_write_uid_fkey");

            entity.HasMany(d => d.MoveDests).WithMany(p => p.MoveOrigs)
                .UsingEntity<Dictionary<string, object>>(
                    "StockMoveMoveRel",
                    r => r.HasOne<StockMove>().WithMany()
                        .HasForeignKey("MoveDestId")
                        .HasConstraintName("stock_move_move_rel_move_dest_id_fkey"),
                    l => l.HasOne<StockMove>().WithMany()
                        .HasForeignKey("MoveOrigId")
                        .HasConstraintName("stock_move_move_rel_move_orig_id_fkey"),
                    j =>
                    {
                        j.HasKey("MoveOrigId", "MoveDestId").HasName("stock_move_move_rel_pkey");
                        j.ToTable("stock_move_move_rel");
                        j.HasIndex(new[] { "MoveDestId", "MoveOrigId" }, "stock_move_move_rel_move_dest_id_move_orig_id_idx");
                    });

            entity.HasMany(d => d.MoveOrigs).WithMany(p => p.MoveDests)
                .UsingEntity<Dictionary<string, object>>(
                    "StockMoveMoveRel",
                    r => r.HasOne<StockMove>().WithMany()
                        .HasForeignKey("MoveOrigId")
                        .HasConstraintName("stock_move_move_rel_move_orig_id_fkey"),
                    l => l.HasOne<StockMove>().WithMany()
                        .HasForeignKey("MoveDestId")
                        .HasConstraintName("stock_move_move_rel_move_dest_id_fkey"),
                    j =>
                    {
                        j.HasKey("MoveOrigId", "MoveDestId").HasName("stock_move_move_rel_pkey");
                        j.ToTable("stock_move_move_rel");
                        j.HasIndex(new[] { "MoveDestId", "MoveOrigId" }, "stock_move_move_rel_move_dest_id_move_orig_id_idx");
                    });

            entity.HasMany(d => d.Routes).WithMany(p => p.Moves)
                .UsingEntity<Dictionary<string, object>>(
                    "StockRouteMove",
                    r => r.HasOne<StockRoute>().WithMany()
                        .HasForeignKey("RouteId")
                        .HasConstraintName("stock_route_move_route_id_fkey"),
                    l => l.HasOne<StockMove>().WithMany()
                        .HasForeignKey("MoveId")
                        .HasConstraintName("stock_route_move_move_id_fkey"),
                    j =>
                    {
                        j.HasKey("MoveId", "RouteId").HasName("stock_route_move_pkey");
                        j.ToTable("stock_route_move");
                        j.HasIndex(new[] { "RouteId", "MoveId" }, "stock_route_move_route_id_move_id_idx");
                    });
        });

        modelBuilder.Entity<StockMoveLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_move_line_pkey");

            entity.HasIndex(e => new { e.Id, e.CompanyId, e.ProductId, e.LotId, e.LocationId, e.OwnerId, e.PackageId }, "stock_move_line_free_reservation_index").HasFilter("(((state IS NULL) OR (state <> ALL (ARRAY[('cancel'::character varying)::text, ('done'::character varying)::text]))) AND (reserved_qty > (0)::numeric))");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.StockMoveLines)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_move_line_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockMoveLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_line_create_uid_fkey");

            entity.HasOne(d => d.LocationDest).WithMany(p => p.StockMoveLineLocationDests)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_move_line_location_dest_id_fkey");

            entity.HasOne(d => d.Location).WithMany(p => p.StockMoveLineLocations)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_move_line_location_id_fkey");

            entity.HasOne(d => d.Lot).WithMany(p => p.StockMoveLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_line_lot_id_fkey");

            entity.HasOne(d => d.Move).WithMany(p => p.StockMoveLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_line_move_id_fkey");

            entity.HasOne(d => d.Owner).WithMany(p => p.StockMoveLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_line_owner_id_fkey");

            entity.HasOne(d => d.Package).WithMany(p => p.StockMoveLinePackages)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_move_line_package_id_fkey");

            entity.HasOne(d => d.PackageLevel).WithMany(p => p.StockMoveLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_line_package_level_id_fkey");

            entity.HasOne(d => d.Picking).WithMany(p => p.StockMoveLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_line_picking_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockMoveLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_move_line_product_id_fkey");

            entity.HasOne(d => d.ProductUom).WithMany(p => p.StockMoveLines)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_move_line_product_uom_id_fkey");

            entity.HasOne(d => d.Production).WithMany(p => p.StockMoveLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_line_production_id_fkey");

            entity.HasOne(d => d.ResultPackage).WithMany(p => p.StockMoveLineResultPackages)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_move_line_result_package_id_fkey");

            entity.HasOne(d => d.Workorder).WithMany(p => p.StockMoveLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_line_workorder_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockMoveLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_line_write_uid_fkey");

            entity.HasMany(d => d.ConsumeLines).WithMany(p => p.ProduceLines)
                .UsingEntity<Dictionary<string, object>>(
                    "StockMoveLineConsumeRel",
                    r => r.HasOne<StockMoveLine>().WithMany()
                        .HasForeignKey("ConsumeLineId")
                        .HasConstraintName("stock_move_line_consume_rel_consume_line_id_fkey"),
                    l => l.HasOne<StockMoveLine>().WithMany()
                        .HasForeignKey("ProduceLineId")
                        .HasConstraintName("stock_move_line_consume_rel_produce_line_id_fkey"),
                    j =>
                    {
                        j.HasKey("ConsumeLineId", "ProduceLineId").HasName("stock_move_line_consume_rel_pkey");
                        j.ToTable("stock_move_line_consume_rel");
                        j.HasIndex(new[] { "ProduceLineId", "ConsumeLineId" }, "stock_move_line_consume_rel_produce_line_id_consume_line_id_idx");
                    });

            entity.HasMany(d => d.ProduceLines).WithMany(p => p.ConsumeLines)
                .UsingEntity<Dictionary<string, object>>(
                    "StockMoveLineConsumeRel",
                    r => r.HasOne<StockMoveLine>().WithMany()
                        .HasForeignKey("ProduceLineId")
                        .HasConstraintName("stock_move_line_consume_rel_produce_line_id_fkey"),
                    l => l.HasOne<StockMoveLine>().WithMany()
                        .HasForeignKey("ConsumeLineId")
                        .HasConstraintName("stock_move_line_consume_rel_consume_line_id_fkey"),
                    j =>
                    {
                        j.HasKey("ConsumeLineId", "ProduceLineId").HasName("stock_move_line_consume_rel_pkey");
                        j.ToTable("stock_move_line_consume_rel");
                        j.HasIndex(new[] { "ProduceLineId", "ConsumeLineId" }, "stock_move_line_consume_rel_produce_line_id_consume_line_id_idx");
                    });
        });

        modelBuilder.Entity<StockOrderpointSnooze>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_orderpoint_snooze_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockOrderpointSnoozeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_orderpoint_snooze_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockOrderpointSnoozeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_orderpoint_snooze_write_uid_fkey");

            entity.HasMany(d => d.StockWarehouseOrderpoints).WithMany(p => p.StockOrderpointSnoozes)
                .UsingEntity<Dictionary<string, object>>(
                    "StockOrderpointSnoozeStockWarehouseOrderpointRel",
                    r => r.HasOne<StockWarehouseOrderpoint>().WithMany()
                        .HasForeignKey("StockWarehouseOrderpointId")
                        .HasConstraintName("stock_orderpoint_snooze_stock_stock_warehouse_orderpoint_i_fkey"),
                    l => l.HasOne<StockOrderpointSnooze>().WithMany()
                        .HasForeignKey("StockOrderpointSnoozeId")
                        .HasConstraintName("stock_orderpoint_snooze_stock_w_stock_orderpoint_snooze_id_fkey"),
                    j =>
                    {
                        j.HasKey("StockOrderpointSnoozeId", "StockWarehouseOrderpointId").HasName("stock_orderpoint_snooze_stock_warehouse_orderpoint_rel_pkey");
                        j.ToTable("stock_orderpoint_snooze_stock_warehouse_orderpoint_rel");
                        j.HasIndex(new[] { "StockWarehouseOrderpointId", "StockOrderpointSnoozeId" }, "stock_orderpoint_snooze_stock_stock_warehouse_orderpoint_id_idx");
                    });
        });

        modelBuilder.Entity<StockPackageDestination>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_package_destination_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockPackageDestinationCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_package_destination_create_uid_fkey");

            entity.HasOne(d => d.LocationDest).WithMany(p => p.StockPackageDestinations)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_package_destination_location_dest_id_fkey");

            entity.HasOne(d => d.Picking).WithMany(p => p.StockPackageDestinations)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_package_destination_picking_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockPackageDestinationWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_package_destination_write_uid_fkey");
        });

        modelBuilder.Entity<StockPackageLevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_package_level_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.StockPackageLevels)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_package_level_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockPackageLevelCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_package_level_create_uid_fkey");

            entity.HasOne(d => d.LocationDest).WithMany(p => p.StockPackageLevels)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_package_level_location_dest_id_fkey");

            entity.HasOne(d => d.Package).WithMany(p => p.StockPackageLevels)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_package_level_package_id_fkey");

            entity.HasOne(d => d.Picking).WithMany(p => p.StockPackageLevels)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_package_level_picking_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockPackageLevelWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_package_level_write_uid_fkey");
        });

        modelBuilder.Entity<StockPackageType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_package_type_pkey");

            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Company).WithMany(p => p.StockPackageTypes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_package_type_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockPackageTypeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_package_type_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockPackageTypeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_package_type_write_uid_fkey");
        });

        modelBuilder.Entity<StockPicking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_picking_pkey");

            entity.HasIndex(e => e.BackorderId, "stock_picking_backorder_id_index").HasFilter("(backorder_id IS NOT NULL)");

            entity.HasIndex(e => e.Name, "stock_picking_name_index")
                .HasMethod("gin")
                .HasOperators(new[] { "gin_trgm_ops" });

            entity.HasIndex(e => e.Origin, "stock_picking_origin_index")
                .HasMethod("gin")
                .HasOperators(new[] { "gin_trgm_ops" });

            entity.HasIndex(e => e.SaleId, "stock_picking_sale_id_index").HasFilter("(sale_id IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Backorder).WithMany(p => p.InverseBackorder)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_backorder_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.StockPickings)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockPickingCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_create_uid_fkey");

            entity.HasOne(d => d.Group).WithMany(p => p.StockPickings)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_group_id_fkey");

            entity.HasOne(d => d.LocationDest).WithMany(p => p.StockPickingLocationDests)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_picking_location_dest_id_fkey");

            entity.HasOne(d => d.Location).WithMany(p => p.StockPickingLocations)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_picking_location_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.StockPickings)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Owner).WithMany(p => p.StockPickingOwners)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_owner_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.StockPickingPartners)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_partner_id_fkey");

            entity.HasOne(d => d.PickingType).WithMany(p => p.StockPickings)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_picking_picking_type_id_fkey");

            entity.HasOne(d => d.PosOrder).WithMany(p => p.StockPickings)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_pos_order_id_fkey");

            entity.HasOne(d => d.PosSession).WithMany(p => p.StockPickings)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_pos_session_id_fkey");

            entity.HasOne(d => d.Sale).WithMany(p => p.StockPickings)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_sale_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.StockPickingUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_user_id_fkey");

            entity.HasOne(d => d.Website).WithMany(p => p.StockPickings)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_website_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockPickingWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_write_uid_fkey");
        });

        modelBuilder.Entity<StockPickingType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_picking_type_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Company).WithMany(p => p.StockPickingTypes)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_picking_type_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockPickingTypeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_type_create_uid_fkey");

            entity.HasOne(d => d.DefaultLocationDest).WithMany(p => p.StockPickingTypeDefaultLocationDests)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_type_default_location_dest_id_fkey");

            entity.HasOne(d => d.DefaultLocationSrc).WithMany(p => p.StockPickingTypeDefaultLocationSrcs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_type_default_location_src_id_fkey");

            entity.HasOne(d => d.ReturnPickingType).WithMany(p => p.InverseReturnPickingType)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_type_return_picking_type_id_fkey");

            entity.HasOne(d => d.SequenceNavigation).WithMany(p => p.StockPickingTypes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_type_sequence_id_fkey");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.StockPickingTypes)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_picking_type_warehouse_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockPickingTypeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_type_write_uid_fkey");
        });

        modelBuilder.Entity<StockPutawayRule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_putaway_rule_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Category).WithMany(p => p.StockPutawayRules)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_putaway_rule_category_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.StockPutawayRules)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_putaway_rule_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockPutawayRuleCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_putaway_rule_create_uid_fkey");

            entity.HasOne(d => d.LocationIn).WithMany(p => p.StockPutawayRuleLocationIns)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_putaway_rule_location_in_id_fkey");

            entity.HasOne(d => d.LocationOut).WithMany(p => p.StockPutawayRuleLocationOuts)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_putaway_rule_location_out_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockPutawayRules)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_putaway_rule_product_id_fkey");

            entity.HasOne(d => d.StorageCategory).WithMany(p => p.StockPutawayRules)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_putaway_rule_storage_category_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockPutawayRuleWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_putaway_rule_write_uid_fkey");

            entity.HasMany(d => d.StockPackageTypes).WithMany(p => p.StockPutawayRules)
                .UsingEntity<Dictionary<string, object>>(
                    "StockPackageTypeStockPutawayRuleRel",
                    r => r.HasOne<StockPackageType>().WithMany()
                        .HasForeignKey("StockPackageTypeId")
                        .HasConstraintName("stock_package_type_stock_putaway_rul_stock_package_type_id_fkey"),
                    l => l.HasOne<StockPutawayRule>().WithMany()
                        .HasForeignKey("StockPutawayRuleId")
                        .HasConstraintName("stock_package_type_stock_putaway_rul_stock_putaway_rule_id_fkey"),
                    j =>
                    {
                        j.HasKey("StockPutawayRuleId", "StockPackageTypeId").HasName("stock_package_type_stock_putaway_rule_rel_pkey");
                        j.ToTable("stock_package_type_stock_putaway_rule_rel");
                        j.HasIndex(new[] { "StockPackageTypeId", "StockPutawayRuleId" }, "stock_package_type_stock_puta_stock_package_type_id_stock_p_idx");
                    });
        });

        modelBuilder.Entity<StockQuant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_quant_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.StockQuants)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quant_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockQuantCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quant_create_uid_fkey");

            entity.HasOne(d => d.Location).WithMany(p => p.StockQuants)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_quant_location_id_fkey");

            entity.HasOne(d => d.Lot).WithMany(p => p.StockQuants)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_quant_lot_id_fkey");

            entity.HasOne(d => d.Owner).WithMany(p => p.StockQuants)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quant_owner_id_fkey");

            entity.HasOne(d => d.Package).WithMany(p => p.StockQuants)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_quant_package_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockQuants)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_quant_product_id_fkey");

            entity.HasOne(d => d.StorageCategory).WithMany(p => p.StockQuants)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quant_storage_category_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.StockQuantUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quant_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockQuantWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quant_write_uid_fkey");
        });

        modelBuilder.Entity<StockQuantPackage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_quant_package_pkey");

            entity.HasIndex(e => e.Name, "stock_quant_package_name_index")
                .HasMethod("gin")
                .HasOperators(new[] { "gin_trgm_ops" });

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.StockQuantPackages)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quant_package_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockQuantPackageCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quant_package_create_uid_fkey");

            entity.HasOne(d => d.Location).WithMany(p => p.StockQuantPackages)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quant_package_location_id_fkey");

            entity.HasOne(d => d.PackageType).WithMany(p => p.StockQuantPackages)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quant_package_package_type_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockQuantPackageWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quant_package_write_uid_fkey");
        });

        modelBuilder.Entity<StockQuantityHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_quantity_history_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockQuantityHistoryCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quantity_history_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockQuantityHistoryWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quantity_history_write_uid_fkey");
        });

        modelBuilder.Entity<StockReplenishmentInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_replenishment_info_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockReplenishmentInfoCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_replenishment_info_create_uid_fkey");

            entity.HasOne(d => d.Orderpoint).WithMany(p => p.StockReplenishmentInfos)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_replenishment_info_orderpoint_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockReplenishmentInfoWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_replenishment_info_write_uid_fkey");

            entity.HasMany(d => d.ProductSupplierinfos).WithMany(p => p.StockReplenishmentInfos)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductSupplierinfoStockReplenishmentInfoRel",
                    r => r.HasOne<ProductSupplierinfo>().WithMany()
                        .HasForeignKey("ProductSupplierinfoId")
                        .HasConstraintName("product_supplierinfo_stock_repleni_product_supplierinfo_id_fkey"),
                    l => l.HasOne<StockReplenishmentInfo>().WithMany()
                        .HasForeignKey("StockReplenishmentInfoId")
                        .HasConstraintName("product_supplierinfo_stock_rep_stock_replenishment_info_id_fkey"),
                    j =>
                    {
                        j.HasKey("StockReplenishmentInfoId", "ProductSupplierinfoId").HasName("product_supplierinfo_stock_replenishment_info_rel_pkey");
                        j.ToTable("product_supplierinfo_stock_replenishment_info_rel");
                        j.HasIndex(new[] { "ProductSupplierinfoId", "StockReplenishmentInfoId" }, "product_supplierinfo_stock_re_product_supplierinfo_id_stock_idx");
                    });
        });

        modelBuilder.Entity<StockReplenishmentOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_replenishment_option_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockReplenishmentOptionCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_replenishment_option_create_uid_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockReplenishmentOptions)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_replenishment_option_product_id_fkey");

            entity.HasOne(d => d.ReplenishmentInfo).WithMany(p => p.StockReplenishmentOptions)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_replenishment_option_replenishment_info_id_fkey");

            entity.HasOne(d => d.Route).WithMany(p => p.StockReplenishmentOptions)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_replenishment_option_route_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockReplenishmentOptionWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_replenishment_option_write_uid_fkey");
        });

        modelBuilder.Entity<StockRequestCount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_request_count_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockRequestCountCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_request_count_create_uid_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.StockRequestCountUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_request_count_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockRequestCountWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_request_count_write_uid_fkey");

            entity.HasMany(d => d.StockQuants).WithMany(p => p.StockRequestCounts)
                .UsingEntity<Dictionary<string, object>>(
                    "StockQuantStockRequestCountRel",
                    r => r.HasOne<StockQuant>().WithMany()
                        .HasForeignKey("StockQuantId")
                        .HasConstraintName("stock_quant_stock_request_count_rel_stock_quant_id_fkey"),
                    l => l.HasOne<StockRequestCount>().WithMany()
                        .HasForeignKey("StockRequestCountId")
                        .HasConstraintName("stock_quant_stock_request_count_rel_stock_request_count_id_fkey"),
                    j =>
                    {
                        j.HasKey("StockRequestCountId", "StockQuantId").HasName("stock_quant_stock_request_count_rel_pkey");
                        j.ToTable("stock_quant_stock_request_count_rel");
                        j.HasIndex(new[] { "StockQuantId", "StockRequestCountId" }, "stock_quant_stock_request_cou_stock_quant_id_stock_request__idx");
                    });
        });

        modelBuilder.Entity<StockReturnPicking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_return_picking_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockReturnPickingCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_return_picking_create_uid_fkey");

            entity.HasOne(d => d.Location).WithMany(p => p.StockReturnPickingLocations)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_return_picking_location_id_fkey");

            entity.HasOne(d => d.OriginalLocation).WithMany(p => p.StockReturnPickingOriginalLocations)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_return_picking_original_location_id_fkey");

            entity.HasOne(d => d.ParentLocation).WithMany(p => p.StockReturnPickingParentLocations)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_return_picking_parent_location_id_fkey");

            entity.HasOne(d => d.Picking).WithMany(p => p.StockReturnPickings)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_return_picking_picking_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockReturnPickingWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_return_picking_write_uid_fkey");
        });

        modelBuilder.Entity<StockReturnPickingLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_return_picking_line_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockReturnPickingLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_return_picking_line_create_uid_fkey");

            entity.HasOne(d => d.Move).WithMany(p => p.StockReturnPickingLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_return_picking_line_move_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockReturnPickingLines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_return_picking_line_product_id_fkey");

            entity.HasOne(d => d.Wizard).WithMany(p => p.StockReturnPickingLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_return_picking_line_wizard_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockReturnPickingLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_return_picking_line_write_uid_fkey");
        });

        modelBuilder.Entity<StockRoute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_route_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Company).WithMany(p => p.StockRoutes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_route_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockRouteCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_route_create_uid_fkey");

            entity.HasOne(d => d.SuppliedWh).WithMany(p => p.StockRouteSuppliedWhs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_route_supplied_wh_id_fkey");

            entity.HasOne(d => d.SupplierWh).WithMany(p => p.StockRouteSupplierWhs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_route_supplier_wh_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockRouteWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_route_write_uid_fkey");

            entity.HasMany(d => d.Categs).WithMany(p => p.Routes)
                .UsingEntity<Dictionary<string, object>>(
                    "StockRouteCateg",
                    r => r.HasOne<ProductCategory>().WithMany()
                        .HasForeignKey("CategId")
                        .HasConstraintName("stock_route_categ_categ_id_fkey"),
                    l => l.HasOne<StockRoute>().WithMany()
                        .HasForeignKey("RouteId")
                        .HasConstraintName("stock_route_categ_route_id_fkey"),
                    j =>
                    {
                        j.HasKey("RouteId", "CategId").HasName("stock_route_categ_pkey");
                        j.ToTable("stock_route_categ");
                        j.HasIndex(new[] { "CategId", "RouteId" }, "stock_route_categ_categ_id_route_id_idx");
                    });

            entity.HasMany(d => d.Packagings).WithMany(p => p.Routes)
                .UsingEntity<Dictionary<string, object>>(
                    "StockRoutePackaging",
                    r => r.HasOne<ProductPackaging>().WithMany()
                        .HasForeignKey("PackagingId")
                        .HasConstraintName("stock_route_packaging_packaging_id_fkey"),
                    l => l.HasOne<StockRoute>().WithMany()
                        .HasForeignKey("RouteId")
                        .HasConstraintName("stock_route_packaging_route_id_fkey"),
                    j =>
                    {
                        j.HasKey("RouteId", "PackagingId").HasName("stock_route_packaging_pkey");
                        j.ToTable("stock_route_packaging");
                        j.HasIndex(new[] { "PackagingId", "RouteId" }, "stock_route_packaging_packaging_id_route_id_idx");
                    });

            entity.HasMany(d => d.Products).WithMany(p => p.Routes)
                .UsingEntity<Dictionary<string, object>>(
                    "StockRouteProduct",
                    r => r.HasOne<ProductTemplate>().WithMany()
                        .HasForeignKey("ProductId")
                        .HasConstraintName("stock_route_product_product_id_fkey"),
                    l => l.HasOne<StockRoute>().WithMany()
                        .HasForeignKey("RouteId")
                        .HasConstraintName("stock_route_product_route_id_fkey"),
                    j =>
                    {
                        j.HasKey("RouteId", "ProductId").HasName("stock_route_product_pkey");
                        j.ToTable("stock_route_product");
                        j.HasIndex(new[] { "ProductId", "RouteId" }, "stock_route_product_product_id_route_id_idx");
                    });

            entity.HasMany(d => d.Warehouses).WithMany(p => p.Routes)
                .UsingEntity<Dictionary<string, object>>(
                    "StockRouteWarehouse",
                    r => r.HasOne<StockWarehouse>().WithMany()
                        .HasForeignKey("WarehouseId")
                        .HasConstraintName("stock_route_warehouse_warehouse_id_fkey"),
                    l => l.HasOne<StockRoute>().WithMany()
                        .HasForeignKey("RouteId")
                        .HasConstraintName("stock_route_warehouse_route_id_fkey"),
                    j =>
                    {
                        j.HasKey("RouteId", "WarehouseId").HasName("stock_route_warehouse_pkey");
                        j.ToTable("stock_route_warehouse");
                        j.HasIndex(new[] { "WarehouseId", "RouteId" }, "stock_route_warehouse_warehouse_id_route_id_idx");
                    });
        });

        modelBuilder.Entity<StockRule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_rule_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Company).WithMany(p => p.StockRules)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_rule_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockRuleCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_rule_create_uid_fkey");

            entity.HasOne(d => d.Group).WithMany(p => p.StockRules)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_rule_group_id_fkey");

            entity.HasOne(d => d.LocationDest).WithMany(p => p.StockRuleLocationDests)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_rule_location_dest_id_fkey");

            entity.HasOne(d => d.LocationSrc).WithMany(p => p.StockRuleLocationSrcs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_rule_location_src_id_fkey");

            entity.HasOne(d => d.PartnerAddress).WithMany(p => p.StockRules)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_rule_partner_address_id_fkey");

            entity.HasOne(d => d.PickingType).WithMany(p => p.StockRules)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_rule_picking_type_id_fkey");

            entity.HasOne(d => d.PropagateWarehouse).WithMany(p => p.StockRulePropagateWarehouses)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_rule_propagate_warehouse_id_fkey");

            entity.HasOne(d => d.Route).WithMany(p => p.StockRules)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_rule_route_id_fkey");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.StockRuleWarehouses)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_rule_warehouse_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockRuleWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_rule_write_uid_fkey");
        });

        modelBuilder.Entity<StockRulesReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_rules_report_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockRulesReportCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_rules_report_create_uid_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockRulesReports)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_rules_report_product_id_fkey");

            entity.HasOne(d => d.ProductTmpl).WithMany(p => p.StockRulesReports)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_rules_report_product_tmpl_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockRulesReportWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_rules_report_write_uid_fkey");

            entity.HasMany(d => d.StockRoutes).WithMany(p => p.StockRulesReports)
                .UsingEntity<Dictionary<string, object>>(
                    "StockRouteStockRulesReportRel",
                    r => r.HasOne<StockRoute>().WithMany()
                        .HasForeignKey("StockRouteId")
                        .HasConstraintName("stock_route_stock_rules_report_rel_stock_route_id_fkey"),
                    l => l.HasOne<StockRulesReport>().WithMany()
                        .HasForeignKey("StockRulesReportId")
                        .HasConstraintName("stock_route_stock_rules_report_rel_stock_rules_report_id_fkey"),
                    j =>
                    {
                        j.HasKey("StockRulesReportId", "StockRouteId").HasName("stock_route_stock_rules_report_rel_pkey");
                        j.ToTable("stock_route_stock_rules_report_rel");
                        j.HasIndex(new[] { "StockRouteId", "StockRulesReportId" }, "stock_route_stock_rules_repor_stock_route_id_stock_rules_re_idx");
                    });

            entity.HasMany(d => d.StockWarehouses).WithMany(p => p.StockRulesReports)
                .UsingEntity<Dictionary<string, object>>(
                    "StockRulesReportStockWarehouseRel",
                    r => r.HasOne<StockWarehouse>().WithMany()
                        .HasForeignKey("StockWarehouseId")
                        .HasConstraintName("stock_rules_report_stock_warehouse_rel_stock_warehouse_id_fkey"),
                    l => l.HasOne<StockRulesReport>().WithMany()
                        .HasForeignKey("StockRulesReportId")
                        .HasConstraintName("stock_rules_report_stock_warehouse_r_stock_rules_report_id_fkey"),
                    j =>
                    {
                        j.HasKey("StockRulesReportId", "StockWarehouseId").HasName("stock_rules_report_stock_warehouse_rel_pkey");
                        j.ToTable("stock_rules_report_stock_warehouse_rel");
                        j.HasIndex(new[] { "StockWarehouseId", "StockRulesReportId" }, "stock_rules_report_stock_ware_stock_warehouse_id_stock_rule_idx");
                    });
        });

        modelBuilder.Entity<StockSchedulerCompute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_scheduler_compute_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockSchedulerComputeCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_scheduler_compute_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockSchedulerComputeWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_scheduler_compute_write_uid_fkey");
        });

        modelBuilder.Entity<StockScrap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_scrap_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.StockScraps)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_scrap_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockScrapCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_scrap_create_uid_fkey");

            entity.HasOne(d => d.Location).WithMany(p => p.StockScrapLocations)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_scrap_location_id_fkey");

            entity.HasOne(d => d.Lot).WithMany(p => p.StockScraps)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_scrap_lot_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.StockScraps)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_scrap_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Move).WithMany(p => p.StockScraps)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_scrap_move_id_fkey");

            entity.HasOne(d => d.Owner).WithMany(p => p.StockScraps)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_scrap_owner_id_fkey");

            entity.HasOne(d => d.Package).WithMany(p => p.StockScraps)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_scrap_package_id_fkey");

            entity.HasOne(d => d.Picking).WithMany(p => p.StockScraps)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_scrap_picking_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockScraps)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_scrap_product_id_fkey");

            entity.HasOne(d => d.ProductUom).WithMany(p => p.StockScraps)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_scrap_product_uom_id_fkey");

            entity.HasOne(d => d.Production).WithMany(p => p.StockScraps)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_scrap_production_id_fkey");

            entity.HasOne(d => d.ScrapLocation).WithMany(p => p.StockScrapScrapLocations)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_scrap_scrap_location_id_fkey");

            entity.HasOne(d => d.Workorder).WithMany(p => p.StockScraps)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_scrap_workorder_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockScrapWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_scrap_write_uid_fkey");
        });

        modelBuilder.Entity<StockStorageCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_storage_category_pkey");

            entity.HasOne(d => d.Company).WithMany(p => p.StockStorageCategories)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_storage_category_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockStorageCategoryCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_storage_category_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockStorageCategoryWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_storage_category_write_uid_fkey");
        });

        modelBuilder.Entity<StockStorageCategoryCapacity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_storage_category_capacity_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockStorageCategoryCapacityCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_storage_category_capacity_create_uid_fkey");

            entity.HasOne(d => d.PackageType).WithMany(p => p.StockStorageCategoryCapacities)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_storage_category_capacity_package_type_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockStorageCategoryCapacities)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_storage_category_capacity_product_id_fkey");

            entity.HasOne(d => d.StorageCategory).WithMany(p => p.StockStorageCategoryCapacities)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_storage_category_capacity_storage_category_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockStorageCategoryCapacityWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_storage_category_capacity_write_uid_fkey");
        });

        modelBuilder.Entity<StockTraceabilityReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_traceability_report_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockTraceabilityReportCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_traceability_report_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockTraceabilityReportWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_traceability_report_write_uid_fkey");
        });

        modelBuilder.Entity<StockTrackConfirmation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_track_confirmation_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockTrackConfirmationCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_track_confirmation_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockTrackConfirmationWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_track_confirmation_write_uid_fkey");

            entity.HasMany(d => d.ProductProducts).WithMany(p => p.StockTrackConfirmations)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductProductStockTrackConfirmationRel",
                    r => r.HasOne<ProductProduct>().WithMany()
                        .HasForeignKey("ProductProductId")
                        .HasConstraintName("product_product_stock_track_confirmatio_product_product_id_fkey"),
                    l => l.HasOne<StockTrackConfirmation>().WithMany()
                        .HasForeignKey("StockTrackConfirmationId")
                        .HasConstraintName("product_product_stock_track_co_stock_track_confirmation_id_fkey"),
                    j =>
                    {
                        j.HasKey("StockTrackConfirmationId", "ProductProductId").HasName("product_product_stock_track_confirmation_rel_pkey");
                        j.ToTable("product_product_stock_track_confirmation_rel");
                        j.HasIndex(new[] { "ProductProductId", "StockTrackConfirmationId" }, "product_product_stock_track_c_product_product_id_stock_trac_idx");
                    });

            entity.HasMany(d => d.StockQuants).WithMany(p => p.StockTrackConfirmations)
                .UsingEntity<Dictionary<string, object>>(
                    "StockQuantStockTrackConfirmationRel",
                    r => r.HasOne<StockQuant>().WithMany()
                        .HasForeignKey("StockQuantId")
                        .HasConstraintName("stock_quant_stock_track_confirmation_rel_stock_quant_id_fkey"),
                    l => l.HasOne<StockTrackConfirmation>().WithMany()
                        .HasForeignKey("StockTrackConfirmationId")
                        .HasConstraintName("stock_quant_stock_track_confir_stock_track_confirmation_id_fkey"),
                    j =>
                    {
                        j.HasKey("StockTrackConfirmationId", "StockQuantId").HasName("stock_quant_stock_track_confirmation_rel_pkey");
                        j.ToTable("stock_quant_stock_track_confirmation_rel");
                        j.HasIndex(new[] { "StockQuantId", "StockTrackConfirmationId" }, "stock_quant_stock_track_confi_stock_quant_id_stock_track_co_idx");
                    });
        });

        modelBuilder.Entity<StockTrackLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_track_line_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockTrackLineCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_track_line_create_uid_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockTrackLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_track_line_product_id_fkey");

            entity.HasOne(d => d.Wizard).WithMany(p => p.StockTrackLines)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_track_line_wizard_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockTrackLineWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_track_line_write_uid_fkey");
        });

        modelBuilder.Entity<StockValuationLayer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_valuation_layer_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.AccountMove).WithMany(p => p.StockValuationLayers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_valuation_layer_account_move_id_fkey");

            entity.HasOne(d => d.AccountMoveLine).WithMany(p => p.StockValuationLayers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_valuation_layer_account_move_line_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.StockValuationLayers)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_valuation_layer_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockValuationLayerCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_valuation_layer_create_uid_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockValuationLayers)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_valuation_layer_product_id_fkey");

            entity.HasOne(d => d.StockMove).WithMany(p => p.StockValuationLayers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_valuation_layer_stock_move_id_fkey");

            entity.HasOne(d => d.StockValuationLayerNavigation).WithMany(p => p.InverseStockValuationLayerNavigation)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_valuation_layer_stock_valuation_layer_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockValuationLayerWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_valuation_layer_write_uid_fkey");
        });

        modelBuilder.Entity<StockValuationLayerRevaluation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_valuation_layer_revaluation_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Account).WithMany(p => p.StockValuationLayerRevaluations)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_valuation_layer_revaluation_account_id_fkey");

            entity.HasOne(d => d.AccountJournal).WithMany(p => p.StockValuationLayerRevaluations)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_valuation_layer_revaluation_account_journal_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.StockValuationLayerRevaluations)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_valuation_layer_revaluation_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockValuationLayerRevaluationCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_valuation_layer_revaluation_create_uid_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockValuationLayerRevaluations)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_valuation_layer_revaluation_product_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockValuationLayerRevaluationWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_valuation_layer_revaluation_write_uid_fkey");
        });

        modelBuilder.Entity<StockWarehouse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_warehouse_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.BuyPull).WithMany(p => p.StockWarehouseBuyPulls)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_buy_pull_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.StockWarehouses)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_warehouse_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockWarehouseCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_create_uid_fkey");

            entity.HasOne(d => d.CrossdockRoute).WithMany(p => p.StockWarehouseCrossdockRoutes)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_warehouse_crossdock_route_id_fkey");

            entity.HasOne(d => d.DeliveryRoute).WithMany(p => p.StockWarehouseDeliveryRoutes)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_warehouse_delivery_route_id_fkey");

            entity.HasOne(d => d.InType).WithMany(p => p.StockWarehouseInTypes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_in_type_id_fkey");

            entity.HasOne(d => d.IntType).WithMany(p => p.StockWarehouseIntTypes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_int_type_id_fkey");

            entity.HasOne(d => d.LotStock).WithMany(p => p.StockWarehouseLotStocks)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_warehouse_lot_stock_id_fkey");

            entity.HasOne(d => d.ManuType).WithMany(p => p.StockWarehouseManuTypes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_manu_type_id_fkey");

            entity.HasOne(d => d.ManufactureMtoPull).WithMany(p => p.StockWarehouseManufactureMtoPulls)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_manufacture_mto_pull_id_fkey");

            entity.HasOne(d => d.ManufacturePull).WithMany(p => p.StockWarehouseManufacturePulls)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_manufacture_pull_id_fkey");

            entity.HasOne(d => d.MtoPull).WithMany(p => p.StockWarehouseMtoPulls)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_mto_pull_id_fkey");

            entity.HasOne(d => d.OutType).WithMany(p => p.StockWarehouseOutTypes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_out_type_id_fkey");

            entity.HasOne(d => d.PackType).WithMany(p => p.StockWarehousePackTypes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_pack_type_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.StockWarehouses)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_partner_id_fkey");

            entity.HasOne(d => d.PbmLoc).WithMany(p => p.StockWarehousePbmLocs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_pbm_loc_id_fkey");

            entity.HasOne(d => d.PbmMtoPull).WithMany(p => p.StockWarehousePbmMtoPulls)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_pbm_mto_pull_id_fkey");

            entity.HasOne(d => d.PbmRoute).WithMany(p => p.StockWarehousePbmRoutes)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_warehouse_pbm_route_id_fkey");

            entity.HasOne(d => d.PbmType).WithMany(p => p.StockWarehousePbmTypes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_pbm_type_id_fkey");

            entity.HasOne(d => d.PickType).WithMany(p => p.StockWarehousePickTypes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_pick_type_id_fkey");

            entity.HasOne(d => d.PosType).WithMany(p => p.StockWarehousePosTypes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_pos_type_id_fkey");

            entity.HasOne(d => d.ReceptionRoute).WithMany(p => p.StockWarehouseReceptionRoutes)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_warehouse_reception_route_id_fkey");

            entity.HasOne(d => d.ReturnType).WithMany(p => p.StockWarehouseReturnTypes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_return_type_id_fkey");

            entity.HasOne(d => d.SamLoc).WithMany(p => p.StockWarehouseSamLocs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_sam_loc_id_fkey");

            entity.HasOne(d => d.SamRule).WithMany(p => p.StockWarehouseSamRules)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_sam_rule_id_fkey");

            entity.HasOne(d => d.SamType).WithMany(p => p.StockWarehouseSamTypes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_sam_type_id_fkey");

            entity.HasOne(d => d.ViewLocation).WithMany(p => p.StockWarehouseViewLocations)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_warehouse_view_location_id_fkey");

            entity.HasOne(d => d.WhInputStockLoc).WithMany(p => p.StockWarehouseWhInputStockLocs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_wh_input_stock_loc_id_fkey");

            entity.HasOne(d => d.WhOutputStockLoc).WithMany(p => p.StockWarehouseWhOutputStockLocs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_wh_output_stock_loc_id_fkey");

            entity.HasOne(d => d.WhPackStockLoc).WithMany(p => p.StockWarehouseWhPackStockLocs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_wh_pack_stock_loc_id_fkey");

            entity.HasOne(d => d.WhQcStockLoc).WithMany(p => p.StockWarehouseWhQcStockLocs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_wh_qc_stock_loc_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockWarehouseWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_write_uid_fkey");

            entity.HasMany(d => d.SuppliedWhs).WithMany(p => p.SupplierWhs)
                .UsingEntity<Dictionary<string, object>>(
                    "StockWhResupplyTable",
                    r => r.HasOne<StockWarehouse>().WithMany()
                        .HasForeignKey("SuppliedWhId")
                        .HasConstraintName("stock_wh_resupply_table_supplied_wh_id_fkey"),
                    l => l.HasOne<StockWarehouse>().WithMany()
                        .HasForeignKey("SupplierWhId")
                        .HasConstraintName("stock_wh_resupply_table_supplier_wh_id_fkey"),
                    j =>
                    {
                        j.HasKey("SuppliedWhId", "SupplierWhId").HasName("stock_wh_resupply_table_pkey");
                        j.ToTable("stock_wh_resupply_table");
                        j.HasIndex(new[] { "SupplierWhId", "SuppliedWhId" }, "stock_wh_resupply_table_supplier_wh_id_supplied_wh_id_idx");
                    });

            entity.HasMany(d => d.SupplierWhs).WithMany(p => p.SuppliedWhs)
                .UsingEntity<Dictionary<string, object>>(
                    "StockWhResupplyTable",
                    r => r.HasOne<StockWarehouse>().WithMany()
                        .HasForeignKey("SupplierWhId")
                        .HasConstraintName("stock_wh_resupply_table_supplier_wh_id_fkey"),
                    l => l.HasOne<StockWarehouse>().WithMany()
                        .HasForeignKey("SuppliedWhId")
                        .HasConstraintName("stock_wh_resupply_table_supplied_wh_id_fkey"),
                    j =>
                    {
                        j.HasKey("SuppliedWhId", "SupplierWhId").HasName("stock_wh_resupply_table_pkey");
                        j.ToTable("stock_wh_resupply_table");
                        j.HasIndex(new[] { "SupplierWhId", "SuppliedWhId" }, "stock_wh_resupply_table_supplier_wh_id_supplied_wh_id_idx");
                    });
        });

        modelBuilder.Entity<StockWarehouseOrderpoint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_warehouse_orderpoint_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Bom).WithMany(p => p.StockWarehouseOrderpoints)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_orderpoint_bom_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.StockWarehouseOrderpoints)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_warehouse_orderpoint_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockWarehouseOrderpointCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_orderpoint_create_uid_fkey");

            entity.HasOne(d => d.Group).WithMany(p => p.StockWarehouseOrderpoints)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_orderpoint_group_id_fkey");

            entity.HasOne(d => d.Location).WithMany(p => p.StockWarehouseOrderpoints)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_warehouse_orderpoint_location_id_fkey");

            entity.HasOne(d => d.ProductCategory).WithMany(p => p.StockWarehouseOrderpoints)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_orderpoint_product_category_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockWarehouseOrderpoints)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_warehouse_orderpoint_product_id_fkey");

            entity.HasOne(d => d.Route).WithMany(p => p.StockWarehouseOrderpoints)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_orderpoint_route_id_fkey");

            entity.HasOne(d => d.Supplier).WithMany(p => p.StockWarehouseOrderpoints)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_orderpoint_supplier_id_fkey");

            entity.HasOne(d => d.Vendor).WithMany(p => p.StockWarehouseOrderpoints)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_orderpoint_vendor_id_fkey");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.StockWarehouseOrderpoints)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_warehouse_orderpoint_warehouse_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockWarehouseOrderpointWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_orderpoint_write_uid_fkey");
        });

        modelBuilder.Entity<StockWarnInsufficientQtyRepair>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_warn_insufficient_qty_repair_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockWarnInsufficientQtyRepairCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warn_insufficient_qty_repair_create_uid_fkey");

            entity.HasOne(d => d.Location).WithMany(p => p.StockWarnInsufficientQtyRepairs)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_warn_insufficient_qty_repair_location_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockWarnInsufficientQtyRepairs)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_warn_insufficient_qty_repair_product_id_fkey");

            entity.HasOne(d => d.Repair).WithMany(p => p.StockWarnInsufficientQtyRepairs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warn_insufficient_qty_repair_repair_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockWarnInsufficientQtyRepairWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warn_insufficient_qty_repair_write_uid_fkey");
        });

        modelBuilder.Entity<StockWarnInsufficientQtyScrap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_warn_insufficient_qty_scrap_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockWarnInsufficientQtyScrapCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warn_insufficient_qty_scrap_create_uid_fkey");

            entity.HasOne(d => d.Location).WithMany(p => p.StockWarnInsufficientQtyScraps)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_warn_insufficient_qty_scrap_location_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockWarnInsufficientQtyScraps)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_warn_insufficient_qty_scrap_product_id_fkey");

            entity.HasOne(d => d.Scrap).WithMany(p => p.StockWarnInsufficientQtyScraps)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warn_insufficient_qty_scrap_scrap_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockWarnInsufficientQtyScrapWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warn_insufficient_qty_scrap_write_uid_fkey");
        });

        modelBuilder.Entity<StockWarnInsufficientQtyUnbuild>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_warn_insufficient_qty_unbuild_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockWarnInsufficientQtyUnbuildCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warn_insufficient_qty_unbuild_create_uid_fkey");

            entity.HasOne(d => d.Location).WithMany(p => p.StockWarnInsufficientQtyUnbuilds)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_warn_insufficient_qty_unbuild_location_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockWarnInsufficientQtyUnbuilds)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_warn_insufficient_qty_unbuild_product_id_fkey");

            entity.HasOne(d => d.Unbuild).WithMany(p => p.StockWarnInsufficientQtyUnbuilds)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warn_insufficient_qty_unbuild_unbuild_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockWarnInsufficientQtyUnbuildWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warn_insufficient_qty_unbuild_write_uid_fkey");
        });

        modelBuilder.Entity<ThemeIrAsset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("theme_ir_asset_pkey");

            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.ThemeIrAssetCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("theme_ir_asset_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ThemeIrAssetWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("theme_ir_asset_write_uid_fkey");
        });

        modelBuilder.Entity<ThemeIrAttachment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("theme_ir_attachment_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ThemeIrAttachmentCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("theme_ir_attachment_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ThemeIrAttachmentWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("theme_ir_attachment_write_uid_fkey");
        });

        modelBuilder.Entity<ThemeIrUiView>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("theme_ir_ui_view_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ThemeIrUiViewCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("theme_ir_ui_view_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ThemeIrUiViewWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("theme_ir_ui_view_write_uid_fkey");
        });

        modelBuilder.Entity<ThemeWebsiteMenu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("theme_website_menu_pkey");

            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.ThemeWebsiteMenuCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("theme_website_menu_create_uid_fkey");

            entity.HasOne(d => d.Page).WithMany(p => p.ThemeWebsiteMenus)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("theme_website_menu_page_id_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("theme_website_menu_parent_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ThemeWebsiteMenuWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("theme_website_menu_write_uid_fkey");
        });

        modelBuilder.Entity<ThemeWebsitePage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("theme_website_page_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ThemeWebsitePageCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("theme_website_page_create_uid_fkey");

            entity.HasOne(d => d.View).WithMany(p => p.ThemeWebsitePages)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("theme_website_page_view_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ThemeWebsitePageWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("theme_website_page_write_uid_fkey");
        });

        modelBuilder.Entity<UomCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("uom_category_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.UomCategoryCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("uom_category_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.UomCategoryWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("uom_category_write_uid_fkey");
        });

        modelBuilder.Entity<UomUom>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("uom_uom_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Category).WithMany(p => p.UomUoms)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("uom_uom_category_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.UomUomCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("uom_uom_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.UomUomWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("uom_uom_write_uid_fkey");
        });

        modelBuilder.Entity<UtmCampaign>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("utm_campaign_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Company).WithMany(p => p.UtmCampaigns)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("utm_campaign_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.UtmCampaignCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("utm_campaign_create_uid_fkey");

            entity.HasOne(d => d.Stage).WithMany(p => p.UtmCampaigns)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("utm_campaign_stage_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.UtmCampaignUsers)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("utm_campaign_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.UtmCampaignWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("utm_campaign_write_uid_fkey");

            entity.HasMany(d => d.Campaigns).WithMany(p => p.Tags)
                .UsingEntity<Dictionary<string, object>>(
                    "UtmTagRel",
                    r => r.HasOne<UtmTag>().WithMany()
                        .HasForeignKey("CampaignId")
                        .HasConstraintName("utm_tag_rel_campaign_id_fkey"),
                    l => l.HasOne<UtmCampaign>().WithMany()
                        .HasForeignKey("TagId")
                        .HasConstraintName("utm_tag_rel_tag_id_fkey"),
                    j =>
                    {
                        j.HasKey("TagId", "CampaignId").HasName("utm_tag_rel_pkey");
                        j.ToTable("utm_tag_rel");
                        j.HasIndex(new[] { "CampaignId", "TagId" }, "utm_tag_rel_campaign_id_tag_id_idx");
                    });
        });

        modelBuilder.Entity<UtmMedium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("utm_medium_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.UtmMediumCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("utm_medium_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.UtmMediumWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("utm_medium_write_uid_fkey");
        });

        modelBuilder.Entity<UtmSource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("utm_source_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.UtmSourceCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("utm_source_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.UtmSourceWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("utm_source_write_uid_fkey");
        });

        modelBuilder.Entity<UtmStage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("utm_stage_pkey");

            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.UtmStageCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("utm_stage_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.UtmStageWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("utm_stage_write_uid_fkey");
        });

        modelBuilder.Entity<UtmTag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("utm_tag_pkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.UtmTagCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("utm_tag_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.UtmTagWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("utm_tag_write_uid_fkey");
        });

        modelBuilder.Entity<ValidateAccountMove>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("validate_account_move_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ValidateAccountMoveCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("validate_account_move_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ValidateAccountMoveWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("validate_account_move_write_uid_fkey");
        });

        modelBuilder.Entity<WebEditorConverterTest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("web_editor_converter_test_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.WebEditorConverterTestCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("web_editor_converter_test_create_uid_fkey");

            entity.HasOne(d => d.Many2oneNavigation).WithMany(p => p.WebEditorConverterTests)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("web_editor_converter_test_many2one_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.WebEditorConverterTestWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("web_editor_converter_test_write_uid_fkey");
        });

        modelBuilder.Entity<WebEditorConverterTestSub>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("web_editor_converter_test_sub_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.WebEditorConverterTestSubCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("web_editor_converter_test_sub_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.WebEditorConverterTestSubWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("web_editor_converter_test_sub_write_uid_fkey");
        });

        modelBuilder.Entity<WebTourTour>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("web_tour_tour_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.User).WithMany(p => p.WebTourTours)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("web_tour_tour_user_id_fkey");
        });

        modelBuilder.Entity<Website>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("website_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CartRecoveryMailTemplate).WithMany(p => p.Websites)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_cart_recovery_mail_template_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.Websites)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("website_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.WebsiteCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_create_uid_fkey");

            entity.HasOne(d => d.CrmDefaultTeam).WithMany(p => p.WebsiteCrmDefaultTeams)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_crm_default_team_id_fkey");

            entity.HasOne(d => d.CrmDefaultUser).WithMany(p => p.WebsiteCrmDefaultUsers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_crm_default_user_id_fkey");

            entity.HasOne(d => d.DefaultLang).WithMany(p => p.Websites)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("website_default_lang_id_fkey");

            entity.HasOne(d => d.Salesperson).WithMany(p => p.WebsiteSalespeople)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_salesperson_id_fkey");

            entity.HasOne(d => d.Salesteam).WithMany(p => p.WebsiteSalesteams)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_salesteam_id_fkey");

            entity.HasOne(d => d.Theme).WithMany(p => p.Websites)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_theme_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.WebsiteUsers)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("website_user_id_fkey");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.Websites)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_warehouse_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.WebsiteWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_write_uid_fkey");

            entity.HasMany(d => d.Langs).WithMany(p => p.WebsitesNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "WebsiteLangRel",
                    r => r.HasOne<ResLang>().WithMany()
                        .HasForeignKey("LangId")
                        .HasConstraintName("website_lang_rel_lang_id_fkey"),
                    l => l.HasOne<Website>().WithMany()
                        .HasForeignKey("WebsiteId")
                        .HasConstraintName("website_lang_rel_website_id_fkey"),
                    j =>
                    {
                        j.HasKey("WebsiteId", "LangId").HasName("website_lang_rel_pkey");
                        j.ToTable("website_lang_rel");
                        j.HasIndex(new[] { "LangId", "WebsiteId" }, "website_lang_rel_lang_id_website_id_idx");
                    });
        });

        modelBuilder.Entity<WebsiteBaseUnit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("website_base_unit_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.WebsiteBaseUnitCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_base_unit_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.WebsiteBaseUnitWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_base_unit_write_uid_fkey");
        });

        modelBuilder.Entity<WebsiteConfiguratorFeature>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("website_configurator_feature_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.WebsiteConfiguratorFeatureCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_configurator_feature_create_uid_fkey");

            entity.HasOne(d => d.Module).WithMany(p => p.WebsiteConfiguratorFeatures)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("website_configurator_feature_module_id_fkey");

            entity.HasOne(d => d.PageView).WithMany(p => p.WebsiteConfiguratorFeatures)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("website_configurator_feature_page_view_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.WebsiteConfiguratorFeatureWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_configurator_feature_write_uid_fkey");
        });

        modelBuilder.Entity<WebsiteMenu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("website_menu_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.WebsiteMenuCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_menu_create_uid_fkey");

            entity.HasOne(d => d.Page).WithMany(p => p.WebsiteMenus)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("website_menu_page_id_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("website_menu_parent_id_fkey");

            entity.HasOne(d => d.ThemeTemplate).WithMany(p => p.WebsiteMenus)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_menu_theme_template_id_fkey");

            entity.HasOne(d => d.Website).WithMany(p => p.WebsiteMenus)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("website_menu_website_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.WebsiteMenuWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_menu_write_uid_fkey");
        });

        modelBuilder.Entity<WebsitePage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("website_page_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.WebsitePageCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_page_create_uid_fkey");

            entity.HasOne(d => d.ThemeTemplate).WithMany(p => p.WebsitePages)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_page_theme_template_id_fkey");

            entity.HasOne(d => d.View).WithMany(p => p.WebsitePages)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("website_page_view_id_fkey");

            entity.HasOne(d => d.Website).WithMany(p => p.WebsitePages)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("website_page_website_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.WebsitePageWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_page_write_uid_fkey");
        });

        modelBuilder.Entity<WebsiteRewrite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("website_rewrite_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.WebsiteRewriteCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_rewrite_create_uid_fkey");

            entity.HasOne(d => d.Route).WithMany(p => p.WebsiteRewrites)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_rewrite_route_id_fkey");

            entity.HasOne(d => d.Website).WithMany(p => p.WebsiteRewrites)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("website_rewrite_website_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.WebsiteRewriteWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_rewrite_write_uid_fkey");
        });

        modelBuilder.Entity<WebsiteRobot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("website_robots_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.WebsiteRobotCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_robots_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.WebsiteRobotWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_robots_write_uid_fkey");
        });

        modelBuilder.Entity<WebsiteRoute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("website_route_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.WebsiteRouteCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_route_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.WebsiteRouteWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_route_write_uid_fkey");
        });

        modelBuilder.Entity<WebsiteSaleExtraField>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("website_sale_extra_field_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateU).WithMany(p => p.WebsiteSaleExtraFieldCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_sale_extra_field_create_uid_fkey");

            entity.HasOne(d => d.Field).WithMany(p => p.WebsiteSaleExtraFields)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("website_sale_extra_field_field_id_fkey");

            entity.HasOne(d => d.Website).WithMany(p => p.WebsiteSaleExtraFields)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_sale_extra_field_website_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.WebsiteSaleExtraFieldWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_sale_extra_field_write_uid_fkey");
        });

        modelBuilder.Entity<WebsiteSnippetFilter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("website_snippet_filter_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.ActionServer).WithMany(p => p.WebsiteSnippetFilters)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("website_snippet_filter_action_server_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.WebsiteSnippetFilterCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_snippet_filter_create_uid_fkey");

            entity.HasOne(d => d.Filter).WithMany(p => p.WebsiteSnippetFilters)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("website_snippet_filter_filter_id_fkey");

            entity.HasOne(d => d.Website).WithMany(p => p.WebsiteSnippetFilters)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("website_snippet_filter_website_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.WebsiteSnippetFilterWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_snippet_filter_write_uid_fkey");
        });

        modelBuilder.Entity<WebsiteTrack>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("website_track_pkey");

            entity.HasIndex(e => e.ProductId, "website_track_product_id_index").HasFilter("(product_id IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Page).WithMany(p => p.WebsiteTracks)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("website_track_page_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.WebsiteTracks)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("website_track_product_id_fkey");

            entity.HasOne(d => d.Visitor).WithMany(p => p.WebsiteTracks)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("website_track_visitor_id_fkey");
        });

        modelBuilder.Entity<WebsiteVisitor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("website_visitor_pkey");

            entity.HasIndex(e => e.PartnerId, "website_visitor_partner_id_index").HasFilter("(partner_id IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.Country).WithMany(p => p.WebsiteVisitors)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_visitor_country_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.WebsiteVisitorCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_visitor_create_uid_fkey");

            entity.HasOne(d => d.Lang).WithMany(p => p.WebsiteVisitors)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_visitor_lang_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.WebsiteVisitors)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_visitor_partner_id_fkey");

            entity.HasOne(d => d.Website).WithMany(p => p.WebsiteVisitors)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_visitor_website_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.WebsiteVisitorWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("website_visitor_write_uid_fkey");
        });

        modelBuilder.Entity<WizardIrModelMenuCreate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("wizard_ir_model_menu_create_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("next_uuid()");

            entity.HasOne(d => d.CreateU).WithMany(p => p.WizardIrModelMenuCreateCreateUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("wizard_ir_model_menu_create_create_uid_fkey");

            entity.HasOne(d => d.Menu).WithMany(p => p.WizardIrModelMenuCreates)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("wizard_ir_model_menu_create_menu_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.WizardIrModelMenuCreateWriteUs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("wizard_ir_model_menu_create_write_uid_fkey");
        });

        //OnModelCreatingPartial(modelBuilder);
    }

    //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
