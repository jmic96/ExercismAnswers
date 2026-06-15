using System;

class RemoteControlCar
{
    public int Speed { get; set; }
    public int BatteryDrain { get; set; }
    public int MetersDriven { get; set; }
    public int BatteryLife { get; set; } = 100;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        Speed = speed;
        BatteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        return BatteryLife < BatteryDrain;
    }

    public int DistanceDriven()
    {
        return MetersDriven;
    }

    public void Drive()
    {
        if (BatteryLife >= BatteryDrain)
        {
            MetersDriven += Speed;
            BatteryLife -= BatteryDrain;
        }
    }

    public static RemoteControlCar Nitro(int speed = 50, int batteryDrain = 4)
    {
        return new RemoteControlCar(speed, batteryDrain);
    }
}

class RaceTrack
{
    public int Distance { get; set; }

    public RaceTrack(int distance)
    {
        Distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        int maxDistance = (car.BatteryLife / car.BatteryDrain) * car.Speed;

        if (Distance <= maxDistance)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}