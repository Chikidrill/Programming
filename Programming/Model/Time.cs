class Time
{
    private int Hour
    {
        get
        {
            return Hour;
        }
        set
        {
            if ((value < 0) || (value > 12))
                throw new ArgumentException("Hour cannot be empty or <  0  and cannot be >12");
            Hour = value;
        }
    }
    private int Minute
    {
        get
        {
            return Minute;
        }
        set
        {
            if ((value < 0) || (value > 59))
                throw new ArgumentException("Minutes cannot be empty or <  0 and cannot be >59");
            Minute = value;
        }
    }
    private int Second
    {
        get
        {
            return Second;
        }
        set
        {
            if ((value < 0) || (value > 59))
                throw new ArgumentException("Seconds cannot be empty or <  0 and cannot be >59");
            Second = value;
        }
    }
}