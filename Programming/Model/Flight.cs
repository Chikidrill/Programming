class Flight
{
    private string _departurePoint
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
    private string _destinationPoint
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
    private int _flightMinutes
    {
        get
        {
            return _flightMinutes;
        }
        set
        {
            if ((value <0))
                throw new ArgumentException("Duration of flight cannot be < 0 ");
            _flightMinutes = value;
        }
    }
    public Flight(string DeparturePoint, string DestinationPoint, int FlightMinutes)
    {
        _departurePoint = DeparturePoint;
        _destinationPoint = DestinationPoint;
        _flightMinutes = FlightMinutes;
    }
}