using System;
					
public class Program
{
	public static void Main()
	{
		double gasolina, litros = 0, valor_pago;
		Console.WriteLine("Digite o preço da gasolina: ");
		
		gasolina = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Digite o valor que será pago: ");
		
		valor_pago = Convert.ToInt32(Console.ReadLine());
		
		litros=(valor_pago)/gasolina;
				
		Console.WriteLine("Litros de gasolina: "+litros);
	}
}