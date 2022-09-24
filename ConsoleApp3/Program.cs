// See https://aka.ms/new-console-template for more information
// кипров павел 22 исп 2/2 задание:Известна стоимость монитора, системного блока, клавиатуры и мыши. Сколько будут стоить 3 компьютера из этих элементов? N компьютеров?
try
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("введие x");//стоимость монитора
    double x = double.Parse(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("введите y");//стоимость системного блока
    double y = double.Parse(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("введите z");//стоимость клавиатуры
    double z = double.Parse(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("введите a");//стоимость мыши
    double a = double.Parse(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("введите n");// кол-во компьютеров
    double n = double.Parse(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.Green;
    double res = (n * (x + y + z + a));
    Console.WriteLine($"{res:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString);
}