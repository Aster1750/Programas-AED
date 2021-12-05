using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Heitor de Pinho Coelho Santos");
		int baseT, alturaT;
		Console.WriteLine("Digite a base do triangulo");
	    baseT = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite a base do triangulo");
		alturaT = int.Parse(Console.ReadLine());
		
		if(baseT < 0 || alturaT < 0){
			Console.WriteLine("Valores inválidos");
		} else{
			Console.WriteLine("A área do triangulo é: "+(baseT*alturaT/2));
		}
	}	
}