using System.Collections.Generic;
using System.Windows.Input;
using TossBinding.Local.Foundation;
using TossBinding.Local.Model;

namespace TossBinding.Local.ViewModel
{
    public class MainViewModel
    {
        public ICommand HeartClick { get; }

        public string ContentsTitle { get; }

        public List<Stock> Stocks { get; }

        public MainViewModel()
        {
            ContentsTitle = "실시간 Top100";

            List<Stock> stocks = new();
            stocks.Add(new Stock(1, "TSLA", "테슬라", "#F2121E", 1209010, 1279359, false));
            stocks.Add(new Stock(2, "MSFT", "마이크로소프트", "#263961", 347000, 338810, true));
            stocks.Add(new Stock(3, "TWTR", "트위터", "#4B98D3", 58199, 60497, true));
            stocks.Add(new Stock(4, "AMZN", "아마존", "#37404F", 3662201, 3569486, false));
            stocks.Add(new Stock(5, "GTLB", "깃랩", "#3B0E77", 59502, 59545, true));

            Stocks = stocks;

            HeartClick = new HeartCommand<Stock>(HeartChanged);
        }

        private void HeartChanged(Stock heartValue)
        {
            // DB 처리 (Heart)
        }
    }
}
