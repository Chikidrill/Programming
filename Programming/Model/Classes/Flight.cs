using Programming.Model.Classes;
/// <summary>
/// Хранит данные о полётё - точка отправления, прибытия, а также длительность полёта в минутах.
/// </summary>
class Flight
{
    /// <summary>
    /// Точка отправления для каждого объекта класса.
    /// </summary>
    private string _departurePoint;
    /// <summary>
    /// Точка назначения для каждого объекта класса.
    /// </summary>
    private string _destinationPoint;
    /// <summary>
    /// Время полёта для каждого объекта класса.
    /// </summary>
    private int _flightMinutes;
    /// <summary>
    /// Возвращает и задаёт точку отправления. Не может быть пустым полем.
    /// </summary>
    public string DeparturePoint
    {
        get
        {
            return _departurePoint;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Departure point cannot be empty or null");
            _departurePoint = value;
        }
    }
    /// <summary>
    /// Возвращает и задаёт точку прибытия. Не может быть пустым полем.
    /// </summary>
    public string DestinationPoint
    {
        get
        {
            return _destinationPoint;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Destination point cannot be empty or null");
            _destinationPoint = value;
        }
    }
    /// <summary>
    /// Возвращает и задаёт время полёта. Должно быть целым числом, больше 0..
    /// </summary>
    public int FlightMinutes
    {
        get
        {
            return _flightMinutes;
        }
        set
        {
            Validator.AssertOnPositiveValue(value, nameof(FlightMinutes));
            _flightMinutes = value;
        }
    }
    /// <summary>
    /// Создаёт экземпляр класса <see cref="Flight"/>
    /// </summary>
    /// <param name="departurePoint">Точка отправления. Не может быть пустым.</param>
    /// <param name="destinationPoint">Точка назначения. Не может быть пустым.</param>
    /// <param name="flightMinutes">Время полёта. Должно быть целым числом, больше 0.</param>
    public Flight(string departurePoint, string destinationPoint, int flightMinutes)
    {
        DeparturePoint = departurePoint;
        DestinationPoint = destinationPoint;
        FlightMinutes = flightMinutes;
    }
    public Flight() { }
}