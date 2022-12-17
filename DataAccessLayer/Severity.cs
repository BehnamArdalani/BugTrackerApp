﻿using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer
{
    public class Severity
    {
        public int Id { get; set; }
        [StringLength(50)] public string Name { get; set; }
        public string? Description { get; set; }

    }
}
