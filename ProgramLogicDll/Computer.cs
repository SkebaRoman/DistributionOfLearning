﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProgramLogicDll
{
    public class Computer
    {
        [Key]
        public int ComputerId { get; set; }
        public string GraphicsCard { get; set; }
        public string Processor { get; set; }
        public int RAM { get; set; }
        public virtual Audience Audiences { get; set; }
        public virtual ICollection<Software> Softwares { get; set; }
    }
}
