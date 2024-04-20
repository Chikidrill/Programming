using Programming.Model.Classes;
/// <summary>
/// Хранит данные об учебной дисциплине - название дисциплины, кол-во занятий в неделю, имя преподавателя.
/// </summary>
class Subject
{
    /// <summary>
    /// Название дисциплины для каждого экземпляра класса.
    /// </summary>
    private string _subjectName;
    /// <summary>
    /// Количество занятий в неделю для каждого экземпляра класса.
    /// </summary>
    private int _numOfLessonsWeek;
    /// <summary>
    /// Имя учителя для каждого экземпляра класса.
    /// </summary>
    private string _teacherName;
    /// <summary>
    /// Возвращает и задаёт название дисциплины. Не может быть пустой строкой.
    /// </summary>
    public string SubjectName
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
    /// <summary>
    /// Возвращает и задаёт количество занятий в неделю. Целое число, большее 0.
    /// </summary>
    public int NumOfLessonsWeek
    {
        get
        {
            return _numOfLessonsWeek;
        }
        set
        {
            Validator.AssertOnPositiveValue(value, nameof(NumOfLessonsWeek));
            _numOfLessonsWeek = value;
        }
    }
    /// <summary>
    /// Возвращает и задаёт имя учителя. Не может быть пустой строкой.
    /// </summary>
    public string TeacherName
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
    /// <summary>
    /// Создаёт экземпляр класса <see cref="Subject"/>
    /// </summary>
    /// <param name="subjectName">Название дисциплины. Не может быть пустой строкой.</param>
    /// <param name="numOfLessonsWeek">Количество занятий в неделю. Целое число, большее 0.</param>
    /// <param name="teacherName">Имя учителя. Не может быть пустой строкой.</param>
    public Subject(string subjectName, int numOfLessonsWeek, string teacherName)
    {
        SubjectName = subjectName;
        NumOfLessonsWeek = numOfLessonsWeek;
        TeacherName = teacherName;
    }
    public Subject() { }
}