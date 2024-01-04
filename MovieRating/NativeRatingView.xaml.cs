namespace MovieRating;

public partial class NativeRatingView : ContentView
{
	public NativeRatingView()
	{
		InitializeComponent();
	}
    
    public int Value { get; set; }

    public BindableProperty ColorProperty =
        BindableProperty.Create(nameof(Color), typeof(Color), typeof(NativeRatingView), Color.Parse("Yellow"));

    public Color StarColor
    {
        get { return (Color)GetValue(ColorProperty); }
        set { SetValue(ColorProperty, value); }
    }
    void Clear()
    {
        FirstStarPolygon.Fill = Color.Parse("Gray");
        SecondStarPolygon.Fill = Color.Parse("Gray");
        ThirdStarPolygon.Fill = Color.Parse("Gray");
        FourthStarPolygon.Fill = Color.Parse("Gray");
        FifthStarPolygon.Fill = Color.Parse("Gray");
    }
    private void OnFirstStarClicked(object sender, EventArgs e)
    {
        Clear();
        FirstStarPolygon.Fill = StarColor;
        Value = 1;
    }
    private void OnSecondStarClicked(object sender, EventArgs e)
    {
        Clear();
        OnFirstStarClicked(sender, e);
        SecondStarPolygon.Fill = StarColor;
        Value = 2;
    }

    private void OnThirdStarClicked(object sender, EventArgs e)
    {
        Clear();
        OnSecondStarClicked(sender, e);
        ThirdStarPolygon.Fill = StarColor;
        Value = 3;
    }
    private void OnFourthStarClicked(object sender, EventArgs e)
    {
        Clear();
        OnThirdStarClicked(sender, e);
        FourthStarPolygon.Fill = StarColor;
        Value = 4;
    }
    private void OnFifthStarClicked(object sender, EventArgs e)
    {
        Clear();
        OnFourthStarClicked(sender, e);
        FifthStarPolygon.Fill = StarColor;
        Value = 5;
    }
    private void OnColorChanged(object sender, ValueChangedEventArgs e)
    {
        byte red = (byte)redSlider.Value;
        byte green = (byte)greenSlider.Value;
        byte blue = (byte)blueSlider.Value;

        Color selectedColor = Color.FromRgb(red, green, blue);
        colorPreview.Color = selectedColor;
        StarColor = selectedColor;

        switch (Value)
        {
            case 1:
                OnFirstStarClicked(sender, e);
                break;
            case 2:
                OnSecondStarClicked(sender, e);
                break;
            case 3:
                OnThirdStarClicked(sender, e);
                break;
            case 4:
                OnFourthStarClicked(sender, e);
                break;
            case 5:
                OnFifthStarClicked(sender, e);
                break;
        }
    }

    private void OnClickedButton(object sender, EventArgs e)
    {
        if (redSlider.IsVisible == true)
        {
            redSlider.IsVisible = false;
            greenSlider.IsVisible = false;
            blueSlider.IsVisible = false;
            colorPreview.IsVisible = false;
        }
        else
        {
            redSlider.IsVisible = true;
            greenSlider.IsVisible = true;
            blueSlider.IsVisible = true;
            colorPreview.IsVisible = true;
        }
    }
}