﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OA.Data
{
    public class Gender
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
