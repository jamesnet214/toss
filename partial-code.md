# Toss 코드조각
반복 작업을 줄이기 위해 필요한 주요 코드조각 모음입니다.

- [DefaultStyleKeyProperty](#defaultstylekeyproperty)
- [Template 양식](#template-양식)
- [Stock 모델](#stock-모델)
- [주식 종목 데이터 생성](#주식-종목-데이터-생성)
- [실시간 Top100 템플릿](#실시간-top100-템플릿)
- [Rank TextBlock 스타일](#rank-textblock-스타일)
- 이미지
- [미국 국기 스타일](#미국-국기-)

## DefaultStyleKeyProperty
Themes 폴더에 포함된 리소스를 연결하기 위한 구문입니다.
```csharp
#region DefaultStyleKey

static 컨트롤()
{
    DefaultStyleKeyProperty.OverrideMetadata(typeof(컨트롤), new FrameworkPropertyMetadata(typeof(컨트롤)));
}
#endregion
```

## Template 양식
ContentControl 기반 컨트롤의 기본 스타일 양식입니다.
```xaml
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
토스 주식 목록 데이터 모델 및 생성자 구현 부분입니다.

```csharp
internal class Stock
{
    public int Rank { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public double LiveValue { get; set; }
    public double PastValue { get; set; }
    public bool Heart { get; set; }

    public Stock(
        int _rank, 
        string _code, 
        string _name, 
        string _color, 
        double _liveValue, 
        double _pastValue, 
        bool _heart)
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
```

## 주식 종목 데이터 생성
주식 종목 임시 데이터를 생성하는 부분입니다.
```csharp
List<Stock> stocks = new();
stocks.Add(new Stock(1, "TSLA", "테슬라", "#F2121E", 1209010, 1279359, false));
stocks.Add(new Stock(2, "MSFT", "마이크로소프트", "#263961", 347000, 338810, true));
stocks.Add(new Stock(3, "TWTR", "트위터", "#4B98D3", 58199, 60497, true));
stocks.Add(new Stock(4, "AMZN", "아마존", "#37404F", 3662201, 3569486, false));
stocks.Add(new Stock(5, "GTLB", "깃랩", "#3B0E77", 59502, 59545, true));
```

## 실시간 Top100 템플릿
```xaml
<Style TargetType="{x:Type 컨트롤}">
    <Setter Property="BorderBrush" Value="#FFFFFF"/>
    <Setter Property="BorderThickness" Value="0 0 0 1"/>
    <Setter Property="Padding" Value="20"/>
    <Setter Property="FontSize" Value="18"/>
    <Setter Property="FontWeight" Value="SemiBold"/>
    <Setter Property="HorizontalContentAlignment" Value="Center"/>
    <Setter Property="Template">
        <Setter.Value>
            <ControlTemplate TargetType="{x:Type 컨트롤}">
                <Border>
                    <ContentPresenter/>
                </Border>
            </ControlTemplate>
        </Setter.Value>
    </Setter>
</Style>
```

## Rank TextBlock 스타일

```xaml
HorizontalAlignment="Center"
VerticalAlignment="Center"
Foreground="#2464C6"
FontWeight="Bold"
FontSize="18"
Margin="20"
```

## 미국 국기 스타일
```xaml
<Border Grid.Column="1"
        HorizontalAlignment="Right"
        VerticalAlignment="Bottom"
        UseLayoutRounding="True"
        SnapsToDevicePixels="True"
        BorderBrush="#151515"
        BorderThickness="1"
        CornerRadius="1"
        Width="16" Height="12">
    <Border.Background>
        <ImageBrush ImageSource="/TossBinding;component/Themes/Images/Nation/usa.png"
                    RenderOptions.BitmapScalingMode="HighQuality"/>
    </Border.Background>
</Border>
```
