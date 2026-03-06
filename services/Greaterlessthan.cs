namespace AllForOne.services
{
    public class GreaterLessThan
    {
        public string ReturnStatements(double num1, double num2)
        {
            if (num1 > num2)
            {
                return $"{num1} is greater than {num2}. {num2} is less than {num1}.";
            }
            else if (num1 < num2)
            {
                return $"{num1} is less than {num2}. {num2} is greater than {num1}.";
            }

            return $"{num1} is equal to {num2}. {num2} is equal to {num1}.";
        }
    }
}