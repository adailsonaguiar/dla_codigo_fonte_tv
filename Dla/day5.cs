public static class Day5
{
    public static double getInvestmentValueByYear(int yearQtd, double rateReturnByYear, double value)
    {

        double taxYear = rateReturnByYear / 100;
        double accValue = value;

        for (int i = 0; i < yearQtd; i++)
        {
            accValue += (accValue * taxYear);

            Console.WriteLine(accValue);
        }

        return Math.Round(accValue, 2);

    }

    public static int getYearToDoubleValue(double rateReturnByYear, double value)
    {
        bool valueDoubled = false;
        double taxYear = rateReturnByYear / 100;
        double accValue = value;
        int year = 0;

        while (valueDoubled == false)
        {
            accValue += (accValue * taxYear);

            year += 1;

            if (accValue >= (value * 2))
            {
                valueDoubled = true;
            }
        }

        return year;
    }

    public static void getInstallments(int installments, double purchaseValue)
    {
        double accValue = purchaseValue;
        double installmentValue = purchaseValue / installments;

        while (accValue > 0)
        {
            accValue -= installmentValue;
            Console.WriteLine("Valor da parcela:" + installmentValue);
            Console.WriteLine("Valor restante:" + accValue);
        }
    }

}
