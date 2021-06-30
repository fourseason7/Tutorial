using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class ArchcoPunch
    {
        public string Cveid { get; set; }
        public string Archid { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public decimal? PayRate { get; set; }
        public string Date { get; set; }
        public string Ptime { get; set; }
        public string Ptype { get; set; }
        public string CoName { get; set; }
        public DateTime UpdateDt { get; set; }
    }
}
