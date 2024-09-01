using System;

class HelloWorld {
    static void Main() {
        int R;
        string L = "", D = "", C = "", T = "", U = "";
        Console.WriteLine("Введите целое число от 1 до 9999:");
        R = int.Parse(Console.ReadLine());

        if (R <= 0 || R > 9999) {
            Console.WriteLine("Введено неверное число");
        } else {
            if (R >= 1000) {
                switch (R / 1000) {
                    case 1: T = "одна тысяча"; break;
                    case 2: T = "две тысячи"; break;
                    case 3: T = "три тысячи"; break;
                    case 4: T = "четыре тысячи"; break;
                    case 5: T = "пять тысяч"; break;
                    case 6: T = "шесть тысяч"; break;
                    case 7: T = "семь тысяч"; break;
                    case 8: T = "восемь тысяч"; break;
                    case 9: T = "девять тысяч"; break;
                    default: break;
                }
                R %= 1000;
            }

            if (R >= 100) {
                switch (R / 100) {
                    case 1: C = "сто"; break;
                    case 2: C = "двести"; break;
                    case 3: C = "триста"; break;
                    case 4: C = "четыреста"; break;
                    case 5: C = "пятьсот"; break;
                    case 6: C = "шестьсот"; break;
                    case 7: C = "семьсот"; break;
                    case 8: C = "восемьсот"; break;
                    case 9: C = "девятьсот"; break;
                    default: break;
                }
                R %= 100;
            }

            if (R >= 10 && R <= 19) {
                switch (R) {
                    case 10: D = "десять"; break;
                    case 11: D = "одиннадцать"; break;
                    case 12: D = "двенадцать"; break;
                    case 13: D = "тринадцать"; break;
                    case 14: D = "четырнадцать"; break;
                    case 15: D = "пятнадцать"; break;
                    case 16: D = "шестнадцать"; break;
                    case 17: D = "семнадцать"; break;
                    case 18: D = "восемнадцать"; break;
                    case 19: D = "девятнадцать"; break;
                    default: break;
                }
            } else {
                if (R >= 20) {
                    switch (R / 10) {
                        case 2: D = "двадцать"; break;
                        case 3: D = "тридцать"; break;
                        case 4: D = "сорок"; break;
                        case 5: D = "пятьдесят"; break;
                        case 6: D = "шестьдесят"; break;
                        case 7: D = "семьдесят"; break;
                        case 8: D = "восемьдесят"; break;
                        case 9: D = "девяносто"; break;
                        default: break;
                    }
                    R %= 10;
                }

                if (R > 0) {
                    U = fun(R);
                }
            }

            L = T + " " + C + " " + D + " " + U;
            Console.WriteLine(L.Trim());
        }
    }

    static string fun(int R) {
        string C = "";
        switch (R) {
            case 1: C = "один"; break;
            case 2: C = "два"; break;
            case 3: C = "три"; break;
            case 4: C = "четыре"; break;
            case 5: C = "пять"; break;
            case 6: C = "шесть"; break;
            case 7: C = "семь"; break;
            case 8: C = "восемь"; break;
            case 9: C = "девять"; break;
            default: break;
        }
        return C;
    }
}


