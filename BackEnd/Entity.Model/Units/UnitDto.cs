using System;
using System.Collections.Generic;
using System.Text;
using Entity.Model.UnitTypes;

namespace Entity.Model.Units
{
    public class UnitDto
    {
        private readonly Unit unit;

        
        public UnitDto(Unit unit)
        {
            this.unit = unit;
        }

        public int Id
        {
            get { return unit.Id; }
            set { value = unit.Id; }
        }

        public string Code
        {
            get { return unit.Code; }
            set { value = unit.Code; }
        }

        public string Name
        {
            get { return unit.Name; }
            set { value = unit.Name; }
        }
        public string UnitTypeName
        {
            get { return unit.UnitTypes.Title; }
            set { value = unit.UnitTypes.Title; }
        }
        public int  UnitTypeId
        {
            get { return unit.UnitTypes.Id; }
            set { value = unit.UnitTypes.Id; }
        }

        public int UnitCount { get; set; }
    }
}
