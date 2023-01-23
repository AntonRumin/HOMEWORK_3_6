/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Тестовые кейсы: 0, 7, 8, -2, -2 -> 2; 1, -7, 567, 89, 223-> 3
*/

Console.Clear ();

// Запрос и ввод данных
Console.Write ("Введите набор из M чисел с разделителем (,) : ");

string set = Console.ReadLine () ?? "";

// Разбиение данных по разделителю (,) и размещение в элементы массива
string[] units = set.Split(',');

// Подсказка Пользователю о количестве внесенных значений
Console.WriteLine($"Введено {units.Length} значений,");

// Проверка элементов введенного массива на число
int [] reservArray = new int [units.Length]; // Резервный массив для чисел

int j = 0;
int count = 0;
int check = 0;
int controlZero = 0;

Console.Write ("в том числе нечисловые значения : ");

for (int i = 0; i<units.Length; i++) // Разделение чисел и нечисел
{
while(true)
{
    if (int.TryParse (units[i], out reservArray[j])) // Заполнение резервного массива
    { 
            j +=1;
            count +=1;
            break;
    }
    else
    {
            Console.Write (units[i] + ",");
            check +=1;
            break;

    }
}
}
Array.Resize (ref reservArray, count); // Сокращение длины резевного массива за счет изъятия нечисел

// Вывод промежуточного результата
Console.WriteLine();

Console.Write ("Набор введенных чисел: ");

foreach (int element in reservArray)
{
    if (element >0 ) controlZero +=1; // Подсчет числа чисел больше 0
    Console.Write($"{element},"); // Вывод на экран массива чисел
}
// Вывод результата
            Console.WriteLine();
            Console.WriteLine($"Среди {units.Length} введенных значений {count} чисел, из них {controlZero} имeют значение больше 0");
        

