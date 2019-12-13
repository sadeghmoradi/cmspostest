using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Entity.Model.CustomerTypes;

namespace Entity.Model.Customers
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string ShenaseMeli { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string TellHome { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public CustomerType CustomerTypes { get; set; }

    }
}
