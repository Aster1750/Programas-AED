using System;
					
public class Program
{
	public static void Main()
	{
		int num = 0;
		Console.WriteLine("Digite um número:");
		num = int.Parse(Console.ReadLine());

		if (num > 0)
		{
			Console.WriteLine("A raiz quadrada do número é: "+Math.Sqrt(num));
		}
		else
		{
			Console.WriteLine("O número elevado ao quadrado é: "+Math.Pow(num, 2));
		}
	}
}