using System;
		
public class Program
{
	public static void Main()
	{
		int num = 0;
		Console.WriteLine("Digite o número de litros:");
		num = int.Parse(Console.ReadLine());

		if (num < 10)
		{
			Console.WriteLine("O seu prêmio é um chaveiro");
		}
		else
		{
			Console.WriteLine("O seu prêmio é uma ducha");
		}
	}
}