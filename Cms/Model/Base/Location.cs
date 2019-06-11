using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Model.sal;

namespace Model.Base
{
    public enum LocationType
    {
        store,
        shop 
    }
    public class Location
    {
        [Key]
        public ulong Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public LocationType LocationType {get ;set ;}
        public string Tell { get; set; }
        public string Address { get; set; }

        public City Cities { get; set; }
        public ICollection<FactorDoc> LocationId { get; set; }
    }
   
}
