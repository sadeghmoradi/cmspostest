using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Model.Base;

namespace Model.sal
{
    public class FactorDocDetail
    {
        [Key]
        public ulong Id { get; set; }
        public string AddressBuy { get; set; }
        public float Quantity { get; set; }
        public Good Goods{ get; set; }
        public FactorDoc FactorDocs { get; set; }

    }
}
