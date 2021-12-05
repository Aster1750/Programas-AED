using System;
					
public class Program
{
	public static void Main()
	{
		double deposito, juros;
		Console.WriteLine("digite o valor do depósito");
		deposito = Double.Parse(Console.ReadLine());
		Console.WriteLine("digite o valor dos juros");
		juros = Double.Parse(Console.ReadLine());
		Console.WriteLine("Rendimento: "+deposito*juros/100);
		Console.WriteLine("Valor total mais o rendimento: "+(deposito+deposito*juros/100));
	}
}