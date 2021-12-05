using System;
					
public class Program
{
	public static void Main()
	{
		int num1, num2, num3, soma, media;
		Console.WriteLine("Digite o primeiro número:");
		num1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite o segundo número:");
		num2 = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite o terceiro número:");
		num3 = int.Parse(Console.ReadLine());
		
		soma = num1 + num2 + num3;
		media = soma/3;
		
		Console.WriteLine("A soma é: "+soma);
		Console.WriteLine("A media é: "+media);
	}
}