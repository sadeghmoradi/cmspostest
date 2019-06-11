using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Base
{
    public class City
    {
        [Key]
        public ulong Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public ICollection<Location> LocatioId { get; set; }

    }
}
