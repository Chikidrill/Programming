class Subject
{
    private string SubjectName
    {
        get
        {
            return SubjectName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Subject name cannot be empty or null");
            SubjectName = value;
        }
    }
    private int NumOfLessonsWeek
    {
        get
        {
            return NumOfLessonsWeek;
        }
        set
        {
            if ((value == null) || (value < 0))
                throw new ArgumentException("Number of lessons cannot be empty or <  0");
            NumOfLessonsWeek = value;
        }
    }
    private string TeacherName
    {
        get
        {
            return TeacherName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Teacher name cannot be empty or null");
            TeacherName = value;
        }
    }
}