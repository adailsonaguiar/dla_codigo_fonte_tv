public static class Day5
{
    public static double getInvestmentValueByYear(int yearQtd, double rateReturnByYear, double value)
    {

        double taxYear = rateReturnByYear / 100;
        double accValue = value;

        for (int i = 0; i < yearQtd; i++)
        {
            accValue = accValue + (accValue * taxYear);

            Console.WriteLine(accValue);
        }

        return Math.Round(accValue, 2);

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

    public static string CheckParkingGateStatus(int status)
    {
        switch (status)
        {
            case 1:
                return "The gate is close";
            case 2:
                return "The gate is open";
            case 3:
                return "The gate is on maintenance";
            default:
                return "Invalid status";
        }
    }

}
