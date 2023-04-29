using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class PosCategoryResConfigSettingsRel
{
    public Guid ResConfigSettingsId { get; set; }

    public long PosCategoryId { get; set; }

    public virtual ResConfigSetting ResConfigSettings { get; set; } = null!;
}
