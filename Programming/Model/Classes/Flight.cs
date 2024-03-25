using Programming.Model.Classes;
class Flight
{
    private string _departurePoint;
    private string _destinationPoint;
    private int _flightMinutes;
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
    public Flight(string departurePoint, string destinationPoint, int flightMinutes)
    {
        DeparturePoint = departurePoint;
        DestinationPoint = destinationPoint;
        FlightMinutes = flightMinutes;
    }
    public Flight() { }
}