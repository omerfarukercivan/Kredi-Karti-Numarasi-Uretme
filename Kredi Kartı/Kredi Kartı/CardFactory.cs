using System;
using System.Collections.Generic;
using System.Text;

namespace Kredi_Kartı
{
    // Soyut CardFactory sınıfının tanımlanması.
    abstract class CardFactory
    {
        public abstract krediKartı GetCreditCard();
    }
}
