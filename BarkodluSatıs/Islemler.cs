﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatıs
{
    static class Islemler
    {

        public static double DoubleYap(string deger)
        {
            double sonuc;
            double.TryParse(deger,NumberStyles.Currency,CultureInfo.CurrentUICulture.NumberFormat, out sonuc);
            return Math.Round( sonuc,2);

        }
    }
}
