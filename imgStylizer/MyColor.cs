class MyColor : IComparable<MyColor>
{
    public Color Color { get; set; }
    public int value { get; }

    public MyColor(Color color)
    {
        Color = color;
        value = Color.R * 256 * 256 + Color.B * 256 + Color.G;
    }
    public int CompareTo(MyColor? other)
    {
        /*
        if(value < other.value)
        {
            return -1;
        } else if(value > other.value)
        {
            return 1;
        } else
        {
            return 0;
        }
        */
        return this.value.CompareTo(other.value);
    }
}
