class RemoteControlCar
{
    private int distance = 0;
    private int percentage = 100;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {distance} meters";
    }

    public string BatteryDisplay()
    {
        if (percentage ==0)
        {
            return "Battery empty";
        }
        return $"Battery at {percentage}%";
    }

    public void Drive()
    {
        if (percentage > 0)
        {
            distance +=20;
            percentage -=1;
        }
    }
        
}
