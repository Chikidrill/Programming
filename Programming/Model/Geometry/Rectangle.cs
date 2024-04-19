using Programming.Model.Classes;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

public class Rectangle
{

    private int _width;
    private int _length;
    private Colour _color;
    private int _centerX;
    private int _centerY;
    private int _id;
    private static int _allRectangelsCount = 0;

    Random rand = new Random();
    public Point2D Center { get; private set; }

    public int Width
    {
        get
        {
            return _width;
        }
        set
        {
            Validator.AssertOnPositiveValue(value, nameof(Width));
            _width = value;
        }
    }
    public int Length
    {
        get
        {
            return _length;
        }
        set
        {
            Validator.AssertOnPositiveValue(value, nameof(Length));
            _length = value;
        }
    }
    public Colour Color { get; set; }
    public static int AllRectanglesCount()
    {
        return _allRectangelsCount;
    }

    public int ID { get => _id; }
    public override string ToString()
    {
        return $"{ID}: (X={Center.coord_X}; Y={Center.coord_Y}; W={Width}; L={Length})";
    }

    public Rectangle(int width, int length, Colour color)
    {
        Width = width;
        Length = length;
        Color = color;

        _centerX = rand.Next(50, 150);
        _centerY = rand.Next(50, 150);
        Center = new Point2D(_centerX, _centerY);

        _allRectangelsCount++;
        _id = _allRectangelsCount;
    }
    public Rectangle() { }
}