using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{//bir nesnede 1 değeri kullanmak zorunda görünmüyorsam mesela gerçek kişi için firma adı, classları ayırmak mantıklı
    class GercekMusteri:Musteri
    {
        
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
    }
}
