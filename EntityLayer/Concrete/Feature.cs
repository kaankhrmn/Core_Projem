using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Feature
    {
        [Key]
        public int FeatureID { get; set; } // ilk açılıştaki ekranın ıd

        public string Header { get; set; } // Featurdeki Başlık

        public string Name { get; set; } // Featurdeki isim yeri

        public string Title { get; set; } // Featurdeki AltBaşlık
    }

}

