using Programming.Model.Classes;
/// <summary>
/// Хранит данные о песне - название песни, имя артиста, название лейбла, длительность песни в секундах.
/// </summary>
class Song
{
    /// <summary>
    /// Название песни для каждого объекта класса.
    /// </summary>
    private string _songName;
    /// <summary>
    /// Имя артиста для каждого объекта класса.
    /// </summary>
    private string _artistName;
    /// <summary>
    /// Название лейбла, выпустившего песню, для каждого объекта класса.
    /// </summary>
    private string _labelName;
    /// <summary>
    /// Длительность песни в секундах для каждого объекта класса.
    /// </summary>
    private int _durationSeconds;
    /// <summary>
    /// Возвращает и задаёт название песни. Не может быть пустым полем.
    /// </summary>
    public string SongName
    {
        get
        {
            return _songName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name of song cannot be empty or null");
            _songName = value;
        }
    }
    /// <summary>
    /// Возвращает и задаёт имя артиста. Не может быть пустым полем.
    /// </summary>
    public string ArtistName
    {
        get
        {
            return _artistName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Artist name cannot be empty or null");
            _artistName = value;
        }
    }
    /// <summary>
    /// Возвращает и задаёт название лейбла. Не может быть пустым полем.
    /// </summary>
    public string LabelName
    {
        get
        {
            return _labelName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Label name cannot be empty or null");
            _labelName = value;
        }
    }
    /// <summary>
    /// Возвращает и задаёт длительность песни в секундах. Должно быть целым числом, больше 0.
    /// </summary>
    public int DurationSeconds
    {
        get
        {
            return _durationSeconds;
        }
        set
        {
            Validator.AssertOnPositiveValue(value, nameof(DurationSeconds));
            _durationSeconds = value;
        }
    }
    /// <summary>
    /// Создаёт экзмепляр класса <see cref="Song"/>
    /// </summary>
    /// <param name="songName">Название песни.Не может бытьп пустым.</param>
    /// <param name="artistName">Имя артиста. Не может быть пустым.</param>
    /// <param name="labelName">Название лейбла. Не может быть пустым</param>
    /// <param name="durationSeconds">Длительность песни в секундах. Должно быть целым числом, больше 0.</param>
    public Song(string songName, string artistName, string labelName, int durationSeconds)
    {
        SongName = songName;
        ArtistName = artistName;
        LabelName = labelName;
        DurationSeconds = durationSeconds;
    }
    public Song() { }
}