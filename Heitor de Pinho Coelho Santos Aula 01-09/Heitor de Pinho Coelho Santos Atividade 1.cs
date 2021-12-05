using System;
					
public class Program
{
	public static void Main()
	{
		int cargo, salario;
		Console.WriteLine("digite o número do seu cargo");
		cargo = int.Parse(Console.ReadLine());
		Console.WriteLine("digite o número do seu salario");
		salario = int.Parse(Console.ReadLine());

		switch (cargo)
    	{
			case 1:
				Console.WriteLine("seu cargo é Escrituário, seu salário aumentou 50% e o novo valor é: "+salario*1.5+" reais");
				break;

			case 2:
				Console.WriteLine("seu cargo é Secretário, seu salário aumentou 35% e o novo valor é: "+salario*1.35+" reais");
				break;
			
			case 3:
				Console.WriteLine("seu cargo é Caixa, seu salário aumentou 20% e o novo valor é: "+salario*1.2+" reais");
				break;
				
			case 4:
				Console.WriteLine("seu cargo é Gerente, seu salário aumentou 10% e o novo valor é: "+salario*1.1+" reais");
				break;
				
			case 5:
				Console.WriteLine("seu cargo é Diretor, seu salário não aumentou e é: "+salario+" reais");	
				break;	
				
			default:
				Console.WriteLine("Cargo não encontrado");
				break;
    	}
	}
}