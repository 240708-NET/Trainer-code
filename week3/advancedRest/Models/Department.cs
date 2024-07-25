using System;
using System.Collections.Generic;

namespace advancedRest.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public string DepartmentResponsibilites { get; set; } = null!;
}
