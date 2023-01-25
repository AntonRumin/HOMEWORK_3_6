/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Тестирование: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
// Функция 1. Запрос и ввод числа 
Console.Clear();

Console.WriteLine ("--- Вычисление координат точки пересечения двух прямых ---");

int GetNumber(string msg)
{
    int result = 0;

    while(true)
    {
        Console.Write(msg);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введено не число. Повторите ввод.");
        }
    }
    return result;
}

double k1 = GetNumber ("Введите угловой коэффициент функции 1 (к1): ");
double b1 = GetNumber ("Введите свободный коэффициент функции 1 (b1): ");
double k2 = GetNumber ("Введите угловой коэффициент функции 2 (к2): ");
double b2 = GetNumber ("Введите свободный коэффициент функции 2 (b2): ");

(double, double) FindCrossPoint (double fk1, double fk2, double fb1, double fb2)
{
 double x = (fb2 - fb1)/(fk1 - fk2);
 double y = fk1 * x + fb1;

return (x, y);
}

double xCrossPoint = 0;
double yCrossPoint = 0;

if (k1 == k2) Console.WriteLine ("Прямые параллельны");
else if (b1 == b2) 
{
    xCrossPoint = 0;
    yCrossPoint = b1;
    Console.WriteLine ($"Координаты точки пересечения ({xCrossPoint}, {yCrossPoint})");
}
else 
{
    (xCrossPoint, yCrossPoint) = FindCrossPoint (k1, k2, b1, b2);
    Console.WriteLine ($"Координаты точки пересечения ({xCrossPoint}, {yCrossPoint})");
}
