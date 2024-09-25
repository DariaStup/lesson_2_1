Console.WriteLine("Введите пять цифр:");
double[] arr = new double[5];
try
{
    arr[0] = Convert.ToDouble(Console.ReadLine());
    arr[1] = Convert.ToDouble(Console.ReadLine());
    arr[2] = Convert.ToDouble(Console.ReadLine());
    arr[3] = Convert.ToDouble(Console.ReadLine());
    arr[4] = Convert.ToDouble(Console.ReadLine());
}
catch (ArgumentOutOfRangeException ex)
//вне диапазона double
{
    Console.WriteLine(ex.Message);
}
catch (System.FormatException ex)
//ошибка приведения значения к типу double
{
    Console.WriteLine(ex.Message);
}
catch
//все остальные возможные ошибки ввода и приведения
{
    Console.WriteLine("Ошибка! Введены некорректные данные");
}

Console.Write($"{arr[0]}, {arr[1]}, {arr[2]}, {arr[3]}, {arr[4]}");

//вычисляем среднее значение:
double average = ((arr[0] + arr[1] + arr[2] + arr[3] + arr[4]) / arr.Length);
Console.WriteLine();

Console.Write("Среднее значение: ");
Console.Write(average);

