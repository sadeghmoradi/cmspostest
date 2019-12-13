using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Model.Citys
{
    public class CityDto
    {
        private readonly City city;

        public CityDto(City city)
        {
            this.city = city;
        }
        
        public int Id
        {
            get { return city.Id; }
            set { value = city.Id; }
        }
        public string Code
        {
            get { return city.Code; }
            set { value = city.Code; }
        }
        public string Name
        {
            get { return city.Name; }
            set { value = city.Name; }
        }
        public int cityCount { get; set; }
        public string OwnerId {
            get { return city.OwnerId; }
            set { value = city.OwnerId; }
        }
        
    }
}
