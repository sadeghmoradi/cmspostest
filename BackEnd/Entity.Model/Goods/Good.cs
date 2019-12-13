using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Entity.Model.Brands;
using Entity.Model.Units;

namespace Entity.Model.Goods
{
    public class Good
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Unit Units { get; set; }
        public int PackQty { get; set; }
        public bool HasVat { get; set; }
        public bool MyProperty { get; set; }
        public Brand Brands { get; set; }
    }
}
