using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key] //using System.ComponentModel.DataAnnotations; kütüphaneinide eklemek gerekiyor.
        public int AboutID { get; set; } //aboutun  ID

        public string Title { get; set; } // about kısmındaki başlık

        public int Description { get; set; } // about kısmındaki metin

    }
}
