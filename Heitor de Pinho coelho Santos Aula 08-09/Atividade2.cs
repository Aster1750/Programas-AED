using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Heitor de Pinho Coelho Santos");
		
		int[] Prova1={0, 0, 0, 0, 0, 0}, Prova2={0, 0, 0, 0, 0, 0};	
		
		int exame=0, aprovado=0, reprovado=0, media=0;
		
		for(int i=0; i<6; i++){
			Console.WriteLine("Aluno "+(i+1)+" digite a nota da sua prova 1");
			Prova1[i] = int.Parse(Console.ReadLine());
			Console.WriteLine("Aluno "+(i+1)+" digite a nota da sua prova 2");
			Prova2[i] = int.Parse(Console.ReadLine());
			if((Prova1[i]+Prova2[i])/2 <= 3){
				Console.WriteLine("Reprovado");
				reprovado++;
			} else if((Prova1[i]+Prova2[i])/2 > 3 && (Prova1[i]+Prova2[i])/2 < 7){
				Console.WriteLine("Exame");
				exame++;
			} else if((Prova1[i]+Prova2[i])/2 > 7){
				Console.WriteLine("Aprovado");
				aprovado++;
			}
			media = media+Prova1[i]+Prova2[i];
		}
		Console.WriteLine(aprovado+" alunos foram aprovados");
		Console.WriteLine(reprovado+" alunos foram reprovados");
		Console.WriteLine(exame+" alunos devem fazer exame");
		Console.WriteLine("A média aritmética da classe é"+(media/12));
	}
}