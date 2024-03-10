class Rectangle
{

    private double _width;
    private double _length;
    private Color _color;


    public double Width
    {
        get
        {
            return _width;
        }
        set
        {
            if ((value == null) || (value < 0))
                throw new ArgumentException("Width be empty or <  0");
            _width = value;
        }
    }
    public double Length
    {
        get
        {
            return _length;
        }
        set
        {
            if ((value == null) || (value < 0))
                throw new ArgumentException("Height cannot be empty or <  0");
            _length = value;
        }
    }
    public Color Color { get; set; }
    public Rectangle(double width, double length, Color color)
    {
        Width = width;
        Length = length;
        Color = color;
    }
    public Rectangle() { }
}