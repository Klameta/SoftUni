namespace StockMarket
{
    public class Stock
    {
        private string companyName;
        private string director;
        private decimal pricePerShare;
        private int totalNumberOfShares;
        private decimal marketCapitalization;

        public Stock(string companyName, string director, decimal pricePerShare, int totalNumberOfShares)
        {
            CompanyName = companyName;
            Director = director;
            PricePerShare = pricePerShare;
            TotalNumberOfShares = totalNumberOfShares;
            MarketCapitalization = PricePerShare * TotalNumberOfShares;
        }

        public string CompanyName
        {
            get { return companyName; }
            private set { companyName = value; }
        }
        public string Director
        {
            get { return director; }
            private set { director = value; }
        }
        public decimal PricePerShare
        {
            get { return pricePerShare; }
            private set { pricePerShare = value; }
        }
        public int TotalNumberOfShares
        {
            get { return totalNumberOfShares; }
            private set { totalNumberOfShares = value; }
        }
        public decimal MarketCapitalization
        {
            get { return marketCapitalization; }
            private set { marketCapitalization = value; }
        }

        public override string ToString()
        {
            return $"Company: {CompanyName}" +
                $"\nDirector: {Director}" +
                $"\nPrice per share: ${PricePerShare}" +
                $"\nMarket capitalization: ${MarketCapitalization}";
        }
    }
}
