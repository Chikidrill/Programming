class Song
{
    private string SongName
    {
        get
        {
            return SongName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name of song cannot be empty or null");
            SongName = value;
        }
    }
    private string ArtistName
    {
        get
        {
            return ArtistName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Artist name cannot be empty or null");
            ArtistName = value;
        }
    }
    private string LabelName
    {
        get
        {
            return LabelName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Label name cannot be empty or null");
            LabelName = value;
        }
    }
    private int DurationSeconds
    {
        get
        {
            return DurationSeconds;
        }
        set
        {
            if ((value == null) || (value < 0))
                throw new ArgumentException("Duration cannot be empty or <  0");
            DurationSeconds = value;
        }
    }
}