using System;

class Program {
    static void Main() {
        Console.WriteLine("Введите число:");
        int number = int.Parse(Console.ReadLine());
        int sum = SumOfDigits(number);
        Console.WriteLine($"Сумма цифр числа {number} равна {sum}");
    }

    static int SumOfDigits(int number) {
        int sum = 0;
        number = Math.Abs(number); 

        while (number > 0) {
            sum += number % 10;
            number /= 10;
        }

        return sum;
    }
}
