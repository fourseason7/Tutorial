﻿using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class Idprefix
    {
        public int IdprefixId { get; set; }
        public string ColumnName { get; set; }
        public string Prefix { get; set; }
        public bool? ActiveFlag { get; set; }
        public short? SeqNo { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
