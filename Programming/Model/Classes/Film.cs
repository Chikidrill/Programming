using Programming.Model.Classes;
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
            Validator.AssertOnPositiveValue(value, nameof(DurationMinutes));
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
            Validator.AssertValueInRange(value,1900,2024, nameof(ReleaseYear));
            Validator.AssertOnPositiveValue(value, nameof(ReleaseYear));
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
            Validator.AssertOnPositiveValue(value, nameof(Rating));
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