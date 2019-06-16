using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Model.sal;

namespace Model.Base
{
    public class Good
    {
        [Key]
        public int Id { get; set; }

        public string Code { get; set; }
        public string Name { get; set; }
        public ICollection<FactorDocDetail> GoodId { get; set; }
    }
}
