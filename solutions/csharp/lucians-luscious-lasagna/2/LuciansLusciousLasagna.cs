class Lasagna
{
    private int _timeToPrepareLayer = 2;
    
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int elapsedTime) => ExpectedMinutesInOven() - elapsedTime;

    public int PreparationTimeInMinutes(int layers) => _timeToPrepareLayer * layers;

    public int ElapsedTimeInMinutes(int layers, int elapsedTime) => PreparationTimeInMinutes(layers) + elapsedTime;
}
