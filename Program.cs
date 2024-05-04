//Digite o primeiro número..: 7
//Digite o segundo número...: 15
//O maior número é 15

double primeiro, segundo;

 Console.ForegroundColor = ConsoleColor.Red;
Console.Write("Digite o primeiro número..: ");
primeiro = Convert.ToDouble(Console.ReadLine());
Console.ResetColor();
 
 Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Digite o segundo número...: ");
segundo = Convert.ToDouble(Console.ReadLine());
 Console.ResetColor();
 
if (primeiro > segundo)
{
    Console.WriteLine($"O maior número é {primeiro}");
}
else
{
    Console.WriteLine($"O maior número é {segundo}");
}
