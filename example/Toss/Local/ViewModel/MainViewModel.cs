using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using Toss.Local.Command;
using Toss.Local.Model;

namespace Toss.Local.ViewModel
{
    internal class MainViewModel
    {
        // 하트 커맨드
        public ICommand HeartCommand { get; }

        // 주식종목 리스트
        public List<Stock> Stocks { get; }

        public MainViewModel()
        {
            // 하트 커맨드바인딩 연결
            HeartCommand = new TossCommand<Stock>(HeartChecked);

            // 임시 데이터 생성
            List<Stock> stocks = new();
            stocks.Add(new Stock(1, "TSLA", "테슬라", "#F2121E", 1209010, 1279359, false));
            stocks.Add(new Stock(2, "MSFT", "마이크로소프트", "#263961", 347000, 338810, true));
            stocks.Add(new Stock(3, "TWTR", "트위터", "#4B98D3", 58199, 60497, true));
            stocks.Add(new Stock(4, "AMZN", "아마존", "#37404F", 3662201, 3569486, false));
            stocks.Add(new Stock(5, "GTLB", "깃랩", "#3B0E77", 59502, 59545, true));
            Stocks = stocks;
        }

        private void HeartChecked(Stock item)
        {
            // 커맨드바인딩 Execute 부분
            _ = item.Heart;
        }
    }
}
