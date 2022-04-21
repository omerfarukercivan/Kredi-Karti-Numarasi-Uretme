﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Kredi_Kartı
{
    class MasterCardFactory:CardFactory
    {
        private int _creditLimit, _cvv, _point;
        private string _CardNumber, _date, _name;

        // Constructor
        public MasterCardFactory(int creditLimit, int point,int cvv,string cardNumber, string Date, string name_surname)
        {
            _creditLimit = creditLimit;
            _point = point;
            _CardNumber = cardNumber;
            _date = Date;
            _name = name_surname;
            _cvv = cvv;
        }

        // Kart bilgilerini çeken factory methodu.
        public override krediKartı GetCreditCard()
        {
            return new MasterCard(_creditLimit, _point,_cvv, _CardNumber, _date, _name);
        }

    }
}

