﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Model.Base;

namespace Model.sal
{
    public class FactorDoc
    {
        [Key]
        public ulong Id { get; set; }
        public string Code { get; set; }

        public DateTime Confrimdate { get; set; }
        public string Date { get; set; }

        public Location Locations { get; set; }
        public ICollection<FactorDocDetail> FactorDocId { get; set; }
    }
}
