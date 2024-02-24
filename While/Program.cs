int x = 0, y = 0; // Ustalenie wartości początkowych.
Console.WriteLine("Program oblicza wartość funkcji y = 3*x");
Console.WriteLine("dla x zmieniającego się od 0 do 10.");
Console.WriteLine();
while (x <= 10)
{
    y = 3 * x;
    Console.WriteLine("x = " + x + '\t' + " y = " + y);
    x++;
}