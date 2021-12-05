using System;
					
public class Program
{
	public static void Main()
	{
		double baseT, altura;
		Console.WriteLine("Digite o comprimento da base do triângulo");
		baseT = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite a altura do triângulo");
		altura = int.Parse(Console.ReadLine());
		
		Console.WriteLine("A area do triângulo é: "+(baseT*altura)/2);
	}
}