using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Controller
{
    public  class Trade : ITrade
    {
        public Trade()
        {

        }

        CultureInfo provider = new CultureInfo("en-us");
        public double Value { get;  set; }
        public string ClientSector { get;  set; }
        public DateTime NextPaymentDate { get;  set; }
        public string Category { get; set; }

        public void Insert(Trade trade)
        {

        }

        public Trade Validate(string portfolio,DateTime referenceDate)
        {
            string errorMessage = "";
            Trade trade = null;
            double value = 0;
            try
            {
                string[] portfolioData = portfolio.Split(" ");

                if (portfolioData.Length != 3)
                    throw new Exception("The format is not correct. Separete with space the portfolio data.");
                
                if (! Double.TryParse(portfolioData[0],out value))
                    throw new Exception("Is invalid value.");

                if (!(portfolioData[1].ToUpper() == "PUBLIC" || portfolioData[1].ToUpper() == "PRIVATE"))
                    throw new Exception("Is invalid value.");

                if (!Validation.ValidateFormatDate(portfolioData[2]))
                    throw new Exception("Is invalid date.");

                trade = new Trade()
                {
                    Value = value,
                    ClientSector = portfolioData[1],
                    NextPaymentDate = DateTime.Parse(portfolioData[2], provider),
                    
                };
                trade.Category = trade.GetCategory(referenceDate);
            }
            catch (Exception ex)
            {
                throw new Exception("Portfolio Error! " + ex.Message);
            }
            

            return trade;
        }

        private string GetCategory(DateTime referenceDate)
        {
            int daysPayment = (int)referenceDate.Subtract(this.NextPaymentDate).TotalDays;

            if (daysPayment > 30)
                return "EXPIRED";

            if ((this.ClientSector.ToUpper() == "PRIVATE") && (this.Value > 1000000))
                return "HIGHRISK";

            if ((this.ClientSector.ToUpper() == "PUBLIC") && (this.Value > 1000000))
                return "MEDIUMRISK";

            return "Indefined category for this trade";


        }
    }
}
