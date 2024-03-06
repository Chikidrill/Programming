class Film
{
    private string _title;
    private int _durationMinutes;
    private int _releaseYear;
    private double _rating;
    public string Title
    {
        get
        {
            return _title;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Title cannot be empty or null");
            _title = value;
        }
    }
    public int DurationMinutes
    {
        get
        {
            return _durationMinutes;
        }
        set
        {
            if ((value == null) || (value < 0))
                throw new ArgumentException("Duration cannot be empty or <  0");
            _durationMinutes = value;
        }
    }
    public int ReleaseYear
    {
        get
        {
            return _releaseYear;
        }
        set
        {
            if ((value == null) || (value < 0) || (value > 2024))
                throw new ArgumentException("Release year cannot be empty or <  0 or > 2024");
            _releaseYear = value;
        }
    }
    public Genres Genre { get; set; }
    public double Rating
    {
        get
        {
            return _rating;
        }
        set
        {
            _rating = value;
        }
    }
    public Film(string title, int durationMinutes, int releaseYear, Genres genre, double rating)
    {
        Title = title;
        DurationMinutes = durationMinutes;
        ReleaseYear = releaseYear;
        Genre = genre;
        Rating = rating;
    }
    public Film() { }
}