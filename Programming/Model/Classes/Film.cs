using Programming.Model.Classes;
/// <summary>
/// Хранит данные о фильме - название, длительность в минутах, год выпуска, жанр, рейтинг.
/// </summary>
class Film
{
    /// <summary>
    /// Название фильма для каждого объекта класса.
    /// </summary>
    private string _title;
    /// <summary>
    /// Длительность фильма в минутах каждого объекта класса.
    /// </summary>
    private int _durationMinutes;
    /// <summary>
    /// Год выпуска фильма каждого объекта класса.
    /// </summary>
    private int _releaseYear;
    /// <summary>
    /// Рейтинг фильма каждого объекта класса.
    /// </summary>
    private double _rating;

    /// <summary>
    /// Вовзвращает и задает название фильма. Не может быть пустым полем.
    /// </summary>
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
    /// <summary>
    /// Возвращает и задает длительность фильма. Должно состоять только из целого числа, больше 0.
    /// </summary>
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
    /// <summary>
    /// Возвращает и задает год выпуска фильма в промежутке от 1900 года до 2024 года.
    /// </summary>
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
    /// <summary>
    /// Возвращает и задаёт жанр фильма из перечисления Genre.
    /// </summary>
    public Genres Genre { get; set; }
    /// <summary>
    /// Возвращает и задаёт рейтинг фильма. Рейтинг должен быть типа double, и больше 0.
    /// </summary>
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
    /// <summary>
    /// Создаёт экземпляр класс <see cref="Film"/>
    /// </summary>
    /// <param name="title">Название фильма. Не может быть пустым</param>
    /// <param name="durationMinutes">Длительность в минутах. Должно быть целым числом, больше 0.</param>
    /// <param name="releaseYear">Год выпуска фильма. В промежутке от 1900 до 2024 гг.</param>
    /// <param name="genre">Жанр фильма.</param>
    /// <param name="rating">Рейтинг фильма. Число типа double, больше 0.</param>
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