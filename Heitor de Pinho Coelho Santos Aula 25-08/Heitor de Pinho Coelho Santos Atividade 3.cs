using System;
					
public class Program
{
	public static void Main()
	{
		int num1 = 0, num2;
		Console.WriteLine("Digite um número:");
		num1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite outro número:");
		num2 = int.Parse(Console.ReadLine());

		if (num1 < num2)
		{
			Console.WriteLine("o quadrado do menor é: "+Math.Pow(num1, 2)+", e a raiz do maior é: "+Math.Sqrt(num2));
		}
		else
		{
			Console.WriteLine("o quadrado do menor é: "+Math.Pow(num2, 2)+", e a raiz do maior é: "+Math.Sqrt(num1));
		}
	}
}