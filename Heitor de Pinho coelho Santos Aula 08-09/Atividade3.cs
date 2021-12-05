using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Heitor de Pinho Coelho Santos");
		int num;
		Console.WriteLine("Digite um número maior que 1:");
		num = int.Parse(Console.ReadLine());
		
		for (int i = 2; i < num; i++ ){
			if (num % i == 0)
			{
				Console.WriteLine("Não é primo!!");
				i = num + 1;
			}
			else
			{
				Console.WriteLine("É primo!!");
				i = num + 1;
			}
		}
	}	
}