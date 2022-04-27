# Toss 코드조각
반복 작업을 줄이기 위해 필요한 주요 코드조각 모음입니다.

- [DefaultStyleKeyProperty](#defaultstylekeyproperty)
- [Template 양식](#template-양식)
- [Stock 모델](#stock-모델)
- [주식 종목 데이터 생성](#주식-종목-데이터-생성)
- [실시간 Top100 템플릿](#실시간-top100-템플릿)
- [주식종목 이미지](#)
- [미국 국기 스타일](#미국-국기-)
- [Rank TextBlock 스타일](#rank-textblock-스타일)
- [Name TextBlock 스타일](#)

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

## 주식 종목 이미지
| TSLA | MSFT | TWTR | AMZN | GTLB |
|:----:|:----:|:----:|:----:|:----:|
| ![tsla](https://user-images.githubusercontent.com/52397976/165555756-6f739738-7df8-449a-9000-c34be9fd5447.png) | ![msft](https://user-images.githubusercontent.com/52397976/165555859-33017fd4-69b3-4979-9431-636c181c4a2f.png) | ![twtr](https://user-images.githubusercontent.com/52397976/165555907-7ca0074f-7e52-436f-9aa4-947af04c64c3.png) | ![amzn](https://user-images.githubusercontent.com/52397976/165555947-a6fa7ba0-23c2-46b9-8b6a-5cf018ece0ca.png) | ![gtlb](https://user-images.githubusercontent.com/52397976/165555984-e65c9b83-4763-4927-93f9-42429ced1dcb.png) |

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

## Name TextBlock 스타일

```xaml
<StackPanel Grid.Column="2"
            VerticalAlignment="Top"
            Margin="20">
    <TextBlock Text="테슬라"
               Foreground="#C6C5C9"
               FontFamily="나눔고딕"
               FontWeight="SemiBold"
               FontSize="18"
               Margin="0 0 0 4"/>
    <StackPanel Grid.Column="2" 
                VerticalAlignment="Bottom"
                Orientation="Horizontal">
        <TextBlock Text="1279359"
                   Foreground="#9D9CA2"
                   FontSize="15"/>
        <TextBlock x:Name="realtime" 
                   Text="+5.8%"
                   Foreground="#4c73b4"
                   FontSize="15"
                   Margin="2 0 0 0"/>
    </StackPanel>
</StackPanel>
```

## 미국 국기 스타일
```xaml
<Border Grid.Column="1"
        Width="16" Height="12"
        HorizontalAlignment="Right"
        VerticalAlignment="Bottom"
        UseLayoutRounding="True"
        SnapsToDevicePixels="True"
        BorderBrush="#151515"
        BorderThickness="1"
        CornerRadius="1"
        Margin="0 0 0 6">
    <Border.Background>
        <ImageBrush ImageSource="/Toss;component/Images/usa.png"
                    RenderOptions.BitmapScalingMode="HighQuality"/>
    </Border.Background>
</Border>
```
