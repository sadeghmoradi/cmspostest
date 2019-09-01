using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Entity.Model.FactorDocs;
using Entity.Model.Goods;

namespace Entity.Model.FactorDocDetails
{
    public class FactorDocDetail
    {
        [Key]
        public int Id { get; set; }
        public string AddressBuy { get; set; }
        public float Quantity { get; set; }
        public Good Goods { get; set; }
        public FactorDoc FactorDocs { get; set; }

    }
}
