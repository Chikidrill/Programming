using Programming.Model.Classes;
class Song
{
    private string _songName;
    private string _artistName;
    private string _labelName;
    private int _durationSeconds;
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
    public Song(string songName, string artistName, string labelName, int durationSeconds)
    {
        SongName = songName;
        ArtistName = artistName;
        LabelName = labelName;
        DurationSeconds = durationSeconds;
    }
    public Song() { }
}