using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountAccountFinancialReportType
{
    public Guid ReportId { get; set; }

    public long AccountTypeId { get; set; }

    public virtual AccountFinancialReport Report { get; set; } = null!;
}
