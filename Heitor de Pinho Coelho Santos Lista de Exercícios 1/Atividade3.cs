using System;
					
public class Program
{
	public static void Main()
	{
		int num;
		Console.WriteLine("Digite um número:");
		num = int.Parse(Console.ReadLine());
		
		Console.WriteLine("A raiz quadrada do seu número é: "+Math.Sqrt(num));
	}
}