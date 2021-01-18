using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_ChuyenDoiTIenTe_HGK
{

    public class CD
    {
        public string result { get; set; }
        public string documentation { get; set; }
        public string terms_of_use { get; set; }
        public string time_zone { get; set; }
        public int time_last_update { get; set; }
        public int time_next_update { get; set; }
        public string _base { get; set; }
        public Conversion_Rates conversion_rates { get; set; }
    }

    public class Conversion_Rates
    {
        public int USD { get; set; }
        public float AED { get; set; }
        public float ARS { get; set; }
        public float AUD { get; set; }
        public float BGN { get; set; }
        public float BRL { get; set; }
        public float BSD { get; set; }
        public float CAD { get; set; }
        public float CHF { get; set; }
        public float CLP { get; set; }
        public float CNY { get; set; }
        public float COP { get; set; }
        public float CZK { get; set; }
        public float DKK { get; set; }
        public float DOP { get; set; }
        public float EGP { get; set; }
        public float EUR { get; set; }
        public float FJD { get; set; }
        public float GBP { get; set; }
        public float GTQ { get; set; }
        public float HKD { get; set; }
        public float HRK { get; set; }
        public float HUF { get; set; }
        public float IDR { get; set; }
        public float ILS { get; set; }
        public float INR { get; set; }
        public float ISK { get; set; }
        public float JPY { get; set; }
        public float KRW { get; set; }
        public float KZT { get; set; }
        public float MVR { get; set; }
        public float MXN { get; set; }
        public float MYR { get; set; }
        public float NOK { get; set; }
        public float NZD { get; set; }
        public float PAB { get; set; }
        public float PEN { get; set; }
        public float PHP { get; set; }
        public float PKR { get; set; }
        public float PLN { get; set; }
        public float PYG { get; set; }
        public float RON { get; set; }
        public float RUB { get; set; }
        public float SAR { get; set; }
        public float SEK { get; set; }
        public float SGD { get; set; }
        public float THB { get; set; }
        public float TRY { get; set; }
        public float TWD { get; set; }
        public float UAH { get; set; }
        public float UYU { get; set; }
        public float ZAR { get; set; }
    }

}
