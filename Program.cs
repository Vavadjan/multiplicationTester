namespace multiplicationTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Тестер умножения

            Random fN = new Random();
            Random sN = new Random();

            int result;
            int answer = 1;

            for (int i = 0; i >= 0; i++)
            {
                int firstNumber = fN.Next(10);
                int secondNumber = sN.Next(10);

                result = firstNumber * secondNumber;

                Console.WriteLine("Сколько будет " + firstNumber + " * " + secondNumber);

                for (int q = 1; q >= 0 ; q++)
                {
                    answer = Convert.ToInt32(Console.ReadLine());

                    if (answer != result)
                    {
                        Console.WriteLine("Нет! Повторите пожалуйста снова.");
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine("Очень хорошо!");
            }
        }
    }
}