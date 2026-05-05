class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int remainingTime)
    {
        return ExpectedMinutesInOven() - remainingTime;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int lasagnaLayers)
    {
        return lasagnaLayers * 2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layersInLasagna, int time)
    {
        return time + PreparationTimeInMinutes(layersInLasagna);
    }
}


class Program
{
    public  void Main(string[] args)
    {
        Lasagna lasagna = new Lasagna();
        
        lasagna.ExpectedMinutesInOven();
        lasagna.RemainingMinutesInOven(30);
        lasagna.PreparationTimeInMinutes(2);
        lasagna.ElapsedTimeInMinutes(3, 20);
    }
}