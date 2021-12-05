using System;
					
public class Program
{
	public static void Main()
	{
		double aulas, faltas, exerc, prova1, prova2, prova3, reavaliacao = 0, menorProva = 0;
		
		Console.WriteLine("digite o total de aulas:");
		aulas = Double.Parse(Console.ReadLine());
		Console.WriteLine("digite o total de faltas:");
		faltas = Double.Parse(Console.ReadLine());
		Console.WriteLine("digite o total de pontos em exércícios(MAX. 25):");
		exerc = Double.Parse(Console.ReadLine());
		Console.WriteLine("digite o total de pontos na Prova1 (MAX. 25):");
		prova1 = Double.Parse(Console.ReadLine());
		Console.WriteLine("digite o total de pontos na Prova2 (MAX. 25):");
		prova2 = Double.Parse(Console.ReadLine());
		Console.WriteLine("digite o total de pontos na Prova3 (MAX. 25):");
		prova3 = Double.Parse(Console.ReadLine());
	
		if(exerc+prova1+prova2+prova3 < 60){
			Console.WriteLine("Sua nota é inferior a 60, então você deve fazer uma avaliação");
			menorProva = Math.Min(prova1, Math.Min(prova2, prova3));
			Console.WriteLine("digite o total de pontos na Reavaliação (MAX. 25):");
			reavaliacao = Double.Parse(Console.ReadLine());
		}
		
		if(aulas*0.75 < faltas){
			
			if(exerc+prova1+prova2+prova3+reavaliacao-menorProva > 60){
					Console.WriteLine("APROVADO");
			} else{
				Console.WriteLine("REPROVADO");
			}
			
		} else{
			Console.WriteLine("REPROVADO");
		}
	}
}