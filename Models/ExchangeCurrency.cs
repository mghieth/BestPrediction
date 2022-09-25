using System;
using System.Collections.Generic;
using System.Text;

namespace BestPrediction.Models
{
    public class ExchangeCurrency
    {
        public int Id { get; set; }
        public decimal ExchangeRate { get; set; }
        public DateTime ExchangeDate { get; set; }
        public Currency Currency { get; set; }
    }
}
