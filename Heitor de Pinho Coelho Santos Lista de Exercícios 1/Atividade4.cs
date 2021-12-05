using System;
					
public class Program
{
	public static void Main()
	{
		int num1, num2, num3, num4, soma;
		Console.WriteLine("Digite o primeiro número:");
		num1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite o segundo número:");
		num2 = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite o terceiro número:");
		num3 = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite o quarto número:");
		num4 = int.Parse(Console.ReadLine());
		soma = num1 + num2 + num3 + num4;
		
		Console.WriteLine("A soma é: "+soma);
	}
}