using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    public class Investor
    {
        private Dictionary<string, Stock> portfolio;
        private string fullName;
        private string emailAddress;
        private decimal moneyToInvest;
        private string brokerName;

        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            portfolio = new Dictionary<string, Stock>();

            FullName = fullName;
            EmailAddress = emailAddress;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;

        }

        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10_000 && moneyToInvest > stock.PricePerShare)
            {
                if (portfolio.ContainsKey(stock.CompanyName)) return;

                portfolio.Add(stock.CompanyName, stock);
                moneyToInvest -= stock.PricePerShare;
            }
        }
        public string SellStock(string companyName, decimal sellPrice)
        {
            if (!portfolio.ContainsKey(companyName))
            {
                return $"{companyName} does not exist.";
            }
            if (sellPrice < portfolio[companyName].PricePerShare)
            {
                return $"Cannot sell {companyName}.";
            }

            portfolio.Remove(companyName);
            moneyToInvest += sellPrice;
            return $"{companyName} was sold.";

        }
        public Stock FindStock(string companyName)
        {
            if (portfolio.ContainsKey(companyName)) return portfolio[companyName];
            return null;
        }
        public Stock FindBiggestCompany()
        {
            if (!portfolio.Any())
            {
                return null;
            }

            return portfolio.Values.OrderByDescending(x => x.MarketCapitalization).First();
        }
        public string InvestorInformation()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"The investor {fullName} with a broker {brokerName} has stocks:");

            foreach (var stock in portfolio)
            {
                stringBuilder.AppendLine(stock.Value.ToString());
            }

            return stringBuilder.ToString().TrimEnd();
        }




        public string FullName
        {
            get { return fullName; }
            private set { fullName = value; }
        }
        public string EmailAddress
        {
            get { return emailAddress; }
            private set { emailAddress = value; }
        }
        public decimal MoneyToInvest
        {
            get { return moneyToInvest; }
            private set { moneyToInvest = value; }
        }
        public string BrokerName
        {
            get { return brokerName; }
            private set { brokerName = value; }
        }
        public Dictionary<string, Stock> Portfolio => portfolio;
        public int Count => portfolio.Count;


    }
}
