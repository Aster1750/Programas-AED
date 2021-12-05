using System;
					
public class Program
{
	public static void Main()
	{
		double Raio;
		Console.WriteLine("Digite o comprimento do Raio do círculo");
		Raio = int.Parse(Console.ReadLine());
		
		Console.WriteLine("A area do triângulo é: "+Raio*Raio*3.14);
	}
}