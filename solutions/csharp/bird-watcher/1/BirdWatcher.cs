class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] {0, 2, 5, 3, 7, 8, 4};
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1] += 1;
    }

    public bool HasDayWithoutBirds()
    {
        bool noBirds = false;
        foreach(int count in birdsPerDay)
        {
            if (count == 0)
                noBirds = true;
        }

        return noBirds;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        if (numberOfDays > birdsPerDay.Length)
            return 0;

        int count = 0;

        for(int i = 0; i < numberOfDays; i++)
            count += birdsPerDay[i];

        return count;
    }

    public int BusyDays()
    {
        int busyDays = 0;

        foreach(int count in birdsPerDay)
        {
            if (count >= 5)
                busyDays += 1;
        }

        return busyDays;
    }
}
