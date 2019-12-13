using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Entity.Model.Citys;
using Entity.Model.LocationTypes;

namespace Entity.Model.Locations
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }


        public string Tell { get; set; }
        public string Address { get; set; }

        public LocationType LocationTypes { get; set; }
        public City Cities { get; set; }
        

    }
}
