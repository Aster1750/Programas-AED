using System;
					
public class Program
{
	public static void Main()
	{
		int salario;
		Console.WriteLine("Digite seu salário:");
		salario = int.Parse(Console.ReadLine());
		
		Console.WriteLine("O seu salário ajustado é: "+salario * 1.1);
	}
}