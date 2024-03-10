class Time
{
    private int _hour;
    private int _minute;
    private int _second;

    private int Hour
    {
        get
        {
            return _hour;
        }
        set
        {
            if ((value < 0) || (value > 12))
                throw new ArgumentException("Hour cannot be empty or <  0  and cannot be >12");
            _hour = value;
        }
    }
    private int Minute
    {
        get
        {
            return _minute;
        }
        set
        {
            if ((value < 0) || (value > 59))
                throw new ArgumentException("Minutes cannot be empty or <  0 and cannot be >59");
            _minute = value;
        }
    }
    private int Second
    {
        get
        {
            return _second;
        }
        set
        {
            if ((value < 0) || (value > 59))
                throw new ArgumentException("Seconds cannot be empty or <  0 and cannot be >59");
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