using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Heitor de Pinho Coelho Santos");
		double salarioMin, quilowatt;
		int tipo;
		
		Console.WriteLine("Digite o salario minimo");
		salarioMin = Double.Parse(Console.ReadLine());
		Console.WriteLine("Digite a quantia gasta de quilowatts");
		quilowatt = Double.Parse(Console.ReadLine());
		Console.WriteLine("Digite o tipo de consumidor");
		tipo = int.Parse(Console.ReadLine());
		switch(tipo){
			case 1:
				Console.WriteLine("cada quilowatt vale: "+(salarioMin/8));
				Console.WriteLine("O valor a ser pago é: "+((salarioMin/8)*quilowatt)*1.05);
			break;
			
			case 2:
				Console.WriteLine("cada quilowatt vale: "+(salarioMin/8));
				Console.WriteLine("O valor a ser pago é: "+((salarioMin/8)*quilowatt)*1.1);
			break;
				
			case 3:
				Console.WriteLine("cada quilowatt vale: "+(salarioMin/8));
				Console.WriteLine("O valor a ser pago é: "+((salarioMin/8)*quilowatt)*1.15);
			break;
			default:
				Console.WriteLine("Tipo incorreto");
			break;	
		}
		
	}	
}