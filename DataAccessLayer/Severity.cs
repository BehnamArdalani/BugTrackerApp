﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Severity
    {
        int SeverityId { get; set; }
        string Name { get; set; }
        string? Description { get; set; }

    }
}