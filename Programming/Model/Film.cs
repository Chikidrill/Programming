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
                throw new ArgumentException("Title cannot be empty or null");
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
            if ((value == null) || (value < 0))
                throw new ArgumentException("Duration cannot be empty or <  0");
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
            if ((value == null) || (value < 0) || (value > 2024))
                throw new ArgumentException("Release year cannot be empty or <  0 or > 2024");
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
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Genre cannot be empty or null");
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
            if ((value < 0) || (value >5.0))
                throw new ArgumentException("Rating cannot be <0 and >5.0");
            Rating = value;
        }
    }
}