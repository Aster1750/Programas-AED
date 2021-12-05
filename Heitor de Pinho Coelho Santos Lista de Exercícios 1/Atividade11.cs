using System;
					
public class Program
{
	public static void Main()
	{
		double peso_saco, quantidade_por_gato, quantia5dias;
		Console.WriteLine("Digite o peso do saco de ração(em quilos)");
		peso_saco = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite a quantidade de ração por gato no dia(em gramas)");
		quantidade_por_gato = int.Parse(Console.ReadLine());
		
		quantia5dias = (peso_saco*1000) - (2*quantidade_por_gato*5);
		
		Console.WriteLine("Vão sobrar "+quantia5dias+" gramas de ração após 5 dias");
	}
}