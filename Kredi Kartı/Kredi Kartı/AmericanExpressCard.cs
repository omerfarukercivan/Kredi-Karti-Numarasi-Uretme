using System;
using System.Collections.Generic;
using System.Text;

namespace Kredi_Kartı
{
    class AmericanExpressCard:krediKartı
    {
        // American Express kart özelliklerinin tanımlanması.
        private readonly string _cardType;
        private int _creditLimit, _cvv, _point;
        private string _CardNumber, _date, _name;

        // Constructor method.
        public AmericanExpressCard(int creditLimit, int point,int cvv, string cardNumber, string Date, string name_surname)
        {
            _cardType = "Amex";
            _creditLimit = creditLimit;
            _point = point;
            _CardNumber = cardNumber;
            _date = Date;
            _name = name_surname;
            _cvv = cvv;

        }

        // Harcama methodunun ezilmesi.
        public override int harca(int a,ref int puan)
        {
            if(_creditLimit >= a)
            {
                _creditLimit -= a;
                puan = a / 1000;
                return _creditLimit;

            }
            else
            {
                return _creditLimit;
            }
            
        }

        // Borç ödeme methodunun ezilmesi.
        public override int borc_ode(int a)
        {
            _creditLimit += a;
            return _creditLimit;
        }

        // Diğer getter ve setter methodlar.
        public override string CardType
        {
            get { return _cardType; }
        }

        public override int CreditLimit
        {
            get { return _creditLimit; }
            set { _creditLimit = value; }
        }

        public override int cvv
        {
            get { return _cvv; }
            set { _cvv = value; }
        }
        public override string CardNumber
        {
            get { return _CardNumber; }
            set { _CardNumber = value; }
        }

        public override string Name_surname
        {
            get { return _name; }
            set { _name = value; }
        }

        public override string date
        {
            get { return _date; }
            set { _date = value; }
        }


        public override int Point
        {
            get { return _point; }
            set { _point = value; }
        }
    }
}
