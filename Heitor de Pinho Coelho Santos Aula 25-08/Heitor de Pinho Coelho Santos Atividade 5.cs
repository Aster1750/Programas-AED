using System;
					
public class Program
{
	public static void Main()
	{
		int num = 0;
		Console.WriteLine("Digite um número:");
		num = int.Parse(Console.ReadLine());

		if ((num > 20) && (num < 90))
		{
			Console.WriteLine("Seu número está entre 20 e 90!");
		}
		else
		{
			Console.WriteLine("Seu número não está entre 20 e 90!");
		}
	}
}