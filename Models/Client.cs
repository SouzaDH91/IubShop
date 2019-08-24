using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IubShop.Models
{
    public class Client
    {
        /* PK */
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public char Gender { get; set; }
        public string CPF { get; set; }
        public string Phone { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public DateTime RegisteDate { get; set; }
        public DateTime Updatedate { get; set; }



    }
}
