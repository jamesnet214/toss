using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toss.Local.Model
{
    internal class Stock
    {
        // 순위 (1, 2, ...)
        public int Rank { get; set; }
        // 코드 (주식종목코드: TSLA, MSFT, TWTR, AMZN, GTLB)
        public string Code { get; set; }
        // 이름 (테슬라, 마이크로소프트, ...)
        public string Name { get; set; }
        // 시그니쳐 컬러코드 (#F2121E, #263961, ...)
        public string Color { get; set; }
        // 주식 현재 가격
        public double LiveValue { get; set; }
        // 주식 어제 가격
        public double PastValue { get; set; }
        // 하트 (즐겨찾기 여부: True, False)
        public bool Heart { get; set; }

        public Stock(int _rank, string _code, string _name, string _color, double _liveValue, double _pastValue, bool _heart)
        {
            Rank = _rank;
            Code = _code;
            Name = _name;
            Color = _color;
            LiveValue = _liveValue;
            PastValue = _pastValue;
            Heart = _heart;
        }
    }
}
