# WPF 토스 앱


## 기본 ContentControl 기반 Tempalte
```
<Style TargetType="{x:Type 컨트롤}">
    <Setter Property="Template">
        <Setter.Value>
            <ControlTemplate TargetType="{x:Type 컨트롤}">
                <!-- 내용 -->
            </ControlTemplate>
        </Setter.Value>
    </Setter>
</Style>
```

## Stock 모델

```csharp
internal class Stock
{
    // 순위 1
    // 코드 TSLA
    // 이름 테슬라
    // 가격 (오늘) 1279359
    // 가격 (어제) 1269359
    // 하트 true/false

    public int Rank { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public double LiveValue { get; set; }
    public double PastValue { get; set; }
    public bool Heart { get; set; }
    
    public Stock(int _rank, string _code, string _name, double _liveValue, double _pastValue, bool _heart)
    {
        Rank = _rank;
        Code = _code;
        Name = _name;
        LiveValue = _liveValue;
        PastValue = _pastValue;
        Heart = _heart;
    }
}
```

## 주식 목록 데이터 생성
```csharp
List<Stock> stocks = new();
stocks.Add(new Stock(1, "TSLA", "테슬라", "#F2121E", 1209010, 1279359, false));
stocks.Add(new Stock(2, "MSFT", "마이크로소프트", "#263961", 347000, 338810, true));
stocks.Add(new Stock(3, "TWTR", "트위터", "#4B98D3", 58199, 60497, true));
stocks.Add(new Stock(4, "AMZN", "아마존", "#37404F", 3662201, 3569486, false));
stocks.Add(new Stock(5, "GTLB", "깃랩", "#3B0E77", 59502, 59545, true));
```
