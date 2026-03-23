class Lasagna
{
    private int _timeToPrepareLayer = 2;
    
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int elapsedTime)
    {
        return ExpectedMinutesInOven() - elapsedTime;
    }

    public int PreparationTimeInMinutes(int layers)
    {
        return _timeToPrepareLayer * layers;
    }

    public int ElapsedTimeInMinutes(int layers, int elapsedTime)
    {
        return PreparationTimeInMinutes(layers) + elapsedTime;
    }
}
