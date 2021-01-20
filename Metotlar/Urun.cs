using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun
    {
        //property - özellik
        public int Id { get; set; } //bir ürünü diğerlerinden ayırt eden değerdir.
        public string Adi { get; set; }
        public double Fiyati{ get; set; }
        public string Aciklama { get; set; }

        public int StokAdedi { get; set; }

    }
}
