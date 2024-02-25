class Rectangle
{
    private double Width
    {
        get
        {
            return Width;
        }
        set
        {
            if ((value == null) || (value < 0))
                throw new ArgumentException("Width be empty or <  0");
            Width = value;
        }
    }
    private double Height
    {
        get
        {
            return Height;
        }
        set
        {
            if ((value == null) || (value < 0))
                throw new ArgumentException("Height cannot be empty or <  0");
            Height = value;
        }
    }
    private string Colour
    {
        get
        {
            return Colour;
        }
        set 
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Colour cannot be empty or null");
            Colour = value;
        }
    }
}