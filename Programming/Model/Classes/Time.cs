using Programming.Model.Classes;
/// <summary>
/// Хранит данные о времени - час, минута, секунда.
/// </summary>
class Time
{
    /// <summary>
    /// Значения поля "час" для каждого экземпляра класса.
    /// </summary>
    private int _hour;
    /// <summary>
    /// Значения поля "минута" для каждого экземпляра класса.
    /// </summary>
    private int _minute;
    /// <summary>
    /// Значения поля "секунда" для каждого экземпляра класса.
    /// </summary>
    private int _second;
    /// <summary>
    /// Возвращает и задаёт значение поля "час". Значение должно быть больше 0, в промежутке от 0 до 23.
    /// </summary>
    public int Hour
    {
        get
        {
            return _hour;
        }
        set
        {
            Validator.AssertValueInRange(value, 0, 23, nameof(Hour));
            Validator.AssertOnPositiveValue(value, nameof(Hour));
            _hour = value;
        }
    }
    /// <summary>
    /// Возвращает и задаёт значение поля "минута". Значение должно быть больше 0, в промежутке от 0 до 59.
    /// </summary>
    public int Minute
    {
        get
        {
            return _minute;
        }
        set
        {
            Validator.AssertValueInRange(value, 0, 59, nameof(Minute));
            Validator.AssertOnPositiveValue(value, nameof(Minute));
            _minute = value;
        }
    }
    /// <summary>
    /// Возвращает и задаёт значение поля "секунда". Значение должно быть больше 0, в промежутке от 0 до 59.
    /// </summary>
    public int Second
    {
        get
        {
            return _second;
        }
        set
        {
            Validator.AssertValueInRange(value, 0, 59, nameof(Second));
            Validator.AssertOnPositiveValue(value, nameof(Second));
            _second = value;
        }
    }
    /// <summary>
    /// Создаёт экземпляр класса <see cref="Time"/>
    /// </summary>
    /// <param name="hour">Час. Больше 0, в промежутке от 0 до 23.</param>
    /// <param name="minute">Минута. Больше 0, в промежутке от 0 до 59.</param>
    /// <param name="second">Секунда. Больше 0, в промежутке от 0 до 59.</param>
    public Time(int hour, int minute, int second)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
    }
    public Time () { }
}