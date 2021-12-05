using System;

public class Program
{
    public static void Main()
    {
		int graus;
		Console.WriteLine("digite a temperatura em graus celsius");
		graus = int.Parse(Console.ReadLine());
		
		graus = (graus * 9/5) + 32;
		
		Console.WriteLine("A temperatura equivalente em fahrenheit é "+graus);
    }
}