namespace A_six_digit_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите шестизначное число:");
            string inputNumber = Console.ReadLine();

            if (inputNumber.Length != 6)
            {
                Console.WriteLine("Ошибка: введено не шестизначное число");
            }
            else
            {
                Console.WriteLine("Введите номера разрядов для обмена цифр:");
                string inputIndexes = Console.ReadLine();

                int index1, index2;
                if (Int32.TryParse(inputIndexes[0].ToString(), out index1) &&
                    Int32.TryParse(inputIndexes[1].ToString(), out index2))
                {
                    if (index1 < 1 || index1 > 6 || index2 < 1 || index2 > 6)
                    {
                        Console.WriteLine("Ошибка: введены некорректные номера разрядов");
                    }
                    else
                    {
                        char[] digits = inputNumber.ToCharArray();

                        // Обмен значений
                        char temp = digits[index1 - 1];
                        digits[index1 - 1] = digits[index2 - 1];
                        digits[index2 - 1] = temp;

                        string outputNumber = new string(digits);
                        Console.WriteLine("Результат: " + outputNumber);
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: введены некорректные номера разрядов");
                }
            }

            Console.ReadKey();
        }
    }
}
