# WPF 토스 앱


## Stock 모델

```csharp
internal class Stock
{
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
