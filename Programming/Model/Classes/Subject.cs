class Subject
{
    private string _subjectName
    {
        get
        {
            return _subjectName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Subject name cannot be empty or null");
            _subjectName = value;
        }
    }
    private int _numOfLessonsWeek
    {
        get
        {
            return _numOfLessonsWeek;
        }
        set
        {
            if ((value == null) || (value < 0))
                throw new ArgumentException("Number of lessons cannot be empty or <  0");
            _numOfLessonsWeek = value;
        }
    }
    private string _teacherName
    {
        get
        {
            return _teacherName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Teacher name cannot be empty or null");
            _teacherName = value;
        }
    }
    public Subject(string SubjectName, int NumOfLessonsWeek, string TeacherName)
    {
        _subjectName = SubjectName;
        _numOfLessonsWeek = NumOfLessonsWeek;
        _teacherName = TeacherName;
    }
}