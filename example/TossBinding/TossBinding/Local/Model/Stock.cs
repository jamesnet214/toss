namespace TossBinding.Local.Model
{
    public class Stock
    {
        public Stock(int rank, string id, string name, string color, int closingPrice, int todayPrice, bool heart)
        {
            Rank = rank;
            Id = id;
            Name = name;
            Color = color;
            ClosingPrice = closingPrice;
            TodayPrice = todayPrice;
            Heart = heart;

            double returnPrice = todayPrice - closingPrice;
            double realtime = returnPrice / closingPrice * 100;

            Plus = realtime > 0;
        }

        public int Rank { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int ClosingPrice { get; set; }
        public int TodayPrice { get; set; }
        public bool Heart { get; set; }
        public bool Plus { get; set; }
    }
}
