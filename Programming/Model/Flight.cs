class Flight
{
    private string DeparturePoint
    {
        get
        {
            return DeparturePoint;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Departure point cannot be empty or null");
            DeparturePoint = value;
        }
    }
    private string DestinationPoint
    {
        get
        {
            return DestinationPoint;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Destination point cannot be empty or null");
            DestinationPoint = value;
        }
    }
    private int FlightMinutes
    {
        get
        {
            return FlightMinutes;
        }
        set
        {
            if ((value <0))
                throw new ArgumentException("Duration of flight cannot be < 0 ");
            FlightMinutes = value;
        }
    }
}