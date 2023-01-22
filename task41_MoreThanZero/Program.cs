/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Тестовые кейсы: 0, 7, 8, -2, -2 -> 2; 1, -7, 567, 89, 223-> 3
*/

Console.Clear ();
// Запрос и ввод данных

Console.Write ("Введите набор из M чисел с разделителем (,) : ");

string set = Console.ReadLine () ?? "";
// Разбиение данных по разделителю (,) и размещение в элементы массива

string[] units = set.Split(',');
// Вывод данных массива с новым разделителем

Console.WriteLine($"Введено {units.Length} значений");

// Проверка элементов введенного массива на число

        int count = 0;
        int check = 0;
        int controlZero = 0;
 
        int []tempo = new int [units.Length];

    for (int i = 0; i < units.Length; i++)
        {
            if (int.TryParse (units[i], out tempo[i])) count +=1; 
            else check +=1;
            if (tempo[i]>0) controlZero +=1;
        }

if (check > 0) Console.WriteLine ("Не все введенные значения являются числами");

Console.Write ("Набор введенных чисел: ");

//Array.Resize (ref tempo, count);

foreach (int temp in tempo)
{
    Console.Write($"{temp},");
}

            Console.WriteLine();
            Console.WriteLine($"Среди {units.Length} введенных значений {count} чисел, из них {controlZero} имeют значение больше 0");
        