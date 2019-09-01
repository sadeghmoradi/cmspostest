using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Entity.Model.Locations;

namespace Entity.Model.FactorDocs
{
    public class FactorDoc
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }

        public DateTime Confrimdate { get; set; }
        public string Date { get; set; }

        public Location Locations { get; set; }
    }
}
