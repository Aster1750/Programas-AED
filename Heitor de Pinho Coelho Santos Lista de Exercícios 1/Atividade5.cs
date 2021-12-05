using System;
					
public class Program
{
	public static void Main()
	{
		int nota1, nota2, nota3, peso1, peso2, peso3, mediaP;
		Console.WriteLine("Digite o primeiro número:");
		nota1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite o peso do primeiro número:");
		peso1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite o segundo número:");
		nota2 = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite o peso do segundo número:");
		peso2 = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite o terceiro número:");
		nota3 = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite o peso do terceiro número:");
		peso3 = int.Parse(Console.ReadLine());
		
		mediaP = ((nota1*peso1)+(nota2*peso2)+(nota3*peso3))/(peso1+peso2+peso3);
		
		Console.WriteLine("A média Ponderada é: "+mediaP);
	}
}