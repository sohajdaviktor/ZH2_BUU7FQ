using System;
using System.Collections.Generic;

namespace ZH2_BUU7FQ.Models;

public partial class Employement
{
    public string EmployementId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
}
