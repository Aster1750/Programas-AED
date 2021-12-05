using System;
					
public class Program
{
	public static void Main()
	{
		int a = 0;
		Console.WriteLine("Entre com um numero de tres digitos:");
		a = int.Parse(Console.ReadLine());

		if ((a < 100) || (a > 999))
		{
			Console.WriteLine("### Numero inválido ###");
		}

		else
		{
			Console.WriteLine("O numero {0} apresenta:", a);
			Console.WriteLine("{0} - Centenas", a.ToString().Substring(0, 1));

			Console.WriteLine("{0} - Dezenas", a.ToString().Substring(1, 1));
			Console.WriteLine("{0} - Unidas", a.ToString().Substring(2));
		}
	}
}