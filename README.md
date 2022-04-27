# WPF 토스 앱


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
