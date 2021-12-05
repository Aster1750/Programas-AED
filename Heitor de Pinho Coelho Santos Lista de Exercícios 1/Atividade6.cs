using System;
					
public class Program
{
	public static void Main()
	{
		double salario;
		Console.WriteLine("Digite o seu salário:");
		salario = int.Parse(Console.ReadLine());
		
		salario = salario+(salario*0.05)-(salario*0.07);
		
		Console.WriteLine("O salário a receber é: "+salario);
	}
}