using System;
					
public class Program
{
	public static void Main()
	{
		double num;
		Console.WriteLine("digite um número não inteiro para o programa mostrar a pate inteira");
		num = Double.Parse(Console.ReadLine());
		Console.WriteLine((int)num);
	}
}