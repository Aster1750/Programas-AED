using System;
					
public class Program
{
	public static void Main()
	{
		double quilos;
		Console.WriteLine("Digite o valor em quilos da sua refeição: ");
		
		quilos = Convert.ToDouble(Console.ReadLine());
				
		Console.WriteLine("O valor da refeição é: "+ quilos * 12 +" reais");
	}
}