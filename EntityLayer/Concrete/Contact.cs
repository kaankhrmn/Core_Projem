using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContectID { get; set; }
        public string Title { get; set; }
        public string Destriction { get; set; }
        public string Mail { get; set; }
        public int Phone { get; set; }

    }
}
