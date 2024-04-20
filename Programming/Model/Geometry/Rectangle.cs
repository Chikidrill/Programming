using Programming.Model.Classes;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
/// <summary>
/// Хранит данные о прямоугольнике - длина, ширина, цвет, координаты центра и уникальный идентификатор.
/// </summary>
public class Rectangle
{
    /// <summary>
    /// Значение ширины для каждого экземпляра класса.
    /// </summary>
    private int _width;
    /// <summary>
    /// Значение длины для каждого экземпляра класса.
    /// </summary>
    private int _length;
    /// <summary>
    /// Значение цвета для каждого экземпляра класса из перечисления <see cref="Colour"/>
    /// </summary>
    private Colour _color;
    /// <summary>
    /// Значение координаты X центра прямоугольника для каждого экземпляра класса.
    /// </summary>
    private int _centerX;
    /// <summary>
    /// Значение координаты Y центра прямоугольника для каждого экземпляра класса.
    /// </summary>
    private int _centerY;
    /// <summary>
    /// Значение уникального идентификатора для каждого экземпляра класса.
    /// </summary>
    private int _id;
    /// <summary>
    /// Счётчик общего числа прямоугольников.
    /// </summary>
    private static int _allRectangelsCount = 0;

    Random rand = new Random();
    /// <summary>
    /// Возвращает координаты центра X и Y прямоугольника.
    /// </summary>
    public Point2D Center { get; private set; }
    /// <summary>
    /// Возвращает и задаёт ширину прямоугольника. Значение должно быть больше 0.
    /// </summary>
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
    /// <summary>
    /// Возвращает и задаёт длину прямоугольника. Значение должно быть больше 0.
    /// </summary>
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
    /// <summary>
    /// Возвращает и задаёт цвет прямоугольника из перечисления <see cref="Colour"/>.
    /// </summary>
    public Colour Color { get; set; }
    /// <summary>
    /// Возвращает общее количество прямоугольников.
    /// </summary>
    /// <returns>Общее количество прямоугольников</returns>
    public static int AllRectanglesCount()
    {
        return _allRectangelsCount;
    }
    /// <summary>
    /// Возвращает уникальный идентификатор прямоугольника.
    /// </summary>
    public int ID { get => _id; }
    /// <summary>
    /// Создаёт экземпляр класса <see cref="Rectangle"/>.
    /// </summary>
    /// <param name="width">Ширина прямоугольника. Значение должно быть больше 0.</param>
    /// <param name="length">Длина прямоугольника. Значение должно быть больше 0.</param>
    /// <param name="color">Цвет прямоугольника.</param>
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