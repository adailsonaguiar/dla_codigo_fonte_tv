public static class Day4
{
    public static int howManyYearsToRenovate(bool firstTime, int age)
    {
        if (firstTime)
        {
            return 1;
        }

        if (age < 50)
        {
            return 10;
        }

        if (age < 71)
        {
            return 5;
        }

        return 3;

    }

    public static string calculateStudentPerformance(double note)
    {
        if (note <= 5)
        {
            return "Insufficient";
        }

        if (note <= 6)
        {
            return "Regular";
        }

        if (note <= 7.5)
        {
            return "Good";
        }

        if (note <= 9)
        {
            return "Very good";
        }

        return "Excellent";
    }

}
