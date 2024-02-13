class Film
{
    private string Title
    {
        get
        {
            return Title;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty or null");
            Title = value;
        }
    }
    private int DurationMinutes
    {
        get
        {
            return DurationMinutes;
        }
        set
        {
            DurationMinutes = value;
        }
    }
    private int ReleaseYear
    {
        get
        {
            return ReleaseYear;
        }
        set
        {
            ReleaseYear = value;
        }
    }
    private string Genre
    {
        get
        {
            return Genre;
        }
        set
        {
            Genre = value;
        }
    }
    private double Rating
    {
        get
        {
            return Rating;
        }
        set
        {
            Rating = value;
        }
    }
}