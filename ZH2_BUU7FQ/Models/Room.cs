﻿using System;
using System.Collections.Generic;

namespace ZH2_BUU7FQ.Models;

public partial class Room
{
    public int RoomSk { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
}
