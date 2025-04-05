string isOdd(int num)
{
    if (num % 2 == 0)
    {
        return $"The number {num} is even";
    }
    return $"The number {num} is odd";
}

Console.WriteLine(isOdd(3));

string getIMC(double weight, double height)
{
    double imc = weight / (height * height);

    if (imc < 18.5) { return "Underweight"; }
    if (imc < 25) { return "Normal"; }
    if (imc < 30) { return "Overweight"; }
    return "Obese";
}

Console.WriteLine(getIMC(76, 1.74));

string calculateGassByDistance(int distance, double gassPrice, int averageConsumption)
{
    int totalUsedGass = distance / averageConsumption;

    string totalCost = string.Format("{0:#.00}", Convert.ToDecimal(totalUsedGass * gassPrice));

    return $"The total used gass is {totalUsedGass} liters and the total cost is R${totalCost}";
}

Console.WriteLine(calculateGassByDistance(60, 6.30, 12));