using System;
					
public class Program
{
	public static void Main()
	{
		int num1 = 0;
		Console.WriteLine("Digite um número:");
		num1 = int.Parse(Console.ReadLine());

		if (num1%2 == 0 && num1 > 0)
		{
			Console.WriteLine("O número digitado é positivo e par ao mesmo tempo");
		}
		else
		{
			Console.WriteLine("O número digitado não é positivo e par ao mesmo tempo");
		}
	}
}