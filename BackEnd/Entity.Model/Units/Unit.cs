using System;
using System.Collections.Generic;
using System.Text;
using Entity.Model.UnitTypes;

namespace Entity.Model.Units
{
    public  class Unit
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public UnitType UnitTypes { get; set; }
    }
}
