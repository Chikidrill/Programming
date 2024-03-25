using Programming.Model.Classes;
class Time
{
    private int _hour;
    private int _minute;
    private int _second;

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
    public Time(int hour, int minute, int second)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
    }
    public Time () { }
}