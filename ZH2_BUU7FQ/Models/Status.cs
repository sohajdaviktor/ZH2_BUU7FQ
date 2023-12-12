using System;
using System.Collections.Generic;

namespace ZH2_BUU7FQ.Models;

public partial class Status
{
    public byte StatusId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
}
