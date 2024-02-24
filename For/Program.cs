int x, y;
Console.WriteLine("Program oblicza wartość funkcji y = 3*x");
Console.WriteLine("dla x zmieniającego się od 0 do 10.");
Console.WriteLine();
for (x = 0; x <= 10; x++)
{
    y = 3 * x;
    Console.WriteLine("x = " + x + '\t' + " y = " + y);
}