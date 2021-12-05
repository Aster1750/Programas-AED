using System;
					
public class Program
{
	public static void Main()
	{
		int num = 0;
		Console.WriteLine("Digite o preço do produto:");
		num = int.Parse(Console.ReadLine());

		if (num < 20)
		{
			Console.WriteLine("O valor da venda do produto é: "+num*1.45);
		}
		else
		{
			Console.WriteLine("O valor da venda do produto é: "+num*1.30);
		}
	}
}