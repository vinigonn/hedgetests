using System;
namespace Domain.Entities
{

    public class HedgeFund
    {

        public HedgeFund()
        {

        }


        public string Cnpj { get; set; }

        public DateTime RecordDate { get; set; }

        public double TotalValue { get; set; }        

        public double QuotaValue { get; set; }

        public double FundNetWorth { get; set; }

        public double DayTotalInvestments { get; set; }

        public double DayTotalWithdraws { get; set; }

        public int TotalInvestors { get; set; }


    }


}