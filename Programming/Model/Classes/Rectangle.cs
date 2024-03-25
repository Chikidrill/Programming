using Programming.Model.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

class Rectangle
{

    private double _width;
    private double _length;
    private Color _color;
    private int _centerX;
    private int _centerY;
    private int _id;
    private static int _allRectangelsCount = 0;

    Random rand = new Random();
    public Point2D Center { get; private set; }
    public double Width
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
    public double Length
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
    public Color Color { get; set; }
    public static int AllRectanglesCount()
    {
        return _allRectangelsCount;
    }

    public int ID { get => _id; }
    public Rectangle(double width, double length, Color color)
    {
        Width = width;
        Length = length;
        Color = color;

        _centerX = rand.Next(50, 150);
        _centerY = rand.Next(50, 150);
        Center = new Point2D(_centerY, _centerX);

        _allRectangelsCount++;
        _id = _allRectangelsCount;
    }
    public Rectangle() { }
}