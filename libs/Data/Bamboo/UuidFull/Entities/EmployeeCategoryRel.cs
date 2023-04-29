using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("EmpId", "CategoryId")]
[Table("employee_category_rel")]
[Index("CategoryId", "EmpId", Name = "employee_category_rel_category_id_emp_id_idx")]
public partial class EmployeeCategoryRel
{
    [Key]
    [Column("emp_id")]
    public Guid EmpId { get; set; }

    [Key]
    [Column("category_id")]
    public long CategoryId { get; set; }

    [ForeignKey("EmpId")]
    [InverseProperty("EmployeeCategoryRels")]
    public virtual HrEmployee Emp { get; set; } = null!;
}
