using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models.Enums;
namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {

        }
        public SalesRecord(int Id, DateTime Date, double Amount, SaleStatus Status, Seller Seller)
        {
            Id = Id;
            Date = Date;
            Amount = Amount;
            Status = Status;
            Seller = Seller;


        }
    }
}
