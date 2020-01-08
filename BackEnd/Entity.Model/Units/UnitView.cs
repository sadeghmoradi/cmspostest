using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Model.Units
{
    public class UnitView: Unit
    {
        public UnitView():base()
        {

        }
        public string UnitTypeName { get; set; }
        
        public int UnitTypeId { get; set; }
    }
}
