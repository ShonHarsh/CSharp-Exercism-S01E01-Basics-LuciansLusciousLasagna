class Lasagna
{
    public const int EXPECTED_MINUTES_IN_OVEN = 40;
    public const int PREPARATION_MINUTES_PER_LAYER = 2;

    /// <summary>
    /// Returns the expected minutes in the oven for lasagna to cook.
    /// </summary>
    /// <returns>An integer value representing the time for lasagna to cook.</returns>
    public int ExpectedMinutesInOven()
    {
        return EXPECTED_MINUTES_IN_OVEN;
    }

    /// <summary>
    /// Takes the completed and returns the remaining cooking time.
    /// </summary>
    /// <param name="minutes">An integer value representing the completed cooking time.</param>
    /// <returns>An integer value representing the remaining cooking time.</returns>
    public int RemainingMinutesInOven(int actuatlMinutesInOven)
    {
        return this.ExpectedMinutesInOven() - actuatlMinutesInOven;
    }

    /// <summary>
    /// Takes the number of layers you added to the lasagna as a parameter and
    /// returns how many minutes you spent preparing the lasagna, assuming each
    /// layer takes you 2 minutes to prepare.
    /// </summary>
    /// <param name="layers">An integer value representing the number of layers
    /// completed.</param>
    /// <returns>An integer value representing the total preparation time</returns>
    public int PreparationTimeInMinutes(int layersCompleted)
    {
        return layersCompleted * PREPARATION_MINUTES_PER_LAYER;
    }

    /// <summary>
    ///  takes two parameters: the first parameter is the number of layers you
    ///  added to the lasagna, and the second parameter is the number of
    ///  minutes the lasagna has been in the oven. The function should return
    ///  how many minutes you've worked on cooking the lasagna, which is the
    ///  sum of the preparation time in minutes, and the time in minutes the
    ///  lasagna has spent in the oven at the moment.
    /// </summary>
    /// <param name="layers">An integer value representing the number of
    /// completed layers.</param>
    /// <param name="minutes">An integer value representing the number of
    /// minutes the lasagna has been in the oven cooking.</param>
    /// <returns></returns>
    public int ElapsedTimeInMinutes(int layers, int actuatlMinutesInOven)
    {
        return this.PreparationTimeInMinutes(layers) + actuatlMinutesInOven;
    }
}
