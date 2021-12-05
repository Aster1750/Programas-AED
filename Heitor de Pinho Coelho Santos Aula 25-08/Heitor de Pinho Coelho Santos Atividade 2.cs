using System;
					
public class Program
{
	public static void Main()
	{
		int num = 0;
		Console.WriteLine("Digite um número:");
		num = int.Parse(Console.ReadLine());

		if ((num < 3) || (num > 25))
		{
			Console.WriteLine("Seu número é menor que três ou maior que 25!");
		}
		else
		{
			Console.WriteLine("Seu número não é menor que três ou maior que 25!");
		}
	}
}